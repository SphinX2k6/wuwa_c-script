using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001542 RID: 5442
	public class IKurotatoConditionStepSaveRole : IKurotatoConditionStepBase
	{
		// Token: 0x06007AEA RID: 31466 RVA: 0x00124C48 File Offset: 0x00122E48
		public static IKurotatoConditionStepSaveRole Create(IKurotatoConditionStepSaveRole? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepSaveRole
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002808 RID: 10248
		// (get) Token: 0x06007AEB RID: 31467 RVA: 0x00124C67 File Offset: 0x00122E67
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046CA RID: 18122
		private IKurotatoConditionStepSaveRole Instance;
	}
}
