using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001504 RID: 5380
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewShipTower : ActivitySubViewBase
{
	// Token: 0x0600997A RID: 39290 RVA: 0x00213650 File Offset: 0x00211850
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnReward));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600997B RID: 39291 RVA: 0x0021379B File Offset: 0x0021199B
	private void OnBtnReward()
	{
		this.PlaySubViewSequence("HideInfo", false);
		ShipTowerModel.Instance.OpenViewReward(null);
	}

	// Token: 0x0600997C RID: 39292 RVA: 0x002137B4 File Offset: 0x002119B4
	protected override void OnSetData()
	{
	}

	// Token: 0x0600997D RID: 39293 RVA: 0x002137B8 File Offset: 0x002119B8
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewShipTower.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewShipTower.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600997E RID: 39294 RVA: 0x002137FB File Offset: 0x002119FB
	protected override void OnStart()
	{
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			commonInfoPanel.SetBtnText("LongShanStage_Join", Array.Empty<object>());
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
	}

	// Token: 0x0600997F RID: 39295 RVA: 0x00213833 File Offset: 0x00211A33
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06009980 RID: 39296 RVA: 0x0021386A File Offset: 0x00211A6A
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06009981 RID: 39297 RVA: 0x002138A1 File Offset: 0x00211AA1
	protected override void OnBeforeShow()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.ShipTowerReward, base.GetItem(3), null, 0);
	}

	// Token: 0x06009982 RID: 39298 RVA: 0x002138B8 File Offset: 0x00211AB8
	protected override void OnBeforeHide()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ShipTowerReward, base.GetItem(3), 0);
	}

	// Token: 0x06009983 RID: 39299 RVA: 0x002138D0 File Offset: 0x00211AD0
	protected override void OnRefreshView()
	{
		this.UpdateOpenState();
		this.UpdateRewardProgress();
		bool flag = ((ActivityShipTowerData)this.ActivityBaseData).HasNewCycle();
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			commonInfoPanel.SetFunctionRedDotVisible(flag);
		}
		ActivitySubViewGeneralInfo commonInfoPanel2 = this.CommonInfoPanel;
		if (commonInfoPanel2 == null)
		{
			return;
		}
		commonInfoPanel2.SetPanelTipVisible(flag);
	}

	// Token: 0x06009984 RID: 39300 RVA: 0x00213920 File Offset: 0x00211B20
	private void SetRewardBtnVisible(bool isVisible)
	{
		base.GetButton(1).RootUIComp.Get().SetUIActive(isVisible);
	}

	// Token: 0x06009985 RID: 39301 RVA: 0x00213948 File Offset: 0x00211B48
	private void UpdateOpenState()
	{
		string rewardProgressText = ShipTowerModel.Instance.GetRewardProgressText(true);
		string currentStageSeasonName = ShipTowerModel.Instance.GetCurrentStageSeasonName();
		base.GetText(2).SetText(rewardProgressText, true);
		base.GetText(4).SetText(currentStageSeasonName, true);
		this.SetRewardBtnVisible(true);
	}

	// Token: 0x06009986 RID: 39302 RVA: 0x00213990 File Offset: 0x00211B90
	private void UpdateRewardProgress()
	{
		List<ShipTowerAreaItemData> areaList = ShipTowerModel.Instance.GetAreaList();
		List<ShipTowerAreaItemData> list = new List<ShipTowerAreaItemData>();
		foreach (ShipTowerAreaItemData shipTowerAreaItemData in areaList)
		{
			if (shipTowerAreaItemData.Id != 0)
			{
				list.Add(shipTowerAreaItemData);
			}
		}
		list.Sort((ShipTowerAreaItemData a, ShipTowerAreaItemData b) => a.Index.Value - b.Index.Value);
		this.RewardProgressItem1.SetData(list[0]);
		this.RewardProgressItem2.SetData(list[1]);
	}

	// Token: 0x06009987 RID: 39303 RVA: 0x00213A40 File Offset: 0x00211C40
	[NullableContext(1)]
	private void ClickCommonInfo(ActivityBaseData data)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (!ShipTowerModel.Instance.CheckCanOpen(EUiViewName.ShipTowerView, null))
			{
				return;
			}
			this.PlaySubViewSequence("HideView", false);
			ShipTowerStageData currentStage = ShipTowerModel.Instance.GetCurrentStage();
			ShipTowerViewParams shipTowerViewParams = new ShipTowerViewParams();
			shipTowerViewParams.StageId = new int?(currentStage.Id);
			ShipTowerModel.Instance.OpenViewMain(shipTowerViewParams);
		});
	}

	// Token: 0x06009988 RID: 39304 RVA: 0x00213A5E File Offset: 0x00211C5E
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.ShipTowerRewardView)
		{
			this.PlaySubViewSequence("ShowInfo", false);
			this.OnRefreshView();
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
		}
	}

	// Token: 0x06009989 RID: 39305 RVA: 0x00213A9C File Offset: 0x00211C9C
	private void OnRefreshCommonActivityRedDot(int i)
	{
		bool flag = ((ActivityShipTowerData)this.ActivityBaseData).HasNewCycle();
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			commonInfoPanel.SetFunctionRedDotVisible(flag);
		}
		ActivitySubViewGeneralInfo commonInfoPanel2 = this.CommonInfoPanel;
		if (commonInfoPanel2 == null)
		{
			return;
		}
		commonInfoPanel2.SetPanelTipVisible(flag);
	}

	// Token: 0x0600998A RID: 39306 RVA: 0x00213AE0 File Offset: 0x00211CE0
	protected override void OnTimer(float gap)
	{
		if (this.IsNeedUpdate)
		{
			return;
		}
		if (!ShipTowerModel.Instance.IsOpen())
		{
			return;
		}
		if (ShipTowerModel.Instance.TimeIsOver() && ShipTowerModel.Instance.CheckIsNeedShowConfirmSeasonUpdate(new Action(this.OnConfirmSeasonUpdate)))
		{
			this.IsNeedUpdate = true;
		}
	}

	// Token: 0x0600998B RID: 39307 RVA: 0x00213B2E File Offset: 0x00211D2E
	private void OnConfirmSeasonUpdate()
	{
		UiManager.Instance.ResetToBattleView(null);
	}

	// Token: 0x04004370 RID: 17264
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x04004371 RID: 17265
	private ActivitySubViewShipTowerRewardProgress RewardProgressItem1;

	// Token: 0x04004372 RID: 17266
	private ActivitySubViewShipTowerRewardProgress RewardProgressItem2;

	// Token: 0x04004373 RID: 17267
	private bool IsNeedUpdate;

	// Token: 0x02007B3C RID: 31548
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028874 RID: 166004
		ItemCommonPanel,
		// Token: 0x04028875 RID: 166005
		BtnReward,
		// Token: 0x04028876 RID: 166006
		TxtNum,
		// Token: 0x04028877 RID: 166007
		ItemRedDot,
		// Token: 0x04028878 RID: 166008
		TxtRewardTitle,
		// Token: 0x04028879 RID: 166009
		RewardProgressItem1,
		// Token: 0x0402887A RID: 166010
		RewardProgressItem2
	}
}
