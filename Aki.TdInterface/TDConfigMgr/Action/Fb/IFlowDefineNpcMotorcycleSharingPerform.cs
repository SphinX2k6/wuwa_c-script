using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D76 RID: 11638
	public class IFlowDefineNpcMotorcycleSharingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x0600FDE5 RID: 64997 RVA: 0x0024A64E File Offset: 0x0024884E
		public static IFlowDefineNpcMotorcycleSharingPerform Create(IFlowDefineNpcMotorcycleSharingPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowDefineNpcMotorcycleSharingPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FA7 RID: 20391
		// (get) Token: 0x0600FDE6 RID: 64998 RVA: 0x0024A66D File Offset: 0x0024886D
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004FA8 RID: 20392
		// (get) Token: 0x0600FDE7 RID: 64999 RVA: 0x0024A67A File Offset: 0x0024887A
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x04008AA2 RID: 35490
		private IFlowDefineNpcMotorcycleSharingPerform Instance;
	}
}
