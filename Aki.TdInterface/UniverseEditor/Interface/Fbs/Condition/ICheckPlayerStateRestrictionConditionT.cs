using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B03 RID: 19203
	public class ICheckPlayerStateRestrictionConditionT
	{
		// Token: 0x17008B4A RID: 35658
		// (get) Token: 0x0601E320 RID: 123680 RVA: 0x0043C071 File Offset: 0x0043A271
		// (set) Token: 0x0601E321 RID: 123681 RVA: 0x0043C079 File Offset: 0x0043A279
		public ECondition Type { get; set; }

		// Token: 0x17008B4B RID: 35659
		// (get) Token: 0x0601E322 RID: 123682 RVA: 0x0043C082 File Offset: 0x0043A282
		// (set) Token: 0x0601E323 RID: 123683 RVA: 0x0043C08A File Offset: 0x0043A28A
		public int RestrictionId { get; set; }

		// Token: 0x17008B4C RID: 35660
		// (get) Token: 0x0601E324 RID: 123684 RVA: 0x0043C093 File Offset: 0x0043A293
		// (set) Token: 0x0601E325 RID: 123685 RVA: 0x0043C09B File Offset: 0x0043A29B
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601E326 RID: 123686 RVA: 0x0043C0A4 File Offset: 0x0043A2A4
		public ICheckPlayerStateRestrictionConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.RestrictionId = 0;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
