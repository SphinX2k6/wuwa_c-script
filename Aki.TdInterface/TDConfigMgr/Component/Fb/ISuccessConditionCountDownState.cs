using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C6D RID: 3181
	public class ISuccessConditionCountDownState : ITargetGearGroupSuccessContdion
	{
		// Token: 0x060048B0 RID: 18608 RVA: 0x000B7B43 File Offset: 0x000B5D43
		public static ISuccessConditionCountDownState Create(ISuccessConditionCountDownState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISuccessConditionCountDownState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x060048B1 RID: 18609 RVA: 0x000B7B62 File Offset: 0x000B5D62
		public override ETargetGearGroupSuccessCondition Type
		{
			get
			{
				return (ETargetGearGroupSuccessCondition)this.Instance.Type;
			}
		}

		// Token: 0x040028DE RID: 10462
		private ISuccessConditionCountDownState Instance;
	}
}
