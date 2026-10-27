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

// Token: 0x02001B8D RID: 7053
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDungeonSettleItem : UiPanelBase
{
	// Token: 0x0600D205 RID: 53765 RVA: 0x00302930 File Offset: 0x00300B30
	protected unsafe override void OnRegisterComponent()
	{
		int num = 16;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600D206 RID: 53766 RVA: 0x00302B6F File Offset: 0x00300D6F
	protected override void OnBeforeShow()
	{
		this.OnAddEventListener();
		this.RewardLayout = new GenericLayout<FloroRanchDungeonSettleRewardItem, FloroRanchSubInsSettleReward>(base.GetHorizontalLayout(12), new Func<FloroRanchDungeonSettleRewardItem>(this.CreateRewardItem), null, false, true);
	}

	// Token: 0x0600D207 RID: 53767 RVA: 0x00302B99 File Offset: 0x00300D99
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnAnimEvent));
	}

	// Token: 0x0600D208 RID: 53768 RVA: 0x00302BB7 File Offset: 0x00300DB7
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnAnimEvent));
	}

	// Token: 0x0600D209 RID: 53769 RVA: 0x00302BD5 File Offset: 0x00300DD5
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x0600D20A RID: 53770 RVA: 0x00302BE0 File Offset: 0x00300DE0
	public UniTask RefreshAsync(FloroRanchPlaySettleData data)
	{
		FloroRanchDungeonSettleItem.<RefreshAsync>d__8 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<FloroRanchDungeonSettleItem.<RefreshAsync>d__8>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D20B RID: 53771 RVA: 0x00302C2C File Offset: 0x00300E2C
	private void OnAnimEvent(string param)
	{
		if (param == EFloroRanchAnimEvent.TagShow.ToString())
		{
			if (this.SettleData.IsNewMaxDays)
			{
				new LevelSequencePlayer(base.GetItem(4)).PlayLevelSequenceByName("Start", false, null, false);
			}
			if (this.SettleData.IsNewMaxCoin)
			{
				new LevelSequencePlayer(base.GetItem(6)).PlayLevelSequenceByName("Start", false, null, false);
			}
			if (this.SettleData.AllowedTechUp)
			{
				new LevelSequencePlayer(base.GetItem(10)).PlayLevelSequenceByName("Start", false, null, false);
			}
		}
	}

	// Token: 0x0600D20C RID: 53772 RVA: 0x00302CDE File Offset: 0x00300EDE
	private FloroRanchDungeonSettleRewardItem CreateRewardItem()
	{
		return new FloroRanchDungeonSettleRewardItem();
	}

	// Token: 0x04006046 RID: 24646
	private GenericLayout<FloroRanchDungeonSettleRewardItem, FloroRanchSubInsSettleReward> RewardLayout;

	// Token: 0x04006047 RID: 24647
	[Nullable(2)]
	private FloroRanchPlaySettleData SettleData;

	// Token: 0x02008113 RID: 33043
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402A208 RID: 172552
		public const int CardSpine = 0;

		// Token: 0x0402A209 RID: 172553
		public const int CardNameText = 1;

		// Token: 0x0402A20A RID: 172554
		public const int CardContributionText = 2;

		// Token: 0x0402A20B RID: 172555
		public const int TotalDayText = 3;

		// Token: 0x0402A20C RID: 172556
		public const int NewRecordDayItem = 4;

		// Token: 0x0402A20D RID: 172557
		public const int TotalCoinText = 5;

		// Token: 0x0402A20E RID: 172558
		public const int NewRecordCoinItem = 6;

		// Token: 0x0402A20F RID: 172559
		public const int DayMaxCoinText = 7;

		// Token: 0x0402A210 RID: 172560
		public const int RewardItem = 8;

		// Token: 0x0402A211 RID: 172561
		public const int TechnologyRewardText = 9;

		// Token: 0x0402A212 RID: 172562
		public const int TechnologyUpItem = 10;

		// Token: 0x0402A213 RID: 172563
		public const int UnlockRootItem = 11;

		// Token: 0x0402A214 RID: 172564
		public const int UnlockRewardLayout = 12;

		// Token: 0x0402A215 RID: 172565
		public const int WeekScoreItem = 13;

		// Token: 0x0402A216 RID: 172566
		public const int ScoreText = 14;

		// Token: 0x0402A217 RID: 172567
		public const int EndlessTipText = 15;
	}
}
