using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006676 RID: 26230
	public class IEnableMoveOperationT
	{
		// Token: 0x1700C2DA RID: 49882
		// (get) Token: 0x0602D923 RID: 186659 RVA: 0x0063D1EA File Offset: 0x0063B3EA
		// (set) Token: 0x0602D924 RID: 186660 RVA: 0x0063D1F2 File Offset: 0x0063B3F2
		public EMoveOperationType Type { get; set; }

		// Token: 0x0602D925 RID: 186661 RVA: 0x0063D1FB File Offset: 0x0063B3FB
		public IEnableMoveOperationT()
		{
			this.Type = EMoveOperationType.Enable;
		}
	}
}
