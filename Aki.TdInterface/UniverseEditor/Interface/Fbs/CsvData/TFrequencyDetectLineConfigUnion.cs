using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DCB RID: 19915
	public class TFrequencyDetectLineConfigUnion
	{
		// Token: 0x17008E72 RID: 36466
		// (get) Token: 0x0601EE73 RID: 126579 RVA: 0x00451541 File Offset: 0x0044F741
		// (set) Token: 0x0601EE74 RID: 126580 RVA: 0x00451549 File Offset: 0x0044F749
		public TFrequencyDetectLineConfig Type { get; set; }

		// Token: 0x17008E73 RID: 36467
		// (get) Token: 0x0601EE75 RID: 126581 RVA: 0x00451552 File Offset: 0x0044F752
		// (set) Token: 0x0601EE76 RID: 126582 RVA: 0x0045155A File Offset: 0x0044F75A
		public object Value { get; set; }

		// Token: 0x0601EE77 RID: 126583 RVA: 0x00451563 File Offset: 0x0044F763
		public TFrequencyDetectLineConfigUnion()
		{
			this.Type = TFrequencyDetectLineConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0601EE78 RID: 126584 RVA: 0x00451579 File Offset: 0x0044F779
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EE79 RID: 126585 RVA: 0x0045158B File Offset: 0x0044F78B
		public IFrequencyDetectAiLineConfigT AsIFrequencyDetectAiLineConfig()
		{
			return this.As<IFrequencyDetectAiLineConfigT>();
		}

		// Token: 0x0601EE7A RID: 126586 RVA: 0x00451593 File Offset: 0x0044F793
		public static TFrequencyDetectLineConfigUnion FromIFrequencyDetectAiLineConfig(IFrequencyDetectAiLineConfigT _ifrequencydetectailineconfig)
		{
			return new TFrequencyDetectLineConfigUnion
			{
				Type = TFrequencyDetectLineConfig.IFrequencyDetectAiLineConfig,
				Value = _ifrequencydetectailineconfig
			};
		}

		// Token: 0x0601EE7B RID: 126587 RVA: 0x004515A8 File Offset: 0x0044F7A8
		public IFrequencyDetectPlayerLineConfigT AsIFrequencyDetectPlayerLineConfig()
		{
			return this.As<IFrequencyDetectPlayerLineConfigT>();
		}

		// Token: 0x0601EE7C RID: 126588 RVA: 0x004515B0 File Offset: 0x0044F7B0
		public static TFrequencyDetectLineConfigUnion FromIFrequencyDetectPlayerLineConfig(IFrequencyDetectPlayerLineConfigT _ifrequencydetectplayerlineconfig)
		{
			return new TFrequencyDetectLineConfigUnion
			{
				Type = TFrequencyDetectLineConfig.IFrequencyDetectPlayerLineConfig,
				Value = _ifrequencydetectplayerlineconfig
			};
		}

		// Token: 0x0601EE7D RID: 126589 RVA: 0x004515C8 File Offset: 0x0044F7C8
		public static int Pack(FlatBufferBuilder builder, TFrequencyDetectLineConfigUnion _o)
		{
			TFrequencyDetectLineConfig type = _o.Type;
			if (type == TFrequencyDetectLineConfig.IFrequencyDetectAiLineConfig)
			{
				return IFrequencyDetectAiLineConfig.Pack(builder, _o.AsIFrequencyDetectAiLineConfig()).Value;
			}
			if (type != TFrequencyDetectLineConfig.IFrequencyDetectPlayerLineConfig)
			{
				return 0;
			}
			return IFrequencyDetectPlayerLineConfig.Pack(builder, _o.AsIFrequencyDetectPlayerLineConfig()).Value;
		}
	}
}
