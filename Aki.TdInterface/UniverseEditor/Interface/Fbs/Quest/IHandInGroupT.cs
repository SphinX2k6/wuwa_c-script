using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E88 RID: 16008
	public class IHandInGroupT
	{
		// Token: 0x17006F10 RID: 28432
		// (get) Token: 0x0601692E RID: 92462 RVA: 0x00342FF9 File Offset: 0x003411F9
		// (set) Token: 0x0601692F RID: 92463 RVA: 0x00343001 File Offset: 0x00341201
		public EHandInItemType HandInType { get; set; }

		// Token: 0x17006F11 RID: 28433
		// (get) Token: 0x06016930 RID: 92464 RVA: 0x0034300A File Offset: 0x0034120A
		// (set) Token: 0x06016931 RID: 92465 RVA: 0x00343012 File Offset: 0x00341212
		public List<int> ItemIds { get; set; }

		// Token: 0x17006F12 RID: 28434
		// (get) Token: 0x06016932 RID: 92466 RVA: 0x0034301B File Offset: 0x0034121B
		// (set) Token: 0x06016933 RID: 92467 RVA: 0x00343023 File Offset: 0x00341223
		public int Count { get; set; }

		// Token: 0x17006F13 RID: 28435
		// (get) Token: 0x06016934 RID: 92468 RVA: 0x0034302C File Offset: 0x0034122C
		// (set) Token: 0x06016935 RID: 92469 RVA: 0x00343034 File Offset: 0x00341234
		public int Slot { get; set; }

		// Token: 0x17006F14 RID: 28436
		// (get) Token: 0x06016936 RID: 92470 RVA: 0x0034303D File Offset: 0x0034123D
		// (set) Token: 0x06016937 RID: 92471 RVA: 0x00343045 File Offset: 0x00341245
		public IHandInItemRangeT ChoiceRange { get; set; }

		// Token: 0x06016938 RID: 92472 RVA: 0x0034304E File Offset: 0x0034124E
		public IHandInGroupT()
		{
			this.HandInType = EHandInItemType.ItemIds;
			this.ItemIds = null;
			this.Count = 0;
			this.Slot = 0;
			this.ChoiceRange = null;
		}
	}
}
