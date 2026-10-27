using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013ED RID: 5101
	public class IKurotatoConditionStepUpgradeReward : IKurotatoConditionStepBase
	{
		// Token: 0x0600742F RID: 29743 RVA: 0x001162CC File Offset: 0x001144CC
		[NullableContext(1)]
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

		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x06007430 RID: 29744 RVA: 0x001162EB File Offset: 0x001144EB
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x0400433B RID: 17211
		private IKurotatoConditionStepUpgradeReward Instance;
	}
}
