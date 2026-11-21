using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D75 RID: 11637
	public class IFlowDefineNpcHandInHandPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x0600FDE1 RID: 64993 RVA: 0x0024A60D File Offset: 0x0024880D
		public static IFlowDefineNpcHandInHandPerform Create(IFlowDefineNpcHandInHandPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowDefineNpcHandInHandPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FA5 RID: 20389
		// (get) Token: 0x0600FDE2 RID: 64994 RVA: 0x0024A62C File Offset: 0x0024882C
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004FA6 RID: 20390
		// (get) Token: 0x0600FDE3 RID: 64995 RVA: 0x0024A639 File Offset: 0x00248839
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x04008AA1 RID: 35489
		private IFlowDefineNpcHandInHandPerform Instance;
	}
}
