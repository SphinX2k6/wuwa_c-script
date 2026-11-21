using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007125 RID: 28965
	public class ILiveSendScConfigT
	{
		// Token: 0x1700D41B RID: 54299
		// (get) Token: 0x06032515 RID: 206101 RVA: 0x006CDA0B File Offset: 0x006CBC0B
		// (set) Token: 0x06032516 RID: 206102 RVA: 0x006CDA13 File Offset: 0x006CBC13
		public ELiveScOperationType Type { get; set; }

		// Token: 0x1700D41C RID: 54300
		// (get) Token: 0x06032517 RID: 206103 RVA: 0x006CDA1C File Offset: 0x006CBC1C
		// (set) Token: 0x06032518 RID: 206104 RVA: 0x006CDA24 File Offset: 0x006CBC24
		public List<ILiveScConfigT> ScList { get; set; }

		// Token: 0x06032519 RID: 206105 RVA: 0x006CDA2D File Offset: 0x006CBC2D
		public ILiveSendScConfigT()
		{
			this.Type = ELiveScOperationType.Send;
			this.ScList = null;
		}
	}
}
