using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D74 RID: 11636
	public class IFlowDefineNpcGroupPerformType
	{
		// Token: 0x0600FDDE RID: 64990 RVA: 0x0024A5D9 File Offset: 0x002487D9
		public static IFlowDefineNpcGroupPerformType Create(IFlowDefineNpcGroupPerformType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowDefineNpcGroupPerformType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FA4 RID: 20388
		// (get) Token: 0x0600FDDF RID: 64991 RVA: 0x0024A5F8 File Offset: 0x002487F8
		public virtual ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x04008AA0 RID: 35488
		private IFlowDefineNpcGroupPerformType Instance;
	}
}
