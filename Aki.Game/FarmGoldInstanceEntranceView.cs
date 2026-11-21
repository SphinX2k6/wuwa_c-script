using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.FarmGold;
using CSharpScript.Game.Module.Activity.View.InstanceEntrance;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200071A RID: 1818
[NullableContext(2)]
[Nullable(0)]
public class FarmGoldInstanceEntranceView : UiViewBase
{
	// Token: 0x060053C6 RID: 21446 RVA: 0x001BA909 File Offset: 0x001B8B09
	[NullableContext(1)]
	public FarmGoldInstanceEntranceView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060053C7 RID: 21447 RVA: 0x001BA91C File Offset: 0x001B8B1C
	protected unsafe override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIMultiTemplateLayout)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(19, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(18, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
		int num = 1;
		List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list, num);
		Span<ValueTuple<int, Delegate>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Delegate>(19, new Action(this.OnClickGoBtn));
		this.BtnBindInfo = list;
	}

	// Token: 0x060053C8 RID: 21448 RVA: 0x001BAB08 File Offset: 0x001B8D08
	protected override UniTask OnBeforeStartAsync()
	{
		FarmGoldInstanceEntranceView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FarmGoldInstanceEntranceView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060053C9 RID: 21449 RVA: 0x001BAB4B File Offset: 0x001B8D4B
	[NullableContext(1)]
	private FarmGoldInstanceTabItem InitTabItem()
	{
		FarmGoldInstanceTabItem farmGoldInstanceTabItem = new FarmGoldInstanceTabItem();
		farmGoldInstanceTabItem.SetClickCallback(new Action<FarmGoldLevelData, int>(this.OnClickTabItem));
		return farmGoldInstanceTabItem;
	}

	// Token: 0x060053CA RID: 21450 RVA: 0x001BAB64 File Offset: 0x001B8D64
	[NullableContext(1)]
	private void OnClickTabItem(FarmGoldLevelData data, int index)
	{
		if (this.SelectLevelIndex == index)
		{
			return;
		}
		this.SelectLevelIndex = index;
		this.TabScrollView.SelectGridProxy(index, false);
		data.SaveOpenState();
		this.RefreshRightView();
		FarmGoldController.Instance.RequestSetDifficulty(this.ActivityData.Id, data.GetInstId(), data.GetSelectDifficult());
	}

	// Token: 0x060053CB RID: 21451 RVA: 0x001BABBC File Offset: 0x001B8DBC
	protected override void OnStart()
	{
		this.InitCaptionItem();
		this.InitTabLayout();
		this.ScoreItem.RefreshView();
		base.GetButton(18).GetRootComponent().SetUIActive(false);
		this.AddHomeBtnExtraCallback();
	}

	// Token: 0x060053CC RID: 21452 RVA: 0x001BABF0 File Offset: 0x001B8DF0
	private void OnClickGoBtn()
	{
		FarmGoldLevelData levelDataByIndex = this.ActivityData.GetLevelDataByIndex(this.SelectLevelIndex);
		if (levelDataByIndex == null)
		{
			return;
		}
		FarmGoldController.Instance.HandleDoubleConfirmSoloEnterDungeon(levelDataByIndex);
	}

	// Token: 0x060053CD RID: 21453 RVA: 0x001BAC20 File Offset: 0x001B8E20
	private void InitCaptionItem()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		string farmGoldEntranceName = FarmGoldConfig.Instance.GetFarmGoldEntranceName();
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickBtnClose));
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.SetUiActive(true);
		}
		PopupCaptionItem captionItem2 = this.CaptionItem;
		if (captionItem2 != null)
		{
			captionItem2.SetTitleByTextIdAndArgNew(farmGoldEntranceName, Array.Empty<object>());
		}
		string farmGoldEntranceSpritePath = FarmGoldConfig.Instance.GetFarmGoldEntranceSpritePath();
		if (!string.IsNullOrEmpty(farmGoldEntranceSpritePath))
		{
			this.CaptionItem.SetTitleIconVisible(true);
			this.CaptionItem.SetTitleIcon(farmGoldEntranceSpritePath);
		}
		else
		{
			this.CaptionItem.SetTitleIconVisible(false);
		}
		int helpId = FarmGoldConfig.Instance.GetFarmGoldEntranceHelpId();
		this.CaptionItem.SetHelpBtnActive(helpId != 0);
		this.CaptionItem.SetHelpCallBack(delegate
		{
			HelpController.Instance.OpenHelpById(helpId);
		});
		this.CaptionItem.SetHomeBtnShowState(!GameModeController.Instance.IsInInstance());
	}

	// Token: 0x060053CE RID: 21454 RVA: 0x001BAD1C File Offset: 0x001B8F1C
	private void OnClickBtnClose()
	{
		if (FarmGoldController.Instance.IfLeaveInstanceDungeonWhenMainViewClose)
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
			FarmGoldController.Instance.IfLeaveInstanceDungeonWhenMainViewClose = false;
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x060053CF RID: 21455 RVA: 0x001BAD48 File Offset: 0x001B8F48
	private void AddHomeBtnExtraCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			FarmGoldInstanceEntranceView.<>c.<<AddHomeBtnExtraCallback>b__17_0>d <<AddHomeBtnExtraCallback>b__17_0>d;
			<<AddHomeBtnExtraCallback>b__17_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExtraCallback>b__17_0>d.<>1__state = -1;
			<<AddHomeBtnExtraCallback>b__17_0>d.<>t__builder.Start<FarmGoldInstanceEntranceView.<>c.<<AddHomeBtnExtraCallback>b__17_0>d>(ref <<AddHomeBtnExtraCallback>b__17_0>d);
			return <<AddHomeBtnExtraCallback>b__17_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x060053D0 RID: 21456 RVA: 0x001BAD7C File Offset: 0x001B8F7C
	private void InitTabLayout()
	{
		this.SelectLevelIndex = FarmGoldController.Instance.InitLevelIndex;
		FarmGoldLevelData levelDataByIndex = this.ActivityData.GetLevelDataByIndex(this.SelectLevelIndex);
		levelDataByIndex.SaveOpenState();
		FarmGoldController.Instance.RequestSetDifficulty(this.ActivityData.Id, levelDataByIndex.GetInstId(), levelDataByIndex.GetSelectDifficult());
		List<FarmGoldLevelData> allLevelData = this.ActivityData.GetAllLevelData();
		this.TabScrollView.RefreshByData(allLevelData, false, delegate
		{
			this.SelectLevelIndex = FarmGoldController.Instance.InitLevelIndex;
			this.TabScrollView.SelectGridProxy(this.SelectLevelIndex, false);
			this.RefreshRightView();
		}, false);
	}

	// Token: 0x060053D1 RID: 21457 RVA: 0x001BADF8 File Offset: 0x001B8FF8
	private void RefreshRightView()
	{
		FarmGoldLevelData levelDataByIndex = this.ActivityData.GetLevelDataByIndex(this.SelectLevelIndex);
		if (levelDataByIndex == null)
		{
			return;
		}
		base.GetText(5).SetText(levelDataByIndex.GetNameText(), true);
		base.GetText(7).SetText(levelDataByIndex.GetDescText(), true);
		List<FarmGoldRecommendTag> recommendTagConfigList = levelDataByIndex.GetRecommendTagConfigList();
		this.TagLayout.RefreshByData(recommendTagConfigList, null, false);
		base.GetText(12).SetText(levelDataByIndex.GetMonsterTips(), true);
		this.DropDownItem.RefreshLevelData(levelDataByIndex);
		this.RefreshRecommendLevel();
		this.RefreshLockItem();
	}

	// Token: 0x060053D2 RID: 21458 RVA: 0x001BAE84 File Offset: 0x001B9084
	private void RefreshRecommendLevel()
	{
		int levelRecommendLevelByIndex = this.ActivityData.GetLevelRecommendLevelByIndex(this.SelectLevelIndex);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(16), "RecommendLevel", new <>z__ReadOnlySingleElementList<object>(levelRecommendLevelByIndex));
	}

	// Token: 0x060053D3 RID: 21459 RVA: 0x001BAEC5 File Offset: 0x001B90C5
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshInstancedRecommendLevel, new Action(this.OnRefreshInstancedRecommendLevel));
		EventSystem.Instance.Add(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x060053D4 RID: 21460 RVA: 0x001BAEFF File Offset: 0x001B90FF
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshInstancedRecommendLevel, new Action(this.OnRefreshInstancedRecommendLevel));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x060053D5 RID: 21461 RVA: 0x001BAF3C File Offset: 0x001B913C
	private void OnRefreshCommonActivityRedDot(int activityId)
	{
		if (activityId == this.ActivityData.Id)
		{
			List<FarmGoldLevelData> allLevelData = this.ActivityData.GetAllLevelData();
			this.TabScrollView.RefreshByData(allLevelData, false, null, false);
		}
	}

	// Token: 0x060053D6 RID: 21462 RVA: 0x001BAF74 File Offset: 0x001B9174
	private void OnRefreshInstancedRecommendLevel()
	{
		this.RefreshRecommendLevel();
		FarmGoldLevelData levelDataByIndex = this.ActivityData.GetLevelDataByIndex(this.SelectLevelIndex);
		this.DropDownItem.RefreshLevelData(levelDataByIndex);
	}

	// Token: 0x060053D7 RID: 21463 RVA: 0x001BAFA8 File Offset: 0x001B91A8
	private void RefreshLockItem()
	{
		bool levelLockStateByIndex = this.ActivityData.GetLevelLockStateByIndex(this.SelectLevelIndex);
		base.GetItem(3).SetUIActive(levelLockStateByIndex);
		base.GetItem(13).SetUIActive(!levelLockStateByIndex);
		base.GetItem(11).SetUIActive(!levelLockStateByIndex);
		base.GetItem(8).SetUIActive(!levelLockStateByIndex);
		if (levelLockStateByIndex)
		{
			base.GetText(4).SetText(this.ActivityData.GetLevelUnlockTextByIndex(this.SelectLevelIndex), true);
		}
	}

	// Token: 0x04003ACD RID: 15053
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003ACE RID: 15054
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<FarmGoldInstanceTabItem, FarmGoldLevelData> TabScrollView;

	// Token: 0x04003ACF RID: 15055
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FarmGoldRecommandTagItem, FarmGoldRecommendTag> TagLayout;

	// Token: 0x04003AD0 RID: 15056
	private FarmGoldDropDownRoot DropDownItem;

	// Token: 0x04003AD1 RID: 15057
	private FarmGoldInstanceEntranceScoreItem ScoreItem;

	// Token: 0x04003AD2 RID: 15058
	private FarmGoldData ActivityData;

	// Token: 0x04003AD3 RID: 15059
	private int SelectLevelIndex = -1;

	// Token: 0x02006A05 RID: 27141
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04022E4F RID: 142927
		CaptionItem,
		// Token: 0x04022E50 RID: 142928
		TabScroll,
		// Token: 0x04022E51 RID: 142929
		RewardItem,
		// Token: 0x04022E52 RID: 142930
		LockItem,
		// Token: 0x04022E53 RID: 142931
		LockText,
		// Token: 0x04022E54 RID: 142932
		InstanceNameText,
		// Token: 0x04022E55 RID: 142933
		TextContent,
		// Token: 0x04022E56 RID: 142934
		InstanceDescText,
		// Token: 0x04022E57 RID: 142935
		RecommendTagRoot,
		// Token: 0x04022E58 RID: 142936
		RecommendTagLayout,
		// Token: 0x04022E59 RID: 142937
		RecommendTagItem,
		// Token: 0x04022E5A RID: 142938
		BuffItem,
		// Token: 0x04022E5B RID: 142939
		BuffText,
		// Token: 0x04022E5C RID: 142940
		BottomItem,
		// Token: 0x04022E5D RID: 142941
		DropDownItem,
		// Token: 0x04022E5E RID: 142942
		TipsItem,
		// Token: 0x04022E5F RID: 142943
		TipsText,
		// Token: 0x04022E60 RID: 142944
		BtnRoot,
		// Token: 0x04022E61 RID: 142945
		MutipleGoBtn,
		// Token: 0x04022E62 RID: 142946
		SingleGoBtn,
		// Token: 0x04022E63 RID: 142947
		TabItem
	}
}
