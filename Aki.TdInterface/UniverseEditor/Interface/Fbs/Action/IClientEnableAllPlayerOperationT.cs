using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006395 RID: 25493
	public class IClientEnableAllPlayerOperationT
	{
		// Token: 0x1700BE18 RID: 48664
		// (get) Token: 0x0602C1BB RID: 180667 RVA: 0x0060F09E File Offset: 0x0060D29E
		// (set) Token: 0x0602C1BC RID: 180668 RVA: 0x0060F0A6 File Offset: 0x0060D2A6
		public EPlayerOperationType Type { get; set; }

		// Token: 0x0602C1BD RID: 180669 RVA: 0x0060F0AF File Offset: 0x0060D2AF
		public IClientEnableAllPlayerOperationT()
		{
			this.Type = EPlayerOperationType.EnableAll;
		}
	}
}
