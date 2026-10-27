using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection
{
	// Token: 0x020000F3 RID: 243
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixNetworkDetectSelectData : IHotFixNetworkDetectSelectData, IHotFixLayoutData
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x0003CF02 File Offset: 0x0003B102
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x0003CF0A File Offset: 0x0003B10A
		public int? Index { get; set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x0003CF13 File Offset: 0x0003B113
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x0003CF1B File Offset: 0x0003B11B
		public ILoginServersData LoginServersData { get; set; }
	}
}
