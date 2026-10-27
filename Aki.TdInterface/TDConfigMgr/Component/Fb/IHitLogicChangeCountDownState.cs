using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B87 RID: 2951
	public class IHitLogicChangeCountDownState : IHitLogicType
	{
		// Token: 0x060043E3 RID: 17379 RVA: 0x000ACBAE File Offset: 0x000AADAE
		[NullableContext(1)]
		public static IHitLogicChangeCountDownState Create(IHitLogicChangeCountDownState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeCountDownState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x060043E4 RID: 17380 RVA: 0x000ACBCD File Offset: 0x000AADCD
		public override EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x04002646 RID: 9798
		private IHitLogicChangeCountDownState Instance;
	}
}
