using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EA3 RID: 20131
	public class ICheckElementalEffectActiveT
	{
		// Token: 0x17008F9C RID: 36764
		// (get) Token: 0x0601F33D RID: 127805 RVA: 0x00459BC4 File Offset: 0x00457DC4
		// (set) Token: 0x0601F33E RID: 127806 RVA: 0x00459BCC File Offset: 0x00457DCC
		public ECondition Type { get; set; }

		// Token: 0x17008F9D RID: 36765
		// (get) Token: 0x0601F33F RID: 127807 RVA: 0x00459BD5 File Offset: 0x00457DD5
		// (set) Token: 0x0601F340 RID: 127808 RVA: 0x00459BDD File Offset: 0x00457DDD
		public bool IsActive { get; set; }

		// Token: 0x0601F341 RID: 127809 RVA: 0x00459BE6 File Offset: 0x00457DE6
		public ICheckElementalEffectActiveT()
		{
			this.Type = ECondition.CompareVar;
			this.IsActive = false;
		}
	}
}
