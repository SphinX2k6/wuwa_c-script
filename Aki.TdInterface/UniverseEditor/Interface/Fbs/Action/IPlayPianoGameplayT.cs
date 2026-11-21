using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074AE RID: 29870
	public class IPlayPianoGameplayT
	{
		// Token: 0x1700DB93 RID: 56211
		// (get) Token: 0x06034537 RID: 214327 RVA: 0x0070C2D6 File Offset: 0x0070A4D6
		// (set) Token: 0x06034538 RID: 214328 RVA: 0x0070C2DE File Offset: 0x0070A4DE
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700DB94 RID: 56212
		// (get) Token: 0x06034539 RID: 214329 RVA: 0x0070C2E7 File Offset: 0x0070A4E7
		// (set) Token: 0x0603453A RID: 214330 RVA: 0x0070C2EF File Offset: 0x0070A4EF
		public int SplineEntityId { get; set; }

		// Token: 0x1700DB95 RID: 56213
		// (get) Token: 0x0603453B RID: 214331 RVA: 0x0070C2F8 File Offset: 0x0070A4F8
		// (set) Token: 0x0603453C RID: 214332 RVA: 0x0070C300 File Offset: 0x0070A500
		public int RangeEntityId { get; set; }

		// Token: 0x0603453D RID: 214333 RVA: 0x0070C309 File Offset: 0x0070A509
		public IPlayPianoGameplayT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.SplineEntityId = 0;
			this.RangeEntityId = 0;
		}
	}
}
