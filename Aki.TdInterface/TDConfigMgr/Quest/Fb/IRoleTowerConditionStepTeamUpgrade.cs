using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200154C RID: 5452
	public class IRoleTowerConditionStepTeamUpgrade : IRoleTowerConditionStepBase
	{
		// Token: 0x06007B0B RID: 31499 RVA: 0x00124EE2 File Offset: 0x001230E2
		public static IRoleTowerConditionStepTeamUpgrade Create(IRoleTowerConditionStepTeamUpgrade? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepTeamUpgrade
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002815 RID: 10261
		// (get) Token: 0x06007B0C RID: 31500 RVA: 0x00124F01 File Offset: 0x00123101
		public override ERoleTowerConditionStep Type
		{
			get
			{
				return (ERoleTowerConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046DA RID: 18138
		private IRoleTowerConditionStepTeamUpgrade Instance;
	}
}
