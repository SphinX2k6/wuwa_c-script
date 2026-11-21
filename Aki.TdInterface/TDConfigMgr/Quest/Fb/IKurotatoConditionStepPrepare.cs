using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200153F RID: 5439
	public class IKurotatoConditionStepPrepare : IKurotatoConditionStepBase
	{
		// Token: 0x06007AE1 RID: 31457 RVA: 0x00124BAC File Offset: 0x00122DAC
		public static IKurotatoConditionStepPrepare Create(IKurotatoConditionStepPrepare? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepPrepare
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002805 RID: 10245
		// (get) Token: 0x06007AE2 RID: 31458 RVA: 0x00124BCB File Offset: 0x00122DCB
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046C7 RID: 18119
		private IKurotatoConditionStepPrepare Instance;
	}
}
