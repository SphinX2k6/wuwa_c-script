using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C89 RID: 15497
	[NullableContext(1)]
	[Nullable(0)]
	public class DisplayableItem : IDisplayableItem
	{
		// Token: 0x1700513E RID: 20798
		// (get) Token: 0x06027A33 RID: 162355 RVA: 0x00B1A332 File Offset: 0x00B18532
		// (set) Token: 0x06027A34 RID: 162356 RVA: 0x00B1A33A File Offset: 0x00B1853A
		public string DisplayName { get; set; }

		// Token: 0x1700513F RID: 20799
		// (get) Token: 0x06027A35 RID: 162357 RVA: 0x00B1A343 File Offset: 0x00B18543
		// (set) Token: 0x06027A36 RID: 162358 RVA: 0x00B1A34B File Offset: 0x00B1854B
		public string DisplayIcon { get; set; }

		// Token: 0x17005140 RID: 20800
		// (get) Token: 0x06027A37 RID: 162359 RVA: 0x00B1A354 File Offset: 0x00B18554
		// (set) Token: 0x06027A38 RID: 162360 RVA: 0x00B1A35C File Offset: 0x00B1855C
		public int? DisplayCount { get; set; }

		// Token: 0x17005141 RID: 20801
		// (get) Token: 0x06027A39 RID: 162361 RVA: 0x00B1A365 File Offset: 0x00B18565
		// (set) Token: 0x06027A3A RID: 162362 RVA: 0x00B1A36D File Offset: 0x00B1856D
		public bool IsUnlocked { get; set; }

		// Token: 0x17005142 RID: 20802
		// (get) Token: 0x06027A3B RID: 162363 RVA: 0x00B1A376 File Offset: 0x00B18576
		// (set) Token: 0x06027A3C RID: 162364 RVA: 0x00B1A37E File Offset: 0x00B1857E
		public bool IsEquipped { get; set; }

		// Token: 0x17005143 RID: 20803
		// (get) Token: 0x06027A3D RID: 162365 RVA: 0x00B1A387 File Offset: 0x00B18587
		// (set) Token: 0x06027A3E RID: 162366 RVA: 0x00B1A38F File Offset: 0x00B1858F
		public int? QualityLevel { get; set; }

		// Token: 0x17005144 RID: 20804
		// (get) Token: 0x06027A3F RID: 162367 RVA: 0x00B1A398 File Offset: 0x00B18598
		// (set) Token: 0x06027A40 RID: 162368 RVA: 0x00B1A3A0 File Offset: 0x00B185A0
		public bool? IsFinished { get; set; }

		// Token: 0x17005145 RID: 20805
		// (get) Token: 0x06027A41 RID: 162369 RVA: 0x00B1A3A9 File Offset: 0x00B185A9
		// (set) Token: 0x06027A42 RID: 162370 RVA: 0x00B1A3B1 File Offset: 0x00B185B1
		public EClickActionType ClickAction { get; set; }

		// Token: 0x17005146 RID: 20806
		// (get) Token: 0x06027A43 RID: 162371 RVA: 0x00B1A3BA File Offset: 0x00B185BA
		// (set) Token: 0x06027A44 RID: 162372 RVA: 0x00B1A3C2 File Offset: 0x00B185C2
		public int? ClickParam { get; set; }
	}
}
