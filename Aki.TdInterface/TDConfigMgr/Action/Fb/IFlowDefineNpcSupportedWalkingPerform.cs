using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D78 RID: 11640
	public class IFlowDefineNpcSupportedWalkingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x0600FDED RID: 65005 RVA: 0x0024A6D0 File Offset: 0x002488D0
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

		// Token: 0x17004FAB RID: 20395
		// (get) Token: 0x0600FDEE RID: 65006 RVA: 0x0024A6EF File Offset: 0x002488EF
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004FAC RID: 20396
		// (get) Token: 0x0600FDEF RID: 65007 RVA: 0x0024A6FC File Offset: 0x002488FC
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x04008AA4 RID: 35492
		private IFlowDefineNpcSupportedWalkingPerform Instance;
	}
}
