using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E4 RID: 21476
	public class IIgnoreEntityIdsCollisionT
	{
		// Token: 0x17009E16 RID: 40470
		// (get) Token: 0x06023443 RID: 144451 RVA: 0x004E22CD File Offset: 0x004E04CD
		// (set) Token: 0x06023444 RID: 144452 RVA: 0x004E22D5 File Offset: 0x004E04D5
		public List<int> EntityIds { get; set; }

		// Token: 0x06023445 RID: 144453 RVA: 0x004E22DE File Offset: 0x004E04DE
		public IIgnoreEntityIdsCollisionT()
		{
			this.EntityIds = null;
		}
	}
}
