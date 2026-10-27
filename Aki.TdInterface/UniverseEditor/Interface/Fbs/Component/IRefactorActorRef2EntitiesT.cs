using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005815 RID: 22549
	public class IRefactorActorRef2EntitiesT
	{
		// Token: 0x1700A870 RID: 43120
		// (get) Token: 0x06025EA1 RID: 155297 RVA: 0x0053A6C6 File Offset: 0x005388C6
		// (set) Token: 0x06025EA2 RID: 155298 RVA: 0x0053A6CE File Offset: 0x005388CE
		public List<IActorRefT> Actors { get; set; }

		// Token: 0x1700A871 RID: 43121
		// (get) Token: 0x06025EA3 RID: 155299 RVA: 0x0053A6D7 File Offset: 0x005388D7
		// (set) Token: 0x06025EA4 RID: 155300 RVA: 0x0053A6DF File Offset: 0x005388DF
		public List<int> EntityIds { get; set; }

		// Token: 0x06025EA5 RID: 155301 RVA: 0x0053A6E8 File Offset: 0x005388E8
		public IRefactorActorRef2EntitiesT()
		{
			this.Actors = null;
			this.EntityIds = null;
		}
	}
}
