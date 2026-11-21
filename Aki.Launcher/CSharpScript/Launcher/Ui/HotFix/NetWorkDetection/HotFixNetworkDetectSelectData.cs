using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection
{
	// Token: 0x020000F7 RID: 247
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixNetworkDetectSelectData : IHotFixNetworkDetectSelectData, IHotFixLayoutData
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x0003F2A2 File Offset: 0x0003D4A2
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x0003F2AA File Offset: 0x0003D4AA
		public int? Index { get; set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x0003F2B3 File Offset: 0x0003D4B3
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x0003F2BB File Offset: 0x0003D4BB
		public ILoginServersData LoginServersData { get; set; }
	}
}
