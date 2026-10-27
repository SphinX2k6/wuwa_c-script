using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D33 RID: 27955
	public class IPlayPianoGameplayT
	{
		// Token: 0x1700D04B RID: 53323
		// (get) Token: 0x0603153B RID: 202043 RVA: 0x006B0BEE File Offset: 0x006AEDEE
		// (set) Token: 0x0603153C RID: 202044 RVA: 0x006B0BF6 File Offset: 0x006AEDF6
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D04C RID: 53324
		// (get) Token: 0x0603153D RID: 202045 RVA: 0x006B0BFF File Offset: 0x006AEDFF
		// (set) Token: 0x0603153E RID: 202046 RVA: 0x006B0C07 File Offset: 0x006AEE07
		public int SplineEntityId { get; set; }

		// Token: 0x1700D04D RID: 53325
		// (get) Token: 0x0603153F RID: 202047 RVA: 0x006B0C10 File Offset: 0x006AEE10
		// (set) Token: 0x06031540 RID: 202048 RVA: 0x006B0C18 File Offset: 0x006AEE18
		public int RangeEntityId { get; set; }

		// Token: 0x06031541 RID: 202049 RVA: 0x006B0C21 File Offset: 0x006AEE21
		public IPlayPianoGameplayT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.SplineEntityId = 0;
			this.RangeEntityId = 0;
		}
	}
}
