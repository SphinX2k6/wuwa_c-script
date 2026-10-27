using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A72 RID: 10866
	public class ICheckFlowLookAtEntity : ICheckFlowLookAtTarget
	{
		// Token: 0x0600EEEB RID: 61163 RVA: 0x0022C169 File Offset: 0x0022A369
		[NullableContext(1)]
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

		// Token: 0x17004BC9 RID: 19401
		// (get) Token: 0x0600EEEC RID: 61164 RVA: 0x0022C188 File Offset: 0x0022A388
		public override ECheckFlowLookAtTargetType Type
		{
			get
			{
				return (ECheckFlowLookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004BCA RID: 19402
		// (get) Token: 0x0600EEED RID: 61165 RVA: 0x0022C195 File Offset: 0x0022A395
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x0400836E RID: 33646
		private ICheckFlowLookAtEntity Instance;
	}
}
