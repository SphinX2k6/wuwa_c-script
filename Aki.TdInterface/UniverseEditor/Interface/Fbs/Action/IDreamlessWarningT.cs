using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200660D RID: 26125
	public class IDreamlessWarningT
	{
		// Token: 0x1700C21D RID: 49693
		// (get) Token: 0x0602D5D1 RID: 185809 RVA: 0x006376DB File Offset: 0x006358DB
		// (set) Token: 0x0602D5D2 RID: 185810 RVA: 0x006376E3 File Offset: 0x006358E3
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C21E RID: 49694
		// (get) Token: 0x0602D5D3 RID: 185811 RVA: 0x006376EC File Offset: 0x006358EC
		// (set) Token: 0x0602D5D4 RID: 185812 RVA: 0x006376F4 File Offset: 0x006358F4
		public string WarningText { get; set; }

		// Token: 0x0602D5D5 RID: 185813 RVA: 0x006376FD File Offset: 0x006358FD
		public IDreamlessWarningT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.WarningText = null;
		}
	}
}
