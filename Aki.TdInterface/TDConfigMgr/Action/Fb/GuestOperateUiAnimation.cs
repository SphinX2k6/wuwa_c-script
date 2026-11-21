using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D00 RID: 11520
	public class GuestOperateUiAnimation : ActionParams
	{
		// Token: 0x0600FC19 RID: 64537 RVA: 0x0024789E File Offset: 0x00245A9E
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

		// Token: 0x17004EC7 RID: 20167
		// (get) Token: 0x0600FC1A RID: 64538 RVA: 0x002478BD File Offset: 0x00245ABD
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

		// Token: 0x040089AC RID: 35244
		private IGuestOperateUiAnimation Instance;

		// Token: 0x040089AD RID: 35245
		private IGuestOperateUiAnimationType _UiAnimationConfigCache;

		// Token: 0x040089AE RID: 35246
		private bool _UiAnimationConfigInited;
	}
}
