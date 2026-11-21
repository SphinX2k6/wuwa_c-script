using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200794B RID: 31051
	public class ISpecificScanEffect_UnionUnion
	{
		// Token: 0x1700E3C1 RID: 58305
		// (get) Token: 0x06036AF1 RID: 223985 RVA: 0x0075126D File Offset: 0x0074F46D
		// (set) Token: 0x06036AF2 RID: 223986 RVA: 0x00751275 File Offset: 0x0074F475
		public ISpecificScanEffect_Union Type { get; set; }

		// Token: 0x1700E3C2 RID: 58306
		// (get) Token: 0x06036AF3 RID: 223987 RVA: 0x0075127E File Offset: 0x0074F47E
		// (set) Token: 0x06036AF4 RID: 223988 RVA: 0x00751286 File Offset: 0x0074F486
		public object Value { get; set; }

		// Token: 0x06036AF5 RID: 223989 RVA: 0x0075128F File Offset: 0x0074F48F
		public ISpecificScanEffect_UnionUnion()
		{
			this.Type = ISpecificScanEffect_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036AF6 RID: 223990 RVA: 0x007512A5 File Offset: 0x0074F4A5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036AF7 RID: 223991 RVA: 0x007512B7 File Offset: 0x0074F4B7
		public ISpecificScanEffectT AsISpecificScanEffect()
		{
			return this.As<ISpecificScanEffectT>();
		}

		// Token: 0x06036AF8 RID: 223992 RVA: 0x007512BF File Offset: 0x0074F4BF
		public static ISpecificScanEffect_UnionUnion FromISpecificScanEffect(ISpecificScanEffectT _ispecificscaneffect)
		{
			return new ISpecificScanEffect_UnionUnion
			{
				Type = ISpecificScanEffect_Union.ISpecificScanEffect,
				Value = _ispecificscaneffect
			};
		}

		// Token: 0x06036AF9 RID: 223993 RVA: 0x007512D4 File Offset: 0x0074F4D4
		public IChargeSlashScanEffectT AsIChargeSlashScanEffect()
		{
			return this.As<IChargeSlashScanEffectT>();
		}

		// Token: 0x06036AFA RID: 223994 RVA: 0x007512DC File Offset: 0x0074F4DC
		public static ISpecificScanEffect_UnionUnion FromIChargeSlashScanEffect(IChargeSlashScanEffectT _ichargeslashscaneffect)
		{
			return new ISpecificScanEffect_UnionUnion
			{
				Type = ISpecificScanEffect_Union.IChargeSlashScanEffect,
				Value = _ichargeslashscaneffect
			};
		}

		// Token: 0x06036AFB RID: 223995 RVA: 0x007512F1 File Offset: 0x0074F4F1
		public IFlyingFeatherScanEffectT AsIFlyingFeatherScanEffect()
		{
			return this.As<IFlyingFeatherScanEffectT>();
		}

		// Token: 0x06036AFC RID: 223996 RVA: 0x007512F9 File Offset: 0x0074F4F9
		public static ISpecificScanEffect_UnionUnion FromIFlyingFeatherScanEffect(IFlyingFeatherScanEffectT _iflyingfeatherscaneffect)
		{
			return new ISpecificScanEffect_UnionUnion
			{
				Type = ISpecificScanEffect_Union.IFlyingFeatherScanEffect,
				Value = _iflyingfeatherscaneffect
			};
		}

		// Token: 0x06036AFD RID: 223997 RVA: 0x00751310 File Offset: 0x0074F510
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
