using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A84 RID: 10884
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowDefineNpcSupportedWalkingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x0600EF37 RID: 61239 RVA: 0x0022C9C4 File Offset: 0x0022ABC4
		public static IFlowDefineNpcSupportedWalkingPerform Create(IFlowDefineNpcSupportedWalkingPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowDefineNpcSupportedWalkingPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BF1 RID: 19441
		// (get) Token: 0x0600EF38 RID: 61240 RVA: 0x0022C9E3 File Offset: 0x0022ABE3
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004BF2 RID: 19442
		// (get) Token: 0x0600EF39 RID: 61241 RVA: 0x0022C9F0 File Offset: 0x0022ABF0
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x040083A0 RID: 33696
		private IFlowDefineNpcSupportedWalkingPerform Instance;
	}
}
