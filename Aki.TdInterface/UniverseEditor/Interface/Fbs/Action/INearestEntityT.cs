using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B95 RID: 27541
	public class INearestEntityT
	{
		// Token: 0x1700CCB4 RID: 52404
		// (get) Token: 0x060305E9 RID: 198121 RVA: 0x00692043 File Offset: 0x00690243
		// (set) Token: 0x060305EA RID: 198122 RVA: 0x0069204B File Offset: 0x0069024B
		public ETeleportType Type { get; set; }

		// Token: 0x1700CCB5 RID: 52405
		// (get) Token: 0x060305EB RID: 198123 RVA: 0x00692054 File Offset: 0x00690254
		// (set) Token: 0x060305EC RID: 198124 RVA: 0x0069205C File Offset: 0x0069025C
		public List<int> EntityIds { get; set; }

		// Token: 0x060305ED RID: 198125 RVA: 0x00692065 File Offset: 0x00690265
		public INearestEntityT()
		{
			this.Type = ETeleportType.FixedPos;
			this.EntityIds = null;
		}
	}
}
