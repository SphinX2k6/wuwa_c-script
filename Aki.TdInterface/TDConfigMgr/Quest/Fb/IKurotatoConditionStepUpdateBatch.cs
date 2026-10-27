using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013EF RID: 5103
	public class IKurotatoConditionStepUpdateBatch : IKurotatoConditionStepBase
	{
		// Token: 0x06007435 RID: 29749 RVA: 0x00116334 File Offset: 0x00114534
		[NullableContext(1)]
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

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x06007436 RID: 29750 RVA: 0x00116353 File Offset: 0x00114553
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x0400433D RID: 17213
		private IKurotatoConditionStepUpdateBatch Instance;
	}
}
