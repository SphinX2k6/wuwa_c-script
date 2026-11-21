using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D92 RID: 19858
	public class IFrequencyDetectLineConfigBase_UnionUnion
	{
		// Token: 0x17008E14 RID: 36372
		// (get) Token: 0x0601ECB1 RID: 126129 RVA: 0x0044E248 File Offset: 0x0044C448
		// (set) Token: 0x0601ECB2 RID: 126130 RVA: 0x0044E250 File Offset: 0x0044C450
		public IFrequencyDetectLineConfigBase_Union Type { get; set; }

		// Token: 0x17008E15 RID: 36373
		// (get) Token: 0x0601ECB3 RID: 126131 RVA: 0x0044E259 File Offset: 0x0044C459
		// (set) Token: 0x0601ECB4 RID: 126132 RVA: 0x0044E261 File Offset: 0x0044C461
		public object Value { get; set; }

		// Token: 0x0601ECB5 RID: 126133 RVA: 0x0044E26A File Offset: 0x0044C46A
		public IFrequencyDetectLineConfigBase_UnionUnion()
		{
			this.Type = IFrequencyDetectLineConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601ECB6 RID: 126134 RVA: 0x0044E280 File Offset: 0x0044C480
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601ECB7 RID: 126135 RVA: 0x0044E292 File Offset: 0x0044C492
		public IFrequencyDetectLineConfigBaseT AsIFrequencyDetectLineConfigBase()
		{
			return this.As<IFrequencyDetectLineConfigBaseT>();
		}

		// Token: 0x0601ECB8 RID: 126136 RVA: 0x0044E29A File Offset: 0x0044C49A
		public static IFrequencyDetectLineConfigBase_UnionUnion FromIFrequencyDetectLineConfigBase(IFrequencyDetectLineConfigBaseT _ifrequencydetectlineconfigbase)
		{
			return new IFrequencyDetectLineConfigBase_UnionUnion
			{
				Type = IFrequencyDetectLineConfigBase_Union.IFrequencyDetectLineConfigBase,
				Value = _ifrequencydetectlineconfigbase
			};
		}

		// Token: 0x0601ECB9 RID: 126137 RVA: 0x0044E2AF File Offset: 0x0044C4AF
		public IFrequencyDetectAiLineConfigT AsIFrequencyDetectAiLineConfig()
		{
			return this.As<IFrequencyDetectAiLineConfigT>();
		}

		// Token: 0x0601ECBA RID: 126138 RVA: 0x0044E2B7 File Offset: 0x0044C4B7
		public static IFrequencyDetectLineConfigBase_UnionUnion FromIFrequencyDetectAiLineConfig(IFrequencyDetectAiLineConfigT _ifrequencydetectailineconfig)
		{
			return new IFrequencyDetectLineConfigBase_UnionUnion
			{
				Type = IFrequencyDetectLineConfigBase_Union.IFrequencyDetectAiLineConfig,
				Value = _ifrequencydetectailineconfig
			};
		}

		// Token: 0x0601ECBB RID: 126139 RVA: 0x0044E2CC File Offset: 0x0044C4CC
		public IFrequencyDetectPlayerLineConfigT AsIFrequencyDetectPlayerLineConfig()
		{
			return this.As<IFrequencyDetectPlayerLineConfigT>();
		}

		// Token: 0x0601ECBC RID: 126140 RVA: 0x0044E2D4 File Offset: 0x0044C4D4
		public static IFrequencyDetectLineConfigBase_UnionUnion FromIFrequencyDetectPlayerLineConfig(IFrequencyDetectPlayerLineConfigT _ifrequencydetectplayerlineconfig)
		{
			return new IFrequencyDetectLineConfigBase_UnionUnion
			{
				Type = IFrequencyDetectLineConfigBase_Union.IFrequencyDetectPlayerLineConfig,
				Value = _ifrequencydetectplayerlineconfig
			};
		}

		// Token: 0x0601ECBD RID: 126141 RVA: 0x0044E2EC File Offset: 0x0044C4EC
		public static int Pack(FlatBufferBuilder builder, IFrequencyDetectLineConfigBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFrequencyDetectLineConfigBase_Union.IFrequencyDetectLineConfigBase:
				return IFrequencyDetectLineConfigBase.Pack(builder, _o.AsIFrequencyDetectLineConfigBase()).Value;
			case IFrequencyDetectLineConfigBase_Union.IFrequencyDetectAiLineConfig:
				return IFrequencyDetectAiLineConfig.Pack(builder, _o.AsIFrequencyDetectAiLineConfig()).Value;
			case IFrequencyDetectLineConfigBase_Union.IFrequencyDetectPlayerLineConfig:
				return IFrequencyDetectPlayerLineConfig.Pack(builder, _o.AsIFrequencyDetectPlayerLineConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
