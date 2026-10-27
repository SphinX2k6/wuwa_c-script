using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002777 RID: 10103
	[NullableContext(1)]
	[Nullable(0)]
	public class FadeInScreen : ActionParams
	{
		// Token: 0x0600E0F3 RID: 57587 RVA: 0x00213BC0 File Offset: 0x00211DC0
		public static FadeInScreen Create(IFadeInScreen? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FadeInScreen
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043C7 RID: 17351
		// (get) Token: 0x0600E0F4 RID: 57588 RVA: 0x00213BE0 File Offset: 0x00211DE0
		public virtual EFadeUiOverride? TypeOverride
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EFadeUiOverride?((EFadeUiOverride)this.Instance.TypeOverride);
			}
		}

		// Token: 0x170043C8 RID: 17352
		// (get) Token: 0x0600E0F5 RID: 57589 RVA: 0x00213C16 File Offset: 0x00211E16
		[Nullable(2)]
		public virtual IEaseData Ease
		{
			[NullableContext(2)]
			get
			{
				if (this._EaseInited)
				{
					return this._EaseCache;
				}
				this._EaseInited = true;
				this._EaseCache = IEaseData.Create(this.Instance.Ease);
				return this._EaseCache;
			}
		}

		// Token: 0x170043C9 RID: 17353
		// (get) Token: 0x0600E0F6 RID: 57590 RVA: 0x00213C4C File Offset: 0x00211E4C
		public virtual EFadeInScreenShowType? ScreenType
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new EFadeInScreenShowType?((EFadeInScreenShowType)this.Instance.ScreenType);
			}
		}

		// Token: 0x170043CA RID: 17354
		// (get) Token: 0x0600E0F7 RID: 57591 RVA: 0x00213C84 File Offset: 0x00211E84
		public virtual bool? KeepFadeAfterTreeEnd
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepFadeAfterTreeEnd);
			}
		}

		// Token: 0x170043CB RID: 17355
		// (get) Token: 0x0600E0F8 RID: 57592 RVA: 0x00213CBC File Offset: 0x00211EBC
		public virtual bool? KeepFadeAfterTreeRollBack
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepFadeAfterTreeRollBack);
			}
		}

		// Token: 0x170043CC RID: 17356
		// (get) Token: 0x0600E0F9 RID: 57593 RVA: 0x00213CF2 File Offset: 0x00211EF2
		public virtual IFadeBackgroundType FadeBackground
		{
			get
			{
				if (this._FadeBackgroundInited)
				{
					return this._FadeBackgroundCache;
				}
				this._FadeBackgroundInited = true;
				this._FadeBackgroundCache = ActionReadHelper.ReadFadeInScreen_FadeBackground(this.Instance);
				return this._FadeBackgroundCache;
			}
		}

		// Token: 0x170043CD RID: 17357
		// (get) Token: 0x0600E0FA RID: 57594 RVA: 0x00213D24 File Offset: 0x00211F24
		public virtual bool? OnlyLowMemoryDeviceExecute
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.OnlyLowMemoryDeviceExecute);
			}
		}

		// Token: 0x04007C8F RID: 31887
		private IFadeInScreen Instance;

		// Token: 0x04007C90 RID: 31888
		[Nullable(2)]
		private IEaseData _EaseCache;

		// Token: 0x04007C91 RID: 31889
		private bool _EaseInited;

		// Token: 0x04007C92 RID: 31890
		private IFadeBackgroundType _FadeBackgroundCache;

		// Token: 0x04007C93 RID: 31891
		private bool _FadeBackgroundInited;
	}
}
