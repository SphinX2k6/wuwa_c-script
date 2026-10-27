using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A73 RID: 10867
	public class ICheckFlowLookAtPlayer : ICheckFlowLookAtTarget
	{
		// Token: 0x0600EEEF RID: 61167 RVA: 0x0022C1AA File Offset: 0x0022A3AA
		[NullableContext(1)]
		public static ICheckFlowLookAtPlayer Create(ICheckFlowLookAtPlayer? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckFlowLookAtPlayer
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BCB RID: 19403
		// (get) Token: 0x0600EEF0 RID: 61168 RVA: 0x0022C1C9 File Offset: 0x0022A3C9
		public override ECheckFlowLookAtTargetType Type
		{
			get
			{
				return (ECheckFlowLookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x0400836F RID: 33647
		private ICheckFlowLookAtPlayer Instance;
	}
}
