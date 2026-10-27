using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D7 RID: 29655
	public class ITextUiConfig_UnionUnion
	{
		// Token: 0x1700E14D RID: 57677
		// (get) Token: 0x06035E01 RID: 220673 RVA: 0x0075551C File Offset: 0x0075371C
		// (set) Token: 0x06035E02 RID: 220674 RVA: 0x00755524 File Offset: 0x00753724
		public ITextUiConfig_Union Type { get; set; }

		// Token: 0x1700E14E RID: 57678
		// (get) Token: 0x06035E03 RID: 220675 RVA: 0x0075552D File Offset: 0x0075372D
		// (set) Token: 0x06035E04 RID: 220676 RVA: 0x00755535 File Offset: 0x00753735
		public object Value { get; set; }

		// Token: 0x06035E05 RID: 220677 RVA: 0x0075553E File Offset: 0x0075373E
		public ITextUiConfig_UnionUnion()
		{
			this.Type = ITextUiConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035E06 RID: 220678 RVA: 0x00755554 File Offset: 0x00753754
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035E07 RID: 220679 RVA: 0x00755566 File Offset: 0x00753766
		public ITextUiConfigT AsITextUiConfig()
		{
			return this.As<ITextUiConfigT>();
		}

		// Token: 0x06035E08 RID: 220680 RVA: 0x0075556E File Offset: 0x0075376E
		public static ITextUiConfig_UnionUnion FromITextUiConfig(ITextUiConfigT _itextuiconfig)
		{
			return new ITextUiConfig_UnionUnion
			{
				Type = ITextUiConfig_Union.ITextUiConfig,
				Value = _itextuiconfig
			};
		}

		// Token: 0x06035E09 RID: 220681 RVA: 0x00755583 File Offset: 0x00753783
		public IAstrologyTextUiConfigT AsIAstrologyTextUiConfig()
		{
			return this.As<IAstrologyTextUiConfigT>();
		}

		// Token: 0x06035E0A RID: 220682 RVA: 0x0075558B File Offset: 0x0075378B
		public static ITextUiConfig_UnionUnion FromIAstrologyTextUiConfig(IAstrologyTextUiConfigT _iastrologytextuiconfig)
		{
			return new ITextUiConfig_UnionUnion
			{
				Type = ITextUiConfig_Union.IAstrologyTextUiConfig,
				Value = _iastrologytextuiconfig
			};
		}

		// Token: 0x06035E0B RID: 220683 RVA: 0x007555A0 File Offset: 0x007537A0
		public static int Pack(FlatBufferBuilder builder, ITextUiConfig_UnionUnion _o)
		{
			ITextUiConfig_Union type = _o.Type;
			if (type == ITextUiConfig_Union.ITextUiConfig)
			{
				return ITextUiConfig.Pack(builder, _o.AsITextUiConfig()).Value;
			}
			if (type != ITextUiConfig_Union.IAstrologyTextUiConfig)
			{
				return 0;
			}
			return IAstrologyTextUiConfig.Pack(builder, _o.AsIAstrologyTextUiConfig()).Value;
		}
	}
}
