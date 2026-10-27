using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C62 RID: 19554
	public class IOnlinePlayerConditionTargetHostT
	{
		// Token: 0x17008E0A RID: 36362
		// (get) Token: 0x0601F015 RID: 126997 RVA: 0x00455E4E File Offset: 0x0045404E
		// (set) Token: 0x0601F016 RID: 126998 RVA: 0x00455E56 File Offset: 0x00454056
		public EOnlinePlayerConditionTarget Type { get; set; }

		// Token: 0x0601F017 RID: 126999 RVA: 0x00455E5F File Offset: 0x0045405F
		public IOnlinePlayerConditionTargetHostT()
		{
			this.Type = EOnlinePlayerConditionTarget.Host;
		}
	}
}
