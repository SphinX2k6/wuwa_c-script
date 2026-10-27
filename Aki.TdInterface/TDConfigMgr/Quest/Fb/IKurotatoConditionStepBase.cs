using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013E7 RID: 5095
	public class IKurotatoConditionStepBase
	{
		// Token: 0x0600741D RID: 29725 RVA: 0x00116194 File Offset: 0x00114394
		[NullableContext(1)]
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

		// Token: 0x17002622 RID: 9762
		// (get) Token: 0x0600741E RID: 29726 RVA: 0x001161B3 File Offset: 0x001143B3
		public virtual EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004335 RID: 17205
		private IKurotatoConditionStepBase Instance;
	}
}
