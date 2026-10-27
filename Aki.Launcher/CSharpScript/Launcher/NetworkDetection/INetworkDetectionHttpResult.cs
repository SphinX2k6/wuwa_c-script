using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.NetworkDetection
{
	// Token: 0x020001B4 RID: 436
	public class INetworkDetectionHttpResult : INetworkDetectionResult
	{
		// Token: 0x04000779 RID: 1913
		[Nullable(1)]
		public List<IHttpPostResult> Results = new List<IHttpPostResult>();
	}
}
