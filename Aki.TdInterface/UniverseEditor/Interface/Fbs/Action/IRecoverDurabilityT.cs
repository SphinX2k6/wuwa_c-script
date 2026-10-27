using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E17 RID: 28183
	public class IRecoverDurabilityT
	{
		// Token: 0x1700D211 RID: 53777
		// (get) Token: 0x06031CBC RID: 203964 RVA: 0x006BDD3E File Offset: 0x006BBF3E
		// (set) Token: 0x06031CBD RID: 203965 RVA: 0x006BDD46 File Offset: 0x006BBF46
		public int EntityId { get; set; }

		// Token: 0x06031CBE RID: 203966 RVA: 0x006BDD4F File Offset: 0x006BBF4F
		public IRecoverDurabilityT()
		{
			this.EntityId = 0;
		}
	}
}
