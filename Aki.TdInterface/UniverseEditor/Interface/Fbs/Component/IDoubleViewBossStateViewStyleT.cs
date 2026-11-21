using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005617 RID: 22039
	public class IDoubleViewBossStateViewStyleT
	{
		// Token: 0x17009E11 RID: 40465
		// (get) Token: 0x06023263 RID: 143971 RVA: 0x004D67C1 File Offset: 0x004D49C1
		// (set) Token: 0x06023264 RID: 143972 RVA: 0x004D67C9 File Offset: 0x004D49C9
		public EBossStateViewStyle Type { get; set; }

		// Token: 0x17009E12 RID: 40466
		// (get) Token: 0x06023265 RID: 143973 RVA: 0x004D67D2 File Offset: 0x004D49D2
		// (set) Token: 0x06023266 RID: 143974 RVA: 0x004D67DA File Offset: 0x004D49DA
		public EDoubleViewSlot Slot { get; set; }

		// Token: 0x17009E13 RID: 40467
		// (get) Token: 0x06023267 RID: 143975 RVA: 0x004D67E3 File Offset: 0x004D49E3
		// (set) Token: 0x06023268 RID: 143976 RVA: 0x004D67EB File Offset: 0x004D49EB
		public IMarkMainStateTextTargetT MainStateTextTarget { get; set; }

		// Token: 0x17009E14 RID: 40468
		// (get) Token: 0x06023269 RID: 143977 RVA: 0x004D67F4 File Offset: 0x004D49F4
		// (set) Token: 0x0602326A RID: 143978 RVA: 0x004D67FC File Offset: 0x004D49FC
		public int BindMonsterEntityId { get; set; }

		// Token: 0x17009E15 RID: 40469
		// (get) Token: 0x0602326B RID: 143979 RVA: 0x004D6805 File Offset: 0x004D4A05
		// (set) Token: 0x0602326C RID: 143980 RVA: 0x004D680D File Offset: 0x004D4A0D
		public byte NullMask { get; set; }

		// Token: 0x0602326D RID: 143981 RVA: 0x004D6816 File Offset: 0x004D4A16
		public IDoubleViewBossStateViewStyleT()
		{
			this.Type = EBossStateViewStyle.DoubleView;
			this.Slot = EDoubleViewSlot.Left;
			this.MainStateTextTarget = null;
			this.BindMonsterEntityId = 0;
			this.NullMask = 0;
		}
	}
}
