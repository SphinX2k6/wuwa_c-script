using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005933 RID: 22835
	public class ISlidePerformType_UnionUnion
	{
		// Token: 0x1700AB5B RID: 43867
		// (get) Token: 0x06026A16 RID: 158230 RVA: 0x005521FD File Offset: 0x005503FD
		// (set) Token: 0x06026A17 RID: 158231 RVA: 0x00552205 File Offset: 0x00550405
		public ISlidePerformType_Union Type { get; set; }

		// Token: 0x1700AB5C RID: 43868
		// (get) Token: 0x06026A18 RID: 158232 RVA: 0x0055220E File Offset: 0x0055040E
		// (set) Token: 0x06026A19 RID: 158233 RVA: 0x00552216 File Offset: 0x00550416
		public object Value { get; set; }

		// Token: 0x06026A1A RID: 158234 RVA: 0x0055221F File Offset: 0x0055041F
		public ISlidePerformType_UnionUnion()
		{
			this.Type = ISlidePerformType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026A1B RID: 158235 RVA: 0x00552235 File Offset: 0x00550435
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026A1C RID: 158236 RVA: 0x00552247 File Offset: 0x00550447
		public ISlidePerformTypeT AsISlidePerformType()
		{
			return this.As<ISlidePerformTypeT>();
		}

		// Token: 0x06026A1D RID: 158237 RVA: 0x0055224F File Offset: 0x0055044F
		public static ISlidePerformType_UnionUnion FromISlidePerformType(ISlidePerformTypeT _islideperformtype)
		{
			return new ISlidePerformType_UnionUnion
			{
				Type = ISlidePerformType_Union.ISlidePerformType,
				Value = _islideperformtype
			};
		}

		// Token: 0x06026A1E RID: 158238 RVA: 0x00552264 File Offset: 0x00550464
		public ISlopeSlidePerformT AsISlopeSlidePerform()
		{
			return this.As<ISlopeSlidePerformT>();
		}

		// Token: 0x06026A1F RID: 158239 RVA: 0x0055226C File Offset: 0x0055046C
		public static ISlidePerformType_UnionUnion FromISlopeSlidePerform(ISlopeSlidePerformT _islopeslideperform)
		{
			return new ISlidePerformType_UnionUnion
			{
				Type = ISlidePerformType_Union.ISlopeSlidePerform,
				Value = _islopeslideperform
			};
		}

		// Token: 0x06026A20 RID: 158240 RVA: 0x00552284 File Offset: 0x00550484
		public static int Pack(FlatBufferBuilder builder, ISlidePerformType_UnionUnion _o)
		{
			ISlidePerformType_Union type = _o.Type;
			if (type == ISlidePerformType_Union.ISlidePerformType)
			{
				return ISlidePerformType.Pack(builder, _o.AsISlidePerformType()).Value;
			}
			if (type != ISlidePerformType_Union.ISlopeSlidePerform)
			{
				return 0;
			}
			return ISlopeSlidePerform.Pack(builder, _o.AsISlopeSlidePerform()).Value;
		}
	}
}
