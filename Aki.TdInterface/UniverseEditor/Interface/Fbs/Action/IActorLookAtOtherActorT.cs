using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006746 RID: 26438
	public class IActorLookAtOtherActorT
	{
		// Token: 0x1700C039 RID: 49209
		// (get) Token: 0x0602CCCF RID: 183503 RVA: 0x00620BF8 File Offset: 0x0061EDF8
		// (set) Token: 0x0602CCD0 RID: 183504 RVA: 0x00620C00 File Offset: 0x0061EE00
		public EActorLookAtMode Type { get; set; }

		// Token: 0x1700C03A RID: 49210
		// (get) Token: 0x0602CCD1 RID: 183505 RVA: 0x00620C09 File Offset: 0x0061EE09
		// (set) Token: 0x0602CCD2 RID: 183506 RVA: 0x00620C11 File Offset: 0x0061EE11
		public bool Lock { get; set; }

		// Token: 0x1700C03B RID: 49211
		// (get) Token: 0x0602CCD3 RID: 183507 RVA: 0x00620C1A File Offset: 0x0061EE1A
		// (set) Token: 0x0602CCD4 RID: 183508 RVA: 0x00620C22 File Offset: 0x0061EE22
		public int ActorIndex { get; set; }

		// Token: 0x1700C03C RID: 49212
		// (get) Token: 0x0602CCD5 RID: 183509 RVA: 0x00620C2B File Offset: 0x0061EE2B
		// (set) Token: 0x0602CCD6 RID: 183510 RVA: 0x00620C33 File Offset: 0x0061EE33
		public byte NullMask { get; set; }

		// Token: 0x0602CCD7 RID: 183511 RVA: 0x00620C3C File Offset: 0x0061EE3C
		public IActorLookAtOtherActorT()
		{
			this.Type = EActorLookAtMode.Talker;
			this.Lock = false;
			this.ActorIndex = 0;
			this.NullMask = 0;
		}
	}
}
