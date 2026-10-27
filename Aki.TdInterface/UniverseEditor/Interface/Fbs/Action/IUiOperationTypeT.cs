using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074A6 RID: 29862
	public class IUiOperationTypeT
	{
		// Token: 0x1700E2B5 RID: 58037
		// (get) Token: 0x060364BA RID: 222394 RVA: 0x0076149A File Offset: 0x0075F69A
		// (set) Token: 0x060364BB RID: 222395 RVA: 0x007614A2 File Offset: 0x0075F6A2
		public EUiOperationType Type { get; set; }

		// Token: 0x060364BC RID: 222396 RVA: 0x007614AB File Offset: 0x0075F6AB
		public IUiOperationTypeT()
		{
			this.Type = EUiOperationType.Enable;
		}
	}
}
