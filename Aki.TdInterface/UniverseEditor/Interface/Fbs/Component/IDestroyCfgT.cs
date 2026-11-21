using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E7 RID: 21991
	public class IDestroyCfgT
	{
		// Token: 0x17009D78 RID: 40312
		// (get) Token: 0x0602301D RID: 143389 RVA: 0x004D1345 File Offset: 0x004CF545
		// (set) Token: 0x0602301E RID: 143390 RVA: 0x004D134D File Offset: 0x004CF54D
		public List<TTeleControlDestroyConditionUnion> Conditions { get; set; }

		// Token: 0x17009D79 RID: 40313
		// (get) Token: 0x0602301F RID: 143391 RVA: 0x004D1356 File Offset: 0x004CF556
		// (set) Token: 0x06023020 RID: 143392 RVA: 0x004D135E File Offset: 0x004CF55E
		public bool StopPhysicAfterDestroyed { get; set; }

		// Token: 0x17009D7A RID: 40314
		// (get) Token: 0x06023021 RID: 143393 RVA: 0x004D1367 File Offset: 0x004CF567
		// (set) Token: 0x06023022 RID: 143394 RVA: 0x004D136F File Offset: 0x004CF56F
		public byte NullMask { get; set; }

		// Token: 0x06023023 RID: 143395 RVA: 0x004D1378 File Offset: 0x004CF578
		public IDestroyCfgT()
		{
			this.Conditions = null;
			this.StopPhysicAfterDestroyed = false;
			this.NullMask = 0;
		}
	}
}
