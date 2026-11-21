using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001548 RID: 5448
	public class IRoleTowerConditionStepBase
	{
		// Token: 0x06007AFF RID: 31487 RVA: 0x00124E12 File Offset: 0x00123012
		public static IRoleTowerConditionStepBase Create(IRoleTowerConditionStepBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002811 RID: 10257
		// (get) Token: 0x06007B00 RID: 31488 RVA: 0x00124E31 File Offset: 0x00123031
		public virtual ERoleTowerConditionStep Type
		{
			get
			{
				return (ERoleTowerConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046D6 RID: 18134
		private IRoleTowerConditionStepBase Instance;
	}
}
