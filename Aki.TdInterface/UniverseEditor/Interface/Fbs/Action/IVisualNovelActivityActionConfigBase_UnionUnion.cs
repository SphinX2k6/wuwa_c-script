using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D4A RID: 32074
	public class IVisualNovelActivityActionConfigBase_UnionUnion
	{
		// Token: 0x1700F009 RID: 61449
		// (get) Token: 0x06039E6E RID: 237166 RVA: 0x007CF5BD File Offset: 0x007CD7BD
		// (set) Token: 0x06039E6F RID: 237167 RVA: 0x007CF5C5 File Offset: 0x007CD7C5
		public IVisualNovelActivityActionConfigBase_Union Type { get; set; }

		// Token: 0x1700F00A RID: 61450
		// (get) Token: 0x06039E70 RID: 237168 RVA: 0x007CF5CE File Offset: 0x007CD7CE
		// (set) Token: 0x06039E71 RID: 237169 RVA: 0x007CF5D6 File Offset: 0x007CD7D6
		public object Value { get; set; }

		// Token: 0x06039E72 RID: 237170 RVA: 0x007CF5DF File Offset: 0x007CD7DF
		public IVisualNovelActivityActionConfigBase_UnionUnion()
		{
			this.Type = IVisualNovelActivityActionConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06039E73 RID: 237171 RVA: 0x007CF5F5 File Offset: 0x007CD7F5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039E74 RID: 237172 RVA: 0x007CF607 File Offset: 0x007CD807
		public IVisualNovelActivityActionConfigBaseT AsIVisualNovelActivityActionConfigBase()
		{
			return this.As<IVisualNovelActivityActionConfigBaseT>();
		}

		// Token: 0x06039E75 RID: 237173 RVA: 0x007CF60F File Offset: 0x007CD80F
		public static IVisualNovelActivityActionConfigBase_UnionUnion FromIVisualNovelActivityActionConfigBase(IVisualNovelActivityActionConfigBaseT _ivisualnovelactivityactionconfigbase)
		{
			return new IVisualNovelActivityActionConfigBase_UnionUnion
			{
				Type = IVisualNovelActivityActionConfigBase_Union.IVisualNovelActivityActionConfigBase,
				Value = _ivisualnovelactivityactionconfigbase
			};
		}

		// Token: 0x06039E76 RID: 237174 RVA: 0x007CF624 File Offset: 0x007CD824
		public IVisualNovelActivityActionSolarSchoolT AsIVisualNovelActivityActionSolarSchool()
		{
			return this.As<IVisualNovelActivityActionSolarSchoolT>();
		}

		// Token: 0x06039E77 RID: 237175 RVA: 0x007CF62C File Offset: 0x007CD82C
		public static IVisualNovelActivityActionConfigBase_UnionUnion FromIVisualNovelActivityActionSolarSchool(IVisualNovelActivityActionSolarSchoolT _ivisualnovelactivityactionsolarschool)
		{
			return new IVisualNovelActivityActionConfigBase_UnionUnion
			{
				Type = IVisualNovelActivityActionConfigBase_Union.IVisualNovelActivityActionSolarSchool,
				Value = _ivisualnovelactivityactionsolarschool
			};
		}

		// Token: 0x06039E78 RID: 237176 RVA: 0x007CF644 File Offset: 0x007CD844
		public static int Pack(FlatBufferBuilder builder, IVisualNovelActivityActionConfigBase_UnionUnion _o)
		{
			IVisualNovelActivityActionConfigBase_Union type = _o.Type;
			if (type == IVisualNovelActivityActionConfigBase_Union.IVisualNovelActivityActionConfigBase)
			{
				return IVisualNovelActivityActionConfigBase.Pack(builder, _o.AsIVisualNovelActivityActionConfigBase()).Value;
			}
			if (type != IVisualNovelActivityActionConfigBase_Union.IVisualNovelActivityActionSolarSchool)
			{
				return 0;
			}
			return IVisualNovelActivityActionSolarSchool.Pack(builder, _o.AsIVisualNovelActivityActionSolarSchool()).Value;
		}
	}
}
