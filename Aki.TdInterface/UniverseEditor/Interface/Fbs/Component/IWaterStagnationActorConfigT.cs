using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B54 RID: 23380
	public class IWaterStagnationActorConfigT
	{
		// Token: 0x1700B095 RID: 45205
		// (get) Token: 0x06027FDB RID: 163803 RVA: 0x0057F9A2 File Offset: 0x0057DBA2
		// (set) Token: 0x06027FDC RID: 163804 RVA: 0x0057F9AA File Offset: 0x0057DBAA
		public int SeqRefEntity { get; set; }

		// Token: 0x06027FDD RID: 163805 RVA: 0x0057F9B3 File Offset: 0x0057DBB3
		public IWaterStagnationActorConfigT()
		{
			this.SeqRefEntity = 0;
		}
	}
}
