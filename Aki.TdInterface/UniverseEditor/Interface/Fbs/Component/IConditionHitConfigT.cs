using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005551 RID: 21841
	public class IConditionHitConfigT
	{
		// Token: 0x17009C25 RID: 39973
		// (get) Token: 0x06022A7D RID: 141949 RVA: 0x004C5F23 File Offset: 0x004C4123
		// (set) Token: 0x06022A7E RID: 141950 RVA: 0x004C5F2B File Offset: 0x004C412B
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x17009C26 RID: 39974
		// (get) Token: 0x06022A7F RID: 141951 RVA: 0x004C5F34 File Offset: 0x004C4134
		// (set) Token: 0x06022A80 RID: 141952 RVA: 0x004C5F3C File Offset: 0x004C413C
		public string State { get; set; }

		// Token: 0x06022A81 RID: 141953 RVA: 0x004C5F45 File Offset: 0x004C4145
		public IConditionHitConfigT()
		{
			this.Conditions = null;
			this.State = null;
		}
	}
}
