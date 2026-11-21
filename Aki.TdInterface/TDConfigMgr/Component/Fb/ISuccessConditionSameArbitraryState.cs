using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C6C RID: 3180
	public class ISuccessConditionSameArbitraryState : ITargetGearGroupSuccessContdion
	{
		// Token: 0x060048AD RID: 18605 RVA: 0x000B7B0F File Offset: 0x000B5D0F
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

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x060048AE RID: 18606 RVA: 0x000B7B2E File Offset: 0x000B5D2E
		public override ETargetGearGroupSuccessCondition Type
		{
			get
			{
				return (ETargetGearGroupSuccessCondition)this.Instance.Type;
			}
		}

		// Token: 0x040028DD RID: 10461
		private ISuccessConditionSameArbitraryState Instance;
	}
}
