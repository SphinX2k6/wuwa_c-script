using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A17 RID: 23063
	public class ISwordRiderRailSplinePointT
	{
		// Token: 0x1700AD5C RID: 44380
		// (get) Token: 0x060272AF RID: 160431 RVA: 0x00563699 File Offset: 0x00561899
		// (set) Token: 0x060272B0 RID: 160432 RVA: 0x005636A1 File Offset: 0x005618A1
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700AD5D RID: 44381
		// (get) Token: 0x060272B1 RID: 160433 RVA: 0x005636AA File Offset: 0x005618AA
		// (set) Token: 0x060272B2 RID: 160434 RVA: 0x005636B2 File Offset: 0x005618B2
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700AD5E RID: 44382
		// (get) Token: 0x060272B3 RID: 160435 RVA: 0x005636BB File Offset: 0x005618BB
		// (set) Token: 0x060272B4 RID: 160436 RVA: 0x005636C3 File Offset: 0x005618C3
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700AD5F RID: 44383
		// (get) Token: 0x060272B5 RID: 160437 RVA: 0x005636CC File Offset: 0x005618CC
		// (set) Token: 0x060272B6 RID: 160438 RVA: 0x005636D4 File Offset: 0x005618D4
		public ESplineLine LineType { get; set; }

		// Token: 0x1700AD60 RID: 44384
		// (get) Token: 0x060272B7 RID: 160439 RVA: 0x005636DD File Offset: 0x005618DD
		// (set) Token: 0x060272B8 RID: 160440 RVA: 0x005636E5 File Offset: 0x005618E5
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700AD61 RID: 44385
		// (get) Token: 0x060272B9 RID: 160441 RVA: 0x005636EE File Offset: 0x005618EE
		// (set) Token: 0x060272BA RID: 160442 RVA: 0x005636F6 File Offset: 0x005618F6
		public float Radius { get; set; }

		// Token: 0x1700AD62 RID: 44386
		// (get) Token: 0x060272BB RID: 160443 RVA: 0x005636FF File Offset: 0x005618FF
		// (set) Token: 0x060272BC RID: 160444 RVA: 0x00563707 File Offset: 0x00561907
		public int HalfAvailableAngle { get; set; }

		// Token: 0x1700AD63 RID: 44387
		// (get) Token: 0x060272BD RID: 160445 RVA: 0x00563710 File Offset: 0x00561910
		// (set) Token: 0x060272BE RID: 160446 RVA: 0x00563718 File Offset: 0x00561918
		public byte NullMask { get; set; }

		// Token: 0x060272BF RID: 160447 RVA: 0x00563724 File Offset: 0x00561924
		public ISwordRiderRailSplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
			this.Radius = 0f;
			this.HalfAvailableAngle = 0;
			this.NullMask = 0;
		}
	}
}
