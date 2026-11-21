using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D6B RID: 28011
	public class IEntitySplineMoveTargetT
	{
		// Token: 0x1700CD81 RID: 52609
		// (get) Token: 0x06030546 RID: 197958 RVA: 0x006914F5 File Offset: 0x0068F6F5
		// (set) Token: 0x06030547 RID: 197959 RVA: 0x006914FD File Offset: 0x0068F6FD
		public ESplineMoveTargetType Type { get; set; }

		// Token: 0x1700CD82 RID: 52610
		// (get) Token: 0x06030548 RID: 197960 RVA: 0x00691506 File Offset: 0x0068F706
		// (set) Token: 0x06030549 RID: 197961 RVA: 0x0069150E File Offset: 0x0068F70E
		public int EntityId { get; set; }

		// Token: 0x1700CD83 RID: 52611
		// (get) Token: 0x0603054A RID: 197962 RVA: 0x00691517 File Offset: 0x0068F717
		// (set) Token: 0x0603054B RID: 197963 RVA: 0x0069151F File Offset: 0x0068F71F
		public TMoveDriveModeUnion MoveDriveMode { get; set; }

		// Token: 0x0603054C RID: 197964 RVA: 0x00691528 File Offset: 0x0068F728
		public IEntitySplineMoveTargetT()
		{
			this.Type = ESplineMoveTargetType.Entity;
			this.EntityId = 0;
			this.MoveDriveMode = null;
		}
	}
}
