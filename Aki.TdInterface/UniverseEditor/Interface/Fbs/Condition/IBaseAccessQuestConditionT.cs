using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200496E RID: 18798
	public class IBaseAccessQuestConditionT
	{
		// Token: 0x170087CD RID: 34765
		// (get) Token: 0x0601D4C6 RID: 120006 RVA: 0x00422006 File Offset: 0x00420206
		// (set) Token: 0x0601D4C7 RID: 120007 RVA: 0x0042200E File Offset: 0x0042020E
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x0601D4C8 RID: 120008 RVA: 0x00422017 File Offset: 0x00420217
		public IBaseAccessQuestConditionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
		}
	}
}
