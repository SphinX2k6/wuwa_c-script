using System;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AE6 RID: 15078
	public class TowerDefensePhantomDataOwner : ITowerDefensePhantomDataOwner
	{
		// Token: 0x17004F69 RID: 20329
		// (get) Token: 0x06026BCA RID: 158666 RVA: 0x00AD6A04 File Offset: 0x00AD4C04
		// (set) Token: 0x06026BCB RID: 158667 RVA: 0x00AD6A0C File Offset: 0x00AD4C0C
		public long PlayerId { get; set; }

		// Token: 0x17004F6A RID: 20330
		// (get) Token: 0x06026BCC RID: 158668 RVA: 0x00AD6A15 File Offset: 0x00AD4C15
		// (set) Token: 0x06026BCD RID: 158669 RVA: 0x00AD6A1D File Offset: 0x00AD4C1D
		public bool IsSelf { get; set; }

		// Token: 0x17004F6B RID: 20331
		// (get) Token: 0x06026BCE RID: 158670 RVA: 0x00AD6A26 File Offset: 0x00AD4C26
		// (set) Token: 0x06026BCF RID: 158671 RVA: 0x00AD6A2E File Offset: 0x00AD4C2E
		public int RoleCfgId { get; set; }

		// Token: 0x17004F6C RID: 20332
		// (get) Token: 0x06026BD0 RID: 158672 RVA: 0x00AD6A37 File Offset: 0x00AD4C37
		// (set) Token: 0x06026BD1 RID: 158673 RVA: 0x00AD6A3F File Offset: 0x00AD4C3F
		public int RoleSkinId { get; set; }

		// Token: 0x17004F6D RID: 20333
		// (get) Token: 0x06026BD2 RID: 158674 RVA: 0x00AD6A48 File Offset: 0x00AD4C48
		// (set) Token: 0x06026BD3 RID: 158675 RVA: 0x00AD6A50 File Offset: 0x00AD4C50
		public int PhantomId { get; set; }
	}
}
