using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A5F RID: 10847
	public class HideTargetRange : ActionParams
	{
		// Token: 0x0600EF87 RID: 61319 RVA: 0x00231C6C File Offset: 0x0022FE6C
		public static HideTargetRange Create(IHideTargetRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HideTargetRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004777 RID: 18295
		// (get) Token: 0x0600EF88 RID: 61320 RVA: 0x00231C8B File Offset: 0x0022FE8B
		public virtual int RangeEntity
		{
			get
			{
				return this.Instance.RangeEntity;
			}
		}

		// Token: 0x17004778 RID: 18296
		// (get) Token: 0x0600EF89 RID: 61321 RVA: 0x00231C98 File Offset: 0x0022FE98
		public virtual IHideRangeType HideConfig
		{
			get
			{
				if (this._HideConfigInited)
				{
					return this._HideConfigCache;
				}
				this._HideConfigInited = true;
				this._HideConfigCache = ActionReadHelper.ReadHideTargetRange_HideConfig(this.Instance);
				return this._HideConfigCache;
			}
		}

		// Token: 0x17004779 RID: 18297
		// (get) Token: 0x0600EF8A RID: 61322 RVA: 0x00231CC8 File Offset: 0x0022FEC8
		public virtual bool? IsHideSimpleNpc
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsHideSimpleNpc);
			}
		}

		// Token: 0x1700477A RID: 18298
		// (get) Token: 0x0600EF8B RID: 61323 RVA: 0x00231D00 File Offset: 0x0022FF00
		public virtual bool? IsHidePasserByNpc
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsHidePasserByNpc);
			}
		}

		// Token: 0x040083AB RID: 33707
		private IHideTargetRange Instance;

		// Token: 0x040083AC RID: 33708
		private IHideRangeType _HideConfigCache;

		// Token: 0x040083AD RID: 33709
		private bool _HideConfigInited;
	}
}
