using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007879 RID: 30841
	public class ISetWayOccupancyStateT
	{
		// Token: 0x1700E229 RID: 57897
		// (get) Token: 0x060363E9 RID: 222185 RVA: 0x007440EB File Offset: 0x007422EB
		// (set) Token: 0x060363EA RID: 222186 RVA: 0x007440F3 File Offset: 0x007422F3
		public bool Occupy { get; set; }

		// Token: 0x1700E22A RID: 57898
		// (get) Token: 0x060363EB RID: 222187 RVA: 0x007440FC File Offset: 0x007422FC
		// (set) Token: 0x060363EC RID: 222188 RVA: 0x00744104 File Offset: 0x00742304
		public List<int> TargetWay { get; set; }

		// Token: 0x060363ED RID: 222189 RVA: 0x0074410D File Offset: 0x0074230D
		public ISetWayOccupancyStateT()
		{
			this.Occupy = false;
			this.TargetWay = null;
		}
	}
}
