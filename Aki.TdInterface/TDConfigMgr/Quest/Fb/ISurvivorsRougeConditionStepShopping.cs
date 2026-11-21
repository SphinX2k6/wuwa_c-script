using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200153C RID: 5436
	public class ISurvivorsRougeConditionStepShopping : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06007AD5 RID: 31445 RVA: 0x00124A7E File Offset: 0x00122C7E
		public static ISurvivorsRougeConditionStepShopping Create(ISurvivorsRougeConditionStepShopping? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepShopping
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027FF RID: 10239
		// (get) Token: 0x06007AD6 RID: 31446 RVA: 0x00124A9D File Offset: 0x00122C9D
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046BE RID: 18110
		private ISurvivorsRougeConditionStepShopping Instance;
	}
}
