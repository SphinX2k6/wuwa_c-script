using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001536 RID: 5430
	public class ISurvivorsRougeConditionStepPrepare : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06007AC3 RID: 31427 RVA: 0x00124946 File Offset: 0x00122B46
		public static ISurvivorsRougeConditionStepPrepare Create(ISurvivorsRougeConditionStepPrepare? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepPrepare
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027F9 RID: 10233
		// (get) Token: 0x06007AC4 RID: 31428 RVA: 0x00124965 File Offset: 0x00122B65
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046B8 RID: 18104
		private ISurvivorsRougeConditionStepPrepare Instance;
	}
}
