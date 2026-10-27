using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006769 RID: 26473
	public class IFadeBackgroundFadeInEffectTypeBase_UnionUnion
	{
		// Token: 0x1700C482 RID: 50306
		// (get) Token: 0x0602E0D5 RID: 188629 RVA: 0x0064ADA1 File Offset: 0x00648FA1
		// (set) Token: 0x0602E0D6 RID: 188630 RVA: 0x0064ADA9 File Offset: 0x00648FA9
		public IFadeBackgroundFadeInEffectTypeBase_Union Type { get; set; }

		// Token: 0x1700C483 RID: 50307
		// (get) Token: 0x0602E0D7 RID: 188631 RVA: 0x0064ADB2 File Offset: 0x00648FB2
		// (set) Token: 0x0602E0D8 RID: 188632 RVA: 0x0064ADBA File Offset: 0x00648FBA
		public object Value { get; set; }

		// Token: 0x0602E0D9 RID: 188633 RVA: 0x0064ADC3 File Offset: 0x00648FC3
		public IFadeBackgroundFadeInEffectTypeBase_UnionUnion()
		{
			this.Type = IFadeBackgroundFadeInEffectTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E0DA RID: 188634 RVA: 0x0064ADD9 File Offset: 0x00648FD9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E0DB RID: 188635 RVA: 0x0064ADEB File Offset: 0x00648FEB
		public IFadeBackgroundFadeInEffectTypeBaseT AsIFadeBackgroundFadeInEffectTypeBase()
		{
			return this.As<IFadeBackgroundFadeInEffectTypeBaseT>();
		}

		// Token: 0x0602E0DC RID: 188636 RVA: 0x0064ADF3 File Offset: 0x00648FF3
		public static IFadeBackgroundFadeInEffectTypeBase_UnionUnion FromIFadeBackgroundFadeInEffectTypeBase(IFadeBackgroundFadeInEffectTypeBaseT _ifadebackgroundfadeineffecttypebase)
		{
			return new IFadeBackgroundFadeInEffectTypeBase_UnionUnion
			{
				Type = IFadeBackgroundFadeInEffectTypeBase_Union.IFadeBackgroundFadeInEffectTypeBase,
				Value = _ifadebackgroundfadeineffecttypebase
			};
		}

		// Token: 0x0602E0DD RID: 188637 RVA: 0x0064AE08 File Offset: 0x00649008
		public IFadeBackgroundFadeInEffectBlackT AsIFadeBackgroundFadeInEffectBlack()
		{
			return this.As<IFadeBackgroundFadeInEffectBlackT>();
		}

		// Token: 0x0602E0DE RID: 188638 RVA: 0x0064AE10 File Offset: 0x00649010
		public static IFadeBackgroundFadeInEffectTypeBase_UnionUnion FromIFadeBackgroundFadeInEffectBlack(IFadeBackgroundFadeInEffectBlackT _ifadebackgroundfadeineffectblack)
		{
			return new IFadeBackgroundFadeInEffectTypeBase_UnionUnion
			{
				Type = IFadeBackgroundFadeInEffectTypeBase_Union.IFadeBackgroundFadeInEffectBlack,
				Value = _ifadebackgroundfadeineffectblack
			};
		}

		// Token: 0x0602E0DF RID: 188639 RVA: 0x0064AE25 File Offset: 0x00649025
		public IFadeBackgroundFadeInEffectScreenEffectT AsIFadeBackgroundFadeInEffectScreenEffect()
		{
			return this.As<IFadeBackgroundFadeInEffectScreenEffectT>();
		}

		// Token: 0x0602E0E0 RID: 188640 RVA: 0x0064AE2D File Offset: 0x0064902D
		public static IFadeBackgroundFadeInEffectTypeBase_UnionUnion FromIFadeBackgroundFadeInEffectScreenEffect(IFadeBackgroundFadeInEffectScreenEffectT _ifadebackgroundfadeineffectscreeneffect)
		{
			return new IFadeBackgroundFadeInEffectTypeBase_UnionUnion
			{
				Type = IFadeBackgroundFadeInEffectTypeBase_Union.IFadeBackgroundFadeInEffectScreenEffect,
				Value = _ifadebackgroundfadeineffectscreeneffect
			};
		}

		// Token: 0x0602E0E1 RID: 188641 RVA: 0x0064AE44 File Offset: 0x00649044
		public static int Pack(FlatBufferBuilder builder, IFadeBackgroundFadeInEffectTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFadeBackgroundFadeInEffectTypeBase_Union.IFadeBackgroundFadeInEffectTypeBase:
				return IFadeBackgroundFadeInEffectTypeBase.Pack(builder, _o.AsIFadeBackgroundFadeInEffectTypeBase()).Value;
			case IFadeBackgroundFadeInEffectTypeBase_Union.IFadeBackgroundFadeInEffectBlack:
				return IFadeBackgroundFadeInEffectBlack.Pack(builder, _o.AsIFadeBackgroundFadeInEffectBlack()).Value;
			case IFadeBackgroundFadeInEffectTypeBase_Union.IFadeBackgroundFadeInEffectScreenEffect:
				return IFadeBackgroundFadeInEffectScreenEffect.Pack(builder, _o.AsIFadeBackgroundFadeInEffectScreenEffect()).Value;
			default:
				return 0;
			}
		}
	}
}
