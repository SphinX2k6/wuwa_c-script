using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A45 RID: 10821
	[NullableContext(2)]
	[Nullable(0)]
	public class IFadeBackgroundImage : IFadeBackgroundType
	{
		// Token: 0x0600EEFE RID: 61182 RVA: 0x002307B4 File Offset: 0x0022E9B4
		[NullableContext(0)]
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

		// Token: 0x17004722 RID: 18210
		// (get) Token: 0x0600EEFF RID: 61183 RVA: 0x002307D3 File Offset: 0x0022E9D3
		public override EFadeBackgroundType Type
		{
			get
			{
				return (EFadeBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x17004723 RID: 18211
		// (get) Token: 0x0600EF00 RID: 61184 RVA: 0x002307E0 File Offset: 0x0022E9E0
		[Nullable(0)]
		public virtual string BackgroundImage
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.BackgroundImage;
			}
		}

		// Token: 0x17004724 RID: 18212
		// (get) Token: 0x0600EF01 RID: 61185 RVA: 0x002307ED File Offset: 0x0022E9ED
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

		// Token: 0x17004725 RID: 18213
		// (get) Token: 0x0600EF02 RID: 61186 RVA: 0x00230821 File Offset: 0x0022EA21
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

		// Token: 0x0400833B RID: 33595
		private IFadeBackgroundImage Instance;

		// Token: 0x0400833C RID: 33596
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x0400833D RID: 33597
		private bool _FadeInEffectInited;

		// Token: 0x0400833E RID: 33598
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x0400833F RID: 33599
		private bool _FadeOutEffectInited;
	}
}
