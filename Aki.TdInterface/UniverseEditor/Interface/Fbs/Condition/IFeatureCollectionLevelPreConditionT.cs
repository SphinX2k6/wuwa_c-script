using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005119 RID: 20761
	public class IFeatureCollectionLevelPreConditionT
	{
		// Token: 0x170094CA RID: 38090
		// (get) Token: 0x06020A3B RID: 133691 RVA: 0x00486410 File Offset: 0x00484610
		// (set) Token: 0x06020A3C RID: 133692 RVA: 0x00486418 File Offset: 0x00484618
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x170094CB RID: 38091
		// (get) Token: 0x06020A3D RID: 133693 RVA: 0x00486421 File Offset: 0x00484621
		// (set) Token: 0x06020A3E RID: 133694 RVA: 0x00486429 File Offset: 0x00484629
		public int Id { get; set; }

		// Token: 0x170094CC RID: 38092
		// (get) Token: 0x06020A3F RID: 133695 RVA: 0x00486432 File Offset: 0x00484632
		// (set) Token: 0x06020A40 RID: 133696 RVA: 0x0048643A File Offset: 0x0048463A
		public ECompare Compare { get; set; }

		// Token: 0x170094CD RID: 38093
		// (get) Token: 0x06020A41 RID: 133697 RVA: 0x00486443 File Offset: 0x00484643
		// (set) Token: 0x06020A42 RID: 133698 RVA: 0x0048644B File Offset: 0x0048464B
		public int Level { get; set; }

		// Token: 0x06020A43 RID: 133699 RVA: 0x00486454 File Offset: 0x00484654
		public IFeatureCollectionLevelPreConditionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.Id = 0;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
