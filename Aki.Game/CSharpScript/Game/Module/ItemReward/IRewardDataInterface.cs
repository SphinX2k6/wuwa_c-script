using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057EB RID: 22507
	[NullableContext(1)]
	public interface IRewardDataInterface
	{
		// Token: 0x17008A06 RID: 35334
		// (get) Token: 0x06039344 RID: 234308
		// (set) Token: 0x06039345 RID: 234309
		[Nullable(2)]
		IExtendRewardInfo ExtendRewardInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008A07 RID: 35335
		// (get) Token: 0x06039346 RID: 234310
		// (set) Token: 0x06039347 RID: 234311
		Dictionary<int, RewardItemData> ItemConfigIdMap { get; set; }

		// Token: 0x17008A08 RID: 35336
		// (get) Token: 0x06039348 RID: 234312
		// (set) Token: 0x06039349 RID: 234313
		Dictionary<int, RewardItemData> ItemUniqueIdMap { get; set; }

		// Token: 0x0603934A RID: 234314
		void SetItemList([Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemList);

		// Token: 0x0603934B RID: 234315
		void AddItem(RewardItemData rewardItemData);

		// Token: 0x0603934C RID: 234316
		void SetExploreRecordInfo(IRewardExploreRecord exploreRecordInfo);

		// Token: 0x0603934D RID: 234317
		void AddItemList(IReadOnlyList<RewardItemData> itemList);

		// Token: 0x0603934E RID: 234318
		void SetExploreBarDataList(List<IRewardExploreBar> exploreBarDataList);

		// Token: 0x0603934F RID: 234319
		void SetProgressQueue([Nullable(new byte[]
		{
			2,
			1
		})] List<IRewardProgress> progressQueue = null);

		// Token: 0x06039350 RID: 234320
		void SetExploreFriendDataList(List<IRewardExploreFriendData> friendDataList);

		// Token: 0x06039351 RID: 234321
		void SetButtonInfoList(List<IRewardExploreConfirmButton> buttonInfoList);
	}
}
