using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001546 RID: 5446
	public class IKurotatoConditionStepUpdateBatch : IKurotatoConditionStepBase
	{
		// Token: 0x06007AF6 RID: 31478 RVA: 0x00124D18 File Offset: 0x00122F18
		public static IKurotatoConditionStepUpdateBatch Create(IKurotatoConditionStepUpdateBatch? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepUpdateBatch
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700280C RID: 10252
		// (get) Token: 0x06007AF7 RID: 31479 RVA: 0x00124D37 File Offset: 0x00122F37
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046CE RID: 18126
		private IKurotatoConditionStepUpdateBatch Instance;
	}
}
