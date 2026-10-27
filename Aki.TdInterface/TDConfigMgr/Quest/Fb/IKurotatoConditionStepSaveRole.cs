using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013EB RID: 5099
	public class IKurotatoConditionStepSaveRole : IKurotatoConditionStepBase
	{
		// Token: 0x06007429 RID: 29737 RVA: 0x00116264 File Offset: 0x00114464
		[NullableContext(1)]
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

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x0600742A RID: 29738 RVA: 0x00116283 File Offset: 0x00114483
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004339 RID: 17209
		private IKurotatoConditionStepSaveRole Instance;
	}
}
