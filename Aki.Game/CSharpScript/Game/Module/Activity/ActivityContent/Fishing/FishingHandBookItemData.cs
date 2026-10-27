using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006604 RID: 26116
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingHandBookItemData : IFishingHandBookItemData
	{
		// Token: 0x170095F4 RID: 38388
		// (get) Token: 0x06041741 RID: 268097 RVA: 0x00FD9BCD File Offset: 0x00FD7DCD
		// (set) Token: 0x06041742 RID: 268098 RVA: 0x00FD9BD5 File Offset: 0x00FD7DD5
		public int Id { get; set; }

		// Token: 0x170095F5 RID: 38389
		// (get) Token: 0x06041743 RID: 268099 RVA: 0x00FD9BDE File Offset: 0x00FD7DDE
		// (set) Token: 0x06041744 RID: 268100 RVA: 0x00FD9BE6 File Offset: 0x00FD7DE6
		public int Type { get; set; }

		// Token: 0x170095F6 RID: 38390
		// (get) Token: 0x06041745 RID: 268101 RVA: 0x00FD9BEF File Offset: 0x00FD7DEF
		// (set) Token: 0x06041746 RID: 268102 RVA: 0x00FD9BF7 File Offset: 0x00FD7DF7
		public int Time { get; set; }

		// Token: 0x170095F7 RID: 38391
		// (get) Token: 0x06041747 RID: 268103 RVA: 0x00FD9C00 File Offset: 0x00FD7E00
		// (set) Token: 0x06041748 RID: 268104 RVA: 0x00FD9C08 File Offset: 0x00FD7E08
		public List<int> Tech { get; set; }

		// Token: 0x170095F8 RID: 38392
		// (get) Token: 0x06041749 RID: 268105 RVA: 0x00FD9C11 File Offset: 0x00FD7E11
		// (set) Token: 0x0604174A RID: 268106 RVA: 0x00FD9C19 File Offset: 0x00FD7E19
		public List<int> Area { get; set; }

		// Token: 0x170095F9 RID: 38393
		// (get) Token: 0x0604174B RID: 268107 RVA: 0x00FD9C22 File Offset: 0x00FD7E22
		// (set) Token: 0x0604174C RID: 268108 RVA: 0x00FD9C2A File Offset: 0x00FD7E2A
		public int HandBookId { get; set; }

		// Token: 0x0604174D RID: 268109 RVA: 0x00FD9C33 File Offset: 0x00FD7E33
		public FishingHandBookItemData()
		{
			this.Tech = new List<int>();
			this.Area = new List<int>();
		}
	}
}
