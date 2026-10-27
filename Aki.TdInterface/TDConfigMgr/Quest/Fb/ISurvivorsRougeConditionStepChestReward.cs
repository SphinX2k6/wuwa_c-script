using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013E2 RID: 5090
	public class ISurvivorsRougeConditionStepChestReward : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x0600740B RID: 29707 RVA: 0x00115FFE File Offset: 0x001141FE
		[NullableContext(1)]
		public static ISurvivorsRougeConditionStepChestReward Create(ISurvivorsRougeConditionStepChestReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepChestReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x0600740C RID: 29708 RVA: 0x0011601D File Offset: 0x0011421D
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x0400432A RID: 17194
		private ISurvivorsRougeConditionStepChestReward Instance;
	}
}
