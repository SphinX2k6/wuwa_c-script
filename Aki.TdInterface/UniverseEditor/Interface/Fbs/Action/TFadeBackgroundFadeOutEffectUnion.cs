using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076CF RID: 30415
	public class TFadeBackgroundFadeOutEffectUnion
	{
		// Token: 0x1700E623 RID: 58915
		// (get) Token: 0x06037500 RID: 226560 RVA: 0x0077E68A File Offset: 0x0077C88A
		// (set) Token: 0x06037501 RID: 226561 RVA: 0x0077E692 File Offset: 0x0077C892
		public TFadeBackgroundFadeOutEffect Type { get; set; }

		// Token: 0x1700E624 RID: 58916
		// (get) Token: 0x06037502 RID: 226562 RVA: 0x0077E69B File Offset: 0x0077C89B
		// (set) Token: 0x06037503 RID: 226563 RVA: 0x0077E6A3 File Offset: 0x0077C8A3
		public object Value { get; set; }

		// Token: 0x06037504 RID: 226564 RVA: 0x0077E6AC File Offset: 0x0077C8AC
		public TFadeBackgroundFadeOutEffectUnion()
		{
			this.Type = TFadeBackgroundFadeOutEffect.NONE;
			this.Value = null;
		}

		// Token: 0x06037505 RID: 226565 RVA: 0x0077E6C2 File Offset: 0x0077C8C2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037506 RID: 226566 RVA: 0x0077E6D4 File Offset: 0x0077C8D4
		public IFadeBackgroundFadeOutEffectBlackT AsIFadeBackgroundFadeOutEffectBlack()
		{
			return this.As<IFadeBackgroundFadeOutEffectBlackT>();
		}

		// Token: 0x06037507 RID: 226567 RVA: 0x0077E6DC File Offset: 0x0077C8DC
		public static TFadeBackgroundFadeOutEffectUnion FromIFadeBackgroundFadeOutEffectBlack(IFadeBackgroundFadeOutEffectBlackT _ifadebackgroundfadeouteffectblack)
		{
			return new TFadeBackgroundFadeOutEffectUnion
			{
				Type = TFadeBackgroundFadeOutEffect.IFadeBackgroundFadeOutEffectBlack,
				Value = _ifadebackgroundfadeouteffectblack
			};
		}

		// Token: 0x06037508 RID: 226568 RVA: 0x0077E6F1 File Offset: 0x0077C8F1
		public IFadeBackgroundFadeOutEffectScreenEffectT AsIFadeBackgroundFadeOutEffectScreenEffect()
		{
			return this.As<IFadeBackgroundFadeOutEffectScreenEffectT>();
		}

		// Token: 0x06037509 RID: 226569 RVA: 0x0077E6F9 File Offset: 0x0077C8F9
		public static TFadeBackgroundFadeOutEffectUnion FromIFadeBackgroundFadeOutEffectScreenEffect(IFadeBackgroundFadeOutEffectScreenEffectT _ifadebackgroundfadeouteffectscreeneffect)
		{
			return new TFadeBackgroundFadeOutEffectUnion
			{
				Type = TFadeBackgroundFadeOutEffect.IFadeBackgroundFadeOutEffectScreenEffect,
				Value = _ifadebackgroundfadeouteffectscreeneffect
			};
		}

		// Token: 0x0603750A RID: 226570 RVA: 0x0077E710 File Offset: 0x0077C910
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
