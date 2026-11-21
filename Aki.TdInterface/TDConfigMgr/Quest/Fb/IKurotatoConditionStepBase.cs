using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200153E RID: 5438
	public class IKurotatoConditionStepBase
	{
		// Token: 0x06007ADE RID: 31454 RVA: 0x00124B78 File Offset: 0x00122D78
		public static IKurotatoConditionStepBase Create(IKurotatoConditionStepBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002804 RID: 10244
		// (get) Token: 0x06007ADF RID: 31455 RVA: 0x00124B97 File Offset: 0x00122D97
		public virtual EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046C6 RID: 18118
		private IKurotatoConditionStepBase Instance;
	}
}
