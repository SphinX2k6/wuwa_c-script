using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001537 RID: 5431
	public class ISurvivorsRougeConditionStepBattle : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06007AC6 RID: 31430 RVA: 0x0012497A File Offset: 0x00122B7A
		public static ISurvivorsRougeConditionStepBattle Create(ISurvivorsRougeConditionStepBattle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepBattle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027FA RID: 10234
		// (get) Token: 0x06007AC7 RID: 31431 RVA: 0x00124999 File Offset: 0x00122B99
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046B9 RID: 18105
		private ISurvivorsRougeConditionStepBattle Instance;
	}
}
