using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A83 RID: 10883
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowDefineNpcCancelMotorcycleSharingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x0600EF33 RID: 61235 RVA: 0x0022C983 File Offset: 0x0022AB83
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

		// Token: 0x17004BEF RID: 19439
		// (get) Token: 0x0600EF34 RID: 61236 RVA: 0x0022C9A2 File Offset: 0x0022ABA2
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004BF0 RID: 19440
		// (get) Token: 0x0600EF35 RID: 61237 RVA: 0x0022C9AF File Offset: 0x0022ABAF
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x0400839F RID: 33695
		private IFlowDefineNpcCancelMotorcycleSharingPerform Instance;
	}
}
