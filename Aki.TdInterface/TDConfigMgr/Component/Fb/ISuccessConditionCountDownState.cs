using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B9F RID: 2975
	public class ISuccessConditionCountDownState : ITargetGearGroupSuccessContdion
	{
		// Token: 0x06004457 RID: 17495 RVA: 0x000ADA7F File Offset: 0x000ABC7F
		[NullableContext(1)]
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

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x06004458 RID: 17496 RVA: 0x000ADA9E File Offset: 0x000ABC9E
		public override ETargetGearGroupSuccessCondition Type
		{
			get
			{
				return (ETargetGearGroupSuccessCondition)this.Instance.Type;
			}
		}

		// Token: 0x04002696 RID: 9878
		private ISuccessConditionCountDownState Instance;
	}
}
