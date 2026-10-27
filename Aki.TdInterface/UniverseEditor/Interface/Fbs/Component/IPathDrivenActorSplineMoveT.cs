using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056FF RID: 22271
	public class IPathDrivenActorSplineMoveT
	{
		// Token: 0x1700A5C8 RID: 42440
		// (get) Token: 0x0602539B RID: 152475 RVA: 0x005231FD File Offset: 0x005213FD
		// (set) Token: 0x0602539C RID: 152476 RVA: 0x00523205 File Offset: 0x00521405
		public EPathDrivenActorMoveType Type { get; set; }

		// Token: 0x1700A5C9 RID: 42441
		// (get) Token: 0x0602539D RID: 152477 RVA: 0x0052320E File Offset: 0x0052140E
		// (set) Token: 0x0602539E RID: 152478 RVA: 0x00523216 File Offset: 0x00521416
		public List<int> SplineEntityIds { get; set; }

		// Token: 0x1700A5CA RID: 42442
		// (get) Token: 0x0602539F RID: 152479 RVA: 0x0052321F File Offset: 0x0052141F
		// (set) Token: 0x060253A0 RID: 152480 RVA: 0x00523227 File Offset: 0x00521427
		public bool IsRandomSpline { get; set; }

		// Token: 0x1700A5CB RID: 42443
		// (get) Token: 0x060253A1 RID: 152481 RVA: 0x00523230 File Offset: 0x00521430
		// (set) Token: 0x060253A2 RID: 152482 RVA: 0x00523238 File Offset: 0x00521438
		public bool IsChainedSpline { get; set; }

		// Token: 0x1700A5CC RID: 42444
		// (get) Token: 0x060253A3 RID: 152483 RVA: 0x00523241 File Offset: 0x00521441
		// (set) Token: 0x060253A4 RID: 152484 RVA: 0x00523249 File Offset: 0x00521449
		public bool IsLoop { get; set; }

		// Token: 0x1700A5CD RID: 42445
		// (get) Token: 0x060253A5 RID: 152485 RVA: 0x00523252 File Offset: 0x00521452
		// (set) Token: 0x060253A6 RID: 152486 RVA: 0x0052325A File Offset: 0x0052145A
		public bool IsFollowSplineDir { get; set; }

		// Token: 0x1700A5CE RID: 42446
		// (get) Token: 0x060253A7 RID: 152487 RVA: 0x00523263 File Offset: 0x00521463
		// (set) Token: 0x060253A8 RID: 152488 RVA: 0x0052326B File Offset: 0x0052146B
		public byte NullMask { get; set; }

		// Token: 0x060253A9 RID: 152489 RVA: 0x00523274 File Offset: 0x00521474
		public IPathDrivenActorSplineMoveT()
		{
			this.Type = EPathDrivenActorMoveType.Spline;
			this.SplineEntityIds = null;
			this.IsRandomSpline = false;
			this.IsChainedSpline = false;
			this.IsLoop = false;
			this.IsFollowSplineDir = false;
			this.NullMask = 0;
		}
	}
}
