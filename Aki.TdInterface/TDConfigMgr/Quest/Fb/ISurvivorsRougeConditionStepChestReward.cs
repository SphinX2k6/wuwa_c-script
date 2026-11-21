using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001539 RID: 5433
	public class ISurvivorsRougeConditionStepChestReward : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06007ACC RID: 31436 RVA: 0x001249E2 File Offset: 0x00122BE2
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

		// Token: 0x170027FC RID: 10236
		// (get) Token: 0x06007ACD RID: 31437 RVA: 0x00124A01 File Offset: 0x00122C01
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046BB RID: 18107
		private ISurvivorsRougeConditionStepChestReward Instance;
	}
}
