using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012B8 RID: 4792
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewLoopTower : ActivitySubViewBase
{
	// Token: 0x060083A0 RID: 33696 RVA: 0x001C06CC File Offset: 0x001BE8CC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickTowerShopBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickTowerRewardBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060083A1 RID: 33697 RVA: 0x001C087D File Offset: 0x001BEA7D
	protected override void OnSetData()
	{
	}

	// Token: 0x060083A2 RID: 33698 RVA: 0x001C0880 File Offset: 0x001BEA80
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewLoopTower.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewLoopTower.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060083A3 RID: 33699 RVA: 0x001C08C4 File Offset: 0x001BEAC4
	protected override void OnStart()
	{
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		this.DescriptionComponent.SetContentByTextId(this.ActivityBaseData.LocalConfig.Value.Desc, Array.Empty<string>());
		this.RefreshRewardComponent();
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
		if (StringUtils.IsEmpty(this.ActivityRemainTimeText))
		{
			this.ActivityRemainTimeText = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
		}
	}

	// Token: 0x060083A4 RID: 33700 RVA: 0x001C095F File Offset: 0x001BEB5F
	protected override void OnBeforeShow()
	{
		this.OnRefreshView();
		this.RefreshNewSeasonTip();
		EventSystem.Instance.Emit(EEventName.RedDotTowerReward);
		UUIItem item = base.GetItem(7);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!TowerModel.Instance.GetLoopTowerIsClickShop());
	}

	// Token: 0x060083A5 RID: 33701 RVA: 0x001C099B File Offset: 0x001BEB9B
	protected override void OnRefreshView()
	{
		TowerModel.Instance.CurrentSelectDifficulties = 3;
		base.GetItem(8).SetUIActive(TowerModel.Instance.CanGetRewardByDifficulties(3));
		this.RefreshTimerText();
		this.RefreshFunctionalComponent();
		this.RefreshStarNumber();
	}

	// Token: 0x060083A6 RID: 33702 RVA: 0x001C09D1 File Offset: 0x001BEBD1
	protected override void OnTimer(float gap)
	{
		if (!this.NeedTick)
		{
			return;
		}
		this.RefreshTimerText();
	}

	// Token: 0x060083A7 RID: 33703 RVA: 0x001C09E4 File Offset: 0x001BEBE4
	private void RefreshTimerText()
	{
		double num = (double)MathUtils.Instance.LongToNumber(TowerModel.Instance.TowerEndTime.GetValueOrDefault());
		double serverTime = TimeUtil.Instance.GetServerTime();
		if (num - serverTime <= 0.0)
		{
			ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			this.NeedTick = false;
			return;
		}
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText((long)num, this.ActivityRemainTimeText);
		this.TitleComponent.SetTimeTextByText(remainTimeText);
	}

	// Token: 0x060083A8 RID: 33704 RVA: 0x001C0A58 File Offset: 0x001BEC58
	private void RefreshRewardComponent()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
	}

	// Token: 0x060083A9 RID: 33705 RVA: 0x001C0AA4 File Offset: 0x001BECA4
	private void RefreshFunctionalComponent()
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("CollectActivity_Button_ahead", null);
		this.FunctionalComponent.FunctionButton.SetText(localTextNew);
		this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.JumpFunction));
		int loopTowerIsClickSeason = TowerModel.Instance.GetLoopTowerIsClickSeason();
		this.FunctionalComponent.SetFunctionRedDotVisible(loopTowerIsClickSeason < TowerModel.Instance.CurrentSeason);
	}

	// Token: 0x060083AA RID: 33706 RVA: 0x001C0B10 File Offset: 0x001BED10
	private void RefreshNewSeasonTip()
	{
		int player = LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.LoopTowerSeason, -1);
		int currentSeason = TowerModel.Instance.CurrentSeason;
		bool flag = player != currentSeason;
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent != null)
		{
			functionalComponent.SetPanelTipVisible(flag);
		}
		if (flag)
		{
			ActivityFunctionalTypeA functionalComponent2 = this.FunctionalComponent;
			if (functionalComponent2 != null)
			{
				functionalComponent2.SetPanelTipByTextId("CycleTowerNewPeriod", Array.Empty<string>());
			}
			LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.LoopTowerSeason, currentSeason);
		}
	}

	// Token: 0x060083AB RID: 33707 RVA: 0x001C0B78 File Offset: 0x001BED78
	private void RefreshStarNumber()
	{
		TowerModel instance = TowerModel.Instance;
		int difficultyMaxStars = instance.GetDifficultyMaxStars(3, false);
		int difficultyAllStars = instance.GetDifficultyAllStars(3, false);
		base.GetText(6).SetText(difficultyMaxStars.ToString() + "/" + difficultyAllStars.ToString(), true);
	}

	// Token: 0x060083AC RID: 33708 RVA: 0x001C0BC0 File Offset: 0x001BEDC0
	private void JumpFunction()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			TowerController.Instance.OpenTowerView(false);
		});
	}

	// Token: 0x060083AD RID: 33709 RVA: 0x001C0BF1 File Offset: 0x001BEDF1
	private void OnClickTowerShopBtn()
	{
		TowerModel.Instance.SetLoopTowerIsClickShop(true);
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		PayShopController.Instance.OpenPayShopViewWithTab(PayShopDefine.EPayShopTabType.ActivityShop, 0);
	}

	// Token: 0x060083AE RID: 33710 RVA: 0x001C0C20 File Offset: 0x001BEE20
	private void OnClickTowerRewardBtn()
	{
		TowerModel instance = TowerModel.Instance;
		if (((instance != null) ? instance.GetDifficultyRewardProgress(3) : 0f) == 1f)
		{
			ScrollingTipsController.Instance.ShowTipsById("HaveAllReward", Array.Empty<object>());
		}
		UiManager.Instance.OpenView(EUiViewName.TowerRewardView, 3, delegate(bool success, int viewId)
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.CommonActivityView);
			if (viewByName == null)
			{
				return;
			}
			viewByName.AddChildViewById(viewId);
		});
	}

	// Token: 0x04003B3B RID: 15163
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003B3C RID: 15164
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04003B3D RID: 15165
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04003B3E RID: 15166
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x04003B3F RID: 15167
	private bool NeedTick = true;

	// Token: 0x020078D4 RID: 30932
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027CF3 RID: 163059
		public const int TitleItem = 0;

		// Token: 0x04027CF4 RID: 163060
		public const int DescriptionItem = 1;

		// Token: 0x04027CF5 RID: 163061
		public const int RewardListItem = 2;

		// Token: 0x04027CF6 RID: 163062
		public const int FunctionArea = 3;

		// Token: 0x04027CF7 RID: 163063
		public const int TowerShopBtn = 4;

		// Token: 0x04027CF8 RID: 163064
		public const int TowerRewardBtn = 5;

		// Token: 0x04027CF9 RID: 163065
		public const int TowerProgressText = 6;

		// Token: 0x04027CFA RID: 163066
		public const int ShopBtnRedDotItem = 7;

		// Token: 0x04027CFB RID: 163067
		public const int RewardBtnRedDotItem = 8;
	}
}
