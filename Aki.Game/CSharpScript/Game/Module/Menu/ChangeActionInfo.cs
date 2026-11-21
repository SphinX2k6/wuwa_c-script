using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043D8 RID: 17368
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeActionInfo : IChangeActionInfo
	{
		// Token: 0x170057D3 RID: 22483
		// (get) Token: 0x0602BE53 RID: 179795 RVA: 0x00C54225 File Offset: 0x00C52425
		// (set) Token: 0x0602BE54 RID: 179796 RVA: 0x00C5422D File Offset: 0x00C5242D
		public EInputControllerType InputControllerType { get; set; }

		// Token: 0x170057D4 RID: 22484
		// (get) Token: 0x0602BE55 RID: 179797 RVA: 0x00C54236 File Offset: 0x00C52436
		// (set) Token: 0x0602BE56 RID: 179798 RVA: 0x00C5423E File Offset: 0x00C5243E
		public KeySettingRowData KeySettingRowData { get; set; }

		// Token: 0x170057D5 RID: 22485
		// (get) Token: 0x0602BE57 RID: 179799 RVA: 0x00C54247 File Offset: 0x00C52447
		// (set) Token: 0x0602BE58 RID: 179800 RVA: 0x00C5424F File Offset: 0x00C5244F
		public Action<bool> OnConfirmCallback { get; set; }
	}
}
