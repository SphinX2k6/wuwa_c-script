using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A71 RID: 10865
	public class ICheckFlowLookAtTarget
	{
		// Token: 0x0600EEE8 RID: 61160 RVA: 0x0022C135 File Offset: 0x0022A335
		[NullableContext(1)]
		public static ICheckFlowLookAtTarget Create(ICheckFlowLookAtTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckFlowLookAtTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BC8 RID: 19400
		// (get) Token: 0x0600EEE9 RID: 61161 RVA: 0x0022C154 File Offset: 0x0022A354
		public virtual ECheckFlowLookAtTargetType Type
		{
			get
			{
				return (ECheckFlowLookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x0400836D RID: 33645
		private ICheckFlowLookAtTarget Instance;
	}
}
