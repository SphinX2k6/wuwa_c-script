using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D49 RID: 19785
	public class TAreaConflictSelectorUnion
	{
		// Token: 0x17008DB8 RID: 36280
		// (get) Token: 0x0601EADF RID: 125663 RVA: 0x0044AE08 File Offset: 0x00449008
		// (set) Token: 0x0601EAE0 RID: 125664 RVA: 0x0044AE10 File Offset: 0x00449010
		public TAreaConflictSelector Type { get; set; }

		// Token: 0x17008DB9 RID: 36281
		// (get) Token: 0x0601EAE1 RID: 125665 RVA: 0x0044AE19 File Offset: 0x00449019
		// (set) Token: 0x0601EAE2 RID: 125666 RVA: 0x0044AE21 File Offset: 0x00449021
		public object Value { get; set; }

		// Token: 0x0601EAE3 RID: 125667 RVA: 0x0044AE2A File Offset: 0x0044902A
		public TAreaConflictSelectorUnion()
		{
			this.Type = TAreaConflictSelector.NONE;
			this.Value = null;
		}

		// Token: 0x0601EAE4 RID: 125668 RVA: 0x0044AE40 File Offset: 0x00449040
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EAE5 RID: 125669 RVA: 0x0044AE52 File Offset: 0x00449052
		public ICustomShapeAreaConflictSelectorT AsICustomShapeAreaConflictSelector()
		{
			return this.As<ICustomShapeAreaConflictSelectorT>();
		}

		// Token: 0x0601EAE6 RID: 125670 RVA: 0x0044AE5A File Offset: 0x0044905A
		public static TAreaConflictSelectorUnion FromICustomShapeAreaConflictSelector(ICustomShapeAreaConflictSelectorT _icustomshapeareaconflictselector)
		{
			return new TAreaConflictSelectorUnion
			{
				Type = TAreaConflictSelector.ICustomShapeAreaConflictSelector,
				Value = _icustomshapeareaconflictselector
			};
		}

		// Token: 0x0601EAE7 RID: 125671 RVA: 0x0044AE6F File Offset: 0x0044906F
		public ILevelPlayAreaConflictSelectorT AsILevelPlayAreaConflictSelector()
		{
			return this.As<ILevelPlayAreaConflictSelectorT>();
		}

		// Token: 0x0601EAE8 RID: 125672 RVA: 0x0044AE77 File Offset: 0x00449077
		public static TAreaConflictSelectorUnion FromILevelPlayAreaConflictSelector(ILevelPlayAreaConflictSelectorT _ilevelplayareaconflictselector)
		{
			return new TAreaConflictSelectorUnion
			{
				Type = TAreaConflictSelector.ILevelPlayAreaConflictSelector,
				Value = _ilevelplayareaconflictselector
			};
		}

		// Token: 0x0601EAE9 RID: 125673 RVA: 0x0044AE8C File Offset: 0x0044908C
		public IQuestAreaConflictSelectorT AsIQuestAreaConflictSelector()
		{
			return this.As<IQuestAreaConflictSelectorT>();
		}

		// Token: 0x0601EAEA RID: 125674 RVA: 0x0044AE94 File Offset: 0x00449094
		public static TAreaConflictSelectorUnion FromIQuestAreaConflictSelector(IQuestAreaConflictSelectorT _iquestareaconflictselector)
		{
			return new TAreaConflictSelectorUnion
			{
				Type = TAreaConflictSelector.IQuestAreaConflictSelector,
				Value = _iquestareaconflictselector
			};
		}

		// Token: 0x0601EAEB RID: 125675 RVA: 0x0044AEAC File Offset: 0x004490AC
		public static int Pack(FlatBufferBuilder builder, TAreaConflictSelectorUnion _o)
		{
			switch (_o.Type)
			{
			case TAreaConflictSelector.ICustomShapeAreaConflictSelector:
				return ICustomShapeAreaConflictSelector.Pack(builder, _o.AsICustomShapeAreaConflictSelector()).Value;
			case TAreaConflictSelector.ILevelPlayAreaConflictSelector:
				return ILevelPlayAreaConflictSelector.Pack(builder, _o.AsILevelPlayAreaConflictSelector()).Value;
			case TAreaConflictSelector.IQuestAreaConflictSelector:
				return IQuestAreaConflictSelector.Pack(builder, _o.AsIQuestAreaConflictSelector()).Value;
			default:
				return 0;
			}
		}
	}
}
