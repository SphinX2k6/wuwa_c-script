using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001535 RID: 5429
	public class ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06007AC0 RID: 31424 RVA: 0x00124912 File Offset: 0x00122B12
		public static ISurvivorsRougeConditionStepBase Create(ISurvivorsRougeConditionStepBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027F8 RID: 10232
		// (get) Token: 0x06007AC1 RID: 31425 RVA: 0x00124931 File Offset: 0x00122B31
		public virtual ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046B7 RID: 18103
		private ISurvivorsRougeConditionStepBase Instance;
	}
}
