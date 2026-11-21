using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AE2 RID: 15074
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseParsedStageMessage : ITowerDefenseParsedStageMessage
	{
		// Token: 0x17004F52 RID: 20306
		// (get) Token: 0x06026B9A RID: 158618 RVA: 0x00AD6917 File Offset: 0x00AD4B17
		// (set) Token: 0x06026B9B RID: 158619 RVA: 0x00AD691F File Offset: 0x00AD4B1F
		public TowerDefenceInstanceInfo Meta { get; set; }

		// Token: 0x17004F53 RID: 20307
		// (get) Token: 0x06026B9C RID: 158620 RVA: 0x00AD6928 File Offset: 0x00AD4B28
		// (set) Token: 0x06026B9D RID: 158621 RVA: 0x00AD6930 File Offset: 0x00AD4B30
		public int Id { get; set; }

		// Token: 0x17004F54 RID: 20308
		// (get) Token: 0x06026B9E RID: 158622 RVA: 0x00AD6939 File Offset: 0x00AD4B39
		// (set) Token: 0x06026B9F RID: 158623 RVA: 0x00AD6941 File Offset: 0x00AD4B41
		public long UnlockTime { get; set; }

		// Token: 0x17004F55 RID: 20309
		// (get) Token: 0x06026BA0 RID: 158624 RVA: 0x00AD694A File Offset: 0x00AD4B4A
		// (set) Token: 0x06026BA1 RID: 158625 RVA: 0x00AD6952 File Offset: 0x00AD4B52
		public bool Passed { get; set; }

		// Token: 0x17004F56 RID: 20310
		// (get) Token: 0x06026BA2 RID: 158626 RVA: 0x00AD695B File Offset: 0x00AD4B5B
		// (set) Token: 0x06026BA3 RID: 158627 RVA: 0x00AD6963 File Offset: 0x00AD4B63
		public double PassTime { get; set; }

		// Token: 0x17004F57 RID: 20311
		// (get) Token: 0x06026BA4 RID: 158628 RVA: 0x00AD696C File Offset: 0x00AD4B6C
		// (set) Token: 0x06026BA5 RID: 158629 RVA: 0x00AD6974 File Offset: 0x00AD4B74
		public bool Rewarded { get; set; }

		// Token: 0x17004F58 RID: 20312
		// (get) Token: 0x06026BA6 RID: 158630 RVA: 0x00AD697D File Offset: 0x00AD4B7D
		// (set) Token: 0x06026BA7 RID: 158631 RVA: 0x00AD6985 File Offset: 0x00AD4B85
		public int Record { get; set; }

		// Token: 0x17004F59 RID: 20313
		// (get) Token: 0x06026BA8 RID: 158632 RVA: 0x00AD698E File Offset: 0x00AD4B8E
		// (set) Token: 0x06026BA9 RID: 158633 RVA: 0x00AD6996 File Offset: 0x00AD4B96
		public bool RecordOverThreshold { get; set; }
	}
}
