using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02005F01 RID: 24321
	public class IStreamingGroupT
	{
		// Token: 0x1700B5D0 RID: 46544
		// (get) Token: 0x06029C72 RID: 171122 RVA: 0x005BB8B7 File Offset: 0x005B9AB7
		// (set) Token: 0x06029C73 RID: 171123 RVA: 0x005BB8BF File Offset: 0x005B9ABF
		public int EntityId { get; set; }

		// Token: 0x1700B5D1 RID: 46545
		// (get) Token: 0x06029C74 RID: 171124 RVA: 0x005BB8C8 File Offset: 0x005B9AC8
		// (set) Token: 0x06029C75 RID: 171125 RVA: 0x005BB8D0 File Offset: 0x005B9AD0
		public List<IActorRefT> RefData { get; set; }

		// Token: 0x06029C76 RID: 171126 RVA: 0x005BB8D9 File Offset: 0x005B9AD9
		public IStreamingGroupT()
		{
			this.EntityId = 0;
			this.RefData = null;
		}
	}
}
