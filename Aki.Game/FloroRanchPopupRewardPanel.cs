using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001057 RID: 4183
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchPopupRewardPanel : UiPanelBase
{
	// Token: 0x0600A66B RID: 42603 RVA: 0x0030FD70 File Offset: 0x0030DF70
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A66C RID: 42604 RVA: 0x0030FDDC File Offset: 0x0030DFDC
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchPopupRewardPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchPopupRewardPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A66D RID: 42605 RVA: 0x0030FE1F File Offset: 0x0030E01F
	protected override void OnStart()
	{
		this.TemplateRewardItem = base.GetItem(1);
		this.TemplateRewardItem.SetUIActive(false);
	}

	// Token: 0x0600A66E RID: 42606 RVA: 0x0030FE3A File Offset: 0x0030E03A
	protected override void OnBeforeShow()
	{
		this.TimerHandle = FloroRanchGamePlayModel.Instance.FloroRanchTimerSystem.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, true);
	}

	// Token: 0x0600A66F RID: 42607 RVA: 0x0030FE6C File Offset: 0x0030E06C
	private void OnTick(float deltaTime)
	{
		foreach (FloroRanchPopupRewardItem floroRanchPopupRewardItem in this.RewardItemSet)
		{
			floroRanchPopupRewardItem.Tick(deltaTime);
		}
	}

	// Token: 0x0600A670 RID: 42608 RVA: 0x0030FEC0 File Offset: 0x0030E0C0
	protected override void OnBeforeHide()
	{
		if (this.TimerHandle != null)
		{
			FloroRanchGamePlayModel.Instance.FloroRanchTimerSystem.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600A671 RID: 42609 RVA: 0x0030FEE8 File Offset: 0x0030E0E8
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<FloroRanchPopupRewardItem> GetRewardItem()
	{
		FloroRanchPopupRewardPanel.<GetRewardItem>d__15 <GetRewardItem>d__;
		<GetRewardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloroRanchPopupRewardItem>.Create();
		<GetRewardItem>d__.<>4__this = this;
		<GetRewardItem>d__.<>1__state = -1;
		<GetRewardItem>d__.<>t__builder.Start<FloroRanchPopupRewardPanel.<GetRewardItem>d__15>(ref <GetRewardItem>d__);
		return <GetRewardItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A672 RID: 42610 RVA: 0x0030FF2B File Offset: 0x0030E12B
	private void RecycleRewardItem(FloroRanchPopupRewardItem item)
	{
		this.RewardItemSet.Remove(item);
		this.RewardItemPool.Add(item);
	}

	// Token: 0x0600A673 RID: 42611 RVA: 0x0030FF46 File Offset: 0x0030E146
	public void BindCoinTargetPos(FVector vector)
	{
		this.CoinTargetPos = Vector.Create((double)vector.X, (double)vector.Y, (double)vector.Z);
	}

	// Token: 0x0600A674 RID: 42612 RVA: 0x0030FF68 File Offset: 0x0030E168
	public void BindCoinChangeCallBack(Action<long> callback)
	{
		this.CoinChangeCallBack = callback;
	}

	// Token: 0x0600A675 RID: 42613 RVA: 0x0030FF71 File Offset: 0x0030E171
	public void BindDiamondChangeCallBack(Action<long> callback)
	{
		this.DiamondChangeCallBack = callback;
	}

	// Token: 0x0600A676 RID: 42614 RVA: 0x0030FF7C File Offset: 0x0030E17C
	public UniTask ShowPopupReward(FloroRanchUiItemBase item, EFloroRanchPopupRewardType rewardType, long count)
	{
		FloroRanchPopupRewardPanel.<ShowPopupReward>d__20 <ShowPopupReward>d__;
		<ShowPopupReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowPopupReward>d__.<>4__this = this;
		<ShowPopupReward>d__.item = item;
		<ShowPopupReward>d__.rewardType = rewardType;
		<ShowPopupReward>d__.count = count;
		<ShowPopupReward>d__.<>1__state = -1;
		<ShowPopupReward>d__.<>t__builder.Start<FloroRanchPopupRewardPanel.<ShowPopupReward>d__20>(ref <ShowPopupReward>d__);
		return <ShowPopupReward>d__.<>t__builder.Task;
	}

	// Token: 0x0600A677 RID: 42615 RVA: 0x0030FFD8 File Offset: 0x0030E1D8
	private UniTask ShowCoinReward(Vector startPoint, FloroRanchPopupRewardItem rewardItem, long count)
	{
		FloroRanchPopupRewardPanel.<ShowCoinReward>d__21 <ShowCoinReward>d__;
		<ShowCoinReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowCoinReward>d__.<>4__this = this;
		<ShowCoinReward>d__.startPoint = startPoint;
		<ShowCoinReward>d__.rewardItem = rewardItem;
		<ShowCoinReward>d__.count = count;
		<ShowCoinReward>d__.<>1__state = -1;
		<ShowCoinReward>d__.<>t__builder.Start<FloroRanchPopupRewardPanel.<ShowCoinReward>d__21>(ref <ShowCoinReward>d__);
		return <ShowCoinReward>d__.<>t__builder.Task;
	}

	// Token: 0x0600A678 RID: 42616 RVA: 0x00310034 File Offset: 0x0030E234
	private UniTask ShowDiamondReward(Vector startPoint, FloroRanchPopupRewardItem rewardItem, long count)
	{
		FloroRanchPopupRewardPanel.<ShowDiamondReward>d__22 <ShowDiamondReward>d__;
		<ShowDiamondReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowDiamondReward>d__.<>4__this = this;
		<ShowDiamondReward>d__.startPoint = startPoint;
		<ShowDiamondReward>d__.rewardItem = rewardItem;
		<ShowDiamondReward>d__.count = count;
		<ShowDiamondReward>d__.<>1__state = -1;
		<ShowDiamondReward>d__.<>t__builder.Start<FloroRanchPopupRewardPanel.<ShowDiamondReward>d__22>(ref <ShowDiamondReward>d__);
		return <ShowDiamondReward>d__.<>t__builder.Task;
	}

	// Token: 0x0600A679 RID: 42617 RVA: 0x00310090 File Offset: 0x0030E290
	private UniTask ShowSalaryReward(Vector startPoint, FloroRanchPopupRewardItem rewardItem, long count)
	{
		FloroRanchPopupRewardPanel.<ShowSalaryReward>d__23 <ShowSalaryReward>d__;
		<ShowSalaryReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowSalaryReward>d__.<>4__this = this;
		<ShowSalaryReward>d__.startPoint = startPoint;
		<ShowSalaryReward>d__.rewardItem = rewardItem;
		<ShowSalaryReward>d__.count = count;
		<ShowSalaryReward>d__.<>1__state = -1;
		<ShowSalaryReward>d__.<>t__builder.Start<FloroRanchPopupRewardPanel.<ShowSalaryReward>d__23>(ref <ShowSalaryReward>d__);
		return <ShowSalaryReward>d__.<>t__builder.Task;
	}

	// Token: 0x0400613F RID: 24895
	[Nullable(2)]
	private Vector CoinTargetPos;

	// Token: 0x04006140 RID: 24896
	private readonly HashSet<FloroRanchPopupRewardItem> RewardItemSet = new HashSet<FloroRanchPopupRewardItem>();

	// Token: 0x04006141 RID: 24897
	private readonly List<FloroRanchPopupRewardItem> RewardItemPool = new List<FloroRanchPopupRewardItem>();

	// Token: 0x04006142 RID: 24898
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04006143 RID: 24899
	private UCurveFloat LerpCurve;

	// Token: 0x04006144 RID: 24900
	[Nullable(2)]
	private UUIItem TemplateRewardItem;

	// Token: 0x04006145 RID: 24901
	private Action<long> CoinChangeCallBack;

	// Token: 0x04006146 RID: 24902
	private Action<long> DiamondChangeCallBack;

	// Token: 0x020072B8 RID: 29368
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040255C0 RID: 153024
		public const int RewardRoot = 0;

		// Token: 0x040255C1 RID: 153025
		public const int RewardTemplate = 1;
	}
}
