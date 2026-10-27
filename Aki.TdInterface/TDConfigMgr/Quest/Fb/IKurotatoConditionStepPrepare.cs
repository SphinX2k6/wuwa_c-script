using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013E8 RID: 5096
	public class IKurotatoConditionStepPrepare : IKurotatoConditionStepBase
	{
		// Token: 0x06007420 RID: 29728 RVA: 0x001161C8 File Offset: 0x001143C8
		[NullableContext(1)]
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

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x06007421 RID: 29729 RVA: 0x001161E7 File Offset: 0x001143E7
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004336 RID: 17206
		private IKurotatoConditionStepPrepare Instance;
	}
}
