using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Wonder.Umshare.RNReactNativeWonderUmshare
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeWonderUmshareModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeWonderUmshareModule"/>.
        /// </summary>
        internal RNReactNativeWonderUmshareModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeWonderUmshare";
            }
        }
    }
}
