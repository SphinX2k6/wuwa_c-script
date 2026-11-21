using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020009BC RID: 2492
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewShipTower : ActivitySubViewBase
{
	// Token: 0x06006D54 RID: 27988 RVA: 0x0021D36C File Offset: 0x0021B56C
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

	// Token: 0x06006D55 RID: 27989 RVA: 0x0021D4B7 File Offset: 0x0021B6B7
	private void OnBtnReward()
	{
		this.PlaySubViewSequence("HideInfo", false);
		ShipTowerModel.Instance.OpenViewReward(null);
	}

	// Token: 0x06006D56 RID: 27990 RVA: 0x0021D4D0 File Offset: 0x0021B6D0
	protected override void OnSetData()
	{
	}

	// Token: 0x06006D57 RID: 27991 RVA: 0x0021D4D4 File Offset: 0x0021B6D4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewShipTower.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewShipTower.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006D58 RID: 27992 RVA: 0x0021D517 File Offset: 0x0021B717
	protected override void OnStart()
	{
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			commonInfoPanel.SetBtnText("LongShanStage_Join", Array.Empty<object>());
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
	}

	// Token: 0x06006D59 RID: 27993 RVA: 0x0021D54F File Offset: 0x0021B74F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06006D5A RID: 27994 RVA: 0x0021D586 File Offset: 0x0021B786
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06006D5B RID: 27995 RVA: 0x0021D5BD File Offset: 0x0021B7BD
	protected override void OnBeforeShow()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.ShipTowerReward, base.GetItem(3), null, 0);
	}

	// Token: 0x06006D5C RID: 27996 RVA: 0x0021D5D4 File Offset: 0x0021B7D4
	protected override void OnBeforeHide()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ShipTowerReward, base.GetItem(3), 0);
	}

	// Token: 0x06006D5D RID: 27997 RVA: 0x0021D5EC File Offset: 0x0021B7EC
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

	// Token: 0x06006D5E RID: 27998 RVA: 0x0021D63C File Offset: 0x0021B83C
	private void SetRewardBtnVisible(bool isVisible)
	{
		base.GetButton(1).RootUIComp.Get().SetUIActive(isVisible);
	}

	// Token: 0x06006D5F RID: 27999 RVA: 0x0021D664 File Offset: 0x0021B864
	private void UpdateOpenState()
	{
		string rewardProgressText = ShipTowerModel.Instance.GetRewardProgressText(true);
		string currentStageSeasonName = ShipTowerModel.Instance.GetCurrentStageSeasonName();
		base.GetText(2).SetText(rewardProgressText, true);
		base.GetText(4).SetText(currentStageSeasonName, true);
		this.SetRewardBtnVisible(true);
	}

	// Token: 0x06006D60 RID: 28000 RVA: 0x0021D6AC File Offset: 0x0021B8AC
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

	// Token: 0x06006D61 RID: 28001 RVA: 0x0021D75C File Offset: 0x0021B95C
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

	// Token: 0x06006D62 RID: 28002 RVA: 0x0021D77A File Offset: 0x0021B97A
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.ShipTowerRewardView)
		{
			this.PlaySubViewSequence("ShowInfo", false);
			this.OnRefreshView();
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
		}
	}

	// Token: 0x06006D63 RID: 28003 RVA: 0x0021D7B8 File Offset: 0x0021B9B8
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

	// Token: 0x06006D64 RID: 28004 RVA: 0x0021D7FC File Offset: 0x0021B9FC
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

	// Token: 0x06006D65 RID: 28005 RVA: 0x0021D84A File Offset: 0x0021BA4A
	private void OnConfirmSeasonUpdate()
	{
		UiManager.Instance.ResetToBattleView(null);
	}

	// Token: 0x04004415 RID: 17429
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x04004416 RID: 17430
	private ActivitySubViewShipTowerRewardProgress RewardProgressItem1;

	// Token: 0x04004417 RID: 17431
	private ActivitySubViewShipTowerRewardProgress RewardProgressItem2;

	// Token: 0x04004418 RID: 17432
	private bool IsNeedUpdate;

	// Token: 0x02006CC7 RID: 27847
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04023BB0 RID: 146352
		ItemCommonPanel,
		// Token: 0x04023BB1 RID: 146353
		BtnReward,
		// Token: 0x04023BB2 RID: 146354
		TxtNum,
		// Token: 0x04023BB3 RID: 146355
		ItemRedDot,
		// Token: 0x04023BB4 RID: 146356
		TxtRewardTitle,
		// Token: 0x04023BB5 RID: 146357
		RewardProgressItem1,
		// Token: 0x04023BB6 RID: 146358
		RewardProgressItem2
	}
}
