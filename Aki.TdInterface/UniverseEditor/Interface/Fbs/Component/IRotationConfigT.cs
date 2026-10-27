using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200588C RID: 22668
	public class IRotationConfigT
	{
		// Token: 0x1700A989 RID: 43401
		// (get) Token: 0x0602632E RID: 156462 RVA: 0x00543F99 File Offset: 0x00542199
		// (set) Token: 0x0602632F RID: 156463 RVA: 0x00543FA1 File Offset: 0x005421A1
		public ERotationType Type { get; set; }

		// Token: 0x1700A98A RID: 43402
		// (get) Token: 0x06026330 RID: 156464 RVA: 0x00543FAA File Offset: 0x005421AA
		// (set) Token: 0x06026331 RID: 156465 RVA: 0x00543FB2 File Offset: 0x005421B2
		public float Time { get; set; }

		// Token: 0x1700A98B RID: 43403
		// (get) Token: 0x06026332 RID: 156466 RVA: 0x00543FBB File Offset: 0x005421BB
		// (set) Token: 0x06026333 RID: 156467 RVA: 0x00543FC3 File Offset: 0x005421C3
		public float Cd { get; set; }

		// Token: 0x1700A98C RID: 43404
		// (get) Token: 0x06026334 RID: 156468 RVA: 0x00543FCC File Offset: 0x005421CC
		// (set) Token: 0x06026335 RID: 156469 RVA: 0x00543FD4 File Offset: 0x005421D4
		public string Curve { get; set; }

		// Token: 0x1700A98D RID: 43405
		// (get) Token: 0x06026336 RID: 156470 RVA: 0x00543FDD File Offset: 0x005421DD
		// (set) Token: 0x06026337 RID: 156471 RVA: 0x00543FE5 File Offset: 0x005421E5
		public IVectorInfoT Axis { get; set; }

		// Token: 0x1700A98E RID: 43406
		// (get) Token: 0x06026338 RID: 156472 RVA: 0x00543FEE File Offset: 0x005421EE
		// (set) Token: 0x06026339 RID: 156473 RVA: 0x00543FF6 File Offset: 0x005421F6
		public float Angle { get; set; }

		// Token: 0x1700A98F RID: 43407
		// (get) Token: 0x0602633A RID: 156474 RVA: 0x00543FFF File Offset: 0x005421FF
		// (set) Token: 0x0602633B RID: 156475 RVA: 0x00544007 File Offset: 0x00542207
		public byte NullMask { get; set; }

		// Token: 0x0602633C RID: 156476 RVA: 0x00544010 File Offset: 0x00542210
		public IRotationConfigT()
		{
			this.Type = ERotationType.Relative;
			this.Time = 0f;
			this.Cd = 0f;
			this.Curve = null;
			this.Axis = null;
			this.Angle = 0f;
			this.NullMask = 0;
		}
	}
}
