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
	// Token: 0x02004B96 RID: 19350
	[NullableContext(1)]
	[Nullable(0)]
	public class SlidingBlocksSettlementView : UiViewBase
	{
		// Token: 0x0603222F RID: 205359 RVA: 0x00BA5B96 File Offset: 0x00BA3D96
		public SlidingBlocksSettlementView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06032230 RID: 205360 RVA: 0x00BA5BAC File Offset: 0x00BA3DAC
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

		// Token: 0x06032231 RID: 205361 RVA: 0x00BA5CE8 File Offset: 0x00BA3EE8
		protected override UniTask OnBeforeStartAsync()
		{
			SlidingBlocksSettlementView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SlidingBlocksSettlementView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032232 RID: 205362 RVA: 0x00BA5D2C File Offset: 0x00BA3F2C
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

		// Token: 0x06032233 RID: 205363 RVA: 0x00BA5D80 File Offset: 0x00BA3F80
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
					InstanceDungeonEntranceController.Instance.RestartInstanceDungeon().Finally(delegate()
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

		// Token: 0x06032234 RID: 205364 RVA: 0x00BA5EDC File Offset: 0x00BA40DC
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

		// Token: 0x06032235 RID: 205365 RVA: 0x00BA5F2C File Offset: 0x00BA412C
		protected override void OnAfterShow()
		{
		}

		// Token: 0x06032236 RID: 205366 RVA: 0x00BA5F30 File Offset: 0x00BA4130
		protected override void OnAfterPlayStartSequence()
		{
			this.UiViewSequence.PlaySequence(this.IsSuccess ? "Success" : "Fail", true, null);
		}

		// Token: 0x06032237 RID: 205367 RVA: 0x00BA5F66 File Offset: 0x00BA4166
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0401AB55 RID: 109397
		[Nullable(2)]
		private CubeResultItem CubeResultItem;

		// Token: 0x0401AB56 RID: 109398
		private readonly List<RewardExploreConfirmButton> ButtonList = new List<RewardExploreConfirmButton>();

		// Token: 0x0401AB57 RID: 109399
		private bool IsSuccess;

		// Token: 0x0200ADA7 RID: 44455
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034BD5 RID: 216021
			TitleItem,
			// Token: 0x04034BD6 RID: 216022
			TitleText,
			// Token: 0x04034BD7 RID: 216023
			TitleTexture,
			// Token: 0x04034BD8 RID: 216024
			ContentItem,
			// Token: 0x04034BD9 RID: 216025
			ButtonHorizontalItem,
			// Token: 0x04034BDA RID: 216026
			ButtonItem,
			// Token: 0x04034BDB RID: 216027
			ToggleItem,
			// Token: 0x04034BDC RID: 216028
			DoubleTip = 18,
			// Token: 0x04034BDD RID: 216029
			DoubleTipTxt,
			// Token: 0x04034BDE RID: 216030
			Content,
			// Token: 0x04034BDF RID: 216031
			FriendItem,
			// Token: 0x04034BE0 RID: 216032
			FriendGrid,
			// Token: 0x04034BE1 RID: 216033
			ItemTeam
		}
	}
}
