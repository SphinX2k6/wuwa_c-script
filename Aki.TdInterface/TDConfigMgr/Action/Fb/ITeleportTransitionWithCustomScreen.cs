using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002964 RID: 10596
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportTransitionWithCustomScreen : ITeleportTransitionType
	{
		// Token: 0x0600EB23 RID: 60195 RVA: 0x0022A86C File Offset: 0x00228A6C
		[NullableContext(0)]
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

		// Token: 0x17004509 RID: 17673
		// (get) Token: 0x0600EB24 RID: 60196 RVA: 0x0022A88B File Offset: 0x00228A8B
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x1700450A RID: 17674
		// (get) Token: 0x0600EB25 RID: 60197 RVA: 0x0022A898 File Offset: 0x00228A98
		[Nullable(0)]
		public virtual ICustomScreenTypeBase ScreenType
		{
			[NullableContext(0)]
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

		// Token: 0x1700450B RID: 17675
		// (get) Token: 0x0600EB26 RID: 60198 RVA: 0x0022A8C7 File Offset: 0x00228AC7
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

		// Token: 0x1700450C RID: 17676
		// (get) Token: 0x0600EB27 RID: 60199 RVA: 0x0022A8FB File Offset: 0x00228AFB
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

		// Token: 0x1700450D RID: 17677
		// (get) Token: 0x0600EB28 RID: 60200 RVA: 0x0022A930 File Offset: 0x00228B30
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

		// Token: 0x1700450E RID: 17678
		// (get) Token: 0x0600EB29 RID: 60201 RVA: 0x0022A966 File Offset: 0x00228B66
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

		// Token: 0x1700450F RID: 17679
		// (get) Token: 0x0600EB2A RID: 60202 RVA: 0x0022A99A File Offset: 0x00228B9A
		public virtual string StartAkEvent
		{
			get
			{
				return this.Instance.StartAkEvent;
			}
		}

		// Token: 0x04008184 RID: 33156
		private ITeleportTransitionWithCustomScreen Instance;

		// Token: 0x04008185 RID: 33157
		[Nullable(0)]
		private ICustomScreenTypeBase _ScreenTypeCache;

		// Token: 0x04008186 RID: 33158
		private bool _ScreenTypeInited;

		// Token: 0x04008187 RID: 33159
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x04008188 RID: 33160
		private bool _FadeInEffectInited;

		// Token: 0x04008189 RID: 33161
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x0400818A RID: 33162
		private bool _FadeOutEffectInited;

		// Token: 0x0400818B RID: 33163
		private ICustomShowUi _CustomShowUiCache;

		// Token: 0x0400818C RID: 33164
		private bool _CustomShowUiInited;
	}
}
