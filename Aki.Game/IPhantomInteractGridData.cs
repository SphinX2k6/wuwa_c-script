using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200193F RID: 6463
[NullableContext(1)]
public interface IPhantomInteractGridData
{
	// Token: 0x17001871 RID: 6257
	// (get) Token: 0x0600FF6C RID: 65388
	int MonsterId { get; }

	// Token: 0x17001872 RID: 6258
	// (get) Token: 0x0600FF6D RID: 65389
	int MonsterInfoId { get; }

	// Token: 0x17001873 RID: 6259
	// (get) Token: 0x0600FF6E RID: 65390
	List<int> SkinIds { get; }

	// Token: 0x17001874 RID: 6260
	// (get) Token: 0x0600FF6F RID: 65391
	int EquippedSkin { get; }

	// Token: 0x17001875 RID: 6261
	// (get) Token: 0x0600FF70 RID: 65392
	bool IsSpecial { get; }

	// Token: 0x17001876 RID: 6262
	// (get) Token: 0x0600FF71 RID: 65393
	bool HasSkin { get; }

	// Token: 0x17001877 RID: 6263
	// (get) Token: 0x0600FF72 RID: 65394
	int Cost { get; }

	// Token: 0x17001878 RID: 6264
	// (get) Token: 0x0600FF73 RID: 65395
	List<int> InteractAreaList { get; }

	// Token: 0x17001879 RID: 6265
	// (get) Token: 0x0600FF74 RID: 65396
	bool IsUnlocked { get; }

	// Token: 0x1700187A RID: 6266
	// (get) Token: 0x0600FF75 RID: 65397
	[Nullable(2)]
	string Name { [NullableContext(2)] get; }

	// Token: 0x1700187B RID: 6267
	// (get) Token: 0x0600FF76 RID: 65398
	int InSlotIndex { get; }

	// Token: 0x1700187C RID: 6268
	// (get) Token: 0x0600FF77 RID: 65399
	[Nullable(2)]
	string IconPath { [NullableContext(2)] get; }

	// Token: 0x1700187D RID: 6269
	// (get) Token: 0x0600FF78 RID: 65400
	int GetWayConfigId { get; }

	// Token: 0x1700187E RID: 6270
	// (get) Token: 0x0600FF79 RID: 65401
	int SortId { get; }
}
