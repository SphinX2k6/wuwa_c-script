using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006749 RID: 26441
	public class IActorLookAtPlayerDataT
	{
		// Token: 0x1700C041 RID: 49217
		// (get) Token: 0x0602CCEB RID: 183531 RVA: 0x00620EB2 File Offset: 0x0061F0B2
		// (set) Token: 0x0602CCEC RID: 183532 RVA: 0x00620EBA File Offset: 0x0061F0BA
		public EActorLookAtMode Type { get; set; }

		// Token: 0x1700C042 RID: 49218
		// (get) Token: 0x0602CCED RID: 183533 RVA: 0x00620EC3 File Offset: 0x0061F0C3
		// (set) Token: 0x0602CCEE RID: 183534 RVA: 0x00620ECB File Offset: 0x0061F0CB
		public bool Lock { get; set; }

		// Token: 0x1700C043 RID: 49219
		// (get) Token: 0x0602CCEF RID: 183535 RVA: 0x00620ED4 File Offset: 0x0061F0D4
		// (set) Token: 0x0602CCF0 RID: 183536 RVA: 0x00620EDC File Offset: 0x0061F0DC
		public byte NullMask { get; set; }

		// Token: 0x0602CCF1 RID: 183537 RVA: 0x00620EE5 File Offset: 0x0061F0E5
		public IActorLookAtPlayerDataT()
		{
			this.Type = EActorLookAtMode.Talker;
			this.Lock = false;
			this.NullMask = 0;
		}
	}
}
