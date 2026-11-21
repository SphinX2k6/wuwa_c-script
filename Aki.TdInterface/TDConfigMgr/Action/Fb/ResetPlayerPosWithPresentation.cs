using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DDC RID: 11740
	public class ResetPlayerPosWithPresentation : ActionParams
	{
		// Token: 0x0600FF72 RID: 65394 RVA: 0x0024CE4D File Offset: 0x0024B04D
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

		// Token: 0x17005068 RID: 20584
		// (get) Token: 0x0600FF73 RID: 65395 RVA: 0x0024CE6C File Offset: 0x0024B06C
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

		// Token: 0x17005069 RID: 20585
		// (get) Token: 0x0600FF74 RID: 65396 RVA: 0x0024CEA0 File Offset: 0x0024B0A0
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

		// Token: 0x1700506A RID: 20586
		// (get) Token: 0x0600FF75 RID: 65397 RVA: 0x0024CED0 File Offset: 0x0024B0D0
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

		// Token: 0x04008B74 RID: 35700
		private IResetPlayerPosWithPresentation Instance;

		// Token: 0x04008B75 RID: 35701
		[Nullable(2)]
		private IResetPresentationFailure _PresentationCache;

		// Token: 0x04008B76 RID: 35702
		private bool _PresentationInited;

		// Token: 0x04008B77 RID: 35703
		private IResetPosType _ResetPosConfigCache;

		// Token: 0x04008B78 RID: 35704
		private bool _ResetPosConfigInited;
	}
}
