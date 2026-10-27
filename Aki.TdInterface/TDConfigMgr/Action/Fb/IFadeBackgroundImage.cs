using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002773 RID: 10099
	[NullableContext(2)]
	[Nullable(0)]
	public class IFadeBackgroundImage : IFadeBackgroundType
	{
		// Token: 0x0600E0E0 RID: 57568 RVA: 0x00213A20 File Offset: 0x00211C20
		[NullableContext(1)]
		public static IFadeBackgroundImage Create(IFadeBackgroundImage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundImage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043BC RID: 17340
		// (get) Token: 0x0600E0E1 RID: 57569 RVA: 0x00213A3F File Offset: 0x00211C3F
		public override EFadeBackgroundType Type
		{
			get
			{
				return (EFadeBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x170043BD RID: 17341
		// (get) Token: 0x0600E0E2 RID: 57570 RVA: 0x00213A4C File Offset: 0x00211C4C
		[Nullable(1)]
		public virtual string BackgroundImage
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.BackgroundImage;
			}
		}

		// Token: 0x170043BE RID: 17342
		// (get) Token: 0x0600E0E3 RID: 57571 RVA: 0x00213A59 File Offset: 0x00211C59
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

		// Token: 0x170043BF RID: 17343
		// (get) Token: 0x0600E0E4 RID: 57572 RVA: 0x00213A8D File Offset: 0x00211C8D
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

		// Token: 0x04007C85 RID: 31877
		private IFadeBackgroundImage Instance;

		// Token: 0x04007C86 RID: 31878
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x04007C87 RID: 31879
		private bool _FadeInEffectInited;

		// Token: 0x04007C88 RID: 31880
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x04007C89 RID: 31881
		private bool _FadeOutEffectInited;
	}
}
