using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001545 RID: 5445
	public class IKurotatoConditionStepShopping : IKurotatoConditionStepBase
	{
		// Token: 0x06007AF3 RID: 31475 RVA: 0x00124CE4 File Offset: 0x00122EE4
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

		// Token: 0x1700280B RID: 10251
		// (get) Token: 0x06007AF4 RID: 31476 RVA: 0x00124D03 File Offset: 0x00122F03
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046CD RID: 18125
		private IKurotatoConditionStepShopping Instance;
	}
}
