using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D77 RID: 11639
	public class IFlowDefineNpcCancelMotorcycleSharingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x0600FDE9 RID: 65001 RVA: 0x0024A68F File Offset: 0x0024888F
		public static IFlowDefineNpcCancelMotorcycleSharingPerform Create(IFlowDefineNpcCancelMotorcycleSharingPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowDefineNpcCancelMotorcycleSharingPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FA9 RID: 20393
		// (get) Token: 0x0600FDEA RID: 65002 RVA: 0x0024A6AE File Offset: 0x002488AE
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004FAA RID: 20394
		// (get) Token: 0x0600FDEB RID: 65003 RVA: 0x0024A6BB File Offset: 0x002488BB
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x04008AA3 RID: 35491
		private IFlowDefineNpcCancelMotorcycleSharingPerform Instance;
	}
}
