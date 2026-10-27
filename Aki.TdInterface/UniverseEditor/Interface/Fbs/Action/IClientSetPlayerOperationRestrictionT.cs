using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063E6 RID: 25574
	public class IClientSetPlayerOperationRestrictionT
	{
		// Token: 0x1700BE83 RID: 48771
		// (get) Token: 0x0602C3F1 RID: 181233 RVA: 0x00612CE2 File Offset: 0x00610EE2
		// (set) Token: 0x0602C3F2 RID: 181234 RVA: 0x00612CEA File Offset: 0x00610EEA
		public EPlayerOperationType Type { get; set; }

		// Token: 0x0602C3F3 RID: 181235 RVA: 0x00612CF3 File Offset: 0x00610EF3
		public IClientSetPlayerOperationRestrictionT()
		{
			this.Type = EPlayerOperationType.EnableAll;
		}
	}
}
