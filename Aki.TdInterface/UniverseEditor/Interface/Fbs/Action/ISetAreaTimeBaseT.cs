using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007769 RID: 30569
	public class ISetAreaTimeBaseT
	{
		// Token: 0x1700E00F RID: 57359
		// (get) Token: 0x06035A77 RID: 219767 RVA: 0x00730BFE File Offset: 0x0072EDFE
		// (set) Token: 0x06035A78 RID: 219768 RVA: 0x00730C06 File Offset: 0x0072EE06
		public ESetAreaTime Type { get; set; }

		// Token: 0x06035A79 RID: 219769 RVA: 0x00730C0F File Offset: 0x0072EE0F
		public ISetAreaTimeBaseT()
		{
			this.Type = ESetAreaTime.Lock;
		}
	}
}
