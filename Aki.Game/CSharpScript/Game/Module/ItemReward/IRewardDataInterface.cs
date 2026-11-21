using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047C2 RID: 18370
	[NullableContext(1)]
	public interface IRewardDataInterface
	{
		// Token: 0x17005DD0 RID: 24016
		// (get) Token: 0x0602E258 RID: 189016
		// (set) Token: 0x0602E259 RID: 189017
		[Nullable(2)]
		IExtendRewardInfo ExtendRewardInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005DD1 RID: 24017
		// (get) Token: 0x0602E25A RID: 189018
		// (set) Token: 0x0602E25B RID: 189019
		Dictionary<int, RewardItemData> ItemConfigIdMap { get; set; }

		// Token: 0x17005DD2 RID: 24018
		// (get) Token: 0x0602E25C RID: 189020
		// (set) Token: 0x0602E25D RID: 189021
		Dictionary<int, RewardItemData> ItemUniqueIdMap { get; set; }

		// Token: 0x0602E25E RID: 189022
		void SetItemList([Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemList);

		// Token: 0x0602E25F RID: 189023
		void AddItem(RewardItemData rewardItemData);

		// Token: 0x0602E260 RID: 189024
		void SetExploreRecordInfo(IRewardExploreRecord exploreRecordInfo);

		// Token: 0x0602E261 RID: 189025
		void AddItemList(IReadOnlyList<RewardItemData> itemList);

		// Token: 0x0602E262 RID: 189026
		void SetExploreBarDataList(List<IRewardExploreBar> exploreBarDataList);

		// Token: 0x0602E263 RID: 189027
		void SetProgressQueue([Nullable(new byte[]
		{
			2,
			1
		})] List<IRewardProgress> progressQueue = null);

		// Token: 0x0602E264 RID: 189028
		void SetExploreFriendDataList(List<IRewardExploreFriendData> friendDataList);

		// Token: 0x0602E265 RID: 189029
		void SetButtonInfoList(List<IRewardExploreConfirmButton> buttonInfoList);
	}
}
