using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200674E RID: 26446
	public class IFaceExpressionConfig_UnionUnion
	{
		// Token: 0x1700C456 RID: 50262
		// (get) Token: 0x0602E007 RID: 188423 RVA: 0x006498AA File Offset: 0x00647AAA
		// (set) Token: 0x0602E008 RID: 188424 RVA: 0x006498B2 File Offset: 0x00647AB2
		public IFaceExpressionConfig_Union Type { get; set; }

		// Token: 0x1700C457 RID: 50263
		// (get) Token: 0x0602E009 RID: 188425 RVA: 0x006498BB File Offset: 0x00647ABB
		// (set) Token: 0x0602E00A RID: 188426 RVA: 0x006498C3 File Offset: 0x00647AC3
		public object Value { get; set; }

		// Token: 0x0602E00B RID: 188427 RVA: 0x006498CC File Offset: 0x00647ACC
		public IFaceExpressionConfig_UnionUnion()
		{
			this.Type = IFaceExpressionConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E00C RID: 188428 RVA: 0x006498E2 File Offset: 0x00647AE2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E00D RID: 188429 RVA: 0x006498F4 File Offset: 0x00647AF4
		public IFaceExpressionConfigT AsIFaceExpressionConfig()
		{
			return this.As<IFaceExpressionConfigT>();
		}

		// Token: 0x0602E00E RID: 188430 RVA: 0x006498FC File Offset: 0x00647AFC
		public static IFaceExpressionConfig_UnionUnion FromIFaceExpressionConfig(IFaceExpressionConfigT _ifaceexpressionconfig)
		{
			return new IFaceExpressionConfig_UnionUnion
			{
				Type = IFaceExpressionConfig_Union.IFaceExpressionConfig,
				Value = _ifaceexpressionconfig
			};
		}

		// Token: 0x0602E00F RID: 188431 RVA: 0x00649911 File Offset: 0x00647B11
		public IFaceExpressionMorphConfigT AsIFaceExpressionMorphConfig()
		{
			return this.As<IFaceExpressionMorphConfigT>();
		}

		// Token: 0x0602E010 RID: 188432 RVA: 0x00649919 File Offset: 0x00647B19
		public static IFaceExpressionConfig_UnionUnion FromIFaceExpressionMorphConfig(IFaceExpressionMorphConfigT _ifaceexpressionmorphconfig)
		{
			return new IFaceExpressionConfig_UnionUnion
			{
				Type = IFaceExpressionConfig_Union.IFaceExpressionMorphConfig,
				Value = _ifaceexpressionmorphconfig
			};
		}

		// Token: 0x0602E011 RID: 188433 RVA: 0x0064992E File Offset: 0x00647B2E
		public IFaceExpressionTextureConfigT AsIFaceExpressionTextureConfig()
		{
			return this.As<IFaceExpressionTextureConfigT>();
		}

		// Token: 0x0602E012 RID: 188434 RVA: 0x00649936 File Offset: 0x00647B36
		public static IFaceExpressionConfig_UnionUnion FromIFaceExpressionTextureConfig(IFaceExpressionTextureConfigT _ifaceexpressiontextureconfig)
		{
			return new IFaceExpressionConfig_UnionUnion
			{
				Type = IFaceExpressionConfig_Union.IFaceExpressionTextureConfig,
				Value = _ifaceexpressiontextureconfig
			};
		}

		// Token: 0x0602E013 RID: 188435 RVA: 0x0064994B File Offset: 0x00647B4B
		public IFaceExpressionAnimSequenceConfigT AsIFaceExpressionAnimSequenceConfig()
		{
			return this.As<IFaceExpressionAnimSequenceConfigT>();
		}

		// Token: 0x0602E014 RID: 188436 RVA: 0x00649953 File Offset: 0x00647B53
		public static IFaceExpressionConfig_UnionUnion FromIFaceExpressionAnimSequenceConfig(IFaceExpressionAnimSequenceConfigT _ifaceexpressionanimsequenceconfig)
		{
			return new IFaceExpressionConfig_UnionUnion
			{
				Type = IFaceExpressionConfig_Union.IFaceExpressionAnimSequenceConfig,
				Value = _ifaceexpressionanimsequenceconfig
			};
		}

		// Token: 0x0602E015 RID: 188437 RVA: 0x00649968 File Offset: 0x00647B68
		public IFaceExpressionTextureMultiSlotConfigT AsIFaceExpressionTextureMultiSlotConfig()
		{
			return this.As<IFaceExpressionTextureMultiSlotConfigT>();
		}

		// Token: 0x0602E016 RID: 188438 RVA: 0x00649970 File Offset: 0x00647B70
		public static IFaceExpressionConfig_UnionUnion FromIFaceExpressionTextureMultiSlotConfig(IFaceExpressionTextureMultiSlotConfigT _ifaceexpressiontexturemultislotconfig)
		{
			return new IFaceExpressionConfig_UnionUnion
			{
				Type = IFaceExpressionConfig_Union.IFaceExpressionTextureMultiSlotConfig,
				Value = _ifaceexpressiontexturemultislotconfig
			};
		}

		// Token: 0x0602E017 RID: 188439 RVA: 0x00649988 File Offset: 0x00647B88
		public static int Pack(FlatBufferBuilder builder, IFaceExpressionConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFaceExpressionConfig_Union.IFaceExpressionConfig:
				return IFaceExpressionConfig.Pack(builder, _o.AsIFaceExpressionConfig()).Value;
			case IFaceExpressionConfig_Union.IFaceExpressionMorphConfig:
				return IFaceExpressionMorphConfig.Pack(builder, _o.AsIFaceExpressionMorphConfig()).Value;
			case IFaceExpressionConfig_Union.IFaceExpressionTextureConfig:
				return IFaceExpressionTextureConfig.Pack(builder, _o.AsIFaceExpressionTextureConfig()).Value;
			case IFaceExpressionConfig_Union.IFaceExpressionAnimSequenceConfig:
				return IFaceExpressionAnimSequenceConfig.Pack(builder, _o.AsIFaceExpressionAnimSequenceConfig()).Value;
			case IFaceExpressionConfig_Union.IFaceExpressionTextureMultiSlotConfig:
				return IFaceExpressionTextureMultiSlotConfig.Pack(builder, _o.AsIFaceExpressionTextureMultiSlotConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
