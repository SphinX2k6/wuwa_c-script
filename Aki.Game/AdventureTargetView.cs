using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001693 RID: 5779
[NullableContext(1)]
[Nullable(0)]
public class AdventureTargetView : UiTabViewBase
{
	// Token: 0x0600A4DE RID: 42206 RVA: 0x0024BBB0 File Offset: 0x00249DB0
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

	// Token: 0x0600A4DF RID: 42207 RVA: 0x0024BEFC File Offset: 0x0024A0FC
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.AdventureTaskStateChange, new Action<IReadOnlyList<int>>(this.OnTaskStateChange));
		EventSystem.Instance.Add(EEventName.ChapterRewardReceived, new Action<int>(this.OnChapterRewardReceived));
		EventSystem.Instance.Add(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
	}

	// Token: 0x0600A4E0 RID: 42208 RVA: 0x0024BF60 File Offset: 0x0024A160
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.AdventureTaskStateChange, new Action<IReadOnlyList<int>>(this.OnTaskStateChange));
		EventSystem.Instance.Remove(EEventName.ChapterRewardReceived, new Action<int>(this.OnChapterRewardReceived));
		EventSystem.Instance.Remove(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
	}

	// Token: 0x0600A4E1 RID: 42209 RVA: 0x0024BFC4 File Offset: 0x0024A1C4
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

	// Token: 0x0600A4E2 RID: 42210 RVA: 0x0024C010 File Offset: 0x0024A210
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

	// Token: 0x0600A4E3 RID: 42211 RVA: 0x0024C0C0 File Offset: 0x0024A2C0
	private AdventureTargetRewardItem OnRewardLayoutUpdater()
	{
		AdventureTargetRewardItem adventureTargetRewardItem = new AdventureTargetRewardItem();
		adventureTargetRewardItem.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnRewardItemClick));
		adventureTargetRewardItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanRewardItemChangeToggle));
		return adventureTargetRewardItem;
	}

	// Token: 0x0600A4E4 RID: 42212 RVA: 0x0024C0EB File Offset: 0x0024A2EB
	private void OnRewardItemClick(MediumItemGridExtendCallback callbackParameter)
	{
		ItemController.Instance.OpenItemTipsByItemId(((TItem)callbackParameter.Data).ItemData.ItemId, true, null);
	}

	// Token: 0x0600A4E5 RID: 42213 RVA: 0x0024C10E File Offset: 0x0024A30E
	private bool CanRewardItemChangeToggle(object _, bool result, EToggleState state)
	{
		return false;
	}

	// Token: 0x0600A4E6 RID: 42214 RVA: 0x0024C111 File Offset: 0x0024A311
	private AdventureTargetItem OnTaskLayoutUpdater()
	{
		AdventureTargetItem adventureTargetItem = new AdventureTargetItem();
		adventureTargetItem.SetClickGetButtonCb(new Action<int>(this.OnTaskItemGetClick));
		return adventureTargetItem;
	}

	// Token: 0x0600A4E7 RID: 42215 RVA: 0x0024C12C File Offset: 0x0024A32C
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

	// Token: 0x0600A4E8 RID: 42216 RVA: 0x0024C1B6 File Offset: 0x0024A3B6
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

	// Token: 0x0600A4E9 RID: 42217 RVA: 0x0024C1E0 File Offset: 0x0024A3E0
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

	// Token: 0x0600A4EA RID: 42218 RVA: 0x0024C238 File Offset: 0x0024A438
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
				if (!rewardChaptersList.Contains(i) && chapterReceivedCount >= rewardUnlockCount && num <= i)
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

	// Token: 0x0600A4EB RID: 42219 RVA: 0x0024C388 File Offset: 0x0024A588
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

	// Token: 0x0600A4EC RID: 42220 RVA: 0x0024C3C8 File Offset: 0x0024A5C8
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
			rewardBtn.RootUIComp.Get().SetUIActive(unLockChaptersList.Contains(chapter));
		}
		this.RewardBtn.SetSelfInteractive(chapterReceivedCount >= rewardUnlockCount && !rewardChaptersList.Contains(chapter));
		if (unLockChaptersList.Contains(chapter))
		{
			if (rewardChaptersList.Contains(chapter))
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

	// Token: 0x0600A4ED RID: 42221 RVA: 0x0024C614 File Offset: 0x0024A814
	private void BuildTaskList(AdventureTaskRecord[] taskList)
	{
		GenericScrollViewNew<AdventureTargetItem, AdventureTaskRecord> targetItemLayout = this.TargetItemLayout;
		if (targetItemLayout == null)
		{
			return;
		}
		targetItemLayout.RefreshByData(taskList.ToList<AdventureTaskRecord>(), null, true);
	}

	// Token: 0x0600A4EE RID: 42222 RVA: 0x0024C630 File Offset: 0x0024A830
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
		bool uiactive = AdventureGuideModel.Instance.GetUnLockChaptersList().Contains(chapter);
		base.GetText(19).SetUIActive(uiactive);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "Adventure_Taget_State_Number", new <>z__ReadOnlySingleElementList<object>(chapter));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(20), "Adventure_Taget_RewardUnlock", new <>z__ReadOnlyArray<object>(new object[]
		{
			Math.Min(chapterReceivedCount, rewardUnlockCount),
			rewardUnlockCount
		}));
		base.GetItem(9).SetUIActive(chapterReceivedCount >= rewardUnlockCount && !AdventureGuideModel.Instance.GetRewardChaptersList().Contains(chapter));
	}

	// Token: 0x0600A4EF RID: 42223 RVA: 0x0024C840 File Offset: 0x0024AA40
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
			adventureTargetRewardItem.SetReceivedFlagVisible(new bool?(rewardChaptersList.Contains(this.NowShowingChapter)));
		}
	}

	// Token: 0x0600A4F0 RID: 42224 RVA: 0x0024C8DC File Offset: 0x0024AADC
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
			this.SetAdventureTargetInfoByChapter(num, AdventureGuideModel.Instance.GetUnLockChaptersList().Contains(num));
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

	// Token: 0x0600A4F1 RID: 42225 RVA: 0x0024C95C File Offset: 0x0024AB5C
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
			this.SetAdventureTargetInfoByChapter(num, AdventureGuideModel.Instance.GetUnLockChaptersList().Contains(num));
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

	// Token: 0x0600A4F2 RID: 42226 RVA: 0x0024C9E4 File Offset: 0x0024ABE4
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

	// Token: 0x0600A4F3 RID: 42227 RVA: 0x0024CA67 File Offset: 0x0024AC67
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

	// Token: 0x0600A4F4 RID: 42228 RVA: 0x0024CA94 File Offset: 0x0024AC94
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
		AdventureTaskRecord[] source = AdventureGuideModel.Instance.GetChapterTasks(this.NowShowingChapter);
		this.SetAdventureTargetInfoByChapter(this.NowShowingChapter, false);
		source = AdventureGuideModel.Instance.SortChapterTasks(this.NowShowingChapter);
		GenericScrollViewNew<AdventureTargetItem, AdventureTaskRecord> targetItemLayout = this.TargetItemLayout;
		if (targetItemLayout == null)
		{
			return;
		}
		targetItemLayout.RefreshByData(source.ToList<AdventureTaskRecord>(), null, false);
	}

	// Token: 0x0600A4F5 RID: 42229 RVA: 0x0024CB3C File Offset: 0x0024AD3C
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

	// Token: 0x0600A4F6 RID: 42230 RVA: 0x0024CB99 File Offset: 0x0024AD99
	private void OnCloseRewardView()
	{
		this.StopFront = false;
	}

	// Token: 0x04004A95 RID: 19093
	private const string REWARD_RECEIVED = "ChapterRewardGet";

	// Token: 0x04004A96 RID: 19094
	private const string NOT_FINISH_TIP = "NotFinishedTip";

	// Token: 0x04004A97 RID: 19095
	private const string GET_REWARD = "GetReward";

	// Token: 0x04004A98 RID: 19096
	private const float FRONT_ADD_FRAME = 0.01f;

	// Token: 0x04004A99 RID: 19097
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<AdventureTargetRewardItem, TItem> RewardLayout;

	// Token: 0x04004A9A RID: 19098
	private int NowShowingChapter;

	// Token: 0x04004A9B RID: 19099
	[Nullable(2)]
	private UUIButtonComponent RewardBtn;

	// Token: 0x04004A9C RID: 19100
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<AdventureTargetItem, AdventureTaskRecord> TargetItemLayout;

	// Token: 0x04004A9D RID: 19101
	[Nullable(2)]
	private UUISprite FrontBarSprite;

	// Token: 0x04004A9E RID: 19102
	private float TargetFront;

	// Token: 0x04004A9F RID: 19103
	private bool StopFront;

	// Token: 0x04004AA0 RID: 19104
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004AA1 RID: 19105
	private bool Clicking;

	// Token: 0x02007C6D RID: 31853
	[NullableContext(0)]
	private enum ENodeDefine
	{
		// Token: 0x04028D1B RID: 167195
		RewardBtn,
		// Token: 0x04028D1C RID: 167196
		ProgressText,
		// Token: 0x04028D1D RID: 167197
		TargetItem,
		// Token: 0x04028D1E RID: 167198
		PreBtn,
		// Token: 0x04028D1F RID: 167199
		NextBtn,
		// Token: 0x04028D20 RID: 167200
		RewardItem,
		// Token: 0x04028D21 RID: 167201
		ChapterText,
		// Token: 0x04028D22 RID: 167202
		RewardLayout,
		// Token: 0x04028D23 RID: 167203
		FrontBar,
		// Token: 0x04028D24 RID: 167204
		RedDotItem,
		// Token: 0x04028D25 RID: 167205
		ConfirmText,
		// Token: 0x04028D26 RID: 167206
		PanelExpItem,
		// Token: 0x04028D27 RID: 167207
		TaskScroll,
		// Token: 0x04028D28 RID: 167208
		NextChapterTip,
		// Token: 0x04028D29 RID: 167209
		AdventureTaskItem,
		// Token: 0x04028D2A RID: 167210
		StateText,
		// Token: 0x04028D2B RID: 167211
		EmptyText,
		// Token: 0x04028D2C RID: 167212
		LeftRedDotItem,
		// Token: 0x04028D2D RID: 167213
		RightRedDotItem,
		// Token: 0x04028D2E RID: 167214
		NextLevelProgressText,
		// Token: 0x04028D2F RID: 167215
		CurrentRewardText,
		// Token: 0x04028D30 RID: 167216
		ChapterTargetText
	}
}
