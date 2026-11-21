using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CF9 RID: 11513
	public class IGuestOperateUiAnimationType
	{
		// Token: 0x0600FC02 RID: 64514 RVA: 0x002476CA File Offset: 0x002458CA
		public static IGuestOperateUiAnimationType Create(IGuestOperateUiAnimationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGuestOperateUiAnimationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EBE RID: 20158
		// (get) Token: 0x0600FC03 RID: 64515 RVA: 0x002476E9 File Offset: 0x002458E9
		public virtual EGuestOperateUiAnimation Type
		{
			get
			{
				return (EGuestOperateUiAnimation)this.Instance.Type;
			}
		}

		// Token: 0x040089A1 RID: 35233
		private IGuestOperateUiAnimationType Instance;
	}
}
