using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EDA RID: 32474
	public class TFadeBackgroundFadeInEffectUnion
	{
		// Token: 0x1700F25F RID: 62047
		// (get) Token: 0x0603A9A9 RID: 240041 RVA: 0x007E28A4 File Offset: 0x007E0AA4
		// (set) Token: 0x0603A9AA RID: 240042 RVA: 0x007E28AC File Offset: 0x007E0AAC
		public TFadeBackgroundFadeInEffect Type { get; set; }

		// Token: 0x1700F260 RID: 62048
		// (get) Token: 0x0603A9AB RID: 240043 RVA: 0x007E28B5 File Offset: 0x007E0AB5
		// (set) Token: 0x0603A9AC RID: 240044 RVA: 0x007E28BD File Offset: 0x007E0ABD
		public object Value { get; set; }

		// Token: 0x0603A9AD RID: 240045 RVA: 0x007E28C6 File Offset: 0x007E0AC6
		public TFadeBackgroundFadeInEffectUnion()
		{
			this.Type = TFadeBackgroundFadeInEffect.NONE;
			this.Value = null;
		}

		// Token: 0x0603A9AE RID: 240046 RVA: 0x007E28DC File Offset: 0x007E0ADC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A9AF RID: 240047 RVA: 0x007E28EE File Offset: 0x007E0AEE
		public IFadeBackgroundFadeInEffectBlackT AsIFadeBackgroundFadeInEffectBlack()
		{
			return this.As<IFadeBackgroundFadeInEffectBlackT>();
		}

		// Token: 0x0603A9B0 RID: 240048 RVA: 0x007E28F6 File Offset: 0x007E0AF6
		public static TFadeBackgroundFadeInEffectUnion FromIFadeBackgroundFadeInEffectBlack(IFadeBackgroundFadeInEffectBlackT _ifadebackgroundfadeineffectblack)
		{
			return new TFadeBackgroundFadeInEffectUnion
			{
				Type = TFadeBackgroundFadeInEffect.IFadeBackgroundFadeInEffectBlack,
				Value = _ifadebackgroundfadeineffectblack
			};
		}

		// Token: 0x0603A9B1 RID: 240049 RVA: 0x007E290B File Offset: 0x007E0B0B
		public IFadeBackgroundFadeInEffectScreenEffectT AsIFadeBackgroundFadeInEffectScreenEffect()
		{
			return this.As<IFadeBackgroundFadeInEffectScreenEffectT>();
		}

		// Token: 0x0603A9B2 RID: 240050 RVA: 0x007E2913 File Offset: 0x007E0B13
		public static TFadeBackgroundFadeInEffectUnion FromIFadeBackgroundFadeInEffectScreenEffect(IFadeBackgroundFadeInEffectScreenEffectT _ifadebackgroundfadeineffectscreeneffect)
		{
			return new TFadeBackgroundFadeInEffectUnion
			{
				Type = TFadeBackgroundFadeInEffect.IFadeBackgroundFadeInEffectScreenEffect,
				Value = _ifadebackgroundfadeineffectscreeneffect
			};
		}

		// Token: 0x0603A9B3 RID: 240051 RVA: 0x007E2928 File Offset: 0x007E0B28
		public static int Pack(FlatBufferBuilder builder, TFadeBackgroundFadeInEffectUnion _o)
		{
			TFadeBackgroundFadeInEffect type = _o.Type;
			if (type == TFadeBackgroundFadeInEffect.IFadeBackgroundFadeInEffectBlack)
			{
				return IFadeBackgroundFadeInEffectBlack.Pack(builder, _o.AsIFadeBackgroundFadeInEffectBlack()).Value;
			}
			if (type != TFadeBackgroundFadeInEffect.IFadeBackgroundFadeInEffectScreenEffect)
			{
				return 0;
			}
			return IFadeBackgroundFadeInEffectScreenEffect.Pack(builder, _o.AsIFadeBackgroundFadeInEffectScreenEffect()).Value;
		}
	}
}
