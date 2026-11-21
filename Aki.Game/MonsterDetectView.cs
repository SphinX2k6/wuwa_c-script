using System;
using System.Collections.Generic;
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

// Token: 0x02000B4F RID: 2895
[NullableContext(2)]
[Nullable(0)]
public class MonsterDetectView : UiTabViewBase
{
	// Token: 0x06007901 RID: 30977 RVA: 0x00257BBF File Offset: 0x00255DBF
	public int GetCurrentId()
	{
		return this.CurShowingDetectingTarget;
	}

	// Token: 0x06007902 RID: 30978 RVA: 0x00257BC7 File Offset: 0x00255DC7
	public UUIExtendToggle GetCurrentToggle()
	{
		return this.CurrentSelectedToggle;
	}

	// Token: 0x06007903 RID: 30979 RVA: 0x00257BD0 File Offset: 0x00255DD0
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

	// Token: 0x06007904 RID: 30980 RVA: 0x00257EF8 File Offset: 0x002560F8
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

	// Token: 0x06007905 RID: 30981 RVA: 0x00258070 File Offset: 0x00256270
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

	// Token: 0x06007906 RID: 30982 RVA: 0x00258100 File Offset: 0x00256300
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

	// Token: 0x06007907 RID: 30983 RVA: 0x00258148 File Offset: 0x00256348
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
		List<MonsterDetectionRecord> dataList = new List<MonsterDetectionRecord>(AdventureGuideModel.Instance.GetAllDetectMonsters().Values);
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

	// Token: 0x06007908 RID: 30984 RVA: 0x0025828A File Offset: 0x0025648A
	[NullableContext(1)]
	private CommonItemSmallItemGrid OnRewardLayoutUpdater()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06007909 RID: 30985 RVA: 0x00258291 File Offset: 0x00256491
	private void OnRefreshTimeLangChange()
	{
		this.UpdateRefreshTime();
	}

	// Token: 0x0600790A RID: 30986 RVA: 0x0025829C File Offset: 0x0025649C
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

	// Token: 0x0600790B RID: 30987 RVA: 0x002582F4 File Offset: 0x002564F4
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

	// Token: 0x0600790C RID: 30988 RVA: 0x002583E4 File Offset: 0x002565E4
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
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("CanUpAbsorbDangerTypeList");
		IEnumerable<int> intArrayConfig2 = ConfigCommonParamById.GetIntArrayConfig("CanUpAbsorbTypeDescription2List");
		IReadOnlyList<int> intArrayConfig3 = ConfigCommonParamById.GetIntArrayConfig("CanUpAbsorbLowDangerTypeList");
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		using (IEnumerator<int> enumerator = intArrayConfig2.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == monsterDetectData.Conf.TypeDescription2)
				{
					flag3 = true;
					break;
				}
			}
		}
		using (IEnumerator<int> enumerator = intArrayConfig.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == monsterDetectData.Conf.DangerType)
				{
					flag = true;
					break;
				}
			}
		}
		using (IEnumerator<int> enumerator = intArrayConfig3.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == monsterDetectData.Conf.DangerType)
				{
					flag2 = true;
					break;
				}
			}
		}
		flag = (flag && flag3);
		flag2 = (flag2 && flag3);
		UUIText text = base.GetText(15);
		if (flag)
		{
			int leftIntensifyCaptureGuarantee = CalabashModel.Instance.GetLeftIntensifyCaptureGuarantee();
			LguiUtil.Instance.SetLocalTextNew(text, "UpAbsorptionTimeWithTagText", new <>z__ReadOnlySingleElementList<object>(leftIntensifyCaptureGuarantee));
			if (text != null)
			{
				text.SetUIActive(true);
			}
		}
		else if (flag2)
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
		bool uiactive = flag || flag2;
		UUIButtonComponent button = base.GetButton(16);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x0600790D RID: 30989 RVA: 0x0025889C File Offset: 0x00256A9C
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

	// Token: 0x0600790E RID: 30990 RVA: 0x00258978 File Offset: 0x00256B78
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

	// Token: 0x0600790F RID: 30991 RVA: 0x002589F8 File Offset: 0x00256BF8
	public void Tick(float delta)
	{
		this.UpdateRefreshTime();
	}

	// Token: 0x06007910 RID: 30992 RVA: 0x00258A00 File Offset: 0x00256C00
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

	// Token: 0x06007911 RID: 30993 RVA: 0x00258A90 File Offset: 0x00256C90
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

	// Token: 0x06007912 RID: 30994 RVA: 0x00258B30 File Offset: 0x00256D30
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

	// Token: 0x06007913 RID: 30995 RVA: 0x00258CAC File Offset: 0x00256EAC
	private void OnLeftTimeBtn()
	{
		HelpController.Instance.OpenHelpById(72);
	}

	// Token: 0x06007914 RID: 30996 RVA: 0x00258CBA File Offset: 0x00256EBA
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

	// Token: 0x06007915 RID: 30997 RVA: 0x00258CD4 File Offset: 0x00256ED4
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

	// Token: 0x06007916 RID: 30998 RVA: 0x00258D70 File Offset: 0x00256F70
	[NullableContext(1)]
	private void SearchResult(string content)
	{
		AdventureGuideModel instance = AdventureGuideModel.Instance;
		List<MonsterDetectionRecord> detectItemList = this.DetectItemList;
		MonsterDetectionRecord[] searchList = instance.GetSearchList(((detectItemList != null) ? detectItemList.ToArray() : null) ?? Array.Empty<MonsterDetectionRecord>(), content);
		base.GetItem(18).SetUIActive(searchList.Length != 0);
		base.GetItem(19).SetUIActive(searchList.Length == 0);
		this.DetectLoopScroll.RefreshByData(searchList, false, null, false);
	}

	// Token: 0x06007917 RID: 30999 RVA: 0x00258DD8 File Offset: 0x00256FD8
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

	// Token: 0x04004B59 RID: 19289
	private const int MONSTER_HELP = 17;

	// Token: 0x04004B5A RID: 19290
	private const int LEFT_TIME_HELP = 72;

	// Token: 0x04004B5B RID: 19291
	private const int NIGHT_MARE_TYPE = 23;

	// Token: 0x04004B5C RID: 19292
	private const int NIGHT_MARE_TAG = 63;

	// Token: 0x04004B5D RID: 19293
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MonsterDetectItem, MonsterDetectionRecord> DetectLoopScroll;

	// Token: 0x04004B5E RID: 19294
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<MonsterDetectionRecord> DetectItemList;

	// Token: 0x04004B5F RID: 19295
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x04004B60 RID: 19296
	private int CurShowingDetectingTarget;

	// Token: 0x04004B61 RID: 19297
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<MonsterDetectionRecord> FilterBtn;

	// Token: 0x04004B62 RID: 19298
	private UUIExtendToggle CurrentSelectedToggle;

	// Token: 0x04004B63 RID: 19299
	private UUIText DetectText;

	// Token: 0x04004B64 RID: 19300
	private int? PreSelectedMonster = new int?(-1);

	// Token: 0x04004B65 RID: 19301
	private int? PreSelectedDangerType;

	// Token: 0x04004B66 RID: 19302
	private UUIButtonComponent DetectBtn;

	// Token: 0x04004B67 RID: 19303
	private bool DetectInteractive = true;

	// Token: 0x04004B68 RID: 19304
	private double LastClickTime;

	// Token: 0x04004B69 RID: 19305
	private CommonItemSmallItemGrid MonsterHeadItem;

	// Token: 0x04004B6A RID: 19306
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004B6B RID: 19307
	private bool IsNavigationJumpToGrid;

	// Token: 0x04004B6C RID: 19308
	private int JumpIndex;

	// Token: 0x04004B6D RID: 19309
	private CommonSearchComponent SearchComponent;

	// Token: 0x04004B6E RID: 19310
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<MonsterDetectionRecord> FilterResult;

	// Token: 0x02006DF9 RID: 28153
	[NullableContext(0)]
	private enum ENodeDefine
	{
		// Token: 0x04024076 RID: 147574
		FilterBtn,
		// Token: 0x04024077 RID: 147575
		DetectBtn,
		// Token: 0x04024078 RID: 147576
		DetectItem,
		// Token: 0x04024079 RID: 147577
		RewardItem,
		// Token: 0x0402407A RID: 147578
		NameText,
		// Token: 0x0402407B RID: 147579
		DescText,
		// Token: 0x0402407C RID: 147580
		LowDangerItem,
		// Token: 0x0402407D RID: 147581
		DetectScroll,
		// Token: 0x0402407E RID: 147582
		RewardLayout,
		// Token: 0x0402407F RID: 147583
		DropItem,
		// Token: 0x04024080 RID: 147584
		ConfirmText,
		// Token: 0x04024081 RID: 147585
		LowLevelText,
		// Token: 0x04024082 RID: 147586
		TxtUnlock,
		// Token: 0x04024083 RID: 147587
		UnlockItem,
		// Token: 0x04024084 RID: 147588
		MonsterItem,
		// Token: 0x04024085 RID: 147589
		LeftTimeText,
		// Token: 0x04024086 RID: 147590
		LeftTimeBtn,
		// Token: 0x04024087 RID: 147591
		UiItemInputBoxItem,
		// Token: 0x04024088 RID: 147592
		RightItem,
		// Token: 0x04024089 RID: 147593
		EmptyItem
	}
}
