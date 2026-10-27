using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007590 RID: 30096
	public class IVisualNovelOptionGroupConfigBase_UnionUnion
	{
		// Token: 0x1700E431 RID: 58417
		// (get) Token: 0x06036BE8 RID: 224232 RVA: 0x0076E7C5 File Offset: 0x0076C9C5
		// (set) Token: 0x06036BE9 RID: 224233 RVA: 0x0076E7CD File Offset: 0x0076C9CD
		public IVisualNovelOptionGroupConfigBase_Union Type { get; set; }

		// Token: 0x1700E432 RID: 58418
		// (get) Token: 0x06036BEA RID: 224234 RVA: 0x0076E7D6 File Offset: 0x0076C9D6
		// (set) Token: 0x06036BEB RID: 224235 RVA: 0x0076E7DE File Offset: 0x0076C9DE
		public object Value { get; set; }

		// Token: 0x06036BEC RID: 224236 RVA: 0x0076E7E7 File Offset: 0x0076C9E7
		public IVisualNovelOptionGroupConfigBase_UnionUnion()
		{
			this.Type = IVisualNovelOptionGroupConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036BED RID: 224237 RVA: 0x0076E7FD File Offset: 0x0076C9FD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036BEE RID: 224238 RVA: 0x0076E80F File Offset: 0x0076CA0F
		public IVisualNovelOptionGroupConfigBaseT AsIVisualNovelOptionGroupConfigBase()
		{
			return this.As<IVisualNovelOptionGroupConfigBaseT>();
		}

		// Token: 0x06036BEF RID: 224239 RVA: 0x0076E817 File Offset: 0x0076CA17
		public static IVisualNovelOptionGroupConfigBase_UnionUnion FromIVisualNovelOptionGroupConfigBase(IVisualNovelOptionGroupConfigBaseT _ivisualnoveloptiongroupconfigbase)
		{
			return new IVisualNovelOptionGroupConfigBase_UnionUnion
			{
				Type = IVisualNovelOptionGroupConfigBase_Union.IVisualNovelOptionGroupConfigBase,
				Value = _ivisualnoveloptiongroupconfigbase
			};
		}

		// Token: 0x06036BF0 RID: 224240 RVA: 0x0076E82C File Offset: 0x0076CA2C
		public IVisualNovelOptionGroupSolarSchoolExamT AsIVisualNovelOptionGroupSolarSchoolExam()
		{
			return this.As<IVisualNovelOptionGroupSolarSchoolExamT>();
		}

		// Token: 0x06036BF1 RID: 224241 RVA: 0x0076E834 File Offset: 0x0076CA34
		public static IVisualNovelOptionGroupConfigBase_UnionUnion FromIVisualNovelOptionGroupSolarSchoolExam(IVisualNovelOptionGroupSolarSchoolExamT _ivisualnoveloptiongroupsolarschoolexam)
		{
			return new IVisualNovelOptionGroupConfigBase_UnionUnion
			{
				Type = IVisualNovelOptionGroupConfigBase_Union.IVisualNovelOptionGroupSolarSchoolExam,
				Value = _ivisualnoveloptiongroupsolarschoolexam
			};
		}

		// Token: 0x06036BF2 RID: 224242 RVA: 0x0076E84C File Offset: 0x0076CA4C
		public static int Pack(FlatBufferBuilder builder, IVisualNovelOptionGroupConfigBase_UnionUnion _o)
		{
			IVisualNovelOptionGroupConfigBase_Union type = _o.Type;
			if (type == IVisualNovelOptionGroupConfigBase_Union.IVisualNovelOptionGroupConfigBase)
			{
				return IVisualNovelOptionGroupConfigBase.Pack(builder, _o.AsIVisualNovelOptionGroupConfigBase()).Value;
			}
			if (type != IVisualNovelOptionGroupConfigBase_Union.IVisualNovelOptionGroupSolarSchoolExam)
			{
				return 0;
			}
			return IVisualNovelOptionGroupSolarSchoolExam.Pack(builder, _o.AsIVisualNovelOptionGroupSolarSchoolExam()).Value;
		}
	}
}
