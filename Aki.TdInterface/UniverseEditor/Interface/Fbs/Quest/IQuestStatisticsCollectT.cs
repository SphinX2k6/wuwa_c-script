using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004050 RID: 16464
	public class IQuestStatisticsCollectT
	{
		// Token: 0x170073E8 RID: 29672
		// (get) Token: 0x06017DC0 RID: 97728 RVA: 0x0037171D File Offset: 0x0036F91D
		// (set) Token: 0x06017DC1 RID: 97729 RVA: 0x00371725 File Offset: 0x0036F925
		public EStatisticsEventType Type { get; set; }

		// Token: 0x170073E9 RID: 29673
		// (get) Token: 0x06017DC2 RID: 97730 RVA: 0x0037172E File Offset: 0x0036F92E
		// (set) Token: 0x06017DC3 RID: 97731 RVA: 0x00371736 File Offset: 0x0036F936
		public TVarRefUnion Var { get; set; }

		// Token: 0x170073EA RID: 29674
		// (get) Token: 0x06017DC4 RID: 97732 RVA: 0x0037173F File Offset: 0x0036F93F
		// (set) Token: 0x06017DC5 RID: 97733 RVA: 0x00371747 File Offset: 0x0036F947
		public IStaticEntitiyMatchT EntitiyMatch { get; set; }

		// Token: 0x170073EB RID: 29675
		// (get) Token: 0x06017DC6 RID: 97734 RVA: 0x00371750 File Offset: 0x0036F950
		// (set) Token: 0x06017DC7 RID: 97735 RVA: 0x00371758 File Offset: 0x0036F958
		public bool IsGlobal { get; set; }

		// Token: 0x170073EC RID: 29676
		// (get) Token: 0x06017DC8 RID: 97736 RVA: 0x00371761 File Offset: 0x0036F961
		// (set) Token: 0x06017DC9 RID: 97737 RVA: 0x00371769 File Offset: 0x0036F969
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x170073ED RID: 29677
		// (get) Token: 0x06017DCA RID: 97738 RVA: 0x00371772 File Offset: 0x0036F972
		// (set) Token: 0x06017DCB RID: 97739 RVA: 0x0037177A File Offset: 0x0036F97A
		public byte NullMask { get; set; }

		// Token: 0x06017DCC RID: 97740 RVA: 0x00371783 File Offset: 0x0036F983
		public IQuestStatisticsCollectT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.EntitiyMatch = null;
			this.IsGlobal = false;
			this.OnlinePlayerConditionTargetOption = null;
			this.NullMask = 0;
		}
	}
}
