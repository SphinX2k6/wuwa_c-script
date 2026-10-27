using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A85 RID: 10885
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowDefineNpcCancelSupportedWalkingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x0600EF3B RID: 61243 RVA: 0x0022CA05 File Offset: 0x0022AC05
		public static IFlowDefineNpcCancelSupportedWalkingPerform Create(IFlowDefineNpcCancelSupportedWalkingPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowDefineNpcCancelSupportedWalkingPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BF3 RID: 19443
		// (get) Token: 0x0600EF3C RID: 61244 RVA: 0x0022CA24 File Offset: 0x0022AC24
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004BF4 RID: 19444
		// (get) Token: 0x0600EF3D RID: 61245 RVA: 0x0022CA31 File Offset: 0x0022AC31
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x040083A1 RID: 33697
		private IFlowDefineNpcCancelSupportedWalkingPerform Instance;
	}
}
