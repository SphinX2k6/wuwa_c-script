using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F63 RID: 16227
	public class IOperationT
	{
		// Token: 0x170070D8 RID: 28888
		// (get) Token: 0x06017156 RID: 94550 RVA: 0x00353B7E File Offset: 0x00351D7E
		// (set) Token: 0x06017157 RID: 94551 RVA: 0x00353B86 File Offset: 0x00351D86
		public EOperation Type { get; set; }

		// Token: 0x06017158 RID: 94552 RVA: 0x00353B8F File Offset: 0x00351D8F
		public IOperationT()
		{
			this.Type = EOperation.DisableHLOD;
		}
	}
}
