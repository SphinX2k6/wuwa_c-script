using System;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x0200653B RID: 25915
	public class IActorRefT
	{
		// Token: 0x1700BF2C RID: 48940
		// (get) Token: 0x0602C2D0 RID: 180944 RVA: 0x006042B6 File Offset: 0x006024B6
		// (set) Token: 0x0602C2D1 RID: 180945 RVA: 0x006042BE File Offset: 0x006024BE
		public string ActorName { get; set; }

		// Token: 0x1700BF2D RID: 48941
		// (get) Token: 0x0602C2D2 RID: 180946 RVA: 0x006042C7 File Offset: 0x006024C7
		// (set) Token: 0x0602C2D3 RID: 180947 RVA: 0x006042CF File Offset: 0x006024CF
		public string PathName { get; set; }

		// Token: 0x1700BF2E RID: 48942
		// (get) Token: 0x0602C2D4 RID: 180948 RVA: 0x006042D8 File Offset: 0x006024D8
		// (set) Token: 0x0602C2D5 RID: 180949 RVA: 0x006042E0 File Offset: 0x006024E0
		public EActorPlatform Platform { get; set; }

		// Token: 0x1700BF2F RID: 48943
		// (get) Token: 0x0602C2D6 RID: 180950 RVA: 0x006042E9 File Offset: 0x006024E9
		// (set) Token: 0x0602C2D7 RID: 180951 RVA: 0x006042F1 File Offset: 0x006024F1
		public byte NullMask { get; set; }

		// Token: 0x0602C2D8 RID: 180952 RVA: 0x006042FA File Offset: 0x006024FA
		public IActorRefT()
		{
			this.ActorName = null;
			this.PathName = null;
			this.Platform = EActorPlatform.Desktop;
			this.NullMask = 0;
		}
	}
}
