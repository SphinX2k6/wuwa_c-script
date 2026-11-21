using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BA1 RID: 11169
	public class ResetPlayerCameraFocus : ActionParams
	{
		// Token: 0x0600F628 RID: 63016 RVA: 0x0023DCC5 File Offset: 0x0023BEC5
		public static ResetPlayerCameraFocus Create(IResetPlayerCameraFocus? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResetPlayerCameraFocus
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B94 RID: 19348
		// (get) Token: 0x0600F629 RID: 63017 RVA: 0x0023DCE4 File Offset: 0x0023BEE4
		public virtual IResetPlayerFocusType ResetType
		{
			get
			{
				if (this._ResetTypeInited)
				{
					return this._ResetTypeCache;
				}
				this._ResetTypeInited = true;
				this._ResetTypeCache = ActionReadHelper.ReadResetPlayerCameraFocus_ResetType(this.Instance);
				return this._ResetTypeCache;
			}
		}

		// Token: 0x17004B95 RID: 19349
		// (get) Token: 0x0600F62A RID: 63018 RVA: 0x0023DD13 File Offset: 0x0023BF13
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x17004B96 RID: 19350
		// (get) Token: 0x0600F62B RID: 63019 RVA: 0x0023DD20 File Offset: 0x0023BF20
		public virtual bool? CannotInterrupt
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.CannotInterrupt);
			}
		}

		// Token: 0x17004B97 RID: 19351
		// (get) Token: 0x0600F62C RID: 63020 RVA: 0x0023DD58 File Offset: 0x0023BF58
		public virtual float? Duration
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Duration);
			}
		}

		// Token: 0x040086FB RID: 34555
		private IResetPlayerCameraFocus Instance;

		// Token: 0x040086FC RID: 34556
		private IResetPlayerFocusType _ResetTypeCache;

		// Token: 0x040086FD RID: 34557
		private bool _ResetTypeInited;
	}
}
