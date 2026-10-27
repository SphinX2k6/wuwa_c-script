using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE8 RID: 10984
	[NullableContext(1)]
	[Nullable(0)]
	public class ResetPlayerPosWithPresentation : ActionParams
	{
		// Token: 0x0600F0BC RID: 61628 RVA: 0x0022F141 File Offset: 0x0022D341
		public static ResetPlayerPosWithPresentation Create(IResetPlayerPosWithPresentation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResetPlayerPosWithPresentation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CAE RID: 19630
		// (get) Token: 0x0600F0BD RID: 61629 RVA: 0x0022F160 File Offset: 0x0022D360
		public virtual IResetPresentationFailure Presentation
		{
			get
			{
				if (this._PresentationInited)
				{
					return this._PresentationCache;
				}
				this._PresentationInited = true;
				this._PresentationCache = IResetPresentationFailure.Create(this.Instance.Presentation);
				return this._PresentationCache;
			}
		}

		// Token: 0x17004CAF RID: 19631
		// (get) Token: 0x0600F0BE RID: 61630 RVA: 0x0022F194 File Offset: 0x0022D394
		public virtual IResetPosType ResetPosConfig
		{
			get
			{
				if (this._ResetPosConfigInited)
				{
					return this._ResetPosConfigCache;
				}
				this._ResetPosConfigInited = true;
				this._ResetPosConfigCache = ActionReadHelper.ReadResetPlayerPosWithPresentation_ResetPosConfig(this.Instance);
				return this._ResetPosConfigCache;
			}
		}

		// Token: 0x17004CB0 RID: 19632
		// (get) Token: 0x0600F0BF RID: 61631 RVA: 0x0022F1C4 File Offset: 0x0022D3C4
		public virtual bool? NeedWaitResetPos
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.NeedWaitResetPos);
			}
		}

		// Token: 0x04008470 RID: 33904
		private IResetPlayerPosWithPresentation Instance;

		// Token: 0x04008471 RID: 33905
		[Nullable(2)]
		private IResetPresentationFailure _PresentationCache;

		// Token: 0x04008472 RID: 33906
		private bool _PresentationInited;

		// Token: 0x04008473 RID: 33907
		private IResetPosType _ResetPosConfigCache;

		// Token: 0x04008474 RID: 33908
		private bool _ResetPosConfigInited;
	}
}
