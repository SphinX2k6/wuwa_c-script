using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D79 RID: 11641
	public class IFlowDefineNpcCancelSupportedWalkingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x0600FDF1 RID: 65009 RVA: 0x0024A711 File Offset: 0x00248911
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

		// Token: 0x17004FAD RID: 20397
		// (get) Token: 0x0600FDF2 RID: 65010 RVA: 0x0024A730 File Offset: 0x00248930
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004FAE RID: 20398
		// (get) Token: 0x0600FDF3 RID: 65011 RVA: 0x0024A73D File Offset: 0x0024893D
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x04008AA5 RID: 35493
		private IFlowDefineNpcCancelSupportedWalkingPerform Instance;
	}
}
