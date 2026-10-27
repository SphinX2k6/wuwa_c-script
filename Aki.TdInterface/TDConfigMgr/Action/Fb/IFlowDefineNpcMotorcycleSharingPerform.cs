using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A82 RID: 10882
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowDefineNpcMotorcycleSharingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x0600EF2F RID: 61231 RVA: 0x0022C942 File Offset: 0x0022AB42
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

		// Token: 0x17004BED RID: 19437
		// (get) Token: 0x0600EF30 RID: 61232 RVA: 0x0022C961 File Offset: 0x0022AB61
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004BEE RID: 19438
		// (get) Token: 0x0600EF31 RID: 61233 RVA: 0x0022C96E File Offset: 0x0022AB6E
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x0400839E RID: 33694
		private IFlowDefineNpcMotorcycleSharingPerform Instance;
	}
}
