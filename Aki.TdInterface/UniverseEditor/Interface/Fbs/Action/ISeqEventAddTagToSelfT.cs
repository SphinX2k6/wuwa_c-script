using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007742 RID: 30530
	public class ISeqEventAddTagToSelfT
	{
		// Token: 0x1700DFCC RID: 57292
		// (get) Token: 0x0603591E RID: 219422 RVA: 0x0072E181 File Offset: 0x0072C381
		// (set) Token: 0x0603591F RID: 219423 RVA: 0x0072E189 File Offset: 0x0072C389
		public List<int> Tags { get; set; }

		// Token: 0x06035920 RID: 219424 RVA: 0x0072E192 File Offset: 0x0072C392
		public ISeqEventAddTagToSelfT()
		{
			this.Tags = null;
		}
	}
}
