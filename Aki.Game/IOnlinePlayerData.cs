using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020017BF RID: 6079
[NullableContext(1)]
public interface IOnlinePlayerData : IPlayerData
{
	// Token: 0x1700168C RID: 5772
	// (get) Token: 0x0600ED38 RID: 60728
	int HeadId { get; }

	// Token: 0x1700168D RID: 5773
	// (get) Token: 0x0600ED39 RID: 60729
	int Level { get; }

	// Token: 0x1700168E RID: 5774
	// (get) Token: 0x0600ED3A RID: 60730
	string Name { get; }

	// Token: 0x1700168F RID: 5775
	// (get) Token: 0x0600ED3B RID: 60731
	int PlayerTitleId { get; }

	// Token: 0x17001690 RID: 5776
	// (get) Token: 0x0600ED3C RID: 60732
	int PlayerTitleStarLevel { get; }

	// Token: 0x17001691 RID: 5777
	// (get) Token: 0x0600ED3D RID: 60733
	int Sex { get; }

	// Token: 0x17001692 RID: 5778
	// (get) Token: 0x0600ED3E RID: 60734
	PlayerDetails PlayerDetails { get; }

	// Token: 0x17001693 RID: 5779
	// (get) Token: 0x0600ED3F RID: 60735
	int CurUsingCardId { get; }

	// Token: 0x17001694 RID: 5780
	// (get) Token: 0x0600ED40 RID: 60736
	List<PersonalCardData> CardUnlockList { get; }

	// Token: 0x0600ED41 RID: 60737
	bool GetIfCanShowInHallList([Nullable(new byte[]
	{
		2,
		1
	})] Dictionary<string, bool> blockMap = null);

	// Token: 0x17001695 RID: 5781
	// (get) Token: 0x0600ED42 RID: 60738
	string ThirdPartyUserId { get; }
}
