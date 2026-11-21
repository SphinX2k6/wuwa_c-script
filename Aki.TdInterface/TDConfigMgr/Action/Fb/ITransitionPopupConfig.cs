using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002926 RID: 10534
	public class ITransitionPopupConfig
	{
		// Token: 0x0600EA16 RID: 59926 RVA: 0x00228C14 File Offset: 0x00226E14
		public static ITransitionPopupConfig Create(ITransitionPopupConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004478 RID: 17528
		// (get) Token: 0x0600EA17 RID: 59927 RVA: 0x00228C34 File Offset: 0x00226E34
		public virtual float? Duration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Duration);
			}
		}

		// Token: 0x17004479 RID: 17529
		// (get) Token: 0x0600EA18 RID: 59928 RVA: 0x00228C6A File Offset: 0x00226E6A
		public virtual ITransitionPopupStyle PopupStyle
		{
			get
			{
				if (this._PopupStyleInited)
				{
					return this._PopupStyleCache;
				}
				this._PopupStyleInited = true;
				this._PopupStyleCache = ActionReadHelper.ReadITransitionPopupConfig_PopupStyle(this.Instance);
				return this._PopupStyleCache;
			}
		}

		// Token: 0x04008106 RID: 33030
		private ITransitionPopupConfig Instance;

		// Token: 0x04008107 RID: 33031
		private ITransitionPopupStyle _PopupStyleCache;

		// Token: 0x04008108 RID: 33032
		private bool _PopupStyleInited;
	}
}
