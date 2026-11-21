using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000B4B RID: 2891
[NullableContext(1)]
[Nullable(0)]
public class AdventureTargetView : UiTabViewBase
{
	// Token: 0x060078BE RID: 30910 RVA: 0x00255F1C File Offset: 0x0025411C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 20;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnRewardBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnPreBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnNextBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060078BF RID: 30911 RVA: 0x00256268 File Offset: 0x00254468
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.AdventureTaskStateChange, new Action<IReadOnlyList<int>>(this.OnTaskStateChange));
		EventSystem.Instance.Add(EEventName.ChapterRewardReceived, new Action<int>(this.OnChapterRewardReceived));
		EventSystem.Instance.Add(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
	}

	// Token: 0x060078C0 RID: 30912 RVA: 0x002562CC File Offset: 0x002544CC
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.AdventureTaskStateChange, new Action<IReadOnlyList<int>>(this.OnTaskStateChange));
		EventSystem.Instance.Remove(EEventName.ChapterRewardReceived, new Action<int>(this.OnChapterRewardReceived));
		EventSystem.Instance.Remove(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
	}

	// Token: 0x060078C1 RID: 30913 RVA: 0x00256330 File Offset: 0x00254530
	protected override void OnTickUiTabViewBase(float deltaTime)
	{
		if (this.StopFront)
		{
			return;
		}
		float fillAmount = this.FrontBarSprite.fillAmount;
		if (fillAmount < this.TargetFront)
		{
			float fillAmount2 = Math.Min(fillAmount + 0.01f, this.TargetFront);
			this.FrontBarSprite.SetFillAmount(fillAmount2);
		}
	}

	// Token: 0x060078C2 RID: 30914 RVA: 0x0025637C File Offset: 0x0025457C
	protected override void OnStart()
	{
		base.GetText(1).SetUIActive(false);
		this.FrontBarSprite = base.GetSprite(8);
		base.GetItem(14).SetUIActive(true);
		this.RewardBtn = base.GetButton(0);
		base.GetItem(5).SetUIActive(false);
		base.GetItem(2).SetUIActive(false);
		this.RewardLayout = new GenericLayout<AdventureTargetRewardItem, TItem>(base.GetLayoutBase(7), new Func<AdventureTargetRewardItem>(this.OnRewardLayoutUpdater), null, false, true);
		this.TargetItemLayout = new GenericScrollViewNew<AdventureTargetItem, AdventureTaskRecord>(base.GetScrollViewWithScrollbar(12), new Func<AdventureTargetItem>(this.OnTaskLayoutUpdater), null, false, null);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x060078C3 RID: 30915 RVA: 0x0025642C File Offset: 0x0025462C
	private AdventureTargetRewardItem OnRewardLayoutUpdater()
	{
		AdventureTargetRewardItem adventureTargetRewardItem = new AdventureTargetRewardItem();
		adventureTargetRewardItem.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnRewardItemClick));
		adventureTargetRewardItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanRewardItemChangeToggle));
		return adventureTargetRewardItem;
	}

	// Token: 0x060078C4 RID: 30916 RVA: 0x00256457 File Offset: 0x00254657
	private void OnRewardItemClick(MediumItemGridExtendCallback callbackParameter)
	{
		ItemController.Instance.OpenItemTipsByItemId(((TItem)callbackParameter.Data).ItemData.ItemId, true, null, false);
	}

	// Token: 0x060078C5 RID: 30917 RVA: 0x0025647B File Offset: 0x0025467B
	private bool CanRewardItemChangeToggle(object _, bool result, EToggleState state)
	{
		return false;
	}

	// Token: 0x060078C6 RID: 30918 RVA: 0x0025647E File Offset: 0x0025467E
	private AdventureTargetItem OnTaskLayoutUpdater()
	{
		AdventureTargetItem adventureTargetItem = new AdventureTargetItem();
		adventureTargetItem.SetClickGetButtonCb(new Action<int>(this.OnTaskItemGetClick));
		return adventureTargetItem;
	}

	// Token: 0x060078C7 RID: 30919 RVA: 0x00256498 File Offset: 0x00254698
	private void OnTaskItemGetClick(int adventureId)
	{
		if (this.Clicking)
		{
			return;
		}
		this.Clicking = true;
		AdventureTaskRecord[] chapterTasks = AdventureGuideModel.Instance.GetChapterTasks(this.NowShowingChapter);
		List<int> list = new List<int>();
		if (chapterTasks != null)
		{
			foreach (AdventureTaskRecord adventureTaskRecord in chapterTasks)
			{
				if (adventureTaskRecord.Status == AdventreTaskSate.Finish)
				{
					list.Add(adventureTaskRecord.AdventureTaskBase.Id);
				}
			}
		}
		AdventureGuideController.Instance.RequestMultiForAdventureReward(list.ToArray()).ContinueWith(delegate()
		{
			this.Clicking = false;
		});
	}

	// Token: 0x060078C8 RID: 30920 RVA: 0x00256522 File Offset: 0x00254722
	protected override void OnBeforeDestroy()
	{
		this.RewardLayout = null;
		this.TargetItemLayout = null;
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x060078C9 RID: 30921 RVA: 0x0025654C File Offset: 0x0025474C
	private void UpdateBtnStatus(int nowChapter)
	{
		UUIButtonComponent button = base.GetButton(3);
		UUIButtonComponent button2 = base.GetButton(4);
		if (button != null)
		{
			button.SetSelfInteractive(true);
		}
		if (button2 != null)
		{
			button2.SetSelfInteractive(true);
		}
		if (nowChapter == 1 && button != null)
		{
			button.SetSelfInteractive(false);
		}
		if (nowChapter == AdventureGuideConfig.Instance.GetMaxChapter() && button2 != null)
		{
			button2.SetSelfInteractive(false);
		}
	}

	// Token: 0x060078CA RID: 30922 RVA: 0x002565A4 File Offset: 0x002547A4
	protected override void OnBeforeShow()
	{
		this.FrontBarSprite.SetFillAmount(0f);
		int[] unLockChaptersList = AdventureGuideModel.Instance.GetUnLockChaptersList();
		int i = 1;
		int[] rewardChaptersList = AdventureGuideModel.Instance.GetRewardChaptersList();
		int num = 1;
		bool flag = false;
		int num2 = 1;
		bool flag2 = false;
		int num3 = 1;
		bool flag3 = false;
		while (i <= unLockChaptersList.Length)
		{
			AdventureTaskChapter? chapterAdventureConfig = AdventureGuideConfig.Instance.GetChapterAdventureConfig(i);
			if (chapterAdventureConfig != null)
			{
				int chapterReceivedCount = AdventureGuideModel.Instance.GetChapterReceivedCount(i);
				int rewardUnlockCount = chapterAdventureConfig.Value.RewardUnlockCount;
				if (Array.IndexOf<int>(rewardChaptersList, i) < 0 && chapterReceivedCount >= rewardUnlockCount && num <= i)
				{
					num = i;
					flag = true;
				}
				if (AdventureGuideModel.Instance.HaveChapterTasksFinish(i) && num2 <= i)
				{
					num2 = i;
					flag2 = true;
				}
				if (AdventureGuideModel.Instance.HaveChapterTasksUnFinish(i) && num3 <= i)
				{
					num3 = i;
					flag3 = true;
				}
			}
			i++;
		}
		int maxChapter = AdventureGuideConfig.Instance.GetMaxChapter();
		if (flag)
		{
			i = num;
		}
		else if (flag2)
		{
			i = num2;
		}
		else if (flag3)
		{
			i = num3;
		}
		this.SetAdventureTargetInfoByChapter(Math.Min(i, maxChapter), true);
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 != null)
		{
			levelSequencePlayer2.PlayLevelSequenceByName("Start", false, null, false);
		}
		EventSystem.Instance.Emit<int>(EEventName.AdventureHelpBtn, 0);
	}

	// Token: 0x060078CB RID: 30923 RVA: 0x002566F4 File Offset: 0x002548F4
	public void SetAdventureTargetInfoByChapter(int chapter, bool rebuildList = true)
	{
		this.NowShowingChapter = chapter;
		this.SetChapterInfo(chapter);
		if (rebuildList)
		{
			AdventureTaskRecord[] taskList = AdventureGuideModel.Instance.SortChapterTasks(chapter);
			this.BuildTaskList(taskList);
		}
		this.UpdateBtnStatus(chapter);
		this.SetAdventureProgress(chapter);
	}

	// Token: 0x060078CC RID: 30924 RVA: 0x00256734 File Offset: 0x00254934
	public void SetChapterInfo(int chapter)
	{
		AdventureTaskChapter? chapterAdventureConfig = AdventureGuideConfig.Instance.GetChapterAdventureConfig(chapter);
		Dictionary<int, int> dropShowInfo = AdventureGuideConfig.Instance.GetDropShowInfo(chapterAdventureConfig.Value.DropIds);
		List<TItem> list = new List<TItem>();
		int[] rewardChaptersList = AdventureGuideModel.Instance.GetRewardChaptersList();
		int[] unLockChaptersList = AdventureGuideModel.Instance.GetUnLockChaptersList();
		UUIItem item = base.GetItem(11);
		UUIItem rootComponent = base.GetScrollViewWithScrollbar(12).GetRootComponent();
		UUIItem item2 = base.GetItem(13);
		UUIText text = base.GetText(10);
		foreach (KeyValuePair<int, int> keyValuePair in dropShowInfo)
		{
			int key = keyValuePair.Key;
			InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(key, 0);
			TItem item3 = new TItem(itemData, dropShowInfo[key]);
			list.Add(item3);
		}
		this.RewardLayout.RefreshByData(list, new Action(this.RefreshRewardItemReceive), false);
		int chapterReceivedCount = AdventureGuideModel.Instance.GetChapterReceivedCount(chapter);
		int rewardUnlockCount = chapterAdventureConfig.Value.RewardUnlockCount;
		UUIButtonComponent rewardBtn = this.RewardBtn;
		if (rewardBtn != null)
		{
			rewardBtn.RootUIComp.Get().SetUIActive(Array.IndexOf<int>(unLockChaptersList, chapter) >= 0);
		}
		this.RewardBtn.SetSelfInteractive(chapterReceivedCount >= rewardUnlockCount && Array.IndexOf<int>(rewardChaptersList, chapter) < 0);
		if (Array.IndexOf<int>(unLockChaptersList, chapter) >= 0)
		{
			if (Array.IndexOf<int>(rewardChaptersList, chapter) >= 0)
			{
				LguiUtil.Instance.SetLocalText(text, "ChapterRewardGet", Array.Empty<object>());
			}
			else if (chapterReceivedCount >= rewardUnlockCount)
			{
				LguiUtil.Instance.SetLocalText(text, "GetReward", Array.Empty<object>());
			}
			else
			{
				LguiUtil.Instance.SetLocalText(text, "Doing", Array.Empty<object>());
			}
			item.SetUIActive(true);
			rootComponent.SetUIActive(true);
			item2.SetUIActive(false);
			return;
		}
		rootComponent.SetUIActive(false);
		item2.SetUIActive(true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(16), "Adventure_Taget_UnlockTips", new <>z__ReadOnlyArray<object>(new object[]
		{
			chapter - 1,
			(chapterAdventureConfig != null) ? new int?(chapterAdventureConfig.GetValueOrDefault().LevelUnlockCount) : null
		}));
	}

	// Token: 0x060078CD RID: 30925 RVA: 0x00256988 File Offset: 0x00254B88
	private void BuildTaskList(AdventureTaskRecord[] taskList)
	{
		GenericScrollViewNew<AdventureTargetItem, AdventureTaskRecord> targetItemLayout = this.TargetItemLayout;
		if (targetItemLayout == null)
		{
			return;
		}
		targetItemLayout.RefreshByData(taskList, null, true);
	}

	// Token: 0x060078CE RID: 30926 RVA: 0x002569A0 File Offset: 0x00254BA0
	private void SetAdventureProgress(int chapter)
	{
		AdventureTaskChapter? chapterAdventureConfig = AdventureGuideConfig.Instance.GetChapterAdventureConfig(chapter);
		if (chapterAdventureConfig == null)
		{
			return;
		}
		bool flag = chapter >= AdventureGuideConfig.Instance.GetMaxChapter();
		int chapterReceivedCount = AdventureGuideModel.Instance.GetChapterReceivedCount(chapter);
		int rewardUnlockCount = chapterAdventureConfig.Value.RewardUnlockCount;
		if (flag)
		{
			base.GetText(6).SetText(chapterReceivedCount.ToString(), true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(21), "Wandering_Log_Prograss", new <>z__ReadOnlySingleElementList<object>(chapterAdventureConfig.Value.LevelUnlockCount));
			this.TargetFront = Math.Min(1f, (float)chapterReceivedCount / (float)rewardUnlockCount);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(19), "Adventure_Taget_LastLevel", Array.Empty<object>());
		}
		else
		{
			int levelUnlockCount = AdventureGuideConfig.Instance.GetChapterAdventureConfig(chapter + 1).Value.LevelUnlockCount;
			base.GetText(6).SetText(chapterReceivedCount.ToString(), true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(21), "Wandering_Log_Prograss", new <>z__ReadOnlySingleElementList<object>(levelUnlockCount));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(19), (chapterReceivedCount < levelUnlockCount) ? "Adventure_Taget_NextLevelLock" : "Adventure_Taget_NextLevelUnlock", new <>z__ReadOnlySingleElementList<object>(chapter + 1));
			this.TargetFront = Math.Min(1f, (float)chapterReceivedCount / (float)levelUnlockCount);
		}
		bool uiactive = Array.IndexOf<int>(AdventureGuideModel.Instance.GetUnLockChaptersList(), chapter) >= 0;
		base.GetText(19).SetUIActive(uiactive);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "Adventure_Taget_State_Number", new <>z__ReadOnlySingleElementList<object>(chapter));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(20), "Adventure_Taget_RewardUnlock", new <>z__ReadOnlyArray<object>(new object[]
		{
			Math.Min(chapterReceivedCount, rewardUnlockCount),
			rewardUnlockCount
		}));
		base.GetItem(9).SetUIActive(chapterReceivedCount >= rewardUnlockCount && Array.IndexOf<int>(AdventureGuideModel.Instance.GetRewardChaptersList(), chapter) < 0);
	}

	// Token: 0x060078CF RID: 30927 RVA: 0x00256BB4 File Offset: 0x00254DB4
	private void RefreshRewardItemReceive()
	{
		if (AdventureGuideConfig.Instance.GetChapterAdventureConfig(this.NowShowingChapter) == null)
		{
			return;
		}
		int[] rewardChaptersList = AdventureGuideModel.Instance.GetRewardChaptersList();
		GenericLayout<AdventureTargetRewardItem, TItem> rewardLayout = this.RewardLayout;
		foreach (AdventureTargetRewardItem adventureTargetRewardItem in (((rewardLayout != null) ? rewardLayout.GetLayoutItemList() : null) ?? new List<AdventureTargetRewardItem>()))
		{
			adventureTargetRewardItem.SetReceivedFlagVisible(new bool?(Array.IndexOf<int>(rewardChaptersList, this.NowShowingChapter) >= 0));
		}
	}

	// Token: 0x060078D0 RID: 30928 RVA: 0x00256C58 File Offset: 0x00254E58
	private void OnPreBtnClick()
	{
		if (this.NowShowingChapter > 1)
		{
			UUISprite frontBarSprite = this.FrontBarSprite;
			if (frontBarSprite != null)
			{
				frontBarSprite.SetFillAmount(0f);
			}
			int num = this.NowShowingChapter - 1;
			this.SetAdventureTargetInfoByChapter(num, Array.IndexOf<int>(AdventureGuideModel.Instance.GetUnLockChaptersList(), num) >= 0);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, true);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
	}

	// Token: 0x060078D1 RID: 30929 RVA: 0x00256CE0 File Offset: 0x00254EE0
	private void OnNextBtnClick()
	{
		if (this.NowShowingChapter < AdventureGuideConfig.Instance.GetMaxChapter())
		{
			UUISprite frontBarSprite = this.FrontBarSprite;
			if (frontBarSprite != null)
			{
				frontBarSprite.SetFillAmount(0f);
			}
			int num = this.NowShowingChapter + 1;
			this.SetAdventureTargetInfoByChapter(num, Array.IndexOf<int>(AdventureGuideModel.Instance.GetUnLockChaptersList(), num) >= 0);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, true);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
	}

	// Token: 0x060078D2 RID: 30930 RVA: 0x00256D70 File Offset: 0x00254F70
	private void OnRewardBtnClick()
	{
		AdventureTaskChapter? chapterAdventureConfig = AdventureGuideConfig.Instance.GetChapterAdventureConfig(this.NowShowingChapter);
		if (chapterAdventureConfig == null)
		{
			return;
		}
		int chapterReceivedCount = AdventureGuideModel.Instance.GetChapterReceivedCount(this.NowShowingChapter);
		int rewardUnlockCount = chapterAdventureConfig.Value.RewardUnlockCount;
		if (chapterReceivedCount >= rewardUnlockCount)
		{
			AdventureGuideController.Instance.RequestForChapterReward(this.NowShowingChapter);
			this.RewardBtn.SetSelfInteractive(false);
			return;
		}
		string textById = TextConfig.Instance.GetTextById("NotFinishedTip");
		ScrollingTipsController.Instance.ShowTipsByText(textById);
	}

	// Token: 0x060078D3 RID: 30931 RVA: 0x00256DF3 File Offset: 0x00254FF3
	private void OnChapterRewardReceived(int id)
	{
		if (this.NowShowingChapter == id)
		{
			this.SetAdventureTargetInfoByChapter(id, false);
			base.GetItem(9).SetUIActive(false);
			this.OnNextBtnClick();
			this.RefreshRewardItemReceive();
		}
	}

	// Token: 0x060078D4 RID: 30932 RVA: 0x00256E20 File Offset: 0x00255020
	private void OnTaskStateChange(IReadOnlyList<int> ids)
	{
		bool flag = false;
		foreach (int id in ids)
		{
			if (AdventureGuideModel.Instance.IsTaskOfChapter(id, this.NowShowingChapter))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return;
		}
		AdventureTaskRecord[] data = AdventureGuideModel.Instance.GetChapterTasks(this.NowShowingChapter);
		this.SetAdventureTargetInfoByChapter(this.NowShowingChapter, false);
		data = AdventureGuideModel.Instance.SortChapterTasks(this.NowShowingChapter);
		GenericScrollViewNew<AdventureTargetItem, AdventureTaskRecord> targetItemLayout = this.TargetItemLayout;
		if (targetItemLayout == null)
		{
			return;
		}
		targetItemLayout.RefreshByData(data, null, false);
	}

	// Token: 0x060078D5 RID: 30933 RVA: 0x00256EC0 File Offset: 0x002550C0
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		int displayIndex = int.Parse(configParams[0]);
		UUIItem gridByDisplayIndex = this.RewardLayout.GetGridByDisplayIndex(displayIndex);
		if (gridByDisplayIndex != null)
		{
			return new UUIItem[]
			{
				gridByDisplayIndex,
				gridByDisplayIndex
			};
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Guide;
		ELogAuthor author = ELogAuthor.JT;
		string message = "聚焦引导extraParam项配置有误";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x060078D6 RID: 30934 RVA: 0x00256F1D File Offset: 0x0025511D
	private void OnCloseRewardView()
	{
		this.StopFront = false;
	}

	// Token: 0x04004B3C RID: 19260
	private const string REWARD_RECEIVED = "ChapterRewardGet";

	// Token: 0x04004B3D RID: 19261
	private const string NOT_FINISH_TIP = "NotFinishedTip";

	// Token: 0x04004B3E RID: 19262
	private const string GET_REWARD = "GetReward";

	// Token: 0x04004B3F RID: 19263
	private const float FRONT_ADD_FRAME = 0.01f;

	// Token: 0x04004B40 RID: 19264
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<AdventureTargetRewardItem, TItem> RewardLayout;

	// Token: 0x04004B41 RID: 19265
	private int NowShowingChapter;

	// Token: 0x04004B42 RID: 19266
	[Nullable(2)]
	private UUIButtonComponent RewardBtn;

	// Token: 0x04004B43 RID: 19267
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<AdventureTargetItem, AdventureTaskRecord> TargetItemLayout;

	// Token: 0x04004B44 RID: 19268
	[Nullable(2)]
	private UUISprite FrontBarSprite;

	// Token: 0x04004B45 RID: 19269
	private float TargetFront;

	// Token: 0x04004B46 RID: 19270
	private bool StopFront;

	// Token: 0x04004B47 RID: 19271
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004B48 RID: 19272
	private bool Clicking;

	// Token: 0x02006DF2 RID: 28146
	[NullableContext(0)]
	private enum ENodeDefine
	{
		// Token: 0x04024044 RID: 147524
		RewardBtn,
		// Token: 0x04024045 RID: 147525
		ProgressText,
		// Token: 0x04024046 RID: 147526
		TargetItem,
		// Token: 0x04024047 RID: 147527
		PreBtn,
		// Token: 0x04024048 RID: 147528
		NextBtn,
		// Token: 0x04024049 RID: 147529
		RewardItem,
		// Token: 0x0402404A RID: 147530
		ChapterText,
		// Token: 0x0402404B RID: 147531
		RewardLayout,
		// Token: 0x0402404C RID: 147532
		FrontBar,
		// Token: 0x0402404D RID: 147533
		RedDotItem,
		// Token: 0x0402404E RID: 147534
		ConfirmText,
		// Token: 0x0402404F RID: 147535
		PanelExpItem,
		// Token: 0x04024050 RID: 147536
		TaskScroll,
		// Token: 0x04024051 RID: 147537
		NextChapterTip,
		// Token: 0x04024052 RID: 147538
		AdventureTaskItem,
		// Token: 0x04024053 RID: 147539
		StateText,
		// Token: 0x04024054 RID: 147540
		EmptyText,
		// Token: 0x04024055 RID: 147541
		LeftRedDotItem,
		// Token: 0x04024056 RID: 147542
		RightRedDotItem,
		// Token: 0x04024057 RID: 147543
		NextLevelProgressText,
		// Token: 0x04024058 RID: 147544
		CurrentRewardText,
		// Token: 0x04024059 RID: 147545
		ChapterTargetText
	}
}
