using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020009EC RID: 2540
[NullableContext(1)]
[Nullable(0)]
public class ActivityTurntableComponent : UiPanelBase
{
	// Token: 0x06006EED RID: 28397 RVA: 0x00222DA4 File Offset: 0x00220FA4
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
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006EEE RID: 28398 RVA: 0x00222EF8 File Offset: 0x002210F8
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityTurntableComponent.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityTurntableComponent.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006EEF RID: 28399 RVA: 0x00222F3C File Offset: 0x0022113C
	private UniTask CreateRewardItem(AActor itemActor)
	{
		ActivityTurntableComponent.<CreateRewardItem>d__16 <CreateRewardItem>d__;
		<CreateRewardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateRewardItem>d__.<>4__this = this;
		<CreateRewardItem>d__.itemActor = itemActor;
		<CreateRewardItem>d__.<>1__state = -1;
		<CreateRewardItem>d__.<>t__builder.Start<ActivityTurntableComponent.<CreateRewardItem>d__16>(ref <CreateRewardItem>d__);
		return <CreateRewardItem>d__.<>t__builder.Task;
	}

	// Token: 0x06006EF0 RID: 28400 RVA: 0x00222F87 File Offset: 0x00221187
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06006EF1 RID: 28401 RVA: 0x00222FA5 File Offset: 0x002211A5
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06006EF2 RID: 28402 RVA: 0x00222FC3 File Offset: 0x002211C3
	protected override void OnBeforeDestroy()
	{
		this.RemoveAnimationTimer();
	}

	// Token: 0x06006EF3 RID: 28403 RVA: 0x00222FCC File Offset: 0x002211CC
	public UniTask Refresh(List<ITurntableReward> rewardList)
	{
		ActivityTurntableComponent.<Refresh>d__20 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.rewardList = rewardList;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<ActivityTurntableComponent.<Refresh>d__20>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x06006EF4 RID: 28404 RVA: 0x00223017 File Offset: 0x00221217
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param != "TurntableRotate" || !this.Activate)
		{
			return;
		}
		this.StartRotateGrid(this.AnimationRotateAngle);
	}

	// Token: 0x06006EF5 RID: 28405 RVA: 0x0022303C File Offset: 0x0022123C
	[NullableContext(2)]
	public void RunTurntableByRewardId(int rewardId, Action finishedCallback = null)
	{
		this.RunTurntableAnimation(rewardId, finishedCallback).ContinueWith(delegate()
		{
			Action finishedCallback2 = finishedCallback;
			if (finishedCallback2 == null)
			{
				return;
			}
			finishedCallback2();
		});
	}

	// Token: 0x06006EF6 RID: 28406 RVA: 0x00223078 File Offset: 0x00221278
	[NullableContext(2)]
	private UniTask RunTurntableAnimation(int rewardId, Action finishedCallback = null)
	{
		ActivityTurntableComponent.<RunTurntableAnimation>d__23 <RunTurntableAnimation>d__;
		<RunTurntableAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RunTurntableAnimation>d__.<>4__this = this;
		<RunTurntableAnimation>d__.rewardId = rewardId;
		<RunTurntableAnimation>d__.finishedCallback = finishedCallback;
		<RunTurntableAnimation>d__.<>1__state = -1;
		<RunTurntableAnimation>d__.<>t__builder.Start<ActivityTurntableComponent.<RunTurntableAnimation>d__23>(ref <RunTurntableAnimation>d__);
		return <RunTurntableAnimation>d__.<>t__builder.Task;
	}

	// Token: 0x06006EF7 RID: 28407 RVA: 0x002230CC File Offset: 0x002212CC
	[NullableContext(0)]
	private ValueTuple<float, bool, bool> GetRotateInfoByRewardId(int rewardId)
	{
		int num = -1;
		bool item = false;
		bool item2 = false;
		for (int i = 0; i < this.RewardItemList.Count; i++)
		{
			if (this.RewardItemList[i].RewardId == rewardId)
			{
				num = i;
				item = this.RewardItemList[i].IsSpecial;
				item2 = this.RewardItemList[i].IsGoldenQuality;
				break;
			}
		}
		if (num < 0)
		{
			return new ValueTuple<float, bool, bool>(-1f, item, item2);
		}
		return new ValueTuple<float, bool, bool>((float)(-90 + -45 * num), item, item2);
	}

	// Token: 0x06006EF8 RID: 28408 RVA: 0x00223154 File Offset: 0x00221354
	private void StartRotateGrid(float rotateAngle)
	{
		if (rotateAngle == 0f)
		{
			return;
		}
		this.RotateAllGridInner(-rotateAngle);
		this.AnimationTime = 0f;
		this.AnimationTimerId = TimerSystem.GameplayTimeInstance.Forever(delegate(float deltaTime)
		{
			this.RunAnimationTimer(deltaTime, rotateAngle);
		}, 20f, 1f, null, null, true);
	}

	// Token: 0x06006EF9 RID: 28409 RVA: 0x002231C4 File Offset: 0x002213C4
	private void RotateAllGridInner(float changeAngle)
	{
		foreach (ActivityTurntableGrid activityTurntableGrid in this.RewardItemList)
		{
			activityTurntableGrid.Rotate(changeAngle);
		}
	}

	// Token: 0x06006EFA RID: 28410 RVA: 0x00223218 File Offset: 0x00221418
	private void RunAnimationTimer(float deltaTime, float totalAngle)
	{
		this.AnimationTime += deltaTime;
		float num = Math.Min(this.AnimationTime / this.AnimationRotateTime, 1f);
		this.AnimationRotator.Pitch = 0f;
		this.AnimationRotator.Roll = 0f;
		this.AnimationRotator.Yaw = num * totalAngle;
		base.GetItem(8).SetUIRelativeRotation(this.AnimationRotator);
		if (this.AnimationTime >= this.AnimationRotateTime)
		{
			this.RemoveAnimationTimer();
		}
	}

	// Token: 0x06006EFB RID: 28411 RVA: 0x0022329F File Offset: 0x0022149F
	private void RemoveAnimationTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.AnimationTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AnimationTimerId);
			this.AnimationTimerId = null;
			this.AnimationTime = 0f;
		}
	}

	// Token: 0x06006EFC RID: 28412 RVA: 0x002232D8 File Offset: 0x002214D8
	private UniTask PlayTurntableAnimation(string sequenceName, bool blockClick = false)
	{
		ActivityTurntableComponent.<PlayTurntableAnimation>d__29 <PlayTurntableAnimation>d__;
		<PlayTurntableAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayTurntableAnimation>d__.<>4__this = this;
		<PlayTurntableAnimation>d__.sequenceName = sequenceName;
		<PlayTurntableAnimation>d__.blockClick = blockClick;
		<PlayTurntableAnimation>d__.<>1__state = -1;
		<PlayTurntableAnimation>d__.<>t__builder.Start<ActivityTurntableComponent.<PlayTurntableAnimation>d__29>(ref <PlayTurntableAnimation>d__);
		return <PlayTurntableAnimation>d__.<>t__builder.Task;
	}

	// Token: 0x040044CD RID: 17613
	private readonly List<ActivityTurntableGrid> RewardItemList = new List<ActivityTurntableGrid>();

	// Token: 0x040044CE RID: 17614
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040044CF RID: 17615
	[Nullable(2)]
	private TimerHandle AnimationTimerId;

	// Token: 0x040044D0 RID: 17616
	private float AnimationTime;

	// Token: 0x040044D1 RID: 17617
	private float AnimationRotateAngle;

	// Token: 0x040044D2 RID: 17618
	private FRotator AnimationRotator = new FRotator();

	// Token: 0x040044D3 RID: 17619
	public bool Activate = true;

	// Token: 0x040044D4 RID: 17620
	private float AnimationRotateTime;

	// Token: 0x040044D5 RID: 17621
	private const int TURNTABLE_GRID_SIZE = 8;

	// Token: 0x040044D6 RID: 17622
	private const int ROTATE_DEFAULT_ANGLE = -90;

	// Token: 0x040044D7 RID: 17623
	private const int ROTATE_GRID_ANGLE = -45;

	// Token: 0x040044D8 RID: 17624
	private const int ROTATE_LOOP_ANIMATION_TIME = 500;

	// Token: 0x040044D9 RID: 17625
	private const string TURNTABLE_ROTATE_PARAM = "TurntableRotate";

	// Token: 0x02006CF2 RID: 27890
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023C7E RID: 146558
		public const int Grid1 = 0;

		// Token: 0x04023C7F RID: 146559
		public const int Grid2 = 1;

		// Token: 0x04023C80 RID: 146560
		public const int Grid3 = 2;

		// Token: 0x04023C81 RID: 146561
		public const int Grid4 = 3;

		// Token: 0x04023C82 RID: 146562
		public const int Grid5 = 4;

		// Token: 0x04023C83 RID: 146563
		public const int Grid6 = 5;

		// Token: 0x04023C84 RID: 146564
		public const int Grid7 = 6;

		// Token: 0x04023C85 RID: 146565
		public const int Grid8 = 7;

		// Token: 0x04023C86 RID: 146566
		public const int Rotator = 8;
	}
}
