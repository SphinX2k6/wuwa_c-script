using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A9 RID: 16809
	public class ICombatState2ConditionT
	{
		// Token: 0x1700721F RID: 29215
		// (get) Token: 0x06017372 RID: 95090 RVA: 0x003506A1 File Offset: 0x0034E8A1
		// (set) Token: 0x06017373 RID: 95091 RVA: 0x003506A9 File Offset: 0x0034E8A9
		public int EntityId { get; set; }

		// Token: 0x17007220 RID: 29216
		// (get) Token: 0x06017374 RID: 95092 RVA: 0x003506B2 File Offset: 0x0034E8B2
		// (set) Token: 0x06017375 RID: 95093 RVA: 0x003506BA File Offset: 0x0034E8BA
		public string State { get; set; }

		// Token: 0x17007221 RID: 29217
		// (get) Token: 0x06017376 RID: 95094 RVA: 0x003506C3 File Offset: 0x0034E8C3
		// (set) Token: 0x06017377 RID: 95095 RVA: 0x003506CB File Offset: 0x0034E8CB
		public ECompare Compare { get; set; }

		// Token: 0x17007222 RID: 29218
		// (get) Token: 0x06017378 RID: 95096 RVA: 0x003506D4 File Offset: 0x0034E8D4
		// (set) Token: 0x06017379 RID: 95097 RVA: 0x003506DC File Offset: 0x0034E8DC
		public EDetectTarget DetectTarget { get; set; }

		// Token: 0x17007223 RID: 29219
		// (get) Token: 0x0601737A RID: 95098 RVA: 0x003506E5 File Offset: 0x0034E8E5
		// (set) Token: 0x0601737B RID: 95099 RVA: 0x003506ED File Offset: 0x0034E8ED
		public byte NullMask { get; set; }

		// Token: 0x0601737C RID: 95100 RVA: 0x003506F6 File Offset: 0x0034E8F6
		public ICombatState2ConditionT()
		{
			this.EntityId = 0;
			this.State = null;
			this.Compare = ECompare.Eq;
			this.DetectTarget = EDetectTarget.ControlledRole;
			this.NullMask = 0;
		}
	}
}
