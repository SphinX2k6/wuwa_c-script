using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001538 RID: 5432
	public class ISurvivorsRougeConditionStepEnd : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06007AC9 RID: 31433 RVA: 0x001249AE File Offset: 0x00122BAE
		public static ISurvivorsRougeConditionStepEnd Create(ISurvivorsRougeConditionStepEnd? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepEnd
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027FB RID: 10235
		// (get) Token: 0x06007ACA RID: 31434 RVA: 0x001249CD File Offset: 0x00122BCD
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046BA RID: 18106
		private ISurvivorsRougeConditionStepEnd Instance;
	}
}
