using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E1C RID: 24092
	public class IRefactorActorRef2EntitiesT
	{
		// Token: 0x1700B194 RID: 45460
		// (get) Token: 0x060283C1 RID: 164801 RVA: 0x00580852 File Offset: 0x0057EA52
		// (set) Token: 0x060283C2 RID: 164802 RVA: 0x0058085A File Offset: 0x0057EA5A
		public List<IActorRefT> Actors { get; set; }

		// Token: 0x1700B195 RID: 45461
		// (get) Token: 0x060283C3 RID: 164803 RVA: 0x00580863 File Offset: 0x0057EA63
		// (set) Token: 0x060283C4 RID: 164804 RVA: 0x0058086B File Offset: 0x0057EA6B
		public List<int> EntityIds { get; set; }

		// Token: 0x060283C5 RID: 164805 RVA: 0x00580874 File Offset: 0x0057EA74
		public IRefactorActorRef2EntitiesT()
		{
			this.Actors = null;
			this.EntityIds = null;
		}
	}
}
