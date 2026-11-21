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

// Token: 0x02001813 RID: 6163
public class BattlePassRewardView : UiTabViewBase
{
	// Token: 0x0600F1F7 RID: 61943 RVA: 0x004719FC File Offset: 0x0046FBFC
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

	// Token: 0x0600F1F8 RID: 61944 RVA: 0x00471B6C File Offset: 0x0046FD6C
	private void OnClickPayBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BattlePassPayView, this.ExtraParams, null);
		BattlePassModel.Instance.PayButtonRedDotState = false;
		OnBattlePassOperationLogEvent onBattlePassOperationLogEvent = new OnBattlePassOperationLogEvent();
		onBattlePassOperationLogEvent.i_operation_type = 1;
		LogReportController.Instance.LogReport(onBattlePassOperationLogEvent);
	}

	// Token: 0x0600F1F9 RID: 61945 RVA: 0x00471BB4 File Offset: 0x0046FDB4
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

	// Token: 0x0600F1FA RID: 61946 RVA: 0x00471C08 File Offset: 0x0046FE08
	protected override UniTask OnBeforeStartAsync()
	{
		BattlePassRewardView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BattlePassRewardView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F1FB RID: 61947 RVA: 0x00471C4C File Offset: 0x0046FE4C
	protected override void OnStart()
	{
		this.StartAnime = true;
		base.GetItem(2).SetUIActive(BattlePassModel.Instance.PayType == BattlePassPayStatus.NoPaid);
		this.LoopScrollView = new LoopScrollView<BattlePassRewardGridItem, BattlePassRewardData>(base.GetLoopScrollViewComponent(3), (AUIBaseActor)base.GetItem(5).GetOwner(), new Func<BattlePassRewardGridItem>(this.CreateLoopItem), false);
		this.LoopScrollView.BindOnScrollValueChanged(new Action<FVector2D>(this.RefreshStageReward));
		this.LoopScrollView.BindLateUpdate(new Action<float>(this.RewardScrollToShowLevel));
	}

	// Token: 0x0600F1FC RID: 61948 RVA: 0x00471CD7 File Offset: 0x0046FED7
	protected override void OnBeforeShow()
	{
		this.RefreshScrollView();
	}

	// Token: 0x0600F1FD RID: 61949 RVA: 0x00471CE0 File Offset: 0x0046FEE0
	protected override void OnAfterShow()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.PlaySequence(this.StartAnime ? "Start" : "Switch", false, null);
		}
		this.StartAnime = false;
	}

	// Token: 0x0600F1FE RID: 61950 RVA: 0x00471D23 File Offset: 0x0046FF23
	[NullableContext(1)]
	private BattlePassRewardGridItem CreateLoopItem()
	{
		return new BattlePassRewardGridItem();
	}

	// Token: 0x0600F1FF RID: 61951 RVA: 0x00471D2C File Offset: 0x0046FF2C
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int?>(EEventName.GetBattlePassRewardEvent, new Action<int?>(this.OnGetRewardUpdateView));
		EventSystem.Instance.Add(EEventName.ReceiveBattlePassDataEvent, new Action(this.RefreshScrollView));
		EventSystem.Instance.Add(EEventName.BattlePassFirstUnlockAnime, new Action(this.OnBattlePassFirstUnlockAnime));
	}

	// Token: 0x0600F200 RID: 61952 RVA: 0x00471D90 File Offset: 0x0046FF90
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GetBattlePassRewardEvent, new Action<int?>(this.OnGetRewardUpdateView));
		EventSystem.Instance.Remove(EEventName.ReceiveBattlePassDataEvent, new Action(this.RefreshScrollView));
		EventSystem.Instance.Remove(EEventName.BattlePassFirstUnlockAnime, new Action(this.OnBattlePassFirstUnlockAnime));
	}

	// Token: 0x0600F201 RID: 61953 RVA: 0x00471DF1 File Offset: 0x0046FFF1
	private void OnBattlePassFirstUnlockAnime()
	{
		base.GetItem(2).SetUIActive(BattlePassModel.Instance.PayType == BattlePassPayStatus.NoPaid);
	}

	// Token: 0x0600F202 RID: 61954 RVA: 0x00471E0C File Offset: 0x0047000C
	private void RewardScrollToShowLevel(float _)
	{
		if (this.NeedLateUpdate)
		{
			this.NeedLateUpdate = false;
			int currentShowLevel = BattlePassModel.Instance.GetCurrentShowLevel();
			this.LoopScrollView.ScrollToGridIndex(currentShowLevel - 1, true);
		}
	}

	// Token: 0x0600F203 RID: 61955 RVA: 0x00471E44 File Offset: 0x00470044
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

	// Token: 0x0600F204 RID: 61956 RVA: 0x00471E90 File Offset: 0x00470090
	private void RefreshScrollView()
	{
		this.NeedLateUpdate = true;
		this.LoopScrollView.RefreshByData(BattlePassModel.Instance.RewardDataList, false, null, false);
		this.RefreshStageReward(default(FVector2D));
		this.RefreshStageRewardState();
	}

	// Token: 0x0600F205 RID: 61957 RVA: 0x00471ED4 File Offset: 0x004700D4
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

	// Token: 0x0600F206 RID: 61958 RVA: 0x00471F40 File Offset: 0x00470140
	private void RefreshStageRewardState()
	{
		int girdLevel = this.StageRewardView.GetGirdLevel();
		if (girdLevel > 0)
		{
			this.StageRewardView.Refresh(BattlePassModel.Instance.GetRewardData(girdLevel), false, 0);
		}
	}

	// Token: 0x0600F207 RID: 61959 RVA: 0x00471F75 File Offset: 0x00470175
	protected override void OnBeforeDestroy()
	{
		if (this.LoopScrollView != null)
		{
			this.LoopScrollView.ClearGridProxies();
			this.LoopScrollView = null;
		}
	}

	// Token: 0x04008860 RID: 34912
	private bool NeedLateUpdate;

	// Token: 0x04008861 RID: 34913
	private bool StartAnime;

	// Token: 0x04008862 RID: 34914
	[Nullable(2)]
	private BattlePassBackgroundPanel BackgroundPanel;

	// Token: 0x04008863 RID: 34915
	[Nullable(2)]
	private BattlePassRewardGridItem StageRewardView;

	// Token: 0x04008864 RID: 34916
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<BattlePassRewardGridItem, BattlePassRewardData> LoopScrollView;

	// Token: 0x02007A3A RID: 31290
	private enum EReportOperation
	{
		// Token: 0x040279E4 RID: 162276
		BuyLevelBtn,
		// Token: 0x040279E5 RID: 162277
		BuyPassBtn
	}

	// Token: 0x02007A3B RID: 31291
	private enum EComponents
	{
		// Token: 0x040279E7 RID: 162279
		BattlePassBackground,
		// Token: 0x040279E8 RID: 162280
		BtnPay,
		// Token: 0x040279E9 RID: 162281
		ImgUnlock,
		// Token: 0x040279EA RID: 162282
		RewardLoopScroll,
		// Token: 0x040279EB RID: 162283
		StateRewardItem,
		// Token: 0x040279EC RID: 162284
		RewardItem,
		// Token: 0x040279ED RID: 162285
		BtnWeapon
	}
}
