using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.Common.InputView;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001697 RID: 5783
[NullableContext(2)]
[Nullable(0)]
public class MonsterDetectView : UiTabViewBase
{
	// Token: 0x0600A521 RID: 42273 RVA: 0x0024D83B File Offset: 0x0024BA3B
	public int GetCurrentId()
	{
		return this.CurShowingDetectingTarget;
	}

	// Token: 0x0600A522 RID: 42274 RVA: 0x0024D843 File Offset: 0x0024BA43
	public UUIExtendToggle GetCurrentToggle()
	{
		return this.CurrentSelectedToggle;
	}

	// Token: 0x0600A523 RID: 42275 RVA: 0x0024D84C File Offset: 0x0024BA4C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 20;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnDetectClickFunction));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnLeftTimeBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A524 RID: 42276 RVA: 0x0024DB74 File Offset: 0x0024BD74
	protected override void OnStart()
	{
		this.DetectLoopScroll = new LoopScrollView<MonsterDetectItem, MonsterDetectionRecord>(base.GetLoopScrollViewComponent(7), base.GetItem(2).GetOwner() as AUIBaseActor, delegate()
		{
			MonsterDetectItem monsterDetectItem = new MonsterDetectItem();
			monsterDetectItem.BindCallback(new Action<int, UUIExtendToggle>(this.RefreshByDetectingId));
			return monsterDetectItem;
		}, false);
		this.DetectLoopScroll.SetAnimFinishDelegate(new Action(this.OnAnimFinishDelegate));
		this.MonsterHeadItem = new CommonItemSmallItemGrid();
		this.MonsterHeadItem.Initialize(base.GetItem(14).GetOwner());
		this.DetectItemList = new List<MonsterDetectionRecord>();
		this.RewardLayout = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(8), new Func<CommonItemSmallItemGrid>(this.OnRewardLayoutUpdater), null, false, null);
		this.FilterBtn = new FilterSortEntrance<MonsterDetectionRecord>(base.GetItem(0), new TUpdateDataListFunction<MonsterDetectionRecord>(this.OnFilterUpdate));
		this.DetectText = base.GetText(10);
		this.DetectText.OnSelfLanguageChange.Bind(new Action(this.OnRefreshTimeLangChange));
		this.DetectBtn = base.GetButton(1);
		this.CurShowingDetectingTarget = AdventureGuideModel.Instance.GetCurDetectingMonsterConfId();
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		int leftIntensifyCaptureGuarantee = CalabashModel.Instance.GetLeftIntensifyCaptureGuarantee();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "UpAbsorptionTimeWithTagText", new <>z__ReadOnlySingleElementList<object>(leftIntensifyCaptureGuarantee));
		this.InitNavigationParam();
		this.SearchComponent = new CommonSearchComponent(base.GetItem(17), new Action<string>(this.SearchResult), new Action(this.ResetSearch));
	}

	// Token: 0x0600A525 RID: 42277 RVA: 0x0024DCEC File Offset: 0x0024BEEC
	private void InitNavigationParam()
	{
		AdventureGuideViewOpenData adventureGuideViewOpenData = this.ExtraParams as AdventureGuideViewOpenData;
		int? num = (((adventureGuideViewOpenData != null) ? adventureGuideViewOpenData.OpenTabViewName : null) == EUiTabViewName.MonsterDetectView) ? adventureGuideViewOpenData.OpenParam : null;
		if (num != null)
		{
			int? num2 = num;
			int num3 = 0;
			if (num2.GetValueOrDefault() > num3 & num2 != null)
			{
				this.IsNavigationJumpToGrid = true;
			}
		}
	}

	// Token: 0x0600A526 RID: 42278 RVA: 0x0024DD7C File Offset: 0x0024BF7C
	private void NavigationJumpToGrid()
	{
		if (!this.IsNavigationJumpToGrid)
		{
			return;
		}
		this.IsNavigationJumpToGrid = false;
		MonsterDetectItem monsterDetectItem = this.DetectLoopScroll.UnsafeGetGridProxy(this.JumpIndex, false);
		if (monsterDetectItem == null)
		{
			return;
		}
		UiNavigationNewController.Instance.SetNavigationFocusForView(monsterDetectItem.GetToggleItem(), false, false, false);
	}

	// Token: 0x0600A527 RID: 42279 RVA: 0x0024DDC4 File Offset: 0x0024BFC4
	protected override void OnBeforeShow()
	{
		AdventureGuideViewOpenData adventureGuideViewOpenData = this.ExtraParams as AdventureGuideViewOpenData;
		int? num = (((adventureGuideViewOpenData != null) ? adventureGuideViewOpenData.OpenTabViewName : null) == EUiTabViewName.MonsterDetectView) ? adventureGuideViewOpenData.OpenParam : null;
		int? num2 = null;
		if (num != null)
		{
			int? num3 = num;
			int num4 = 0;
			if (num3.GetValueOrDefault() > num4 & num3 != null)
			{
				num2 = num;
			}
			else
			{
				this.PreSelectedDangerType = -num;
			}
		}
		this.PreSelectedMonster = num2;
		AdventureGuideModel.Instance.CurrentMonsterId = num2;
		List<MonsterDetectionRecord> dataList = AdventureGuideModel.Instance.GetAllDetectMonsters().Values.ToList<MonsterDetectionRecord>();
		this.FilterBtn.UpdateData(EFilterSortGroupId.MonsterDetection, dataList, Array.Empty<object>());
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
		EventSystem.Instance.Emit<int>(EEventName.AdventureHelpBtn, 17);
	}

	// Token: 0x0600A528 RID: 42280 RVA: 0x0024DF06 File Offset: 0x0024C106
	[NullableContext(1)]
	private CommonItemSmallItemGrid OnRewardLayoutUpdater()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600A529 RID: 42281 RVA: 0x0024DF0D File Offset: 0x0024C10D
	private void OnRefreshTimeLangChange()
	{
		this.UpdateRefreshTime();
	}

	// Token: 0x0600A52A RID: 42282 RVA: 0x0024DF18 File Offset: 0x0024C118
	protected override void OnBeforeDestroy()
	{
		this.RewardLayout = null;
		if (this.DetectLoopScroll != null)
		{
			this.DetectLoopScroll.ClearGridProxies();
			this.DetectLoopScroll = null;
		}
		this.DetectText.OnSelfLanguageChange.Unbind();
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600A52B RID: 42283 RVA: 0x0024DF70 File Offset: 0x0024C170
	[NullableContext(1)]
	private void BuildDetectList(List<MonsterDetectionRecord> list)
	{
		this.DetectItemList.Clear();
		foreach (MonsterDetectionRecord monsterDetectionRecord in list)
		{
			this.DetectItemList.Add(monsterDetectionRecord);
			if (this.PreSelectedMonster.GetValueOrDefault() != -1)
			{
				int? preSelectedMonster = this.PreSelectedMonster;
				int id = monsterDetectionRecord.Conf.Id;
				if (preSelectedMonster.GetValueOrDefault() == id & preSelectedMonster != null)
				{
					this.PreSelectedMonster = new int?(-1);
				}
			}
		}
		if (AdventureGuideModel.Instance.CurrentMonsterId == null)
		{
			int firstMonsterIdByDangerType = this.GetFirstMonsterIdByDangerType();
			AdventureGuideModel.Instance.CurrentMonsterId = new int?(firstMonsterIdByDangerType);
		}
		Action callBack = delegate()
		{
			this.JumpToTarget(AdventureGuideModel.Instance.CurrentMonsterId.Value);
		};
		this.DetectLoopScroll.RefreshByData(this.DetectItemList, false, callBack, true);
	}

	// Token: 0x0600A52C RID: 42284 RVA: 0x0024E060 File Offset: 0x0024C260
	[NullableContext(1)]
	public void RefreshByDetectingId(int id, UUIExtendToggle toggle)
	{
		if (this.CurrentSelectedToggle != null && this.CurrentSelectedToggle != toggle)
		{
			this.CurrentSelectedToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, true);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 != null)
		{
			levelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
		}
		AdventureGuideModel.Instance.CurrentMonsterId = new int?(id);
		this.CurrentSelectedToggle = toggle;
		this.CurShowingDetectingTarget = id;
		MonsterDetectionRecord monsterDetectData = AdventureGuideModel.Instance.GetMonsterDetectData(id);
		string name = MonsterInfoConfig.Instance.GetMonsterInfoConfig(monsterDetectData.Conf.MonsterInfoId).Value.Name;
		TItem titem = new TItem(new InventoryDefine.GetItemData(monsterDetectData.Conf.MonsterInfoId, 0), 1);
		PhantomSmallItemGrid parameters = new PhantomSmallItemGrid
		{
			Data = titem,
			BottomText = "",
			IsNotFoundVisible = new bool?(monsterDetectData.IsLock),
			IsSelectedFlag = new bool?(false),
			MonsterId = new int?(monsterDetectData.Conf.MonsterInfoId),
			IsQualityHidden = new bool?(true),
			IconHidden = new bool?(monsterDetectData.IsLock)
		};
		CommonItemSmallItemGrid monsterHeadItem = this.MonsterHeadItem;
		if (monsterHeadItem != null)
		{
			monsterHeadItem.Apply<PhantomSmallItemGrid>(parameters);
		}
		CommonItemSmallItemGrid monsterHeadItem2 = this.MonsterHeadItem;
		if (monsterHeadItem2 != null)
		{
			monsterHeadItem2.SetToggleInteractive(false);
		}
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(ConfigTextById.GetConfig("Detect", true).Value.TextContent, null);
		this.DetectText.SetText(localTextNew, true);
		if (monsterDetectData.IsLock)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(4), "Unknown", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), monsterDetectData.Conf.AttributesDescriptionLock, Array.Empty<object>());
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), monsterDetectData.Conf.AttributesDescriptionUnlock, Array.Empty<object>());
			this.UpdateRefreshTime();
		}
		SecondaryGuideData? secondaryGuideDataConf = AdventureGuideConfig.Instance.GetSecondaryGuideDataConf(monsterDetectData.Conf.DangerType);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), AdventureGuideConfig.Instance.GetSecondaryGuideDataTextById(monsterDetectData.Conf.DangerType), Array.Empty<object>());
		this.SetSpriteByPath(secondaryGuideDataConf.Value.Icon, base.GetSprite(6), false, null, null);
		if (monsterDetectData.Conf.ShowReward == 0)
		{
			base.GetItem(9).SetUIActive(false);
		}
		else
		{
			base.GetItem(9).SetUIActive(true);
			this.BuildRewardList(monsterDetectData.Conf.ShowReward, false);
		}
		IEnumerable<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("CanUpAbsorbDangerTypeList");
		IReadOnlyList<int> intArrayConfig2 = ConfigCommonParamById.GetIntArrayConfig("CanUpAbsorbTypeDescription2List");
		IReadOnlyList<int> intArrayConfig3 = ConfigCommonParamById.GetIntArrayConfig("CanUpAbsorbLowDangerTypeList");
		object obj = intArrayConfig.Contains(monsterDetectData.Conf.DangerType) && intArrayConfig2.Contains(monsterDetectData.Conf.TypeDescription2);
		bool flag = intArrayConfig3.Contains(monsterDetectData.Conf.DangerType) && intArrayConfig2.Contains(monsterDetectData.Conf.TypeDescription2);
		UUIText text = base.GetText(15);
		object obj2 = obj;
		if (obj2 != null)
		{
			int leftIntensifyCaptureGuarantee = CalabashModel.Instance.GetLeftIntensifyCaptureGuarantee();
			LguiUtil.Instance.SetLocalTextNew(text, "UpAbsorptionTimeWithTagText", new <>z__ReadOnlySingleElementList<object>(leftIntensifyCaptureGuarantee));
			if (text != null)
			{
				text.SetUIActive(true);
			}
		}
		else if (flag)
		{
			int leftLowCostIntensifyCaptureGuarantee = CalabashModel.Instance.GetLeftLowCostIntensifyCaptureGuarantee();
			LguiUtil.Instance.SetLocalTextNew(text, "UpAbsorptionTimeWithTagText", new <>z__ReadOnlySingleElementList<object>(leftLowCostIntensifyCaptureGuarantee));
			if (text != null)
			{
				text.SetUIActive(true);
			}
		}
		else if (text != null)
		{
			text.SetUIActive(false);
		}
		bool uiactive = (obj2 | flag) != null;
		UUIButtonComponent button = base.GetButton(16);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x0600A52D RID: 42285 RVA: 0x0024E47C File Offset: 0x0024C67C
	private int GetFirstMonsterIdByDangerType()
	{
		int? preSelectedDangerType = this.PreSelectedDangerType;
		this.PreSelectedDangerType = null;
		if (this.DetectItemList.Count <= 0)
		{
			return -1;
		}
		int id = this.DetectItemList[0].Conf.Id;
		if (preSelectedDangerType == null)
		{
			return id;
		}
		foreach (MonsterDetectionRecord monsterDetectionRecord in this.DetectItemList)
		{
			if (!monsterDetectionRecord.IsLock)
			{
				int dangerType = monsterDetectionRecord.Conf.DangerType;
				int? num = preSelectedDangerType;
				if (dangerType == num.GetValueOrDefault() & num != null)
				{
					return monsterDetectionRecord.Conf.Id;
				}
			}
		}
		return id;
	}

	// Token: 0x0600A52E RID: 42286 RVA: 0x0024E558 File Offset: 0x0024C758
	private void UpdateRefreshTime()
	{
		int currentId = this.GetCurrentId();
		if (currentId == 0)
		{
			return;
		}
		MonsterDetectionRecord monsterDetectData = AdventureGuideModel.Instance.GetMonsterDetectData(currentId);
		if (monsterDetectData == null)
		{
			return;
		}
		base.GetItem(13).SetUIActive(monsterDetectData.IsLock);
		if (monsterDetectData.IsLock)
		{
			return;
		}
		this.DetectBtn.RootUIComp.Get().SetUIActive(true);
		if (!monsterDetectData.IsLock && !this.DetectInteractive)
		{
			this.DetectBtn.SetSelfInteractive(true);
			this.DetectInteractive = true;
		}
	}

	// Token: 0x0600A52F RID: 42287 RVA: 0x0024E5D8 File Offset: 0x0024C7D8
	public void Tick(float delta)
	{
		this.UpdateRefreshTime();
	}

	// Token: 0x0600A530 RID: 42288 RVA: 0x0024E5E0 File Offset: 0x0024C7E0
	private void BuildRewardList(int dropId, bool isReceived)
	{
		Dictionary<int, int> dropShowInfo = AdventureGuideConfig.Instance.GetDropShowInfo(dropId);
		List<TItem> list = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair in dropShowInfo)
		{
			int key = keyValuePair.Key;
			TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), dropShowInfo[key]);
			list.Add(item);
		}
		this.RewardLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0600A531 RID: 42289 RVA: 0x0024E670 File Offset: 0x0024C870
	[NullableContext(1)]
	private void OnFilterUpdate(List<MonsterDetectionRecord> list, bool result, EFilterSortType type)
	{
		List<MonsterDetectionRecord> list2 = new List<MonsterDetectionRecord>();
		foreach (MonsterDetectionRecord item in list)
		{
			list2.Add(item);
		}
		this.BuildDetectList(list2);
		this.FilterResult = list2;
		base.GetItem(18).SetUIActive(list2.Count > 0);
		base.GetItem(19).SetUIActive(list2.Count <= 0);
		this.SearchComponent.ResetSearch(true);
	}

	// Token: 0x0600A532 RID: 42290 RVA: 0x0024E710 File Offset: 0x0024C910
	private void OnDetectClickFunction()
	{
		if (Time.Instance.Now - this.LastClickTime <= (double)(TimeUtil.Instance.InverseMillisecond * 2))
		{
			return;
		}
		this.LastClickTime = Time.Instance.Now;
		if (GameModeController.Instance.IsInInstance())
		{
			GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
			return;
		}
		int currentId = this.GetCurrentId();
		MonsterDetectionRecord monsterDetectData = AdventureGuideModel.Instance.GetMonsterDetectData(currentId);
		if (monsterDetectData != null && monsterDetectData.IsLock && monsterDetectData.Conf.TypeDescription2 == 23)
		{
			SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(monsterDetectData.Conf.NightMareDetectionId);
			if (silentAreaDetectData != null && silentAreaDetectData.IsLock)
			{
				if (!AdventureGuideModel.Instance.CheckTargetDungeonTypeCanShow(EDungeonType.NightMare))
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("ConditionGroup_12005113_HintText", Array.Empty<object>());
					return;
				}
				AdventureGuideViewOpenData adventureGuideViewOpenData = new AdventureGuideViewOpenData();
				adventureGuideViewOpenData.OpenTabViewName = new EUiTabViewName?(EUiTabViewName.NewSoundAreaView);
				adventureGuideViewOpenData.OpenParam = new int?(63);
				AdventureGuideModel.Instance.HandleShowNightMareParam = monsterDetectData.Conf.NightMareDetectionId;
				AdventureGuideController.Instance.OpenGuideViewWithOpenData(adventureGuideViewOpenData, null);
				return;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.AdventureGuide;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "手动探测怪物";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("探测Id", currentId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		AdventureGuideModel.Instance.SetFromManualDetect(true);
		AdventureGuideController.Instance.RequestForDetection(DetectionType.NormalMonster, Array.Empty<int>(), this.CurShowingDetectingTarget);
	}

	// Token: 0x0600A533 RID: 42291 RVA: 0x0024E88C File Offset: 0x0024CA8C
	private void OnLeftTimeBtn()
	{
		HelpController.Instance.OpenHelpById(72);
	}

	// Token: 0x0600A534 RID: 42292 RVA: 0x0024E89A File Offset: 0x0024CA9A
	private void OnAnimFinishDelegate()
	{
		this.NavigationJumpToGrid();
		LoopScrollView<MonsterDetectItem, MonsterDetectionRecord> detectLoopScroll = this.DetectLoopScroll;
		if (detectLoopScroll == null)
		{
			return;
		}
		detectLoopScroll.SetAnimFinishDelegate(null);
	}

	// Token: 0x0600A535 RID: 42293 RVA: 0x0024E8B4 File Offset: 0x0024CAB4
	public void JumpToTarget(int target)
	{
		int num = 0;
		foreach (MonsterDetectionRecord monsterDetectionRecord in this.DetectItemList)
		{
			if (target == monsterDetectionRecord.Conf.Id)
			{
				this.DetectLoopScroll.DeselectCurrentGridProxy(false);
				this.DetectLoopScroll.ScrollToGridIndex(num, true);
				this.DetectLoopScroll.SelectGridProxy(num, false);
				break;
			}
			num++;
		}
		this.JumpIndex = num;
	}

	// Token: 0x0600A536 RID: 42294 RVA: 0x0024E950 File Offset: 0x0024CB50
	[NullableContext(1)]
	private void SearchResult(string content)
	{
		AdventureGuideModel instance = AdventureGuideModel.Instance;
		List<MonsterDetectionRecord> detectItemList = this.DetectItemList;
		MonsterDetectionRecord[] searchList = instance.GetSearchList(((detectItemList != null) ? detectItemList.ToArray() : null) ?? Array.Empty<MonsterDetectionRecord>(), content);
		base.GetItem(18).SetUIActive(searchList.Length != 0);
		base.GetItem(19).SetUIActive(searchList.Length == 0);
		this.DetectLoopScroll.RefreshByData(searchList.ToList<MonsterDetectionRecord>(), false, null, false);
	}

	// Token: 0x0600A537 RID: 42295 RVA: 0x0024E9BC File Offset: 0x0024CBBC
	private void ResetSearch()
	{
		if (this.FilterResult != null)
		{
			base.GetItem(18).SetUIActive(this.FilterResult.Count > 0);
			base.GetItem(19).SetUIActive(this.FilterResult.Count <= 0);
		}
		else
		{
			base.GetItem(18).SetUIActive(false);
			base.GetItem(19).SetUIActive(true);
		}
		this.DetectLoopScroll.RefreshByData(this.FilterResult ?? new List<MonsterDetectionRecord>(), false, null, false);
	}

	// Token: 0x04004AB2 RID: 19122
	private const int MONSTER_HELP = 17;

	// Token: 0x04004AB3 RID: 19123
	private const int LEFT_TIME_HELP = 72;

	// Token: 0x04004AB4 RID: 19124
	private const int NIGHT_MARE_TYPE = 23;

	// Token: 0x04004AB5 RID: 19125
	private const int NIGHT_MARE_TAG = 63;

	// Token: 0x04004AB6 RID: 19126
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MonsterDetectItem, MonsterDetectionRecord> DetectLoopScroll;

	// Token: 0x04004AB7 RID: 19127
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<MonsterDetectionRecord> DetectItemList;

	// Token: 0x04004AB8 RID: 19128
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x04004AB9 RID: 19129
	private int CurShowingDetectingTarget;

	// Token: 0x04004ABA RID: 19130
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<MonsterDetectionRecord> FilterBtn;

	// Token: 0x04004ABB RID: 19131
	private UUIExtendToggle CurrentSelectedToggle;

	// Token: 0x04004ABC RID: 19132
	private UUIText DetectText;

	// Token: 0x04004ABD RID: 19133
	private int? PreSelectedMonster = new int?(-1);

	// Token: 0x04004ABE RID: 19134
	private int? PreSelectedDangerType;

	// Token: 0x04004ABF RID: 19135
	private UUIButtonComponent DetectBtn;

	// Token: 0x04004AC0 RID: 19136
	private bool DetectInteractive = true;

	// Token: 0x04004AC1 RID: 19137
	private double LastClickTime;

	// Token: 0x04004AC2 RID: 19138
	private CommonItemSmallItemGrid MonsterHeadItem;

	// Token: 0x04004AC3 RID: 19139
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004AC4 RID: 19140
	private bool IsNavigationJumpToGrid;

	// Token: 0x04004AC5 RID: 19141
	private int JumpIndex;

	// Token: 0x04004AC6 RID: 19142
	private CommonSearchComponent SearchComponent;

	// Token: 0x04004AC7 RID: 19143
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<MonsterDetectionRecord> FilterResult;

	// Token: 0x02007C74 RID: 31860
	[NullableContext(0)]
	private enum ENodeDefine
	{
		// Token: 0x04028D4D RID: 167245
		FilterBtn,
		// Token: 0x04028D4E RID: 167246
		DetectBtn,
		// Token: 0x04028D4F RID: 167247
		DetectItem,
		// Token: 0x04028D50 RID: 167248
		RewardItem,
		// Token: 0x04028D51 RID: 167249
		NameText,
		// Token: 0x04028D52 RID: 167250
		DescText,
		// Token: 0x04028D53 RID: 167251
		LowDangerItem,
		// Token: 0x04028D54 RID: 167252
		DetectScroll,
		// Token: 0x04028D55 RID: 167253
		RewardLayout,
		// Token: 0x04028D56 RID: 167254
		DropItem,
		// Token: 0x04028D57 RID: 167255
		ConfirmText,
		// Token: 0x04028D58 RID: 167256
		LowLevelText,
		// Token: 0x04028D59 RID: 167257
		TxtUnlock,
		// Token: 0x04028D5A RID: 167258
		UnlockItem,
		// Token: 0x04028D5B RID: 167259
		MonsterItem,
		// Token: 0x04028D5C RID: 167260
		LeftTimeText,
		// Token: 0x04028D5D RID: 167261
		LeftTimeBtn,
		// Token: 0x04028D5E RID: 167262
		UiItemInputBoxItem,
		// Token: 0x04028D5F RID: 167263
		RightItem,
		// Token: 0x04028D60 RID: 167264
		EmptyItem
	}
}
