using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056BF RID: 22207
	public class IEntityBatchRefreshComponentT
	{
		// Token: 0x17009FDB RID: 40923
		// (get) Token: 0x06023958 RID: 145752 RVA: 0x004E4C2E File Offset: 0x004E2E2E
		// (set) Token: 0x06023959 RID: 145753 RVA: 0x004E4C36 File Offset: 0x004E2E36
		public bool Disabled { get; set; }

		// Token: 0x17009FDC RID: 40924
		// (get) Token: 0x0602395A RID: 145754 RVA: 0x004E4C3F File Offset: 0x004E2E3F
		// (set) Token: 0x0602395B RID: 145755 RVA: 0x004E4C47 File Offset: 0x004E2E47
		public IConditionGroupT StartCondition { get; set; }

		// Token: 0x17009FDD RID: 40925
		// (get) Token: 0x0602395C RID: 145756 RVA: 0x004E4C50 File Offset: 0x004E2E50
		// (set) Token: 0x0602395D RID: 145757 RVA: 0x004E4C58 File Offset: 0x004E2E58
		public IConditionGroupT EndCondition { get; set; }

		// Token: 0x17009FDE RID: 40926
		// (get) Token: 0x0602395E RID: 145758 RVA: 0x004E4C61 File Offset: 0x004E2E61
		// (set) Token: 0x0602395F RID: 145759 RVA: 0x004E4C69 File Offset: 0x004E2E69
		public TEntityBatchRefreshUnion EntityBatchRefresh { get; set; }

		// Token: 0x17009FDF RID: 40927
		// (get) Token: 0x06023960 RID: 145760 RVA: 0x004E4C72 File Offset: 0x004E2E72
		// (set) Token: 0x06023961 RID: 145761 RVA: 0x004E4C7A File Offset: 0x004E2E7A
		public byte NullMask { get; set; }

		// Token: 0x06023962 RID: 145762 RVA: 0x004E4C83 File Offset: 0x004E2E83
		public IEntityBatchRefreshComponentT()
		{
			this.Disabled = false;
			this.StartCondition = null;
			this.EndCondition = null;
			this.EntityBatchRefresh = null;
			this.NullMask = 0;
		}
	}
}
