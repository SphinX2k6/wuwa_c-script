using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005578 RID: 21880
	public class FishingReward : IFishingReward
	{
		// Token: 0x17006933 RID: 26931
		// (get) Token: 0x060363BB RID: 222139 RVA: 0x00F20AEE File Offset: 0x00F1ECEE
		// (set) Token: 0x060363BC RID: 222140 RVA: 0x00F20AF6 File Offset: 0x00F1ECF6
		public int Id { get; set; }

		// Token: 0x17006934 RID: 26932
		// (get) Token: 0x060363BD RID: 222141 RVA: 0x00F20AFF File Offset: 0x00F1ECFF
		// (set) Token: 0x060363BE RID: 222142 RVA: 0x00F20B07 File Offset: 0x00F1ED07
		public int Current { get; set; }

		// Token: 0x17006935 RID: 26933
		// (get) Token: 0x060363BF RID: 222143 RVA: 0x00F20B10 File Offset: 0x00F1ED10
		// (set) Token: 0x060363C0 RID: 222144 RVA: 0x00F20B18 File Offset: 0x00F1ED18
		public int Target { get; set; }

		// Token: 0x17006936 RID: 26934
		// (get) Token: 0x060363C1 RID: 222145 RVA: 0x00F20B21 File Offset: 0x00F1ED21
		// (set) Token: 0x060363C2 RID: 222146 RVA: 0x00F20B29 File Offset: 0x00F1ED29
		public bool IsFinished { get; set; }

		// Token: 0x17006937 RID: 26935
		// (get) Token: 0x060363C3 RID: 222147 RVA: 0x00F20B32 File Offset: 0x00F1ED32
		// (set) Token: 0x060363C4 RID: 222148 RVA: 0x00F20B3A File Offset: 0x00F1ED3A
		public bool IsTaken { get; set; }
	}
}
