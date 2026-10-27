using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013F1 RID: 5105
	public class IRoleTowerConditionStepBase
	{
		// Token: 0x0600743E RID: 29758 RVA: 0x0011642E File Offset: 0x0011462E
		[NullableContext(1)]
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

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x0600743F RID: 29759 RVA: 0x0011644D File Offset: 0x0011464D
		public virtual ERoleTowerConditionStep Type
		{
			get
			{
				return (ERoleTowerConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004345 RID: 17221
		private IRoleTowerConditionStepBase Instance;
	}
}
