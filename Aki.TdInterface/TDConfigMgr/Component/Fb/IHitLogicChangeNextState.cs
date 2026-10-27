using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B85 RID: 2949
	public class IHitLogicChangeNextState : IHitLogicType
	{
		// Token: 0x060043DD RID: 17373 RVA: 0x000ACB46 File Offset: 0x000AAD46
		[NullableContext(1)]
		public static IHitLogicChangeNextState Create(IHitLogicChangeNextState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeNextState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x060043DE RID: 17374 RVA: 0x000ACB65 File Offset: 0x000AAD65
		public override EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x04002644 RID: 9796
		private IHitLogicChangeNextState Instance;
	}
}
