using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068AD RID: 26797
	public class IGroupAiCommunicateRemoveTagT
	{
		// Token: 0x1700C6EC RID: 50924
		// (get) Token: 0x0602EBDC RID: 191452 RVA: 0x0065F117 File Offset: 0x0065D317
		// (set) Token: 0x0602EBDD RID: 191453 RVA: 0x0065F11F File Offset: 0x0065D31F
		public EGroupAiCommunicateType Type { get; set; }

		// Token: 0x1700C6ED RID: 50925
		// (get) Token: 0x0602EBDE RID: 191454 RVA: 0x0065F128 File Offset: 0x0065D328
		// (set) Token: 0x0602EBDF RID: 191455 RVA: 0x0065F130 File Offset: 0x0065D330
		public List<string> Tags { get; set; }

		// Token: 0x0602EBE0 RID: 191456 RVA: 0x0065F139 File Offset: 0x0065D339
		public IGroupAiCommunicateRemoveTagT()
		{
			this.Type = EGroupAiCommunicateType.AddTag;
			this.Tags = null;
		}
	}
}
