using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A44 RID: 10820
	[NullableContext(2)]
	[Nullable(0)]
	public class IFadeBackgroundSpine : IFadeBackgroundType
	{
		// Token: 0x0600EEF8 RID: 61176 RVA: 0x0023070B File Offset: 0x0022E90B
		[NullableContext(0)]
		public static IFadeBackgroundSpine Create(IFadeBackgroundSpine? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundSpine
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700471E RID: 18206
		// (get) Token: 0x0600EEF9 RID: 61177 RVA: 0x0023072A File Offset: 0x0022E92A
		public override EFadeBackgroundType Type
		{
			get
			{
				return (EFadeBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x1700471F RID: 18207
		// (get) Token: 0x0600EEFA RID: 61178 RVA: 0x00230737 File Offset: 0x0022E937
		public virtual int SpineId
		{
			get
			{
				return this.Instance.SpineId;
			}
		}

		// Token: 0x17004720 RID: 18208
		// (get) Token: 0x0600EEFB RID: 61179 RVA: 0x00230744 File Offset: 0x0022E944
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

		// Token: 0x17004721 RID: 18209
		// (get) Token: 0x0600EEFC RID: 61180 RVA: 0x00230778 File Offset: 0x0022E978
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

		// Token: 0x04008336 RID: 33590
		private IFadeBackgroundSpine Instance;

		// Token: 0x04008337 RID: 33591
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x04008338 RID: 33592
		private bool _FadeInEffectInited;

		// Token: 0x04008339 RID: 33593
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x0400833A RID: 33594
		private bool _FadeOutEffectInited;
	}
}
