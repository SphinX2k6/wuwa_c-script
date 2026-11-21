using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001541 RID: 5441
	public class IKurotatoConditionStepEnd : IKurotatoConditionStepBase
	{
		// Token: 0x06007AE7 RID: 31463 RVA: 0x00124C14 File Offset: 0x00122E14
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

		// Token: 0x17002807 RID: 10247
		// (get) Token: 0x06007AE8 RID: 31464 RVA: 0x00124C33 File Offset: 0x00122E33
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046C9 RID: 18121
		private IKurotatoConditionStepEnd Instance;
	}
}
