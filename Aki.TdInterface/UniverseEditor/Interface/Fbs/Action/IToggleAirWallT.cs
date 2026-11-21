using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BD6 RID: 31702
	public class IToggleAirWallT
	{
		// Token: 0x1700ED7B RID: 60795
		// (get) Token: 0x06039242 RID: 234050 RVA: 0x007B8B88 File Offset: 0x007B6D88
		// (set) Token: 0x06039243 RID: 234051 RVA: 0x007B8B90 File Offset: 0x007B6D90
		public TToggleAirWallUnion Option { get; set; }

		// Token: 0x1700ED7C RID: 60796
		// (get) Token: 0x06039244 RID: 234052 RVA: 0x007B8B99 File Offset: 0x007B6D99
		// (set) Token: 0x06039245 RID: 234053 RVA: 0x007B8BA1 File Offset: 0x007B6DA1
		public List<IActorRefT> ActorRefs { get; set; }

		// Token: 0x06039246 RID: 234054 RVA: 0x007B8BAA File Offset: 0x007B6DAA
		public IToggleAirWallT()
		{
			this.Option = null;
			this.ActorRefs = null;
		}
	}
}
