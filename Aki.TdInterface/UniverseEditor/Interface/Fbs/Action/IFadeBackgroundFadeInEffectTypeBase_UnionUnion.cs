using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE9 RID: 28137
	public class IFadeBackgroundFadeInEffectTypeBase_UnionUnion
	{
		// Token: 0x1700CE38 RID: 52792
		// (get) Token: 0x0603091B RID: 198939 RVA: 0x006984E5 File Offset: 0x006966E5
		// (set) Token: 0x0603091C RID: 198940 RVA: 0x006984ED File Offset: 0x006966ED
		public IFadeBackgroundFadeInEffectTypeBase_Union Type { get; set; }

		// Token: 0x1700CE39 RID: 52793
		// (get) Token: 0x0603091D RID: 198941 RVA: 0x006984F6 File Offset: 0x006966F6
		// (set) Token: 0x0603091E RID: 198942 RVA: 0x006984FE File Offset: 0x006966FE
		public object Value { get; set; }

		// Token: 0x0603091F RID: 198943 RVA: 0x00698507 File Offset: 0x00696707
		public IFadeBackgroundFadeInEffectTypeBase_UnionUnion()
		{
			this.Type = IFadeBackgroundFadeInEffectTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030920 RID: 198944 RVA: 0x0069851D File Offset: 0x0069671D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030921 RID: 198945 RVA: 0x0069852F File Offset: 0x0069672F
		public IFadeBackgroundFadeInEffectTypeBaseT AsIFadeBackgroundFadeInEffectTypeBase()
		{
			return this.As<IFadeBackgroundFadeInEffectTypeBaseT>();
		}

		// Token: 0x06030922 RID: 198946 RVA: 0x00698537 File Offset: 0x00696737
		public static IFadeBackgroundFadeInEffectTypeBase_UnionUnion FromIFadeBackgroundFadeInEffectTypeBase(IFadeBackgroundFadeInEffectTypeBaseT _ifadebackgroundfadeineffecttypebase)
		{
			return new IFadeBackgroundFadeInEffectTypeBase_UnionUnion
			{
				Type = IFadeBackgroundFadeInEffectTypeBase_Union.IFadeBackgroundFadeInEffectTypeBase,
				Value = _ifadebackgroundfadeineffecttypebase
			};
		}

		// Token: 0x06030923 RID: 198947 RVA: 0x0069854C File Offset: 0x0069674C
		public IFadeBackgroundFadeInEffectBlackT AsIFadeBackgroundFadeInEffectBlack()
		{
			return this.As<IFadeBackgroundFadeInEffectBlackT>();
		}

		// Token: 0x06030924 RID: 198948 RVA: 0x00698554 File Offset: 0x00696754
		public static IFadeBackgroundFadeInEffectTypeBase_UnionUnion FromIFadeBackgroundFadeInEffectBlack(IFadeBackgroundFadeInEffectBlackT _ifadebackgroundfadeineffectblack)
		{
			return new IFadeBackgroundFadeInEffectTypeBase_UnionUnion
			{
				Type = IFadeBackgroundFadeInEffectTypeBase_Union.IFadeBackgroundFadeInEffectBlack,
				Value = _ifadebackgroundfadeineffectblack
			};
		}

		// Token: 0x06030925 RID: 198949 RVA: 0x00698569 File Offset: 0x00696769
		public IFadeBackgroundFadeInEffectScreenEffectT AsIFadeBackgroundFadeInEffectScreenEffect()
		{
			return this.As<IFadeBackgroundFadeInEffectScreenEffectT>();
		}

		// Token: 0x06030926 RID: 198950 RVA: 0x00698571 File Offset: 0x00696771
		public static IFadeBackgroundFadeInEffectTypeBase_UnionUnion FromIFadeBackgroundFadeInEffectScreenEffect(IFadeBackgroundFadeInEffectScreenEffectT _ifadebackgroundfadeineffectscreeneffect)
		{
			return new IFadeBackgroundFadeInEffectTypeBase_UnionUnion
			{
				Type = IFadeBackgroundFadeInEffectTypeBase_Union.IFadeBackgroundFadeInEffectScreenEffect,
				Value = _ifadebackgroundfadeineffectscreeneffect
			};
		}

		// Token: 0x06030927 RID: 198951 RVA: 0x00698588 File Offset: 0x00696788
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
