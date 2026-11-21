using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001543 RID: 5443
	public class IKurotatoConditionStepChestReward : IKurotatoConditionStepBase
	{
		// Token: 0x06007AED RID: 31469 RVA: 0x00124C7C File Offset: 0x00122E7C
		public static IKurotatoConditionStepChestReward Create(IKurotatoConditionStepChestReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepChestReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002809 RID: 10249
		// (get) Token: 0x06007AEE RID: 31470 RVA: 0x00124C9B File Offset: 0x00122E9B
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046CB RID: 18123
		private IKurotatoConditionStepChestReward Instance;
	}
}
