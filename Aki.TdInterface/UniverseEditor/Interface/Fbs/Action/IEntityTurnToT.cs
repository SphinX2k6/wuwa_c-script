using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066F1 RID: 26353
	public class IEntityTurnToT
	{
		// Token: 0x1700C3D8 RID: 50136
		// (get) Token: 0x0602DD44 RID: 187716 RVA: 0x00644743 File Offset: 0x00642943
		// (set) Token: 0x0602DD45 RID: 187717 RVA: 0x0064474B File Offset: 0x0064294B
		public int EntityId { get; set; }

		// Token: 0x1700C3D9 RID: 50137
		// (get) Token: 0x0602DD46 RID: 187718 RVA: 0x00644754 File Offset: 0x00642954
		// (set) Token: 0x0602DD47 RID: 187719 RVA: 0x0064475C File Offset: 0x0064295C
		public TActorTurnToDataUnion Target { get; set; }

		// Token: 0x1700C3DA RID: 50138
		// (get) Token: 0x0602DD48 RID: 187720 RVA: 0x00644765 File Offset: 0x00642965
		// (set) Token: 0x0602DD49 RID: 187721 RVA: 0x0064476D File Offset: 0x0064296D
		public bool UseLookAtForSmallAngle { get; set; }

		// Token: 0x1700C3DB RID: 50139
		// (get) Token: 0x0602DD4A RID: 187722 RVA: 0x00644776 File Offset: 0x00642976
		// (set) Token: 0x0602DD4B RID: 187723 RVA: 0x0064477E File Offset: 0x0064297E
		public byte NullMask { get; set; }

		// Token: 0x0602DD4C RID: 187724 RVA: 0x00644787 File Offset: 0x00642987
		public IEntityTurnToT()
		{
			this.EntityId = 0;
			this.Target = null;
			this.UseLookAtForSmallAngle = false;
			this.NullMask = 0;
		}
	}
}
