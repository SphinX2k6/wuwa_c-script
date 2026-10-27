using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073EC RID: 29676
	public class IToggleAirWallT
	{
		// Token: 0x1700E166 RID: 57702
		// (get) Token: 0x06035E8F RID: 220815 RVA: 0x00756414 File Offset: 0x00754614
		// (set) Token: 0x06035E90 RID: 220816 RVA: 0x0075641C File Offset: 0x0075461C
		public TToggleAirWallUnion Option { get; set; }

		// Token: 0x1700E167 RID: 57703
		// (get) Token: 0x06035E91 RID: 220817 RVA: 0x00756425 File Offset: 0x00754625
		// (set) Token: 0x06035E92 RID: 220818 RVA: 0x0075642D File Offset: 0x0075462D
		public List<IActorRefT> ActorRefs { get; set; }

		// Token: 0x06035E93 RID: 220819 RVA: 0x00756436 File Offset: 0x00754636
		public IToggleAirWallT()
		{
			this.Option = null;
			this.ActorRefs = null;
		}
	}
}
