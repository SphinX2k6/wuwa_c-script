using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DCE RID: 28110
	public class IFaceExpressionConfig_UnionUnion
	{
		// Token: 0x1700CE0C RID: 52748
		// (get) Token: 0x0603084D RID: 198733 RVA: 0x00696FEE File Offset: 0x006951EE
		// (set) Token: 0x0603084E RID: 198734 RVA: 0x00696FF6 File Offset: 0x006951F6
		public IFaceExpressionConfig_Union Type { get; set; }

		// Token: 0x1700CE0D RID: 52749
		// (get) Token: 0x0603084F RID: 198735 RVA: 0x00696FFF File Offset: 0x006951FF
		// (set) Token: 0x06030850 RID: 198736 RVA: 0x00697007 File Offset: 0x00695207
		public object Value { get; set; }

		// Token: 0x06030851 RID: 198737 RVA: 0x00697010 File Offset: 0x00695210
		public IFaceExpressionConfig_UnionUnion()
		{
			this.Type = IFaceExpressionConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030852 RID: 198738 RVA: 0x00697026 File Offset: 0x00695226
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030853 RID: 198739 RVA: 0x00697038 File Offset: 0x00695238
		public IFaceExpressionConfigT AsIFaceExpressionConfig()
		{
			return this.As<IFaceExpressionConfigT>();
		}

		// Token: 0x06030854 RID: 198740 RVA: 0x00697040 File Offset: 0x00695240
		public static IFaceExpressionConfig_UnionUnion FromIFaceExpressionConfig(IFaceExpressionConfigT _ifaceexpressionconfig)
		{
			return new IFaceExpressionConfig_UnionUnion
			{
				Type = IFaceExpressionConfig_Union.IFaceExpressionConfig,
				Value = _ifaceexpressionconfig
			};
		}

		// Token: 0x06030855 RID: 198741 RVA: 0x00697055 File Offset: 0x00695255
		public IFaceExpressionMorphConfigT AsIFaceExpressionMorphConfig()
		{
			return this.As<IFaceExpressionMorphConfigT>();
		}

		// Token: 0x06030856 RID: 198742 RVA: 0x0069705D File Offset: 0x0069525D
		public static IFaceExpressionConfig_UnionUnion FromIFaceExpressionMorphConfig(IFaceExpressionMorphConfigT _ifaceexpressionmorphconfig)
		{
			return new IFaceExpressionConfig_UnionUnion
			{
				Type = IFaceExpressionConfig_Union.IFaceExpressionMorphConfig,
				Value = _ifaceexpressionmorphconfig
			};
		}

		// Token: 0x06030857 RID: 198743 RVA: 0x00697072 File Offset: 0x00695272
		public IFaceExpressionTextureConfigT AsIFaceExpressionTextureConfig()
		{
			return this.As<IFaceExpressionTextureConfigT>();
		}

		// Token: 0x06030858 RID: 198744 RVA: 0x0069707A File Offset: 0x0069527A
		public static IFaceExpressionConfig_UnionUnion FromIFaceExpressionTextureConfig(IFaceExpressionTextureConfigT _ifaceexpressiontextureconfig)
		{
			return new IFaceExpressionConfig_UnionUnion
			{
				Type = IFaceExpressionConfig_Union.IFaceExpressionTextureConfig,
				Value = _ifaceexpressiontextureconfig
			};
		}

		// Token: 0x06030859 RID: 198745 RVA: 0x0069708F File Offset: 0x0069528F
		public IFaceExpressionAnimSequenceConfigT AsIFaceExpressionAnimSequenceConfig()
		{
			return this.As<IFaceExpressionAnimSequenceConfigT>();
		}

		// Token: 0x0603085A RID: 198746 RVA: 0x00697097 File Offset: 0x00695297
		public static IFaceExpressionConfig_UnionUnion FromIFaceExpressionAnimSequenceConfig(IFaceExpressionAnimSequenceConfigT _ifaceexpressionanimsequenceconfig)
		{
			return new IFaceExpressionConfig_UnionUnion
			{
				Type = IFaceExpressionConfig_Union.IFaceExpressionAnimSequenceConfig,
				Value = _ifaceexpressionanimsequenceconfig
			};
		}

		// Token: 0x0603085B RID: 198747 RVA: 0x006970AC File Offset: 0x006952AC
		public IFaceExpressionTextureMultiSlotConfigT AsIFaceExpressionTextureMultiSlotConfig()
		{
			return this.As<IFaceExpressionTextureMultiSlotConfigT>();
		}

		// Token: 0x0603085C RID: 198748 RVA: 0x006970B4 File Offset: 0x006952B4
		public static IFaceExpressionConfig_UnionUnion FromIFaceExpressionTextureMultiSlotConfig(IFaceExpressionTextureMultiSlotConfigT _ifaceexpressiontexturemultislotconfig)
		{
			return new IFaceExpressionConfig_UnionUnion
			{
				Type = IFaceExpressionConfig_Union.IFaceExpressionTextureMultiSlotConfig,
				Value = _ifaceexpressiontexturemultislotconfig
			};
		}

		// Token: 0x0603085D RID: 198749 RVA: 0x006970CC File Offset: 0x006952CC
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
