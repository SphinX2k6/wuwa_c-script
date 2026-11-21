using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072DE RID: 29406
	public class INewMoveWithSplineT
	{
		// Token: 0x1700D7A4 RID: 55204
		// (get) Token: 0x06033469 RID: 210025 RVA: 0x006EAD43 File Offset: 0x006E8F43
		// (set) Token: 0x0603346A RID: 210026 RVA: 0x006EAD4B File Offset: 0x006E8F4B
		public TNewSplineMoveTargetUnion MoveTarget { get; set; }

		// Token: 0x1700D7A5 RID: 55205
		// (get) Token: 0x0603346B RID: 210027 RVA: 0x006EAD54 File Offset: 0x006E8F54
		// (set) Token: 0x0603346C RID: 210028 RVA: 0x006EAD5C File Offset: 0x006E8F5C
		public IFrontAxleTrackingSplineMoveT Move { get; set; }

		// Token: 0x1700D7A6 RID: 55206
		// (get) Token: 0x0603346D RID: 210029 RVA: 0x006EAD65 File Offset: 0x006E8F65
		// (set) Token: 0x0603346E RID: 210030 RVA: 0x006EAD6D File Offset: 0x006E8F6D
		public int SplineEntityId { get; set; }

		// Token: 0x1700D7A7 RID: 55207
		// (get) Token: 0x0603346F RID: 210031 RVA: 0x006EAD76 File Offset: 0x006E8F76
		// (set) Token: 0x06033470 RID: 210032 RVA: 0x006EAD7E File Offset: 0x006E8F7E
		public int StartPointIndex { get; set; }

		// Token: 0x1700D7A8 RID: 55208
		// (get) Token: 0x06033471 RID: 210033 RVA: 0x006EAD87 File Offset: 0x006E8F87
		// (set) Token: 0x06033472 RID: 210034 RVA: 0x006EAD8F File Offset: 0x006E8F8F
		public int EndPointIndex { get; set; }

		// Token: 0x1700D7A9 RID: 55209
		// (get) Token: 0x06033473 RID: 210035 RVA: 0x006EAD98 File Offset: 0x006E8F98
		// (set) Token: 0x06033474 RID: 210036 RVA: 0x006EADA0 File Offset: 0x006E8FA0
		public bool IsStartFromCurrentPos { get; set; }

		// Token: 0x1700D7AA RID: 55210
		// (get) Token: 0x06033475 RID: 210037 RVA: 0x006EADA9 File Offset: 0x006E8FA9
		// (set) Token: 0x06033476 RID: 210038 RVA: 0x006EADB1 File Offset: 0x006E8FB1
		public bool IsFollowStrictly { get; set; }

		// Token: 0x1700D7AB RID: 55211
		// (get) Token: 0x06033477 RID: 210039 RVA: 0x006EADBA File Offset: 0x006E8FBA
		// (set) Token: 0x06033478 RID: 210040 RVA: 0x006EADC2 File Offset: 0x006E8FC2
		public byte NullMask { get; set; }

		// Token: 0x06033479 RID: 210041 RVA: 0x006EADCB File Offset: 0x006E8FCB
		public INewMoveWithSplineT()
		{
			this.MoveTarget = null;
			this.Move = null;
			this.SplineEntityId = 0;
			this.StartPointIndex = 0;
			this.EndPointIndex = 0;
			this.IsStartFromCurrentPos = false;
			this.IsFollowStrictly = false;
			this.NullMask = 0;
		}
	}
}
