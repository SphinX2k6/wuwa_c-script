using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A31 RID: 18993
	public class ICheckFormationRoleInfoConditionT
	{
		// Token: 0x1700897E RID: 35198
		// (get) Token: 0x0601DBA4 RID: 121764 RVA: 0x0042E54B File Offset: 0x0042C74B
		// (set) Token: 0x0601DBA5 RID: 121765 RVA: 0x0042E553 File Offset: 0x0042C753
		public ECondition Type { get; set; }

		// Token: 0x1700897F RID: 35199
		// (get) Token: 0x0601DBA6 RID: 121766 RVA: 0x0042E55C File Offset: 0x0042C75C
		// (set) Token: 0x0601DBA7 RID: 121767 RVA: 0x0042E564 File Offset: 0x0042C764
		public TCheckFormationRoleInfoUnion Option { get; set; }

		// Token: 0x0601DBA8 RID: 121768 RVA: 0x0042E56D File Offset: 0x0042C76D
		public ICheckFormationRoleInfoConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Option = null;
		}
	}
}
