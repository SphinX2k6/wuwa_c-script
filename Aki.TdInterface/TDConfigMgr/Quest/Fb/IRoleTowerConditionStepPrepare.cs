using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001549 RID: 5449
	public class IRoleTowerConditionStepPrepare : IRoleTowerConditionStepBase
	{
		// Token: 0x06007B02 RID: 31490 RVA: 0x00124E46 File Offset: 0x00123046
		public static IRoleTowerConditionStepPrepare Create(IRoleTowerConditionStepPrepare? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepPrepare
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002812 RID: 10258
		// (get) Token: 0x06007B03 RID: 31491 RVA: 0x00124E65 File Offset: 0x00123065
		public override ERoleTowerConditionStep Type
		{
			get
			{
				return (ERoleTowerConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046D7 RID: 18135
		private IRoleTowerConditionStepPrepare Instance;
	}
}
