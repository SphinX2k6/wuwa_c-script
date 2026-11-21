using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060EF RID: 24815
	public class ITriggerCountConfigT
	{
		// Token: 0x1700B8AC RID: 47276
		// (get) Token: 0x0602A0BE RID: 172222 RVA: 0x005BD574 File Offset: 0x005BB774
		// (set) Token: 0x0602A0BF RID: 172223 RVA: 0x005BD57C File Offset: 0x005BB77C
		public int TriggerCount { get; set; }

		// Token: 0x1700B8AD RID: 47277
		// (get) Token: 0x0602A0C0 RID: 172224 RVA: 0x005BD585 File Offset: 0x005BB785
		// (set) Token: 0x0602A0C1 RID: 172225 RVA: 0x005BD58D File Offset: 0x005BB78D
		public float TriggerInterval { get; set; }

		// Token: 0x0602A0C2 RID: 172226 RVA: 0x005BD596 File Offset: 0x005BB796
		public ITriggerCountConfigT()
		{
			this.TriggerCount = 0;
			this.TriggerInterval = 0f;
		}
	}
}
