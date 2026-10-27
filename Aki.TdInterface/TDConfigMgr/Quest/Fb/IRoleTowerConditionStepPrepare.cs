using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013F2 RID: 5106
	public class IRoleTowerConditionStepPrepare : IRoleTowerConditionStepBase
	{
		// Token: 0x06007441 RID: 29761 RVA: 0x00116462 File Offset: 0x00114662
		[NullableContext(1)]
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

		// Token: 0x17002630 RID: 9776
		// (get) Token: 0x06007442 RID: 29762 RVA: 0x00116481 File Offset: 0x00114681
		public override ERoleTowerConditionStep Type
		{
			get
			{
				return (ERoleTowerConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004346 RID: 17222
		private IRoleTowerConditionStepPrepare Instance;
	}
}
