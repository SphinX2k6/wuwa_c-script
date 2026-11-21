using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006003 RID: 24579
	public class ISunSpiritCollectComponentT
	{
		// Token: 0x1700B641 RID: 46657
		// (get) Token: 0x060296D2 RID: 169682 RVA: 0x005A78ED File Offset: 0x005A5AED
		// (set) Token: 0x060296D3 RID: 169683 RVA: 0x005A78F5 File Offset: 0x005A5AF5
		public bool Disabled { get; set; }

		// Token: 0x1700B642 RID: 46658
		// (get) Token: 0x060296D4 RID: 169684 RVA: 0x005A78FE File Offset: 0x005A5AFE
		// (set) Token: 0x060296D5 RID: 169685 RVA: 0x005A7906 File Offset: 0x005A5B06
		public int AreaId { get; set; }

		// Token: 0x1700B643 RID: 46659
		// (get) Token: 0x060296D6 RID: 169686 RVA: 0x005A790F File Offset: 0x005A5B0F
		// (set) Token: 0x060296D7 RID: 169687 RVA: 0x005A7917 File Offset: 0x005A5B17
		public float SunSpiritScale { get; set; }

		// Token: 0x1700B644 RID: 46660
		// (get) Token: 0x060296D8 RID: 169688 RVA: 0x005A7920 File Offset: 0x005A5B20
		// (set) Token: 0x060296D9 RID: 169689 RVA: 0x005A7928 File Offset: 0x005A5B28
		public ISunSpiritPlayerBattleConfigT PlayerBattleConfig { get; set; }

		// Token: 0x1700B645 RID: 46661
		// (get) Token: 0x060296DA RID: 169690 RVA: 0x005A7931 File Offset: 0x005A5B31
		// (set) Token: 0x060296DB RID: 169691 RVA: 0x005A7939 File Offset: 0x005A5B39
		public byte NullMask { get; set; }

		// Token: 0x060296DC RID: 169692 RVA: 0x005A7942 File Offset: 0x005A5B42
		public ISunSpiritCollectComponentT()
		{
			this.Disabled = false;
			this.AreaId = 0;
			this.SunSpiritScale = 0f;
			this.PlayerBattleConfig = null;
			this.NullMask = 0;
		}
	}
}
