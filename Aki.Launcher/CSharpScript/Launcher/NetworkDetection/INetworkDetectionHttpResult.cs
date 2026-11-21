using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.NetworkDetection
{
	// Token: 0x020001B8 RID: 440
	public class INetworkDetectionHttpResult : INetworkDetectionResult
	{
		// Token: 0x040007B6 RID: 1974
		[Nullable(1)]
		public List<IHttpPostResult> Results = new List<IHttpPostResult>();
	}
}
