using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A0C RID: 10764
	public class IGuestOperateUiAnimationType
	{
		// Token: 0x0600ED6B RID: 60779 RVA: 0x00229D46 File Offset: 0x00227F46
		[NullableContext(1)]
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

		// Token: 0x17004B15 RID: 19221
		// (get) Token: 0x0600ED6C RID: 60780 RVA: 0x00229D65 File Offset: 0x00227F65
		public virtual EGuestOperateUiAnimation Type
		{
			get
			{
				return (EGuestOperateUiAnimation)this.Instance.Type;
			}
		}

		// Token: 0x040082B0 RID: 33456
		private IGuestOperateUiAnimationType Instance;
	}
}
