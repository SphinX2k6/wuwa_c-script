using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA8 RID: 28072
	public class IPreprocessOperationConfig_UnionUnion
	{
		// Token: 0x1700D15D RID: 53597
		// (get) Token: 0x0603196D RID: 203117 RVA: 0x006B8631 File Offset: 0x006B6831
		// (set) Token: 0x0603196E RID: 203118 RVA: 0x006B8639 File Offset: 0x006B6839
		public IPreprocessOperationConfig_Union Type { get; set; }

		// Token: 0x1700D15E RID: 53598
		// (get) Token: 0x0603196F RID: 203119 RVA: 0x006B8642 File Offset: 0x006B6842
		// (set) Token: 0x06031970 RID: 203120 RVA: 0x006B864A File Offset: 0x006B684A
		public object Value { get; set; }

		// Token: 0x06031971 RID: 203121 RVA: 0x006B8653 File Offset: 0x006B6853
		public IPreprocessOperationConfig_UnionUnion()
		{
			this.Type = IPreprocessOperationConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031972 RID: 203122 RVA: 0x006B8669 File Offset: 0x006B6869
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031973 RID: 203123 RVA: 0x006B867B File Offset: 0x006B687B
		public IPreprocessOperationConfigT AsIPreprocessOperationConfig()
		{
			return this.As<IPreprocessOperationConfigT>();
		}

		// Token: 0x06031974 RID: 203124 RVA: 0x006B8683 File Offset: 0x006B6883
		public static IPreprocessOperationConfig_UnionUnion FromIPreprocessOperationConfig(IPreprocessOperationConfigT _ipreprocessoperationconfig)
		{
			return new IPreprocessOperationConfig_UnionUnion
			{
				Type = IPreprocessOperationConfig_Union.IPreprocessOperationConfig,
				Value = _ipreprocessoperationconfig
			};
		}

		// Token: 0x06031975 RID: 203125 RVA: 0x006B8698 File Offset: 0x006B6898
		public IFloatingSubtitleLanguageDiffT AsIFloatingSubtitleLanguageDiff()
		{
			return this.As<IFloatingSubtitleLanguageDiffT>();
		}

		// Token: 0x06031976 RID: 203126 RVA: 0x006B86A0 File Offset: 0x006B68A0
		public static IPreprocessOperationConfig_UnionUnion FromIFloatingSubtitleLanguageDiff(IFloatingSubtitleLanguageDiffT _ifloatingsubtitlelanguagediff)
		{
			return new IPreprocessOperationConfig_UnionUnion
			{
				Type = IPreprocessOperationConfig_Union.IFloatingSubtitleLanguageDiff,
				Value = _ifloatingsubtitlelanguagediff
			};
		}

		// Token: 0x06031977 RID: 203127 RVA: 0x006B86B8 File Offset: 0x006B68B8
		public static int Pack(FlatBufferBuilder builder, IPreprocessOperationConfig_UnionUnion _o)
		{
			IPreprocessOperationConfig_Union type = _o.Type;
			if (type == IPreprocessOperationConfig_Union.IPreprocessOperationConfig)
			{
				return IPreprocessOperationConfig.Pack(builder, _o.AsIPreprocessOperationConfig()).Value;
			}
			if (type != IPreprocessOperationConfig_Union.IFloatingSubtitleLanguageDiff)
			{
				return 0;
			}
			return IFloatingSubtitleLanguageDiff.Pack(builder, _o.AsIFloatingSubtitleLanguageDiff()).Value;
		}
	}
}
