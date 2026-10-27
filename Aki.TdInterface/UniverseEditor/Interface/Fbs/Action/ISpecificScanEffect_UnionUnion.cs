using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200717C RID: 29052
	public class ISpecificScanEffect_UnionUnion
	{
		// Token: 0x1700D7CF RID: 55247
		// (get) Token: 0x06033817 RID: 210967 RVA: 0x006F02DD File Offset: 0x006EE4DD
		// (set) Token: 0x06033818 RID: 210968 RVA: 0x006F02E5 File Offset: 0x006EE4E5
		public ISpecificScanEffect_Union Type { get; set; }

		// Token: 0x1700D7D0 RID: 55248
		// (get) Token: 0x06033819 RID: 210969 RVA: 0x006F02EE File Offset: 0x006EE4EE
		// (set) Token: 0x0603381A RID: 210970 RVA: 0x006F02F6 File Offset: 0x006EE4F6
		public object Value { get; set; }

		// Token: 0x0603381B RID: 210971 RVA: 0x006F02FF File Offset: 0x006EE4FF
		public ISpecificScanEffect_UnionUnion()
		{
			this.Type = ISpecificScanEffect_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603381C RID: 210972 RVA: 0x006F0315 File Offset: 0x006EE515
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603381D RID: 210973 RVA: 0x006F0327 File Offset: 0x006EE527
		public ISpecificScanEffectT AsISpecificScanEffect()
		{
			return this.As<ISpecificScanEffectT>();
		}

		// Token: 0x0603381E RID: 210974 RVA: 0x006F032F File Offset: 0x006EE52F
		public static ISpecificScanEffect_UnionUnion FromISpecificScanEffect(ISpecificScanEffectT _ispecificscaneffect)
		{
			return new ISpecificScanEffect_UnionUnion
			{
				Type = ISpecificScanEffect_Union.ISpecificScanEffect,
				Value = _ispecificscaneffect
			};
		}

		// Token: 0x0603381F RID: 210975 RVA: 0x006F0344 File Offset: 0x006EE544
		public IChargeSlashScanEffectT AsIChargeSlashScanEffect()
		{
			return this.As<IChargeSlashScanEffectT>();
		}

		// Token: 0x06033820 RID: 210976 RVA: 0x006F034C File Offset: 0x006EE54C
		public static ISpecificScanEffect_UnionUnion FromIChargeSlashScanEffect(IChargeSlashScanEffectT _ichargeslashscaneffect)
		{
			return new ISpecificScanEffect_UnionUnion
			{
				Type = ISpecificScanEffect_Union.IChargeSlashScanEffect,
				Value = _ichargeslashscaneffect
			};
		}

		// Token: 0x06033821 RID: 210977 RVA: 0x006F0361 File Offset: 0x006EE561
		public IFlyingFeatherScanEffectT AsIFlyingFeatherScanEffect()
		{
			return this.As<IFlyingFeatherScanEffectT>();
		}

		// Token: 0x06033822 RID: 210978 RVA: 0x006F0369 File Offset: 0x006EE569
		public static ISpecificScanEffect_UnionUnion FromIFlyingFeatherScanEffect(IFlyingFeatherScanEffectT _iflyingfeatherscaneffect)
		{
			return new ISpecificScanEffect_UnionUnion
			{
				Type = ISpecificScanEffect_Union.IFlyingFeatherScanEffect,
				Value = _iflyingfeatherscaneffect
			};
		}

		// Token: 0x06033823 RID: 210979 RVA: 0x006F0380 File Offset: 0x006EE580
		public static int Pack(FlatBufferBuilder builder, ISpecificScanEffect_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISpecificScanEffect_Union.ISpecificScanEffect:
				return ISpecificScanEffect.Pack(builder, _o.AsISpecificScanEffect()).Value;
			case ISpecificScanEffect_Union.IChargeSlashScanEffect:
				return IChargeSlashScanEffect.Pack(builder, _o.AsIChargeSlashScanEffect()).Value;
			case ISpecificScanEffect_Union.IFlyingFeatherScanEffect:
				return IFlyingFeatherScanEffect.Pack(builder, _o.AsIFlyingFeatherScanEffect()).Value;
			default:
				return 0;
			}
		}
	}
}
