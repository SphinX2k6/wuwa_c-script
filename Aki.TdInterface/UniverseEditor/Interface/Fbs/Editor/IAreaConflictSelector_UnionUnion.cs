using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004821 RID: 18465
	public class IAreaConflictSelector_UnionUnion
	{
		// Token: 0x17008474 RID: 33908
		// (get) Token: 0x0601C845 RID: 116805 RVA: 0x004086F1 File Offset: 0x004068F1
		// (set) Token: 0x0601C846 RID: 116806 RVA: 0x004086F9 File Offset: 0x004068F9
		public IAreaConflictSelector_Union Type { get; set; }

		// Token: 0x17008475 RID: 33909
		// (get) Token: 0x0601C847 RID: 116807 RVA: 0x00408702 File Offset: 0x00406902
		// (set) Token: 0x0601C848 RID: 116808 RVA: 0x0040870A File Offset: 0x0040690A
		public object Value { get; set; }

		// Token: 0x0601C849 RID: 116809 RVA: 0x00408713 File Offset: 0x00406913
		public IAreaConflictSelector_UnionUnion()
		{
			this.Type = IAreaConflictSelector_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601C84A RID: 116810 RVA: 0x00408729 File Offset: 0x00406929
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601C84B RID: 116811 RVA: 0x0040873B File Offset: 0x0040693B
		public IAreaConflictSelectorT AsIAreaConflictSelector()
		{
			return this.As<IAreaConflictSelectorT>();
		}

		// Token: 0x0601C84C RID: 116812 RVA: 0x00408743 File Offset: 0x00406943
		public static IAreaConflictSelector_UnionUnion FromIAreaConflictSelector(IAreaConflictSelectorT _iareaconflictselector)
		{
			return new IAreaConflictSelector_UnionUnion
			{
				Type = IAreaConflictSelector_Union.IAreaConflictSelector,
				Value = _iareaconflictselector
			};
		}

		// Token: 0x0601C84D RID: 116813 RVA: 0x00408758 File Offset: 0x00406958
		public IQuestAreaConflictSelectorT AsIQuestAreaConflictSelector()
		{
			return this.As<IQuestAreaConflictSelectorT>();
		}

		// Token: 0x0601C84E RID: 116814 RVA: 0x00408760 File Offset: 0x00406960
		public static IAreaConflictSelector_UnionUnion FromIQuestAreaConflictSelector(IQuestAreaConflictSelectorT _iquestareaconflictselector)
		{
			return new IAreaConflictSelector_UnionUnion
			{
				Type = IAreaConflictSelector_Union.IQuestAreaConflictSelector,
				Value = _iquestareaconflictselector
			};
		}

		// Token: 0x0601C84F RID: 116815 RVA: 0x00408775 File Offset: 0x00406975
		public ILevelPlayAreaConflictSelectorT AsILevelPlayAreaConflictSelector()
		{
			return this.As<ILevelPlayAreaConflictSelectorT>();
		}

		// Token: 0x0601C850 RID: 116816 RVA: 0x0040877D File Offset: 0x0040697D
		public static IAreaConflictSelector_UnionUnion FromILevelPlayAreaConflictSelector(ILevelPlayAreaConflictSelectorT _ilevelplayareaconflictselector)
		{
			return new IAreaConflictSelector_UnionUnion
			{
				Type = IAreaConflictSelector_Union.ILevelPlayAreaConflictSelector,
				Value = _ilevelplayareaconflictselector
			};
		}

		// Token: 0x0601C851 RID: 116817 RVA: 0x00408792 File Offset: 0x00406992
		public ICustomShapeAreaConflictSelectorT AsICustomShapeAreaConflictSelector()
		{
			return this.As<ICustomShapeAreaConflictSelectorT>();
		}

		// Token: 0x0601C852 RID: 116818 RVA: 0x0040879A File Offset: 0x0040699A
		public static IAreaConflictSelector_UnionUnion FromICustomShapeAreaConflictSelector(ICustomShapeAreaConflictSelectorT _icustomshapeareaconflictselector)
		{
			return new IAreaConflictSelector_UnionUnion
			{
				Type = IAreaConflictSelector_Union.ICustomShapeAreaConflictSelector,
				Value = _icustomshapeareaconflictselector
			};
		}

		// Token: 0x0601C853 RID: 116819 RVA: 0x004087B0 File Offset: 0x004069B0
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
