using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013EE RID: 5102
	public class IKurotatoConditionStepShopping : IKurotatoConditionStepBase
	{
		// Token: 0x06007432 RID: 29746 RVA: 0x00116300 File Offset: 0x00114500
		[NullableContext(1)]
		public static IKurotatoConditionStepShopping Create(IKurotatoConditionStepShopping? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepShopping
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x06007433 RID: 29747 RVA: 0x0011631F File Offset: 0x0011451F
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x0400433C RID: 17212
		private IKurotatoConditionStepShopping Instance;
	}
}
