using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B51 RID: 19281
	public class ICheckTargetSunSpiritCollectedT
	{
		// Token: 0x17008BE2 RID: 35810
		// (get) Token: 0x0601E5DD RID: 124381 RVA: 0x00441375 File Offset: 0x0043F575
		// (set) Token: 0x0601E5DE RID: 124382 RVA: 0x0044137D File Offset: 0x0043F57D
		public ECondition Type { get; set; }

		// Token: 0x17008BE3 RID: 35811
		// (get) Token: 0x0601E5DF RID: 124383 RVA: 0x00441386 File Offset: 0x0043F586
		// (set) Token: 0x0601E5E0 RID: 124384 RVA: 0x0044138E File Offset: 0x0043F58E
		public int DungeonId { get; set; }

		// Token: 0x17008BE4 RID: 35812
		// (get) Token: 0x0601E5E1 RID: 124385 RVA: 0x00441397 File Offset: 0x0043F597
		// (set) Token: 0x0601E5E2 RID: 124386 RVA: 0x0044139F File Offset: 0x0043F59F
		public int SunSpiritEntityId { get; set; }

		// Token: 0x17008BE5 RID: 35813
		// (get) Token: 0x0601E5E3 RID: 124387 RVA: 0x004413A8 File Offset: 0x0043F5A8
		// (set) Token: 0x0601E5E4 RID: 124388 RVA: 0x004413B0 File Offset: 0x0043F5B0
		public bool IsCollected { get; set; }

		// Token: 0x17008BE6 RID: 35814
		// (get) Token: 0x0601E5E5 RID: 124389 RVA: 0x004413B9 File Offset: 0x0043F5B9
		// (set) Token: 0x0601E5E6 RID: 124390 RVA: 0x004413C1 File Offset: 0x0043F5C1
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601E5E7 RID: 124391 RVA: 0x004413CA File Offset: 0x0043F5CA
		public ICheckTargetSunSpiritCollectedT()
		{
			this.Type = ECondition.CompareVar;
			this.DungeonId = 0;
			this.SunSpiritEntityId = 0;
			this.IsCollected = false;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
