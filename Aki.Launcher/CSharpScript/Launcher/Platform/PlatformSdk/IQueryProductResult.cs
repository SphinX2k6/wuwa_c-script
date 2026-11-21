using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000146 RID: 326
	public class IQueryProductResult
	{
		// Token: 0x04000637 RID: 1591
		[Nullable(1)]
		public string FailReason;

		// Token: 0x04000638 RID: 1592
		public bool NeedReLogin;

		// Token: 0x04000639 RID: 1593
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<DisplayProductInfo> DataList;
	}
}
