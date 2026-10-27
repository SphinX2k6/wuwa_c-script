using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B98 RID: 27544
	public class INewMoveWithSplineT
	{
		// Token: 0x1700CCBE RID: 52414
		// (get) Token: 0x0603060F RID: 198159 RVA: 0x00692655 File Offset: 0x00690855
		// (set) Token: 0x06030610 RID: 198160 RVA: 0x0069265D File Offset: 0x0069085D
		public TNewSplineMoveTargetUnion MoveTarget { get; set; }

		// Token: 0x1700CCBF RID: 52415
		// (get) Token: 0x06030611 RID: 198161 RVA: 0x00692666 File Offset: 0x00690866
		// (set) Token: 0x06030612 RID: 198162 RVA: 0x0069266E File Offset: 0x0069086E
		public int SplineEntityId { get; set; }

		// Token: 0x1700CCC0 RID: 52416
		// (get) Token: 0x06030613 RID: 198163 RVA: 0x00692677 File Offset: 0x00690877
		// (set) Token: 0x06030614 RID: 198164 RVA: 0x0069267F File Offset: 0x0069087F
		public int StartPointIndex { get; set; }

		// Token: 0x1700CCC1 RID: 52417
		// (get) Token: 0x06030615 RID: 198165 RVA: 0x00692688 File Offset: 0x00690888
		// (set) Token: 0x06030616 RID: 198166 RVA: 0x00692690 File Offset: 0x00690890
		public int EndPointIndex { get; set; }

		// Token: 0x1700CCC2 RID: 52418
		// (get) Token: 0x06030617 RID: 198167 RVA: 0x00692699 File Offset: 0x00690899
		// (set) Token: 0x06030618 RID: 198168 RVA: 0x006926A1 File Offset: 0x006908A1
		public bool IsStartFromCurrentPos { get; set; }

		// Token: 0x1700CCC3 RID: 52419
		// (get) Token: 0x06030619 RID: 198169 RVA: 0x006926AA File Offset: 0x006908AA
		// (set) Token: 0x0603061A RID: 198170 RVA: 0x006926B2 File Offset: 0x006908B2
		public bool IsFollowStrictly { get; set; }

		// Token: 0x1700CCC4 RID: 52420
		// (get) Token: 0x0603061B RID: 198171 RVA: 0x006926BB File Offset: 0x006908BB
		// (set) Token: 0x0603061C RID: 198172 RVA: 0x006926C3 File Offset: 0x006908C3
		public byte NullMask { get; set; }

		// Token: 0x0603061D RID: 198173 RVA: 0x006926CC File Offset: 0x006908CC
		public INewMoveWithSplineT()
		{
			this.MoveTarget = null;
			this.SplineEntityId = 0;
			this.StartPointIndex = 0;
			this.EndPointIndex = 0;
			this.IsStartFromCurrentPos = false;
			this.IsFollowStrictly = false;
			this.NullMask = 0;
		}
	}
}
