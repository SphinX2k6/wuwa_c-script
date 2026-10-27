using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028CC RID: 10444
	[NullableContext(1)]
	[Nullable(0)]
	public class ResetPlayerCameraFocus : ActionParams
	{
		// Token: 0x0600E7F9 RID: 59385 RVA: 0x00220D45 File Offset: 0x0021EF45
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

		// Token: 0x17004823 RID: 18467
		// (get) Token: 0x0600E7FA RID: 59386 RVA: 0x00220D64 File Offset: 0x0021EF64
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

		// Token: 0x17004824 RID: 18468
		// (get) Token: 0x0600E7FB RID: 59387 RVA: 0x00220D93 File Offset: 0x0021EF93
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x17004825 RID: 18469
		// (get) Token: 0x0600E7FC RID: 59388 RVA: 0x00220DA0 File Offset: 0x0021EFA0
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

		// Token: 0x17004826 RID: 18470
		// (get) Token: 0x0600E7FD RID: 59389 RVA: 0x00220DD8 File Offset: 0x0021EFD8
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

		// Token: 0x0400803C RID: 32828
		private IResetPlayerCameraFocus Instance;

		// Token: 0x0400803D RID: 32829
		private IResetPlayerFocusType _ResetTypeCache;

		// Token: 0x0400803E RID: 32830
		private bool _ResetTypeInited;
	}
}
