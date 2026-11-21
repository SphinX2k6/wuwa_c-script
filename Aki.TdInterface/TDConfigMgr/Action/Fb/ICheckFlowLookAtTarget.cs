using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D65 RID: 11621
	public class ICheckFlowLookAtTarget
	{
		// Token: 0x0600FD9E RID: 64926 RVA: 0x00249E41 File Offset: 0x00248041
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

		// Token: 0x17004F82 RID: 20354
		// (get) Token: 0x0600FD9F RID: 64927 RVA: 0x00249E60 File Offset: 0x00248060
		public virtual ECheckFlowLookAtTargetType Type
		{
			get
			{
				return (ECheckFlowLookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04008A71 RID: 35441
		private ICheckFlowLookAtTarget Instance;
	}
}
