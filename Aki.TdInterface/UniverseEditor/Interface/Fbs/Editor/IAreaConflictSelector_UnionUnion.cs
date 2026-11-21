using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C89 RID: 19593
	public class IAreaConflictSelector_UnionUnion
	{
		// Token: 0x17008ABF RID: 35519
		// (get) Token: 0x0601E042 RID: 122946 RVA: 0x00435041 File Offset: 0x00433241
		// (set) Token: 0x0601E043 RID: 122947 RVA: 0x00435049 File Offset: 0x00433249
		public IAreaConflictSelector_Union Type { get; set; }

		// Token: 0x17008AC0 RID: 35520
		// (get) Token: 0x0601E044 RID: 122948 RVA: 0x00435052 File Offset: 0x00433252
		// (set) Token: 0x0601E045 RID: 122949 RVA: 0x0043505A File Offset: 0x0043325A
		public object Value { get; set; }

		// Token: 0x0601E046 RID: 122950 RVA: 0x00435063 File Offset: 0x00433263
		public IAreaConflictSelector_UnionUnion()
		{
			this.Type = IAreaConflictSelector_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601E047 RID: 122951 RVA: 0x00435079 File Offset: 0x00433279
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601E048 RID: 122952 RVA: 0x0043508B File Offset: 0x0043328B
		public IAreaConflictSelectorT AsIAreaConflictSelector()
		{
			return this.As<IAreaConflictSelectorT>();
		}

		// Token: 0x0601E049 RID: 122953 RVA: 0x00435093 File Offset: 0x00433293
		public static IAreaConflictSelector_UnionUnion FromIAreaConflictSelector(IAreaConflictSelectorT _iareaconflictselector)
		{
			return new IAreaConflictSelector_UnionUnion
			{
				Type = IAreaConflictSelector_Union.IAreaConflictSelector,
				Value = _iareaconflictselector
			};
		}

		// Token: 0x0601E04A RID: 122954 RVA: 0x004350A8 File Offset: 0x004332A8
		public IQuestAreaConflictSelectorT AsIQuestAreaConflictSelector()
		{
			return this.As<IQuestAreaConflictSelectorT>();
		}

		// Token: 0x0601E04B RID: 122955 RVA: 0x004350B0 File Offset: 0x004332B0
		public static IAreaConflictSelector_UnionUnion FromIQuestAreaConflictSelector(IQuestAreaConflictSelectorT _iquestareaconflictselector)
		{
			return new IAreaConflictSelector_UnionUnion
			{
				Type = IAreaConflictSelector_Union.IQuestAreaConflictSelector,
				Value = _iquestareaconflictselector
			};
		}

		// Token: 0x0601E04C RID: 122956 RVA: 0x004350C5 File Offset: 0x004332C5
		public ILevelPlayAreaConflictSelectorT AsILevelPlayAreaConflictSelector()
		{
			return this.As<ILevelPlayAreaConflictSelectorT>();
		}

		// Token: 0x0601E04D RID: 122957 RVA: 0x004350CD File Offset: 0x004332CD
		public static IAreaConflictSelector_UnionUnion FromILevelPlayAreaConflictSelector(ILevelPlayAreaConflictSelectorT _ilevelplayareaconflictselector)
		{
			return new IAreaConflictSelector_UnionUnion
			{
				Type = IAreaConflictSelector_Union.ILevelPlayAreaConflictSelector,
				Value = _ilevelplayareaconflictselector
			};
		}

		// Token: 0x0601E04E RID: 122958 RVA: 0x004350E2 File Offset: 0x004332E2
		public ICustomShapeAreaConflictSelectorT AsICustomShapeAreaConflictSelector()
		{
			return this.As<ICustomShapeAreaConflictSelectorT>();
		}

		// Token: 0x0601E04F RID: 122959 RVA: 0x004350EA File Offset: 0x004332EA
		public static IAreaConflictSelector_UnionUnion FromICustomShapeAreaConflictSelector(ICustomShapeAreaConflictSelectorT _icustomshapeareaconflictselector)
		{
			return new IAreaConflictSelector_UnionUnion
			{
				Type = IAreaConflictSelector_Union.ICustomShapeAreaConflictSelector,
				Value = _icustomshapeareaconflictselector
			};
		}

		// Token: 0x0601E050 RID: 122960 RVA: 0x00435100 File Offset: 0x00433300
		public static int Pack(FlatBufferBuilder builder, IAreaConflictSelector_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IAreaConflictSelector_Union.IAreaConflictSelector:
				return IAreaConflictSelector.Pack(builder, _o.AsIAreaConflictSelector()).Value;
			case IAreaConflictSelector_Union.IQuestAreaConflictSelector:
				return IQuestAreaConflictSelector.Pack(builder, _o.AsIQuestAreaConflictSelector()).Value;
			case IAreaConflictSelector_Union.ILevelPlayAreaConflictSelector:
				return ILevelPlayAreaConflictSelector.Pack(builder, _o.AsILevelPlayAreaConflictSelector()).Value;
			case IAreaConflictSelector_Union.ICustomShapeAreaConflictSelector:
				return ICustomShapeAreaConflictSelector.Pack(builder, _o.AsICustomShapeAreaConflictSelector()).Value;
			default:
				return 0;
			}
		}
	}
}
