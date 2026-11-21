using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043E0 RID: 17376
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeKeyModeGroup : IChangeKeyModeGroup
	{
		// Token: 0x170057E7 RID: 22503
		// (get) Token: 0x0602BE7E RID: 179838 RVA: 0x00C54313 File Offset: 0x00C52513
		// (set) Token: 0x0602BE7F RID: 179839 RVA: 0x00C5431B File Offset: 0x00C5251B
		public string GroupName { get; set; } = "";

		// Token: 0x170057E8 RID: 22504
		// (get) Token: 0x0602BE80 RID: 179840 RVA: 0x00C54324 File Offset: 0x00C52524
		// (set) Token: 0x0602BE81 RID: 179841 RVA: 0x00C5432C File Offset: 0x00C5252C
		public int DefaultKeyModeRowIndex { get; set; }

		// Token: 0x170057E9 RID: 22505
		// (get) Token: 0x0602BE82 RID: 179842 RVA: 0x00C54335 File Offset: 0x00C52535
		// (set) Token: 0x0602BE83 RID: 179843 RVA: 0x00C5433D File Offset: 0x00C5253D
		public IChangeKeyModeRow[] ChangeKeyModeRowList { get; set; } = new IChangeKeyModeRow[0];
	}
}
