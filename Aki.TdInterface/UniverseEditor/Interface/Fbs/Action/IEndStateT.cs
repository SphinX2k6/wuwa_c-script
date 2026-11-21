using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D20 RID: 27936
	public class IEndStateT
	{
		// Token: 0x1700CCF3 RID: 52467
		// (get) Token: 0x060302EC RID: 197356 RVA: 0x0068D263 File Offset: 0x0068B463
		// (set) Token: 0x060302ED RID: 197357 RVA: 0x0068D26B File Offset: 0x0068B46B
		public List<int> StayFlowMontageActors { get; set; }

		// Token: 0x1700CCF4 RID: 52468
		// (get) Token: 0x060302EE RID: 197358 RVA: 0x0068D274 File Offset: 0x0068B474
		// (set) Token: 0x060302EF RID: 197359 RVA: 0x0068D27C File Offset: 0x0068B47C
		public byte NullMask { get; set; }

		// Token: 0x060302F0 RID: 197360 RVA: 0x0068D285 File Offset: 0x0068B485
		public IEndStateT()
		{
			this.StayFlowMontageActors = null;
			this.NullMask = 0;
		}
	}
}
