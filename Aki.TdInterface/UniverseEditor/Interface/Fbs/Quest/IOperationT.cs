using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043A1 RID: 17313
	public class IOperationT
	{
		// Token: 0x170076C9 RID: 30409
		// (get) Token: 0x060187B8 RID: 100280 RVA: 0x0037CFF2 File Offset: 0x0037B1F2
		// (set) Token: 0x060187B9 RID: 100281 RVA: 0x0037CFFA File Offset: 0x0037B1FA
		public EOperation Type { get; set; }

		// Token: 0x060187BA RID: 100282 RVA: 0x0037D003 File Offset: 0x0037B203
		public IOperationT()
		{
			this.Type = EOperation.DisableHLOD;
		}
	}
}
