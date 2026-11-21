using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CEA RID: 27882
	public class IEnableMoveOperationT
	{
		// Token: 0x1700CC7D RID: 52349
		// (get) Token: 0x0603010C RID: 196876 RVA: 0x00689F86 File Offset: 0x00688186
		// (set) Token: 0x0603010D RID: 196877 RVA: 0x00689F8E File Offset: 0x0068818E
		public EMoveOperationType Type { get; set; }

		// Token: 0x0603010E RID: 196878 RVA: 0x00689F97 File Offset: 0x00688197
		public IEnableMoveOperationT()
		{
			this.Type = EMoveOperationType.Enable;
		}
	}
}
