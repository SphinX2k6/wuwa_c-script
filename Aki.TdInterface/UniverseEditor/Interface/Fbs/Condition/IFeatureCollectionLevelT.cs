using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C23 RID: 19491
	public class IFeatureCollectionLevelT
	{
		// Token: 0x17008D98 RID: 36248
		// (get) Token: 0x0601EE19 RID: 126489 RVA: 0x0045281C File Offset: 0x00450A1C
		// (set) Token: 0x0601EE1A RID: 126490 RVA: 0x00452824 File Offset: 0x00450A24
		public EFormationRoleInfoType Type { get; set; }

		// Token: 0x17008D99 RID: 36249
		// (get) Token: 0x0601EE1B RID: 126491 RVA: 0x0045282D File Offset: 0x00450A2D
		// (set) Token: 0x0601EE1C RID: 126492 RVA: 0x00452835 File Offset: 0x00450A35
		public int Id { get; set; }

		// Token: 0x17008D9A RID: 36250
		// (get) Token: 0x0601EE1D RID: 126493 RVA: 0x0045283E File Offset: 0x00450A3E
		// (set) Token: 0x0601EE1E RID: 126494 RVA: 0x00452846 File Offset: 0x00450A46
		public ECompare Compare { get; set; }

		// Token: 0x17008D9B RID: 36251
		// (get) Token: 0x0601EE1F RID: 126495 RVA: 0x0045284F File Offset: 0x00450A4F
		// (set) Token: 0x0601EE20 RID: 126496 RVA: 0x00452857 File Offset: 0x00450A57
		public int Level { get; set; }

		// Token: 0x0601EE21 RID: 126497 RVA: 0x00452860 File Offset: 0x00450A60
		public IFeatureCollectionLevelT()
		{
			this.Type = EFormationRoleInfoType.RoleLevel;
			this.Id = 0;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
