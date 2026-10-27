using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005B02 RID: 23298
	[NullableContext(1)]
	[Nullable(0)]
	public class MachiningData : IMachiningData, ICookItemData
	{
		// Token: 0x17008C63 RID: 35939
		// (get) Token: 0x0603AFE5 RID: 241637 RVA: 0x00E11041 File Offset: 0x00E0F241
		// (set) Token: 0x0603AFE6 RID: 241638 RVA: 0x00E11049 File Offset: 0x00E0F249
		public ECookListType MainType { get; set; }

		// Token: 0x17008C64 RID: 35940
		// (get) Token: 0x0603AFE7 RID: 241639 RVA: 0x00E11052 File Offset: 0x00E0F252
		// (set) Token: 0x0603AFE8 RID: 241640 RVA: 0x00E1105A File Offset: 0x00E0F25A
		public int ItemId { get; set; }

		// Token: 0x17008C65 RID: 35941
		// (get) Token: 0x0603AFE9 RID: 241641 RVA: 0x00E11063 File Offset: 0x00E0F263
		// (set) Token: 0x0603AFEA RID: 241642 RVA: 0x00E1106B File Offset: 0x00E0F26B
		public bool IsNew { get; set; }

		// Token: 0x17008C66 RID: 35942
		// (get) Token: 0x0603AFEB RID: 241643 RVA: 0x00E11074 File Offset: 0x00E0F274
		// (set) Token: 0x0603AFEC RID: 241644 RVA: 0x00E1107C File Offset: 0x00E0F27C
		public int Quality { get; set; }

		// Token: 0x17008C67 RID: 35943
		// (get) Token: 0x0603AFED RID: 241645 RVA: 0x00E11085 File Offset: 0x00E0F285
		// (set) Token: 0x0603AFEE RID: 241646 RVA: 0x00E1108D File Offset: 0x00E0F28D
		public bool IsUnLock { get; set; }

		// Token: 0x17008C68 RID: 35944
		// (get) Token: 0x0603AFEF RID: 241647 RVA: 0x00E11096 File Offset: 0x00E0F296
		// (set) Token: 0x0603AFF0 RID: 241648 RVA: 0x00E1109E File Offset: 0x00E0F29E
		public List<int> InteractiveList { get; set; }

		// Token: 0x17008C69 RID: 35945
		// (get) Token: 0x0603AFF1 RID: 241649 RVA: 0x00E110A7 File Offset: 0x00E0F2A7
		// (set) Token: 0x0603AFF2 RID: 241650 RVA: 0x00E110AF File Offset: 0x00E0F2AF
		public List<int> UnlockList { get; set; }

		// Token: 0x17008C6A RID: 35946
		// (get) Token: 0x0603AFF3 RID: 241651 RVA: 0x00E110B8 File Offset: 0x00E0F2B8
		// (set) Token: 0x0603AFF4 RID: 241652 RVA: 0x00E110C0 File Offset: 0x00E0F2C0
		public int IsMachining { get; set; }
	}
}
