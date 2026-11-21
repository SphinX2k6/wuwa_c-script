using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View
{
	// Token: 0x02003B40 RID: 15168
	[NullableContext(1)]
	[Nullable(0)]
	public class SlidingBlocksSettlementView : UiViewBase
	{
		// Token: 0x06026FBF RID: 159679 RVA: 0x00AE9CE2 File Offset: 0x00AE7EE2
		public SlidingBlocksSettlementView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06026FC0 RID: 159680 RVA: 0x00AE9CF8 File Offset: 0x00AE7EF8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIItem)),
				new ValueTuple<int, Type>(19, typeof(UUIText)),
				new ValueTuple<int, Type>(20, typeof(UUIItem)),
				new ValueTuple<int, Type>(21, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(22, typeof(UUIItem)),
				new ValueTuple<int, Type>(23, typeof(UUIItem))
			};
		}

		// Token: 0x06026FC1 RID: 159681 RVA: 0x00AE9E34 File Offset: 0x00AE8034
		protected override UniTask OnBeforeStartAsync()
		{
			SlidingBlocksSettlementView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SlidingBlocksSettlementView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026FC2 RID: 159682 RVA: 0x00AE9E78 File Offset: 0x00AE8078
		private UniTask NewCubeResult(int historyScore, List<TItem> rewardList)
		{
			SlidingBlocksSettlementView.<NewCubeResult>d__7 <NewCubeResult>d__;
			<NewCubeResult>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewCubeResult>d__.<>4__this = this;
			<NewCubeResult>d__.historyScore = historyScore;
			<NewCubeResult>d__.rewardList = rewardList;
			<NewCubeResult>d__.<>1__state = -1;
			<NewCubeResult>d__.<>t__builder.Start<SlidingBlocksSettlementView.<NewCubeResult>d__7>(ref <NewCubeResult>d__);
			return <NewCubeResult>d__.<>t__builder.Task;
		}

		// Token: 0x06026FC3 RID: 159683 RVA: 0x00AE9ECC File Offset: 0x00AE80CC
		private void InitButtons(int instanceId)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			List<IRewardExploreConfirmButton> list = new List<IRewardExploreConfirmButton>();
			RewardExploreConfirmButtonData rewardExploreConfirmButtonData = new RewardExploreConfirmButtonData();
			rewardExploreConfirmButtonData.ButtonTextId = "Text_ButtonTextExit_Text";
			rewardExploreConfirmButtonData.DescriptionTextId = "GenericPromptTypes_2_GeneralText";
			rewardExploreConfirmButtonData.DescriptionArgs = null;
			rewardExploreConfirmButtonData.TimeDown = new int?(config.Value.AutoLeaveTime * TimeUtil.Instance.InverseMillisecond);
			rewardExploreConfirmButtonData.IsTimeDownCloseView = true;
			rewardExploreConfirmButtonData.OnTimeDownOnCallback = delegate()
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
			};
			rewardExploreConfirmButtonData.IsClickedCloseView = false;
			rewardExploreConfirmButtonData.OnClickedCallback = delegate(int index)
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Finally(delegate()
				{
					base.CloseMe(null);
				});
			};
			RewardExploreConfirmButtonData item = rewardExploreConfirmButtonData;
			list.Add(item);
			RewardExploreConfirmButtonData item2 = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "Text_ChallengeAgain_Text",
				DescriptionTextId = null,
				DescriptionArgs = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = false,
				OnClickedCallback = delegate(int index)
				{
					InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false).Finally(delegate()
					{
						base.CloseMe(null);
					});
				}
			};
			list.Add(item2);
			if (list != null && list != null && list.Count > 0)
			{
				int num = 0;
				foreach (IRewardExploreConfirmButton buttonData in list)
				{
					this.NewButton(buttonData, num);
					num++;
				}
			}
		}

		// Token: 0x06026FC4 RID: 159684 RVA: 0x00AEA028 File Offset: 0x00AE8228
		private RewardExploreConfirmButton NewButton(IRewardExploreConfirmButton buttonData, int buttonIndex)
		{
			UUIItem item = base.GetItem(5);
			UUIItem item2 = base.GetItem(4);
			RewardExploreConfirmButton rewardExploreConfirmButton = new RewardExploreConfirmButton(LguiUtil.Instance.DuplicateActor(item.GetOwner(), item2), buttonIndex);
			rewardExploreConfirmButton.Refresh(buttonData);
			rewardExploreConfirmButton.SetActive(true);
			this.ButtonList.Add(rewardExploreConfirmButton);
			return rewardExploreConfirmButton;
		}

		// Token: 0x06026FC5 RID: 159685 RVA: 0x00AEA078 File Offset: 0x00AE8278
		protected override void OnAfterShow()
		{
		}

		// Token: 0x06026FC6 RID: 159686 RVA: 0x00AEA07C File Offset: 0x00AE827C
		protected override void OnAfterPlayStartSequence()
		{
			this.UiViewSequence.PlaySequence(this.IsSuccess ? "Success" : "Fail", true, null);
		}

		// Token: 0x06026FC7 RID: 159687 RVA: 0x00AEA0B2 File Offset: 0x00AE82B2
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x040154A9 RID: 87209
		[Nullable(2)]
		private CubeResultItem CubeResultItem;

		// Token: 0x040154AA RID: 87210
		private readonly List<RewardExploreConfirmButton> ButtonList = new List<RewardExploreConfirmButton>();

		// Token: 0x040154AB RID: 87211
		private bool IsSuccess;

		// Token: 0x020097C6 RID: 38854
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0402F57C RID: 193916
			TitleItem,
			// Token: 0x0402F57D RID: 193917
			TitleText,
			// Token: 0x0402F57E RID: 193918
			TitleTexture,
			// Token: 0x0402F57F RID: 193919
			ContentItem,
			// Token: 0x0402F580 RID: 193920
			ButtonHorizontalItem,
			// Token: 0x0402F581 RID: 193921
			ButtonItem,
			// Token: 0x0402F582 RID: 193922
			ToggleItem,
			// Token: 0x0402F583 RID: 193923
			DoubleTip = 18,
			// Token: 0x0402F584 RID: 193924
			DoubleTipTxt,
			// Token: 0x0402F585 RID: 193925
			Content,
			// Token: 0x0402F586 RID: 193926
			FriendItem,
			// Token: 0x0402F587 RID: 193927
			FriendGrid,
			// Token: 0x0402F588 RID: 193928
			ItemTeam
		}
	}
}
