using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A4 RID: 26788
	public class IGroupAiCommunicateAddTagT
	{
		// Token: 0x1700C6E2 RID: 50914
		// (get) Token: 0x0602EBA0 RID: 191392 RVA: 0x0065EB17 File Offset: 0x0065CD17
		// (set) Token: 0x0602EBA1 RID: 191393 RVA: 0x0065EB1F File Offset: 0x0065CD1F
		public EGroupAiCommunicateType Type { get; set; }

		// Token: 0x1700C6E3 RID: 50915
		// (get) Token: 0x0602EBA2 RID: 191394 RVA: 0x0065EB28 File Offset: 0x0065CD28
		// (set) Token: 0x0602EBA3 RID: 191395 RVA: 0x0065EB30 File Offset: 0x0065CD30
		public List<string> Tags { get; set; }

		// Token: 0x0602EBA4 RID: 191396 RVA: 0x0065EB39 File Offset: 0x0065CD39
		public IGroupAiCommunicateAddTagT()
		{
			this.Type = EGroupAiCommunicateType.AddTag;
			this.Tags = null;
		}
	}
}
