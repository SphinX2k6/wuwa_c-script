using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013F4 RID: 5108
	public class IRoleTowerConditionStepSettle : IRoleTowerConditionStepBase
	{
		// Token: 0x06007447 RID: 29767 RVA: 0x001164CA File Offset: 0x001146CA
		[NullableContext(1)]
		public static IRoleTowerConditionStepSettle Create(IRoleTowerConditionStepSettle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepSettle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002632 RID: 9778
		// (get) Token: 0x06007448 RID: 29768 RVA: 0x001164E9 File Offset: 0x001146E9
		public override ERoleTowerConditionStep Type
		{
			get
			{
				return (ERoleTowerConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004348 RID: 17224
		private IRoleTowerConditionStepSettle Instance;
	}
}
