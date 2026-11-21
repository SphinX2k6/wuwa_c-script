using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001540 RID: 5440
	public class IKurotatoConditionStepBattle : IKurotatoConditionStepBase
	{
		// Token: 0x06007AE4 RID: 31460 RVA: 0x00124BE0 File Offset: 0x00122DE0
		public static IKurotatoConditionStepBattle Create(IKurotatoConditionStepBattle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepBattle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002806 RID: 10246
		// (get) Token: 0x06007AE5 RID: 31461 RVA: 0x00124BFF File Offset: 0x00122DFF
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046C8 RID: 18120
		private IKurotatoConditionStepBattle Instance;
	}
}
