using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA3 RID: 23203
	public class ITimeScheduleGenerateDynamicEntityT
	{
		// Token: 0x1700AEC7 RID: 44743
		// (get) Token: 0x06027892 RID: 161938 RVA: 0x0057068E File Offset: 0x0056E88E
		// (set) Token: 0x06027893 RID: 161939 RVA: 0x00570696 File Offset: 0x0056E896
		public ITimeScheduleGenerateParamsT GenerateParams { get; set; }

		// Token: 0x1700AEC8 RID: 44744
		// (get) Token: 0x06027894 RID: 161940 RVA: 0x0057069F File Offset: 0x0056E89F
		// (set) Token: 0x06027895 RID: 161941 RVA: 0x005706A7 File Offset: 0x0056E8A7
		public ITimeScheduleEntityTemplateNpcSourceT NpcSource { get; set; }

		// Token: 0x1700AEC9 RID: 44745
		// (get) Token: 0x06027896 RID: 161942 RVA: 0x005706B0 File Offset: 0x0056E8B0
		// (set) Token: 0x06027897 RID: 161943 RVA: 0x005706B8 File Offset: 0x0056E8B8
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x06027898 RID: 161944 RVA: 0x005706C1 File Offset: 0x0056E8C1
		public ITimeScheduleGenerateDynamicEntityT()
		{
			this.GenerateParams = null;
			this.NpcSource = null;
			this.Conditions = null;
		}
	}
}
