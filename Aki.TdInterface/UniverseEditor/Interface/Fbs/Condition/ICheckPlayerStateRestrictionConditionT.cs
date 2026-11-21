using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FDE RID: 20446
	public class ICheckPlayerStateRestrictionConditionT
	{
		// Token: 0x1700924B RID: 37451
		// (get) Token: 0x0601FE61 RID: 130657 RVA: 0x0046E11D File Offset: 0x0046C31D
		// (set) Token: 0x0601FE62 RID: 130658 RVA: 0x0046E125 File Offset: 0x0046C325
		public ECondition Type { get; set; }

		// Token: 0x1700924C RID: 37452
		// (get) Token: 0x0601FE63 RID: 130659 RVA: 0x0046E12E File Offset: 0x0046C32E
		// (set) Token: 0x0601FE64 RID: 130660 RVA: 0x0046E136 File Offset: 0x0046C336
		public int RestrictionId { get; set; }

		// Token: 0x1700924D RID: 37453
		// (get) Token: 0x0601FE65 RID: 130661 RVA: 0x0046E13F File Offset: 0x0046C33F
		// (set) Token: 0x0601FE66 RID: 130662 RVA: 0x0046E147 File Offset: 0x0046C347
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601FE67 RID: 130663 RVA: 0x0046E150 File Offset: 0x0046C350
		public ICheckPlayerStateRestrictionConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.RestrictionId = 0;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
