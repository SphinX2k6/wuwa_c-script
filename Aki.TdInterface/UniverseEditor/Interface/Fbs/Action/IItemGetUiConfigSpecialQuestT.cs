using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069C4 RID: 27076
	public class IItemGetUiConfigSpecialQuestT
	{
		// Token: 0x1700C8D1 RID: 51409
		// (get) Token: 0x0602F4F7 RID: 193783 RVA: 0x0067157F File Offset: 0x0066F77F
		// (set) Token: 0x0602F4F8 RID: 193784 RVA: 0x00671587 File Offset: 0x0066F787
		public EItemGetUiType Type { get; set; }

		// Token: 0x1700C8D2 RID: 51410
		// (get) Token: 0x0602F4F9 RID: 193785 RVA: 0x00671590 File Offset: 0x0066F790
		// (set) Token: 0x0602F4FA RID: 193786 RVA: 0x00671598 File Offset: 0x0066F798
		public string Title { get; set; }

		// Token: 0x1700C8D3 RID: 51411
		// (get) Token: 0x0602F4FB RID: 193787 RVA: 0x006715A1 File Offset: 0x0066F7A1
		// (set) Token: 0x0602F4FC RID: 193788 RVA: 0x006715A9 File Offset: 0x0066F7A9
		public bool ShowDetail { get; set; }

		// Token: 0x1700C8D4 RID: 51412
		// (get) Token: 0x0602F4FD RID: 193789 RVA: 0x006715B2 File Offset: 0x0066F7B2
		// (set) Token: 0x0602F4FE RID: 193790 RVA: 0x006715BA File Offset: 0x0066F7BA
		public byte NullMask { get; set; }

		// Token: 0x0602F4FF RID: 193791 RVA: 0x006715C3 File Offset: 0x0066F7C3
		public IItemGetUiConfigSpecialQuestT()
		{
			this.Type = EItemGetUiType.None;
			this.Title = null;
			this.ShowDetail = false;
			this.NullMask = 0;
		}
	}
}
