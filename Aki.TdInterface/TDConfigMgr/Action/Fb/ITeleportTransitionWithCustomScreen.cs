using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026A1 RID: 9889
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportTransitionWithCustomScreen : ITeleportTransitionType
	{
		// Token: 0x0600DD4C RID: 56652 RVA: 0x0020E0CC File Offset: 0x0020C2CC
		[NullableContext(1)]
		public static ITeleportTransitionWithCustomScreen Create(ITeleportTransitionWithCustomScreen? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCustomScreen
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041CC RID: 16844
		// (get) Token: 0x0600DD4D RID: 56653 RVA: 0x0020E0EB File Offset: 0x0020C2EB
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170041CD RID: 16845
		// (get) Token: 0x0600DD4E RID: 56654 RVA: 0x0020E0F8 File Offset: 0x0020C2F8
		[Nullable(1)]
		public virtual ICustomScreenTypeBase ScreenType
		{
			[NullableContext(1)]
			get
			{
				if (this._ScreenTypeInited)
				{
					return this._ScreenTypeCache;
				}
				this._ScreenTypeInited = true;
				this._ScreenTypeCache = ActionReadHelper.ReadITeleportTransitionWithCustomScreen_ScreenType(this.Instance);
				return this._ScreenTypeCache;
			}
		}

		// Token: 0x170041CE RID: 16846
		// (get) Token: 0x0600DD4F RID: 56655 RVA: 0x0020E127 File Offset: 0x0020C327
		public virtual IFadeBackgroundFadeInEffect FadeInEffect
		{
			get
			{
				if (this._FadeInEffectInited)
				{
					return this._FadeInEffectCache;
				}
				this._FadeInEffectInited = true;
				this._FadeInEffectCache = IFadeBackgroundFadeInEffect.Create(this.Instance.FadeInEffect);
				return this._FadeInEffectCache;
			}
		}

		// Token: 0x170041CF RID: 16847
		// (get) Token: 0x0600DD50 RID: 56656 RVA: 0x0020E15B File Offset: 0x0020C35B
		public virtual IFadeBackgroundFadeOutEffect FadeOutEffect
		{
			get
			{
				if (this._FadeOutEffectInited)
				{
					return this._FadeOutEffectCache;
				}
				this._FadeOutEffectInited = true;
				this._FadeOutEffectCache = IFadeBackgroundFadeOutEffect.Create(this.Instance.FadeOutEffect);
				return this._FadeOutEffectCache;
			}
		}

		// Token: 0x170041D0 RID: 16848
		// (get) Token: 0x0600DD51 RID: 56657 RVA: 0x0020E190 File Offset: 0x0020C390
		public virtual float? KeepTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.KeepTime);
			}
		}

		// Token: 0x170041D1 RID: 16849
		// (get) Token: 0x0600DD52 RID: 56658 RVA: 0x0020E1C6 File Offset: 0x0020C3C6
		public virtual ICustomShowUi CustomShowUi
		{
			get
			{
				if (this._CustomShowUiInited)
				{
					return this._CustomShowUiCache;
				}
				this._CustomShowUiInited = true;
				this._CustomShowUiCache = ICustomShowUi.Create(this.Instance.CustomShowUi);
				return this._CustomShowUiCache;
			}
		}

		// Token: 0x170041D2 RID: 16850
		// (get) Token: 0x0600DD53 RID: 56659 RVA: 0x0020E1FA File Offset: 0x0020C3FA
		public virtual string StartAkEvent
		{
			get
			{
				return this.Instance.StartAkEvent;
			}
		}

		// Token: 0x04007AE7 RID: 31463
		private ITeleportTransitionWithCustomScreen Instance;

		// Token: 0x04007AE8 RID: 31464
		[Nullable(1)]
		private ICustomScreenTypeBase _ScreenTypeCache;

		// Token: 0x04007AE9 RID: 31465
		private bool _ScreenTypeInited;

		// Token: 0x04007AEA RID: 31466
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x04007AEB RID: 31467
		private bool _FadeInEffectInited;

		// Token: 0x04007AEC RID: 31468
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x04007AED RID: 31469
		private bool _FadeOutEffectInited;

		// Token: 0x04007AEE RID: 31470
		private ICustomShowUi _CustomShowUiCache;

		// Token: 0x04007AEF RID: 31471
		private bool _CustomShowUiInited;
	}
}
