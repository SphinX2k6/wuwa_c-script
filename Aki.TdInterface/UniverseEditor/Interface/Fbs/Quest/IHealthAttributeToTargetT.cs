using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E97 RID: 16023
	public class IHealthAttributeToTargetT
	{
		// Token: 0x17006F42 RID: 28482
		// (get) Token: 0x060169F6 RID: 92662 RVA: 0x00344B1E File Offset: 0x00342D1E
		// (set) Token: 0x060169F7 RID: 92663 RVA: 0x00344B26 File Offset: 0x00342D26
		public EAttributeToTarget Type { get; set; }

		// Token: 0x17006F43 RID: 28483
		// (get) Token: 0x060169F8 RID: 92664 RVA: 0x00344B2F File Offset: 0x00342D2F
		// (set) Token: 0x060169F9 RID: 92665 RVA: 0x00344B37 File Offset: 0x00342D37
		public float Min { get; set; }

		// Token: 0x17006F44 RID: 28484
		// (get) Token: 0x060169FA RID: 92666 RVA: 0x00344B40 File Offset: 0x00342D40
		// (set) Token: 0x060169FB RID: 92667 RVA: 0x00344B48 File Offset: 0x00342D48
		public float Max { get; set; }

		// Token: 0x17006F45 RID: 28485
		// (get) Token: 0x060169FC RID: 92668 RVA: 0x00344B51 File Offset: 0x00342D51
		// (set) Token: 0x060169FD RID: 92669 RVA: 0x00344B59 File Offset: 0x00342D59
		public bool ZeroHealthOnDeath { get; set; }

		// Token: 0x17006F46 RID: 28486
		// (get) Token: 0x060169FE RID: 92670 RVA: 0x00344B62 File Offset: 0x00342D62
		// (set) Token: 0x060169FF RID: 92671 RVA: 0x00344B6A File Offset: 0x00342D6A
		public byte NullMask { get; set; }

		// Token: 0x06016A00 RID: 92672 RVA: 0x00344B73 File Offset: 0x00342D73
		public IHealthAttributeToTargetT()
		{
			this.Type = EAttributeToTarget.Health;
			this.Min = 0f;
			this.Max = 0f;
			this.ZeroHealthOnDeath = false;
			this.NullMask = 0;
		}
	}
}
