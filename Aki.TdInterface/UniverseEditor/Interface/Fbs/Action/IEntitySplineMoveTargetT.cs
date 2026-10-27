using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066EB RID: 26347
	public class IEntitySplineMoveTargetT
	{
		// Token: 0x1700C3CB RID: 50123
		// (get) Token: 0x0602DD09 RID: 187657 RVA: 0x00643F81 File Offset: 0x00642181
		// (set) Token: 0x0602DD0A RID: 187658 RVA: 0x00643F89 File Offset: 0x00642189
		public ESplineMoveTargetType Type { get; set; }

		// Token: 0x1700C3CC RID: 50124
		// (get) Token: 0x0602DD0B RID: 187659 RVA: 0x00643F92 File Offset: 0x00642192
		// (set) Token: 0x0602DD0C RID: 187660 RVA: 0x00643F9A File Offset: 0x0064219A
		public int EntityId { get; set; }

		// Token: 0x1700C3CD RID: 50125
		// (get) Token: 0x0602DD0D RID: 187661 RVA: 0x00643FA3 File Offset: 0x006421A3
		// (set) Token: 0x0602DD0E RID: 187662 RVA: 0x00643FAB File Offset: 0x006421AB
		public TMoveDriveModeUnion MoveDriveMode { get; set; }

		// Token: 0x0602DD0F RID: 187663 RVA: 0x00643FB4 File Offset: 0x006421B4
		public IEntitySplineMoveTargetT()
		{
			this.Type = ESplineMoveTargetType.Entity;
			this.EntityId = 0;
			this.MoveDriveMode = null;
		}
	}
}
