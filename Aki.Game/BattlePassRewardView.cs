using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200232E RID: 9006
public class BattlePassRewardView : UiTabViewBase
{
	// Token: 0x06011D47 RID: 73031 RVA: 0x00464934 File Offset: 0x00462B34
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
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickPayBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickWeapon));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011D48 RID: 73032 RVA: 0x00464AA4 File Offset: 0x00462CA4
	private void OnClickPayBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BattlePassPayView, this.ExtraParams, null);
		BattlePassModel.Instance.PayButtonRedDotState = false;
		OnBattlePassOperationLogEvent onBattlePassOperationLogEvent = new OnBattlePassOperationLogEvent();
		onBattlePassOperationLogEvent.i_operation_type = 1;
		LogReportController.Instance.LogReport(onBattlePassOperationLogEvent);
	}

	// Token: 0x06011D49 RID: 73033 RVA: 0x00464AEC File Offset: 0x00462CEC
	private void OnClickWeapon()
	{
		WeaponPreviewViewParam param = new WeaponPreviewViewParam
		{
			WeaponDataList = BattlePassModel.Instance.GetWeaponDataList().ToArray(),
			SelectedIndex = 0,
			WeaponObservers = (WeaponSkeletalObserverHandles)this.ExtraParams
		};
		UiManager.Instance.OpenView(EUiViewName.WeaponPreviewView, param, null);
	}

	// Token: 0x06011D4A RID: 73034 RVA: 0x00464B40 File Offset: 0x00462D40
	protected override UniTask OnBeforeStartAsync()
	{
		BattlePassRewardView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BattlePassRewardView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011D4B RID: 73035 RVA: 0x00464B84 File Offset: 0x00462D84
	protected override void OnStart()
	{
		this.StartAnime = true;
		base.GetItem(2).SetUIActive(BattlePassModel.Instance.PayType == BattlePassPayStatus.NoPaid);
		this.LoopScrollView = new LoopScrollView<BattlePassRewardGridItem, BattlePassRewardData>(base.GetLoopScrollViewComponent(3), (AUIBaseActor)base.GetItem(5).GetOwner(), new Func<BattlePassRewardGridItem>(this.CreateLoopItem), false);
		this.LoopScrollView.BindOnScrollValueChanged(new Action<FVector2D>(this.RefreshStageReward));
		this.LoopScrollView.BindLateUpdate(new Action<float>(this.RewardScrollToShowLevel));
	}

	// Token: 0x06011D4C RID: 73036 RVA: 0x00464C0F File Offset: 0x00462E0F
	protected override void OnBeforeShow()
	{
		this.RefreshScrollView();
	}

	// Token: 0x06011D4D RID: 73037 RVA: 0x00464C18 File Offset: 0x00462E18
	protected override void OnAfterShow()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.PlaySequence(this.StartAnime ? "Start" : "Switch", false, null);
		}
		this.StartAnime = false;
	}

	// Token: 0x06011D4E RID: 73038 RVA: 0x00464C5B File Offset: 0x00462E5B
	[NullableContext(1)]
	private BattlePassRewardGridItem CreateLoopItem()
	{
		return new BattlePassRewardGridItem();
	}

	// Token: 0x06011D4F RID: 73039 RVA: 0x00464C64 File Offset: 0x00462E64
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int?>(EEventName.GetBattlePassRewardEvent, new Action<int?>(this.OnGetRewardUpdateView));
		EventSystem.Instance.Add(EEventName.ReceiveBattlePassDataEvent, new Action(this.RefreshScrollView));
		EventSystem.Instance.Add(EEventName.BattlePassFirstUnlockAnime, new Action(this.OnBattlePassFirstUnlockAnime));
	}

	// Token: 0x06011D50 RID: 73040 RVA: 0x00464CC8 File Offset: 0x00462EC8
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GetBattlePassRewardEvent, new Action<int?>(this.OnGetRewardUpdateView));
		EventSystem.Instance.Remove(EEventName.ReceiveBattlePassDataEvent, new Action(this.RefreshScrollView));
		EventSystem.Instance.Remove(EEventName.BattlePassFirstUnlockAnime, new Action(this.OnBattlePassFirstUnlockAnime));
	}

	// Token: 0x06011D51 RID: 73041 RVA: 0x00464D29 File Offset: 0x00462F29
	private void OnBattlePassFirstUnlockAnime()
	{
		base.GetItem(2).SetUIActive(BattlePassModel.Instance.PayType == BattlePassPayStatus.NoPaid);
	}

	// Token: 0x06011D52 RID: 73042 RVA: 0x00464D44 File Offset: 0x00462F44
	private void RewardScrollToShowLevel(float _)
	{
		if (this.NeedLateUpdate)
		{
			this.NeedLateUpdate = false;
			int currentShowLevel = BattlePassModel.Instance.GetCurrentShowLevel();
			this.LoopScrollView.ScrollToGridIndex(currentShowLevel - 1, true);
		}
	}

	// Token: 0x06011D53 RID: 73043 RVA: 0x00464D7C File Offset: 0x00462F7C
	private void OnGetRewardUpdateView(int? gridIndex)
	{
		if (gridIndex == null)
		{
			this.LoopScrollView.RefreshAllGridProxies();
		}
		else
		{
			this.LoopScrollView.RefreshGridProxy(gridIndex.Value);
		}
		this.RefreshStageReward(default(FVector2D));
		this.RefreshStageRewardState();
	}

	// Token: 0x06011D54 RID: 73044 RVA: 0x00464DC8 File Offset: 0x00462FC8
	private void RefreshScrollView()
	{
		this.NeedLateUpdate = true;
		this.LoopScrollView.RefreshByData(BattlePassModel.Instance.RewardDataList, false, null, false);
		this.RefreshStageReward(default(FVector2D));
		this.RefreshStageRewardState();
	}

	// Token: 0x06011D55 RID: 73045 RVA: 0x00464E0C File Offset: 0x0046300C
	private void RefreshStageReward(FVector2D _)
	{
		int endGridIndex = this.LoopScrollView.EndGridIndex;
		BattlePassRewardData battlePassRewardData = this.LoopScrollView.TryGetCachedData(endGridIndex);
		if (battlePassRewardData != null)
		{
			int currentLevel = battlePassRewardData.Level.Value - 1;
			int nextStageLevel = BattlePassModel.Instance.GetNextStageLevel(currentLevel);
			if (nextStageLevel != 0 && this.StageRewardView.GetGirdLevel() != nextStageLevel)
			{
				this.StageRewardView.Refresh(BattlePassModel.Instance.GetRewardData(nextStageLevel), false, 0);
			}
		}
	}

	// Token: 0x06011D56 RID: 73046 RVA: 0x00464E78 File Offset: 0x00463078
	private void RefreshStageRewardState()
	{
		int girdLevel = this.StageRewardView.GetGirdLevel();
		if (girdLevel > 0)
		{
			this.StageRewardView.Refresh(BattlePassModel.Instance.GetRewardData(girdLevel), false, 0);
		}
	}

	// Token: 0x06011D57 RID: 73047 RVA: 0x00464EAD File Offset: 0x004630AD
	protected override void OnBeforeDestroy()
	{
		if (this.LoopScrollView != null)
		{
			this.LoopScrollView.ClearGridProxies();
			this.LoopScrollView = null;
		}
	}

	// Token: 0x0400871D RID: 34589
	private bool NeedLateUpdate;

	// Token: 0x0400871E RID: 34590
	private bool StartAnime;

	// Token: 0x0400871F RID: 34591
	[Nullable(2)]
	private BattlePassBackgroundPanel BackgroundPanel;

	// Token: 0x04008720 RID: 34592
	[Nullable(2)]
	private BattlePassRewardGridItem StageRewardView;

	// Token: 0x04008721 RID: 34593
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<BattlePassRewardGridItem, BattlePassRewardData> LoopScrollView;

	// Token: 0x020088B1 RID: 34993
	private enum EReportOperation
	{
		// Token: 0x0402C6D0 RID: 181968
		BuyLevelBtn,
		// Token: 0x0402C6D1 RID: 181969
		BuyPassBtn
	}

	// Token: 0x020088B2 RID: 34994
	private enum EComponents
	{
		// Token: 0x0402C6D3 RID: 181971
		BattlePassBackground,
		// Token: 0x0402C6D4 RID: 181972
		BtnPay,
		// Token: 0x0402C6D5 RID: 181973
		ImgUnlock,
		// Token: 0x0402C6D6 RID: 181974
		RewardLoopScroll,
		// Token: 0x0402C6D7 RID: 181975
		StateRewardItem,
		// Token: 0x0402C6D8 RID: 181976
		RewardItem,
		// Token: 0x0402C6D9 RID: 181977
		BtnWeapon
	}
}
