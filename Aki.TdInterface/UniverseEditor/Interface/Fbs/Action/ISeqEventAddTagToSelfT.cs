using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F7C RID: 28540
	public class ISeqEventAddTagToSelfT
	{
		// Token: 0x1700D3FD RID: 54269
		// (get) Token: 0x060326CE RID: 206542 RVA: 0x006CE7C9 File Offset: 0x006CC9C9
		// (set) Token: 0x060326CF RID: 206543 RVA: 0x006CE7D1 File Offset: 0x006CC9D1
		public List<int> Tags { get; set; }

		// Token: 0x060326D0 RID: 206544 RVA: 0x006CE7DA File Offset: 0x006CC9DA
		public ISeqEventAddTagToSelfT()
		{
			this.Tags = null;
		}
	}
}
