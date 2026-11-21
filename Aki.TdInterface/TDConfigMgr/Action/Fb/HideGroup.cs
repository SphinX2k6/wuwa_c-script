using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A69 RID: 10857
	public class HideGroup : ActionParams
	{
		// Token: 0x0600EFB4 RID: 61364 RVA: 0x00232444 File Offset: 0x00230644
		public static HideGroup Create(IHideGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HideGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004790 RID: 18320
		// (get) Token: 0x0600EFB5 RID: 61365 RVA: 0x00232463 File Offset: 0x00230663
		public virtual string GroupKey
		{
			get
			{
				return this.Instance.GroupKey;
			}
		}

		// Token: 0x17004791 RID: 18321
		// (get) Token: 0x0600EFB6 RID: 61366 RVA: 0x00232470 File Offset: 0x00230670
		public virtual IHideGroupType HideConfig
		{
			get
			{
				if (this._HideConfigInited)
				{
					return this._HideConfigCache;
				}
				this._HideConfigInited = true;
				this._HideConfigCache = ActionReadHelper.ReadHideGroup_HideConfig(this.Instance);
				return this._HideConfigCache;
			}
		}

		// Token: 0x17004792 RID: 18322
		// (get) Token: 0x0600EFB7 RID: 61367 RVA: 0x002324A0 File Offset: 0x002306A0
		public virtual bool? IsHidePasserByNpc
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsHidePasserByNpc);
			}
		}

		// Token: 0x040083CF RID: 33743
		private IHideGroup Instance;

		// Token: 0x040083D0 RID: 33744
		private IHideGroupType _HideConfigCache;

		// Token: 0x040083D1 RID: 33745
		private bool _HideConfigInited;
	}
}
