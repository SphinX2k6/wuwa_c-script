using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B9D RID: 2973
	[NullableContext(1)]
	[Nullable(0)]
	public class ISuccessConditionSameSpecificState : ITargetGearGroupSuccessContdion
	{
		// Token: 0x06004450 RID: 17488 RVA: 0x000ADA0A File Offset: 0x000ABC0A
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

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06004451 RID: 17489 RVA: 0x000ADA29 File Offset: 0x000ABC29
		public override ETargetGearGroupSuccessCondition Type
		{
			get
			{
				return (ETargetGearGroupSuccessCondition)this.Instance.Type;
			}
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x06004452 RID: 17490 RVA: 0x000ADA36 File Offset: 0x000ABC36
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x04002694 RID: 9876
		private ISuccessConditionSameSpecificState Instance;
	}
}
