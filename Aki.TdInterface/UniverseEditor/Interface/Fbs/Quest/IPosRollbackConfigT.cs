using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043F2 RID: 17394
	public class IPosRollbackConfigT
	{
		// Token: 0x170077DC RID: 30684
		// (get) Token: 0x06018B85 RID: 101253 RVA: 0x003860FC File Offset: 0x003842FC
		// (set) Token: 0x06018B86 RID: 101254 RVA: 0x00386104 File Offset: 0x00384304
		public int RangeEntityId { get; set; }

		// Token: 0x170077DD RID: 30685
		// (get) Token: 0x06018B87 RID: 101255 RVA: 0x0038610D File Offset: 0x0038430D
		// (set) Token: 0x06018B88 RID: 101256 RVA: 0x00386115 File Offset: 0x00384315
		public int PositionEntityId { get; set; }

		// Token: 0x170077DE RID: 30686
		// (get) Token: 0x06018B89 RID: 101257 RVA: 0x0038611E File Offset: 0x0038431E
		// (set) Token: 0x06018B8A RID: 101258 RVA: 0x00386126 File Offset: 0x00384326
		public bool GravityFlip { get; set; }

		// Token: 0x170077DF RID: 30687
		// (get) Token: 0x06018B8B RID: 101259 RVA: 0x0038612F File Offset: 0x0038432F
		// (set) Token: 0x06018B8C RID: 101260 RVA: 0x00386137 File Offset: 0x00384337
		public byte NullMask { get; set; }

		// Token: 0x06018B8D RID: 101261 RVA: 0x00386140 File Offset: 0x00384340
		public IPosRollbackConfigT()
		{
			this.RangeEntityId = 0;
			this.PositionEntityId = 0;
			this.GravityFlip = false;
			this.NullMask = 0;
		}
	}
}
