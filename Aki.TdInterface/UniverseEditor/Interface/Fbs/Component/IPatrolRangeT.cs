using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200570E RID: 22286
	public class IPatrolRangeT
	{
		// Token: 0x1700A5EC RID: 42476
		// (get) Token: 0x06025433 RID: 152627 RVA: 0x0052436F File Offset: 0x0052256F
		// (set) Token: 0x06025434 RID: 152628 RVA: 0x00524377 File Offset: 0x00522577
		public IVectorInfoT Center { get; set; }

		// Token: 0x1700A5ED RID: 42477
		// (get) Token: 0x06025435 RID: 152629 RVA: 0x00524380 File Offset: 0x00522580
		// (set) Token: 0x06025436 RID: 152630 RVA: 0x00524388 File Offset: 0x00522588
		public int Radius { get; set; }

		// Token: 0x06025437 RID: 152631 RVA: 0x00524391 File Offset: 0x00522591
		public IPatrolRangeT()
		{
			this.Center = null;
			this.Radius = 0;
		}
	}
}
