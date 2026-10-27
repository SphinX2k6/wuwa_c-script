using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052CB RID: 21195
	public class IFoxJumpPositionOnPathDrivenSpawnedActorT
	{
		// Token: 0x17009B77 RID: 39799
		// (get) Token: 0x06022935 RID: 141621 RVA: 0x004CAFC3 File Offset: 0x004C91C3
		// (set) Token: 0x06022936 RID: 141622 RVA: 0x004CAFCB File Offset: 0x004C91CB
		public EFoxJumpInteractPointRelationType Type { get; set; }

		// Token: 0x17009B78 RID: 39800
		// (get) Token: 0x06022937 RID: 141623 RVA: 0x004CAFD4 File Offset: 0x004C91D4
		// (set) Token: 0x06022938 RID: 141624 RVA: 0x004CAFDC File Offset: 0x004C91DC
		public IVectorInfoT Offset { get; set; }

		// Token: 0x17009B79 RID: 39801
		// (get) Token: 0x06022939 RID: 141625 RVA: 0x004CAFE5 File Offset: 0x004C91E5
		// (set) Token: 0x0602293A RID: 141626 RVA: 0x004CAFED File Offset: 0x004C91ED
		public IVectorInfoT RaycastDestOffset { get; set; }

		// Token: 0x17009B7A RID: 39802
		// (get) Token: 0x0602293B RID: 141627 RVA: 0x004CAFF6 File Offset: 0x004C91F6
		// (set) Token: 0x0602293C RID: 141628 RVA: 0x004CAFFE File Offset: 0x004C91FE
		public IFoxJumpShapeAndPointsParamsT BottomParams { get; set; }

		// Token: 0x17009B7B RID: 39803
		// (get) Token: 0x0602293D RID: 141629 RVA: 0x004CB007 File Offset: 0x004C9207
		// (set) Token: 0x0602293E RID: 141630 RVA: 0x004CB00F File Offset: 0x004C920F
		public int BottomRangeSplineEntityId { get; set; }

		// Token: 0x17009B7C RID: 39804
		// (get) Token: 0x0602293F RID: 141631 RVA: 0x004CB018 File Offset: 0x004C9218
		// (set) Token: 0x06022940 RID: 141632 RVA: 0x004CB020 File Offset: 0x004C9220
		public IFoxJumpShapeAndPointsParamsT TopParams { get; set; }

		// Token: 0x17009B7D RID: 39805
		// (get) Token: 0x06022941 RID: 141633 RVA: 0x004CB029 File Offset: 0x004C9229
		// (set) Token: 0x06022942 RID: 141634 RVA: 0x004CB031 File Offset: 0x004C9231
		public IBoxTriggerShapeT HollowShape { get; set; }

		// Token: 0x17009B7E RID: 39806
		// (get) Token: 0x06022943 RID: 141635 RVA: 0x004CB03A File Offset: 0x004C923A
		// (set) Token: 0x06022944 RID: 141636 RVA: 0x004CB042 File Offset: 0x004C9242
		public byte NullMask { get; set; }

		// Token: 0x06022945 RID: 141637 RVA: 0x004CB04B File Offset: 0x004C924B
		public IFoxJumpPositionOnPathDrivenSpawnedActorT()
		{
			this.Type = EFoxJumpInteractPointRelationType.ThisEntity;
			this.Offset = null;
			this.RaycastDestOffset = null;
			this.BottomParams = null;
			this.BottomRangeSplineEntityId = 0;
			this.TopParams = null;
			this.HollowShape = null;
			this.NullMask = 0;
		}
	}
}
