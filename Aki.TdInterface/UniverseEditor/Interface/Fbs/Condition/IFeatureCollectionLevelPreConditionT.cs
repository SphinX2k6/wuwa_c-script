using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C26 RID: 19494
	public class IFeatureCollectionLevelPreConditionT
	{
		// Token: 0x17008DA1 RID: 36257
		// (get) Token: 0x0601EE37 RID: 126519 RVA: 0x00452B34 File Offset: 0x00450D34
		// (set) Token: 0x0601EE38 RID: 126520 RVA: 0x00452B3C File Offset: 0x00450D3C
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17008DA2 RID: 36258
		// (get) Token: 0x0601EE39 RID: 126521 RVA: 0x00452B45 File Offset: 0x00450D45
		// (set) Token: 0x0601EE3A RID: 126522 RVA: 0x00452B4D File Offset: 0x00450D4D
		public int Id { get; set; }

		// Token: 0x17008DA3 RID: 36259
		// (get) Token: 0x0601EE3B RID: 126523 RVA: 0x00452B56 File Offset: 0x00450D56
		// (set) Token: 0x0601EE3C RID: 126524 RVA: 0x00452B5E File Offset: 0x00450D5E
		public ECompare Compare { get; set; }

		// Token: 0x17008DA4 RID: 36260
		// (get) Token: 0x0601EE3D RID: 126525 RVA: 0x00452B67 File Offset: 0x00450D67
		// (set) Token: 0x0601EE3E RID: 126526 RVA: 0x00452B6F File Offset: 0x00450D6F
		public int Level { get; set; }

		// Token: 0x0601EE3F RID: 126527 RVA: 0x00452B78 File Offset: 0x00450D78
		public IFeatureCollectionLevelPreConditionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.Id = 0;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
