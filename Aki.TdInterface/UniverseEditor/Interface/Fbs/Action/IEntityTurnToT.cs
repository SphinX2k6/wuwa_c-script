using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D71 RID: 28017
	public class IEntityTurnToT
	{
		// Token: 0x1700CD8E RID: 52622
		// (get) Token: 0x06030581 RID: 198017 RVA: 0x00691CB7 File Offset: 0x0068FEB7
		// (set) Token: 0x06030582 RID: 198018 RVA: 0x00691CBF File Offset: 0x0068FEBF
		public int EntityId { get; set; }

		// Token: 0x1700CD8F RID: 52623
		// (get) Token: 0x06030583 RID: 198019 RVA: 0x00691CC8 File Offset: 0x0068FEC8
		// (set) Token: 0x06030584 RID: 198020 RVA: 0x00691CD0 File Offset: 0x0068FED0
		public TActorTurnToDataUnion Target { get; set; }

		// Token: 0x1700CD90 RID: 52624
		// (get) Token: 0x06030585 RID: 198021 RVA: 0x00691CD9 File Offset: 0x0068FED9
		// (set) Token: 0x06030586 RID: 198022 RVA: 0x00691CE1 File Offset: 0x0068FEE1
		public bool UseLookAtForSmallAngle { get; set; }

		// Token: 0x1700CD91 RID: 52625
		// (get) Token: 0x06030587 RID: 198023 RVA: 0x00691CEA File Offset: 0x0068FEEA
		// (set) Token: 0x06030588 RID: 198024 RVA: 0x00691CF2 File Offset: 0x0068FEF2
		public byte NullMask { get; set; }

		// Token: 0x06030589 RID: 198025 RVA: 0x00691CFB File Offset: 0x0068FEFB
		public IEntityTurnToT()
		{
			this.EntityId = 0;
			this.Target = null;
			this.UseLookAtForSmallAngle = false;
			this.NullMask = 0;
		}
	}
}
