using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EDD RID: 32477
	public class TFadeBackgroundFadeOutEffectUnion
	{
		// Token: 0x1700F261 RID: 62049
		// (get) Token: 0x0603A9B5 RID: 240053 RVA: 0x007E299E File Offset: 0x007E0B9E
		// (set) Token: 0x0603A9B6 RID: 240054 RVA: 0x007E29A6 File Offset: 0x007E0BA6
		public TFadeBackgroundFadeOutEffect Type { get; set; }

		// Token: 0x1700F262 RID: 62050
		// (get) Token: 0x0603A9B7 RID: 240055 RVA: 0x007E29AF File Offset: 0x007E0BAF
		// (set) Token: 0x0603A9B8 RID: 240056 RVA: 0x007E29B7 File Offset: 0x007E0BB7
		public object Value { get; set; }

		// Token: 0x0603A9B9 RID: 240057 RVA: 0x007E29C0 File Offset: 0x007E0BC0
		public TFadeBackgroundFadeOutEffectUnion()
		{
			this.Type = TFadeBackgroundFadeOutEffect.NONE;
			this.Value = null;
		}

		// Token: 0x0603A9BA RID: 240058 RVA: 0x007E29D6 File Offset: 0x007E0BD6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A9BB RID: 240059 RVA: 0x007E29E8 File Offset: 0x007E0BE8
		public IFadeBackgroundFadeOutEffectBlackT AsIFadeBackgroundFadeOutEffectBlack()
		{
			return this.As<IFadeBackgroundFadeOutEffectBlackT>();
		}

		// Token: 0x0603A9BC RID: 240060 RVA: 0x007E29F0 File Offset: 0x007E0BF0
		public static TFadeBackgroundFadeOutEffectUnion FromIFadeBackgroundFadeOutEffectBlack(IFadeBackgroundFadeOutEffectBlackT _ifadebackgroundfadeouteffectblack)
		{
			return new TFadeBackgroundFadeOutEffectUnion
			{
				Type = TFadeBackgroundFadeOutEffect.IFadeBackgroundFadeOutEffectBlack,
				Value = _ifadebackgroundfadeouteffectblack
			};
		}

		// Token: 0x0603A9BD RID: 240061 RVA: 0x007E2A05 File Offset: 0x007E0C05
		public IFadeBackgroundFadeOutEffectScreenEffectT AsIFadeBackgroundFadeOutEffectScreenEffect()
		{
			return this.As<IFadeBackgroundFadeOutEffectScreenEffectT>();
		}

		// Token: 0x0603A9BE RID: 240062 RVA: 0x007E2A0D File Offset: 0x007E0C0D
		public static TFadeBackgroundFadeOutEffectUnion FromIFadeBackgroundFadeOutEffectScreenEffect(IFadeBackgroundFadeOutEffectScreenEffectT _ifadebackgroundfadeouteffectscreeneffect)
		{
			return new TFadeBackgroundFadeOutEffectUnion
			{
				Type = TFadeBackgroundFadeOutEffect.IFadeBackgroundFadeOutEffectScreenEffect,
				Value = _ifadebackgroundfadeouteffectscreeneffect
			};
		}

		// Token: 0x0603A9BF RID: 240063 RVA: 0x007E2A24 File Offset: 0x007E0C24
		public static int Pack(FlatBufferBuilder builder, TFadeBackgroundFadeOutEffectUnion _o)
		{
			TFadeBackgroundFadeOutEffect type = _o.Type;
			if (type == TFadeBackgroundFadeOutEffect.IFadeBackgroundFadeOutEffectBlack)
			{
				return IFadeBackgroundFadeOutEffectBlack.Pack(builder, _o.AsIFadeBackgroundFadeOutEffectBlack()).Value;
			}
			if (type != TFadeBackgroundFadeOutEffect.IFadeBackgroundFadeOutEffectScreenEffect)
			{
				return 0;
			}
			return IFadeBackgroundFadeOutEffectScreenEffect.Pack(builder, _o.AsIFadeBackgroundFadeOutEffectScreenEffect()).Value;
		}
	}
}
