using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B9E RID: 2974
	public class ISuccessConditionSameArbitraryState : ITargetGearGroupSuccessContdion
	{
		// Token: 0x06004454 RID: 17492 RVA: 0x000ADA4B File Offset: 0x000ABC4B
		[NullableContext(1)]
		public static ISuccessConditionSameArbitraryState Create(ISuccessConditionSameArbitraryState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISuccessConditionSameArbitraryState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x06004455 RID: 17493 RVA: 0x000ADA6A File Offset: 0x000ABC6A
		public override ETargetGearGroupSuccessCondition Type
		{
			get
			{
				return (ETargetGearGroupSuccessCondition)this.Instance.Type;
			}
		}

		// Token: 0x04002695 RID: 9877
		private ISuccessConditionSameArbitraryState Instance;
	}
}
