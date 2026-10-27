using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001534 RID: 5428
[NullableContext(1)]
[Nullable(0)]
public class ActivityTurntableComponent : UiPanelBase
{
	// Token: 0x06009B0F RID: 39695 RVA: 0x00219004 File Offset: 0x00217204
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

	// Token: 0x06009B10 RID: 39696 RVA: 0x00219158 File Offset: 0x00217358
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityTurntableComponent.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityTurntableComponent.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009B11 RID: 39697 RVA: 0x0021919C File Offset: 0x0021739C
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

	// Token: 0x06009B12 RID: 39698 RVA: 0x002191E7 File Offset: 0x002173E7
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06009B13 RID: 39699 RVA: 0x00219205 File Offset: 0x00217405
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06009B14 RID: 39700 RVA: 0x00219223 File Offset: 0x00217423
	protected override void OnBeforeDestroy()
	{
		this.RemoveAnimationTimer();
	}

	// Token: 0x06009B15 RID: 39701 RVA: 0x0021922C File Offset: 0x0021742C
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

	// Token: 0x06009B16 RID: 39702 RVA: 0x00219277 File Offset: 0x00217477
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param != "TurntableRotate" || !this.Activate)
		{
			return;
		}
		this.StartRotateGrid(this.AnimationRotateAngle);
	}

	// Token: 0x06009B17 RID: 39703 RVA: 0x0021929C File Offset: 0x0021749C
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

	// Token: 0x06009B18 RID: 39704 RVA: 0x002192D8 File Offset: 0x002174D8
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

	// Token: 0x06009B19 RID: 39705 RVA: 0x0021932C File Offset: 0x0021752C
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

	// Token: 0x06009B1A RID: 39706 RVA: 0x002193B4 File Offset: 0x002175B4
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

	// Token: 0x06009B1B RID: 39707 RVA: 0x00219424 File Offset: 0x00217624
	private void RotateAllGridInner(float changeAngle)
	{
		foreach (ActivityTurntableGrid activityTurntableGrid in this.RewardItemList)
		{
			activityTurntableGrid.Rotate(changeAngle);
		}
	}

	// Token: 0x06009B1C RID: 39708 RVA: 0x00219478 File Offset: 0x00217678
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

	// Token: 0x06009B1D RID: 39709 RVA: 0x002194FF File Offset: 0x002176FF
	private void RemoveAnimationTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.AnimationTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AnimationTimerId);
			this.AnimationTimerId = null;
			this.AnimationTime = 0f;
		}
	}

	// Token: 0x06009B1E RID: 39710 RVA: 0x00219538 File Offset: 0x00217738
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

	// Token: 0x04004427 RID: 17447
	private readonly List<ActivityTurntableGrid> RewardItemList = new List<ActivityTurntableGrid>();

	// Token: 0x04004428 RID: 17448
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004429 RID: 17449
	[Nullable(2)]
	private TimerHandle AnimationTimerId;

	// Token: 0x0400442A RID: 17450
	private float AnimationTime;

	// Token: 0x0400442B RID: 17451
	private float AnimationRotateAngle;

	// Token: 0x0400442C RID: 17452
	private FRotator AnimationRotator = new FRotator();

	// Token: 0x0400442D RID: 17453
	public bool Activate = true;

	// Token: 0x0400442E RID: 17454
	private float AnimationRotateTime;

	// Token: 0x0400442F RID: 17455
	private const int TURNTABLE_GRID_SIZE = 8;

	// Token: 0x04004430 RID: 17456
	private const int ROTATE_DEFAULT_ANGLE = -90;

	// Token: 0x04004431 RID: 17457
	private const int ROTATE_GRID_ANGLE = -45;

	// Token: 0x04004432 RID: 17458
	private const int ROTATE_LOOP_ANIMATION_TIME = 500;

	// Token: 0x04004433 RID: 17459
	private const string TURNTABLE_ROTATE_PARAM = "TurntableRotate";

	// Token: 0x02007B67 RID: 31591
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04028943 RID: 166211
		public const int Grid1 = 0;

		// Token: 0x04028944 RID: 166212
		public const int Grid2 = 1;

		// Token: 0x04028945 RID: 166213
		public const int Grid3 = 2;

		// Token: 0x04028946 RID: 166214
		public const int Grid4 = 3;

		// Token: 0x04028947 RID: 166215
		public const int Grid5 = 4;

		// Token: 0x04028948 RID: 166216
		public const int Grid6 = 5;

		// Token: 0x04028949 RID: 166217
		public const int Grid7 = 6;

		// Token: 0x0402894A RID: 166218
		public const int Grid8 = 7;

		// Token: 0x0402894B RID: 166219
		public const int Rotator = 8;
	}
}
