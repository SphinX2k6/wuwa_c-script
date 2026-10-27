using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000142 RID: 322
	public class IQueryProductResult
	{
		// Token: 0x040005FC RID: 1532
		[Nullable(1)]
		public string FailReason;

		// Token: 0x040005FD RID: 1533
		public bool NeedReLogin;

		// Token: 0x040005FE RID: 1534
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<DisplayProductInfo> DataList;
	}
}
