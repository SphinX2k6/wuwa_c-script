using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B3A RID: 19258
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseParsedStageMessage : ITowerDefenseParsedStageMessage
	{
		// Token: 0x17007BA5 RID: 31653
		// (get) Token: 0x06031E0A RID: 204298 RVA: 0x00B928B3 File Offset: 0x00B90AB3
		// (set) Token: 0x06031E0B RID: 204299 RVA: 0x00B928BB File Offset: 0x00B90ABB
		public TowerDefenceInstanceInfo Meta { get; set; }

		// Token: 0x17007BA6 RID: 31654
		// (get) Token: 0x06031E0C RID: 204300 RVA: 0x00B928C4 File Offset: 0x00B90AC4
		// (set) Token: 0x06031E0D RID: 204301 RVA: 0x00B928CC File Offset: 0x00B90ACC
		public int Id { get; set; }

		// Token: 0x17007BA7 RID: 31655
		// (get) Token: 0x06031E0E RID: 204302 RVA: 0x00B928D5 File Offset: 0x00B90AD5
		// (set) Token: 0x06031E0F RID: 204303 RVA: 0x00B928DD File Offset: 0x00B90ADD
		public long UnlockTime { get; set; }

		// Token: 0x17007BA8 RID: 31656
		// (get) Token: 0x06031E10 RID: 204304 RVA: 0x00B928E6 File Offset: 0x00B90AE6
		// (set) Token: 0x06031E11 RID: 204305 RVA: 0x00B928EE File Offset: 0x00B90AEE
		public bool Passed { get; set; }

		// Token: 0x17007BA9 RID: 31657
		// (get) Token: 0x06031E12 RID: 204306 RVA: 0x00B928F7 File Offset: 0x00B90AF7
		// (set) Token: 0x06031E13 RID: 204307 RVA: 0x00B928FF File Offset: 0x00B90AFF
		public double PassTime { get; set; }

		// Token: 0x17007BAA RID: 31658
		// (get) Token: 0x06031E14 RID: 204308 RVA: 0x00B92908 File Offset: 0x00B90B08
		// (set) Token: 0x06031E15 RID: 204309 RVA: 0x00B92910 File Offset: 0x00B90B10
		public bool Rewarded { get; set; }

		// Token: 0x17007BAB RID: 31659
		// (get) Token: 0x06031E16 RID: 204310 RVA: 0x00B92919 File Offset: 0x00B90B19
		// (set) Token: 0x06031E17 RID: 204311 RVA: 0x00B92921 File Offset: 0x00B90B21
		public int Record { get; set; }

		// Token: 0x17007BAC RID: 31660
		// (get) Token: 0x06031E18 RID: 204312 RVA: 0x00B9292A File Offset: 0x00B90B2A
		// (set) Token: 0x06031E19 RID: 204313 RVA: 0x00B92932 File Offset: 0x00B90B32
		public bool RecordOverThreshold { get; set; }
	}
}
