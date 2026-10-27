using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013EA RID: 5098
	public class IKurotatoConditionStepEnd : IKurotatoConditionStepBase
	{
		// Token: 0x06007426 RID: 29734 RVA: 0x00116230 File Offset: 0x00114430
		[NullableContext(1)]
		public static IKurotatoConditionStepEnd Create(IKurotatoConditionStepEnd? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepEnd
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x06007427 RID: 29735 RVA: 0x0011624F File Offset: 0x0011444F
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004338 RID: 17208
		private IKurotatoConditionStepEnd Instance;
	}
}
