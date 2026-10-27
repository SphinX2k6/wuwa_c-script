using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020022DB RID: 8923
[NullableContext(1)]
public interface IOnlinePlayerData : IPlayerData
{
	// Token: 0x17001655 RID: 5717
	// (get) Token: 0x060118A1 RID: 71841
	int HeadId { get; }

	// Token: 0x17001656 RID: 5718
	// (get) Token: 0x060118A2 RID: 71842
	int Level { get; }

	// Token: 0x17001657 RID: 5719
	// (get) Token: 0x060118A3 RID: 71843
	string Name { get; }

	// Token: 0x17001658 RID: 5720
	// (get) Token: 0x060118A4 RID: 71844
	int PlayerTitleId { get; }

	// Token: 0x17001659 RID: 5721
	// (get) Token: 0x060118A5 RID: 71845
	int PlayerTitleStarLevel { get; }

	// Token: 0x1700165A RID: 5722
	// (get) Token: 0x060118A6 RID: 71846
	int Sex { get; }

	// Token: 0x1700165B RID: 5723
	// (get) Token: 0x060118A7 RID: 71847
	PlayerDetails PlayerDetails { get; }

	// Token: 0x1700165C RID: 5724
	// (get) Token: 0x060118A8 RID: 71848
	int CurUsingCardId { get; }

	// Token: 0x1700165D RID: 5725
	// (get) Token: 0x060118A9 RID: 71849
	List<PersonalCardData> CardUnlockList { get; }

	// Token: 0x060118AA RID: 71850
	bool GetIfCanShowInHallList([Nullable(new byte[]
	{
		2,
		1
	})] Dictionary<string, bool> blockMap = null);

	// Token: 0x1700165E RID: 5726
	// (get) Token: 0x060118AB RID: 71851
	string ThirdPartyUserId { get; }
}
