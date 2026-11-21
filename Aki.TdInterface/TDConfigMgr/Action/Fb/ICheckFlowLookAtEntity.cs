using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D66 RID: 11622
	public class ICheckFlowLookAtEntity : ICheckFlowLookAtTarget
	{
		// Token: 0x0600FDA1 RID: 64929 RVA: 0x00249E75 File Offset: 0x00248075
		public static ICheckFlowLookAtEntity Create(ICheckFlowLookAtEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckFlowLookAtEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F83 RID: 20355
		// (get) Token: 0x0600FDA2 RID: 64930 RVA: 0x00249E94 File Offset: 0x00248094
		public override ECheckFlowLookAtTargetType Type
		{
			get
			{
				return (ECheckFlowLookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004F84 RID: 20356
		// (get) Token: 0x0600FDA3 RID: 64931 RVA: 0x00249EA1 File Offset: 0x002480A1
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04008A72 RID: 35442
		private ICheckFlowLookAtEntity Instance;
	}
}
