using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E6C RID: 24172
	public class IResetEntitiesPosComponentT
	{
		// Token: 0x1700B24D RID: 45645
		// (get) Token: 0x060286EC RID: 165612 RVA: 0x005875EC File Offset: 0x005857EC
		// (set) Token: 0x060286ED RID: 165613 RVA: 0x005875F4 File Offset: 0x005857F4
		public bool Disabled { get; set; }

		// Token: 0x1700B24E RID: 45646
		// (get) Token: 0x060286EE RID: 165614 RVA: 0x005875FD File Offset: 0x005857FD
		// (set) Token: 0x060286EF RID: 165615 RVA: 0x00587605 File Offset: 0x00585805
		public TTriggerShapeUnion Range { get; set; }

		// Token: 0x1700B24F RID: 45647
		// (get) Token: 0x060286F0 RID: 165616 RVA: 0x0058760E File Offset: 0x0058580E
		// (set) Token: 0x060286F1 RID: 165617 RVA: 0x00587616 File Offset: 0x00585816
		public List<int> EntityIds { get; set; }

		// Token: 0x1700B250 RID: 45648
		// (get) Token: 0x060286F2 RID: 165618 RVA: 0x0058761F File Offset: 0x0058581F
		// (set) Token: 0x060286F3 RID: 165619 RVA: 0x00587627 File Offset: 0x00585827
		public byte NullMask { get; set; }

		// Token: 0x060286F4 RID: 165620 RVA: 0x00587630 File Offset: 0x00585830
		public IResetEntitiesPosComponentT()
		{
			this.Disabled = false;
			this.Range = null;
			this.EntityIds = null;
			this.NullMask = 0;
		}
	}
}
