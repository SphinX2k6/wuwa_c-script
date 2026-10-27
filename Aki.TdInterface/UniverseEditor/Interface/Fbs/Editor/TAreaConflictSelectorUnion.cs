using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048E4 RID: 18660
	public class TAreaConflictSelectorUnion
	{
		// Token: 0x17008770 RID: 34672
		// (get) Token: 0x0601D2F2 RID: 119538 RVA: 0x0041E66C File Offset: 0x0041C86C
		// (set) Token: 0x0601D2F3 RID: 119539 RVA: 0x0041E674 File Offset: 0x0041C874
		public TAreaConflictSelector Type { get; set; }

		// Token: 0x17008771 RID: 34673
		// (get) Token: 0x0601D2F4 RID: 119540 RVA: 0x0041E67D File Offset: 0x0041C87D
		// (set) Token: 0x0601D2F5 RID: 119541 RVA: 0x0041E685 File Offset: 0x0041C885
		public object Value { get; set; }

		// Token: 0x0601D2F6 RID: 119542 RVA: 0x0041E68E File Offset: 0x0041C88E
		public TAreaConflictSelectorUnion()
		{
			this.Type = TAreaConflictSelector.NONE;
			this.Value = null;
		}

		// Token: 0x0601D2F7 RID: 119543 RVA: 0x0041E6A4 File Offset: 0x0041C8A4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601D2F8 RID: 119544 RVA: 0x0041E6B6 File Offset: 0x0041C8B6
		public ICustomShapeAreaConflictSelectorT AsICustomShapeAreaConflictSelector()
		{
			return this.As<ICustomShapeAreaConflictSelectorT>();
		}

		// Token: 0x0601D2F9 RID: 119545 RVA: 0x0041E6BE File Offset: 0x0041C8BE
		public static TAreaConflictSelectorUnion FromICustomShapeAreaConflictSelector(ICustomShapeAreaConflictSelectorT _icustomshapeareaconflictselector)
		{
			return new TAreaConflictSelectorUnion
			{
				Type = TAreaConflictSelector.ICustomShapeAreaConflictSelector,
				Value = _icustomshapeareaconflictselector
			};
		}

		// Token: 0x0601D2FA RID: 119546 RVA: 0x0041E6D3 File Offset: 0x0041C8D3
		public ILevelPlayAreaConflictSelectorT AsILevelPlayAreaConflictSelector()
		{
			return this.As<ILevelPlayAreaConflictSelectorT>();
		}

		// Token: 0x0601D2FB RID: 119547 RVA: 0x0041E6DB File Offset: 0x0041C8DB
		public static TAreaConflictSelectorUnion FromILevelPlayAreaConflictSelector(ILevelPlayAreaConflictSelectorT _ilevelplayareaconflictselector)
		{
			return new TAreaConflictSelectorUnion
			{
				Type = TAreaConflictSelector.ILevelPlayAreaConflictSelector,
				Value = _ilevelplayareaconflictselector
			};
		}

		// Token: 0x0601D2FC RID: 119548 RVA: 0x0041E6F0 File Offset: 0x0041C8F0
		public IQuestAreaConflictSelectorT AsIQuestAreaConflictSelector()
		{
			return this.As<IQuestAreaConflictSelectorT>();
		}

		// Token: 0x0601D2FD RID: 119549 RVA: 0x0041E6F8 File Offset: 0x0041C8F8
		public static TAreaConflictSelectorUnion FromIQuestAreaConflictSelector(IQuestAreaConflictSelectorT _iquestareaconflictselector)
		{
			return new TAreaConflictSelectorUnion
			{
				Type = TAreaConflictSelector.IQuestAreaConflictSelector,
				Value = _iquestareaconflictselector
			};
		}

		// Token: 0x0601D2FE RID: 119550 RVA: 0x0041E710 File Offset: 0x0041C910
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
