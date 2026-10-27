using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F6C RID: 16236
	public class IOutOfRangeTrackTargetT
	{
		// Token: 0x170070EC RID: 28908
		// (get) Token: 0x060171A0 RID: 94624 RVA: 0x003544CC File Offset: 0x003526CC
		// (set) Token: 0x060171A1 RID: 94625 RVA: 0x003544D4 File Offset: 0x003526D4
		public IVectorInfoT TrackPos { get; set; }

		// Token: 0x170070ED RID: 28909
		// (get) Token: 0x060171A2 RID: 94626 RVA: 0x003544DD File Offset: 0x003526DD
		// (set) Token: 0x060171A3 RID: 94627 RVA: 0x003544E5 File Offset: 0x003526E5
		public IVectorInfoT Center { get; set; }

		// Token: 0x170070EE RID: 28910
		// (get) Token: 0x060171A4 RID: 94628 RVA: 0x003544EE File Offset: 0x003526EE
		// (set) Token: 0x060171A5 RID: 94629 RVA: 0x003544F6 File Offset: 0x003526F6
		public int Radius { get; set; }

		// Token: 0x170070EF RID: 28911
		// (get) Token: 0x060171A6 RID: 94630 RVA: 0x003544FF File Offset: 0x003526FF
		// (set) Token: 0x060171A7 RID: 94631 RVA: 0x00354507 File Offset: 0x00352707
		public bool OverrideChildNodeTrackTarget { get; set; }

		// Token: 0x170070F0 RID: 28912
		// (get) Token: 0x060171A8 RID: 94632 RVA: 0x00354510 File Offset: 0x00352710
		// (set) Token: 0x060171A9 RID: 94633 RVA: 0x00354518 File Offset: 0x00352718
		public byte NullMask { get; set; }

		// Token: 0x060171AA RID: 94634 RVA: 0x00354521 File Offset: 0x00352721
		public IOutOfRangeTrackTargetT()
		{
			this.TrackPos = null;
			this.Center = null;
			this.Radius = 0;
			this.OverrideChildNodeTrackTarget = false;
			this.NullMask = 0;
		}
	}
}
