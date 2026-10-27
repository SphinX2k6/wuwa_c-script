using System;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02005EF8 RID: 24312
	public class IActorRefT
	{
		// Token: 0x1700B5C1 RID: 46529
		// (get) Token: 0x06029C1C RID: 171036 RVA: 0x005BADD2 File Offset: 0x005B8FD2
		// (set) Token: 0x06029C1D RID: 171037 RVA: 0x005BADDA File Offset: 0x005B8FDA
		public string ActorName { get; set; }

		// Token: 0x1700B5C2 RID: 46530
		// (get) Token: 0x06029C1E RID: 171038 RVA: 0x005BADE3 File Offset: 0x005B8FE3
		// (set) Token: 0x06029C1F RID: 171039 RVA: 0x005BADEB File Offset: 0x005B8FEB
		public string PathName { get; set; }

		// Token: 0x1700B5C3 RID: 46531
		// (get) Token: 0x06029C20 RID: 171040 RVA: 0x005BADF4 File Offset: 0x005B8FF4
		// (set) Token: 0x06029C21 RID: 171041 RVA: 0x005BADFC File Offset: 0x005B8FFC
		public EActorPlatform Platform { get; set; }

		// Token: 0x1700B5C4 RID: 46532
		// (get) Token: 0x06029C22 RID: 171042 RVA: 0x005BAE05 File Offset: 0x005B9005
		// (set) Token: 0x06029C23 RID: 171043 RVA: 0x005BAE0D File Offset: 0x005B900D
		public byte NullMask { get; set; }

		// Token: 0x06029C24 RID: 171044 RVA: 0x005BAE16 File Offset: 0x005B9016
		public IActorRefT()
		{
			this.ActorName = null;
			this.PathName = null;
			this.Platform = EActorPlatform.Desktop;
			this.NullMask = 0;
		}
	}
}
