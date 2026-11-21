using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200154A RID: 5450
	public class IRoleTowerConditionStepBattle : IRoleTowerConditionStepBase
	{
		// Token: 0x06007B05 RID: 31493 RVA: 0x00124E7A File Offset: 0x0012307A
		public static IRoleTowerConditionStepBattle Create(IRoleTowerConditionStepBattle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepBattle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002813 RID: 10259
		// (get) Token: 0x06007B06 RID: 31494 RVA: 0x00124E99 File Offset: 0x00123099
		public override ERoleTowerConditionStep Type
		{
			get
			{
				return (ERoleTowerConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046D8 RID: 18136
		private IRoleTowerConditionStepBattle Instance;
	}
}
