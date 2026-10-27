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

// Token: 0x02001EE7 RID: 7911
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryQuestView : UiViewBase
{
	// Token: 0x0600F38E RID: 62350 RVA: 0x003AB642 File Offset: 0x003A9842
	public HonamiStoryQuestView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F38F RID: 62351 RVA: 0x003AB658 File Offset: 0x003A9858
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

	// Token: 0x0600F390 RID: 62352 RVA: 0x003AB878 File Offset: 0x003A9A78
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryQuestView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryQuestView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F391 RID: 62353 RVA: 0x003AB8BB File Offset: 0x003A9ABB
	protected override void OnBeforeShow()
	{
		base.GetItem(11).SetUIActive(false);
		base.GetItem(6).SetUIActive(false);
		base.GetItem(5).SetUIActive(false);
		this.RefreshDetail();
	}

	// Token: 0x0600F392 RID: 62354 RVA: 0x003AB8EC File Offset: 0x003A9AEC
	private UniTask InitTaskScrollViewAsync()
	{
		HonamiStoryQuestView.<InitTaskScrollViewAsync>d__13 <InitTaskScrollViewAsync>d__;
		<InitTaskScrollViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTaskScrollViewAsync>d__.<>4__this = this;
		<InitTaskScrollViewAsync>d__.<>1__state = -1;
		<InitTaskScrollViewAsync>d__.<>t__builder.Start<HonamiStoryQuestView.<InitTaskScrollViewAsync>d__13>(ref <InitTaskScrollViewAsync>d__);
		return <InitTaskScrollViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F393 RID: 62355 RVA: 0x003AB930 File Offset: 0x003A9B30
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

	// Token: 0x0600F394 RID: 62356 RVA: 0x003ABA38 File Offset: 0x003A9C38
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

	// Token: 0x0600F395 RID: 62357 RVA: 0x003ABBB4 File Offset: 0x003A9DB4
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

	// Token: 0x0600F396 RID: 62358 RVA: 0x003ABC58 File Offset: 0x003A9E58
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

	// Token: 0x0600F397 RID: 62359 RVA: 0x003ABCD0 File Offset: 0x003A9ED0
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

	// Token: 0x0600F398 RID: 62360 RVA: 0x003ABD1C File Offset: 0x003A9F1C
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

	// Token: 0x0600F399 RID: 62361 RVA: 0x003ABDB0 File Offset: 0x003A9FB0
	private HonamiStoryQuestItem InitTaskItem()
	{
		HonamiStoryQuestItem honamiStoryQuestItem = new HonamiStoryQuestItem();
		honamiStoryQuestItem.BindOnClickTask(new Action<HonamiStoryQuestItemChildItem>(this.OnClickTaskToggle));
		return honamiStoryQuestItem;
	}

	// Token: 0x0600F39A RID: 62362 RVA: 0x003ABDC9 File Offset: 0x003A9FC9
	private CommonItemSmallItemGrid InitRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600F39B RID: 62363 RVA: 0x003ABDD0 File Offset: 0x003A9FD0
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

	// Token: 0x0600F39C RID: 62364 RVA: 0x003ABE94 File Offset: 0x003AA094
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

	// Token: 0x040070C7 RID: 28871
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040070C8 RID: 28872
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<HonamiStoryQuestItem, EHonamiStoryQuestType> TaskScrollVieW;

	// Token: 0x040070C9 RID: 28873
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x040070CA RID: 28874
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040070CB RID: 28875
	private ButtonItem ConfirmButtonItem;

	// Token: 0x040070CC RID: 28876
	[Nullable(2)]
	private QuestViewStep QuestViewStep;

	// Token: 0x040070CD RID: 28877
	[Nullable(2)]
	private HonamiStoryQuestItemChildItem CurSelectChildItem;

	// Token: 0x040070CE RID: 28878
	private readonly List<HonamiStoryQuestItemChildItem> TaskChildItemList = new List<HonamiStoryQuestItemChildItem>();

	// Token: 0x020084DE RID: 34014
	[NullableContext(0)]
	private enum EHonamiStoryQuestComponents
	{
		// Token: 0x0402B3CE RID: 177102
		CaptionItem,
		// Token: 0x0402B3CF RID: 177103
		TaskScrollView,
		// Token: 0x0402B3D0 RID: 177104
		TaskItem,
		// Token: 0x0402B3D1 RID: 177105
		TaskNameText,
		// Token: 0x0402B3D2 RID: 177106
		DetailsStepsRoot,
		// Token: 0x0402B3D3 RID: 177107
		ParentStep,
		// Token: 0x0402B3D4 RID: 177108
		TimeNode,
		// Token: 0x0402B3D5 RID: 177109
		TimeText,
		// Token: 0x0402B3D6 RID: 177110
		TaskDescriptionText,
		// Token: 0x0402B3D7 RID: 177111
		RewardScrollView,
		// Token: 0x0402B3D8 RID: 177112
		RewardItem,
		// Token: 0x0402B3D9 RID: 177113
		PanelDetailTipsNode,
		// Token: 0x0402B3DA RID: 177114
		BtnLeft,
		// Token: 0x0402B3DB RID: 177115
		BtnRight,
		// Token: 0x0402B3DC RID: 177116
		RewardTitleText
	}
}
