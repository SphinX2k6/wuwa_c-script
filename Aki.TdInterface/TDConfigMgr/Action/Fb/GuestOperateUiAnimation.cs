using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A13 RID: 10771
	[NullableContext(1)]
	[Nullable(0)]
	public class GuestOperateUiAnimation : ActionParams
	{
		// Token: 0x0600ED82 RID: 60802 RVA: 0x00229F1A File Offset: 0x0022811A
		public static GuestOperateUiAnimation Create(IGuestOperateUiAnimation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GuestOperateUiAnimation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B1E RID: 19230
		// (get) Token: 0x0600ED83 RID: 60803 RVA: 0x00229F39 File Offset: 0x00228139
		public virtual IGuestOperateUiAnimationType UiAnimationConfig
		{
			get
			{
				if (this._UiAnimationConfigInited)
				{
					return this._UiAnimationConfigCache;
				}
				this._UiAnimationConfigInited = true;
				this._UiAnimationConfigCache = ActionReadHelper.ReadGuestOperateUiAnimation_UiAnimationConfig(this.Instance);
				return this._UiAnimationConfigCache;
			}
		}

		// Token: 0x040082BB RID: 33467
		private IGuestOperateUiAnimation Instance;

		// Token: 0x040082BC RID: 33468
		private IGuestOperateUiAnimationType _UiAnimationConfigCache;

		// Token: 0x040082BD RID: 33469
		private bool _UiAnimationConfigInited;
	}
}
