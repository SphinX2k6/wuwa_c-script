using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B98 RID: 7064
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchPopupRewardPanel : UiPanelBase
{
	// Token: 0x0600D25A RID: 53850 RVA: 0x00304C98 File Offset: 0x00302E98
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

	// Token: 0x0600D25B RID: 53851 RVA: 0x00304D04 File Offset: 0x00302F04
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchPopupRewardPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchPopupRewardPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D25C RID: 53852 RVA: 0x00304D47 File Offset: 0x00302F47
	protected override void OnStart()
	{
		this.TemplateRewardItem = base.GetItem(1);
		this.TemplateRewardItem.SetUIActive(false);
	}

	// Token: 0x0600D25D RID: 53853 RVA: 0x00304D62 File Offset: 0x00302F62
	protected override void OnBeforeShow()
	{
		this.TimerHandle = FloroRanchGamePlayModel.Instance.FloroRanchTimerSystem.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, true);
	}

	// Token: 0x0600D25E RID: 53854 RVA: 0x00304D94 File Offset: 0x00302F94
	private void OnTick(float deltaTime)
	{
		foreach (FloroRanchPopupRewardItem floroRanchPopupRewardItem in this.RewardItemSet)
		{
			floroRanchPopupRewardItem.Tick(deltaTime);
		}
	}

	// Token: 0x0600D25F RID: 53855 RVA: 0x00304DE8 File Offset: 0x00302FE8
	protected override void OnBeforeHide()
	{
		if (this.TimerHandle != null)
		{
			FloroRanchGamePlayModel.Instance.FloroRanchTimerSystem.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600D260 RID: 53856 RVA: 0x00304E10 File Offset: 0x00303010
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

	// Token: 0x0600D261 RID: 53857 RVA: 0x00304E53 File Offset: 0x00303053
	private void RecycleRewardItem(FloroRanchPopupRewardItem item)
	{
		this.RewardItemSet.Remove(item);
		this.RewardItemPool.Add(item);
	}

	// Token: 0x0600D262 RID: 53858 RVA: 0x00304E6E File Offset: 0x0030306E
	public void BindCoinTargetPos(FVector vector)
	{
		this.CoinTargetPos = Vector.Create((double)vector.X, (double)vector.Y, (double)vector.Z);
	}

	// Token: 0x0600D263 RID: 53859 RVA: 0x00304E90 File Offset: 0x00303090
	public void BindCoinChangeCallBack(Action<long> callback)
	{
		this.CoinChangeCallBack = callback;
	}

	// Token: 0x0600D264 RID: 53860 RVA: 0x00304E99 File Offset: 0x00303099
	public void BindDiamondChangeCallBack(Action<long> callback)
	{
		this.DiamondChangeCallBack = callback;
	}

	// Token: 0x0600D265 RID: 53861 RVA: 0x00304EA4 File Offset: 0x003030A4
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

	// Token: 0x0600D266 RID: 53862 RVA: 0x00304F00 File Offset: 0x00303100
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

	// Token: 0x0600D267 RID: 53863 RVA: 0x00304F5C File Offset: 0x0030315C
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

	// Token: 0x0600D268 RID: 53864 RVA: 0x00304FB8 File Offset: 0x003031B8
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

	// Token: 0x04006070 RID: 24688
	[Nullable(2)]
	private Vector CoinTargetPos;

	// Token: 0x04006071 RID: 24689
	private readonly HashSet<FloroRanchPopupRewardItem> RewardItemSet = new HashSet<FloroRanchPopupRewardItem>();

	// Token: 0x04006072 RID: 24690
	private readonly List<FloroRanchPopupRewardItem> RewardItemPool = new List<FloroRanchPopupRewardItem>();

	// Token: 0x04006073 RID: 24691
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04006074 RID: 24692
	private UCurveFloat LerpCurve;

	// Token: 0x04006075 RID: 24693
	[Nullable(2)]
	private UUIItem TemplateRewardItem;

	// Token: 0x04006076 RID: 24694
	private Action<long> CoinChangeCallBack;

	// Token: 0x04006077 RID: 24695
	private Action<long> DiamondChangeCallBack;

	// Token: 0x0200812A RID: 33066
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402A28C RID: 172684
		public const int RewardRoot = 0;

		// Token: 0x0402A28D RID: 172685
		public const int RewardTemplate = 1;
	}
}
