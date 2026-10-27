using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052CE RID: 21198
	public class IFoxJumpPositionOnThisEntityT
	{
		// Token: 0x17009B85 RID: 39813
		// (get) Token: 0x0602295D RID: 141661 RVA: 0x004CB538 File Offset: 0x004C9738
		// (set) Token: 0x0602295E RID: 141662 RVA: 0x004CB540 File Offset: 0x004C9740
		public EFoxJumpInteractPointRelationType Type { get; set; }

		// Token: 0x17009B86 RID: 39814
		// (get) Token: 0x0602295F RID: 141663 RVA: 0x004CB549 File Offset: 0x004C9749
		// (set) Token: 0x06022960 RID: 141664 RVA: 0x004CB551 File Offset: 0x004C9751
		public IVectorInfoT Offset { get; set; }

		// Token: 0x17009B87 RID: 39815
		// (get) Token: 0x06022961 RID: 141665 RVA: 0x004CB55A File Offset: 0x004C975A
		// (set) Token: 0x06022962 RID: 141666 RVA: 0x004CB562 File Offset: 0x004C9762
		public IVectorInfoT RaycastDestOffset { get; set; }

		// Token: 0x17009B88 RID: 39816
		// (get) Token: 0x06022963 RID: 141667 RVA: 0x004CB56B File Offset: 0x004C976B
		// (set) Token: 0x06022964 RID: 141668 RVA: 0x004CB573 File Offset: 0x004C9773
		public int SplineEntityId { get; set; }

		// Token: 0x17009B89 RID: 39817
		// (get) Token: 0x06022965 RID: 141669 RVA: 0x004CB57C File Offset: 0x004C977C
		// (set) Token: 0x06022966 RID: 141670 RVA: 0x004CB584 File Offset: 0x004C9784
		public byte NullMask { get; set; }

		// Token: 0x06022967 RID: 141671 RVA: 0x004CB58D File Offset: 0x004C978D
		public IFoxJumpPositionOnThisEntityT()
		{
			this.Type = EFoxJumpInteractPointRelationType.ThisEntity;
			this.Offset = null;
			this.RaycastDestOffset = null;
			this.SplineEntityId = 0;
			this.NullMask = 0;
		}
	}
}
