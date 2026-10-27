using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065FA RID: 26106
	public class FishingReward : IFishingReward
	{
		// Token: 0x170095D1 RID: 38353
		// (get) Token: 0x060416F6 RID: 268022 RVA: 0x00FD9A6E File Offset: 0x00FD7C6E
		// (set) Token: 0x060416F7 RID: 268023 RVA: 0x00FD9A76 File Offset: 0x00FD7C76
		public int Id { get; set; }

		// Token: 0x170095D2 RID: 38354
		// (get) Token: 0x060416F8 RID: 268024 RVA: 0x00FD9A7F File Offset: 0x00FD7C7F
		// (set) Token: 0x060416F9 RID: 268025 RVA: 0x00FD9A87 File Offset: 0x00FD7C87
		public int Current { get; set; }

		// Token: 0x170095D3 RID: 38355
		// (get) Token: 0x060416FA RID: 268026 RVA: 0x00FD9A90 File Offset: 0x00FD7C90
		// (set) Token: 0x060416FB RID: 268027 RVA: 0x00FD9A98 File Offset: 0x00FD7C98
		public int Target { get; set; }

		// Token: 0x170095D4 RID: 38356
		// (get) Token: 0x060416FC RID: 268028 RVA: 0x00FD9AA1 File Offset: 0x00FD7CA1
		// (set) Token: 0x060416FD RID: 268029 RVA: 0x00FD9AA9 File Offset: 0x00FD7CA9
		public bool IsFinished { get; set; }

		// Token: 0x170095D5 RID: 38357
		// (get) Token: 0x060416FE RID: 268030 RVA: 0x00FD9AB2 File Offset: 0x00FD7CB2
		// (set) Token: 0x060416FF RID: 268031 RVA: 0x00FD9ABA File Offset: 0x00FD7CBA
		public bool IsTaken { get; set; }
	}
}
