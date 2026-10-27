using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071BB RID: 29115
	public class IStartSlidePerformType_UnionUnion
	{
		// Token: 0x1700D838 RID: 55352
		// (get) Token: 0x06033A02 RID: 211458 RVA: 0x006F3B61 File Offset: 0x006F1D61
		// (set) Token: 0x06033A03 RID: 211459 RVA: 0x006F3B69 File Offset: 0x006F1D69
		public IStartSlidePerformType_Union Type { get; set; }

		// Token: 0x1700D839 RID: 55353
		// (get) Token: 0x06033A04 RID: 211460 RVA: 0x006F3B72 File Offset: 0x006F1D72
		// (set) Token: 0x06033A05 RID: 211461 RVA: 0x006F3B7A File Offset: 0x006F1D7A
		public object Value { get; set; }

		// Token: 0x06033A06 RID: 211462 RVA: 0x006F3B83 File Offset: 0x006F1D83
		public IStartSlidePerformType_UnionUnion()
		{
			this.Type = IStartSlidePerformType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033A07 RID: 211463 RVA: 0x006F3B99 File Offset: 0x006F1D99
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033A08 RID: 211464 RVA: 0x006F3BAB File Offset: 0x006F1DAB
		public IStartSlidePerformTypeT AsIStartSlidePerformType()
		{
			return this.As<IStartSlidePerformTypeT>();
		}

		// Token: 0x06033A09 RID: 211465 RVA: 0x006F3BB3 File Offset: 0x006F1DB3
		public static IStartSlidePerformType_UnionUnion FromIStartSlidePerformType(IStartSlidePerformTypeT _istartslideperformtype)
		{
			return new IStartSlidePerformType_UnionUnion
			{
				Type = IStartSlidePerformType_Union.IStartSlidePerformType,
				Value = _istartslideperformtype
			};
		}

		// Token: 0x06033A0A RID: 211466 RVA: 0x006F3BC8 File Offset: 0x006F1DC8
		public ISlopeSlidePerformStartT AsISlopeSlidePerformStart()
		{
			return this.As<ISlopeSlidePerformStartT>();
		}

		// Token: 0x06033A0B RID: 211467 RVA: 0x006F3BD0 File Offset: 0x006F1DD0
		public static IStartSlidePerformType_UnionUnion FromISlopeSlidePerformStart(ISlopeSlidePerformStartT _islopeslideperformstart)
		{
			return new IStartSlidePerformType_UnionUnion
			{
				Type = IStartSlidePerformType_Union.ISlopeSlidePerformStart,
				Value = _islopeslideperformstart
			};
		}

		// Token: 0x06033A0C RID: 211468 RVA: 0x006F3BE8 File Offset: 0x006F1DE8
		public static int Pack(FlatBufferBuilder builder, IStartSlidePerformType_UnionUnion _o)
		{
			IStartSlidePerformType_Union type = _o.Type;
			if (type == IStartSlidePerformType_Union.IStartSlidePerformType)
			{
				return IStartSlidePerformType.Pack(builder, _o.AsIStartSlidePerformType()).Value;
			}
			if (type != IStartSlidePerformType_Union.ISlopeSlidePerformStart)
			{
				return 0;
			}
			return ISlopeSlidePerformStart.Pack(builder, _o.AsISlopeSlidePerformStart()).Value;
		}
	}
}
