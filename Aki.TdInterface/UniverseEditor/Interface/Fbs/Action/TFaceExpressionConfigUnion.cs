using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ED4 RID: 32468
	public class TFaceExpressionConfigUnion
	{
		// Token: 0x1700F25B RID: 62043
		// (get) Token: 0x0603A98B RID: 240011 RVA: 0x007E25CE File Offset: 0x007E07CE
		// (set) Token: 0x0603A98C RID: 240012 RVA: 0x007E25D6 File Offset: 0x007E07D6
		public TFaceExpressionConfig Type { get; set; }

		// Token: 0x1700F25C RID: 62044
		// (get) Token: 0x0603A98D RID: 240013 RVA: 0x007E25DF File Offset: 0x007E07DF
		// (set) Token: 0x0603A98E RID: 240014 RVA: 0x007E25E7 File Offset: 0x007E07E7
		public object Value { get; set; }

		// Token: 0x0603A98F RID: 240015 RVA: 0x007E25F0 File Offset: 0x007E07F0
		public TFaceExpressionConfigUnion()
		{
			this.Type = TFaceExpressionConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603A990 RID: 240016 RVA: 0x007E2606 File Offset: 0x007E0806
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A991 RID: 240017 RVA: 0x007E2618 File Offset: 0x007E0818
		public IFaceExpressionAnimSequenceConfigT AsIFaceExpressionAnimSequenceConfig()
		{
			return this.As<IFaceExpressionAnimSequenceConfigT>();
		}

		// Token: 0x0603A992 RID: 240018 RVA: 0x007E2620 File Offset: 0x007E0820
		public static TFaceExpressionConfigUnion FromIFaceExpressionAnimSequenceConfig(IFaceExpressionAnimSequenceConfigT _ifaceexpressionanimsequenceconfig)
		{
			return new TFaceExpressionConfigUnion
			{
				Type = TFaceExpressionConfig.IFaceExpressionAnimSequenceConfig,
				Value = _ifaceexpressionanimsequenceconfig
			};
		}

		// Token: 0x0603A993 RID: 240019 RVA: 0x007E2635 File Offset: 0x007E0835
		public IFaceExpressionMorphConfigT AsIFaceExpressionMorphConfig()
		{
			return this.As<IFaceExpressionMorphConfigT>();
		}

		// Token: 0x0603A994 RID: 240020 RVA: 0x007E263D File Offset: 0x007E083D
		public static TFaceExpressionConfigUnion FromIFaceExpressionMorphConfig(IFaceExpressionMorphConfigT _ifaceexpressionmorphconfig)
		{
			return new TFaceExpressionConfigUnion
			{
				Type = TFaceExpressionConfig.IFaceExpressionMorphConfig,
				Value = _ifaceexpressionmorphconfig
			};
		}

		// Token: 0x0603A995 RID: 240021 RVA: 0x007E2652 File Offset: 0x007E0852
		public IFaceExpressionTextureConfigT AsIFaceExpressionTextureConfig()
		{
			return this.As<IFaceExpressionTextureConfigT>();
		}

		// Token: 0x0603A996 RID: 240022 RVA: 0x007E265A File Offset: 0x007E085A
		public static TFaceExpressionConfigUnion FromIFaceExpressionTextureConfig(IFaceExpressionTextureConfigT _ifaceexpressiontextureconfig)
		{
			return new TFaceExpressionConfigUnion
			{
				Type = TFaceExpressionConfig.IFaceExpressionTextureConfig,
				Value = _ifaceexpressiontextureconfig
			};
		}

		// Token: 0x0603A997 RID: 240023 RVA: 0x007E266F File Offset: 0x007E086F
		public IFaceExpressionTextureMultiSlotConfigT AsIFaceExpressionTextureMultiSlotConfig()
		{
			return this.As<IFaceExpressionTextureMultiSlotConfigT>();
		}

		// Token: 0x0603A998 RID: 240024 RVA: 0x007E2677 File Offset: 0x007E0877
		public static TFaceExpressionConfigUnion FromIFaceExpressionTextureMultiSlotConfig(IFaceExpressionTextureMultiSlotConfigT _ifaceexpressiontexturemultislotconfig)
		{
			return new TFaceExpressionConfigUnion
			{
				Type = TFaceExpressionConfig.IFaceExpressionTextureMultiSlotConfig,
				Value = _ifaceexpressiontexturemultislotconfig
			};
		}

		// Token: 0x0603A999 RID: 240025 RVA: 0x007E268C File Offset: 0x007E088C
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
