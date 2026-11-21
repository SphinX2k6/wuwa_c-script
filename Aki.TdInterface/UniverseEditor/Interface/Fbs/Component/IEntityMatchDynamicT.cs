using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005701 RID: 22273
	public class IEntityMatchDynamicT
	{
		// Token: 0x1700A090 RID: 41104
		// (get) Token: 0x06023C21 RID: 146465 RVA: 0x004EA573 File Offset: 0x004E8773
		// (set) Token: 0x06023C22 RID: 146466 RVA: 0x004EA57B File Offset: 0x004E877B
		public EEntityMatchType Type { get; set; }

		// Token: 0x1700A091 RID: 41105
		// (get) Token: 0x06023C23 RID: 146467 RVA: 0x004EA584 File Offset: 0x004E8784
		// (set) Token: 0x06023C24 RID: 146468 RVA: 0x004EA58C File Offset: 0x004E878C
		public List<IDynamicEntityMatchT> MatchEntity { get; set; }

		// Token: 0x06023C25 RID: 146469 RVA: 0x004EA595 File Offset: 0x004E8795
		public IEntityMatchDynamicT()
		{
			this.Type = EEntityMatchType.Player;
			this.MatchEntity = null;
		}
	}
}
