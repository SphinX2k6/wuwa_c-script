using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004965 RID: 18789
	public class IAccessQuestConditionT
	{
		// Token: 0x170087C0 RID: 34752
		// (get) Token: 0x0601D488 RID: 119944 RVA: 0x00421AA9 File Offset: 0x0041FCA9
		// (set) Token: 0x0601D489 RID: 119945 RVA: 0x00421AB1 File Offset: 0x0041FCB1
		public EConditionCount Type { get; set; }

		// Token: 0x170087C1 RID: 34753
		// (get) Token: 0x0601D48A RID: 119946 RVA: 0x00421ABA File Offset: 0x0041FCBA
		// (set) Token: 0x0601D48B RID: 119947 RVA: 0x00421AC2 File Offset: 0x0041FCC2
		public List<TAccessQuestConditionUnion> Conditions { get; set; }

		// Token: 0x170087C2 RID: 34754
		// (get) Token: 0x0601D48C RID: 119948 RVA: 0x00421ACB File Offset: 0x0041FCCB
		// (set) Token: 0x0601D48D RID: 119949 RVA: 0x00421AD3 File Offset: 0x0041FCD3
		public byte NullMask { get; set; }

		// Token: 0x0601D48E RID: 119950 RVA: 0x00421ADC File Offset: 0x0041FCDC
		public IAccessQuestConditionT()
		{
			this.Type = EConditionCount.All;
			this.Conditions = null;
			this.NullMask = 0;
		}
	}
}
