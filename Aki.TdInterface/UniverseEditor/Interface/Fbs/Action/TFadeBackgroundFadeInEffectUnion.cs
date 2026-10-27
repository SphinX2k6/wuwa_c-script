using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076CC RID: 30412
	public class TFadeBackgroundFadeInEffectUnion
	{
		// Token: 0x1700E621 RID: 58913
		// (get) Token: 0x060374F4 RID: 226548 RVA: 0x0077E590 File Offset: 0x0077C790
		// (set) Token: 0x060374F5 RID: 226549 RVA: 0x0077E598 File Offset: 0x0077C798
		public TFadeBackgroundFadeInEffect Type { get; set; }

		// Token: 0x1700E622 RID: 58914
		// (get) Token: 0x060374F6 RID: 226550 RVA: 0x0077E5A1 File Offset: 0x0077C7A1
		// (set) Token: 0x060374F7 RID: 226551 RVA: 0x0077E5A9 File Offset: 0x0077C7A9
		public object Value { get; set; }

		// Token: 0x060374F8 RID: 226552 RVA: 0x0077E5B2 File Offset: 0x0077C7B2
		public TFadeBackgroundFadeInEffectUnion()
		{
			this.Type = TFadeBackgroundFadeInEffect.NONE;
			this.Value = null;
		}

		// Token: 0x060374F9 RID: 226553 RVA: 0x0077E5C8 File Offset: 0x0077C7C8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060374FA RID: 226554 RVA: 0x0077E5DA File Offset: 0x0077C7DA
		public IFadeBackgroundFadeInEffectBlackT AsIFadeBackgroundFadeInEffectBlack()
		{
			return this.As<IFadeBackgroundFadeInEffectBlackT>();
		}

		// Token: 0x060374FB RID: 226555 RVA: 0x0077E5E2 File Offset: 0x0077C7E2
		public static TFadeBackgroundFadeInEffectUnion FromIFadeBackgroundFadeInEffectBlack(IFadeBackgroundFadeInEffectBlackT _ifadebackgroundfadeineffectblack)
		{
			return new TFadeBackgroundFadeInEffectUnion
			{
				Type = TFadeBackgroundFadeInEffect.IFadeBackgroundFadeInEffectBlack,
				Value = _ifadebackgroundfadeineffectblack
			};
		}

		// Token: 0x060374FC RID: 226556 RVA: 0x0077E5F7 File Offset: 0x0077C7F7
		public IFadeBackgroundFadeInEffectScreenEffectT AsIFadeBackgroundFadeInEffectScreenEffect()
		{
			return this.As<IFadeBackgroundFadeInEffectScreenEffectT>();
		}

		// Token: 0x060374FD RID: 226557 RVA: 0x0077E5FF File Offset: 0x0077C7FF
		public static TFadeBackgroundFadeInEffectUnion FromIFadeBackgroundFadeInEffectScreenEffect(IFadeBackgroundFadeInEffectScreenEffectT _ifadebackgroundfadeineffectscreeneffect)
		{
			return new TFadeBackgroundFadeInEffectUnion
			{
				Type = TFadeBackgroundFadeInEffect.IFadeBackgroundFadeInEffectScreenEffect,
				Value = _ifadebackgroundfadeineffectscreeneffect
			};
		}

		// Token: 0x060374FE RID: 226558 RVA: 0x0077E614 File Offset: 0x0077C814
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
