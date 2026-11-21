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

// Token: 0x0200104C RID: 4172
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDungeonSettleItem : UiPanelBase
{
	// Token: 0x0600A616 RID: 42518 RVA: 0x0030DA08 File Offset: 0x0030BC08
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

	// Token: 0x0600A617 RID: 42519 RVA: 0x0030DC47 File Offset: 0x0030BE47
	protected override void OnBeforeShow()
	{
		this.OnAddEventListener();
		this.RewardLayout = new GenericLayout<FloroRanchDungeonSettleRewardItem, FloroRanchSubInsSettleReward>(base.GetHorizontalLayout(12), new Func<FloroRanchDungeonSettleRewardItem>(this.CreateRewardItem), null, false, true);
	}

	// Token: 0x0600A618 RID: 42520 RVA: 0x0030DC71 File Offset: 0x0030BE71
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnAnimEvent));
	}

	// Token: 0x0600A619 RID: 42521 RVA: 0x0030DC8F File Offset: 0x0030BE8F
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnAnimEvent));
	}

	// Token: 0x0600A61A RID: 42522 RVA: 0x0030DCAD File Offset: 0x0030BEAD
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x0600A61B RID: 42523 RVA: 0x0030DCB8 File Offset: 0x0030BEB8
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

	// Token: 0x0600A61C RID: 42524 RVA: 0x0030DD04 File Offset: 0x0030BF04
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

	// Token: 0x0600A61D RID: 42525 RVA: 0x0030DDB6 File Offset: 0x0030BFB6
	private FloroRanchDungeonSettleRewardItem CreateRewardItem()
	{
		return new FloroRanchDungeonSettleRewardItem();
	}

	// Token: 0x04006115 RID: 24853
	private GenericLayout<FloroRanchDungeonSettleRewardItem, FloroRanchSubInsSettleReward> RewardLayout;

	// Token: 0x04006116 RID: 24854
	[Nullable(2)]
	private FloroRanchPlaySettleData SettleData;

	// Token: 0x020072A1 RID: 29345
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402553C RID: 152892
		public const int CardSpine = 0;

		// Token: 0x0402553D RID: 152893
		public const int CardNameText = 1;

		// Token: 0x0402553E RID: 152894
		public const int CardContributionText = 2;

		// Token: 0x0402553F RID: 152895
		public const int TotalDayText = 3;

		// Token: 0x04025540 RID: 152896
		public const int NewRecordDayItem = 4;

		// Token: 0x04025541 RID: 152897
		public const int TotalCoinText = 5;

		// Token: 0x04025542 RID: 152898
		public const int NewRecordCoinItem = 6;

		// Token: 0x04025543 RID: 152899
		public const int DayMaxCoinText = 7;

		// Token: 0x04025544 RID: 152900
		public const int RewardItem = 8;

		// Token: 0x04025545 RID: 152901
		public const int TechnologyRewardText = 9;

		// Token: 0x04025546 RID: 152902
		public const int TechnologyUpItem = 10;

		// Token: 0x04025547 RID: 152903
		public const int UnlockRootItem = 11;

		// Token: 0x04025548 RID: 152904
		public const int UnlockRewardLayout = 12;

		// Token: 0x04025549 RID: 152905
		public const int WeekScoreItem = 13;

		// Token: 0x0402554A RID: 152906
		public const int ScoreText = 14;

		// Token: 0x0402554B RID: 152907
		public const int EndlessTipText = 15;
	}
}
