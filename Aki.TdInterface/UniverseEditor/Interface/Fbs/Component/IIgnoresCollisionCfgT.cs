using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200596D RID: 22893
	public class IIgnoresCollisionCfgT
	{
		// Token: 0x1700A654 RID: 42580
		// (get) Token: 0x0602551D RID: 152861 RVA: 0x0051F790 File Offset: 0x0051D990
		// (set) Token: 0x0602551E RID: 152862 RVA: 0x0051F798 File Offset: 0x0051D998
		public List<int> IgnoreEntitys { get; set; }

		// Token: 0x1700A655 RID: 42581
		// (get) Token: 0x0602551F RID: 152863 RVA: 0x0051F7A1 File Offset: 0x0051D9A1
		// (set) Token: 0x06025520 RID: 152864 RVA: 0x0051F7A9 File Offset: 0x0051D9A9
		public List<IActorRefT> IgnoreActors { get; set; }

		// Token: 0x06025521 RID: 152865 RVA: 0x0051F7B2 File Offset: 0x0051D9B2
		public IIgnoresCollisionCfgT()
		{
			this.IgnoreEntitys = null;
			this.IgnoreActors = null;
		}
	}
}
