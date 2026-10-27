using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053B4 RID: 21428
	public class IHookFetchComponentT
	{
		// Token: 0x17009D7F RID: 40319
		// (get) Token: 0x060231DA RID: 143834 RVA: 0x004DC8FD File Offset: 0x004DAAFD
		// (set) Token: 0x060231DB RID: 143835 RVA: 0x004DC905 File Offset: 0x004DAB05
		public bool Disabled { get; set; }

		// Token: 0x17009D80 RID: 40320
		// (get) Token: 0x060231DC RID: 143836 RVA: 0x004DC90E File Offset: 0x004DAB0E
		// (set) Token: 0x060231DD RID: 143837 RVA: 0x004DC916 File Offset: 0x004DAB16
		public ISphereTriggerShapeT Range { get; set; }

		// Token: 0x17009D81 RID: 40321
		// (get) Token: 0x060231DE RID: 143838 RVA: 0x004DC91F File Offset: 0x004DAB1F
		// (set) Token: 0x060231DF RID: 143839 RVA: 0x004DC927 File Offset: 0x004DAB27
		public bool UseRangeComponent { get; set; }

		// Token: 0x17009D82 RID: 40322
		// (get) Token: 0x060231E0 RID: 143840 RVA: 0x004DC930 File Offset: 0x004DAB30
		// (set) Token: 0x060231E1 RID: 143841 RVA: 0x004DC938 File Offset: 0x004DAB38
		public IHookFetchMoveUniformT MoveMode { get; set; }

		// Token: 0x17009D83 RID: 40323
		// (get) Token: 0x060231E2 RID: 143842 RVA: 0x004DC941 File Offset: 0x004DAB41
		// (set) Token: 0x060231E3 RID: 143843 RVA: 0x004DC949 File Offset: 0x004DAB49
		public IConditionGroupT HookEnableCondition { get; set; }

		// Token: 0x17009D84 RID: 40324
		// (get) Token: 0x060231E4 RID: 143844 RVA: 0x004DC952 File Offset: 0x004DAB52
		// (set) Token: 0x060231E5 RID: 143845 RVA: 0x004DC95A File Offset: 0x004DAB5A
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x17009D85 RID: 40325
		// (get) Token: 0x060231E6 RID: 143846 RVA: 0x004DC963 File Offset: 0x004DAB63
		// (set) Token: 0x060231E7 RID: 143847 RVA: 0x004DC96B File Offset: 0x004DAB6B
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17009D86 RID: 40326
		// (get) Token: 0x060231E8 RID: 143848 RVA: 0x004DC974 File Offset: 0x004DAB74
		// (set) Token: 0x060231E9 RID: 143849 RVA: 0x004DC97C File Offset: 0x004DAB7C
		public byte NullMask { get; set; }

		// Token: 0x060231EA RID: 143850 RVA: 0x004DC985 File Offset: 0x004DAB85
		public IHookFetchComponentT()
		{
			this.Disabled = false;
			this.Range = null;
			this.UseRangeComponent = false;
			this.MoveMode = null;
			this.HookEnableCondition = null;
			this.HookActions = null;
			this.FinishActions = null;
			this.NullMask = 0;
		}
	}
}
