using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013EC RID: 5100
	public class IKurotatoConditionStepChestReward : IKurotatoConditionStepBase
	{
		// Token: 0x0600742C RID: 29740 RVA: 0x00116298 File Offset: 0x00114498
		[NullableContext(1)]
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

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x0600742D RID: 29741 RVA: 0x001162B7 File Offset: 0x001144B7
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x0400433A RID: 17210
		private IKurotatoConditionStepChestReward Instance;
	}
}
