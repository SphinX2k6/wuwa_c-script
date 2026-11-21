using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001544 RID: 5444
	public class IKurotatoConditionStepUpgradeReward : IKurotatoConditionStepBase
	{
		// Token: 0x06007AF0 RID: 31472 RVA: 0x00124CB0 File Offset: 0x00122EB0
		public static IKurotatoConditionStepUpgradeReward Create(IKurotatoConditionStepUpgradeReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepUpgradeReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700280A RID: 10250
		// (get) Token: 0x06007AF1 RID: 31473 RVA: 0x00124CCF File Offset: 0x00122ECF
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046CC RID: 18124
		private IKurotatoConditionStepUpgradeReward Instance;
	}
}
