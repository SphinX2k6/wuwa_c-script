using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005256 RID: 21078
	public class IFinishStateTriggerT
	{
		// Token: 0x17009A64 RID: 39524
		// (get) Token: 0x06022499 RID: 140441 RVA: 0x004C1233 File Offset: 0x004BF433
		// (set) Token: 0x0602249A RID: 140442 RVA: 0x004C123B File Offset: 0x004BF43B
		public bool IsSilenceEntities { get; set; }

		// Token: 0x17009A65 RID: 39525
		// (get) Token: 0x0602249B RID: 140443 RVA: 0x004C1244 File Offset: 0x004BF444
		// (set) Token: 0x0602249C RID: 140444 RVA: 0x004C124C File Offset: 0x004BF44C
		public IEntityGroupConditionT GroupCondition { get; set; }

		// Token: 0x0602249D RID: 140445 RVA: 0x004C1255 File Offset: 0x004BF455
		public IFinishStateTriggerT()
		{
			this.IsSilenceEntities = false;
			this.GroupCondition = null;
		}
	}
}
