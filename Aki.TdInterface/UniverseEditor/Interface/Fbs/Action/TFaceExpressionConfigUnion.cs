using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076C6 RID: 30406
	public class TFaceExpressionConfigUnion
	{
		// Token: 0x1700E61D RID: 58909
		// (get) Token: 0x060374D6 RID: 226518 RVA: 0x0077E2BA File Offset: 0x0077C4BA
		// (set) Token: 0x060374D7 RID: 226519 RVA: 0x0077E2C2 File Offset: 0x0077C4C2
		public TFaceExpressionConfig Type { get; set; }

		// Token: 0x1700E61E RID: 58910
		// (get) Token: 0x060374D8 RID: 226520 RVA: 0x0077E2CB File Offset: 0x0077C4CB
		// (set) Token: 0x060374D9 RID: 226521 RVA: 0x0077E2D3 File Offset: 0x0077C4D3
		public object Value { get; set; }

		// Token: 0x060374DA RID: 226522 RVA: 0x0077E2DC File Offset: 0x0077C4DC
		public TFaceExpressionConfigUnion()
		{
			this.Type = TFaceExpressionConfig.NONE;
			this.Value = null;
		}

		// Token: 0x060374DB RID: 226523 RVA: 0x0077E2F2 File Offset: 0x0077C4F2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060374DC RID: 226524 RVA: 0x0077E304 File Offset: 0x0077C504
		public IFaceExpressionAnimSequenceConfigT AsIFaceExpressionAnimSequenceConfig()
		{
			return this.As<IFaceExpressionAnimSequenceConfigT>();
		}

		// Token: 0x060374DD RID: 226525 RVA: 0x0077E30C File Offset: 0x0077C50C
		public static TFaceExpressionConfigUnion FromIFaceExpressionAnimSequenceConfig(IFaceExpressionAnimSequenceConfigT _ifaceexpressionanimsequenceconfig)
		{
			return new TFaceExpressionConfigUnion
			{
				Type = TFaceExpressionConfig.IFaceExpressionAnimSequenceConfig,
				Value = _ifaceexpressionanimsequenceconfig
			};
		}

		// Token: 0x060374DE RID: 226526 RVA: 0x0077E321 File Offset: 0x0077C521
		public IFaceExpressionMorphConfigT AsIFaceExpressionMorphConfig()
		{
			return this.As<IFaceExpressionMorphConfigT>();
		}

		// Token: 0x060374DF RID: 226527 RVA: 0x0077E329 File Offset: 0x0077C529
		public static TFaceExpressionConfigUnion FromIFaceExpressionMorphConfig(IFaceExpressionMorphConfigT _ifaceexpressionmorphconfig)
		{
			return new TFaceExpressionConfigUnion
			{
				Type = TFaceExpressionConfig.IFaceExpressionMorphConfig,
				Value = _ifaceexpressionmorphconfig
			};
		}

		// Token: 0x060374E0 RID: 226528 RVA: 0x0077E33E File Offset: 0x0077C53E
		public IFaceExpressionTextureConfigT AsIFaceExpressionTextureConfig()
		{
			return this.As<IFaceExpressionTextureConfigT>();
		}

		// Token: 0x060374E1 RID: 226529 RVA: 0x0077E346 File Offset: 0x0077C546
		public static TFaceExpressionConfigUnion FromIFaceExpressionTextureConfig(IFaceExpressionTextureConfigT _ifaceexpressiontextureconfig)
		{
			return new TFaceExpressionConfigUnion
			{
				Type = TFaceExpressionConfig.IFaceExpressionTextureConfig,
				Value = _ifaceexpressiontextureconfig
			};
		}

		// Token: 0x060374E2 RID: 226530 RVA: 0x0077E35B File Offset: 0x0077C55B
		public IFaceExpressionTextureMultiSlotConfigT AsIFaceExpressionTextureMultiSlotConfig()
		{
			return this.As<IFaceExpressionTextureMultiSlotConfigT>();
		}

		// Token: 0x060374E3 RID: 226531 RVA: 0x0077E363 File Offset: 0x0077C563
		public static TFaceExpressionConfigUnion FromIFaceExpressionTextureMultiSlotConfig(IFaceExpressionTextureMultiSlotConfigT _ifaceexpressiontexturemultislotconfig)
		{
			return new TFaceExpressionConfigUnion
			{
				Type = TFaceExpressionConfig.IFaceExpressionTextureMultiSlotConfig,
				Value = _ifaceexpressiontexturemultislotconfig
			};
		}

		// Token: 0x060374E4 RID: 226532 RVA: 0x0077E378 File Offset: 0x0077C578
		public static int Pack(FlatBufferBuilder builder, TFaceExpressionConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TFaceExpressionConfig.IFaceExpressionAnimSequenceConfig:
				return IFaceExpressionAnimSequenceConfig.Pack(builder, _o.AsIFaceExpressionAnimSequenceConfig()).Value;
			case TFaceExpressionConfig.IFaceExpressionMorphConfig:
				return IFaceExpressionMorphConfig.Pack(builder, _o.AsIFaceExpressionMorphConfig()).Value;
			case TFaceExpressionConfig.IFaceExpressionTextureConfig:
				return IFaceExpressionTextureConfig.Pack(builder, _o.AsIFaceExpressionTextureConfig()).Value;
			case TFaceExpressionConfig.IFaceExpressionTextureMultiSlotConfig:
				return IFaceExpressionTextureMultiSlotConfig.Pack(builder, _o.AsIFaceExpressionTextureMultiSlotConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
