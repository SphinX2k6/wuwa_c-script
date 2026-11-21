using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E67 RID: 20071
	public class ICheckCoopRoleCoopLevelT
	{
		// Token: 0x17008F1F RID: 36639
		// (get) Token: 0x0601F147 RID: 127303 RVA: 0x0045662C File Offset: 0x0045482C
		// (set) Token: 0x0601F148 RID: 127304 RVA: 0x00456634 File Offset: 0x00454834
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008F20 RID: 36640
		// (get) Token: 0x0601F149 RID: 127305 RVA: 0x0045663D File Offset: 0x0045483D
		// (set) Token: 0x0601F14A RID: 127306 RVA: 0x00456645 File Offset: 0x00454845
		public int CoopRoleId { get; set; }

		// Token: 0x17008F21 RID: 36641
		// (get) Token: 0x0601F14B RID: 127307 RVA: 0x0045664E File Offset: 0x0045484E
		// (set) Token: 0x0601F14C RID: 127308 RVA: 0x00456656 File Offset: 0x00454856
		public ECompare Compare { get; set; }

		// Token: 0x17008F22 RID: 36642
		// (get) Token: 0x0601F14D RID: 127309 RVA: 0x0045665F File Offset: 0x0045485F
		// (set) Token: 0x0601F14E RID: 127310 RVA: 0x00456667 File Offset: 0x00454867
		public int Level { get; set; }

		// Token: 0x0601F14F RID: 127311 RVA: 0x00456670 File Offset: 0x00454870
		public ICheckCoopRoleCoopLevelT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.CoopRoleId = 0;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
