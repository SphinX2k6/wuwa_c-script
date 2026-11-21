using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A49 RID: 10825
	public class FadeInScreen : ActionParams
	{
		// Token: 0x0600EF11 RID: 61201 RVA: 0x00230954 File Offset: 0x0022EB54
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

		// Token: 0x1700472D RID: 18221
		// (get) Token: 0x0600EF12 RID: 61202 RVA: 0x00230974 File Offset: 0x0022EB74
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

		// Token: 0x1700472E RID: 18222
		// (get) Token: 0x0600EF13 RID: 61203 RVA: 0x002309AA File Offset: 0x0022EBAA
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

		// Token: 0x1700472F RID: 18223
		// (get) Token: 0x0600EF14 RID: 61204 RVA: 0x002309E0 File Offset: 0x0022EBE0
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

		// Token: 0x17004730 RID: 18224
		// (get) Token: 0x0600EF15 RID: 61205 RVA: 0x00230A18 File Offset: 0x0022EC18
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

		// Token: 0x17004731 RID: 18225
		// (get) Token: 0x0600EF16 RID: 61206 RVA: 0x00230A50 File Offset: 0x0022EC50
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

		// Token: 0x17004732 RID: 18226
		// (get) Token: 0x0600EF17 RID: 61207 RVA: 0x00230A86 File Offset: 0x0022EC86
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

		// Token: 0x17004733 RID: 18227
		// (get) Token: 0x0600EF18 RID: 61208 RVA: 0x00230AB8 File Offset: 0x0022ECB8
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

		// Token: 0x04008345 RID: 33605
		private IFadeInScreen Instance;

		// Token: 0x04008346 RID: 33606
		[Nullable(2)]
		private IEaseData _EaseCache;

		// Token: 0x04008347 RID: 33607
		private bool _EaseInited;

		// Token: 0x04008348 RID: 33608
		private IFadeBackgroundType _FadeBackgroundCache;

		// Token: 0x04008349 RID: 33609
		private bool _FadeBackgroundInited;
	}
}
