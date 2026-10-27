using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006359 RID: 25433
	public class ICheckClimbT
	{
		// Token: 0x1700BDC1 RID: 48577
		// (get) Token: 0x0602BFF3 RID: 180211 RVA: 0x0060BC4B File Offset: 0x00609E4B
		// (set) Token: 0x0602BFF4 RID: 180212 RVA: 0x0060BC53 File Offset: 0x00609E53
		public IVectorInfoT Direction { get; set; }

		// Token: 0x1700BDC2 RID: 48578
		// (get) Token: 0x0602BFF5 RID: 180213 RVA: 0x0060BC5C File Offset: 0x00609E5C
		// (set) Token: 0x0602BFF6 RID: 180214 RVA: 0x0060BC64 File Offset: 0x00609E64
		public int Distance { get; set; }

		// Token: 0x1700BDC3 RID: 48579
		// (get) Token: 0x0602BFF7 RID: 180215 RVA: 0x0060BC6D File Offset: 0x00609E6D
		// (set) Token: 0x0602BFF8 RID: 180216 RVA: 0x0060BC75 File Offset: 0x00609E75
		public int FallBackClimbPointId { get; set; }

		// Token: 0x1700BDC4 RID: 48580
		// (get) Token: 0x0602BFF9 RID: 180217 RVA: 0x0060BC7E File Offset: 0x00609E7E
		// (set) Token: 0x0602BFFA RID: 180218 RVA: 0x0060BC86 File Offset: 0x00609E86
		public byte NullMask { get; set; }

		// Token: 0x0602BFFB RID: 180219 RVA: 0x0060BC8F File Offset: 0x00609E8F
		public ICheckClimbT()
		{
			this.Direction = null;
			this.Distance = 0;
			this.FallBackClimbPointId = 0;
			this.NullMask = 0;
		}
	}
}
