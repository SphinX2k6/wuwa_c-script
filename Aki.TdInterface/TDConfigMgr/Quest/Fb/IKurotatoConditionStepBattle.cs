using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013E9 RID: 5097
	public class IKurotatoConditionStepBattle : IKurotatoConditionStepBase
	{
		// Token: 0x06007423 RID: 29731 RVA: 0x001161FC File Offset: 0x001143FC
		[NullableContext(1)]
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

		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x06007424 RID: 29732 RVA: 0x0011621B File Offset: 0x0011441B
		public override EKurotatoConditionStep Type
		{
			get
			{
				return (EKurotatoConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004337 RID: 17207
		private IKurotatoConditionStepBattle Instance;
	}
}
