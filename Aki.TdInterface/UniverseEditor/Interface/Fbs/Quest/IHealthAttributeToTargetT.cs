using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042D5 RID: 17109
	public class IHealthAttributeToTargetT
	{
		// Token: 0x1700752F RID: 29999
		// (get) Token: 0x06018043 RID: 98371 RVA: 0x0036DAA6 File Offset: 0x0036BCA6
		// (set) Token: 0x06018044 RID: 98372 RVA: 0x0036DAAE File Offset: 0x0036BCAE
		public EAttributeToTarget Type { get; set; }

		// Token: 0x17007530 RID: 30000
		// (get) Token: 0x06018045 RID: 98373 RVA: 0x0036DAB7 File Offset: 0x0036BCB7
		// (set) Token: 0x06018046 RID: 98374 RVA: 0x0036DABF File Offset: 0x0036BCBF
		public float Min { get; set; }

		// Token: 0x17007531 RID: 30001
		// (get) Token: 0x06018047 RID: 98375 RVA: 0x0036DAC8 File Offset: 0x0036BCC8
		// (set) Token: 0x06018048 RID: 98376 RVA: 0x0036DAD0 File Offset: 0x0036BCD0
		public float Max { get; set; }

		// Token: 0x17007532 RID: 30002
		// (get) Token: 0x06018049 RID: 98377 RVA: 0x0036DAD9 File Offset: 0x0036BCD9
		// (set) Token: 0x0601804A RID: 98378 RVA: 0x0036DAE1 File Offset: 0x0036BCE1
		public bool ZeroHealthOnDeath { get; set; }

		// Token: 0x17007533 RID: 30003
		// (get) Token: 0x0601804B RID: 98379 RVA: 0x0036DAEA File Offset: 0x0036BCEA
		// (set) Token: 0x0601804C RID: 98380 RVA: 0x0036DAF2 File Offset: 0x0036BCF2
		public byte NullMask { get; set; }

		// Token: 0x0601804D RID: 98381 RVA: 0x0036DAFB File Offset: 0x0036BCFB
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
