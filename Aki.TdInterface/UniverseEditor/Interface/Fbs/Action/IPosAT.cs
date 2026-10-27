using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D63 RID: 28003
	public class IPosAT
	{
		// Token: 0x1700D0D6 RID: 53462
		// (get) Token: 0x06031726 RID: 202534 RVA: 0x006B449A File Offset: 0x006B269A
		// (set) Token: 0x06031727 RID: 202535 RVA: 0x006B44A2 File Offset: 0x006B26A2
		public float X { get; set; }

		// Token: 0x1700D0D7 RID: 53463
		// (get) Token: 0x06031728 RID: 202536 RVA: 0x006B44AB File Offset: 0x006B26AB
		// (set) Token: 0x06031729 RID: 202537 RVA: 0x006B44B3 File Offset: 0x006B26B3
		public float Y { get; set; }

		// Token: 0x1700D0D8 RID: 53464
		// (get) Token: 0x0603172A RID: 202538 RVA: 0x006B44BC File Offset: 0x006B26BC
		// (set) Token: 0x0603172B RID: 202539 RVA: 0x006B44C4 File Offset: 0x006B26C4
		public float Z { get; set; }

		// Token: 0x1700D0D9 RID: 53465
		// (get) Token: 0x0603172C RID: 202540 RVA: 0x006B44CD File Offset: 0x006B26CD
		// (set) Token: 0x0603172D RID: 202541 RVA: 0x006B44D5 File Offset: 0x006B26D5
		public float A { get; set; }

		// Token: 0x1700D0DA RID: 53466
		// (get) Token: 0x0603172E RID: 202542 RVA: 0x006B44DE File Offset: 0x006B26DE
		// (set) Token: 0x0603172F RID: 202543 RVA: 0x006B44E6 File Offset: 0x006B26E6
		public byte NullMask { get; set; }

		// Token: 0x06031730 RID: 202544 RVA: 0x006B44EF File Offset: 0x006B26EF
		public IPosAT()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.A = 0f;
			this.NullMask = 0;
		}
	}
}
