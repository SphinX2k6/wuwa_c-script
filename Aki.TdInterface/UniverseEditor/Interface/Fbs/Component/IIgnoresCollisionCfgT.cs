using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E7 RID: 21479
	public class IIgnoresCollisionCfgT
	{
		// Token: 0x17009E1A RID: 40474
		// (get) Token: 0x06023465 RID: 144485 RVA: 0x004E2764 File Offset: 0x004E0964
		// (set) Token: 0x06023466 RID: 144486 RVA: 0x004E276C File Offset: 0x004E096C
		public List<int> IgnoreEntitys { get; set; }

		// Token: 0x17009E1B RID: 40475
		// (get) Token: 0x06023467 RID: 144487 RVA: 0x004E2775 File Offset: 0x004E0975
		// (set) Token: 0x06023468 RID: 144488 RVA: 0x004E277D File Offset: 0x004E097D
		public List<IActorRefT> IgnoreActors { get; set; }

		// Token: 0x06023469 RID: 144489 RVA: 0x004E2786 File Offset: 0x004E0986
		public IIgnoresCollisionCfgT()
		{
			this.IgnoreEntitys = null;
			this.IgnoreActors = null;
		}
	}
}
