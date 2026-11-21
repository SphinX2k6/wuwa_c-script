using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013A9 RID: 5033
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryQuestView : UiViewBase
{
	// Token: 0x0600C7AD RID: 51117 RVA: 0x003B713E File Offset: 0x003B533E
	public HonamiStoryQuestView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C7AE RID: 51118 RVA: 0x003B7154 File Offset: 0x003B5354
	protected unsafe override void OnRegisterComponent()
	{
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C7AF RID: 51119 RVA: 0x003B7374 File Offset: 0x003B5574
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryQuestView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryQuestView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7B0 RID: 51120 RVA: 0x003B73B7 File Offset: 0x003B55B7
	protected override void OnBeforeShow()
	{
		base.GetItem(11).SetUIActive(false);
		base.GetItem(6).SetUIActive(false);
		base.GetItem(5).SetUIActive(false);
		this.RefreshDetail();
	}

	// Token: 0x0600C7B1 RID: 51121 RVA: 0x003B73E8 File Offset: 0x003B55E8
	private UniTask InitTaskScrollViewAsync()
	{
		HonamiStoryQuestView.<InitTaskScrollViewAsync>d__13 <InitTaskScrollViewAsync>d__;
		<InitTaskScrollViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTaskScrollViewAsync>d__.<>4__this = this;
		<InitTaskScrollViewAsync>d__.<>1__state = -1;
		<InitTaskScrollViewAsync>d__.<>t__builder.Start<HonamiStoryQuestView.<InitTaskScrollViewAsync>d__13>(ref <InitTaskScrollViewAsync>d__);
		return <InitTaskScrollViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7B2 RID: 51122 RVA: 0x003B742C File Offset: 0x003B562C
	private void InitTaskChildItemList()
	{
		if (this.CurSelectChildItem != null)
		{
			this.CurSelectChildItem.OnDeselected();
			this.CurSelectChildItem = null;
		}
		List<HonamiStoryQuestItem> layoutItemList = this.TaskScrollVieW.GetLayoutItemList();
		this.TaskChildItemList.Clear();
		foreach (HonamiStoryQuestItem honamiStoryQuestItem in layoutItemList)
		{
			foreach (HonamiStoryQuestItemChildItem item in honamiStoryQuestItem.GetTaskChildItemList())
			{
				this.TaskChildItemList.Add(item);
			}
		}
		if (this.TaskChildItemList.Count == 0)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.LRC, "HonamiStoryQuestView 没有任务子item", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.CurSelectChildItem == null)
		{
			this.CurSelectChildItem = this.TaskChildItemList[0];
		}
		this.CurSelectChildItem.OnSelected();
	}

	// Token: 0x0600C7B3 RID: 51123 RVA: 0x003B7534 File Offset: 0x003B5734
	private void RefreshDetail()
	{
		if (this.CurSelectChildItem == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.LRC, "HonamiStoryQuestView 没有当前选中任务item", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		HonamiStoryQuestDataBase data = this.CurSelectChildItem.Data;
		if (data == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.LRC, "HonamiStoryQuestView 没有任务数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		bool isInDungeon = data.IsInDungeon;
		this.RefreshDetailTitle(data);
		base.GetText(8).SetText(data.GetDesc(), true);
		int rewardId = data.GetRewardId();
		if (rewardId == 0)
		{
			this.RewardLayout.SetActive(false);
			base.GetText(14).SetUIActive(false);
		}
		else
		{
			List<TItem> rewardItems = this.GetRewardItems(rewardId);
			bool flag = rewardItems.Count > 0;
			this.RewardLayout.RefreshByData(rewardItems, null, false);
			this.RewardLayout.SetActive(flag);
			base.GetText(14).SetUIActive(flag);
		}
		this.ConfirmButtonItem.SetActive(false);
		if (isInDungeon && data.TaskType == EHonamiStoryQuestType.Sub)
		{
			bool flag2 = data.IsFinished();
			base.GetItem(11).SetUIActive(flag2);
			if (!flag2)
			{
				this.RefreshConfirmButtonText(data);
				this.ConfirmButtonItem.SetEnableClick(true);
				this.ConfirmButtonItem.SetActive(true);
			}
		}
		if (!isInDungeon && data.TaskType == EHonamiStoryQuestType.Main)
		{
			this.ConfirmButtonItem.SetLocalTextNew("HonamiStory_MainTask_Tracking", Array.Empty<object>());
			this.ConfirmButtonItem.SetEnableClick(false);
			this.ConfirmButtonItem.SetActive(true);
		}
		this.RefreshQuestSteps(data);
	}

	// Token: 0x0600C7B4 RID: 51124 RVA: 0x003B76B0 File Offset: 0x003B58B0
	private void RefreshDetailTitle(HonamiStoryQuestDataBase taskData)
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(taskData.GetNameKey(), null);
		UUIText text = base.GetText(3);
		string newText;
		if (taskData.TaskType == EHonamiStoryQuestType.Main)
		{
			newText = StringUtils.Format("<color=#b3dffa>{0}</color>", new string[]
			{
				localTextNew
			});
			if (text != null)
			{
				text.SetRichText(true);
			}
		}
		else if (((HonamiStorySubQuestData)taskData).Config.Value.TaskType != 1)
		{
			if (text != null)
			{
				text.SetRichText(false);
			}
			newText = localTextNew;
		}
		else
		{
			if (text != null)
			{
				text.SetRichText(true);
			}
			newText = StringUtils.Format("<color=#b3dffa>{0}</color>", new string[]
			{
				localTextNew
			});
		}
		if (text != null)
		{
			text.SetText(newText, true);
		}
	}

	// Token: 0x0600C7B5 RID: 51125 RVA: 0x003B7754 File Offset: 0x003B5954
	private void RefreshConfirmButtonText(HonamiStoryQuestDataBase taskData)
	{
		int id = taskData.Id;
		HonamiStoryQuestDataBase curTrackTaskData = HonamiStoryModel.Instance.CurTrackTaskData;
		int? num = (curTrackTaskData != null) ? new int?(curTrackTaskData.Id) : null;
		if (id == num.GetValueOrDefault() & num != null)
		{
			this.ConfirmButtonItem.SetLocalTextNew("HonamiStory_Cancel_Track", Array.Empty<object>());
			return;
		}
		this.ConfirmButtonItem.SetLocalTextNew("HonamiStory_Track", Array.Empty<object>());
	}

	// Token: 0x0600C7B6 RID: 51126 RVA: 0x003B77CC File Offset: 0x003B59CC
	private UniTask RefreshQuestSteps(HonamiStoryQuestDataBase taskData)
	{
		HonamiStoryQuestView.<RefreshQuestSteps>d__18 <RefreshQuestSteps>d__;
		<RefreshQuestSteps>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshQuestSteps>d__.<>4__this = this;
		<RefreshQuestSteps>d__.taskData = taskData;
		<RefreshQuestSteps>d__.<>1__state = -1;
		<RefreshQuestSteps>d__.<>t__builder.Start<HonamiStoryQuestView.<RefreshQuestSteps>d__18>(ref <RefreshQuestSteps>d__);
		return <RefreshQuestSteps>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7B7 RID: 51127 RVA: 0x003B7818 File Offset: 0x003B5A18
	private void OnClickTaskToggle(HonamiStoryQuestItemChildItem taskItem)
	{
		if (this.CurSelectChildItem == taskItem)
		{
			return;
		}
		HonamiStoryQuestItemChildItem curSelectChildItem = this.CurSelectChildItem;
		if (curSelectChildItem != null)
		{
			curSelectChildItem.OnDeselected();
		}
		this.CurSelectChildItem = taskItem;
		this.CurSelectChildItem.OnSelected();
		this.RefreshDetail();
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (((levelSequencePlayer != null) ? levelSequencePlayer.GetCurrentSequence() : null) != "Switch")
		{
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
			return;
		}
		else
		{
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 == null)
			{
				return;
			}
			levelSequencePlayer3.ReplaySequenceByKey("Switch");
			return;
		}
	}

	// Token: 0x0600C7B8 RID: 51128 RVA: 0x003B78AC File Offset: 0x003B5AAC
	private HonamiStoryQuestItem InitTaskItem()
	{
		HonamiStoryQuestItem honamiStoryQuestItem = new HonamiStoryQuestItem();
		honamiStoryQuestItem.BindOnClickTask(new Action<HonamiStoryQuestItemChildItem>(this.OnClickTaskToggle));
		return honamiStoryQuestItem;
	}

	// Token: 0x0600C7B9 RID: 51129 RVA: 0x003B78C5 File Offset: 0x003B5AC5
	private CommonItemSmallItemGrid InitRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600C7BA RID: 51130 RVA: 0x003B78CC File Offset: 0x003B5ACC
	private List<TItem> GetRewardItems(int dropId)
	{
		List<TItem> list = new List<TItem>();
		Dictionary<int, int> dropPackagePreview = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreview(dropId);
		HonamiStoryQuestItemChildItem curSelectChildItem = this.CurSelectChildItem;
		HonamiStoryQuestDataBase honamiStoryQuestDataBase = (curSelectChildItem != null) ? curSelectChildItem.Data : null;
		foreach (KeyValuePair<int, int> keyValuePair in dropPackagePreview)
		{
			int num;
			int num2;
			keyValuePair.Deconstruct(out num, out num2);
			int itemId = num;
			int num3 = num2;
			if (honamiStoryQuestDataBase != null && honamiStoryQuestDataBase.TaskType == EHonamiStoryQuestType.Sub)
			{
				int count = num3 * HonamiStoryModel.Instance.GetSubTaskBonusDataList();
				list.Add(new TItem(new InventoryDefine.GetItemData(itemId, 0), count));
			}
			else
			{
				list.Add(new TItem(new InventoryDefine.GetItemData(itemId, 0), num3));
			}
		}
		return list;
	}

	// Token: 0x0600C7BB RID: 51131 RVA: 0x003B7990 File Offset: 0x003B5B90
	private void OnClickConfirm(int _)
	{
		HonamiStoryQuestItemChildItem curSelectChildItem = this.CurSelectChildItem;
		HonamiStoryQuestDataBase honamiStoryQuestDataBase = (curSelectChildItem != null) ? curSelectChildItem.Data : null;
		if (honamiStoryQuestDataBase == null)
		{
			return;
		}
		HonamiStoryModel.Instance.SetSubQuestTrack(honamiStoryQuestDataBase);
		base.CloseMe(null);
	}

	// Token: 0x040071A8 RID: 29096
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040071A9 RID: 29097
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<HonamiStoryQuestItem, EHonamiStoryQuestType> TaskScrollVieW;

	// Token: 0x040071AA RID: 29098
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x040071AB RID: 29099
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040071AC RID: 29100
	private ButtonItem ConfirmButtonItem;

	// Token: 0x040071AD RID: 29101
	[Nullable(2)]
	private QuestViewStep QuestViewStep;

	// Token: 0x040071AE RID: 29102
	[Nullable(2)]
	private HonamiStoryQuestItemChildItem CurSelectChildItem;

	// Token: 0x040071AF RID: 29103
	private readonly List<HonamiStoryQuestItemChildItem> TaskChildItemList = new List<HonamiStoryQuestItemChildItem>();

	// Token: 0x02007663 RID: 30307
	[NullableContext(0)]
	private enum EHonamiStoryQuestComponents
	{
		// Token: 0x040266F2 RID: 157426
		CaptionItem,
		// Token: 0x040266F3 RID: 157427
		TaskScrollView,
		// Token: 0x040266F4 RID: 157428
		TaskItem,
		// Token: 0x040266F5 RID: 157429
		TaskNameText,
		// Token: 0x040266F6 RID: 157430
		DetailsStepsRoot,
		// Token: 0x040266F7 RID: 157431
		ParentStep,
		// Token: 0x040266F8 RID: 157432
		TimeNode,
		// Token: 0x040266F9 RID: 157433
		TimeText,
		// Token: 0x040266FA RID: 157434
		TaskDescriptionText,
		// Token: 0x040266FB RID: 157435
		RewardScrollView,
		// Token: 0x040266FC RID: 157436
		RewardItem,
		// Token: 0x040266FD RID: 157437
		PanelDetailTipsNode,
		// Token: 0x040266FE RID: 157438
		BtnLeft,
		// Token: 0x040266FF RID: 157439
		BtnRight,
		// Token: 0x04026700 RID: 157440
		RewardTitleText
	}
}
