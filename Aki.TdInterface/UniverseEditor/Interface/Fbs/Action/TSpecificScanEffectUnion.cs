using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007799 RID: 30617
	public class TSpecificScanEffectUnion
	{
		// Token: 0x1700E6A9 RID: 59049
		// (get) Token: 0x0603792A RID: 227626 RVA: 0x00784C62 File Offset: 0x00782E62
		// (set) Token: 0x0603792B RID: 227627 RVA: 0x00784C6A File Offset: 0x00782E6A
		public TSpecificScanEffect Type { get; set; }

		// Token: 0x1700E6AA RID: 59050
		// (get) Token: 0x0603792C RID: 227628 RVA: 0x00784C73 File Offset: 0x00782E73
		// (set) Token: 0x0603792D RID: 227629 RVA: 0x00784C7B File Offset: 0x00782E7B
		public object Value { get; set; }

		// Token: 0x0603792E RID: 227630 RVA: 0x00784C84 File Offset: 0x00782E84
		public TSpecificScanEffectUnion()
		{
			this.Type = TSpecificScanEffect.NONE;
			this.Value = null;
		}

		// Token: 0x0603792F RID: 227631 RVA: 0x00784C9A File Offset: 0x00782E9A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037930 RID: 227632 RVA: 0x00784CAC File Offset: 0x00782EAC
		public IChargeSlashScanEffectT AsIChargeSlashScanEffect()
		{
			return this.As<IChargeSlashScanEffectT>();
		}

		// Token: 0x06037931 RID: 227633 RVA: 0x00784CB4 File Offset: 0x00782EB4
		public static TSpecificScanEffectUnion FromIChargeSlashScanEffect(IChargeSlashScanEffectT _ichargeslashscaneffect)
		{
			return new TSpecificScanEffectUnion
			{
				Type = TSpecificScanEffect.IChargeSlashScanEffect,
				Value = _ichargeslashscaneffect
			};
		}

		// Token: 0x06037932 RID: 227634 RVA: 0x00784CC9 File Offset: 0x00782EC9
		public IFlyingFeatherScanEffectT AsIFlyingFeatherScanEffect()
		{
			return this.As<IFlyingFeatherScanEffectT>();
		}

		// Token: 0x06037933 RID: 227635 RVA: 0x00784CD1 File Offset: 0x00782ED1
		public static TSpecificScanEffectUnion FromIFlyingFeatherScanEffect(IFlyingFeatherScanEffectT _iflyingfeatherscaneffect)
		{
			return new TSpecificScanEffectUnion
			{
				Type = TSpecificScanEffect.IFlyingFeatherScanEffect,
				Value = _iflyingfeatherscaneffect
			};
		}

		// Token: 0x06037934 RID: 227636 RVA: 0x00784CE8 File Offset: 0x00782EE8
		public static int Pack(FlatBufferBuilder builder, TSpecificScanEffectUnion _o)
		{
			TSpecificScanEffect type = _o.Type;
			if (type == TSpecificScanEffect.IChargeSlashScanEffect)
			{
				return IChargeSlashScanEffect.Pack(builder, _o.AsIChargeSlashScanEffect()).Value;
			}
			if (type != TSpecificScanEffect.IFlyingFeatherScanEffect)
			{
				return 0;
			}
			return IFlyingFeatherScanEffect.Pack(builder, _o.AsIFlyingFeatherScanEffect()).Value;
		}
	}
}
