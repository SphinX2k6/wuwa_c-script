using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A5 RID: 29093
	public class IMechEscortPointT
	{
		// Token: 0x1700D519 RID: 54553
		// (get) Token: 0x060329AA RID: 207274 RVA: 0x006D69F5 File Offset: 0x006D4BF5
		// (set) Token: 0x060329AB RID: 207275 RVA: 0x006D69FD File Offset: 0x006D4BFD
		public int SplinePointIndex { get; set; }

		// Token: 0x1700D51A RID: 54554
		// (get) Token: 0x060329AC RID: 207276 RVA: 0x006D6A06 File Offset: 0x006D4C06
		// (set) Token: 0x060329AD RID: 207277 RVA: 0x006D6A0E File Offset: 0x006D4C0E
		public float ForwardOffset { get; set; }

		// Token: 0x1700D51B RID: 54555
		// (get) Token: 0x060329AE RID: 207278 RVA: 0x006D6A17 File Offset: 0x006D4C17
		// (set) Token: 0x060329AF RID: 207279 RVA: 0x006D6A1F File Offset: 0x006D4C1F
		public float Radius { get; set; }

		// Token: 0x1700D51C RID: 54556
		// (get) Token: 0x060329B0 RID: 207280 RVA: 0x006D6A28 File Offset: 0x006D4C28
		// (set) Token: 0x060329B1 RID: 207281 RVA: 0x006D6A30 File Offset: 0x006D4C30
		public float Angle { get; set; }

		// Token: 0x1700D51D RID: 54557
		// (get) Token: 0x060329B2 RID: 207282 RVA: 0x006D6A39 File Offset: 0x006D4C39
		// (set) Token: 0x060329B3 RID: 207283 RVA: 0x006D6A41 File Offset: 0x006D4C41
		public TEnterMovieCameraTypeUnion MovieCamera { get; set; }

		// Token: 0x060329B4 RID: 207284 RVA: 0x006D6A4A File Offset: 0x006D4C4A
		public IMechEscortPointT()
		{
			this.SplinePointIndex = 0;
			this.ForwardOffset = 0f;
			this.Radius = 0f;
			this.Angle = 0f;
			this.MovieCamera = null;
		}
	}
}
