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

// Token: 0x02001266 RID: 4710
[NullableContext(2)]
[Nullable(0)]
public class FarmGoldInstanceEntranceView : UiViewBase
{
	// Token: 0x0600802F RID: 32815 RVA: 0x001B1C39 File Offset: 0x001AFE39
	[NullableContext(1)]
	public FarmGoldInstanceEntranceView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008030 RID: 32816 RVA: 0x001B1C4C File Offset: 0x001AFE4C
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

	// Token: 0x06008031 RID: 32817 RVA: 0x001B1E38 File Offset: 0x001B0038
	protected override UniTask OnBeforeStartAsync()
	{
		FarmGoldInstanceEntranceView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FarmGoldInstanceEntranceView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008032 RID: 32818 RVA: 0x001B1E7B File Offset: 0x001B007B
	[NullableContext(1)]
	private FarmGoldInstanceTabItem InitTabItem()
	{
		FarmGoldInstanceTabItem farmGoldInstanceTabItem = new FarmGoldInstanceTabItem();
		farmGoldInstanceTabItem.SetClickCallback(new Action<FarmGoldLevelData, int>(this.OnClickTabItem));
		return farmGoldInstanceTabItem;
	}

	// Token: 0x06008033 RID: 32819 RVA: 0x001B1E94 File Offset: 0x001B0094
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

	// Token: 0x06008034 RID: 32820 RVA: 0x001B1EEC File Offset: 0x001B00EC
	protected override void OnStart()
	{
		this.InitCaptionItem();
		this.InitTabLayout();
		this.ScoreItem.RefreshView();
		base.GetButton(18).GetRootComponent().SetUIActive(false);
		this.AddHomeBtnExtraCallback();
	}

	// Token: 0x06008035 RID: 32821 RVA: 0x001B1F20 File Offset: 0x001B0120
	private void OnClickGoBtn()
	{
		FarmGoldLevelData levelDataByIndex = this.ActivityData.GetLevelDataByIndex(this.SelectLevelIndex);
		if (levelDataByIndex == null)
		{
			return;
		}
		FarmGoldController.Instance.HandleDoubleConfirmSoloEnterDungeon(levelDataByIndex);
	}

	// Token: 0x06008036 RID: 32822 RVA: 0x001B1F50 File Offset: 0x001B0150
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

	// Token: 0x06008037 RID: 32823 RVA: 0x001B204C File Offset: 0x001B024C
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

	// Token: 0x06008038 RID: 32824 RVA: 0x001B2078 File Offset: 0x001B0278
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

	// Token: 0x06008039 RID: 32825 RVA: 0x001B20AC File Offset: 0x001B02AC
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

	// Token: 0x0600803A RID: 32826 RVA: 0x001B2128 File Offset: 0x001B0328
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

	// Token: 0x0600803B RID: 32827 RVA: 0x001B21B4 File Offset: 0x001B03B4
	private void RefreshRecommendLevel()
	{
		int levelRecommendLevelByIndex = this.ActivityData.GetLevelRecommendLevelByIndex(this.SelectLevelIndex);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(16), "RecommendLevel", new <>z__ReadOnlySingleElementList<object>(levelRecommendLevelByIndex));
	}

	// Token: 0x0600803C RID: 32828 RVA: 0x001B21F5 File Offset: 0x001B03F5
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshInstancedRecommendLevel, new Action(this.OnRefreshInstancedRecommendLevel));
		EventSystem.Instance.Add(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x0600803D RID: 32829 RVA: 0x001B222F File Offset: 0x001B042F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshInstancedRecommendLevel, new Action(this.OnRefreshInstancedRecommendLevel));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x0600803E RID: 32830 RVA: 0x001B226C File Offset: 0x001B046C
	private void OnRefreshCommonActivityRedDot(int activityId)
	{
		if (activityId == this.ActivityData.Id)
		{
			List<FarmGoldLevelData> allLevelData = this.ActivityData.GetAllLevelData();
			this.TabScrollView.RefreshByData(allLevelData, false, null, false);
		}
	}

	// Token: 0x0600803F RID: 32831 RVA: 0x001B22A4 File Offset: 0x001B04A4
	private void OnRefreshInstancedRecommendLevel()
	{
		this.RefreshRecommendLevel();
		FarmGoldLevelData levelDataByIndex = this.ActivityData.GetLevelDataByIndex(this.SelectLevelIndex);
		this.DropDownItem.RefreshLevelData(levelDataByIndex);
	}

	// Token: 0x06008040 RID: 32832 RVA: 0x001B22D8 File Offset: 0x001B04D8
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

	// Token: 0x04003A35 RID: 14901
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003A36 RID: 14902
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<FarmGoldInstanceTabItem, FarmGoldLevelData> TabScrollView;

	// Token: 0x04003A37 RID: 14903
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FarmGoldRecommandTagItem, FarmGoldRecommendTag> TagLayout;

	// Token: 0x04003A38 RID: 14904
	private FarmGoldDropDownRoot DropDownItem;

	// Token: 0x04003A39 RID: 14905
	private FarmGoldInstanceEntranceScoreItem ScoreItem;

	// Token: 0x04003A3A RID: 14906
	private FarmGoldData ActivityData;

	// Token: 0x04003A3B RID: 14907
	private int SelectLevelIndex = -1;

	// Token: 0x0200787A RID: 30842
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04027B1E RID: 162590
		CaptionItem,
		// Token: 0x04027B1F RID: 162591
		TabScroll,
		// Token: 0x04027B20 RID: 162592
		RewardItem,
		// Token: 0x04027B21 RID: 162593
		LockItem,
		// Token: 0x04027B22 RID: 162594
		LockText,
		// Token: 0x04027B23 RID: 162595
		InstanceNameText,
		// Token: 0x04027B24 RID: 162596
		TextContent,
		// Token: 0x04027B25 RID: 162597
		InstanceDescText,
		// Token: 0x04027B26 RID: 162598
		RecommendTagRoot,
		// Token: 0x04027B27 RID: 162599
		RecommendTagLayout,
		// Token: 0x04027B28 RID: 162600
		RecommendTagItem,
		// Token: 0x04027B29 RID: 162601
		BuffItem,
		// Token: 0x04027B2A RID: 162602
		BuffText,
		// Token: 0x04027B2B RID: 162603
		BottomItem,
		// Token: 0x04027B2C RID: 162604
		DropDownItem,
		// Token: 0x04027B2D RID: 162605
		TipsItem,
		// Token: 0x04027B2E RID: 162606
		TipsText,
		// Token: 0x04027B2F RID: 162607
		BtnRoot,
		// Token: 0x04027B30 RID: 162608
		MutipleGoBtn,
		// Token: 0x04027B31 RID: 162609
		SingleGoBtn,
		// Token: 0x04027B32 RID: 162610
		TabItem
	}
}
