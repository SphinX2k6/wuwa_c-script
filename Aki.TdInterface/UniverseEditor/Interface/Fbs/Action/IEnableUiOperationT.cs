using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200669D RID: 26269
	public class IEnableUiOperationT
	{
		// Token: 0x1700C338 RID: 49976
		// (get) Token: 0x0602DA8D RID: 187021 RVA: 0x0063F982 File Offset: 0x0063DB82
		// (set) Token: 0x0602DA8E RID: 187022 RVA: 0x0063F98A File Offset: 0x0063DB8A
		public EUiOperationType Type { get; set; }

		// Token: 0x0602DA8F RID: 187023 RVA: 0x0063F993 File Offset: 0x0063DB93
		public IEnableUiOperationT()
		{
			this.Type = EUiOperationType.Enable;
		}
	}
}
