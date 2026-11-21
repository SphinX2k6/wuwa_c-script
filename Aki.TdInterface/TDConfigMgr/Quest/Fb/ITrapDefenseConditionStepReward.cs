using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200152B RID: 5419
	public class ITrapDefenseConditionStepReward : ITrapDefenseConditionStepBase
	{
		// Token: 0x06007A9B RID: 31387 RVA: 0x001245D0 File Offset: 0x001227D0
		public static ITrapDefenseConditionStepReward Create(ITrapDefenseConditionStepReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027E7 RID: 10215
		// (get) Token: 0x06007A9C RID: 31388 RVA: 0x001245EF File Offset: 0x001227EF
		public override ETrapDefenseConditionStep Type
		{
			get
			{
				return (ETrapDefenseConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046A3 RID: 18083
		private ITrapDefenseConditionStepReward Instance;
	}
}
