using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007523 RID: 29987
	public class IPreprocessOperationConfig_UnionUnion
	{
		// Token: 0x1700DCA5 RID: 56485
		// (get) Token: 0x06034969 RID: 215401 RVA: 0x00713D19 File Offset: 0x00711F19
		// (set) Token: 0x0603496A RID: 215402 RVA: 0x00713D21 File Offset: 0x00711F21
		public IPreprocessOperationConfig_Union Type { get; set; }

		// Token: 0x1700DCA6 RID: 56486
		// (get) Token: 0x0603496B RID: 215403 RVA: 0x00713D2A File Offset: 0x00711F2A
		// (set) Token: 0x0603496C RID: 215404 RVA: 0x00713D32 File Offset: 0x00711F32
		public object Value { get; set; }

		// Token: 0x0603496D RID: 215405 RVA: 0x00713D3B File Offset: 0x00711F3B
		public IPreprocessOperationConfig_UnionUnion()
		{
			this.Type = IPreprocessOperationConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603496E RID: 215406 RVA: 0x00713D51 File Offset: 0x00711F51
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603496F RID: 215407 RVA: 0x00713D63 File Offset: 0x00711F63
		public IPreprocessOperationConfigT AsIPreprocessOperationConfig()
		{
			return this.As<IPreprocessOperationConfigT>();
		}

		// Token: 0x06034970 RID: 215408 RVA: 0x00713D6B File Offset: 0x00711F6B
		public static IPreprocessOperationConfig_UnionUnion FromIPreprocessOperationConfig(IPreprocessOperationConfigT _ipreprocessoperationconfig)
		{
			return new IPreprocessOperationConfig_UnionUnion
			{
				Type = IPreprocessOperationConfig_Union.IPreprocessOperationConfig,
				Value = _ipreprocessoperationconfig
			};
		}

		// Token: 0x06034971 RID: 215409 RVA: 0x00713D80 File Offset: 0x00711F80
		public IFloatingSubtitleLanguageDiffT AsIFloatingSubtitleLanguageDiff()
		{
			return this.As<IFloatingSubtitleLanguageDiffT>();
		}

		// Token: 0x06034972 RID: 215410 RVA: 0x00713D88 File Offset: 0x00711F88
		public static IPreprocessOperationConfig_UnionUnion FromIFloatingSubtitleLanguageDiff(IFloatingSubtitleLanguageDiffT _ifloatingsubtitlelanguagediff)
		{
			return new IPreprocessOperationConfig_UnionUnion
			{
				Type = IPreprocessOperationConfig_Union.IFloatingSubtitleLanguageDiff,
				Value = _ifloatingsubtitlelanguagediff
			};
		}

		// Token: 0x06034973 RID: 215411 RVA: 0x00713DA0 File Offset: 0x00711FA0
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
