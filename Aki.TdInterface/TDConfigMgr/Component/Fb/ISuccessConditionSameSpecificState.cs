using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C6B RID: 3179
	public class ISuccessConditionSameSpecificState : ITargetGearGroupSuccessContdion
	{
		// Token: 0x060048A9 RID: 18601 RVA: 0x000B7ACE File Offset: 0x000B5CCE
		public static ISuccessConditionSameSpecificState Create(ISuccessConditionSameSpecificState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISuccessConditionSameSpecificState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x060048AA RID: 18602 RVA: 0x000B7AED File Offset: 0x000B5CED
		public override ETargetGearGroupSuccessCondition Type
		{
			get
			{
				return (ETargetGearGroupSuccessCondition)this.Instance.Type;
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x060048AB RID: 18603 RVA: 0x000B7AFA File Offset: 0x000B5CFA
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x040028DC RID: 10460
		private ISuccessConditionSameSpecificState Instance;
	}
}
