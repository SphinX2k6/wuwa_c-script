using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004161 RID: 16737
	public class ICheckConditionGroupQuestConditionT
	{
		// Token: 0x17007164 RID: 29028
		// (get) Token: 0x0601704B RID: 94283 RVA: 0x00348620 File Offset: 0x00346820
		// (set) Token: 0x0601704C RID: 94284 RVA: 0x00348628 File Offset: 0x00346828
		public EChildQuest Type { get; set; }

		// Token: 0x17007165 RID: 29029
		// (get) Token: 0x0601704D RID: 94285 RVA: 0x00348631 File Offset: 0x00346831
		// (set) Token: 0x0601704E RID: 94286 RVA: 0x00348639 File Offset: 0x00346839
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007166 RID: 29030
		// (get) Token: 0x0601704F RID: 94287 RVA: 0x00348642 File Offset: 0x00346842
		// (set) Token: 0x06017050 RID: 94288 RVA: 0x0034864A File Offset: 0x0034684A
		public IConditionGroupT Condition { get; set; }

		// Token: 0x06017051 RID: 94289 RVA: 0x00348653 File Offset: 0x00346853
		public ICheckConditionGroupQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Condition = null;
		}
	}
}
