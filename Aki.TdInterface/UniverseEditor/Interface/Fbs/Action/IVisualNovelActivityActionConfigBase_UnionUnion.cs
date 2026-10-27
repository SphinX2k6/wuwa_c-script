using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007554 RID: 30036
	public class IVisualNovelActivityActionConfigBase_UnionUnion
	{
		// Token: 0x1700E3DF RID: 58335
		// (get) Token: 0x06036A58 RID: 223832 RVA: 0x0076C315 File Offset: 0x0076A515
		// (set) Token: 0x06036A59 RID: 223833 RVA: 0x0076C31D File Offset: 0x0076A51D
		public IVisualNovelActivityActionConfigBase_Union Type { get; set; }

		// Token: 0x1700E3E0 RID: 58336
		// (get) Token: 0x06036A5A RID: 223834 RVA: 0x0076C326 File Offset: 0x0076A526
		// (set) Token: 0x06036A5B RID: 223835 RVA: 0x0076C32E File Offset: 0x0076A52E
		public object Value { get; set; }

		// Token: 0x06036A5C RID: 223836 RVA: 0x0076C337 File Offset: 0x0076A537
		public IVisualNovelActivityActionConfigBase_UnionUnion()
		{
			this.Type = IVisualNovelActivityActionConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036A5D RID: 223837 RVA: 0x0076C34D File Offset: 0x0076A54D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036A5E RID: 223838 RVA: 0x0076C35F File Offset: 0x0076A55F
		public IVisualNovelActivityActionConfigBaseT AsIVisualNovelActivityActionConfigBase()
		{
			return this.As<IVisualNovelActivityActionConfigBaseT>();
		}

		// Token: 0x06036A5F RID: 223839 RVA: 0x0076C367 File Offset: 0x0076A567
		public static IVisualNovelActivityActionConfigBase_UnionUnion FromIVisualNovelActivityActionConfigBase(IVisualNovelActivityActionConfigBaseT _ivisualnovelactivityactionconfigbase)
		{
			return new IVisualNovelActivityActionConfigBase_UnionUnion
			{
				Type = IVisualNovelActivityActionConfigBase_Union.IVisualNovelActivityActionConfigBase,
				Value = _ivisualnovelactivityactionconfigbase
			};
		}

		// Token: 0x06036A60 RID: 223840 RVA: 0x0076C37C File Offset: 0x0076A57C
		public IVisualNovelActivityActionSolarSchoolT AsIVisualNovelActivityActionSolarSchool()
		{
			return this.As<IVisualNovelActivityActionSolarSchoolT>();
		}

		// Token: 0x06036A61 RID: 223841 RVA: 0x0076C384 File Offset: 0x0076A584
		public static IVisualNovelActivityActionConfigBase_UnionUnion FromIVisualNovelActivityActionSolarSchool(IVisualNovelActivityActionSolarSchoolT _ivisualnovelactivityactionsolarschool)
		{
			return new IVisualNovelActivityActionConfigBase_UnionUnion
			{
				Type = IVisualNovelActivityActionConfigBase_Union.IVisualNovelActivityActionSolarSchool,
				Value = _ivisualnovelactivityactionsolarschool
			};
		}

		// Token: 0x06036A62 RID: 223842 RVA: 0x0076C39C File Offset: 0x0076A59C
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
