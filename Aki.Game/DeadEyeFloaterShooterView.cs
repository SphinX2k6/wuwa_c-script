using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A7E RID: 6782
[NullableContext(1)]
[Nullable(0)]
public class DeadEyeFloaterShooterView : UiTickViewBase
{
	// Token: 0x0600C7C2 RID: 51138 RVA: 0x002D7F46 File Offset: 0x002D6146
	public DeadEyeFloaterShooterView(UiViewInfo ViewInfo) : base(ViewInfo)
	{
	}

	// Token: 0x0600C7C3 RID: 51139 RVA: 0x002D7F5C File Offset: 0x002D615C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnLaunchButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C7C4 RID: 51140 RVA: 0x002D8024 File Offset: 0x002D6224
	protected override UniTask OnBeforeStartAsync()
	{
		DeadEyeFloaterShooterView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DeadEyeFloaterShooterView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7C5 RID: 51141 RVA: 0x002D8067 File Offset: 0x002D6267
	protected override void OnAfterShow()
	{
		DeadEyeAimItem aimItem = this.AimItem;
		if (aimItem == null)
		{
			return;
		}
		aimItem.ShowAsync().Forget<bool>();
	}

	// Token: 0x0600C7C6 RID: 51142 RVA: 0x002D8080 File Offset: 0x002D6280
	protected override void OnTick(float delta)
	{
		this.CurrentLockedCount = 0;
		this.CurrentDelayTime += delta;
		foreach (DeadEyeFloaterShooterTargetItem deadEyeFloaterShooterTargetItem in this.TargetItem)
		{
			deadEyeFloaterShooterTargetItem.OnTick(delta);
			if (deadEyeFloaterShooterTargetItem.IsLocked)
			{
				this.CurrentLockedCount++;
			}
		}
		bool uiactive = this.CurrentLockedCount == this.TargetItem.Count;
		UUIButtonComponent button = base.GetButton(2);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(uiactive);
		}
		if ((double)this.CurrentDelayTime * TimeUtil.Instance.Millisecond * (double)DeadEyeModeModel.Instance.TimeConsumption >= (double)DeadEyeModeModel.Instance.MaxEnergy)
		{
			this.OnLaunchButtonClick();
		}
	}

	// Token: 0x0600C7C7 RID: 51143 RVA: 0x002D8164 File Offset: 0x002D6364
	private UniTask InitAimItem()
	{
		DeadEyeFloaterShooterView.<InitAimItem>d__13 <InitAimItem>d__;
		<InitAimItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAimItem>d__.<>4__this = this;
		<InitAimItem>d__.<>1__state = -1;
		<InitAimItem>d__.<>t__builder.Start<DeadEyeFloaterShooterView.<InitAimItem>d__13>(ref <InitAimItem>d__);
		return <InitAimItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7C8 RID: 51144 RVA: 0x002D81A8 File Offset: 0x002D63A8
	private UniTask InitTargetItems(IReadOnlyList<EntityHandle> targetEntityHandles, IReadOnlyList<Vector> targetLocations)
	{
		DeadEyeFloaterShooterView.<InitTargetItems>d__14 <InitTargetItems>d__;
		<InitTargetItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTargetItems>d__.<>4__this = this;
		<InitTargetItems>d__.targetEntityHandles = targetEntityHandles;
		<InitTargetItems>d__.targetLocations = targetLocations;
		<InitTargetItems>d__.<>1__state = -1;
		<InitTargetItems>d__.<>t__builder.Start<DeadEyeFloaterShooterView.<InitTargetItems>d__14>(ref <InitTargetItems>d__);
		return <InitTargetItems>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7C9 RID: 51145 RVA: 0x002D81FB File Offset: 0x002D63FB
	private void ShowTargetItemImp()
	{
		if (this.PlayStartSequenceTargetItemIndex >= this.TargetItem.Count)
		{
			return;
		}
		this.PlayTargetItemStartSequence().ContinueWith(new Action(this.ShowTargetItemImp));
	}

	// Token: 0x0600C7CA RID: 51146 RVA: 0x002D822C File Offset: 0x002D642C
	private UniTask PlayTargetItemStartSequence()
	{
		DeadEyeFloaterShooterView.<PlayTargetItemStartSequence>d__16 <PlayTargetItemStartSequence>d__;
		<PlayTargetItemStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayTargetItemStartSequence>d__.<>4__this = this;
		<PlayTargetItemStartSequence>d__.<>1__state = -1;
		<PlayTargetItemStartSequence>d__.<>t__builder.Start<DeadEyeFloaterShooterView.<PlayTargetItemStartSequence>d__16>(ref <PlayTargetItemStartSequence>d__);
		return <PlayTargetItemStartSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7CB RID: 51147 RVA: 0x002D826F File Offset: 0x002D646F
	protected override void OnAfterDestroy()
	{
		AudioSystem.Instance.PostEvent("play_sfx_motorcycle_dead_eye_slow_motion_end");
		DeadEyeModeModel.Instance.EnterNextStage();
	}

	// Token: 0x0600C7CC RID: 51148 RVA: 0x002D828C File Offset: 0x002D648C
	private void OnLaunchButtonClick()
	{
		if (DeadEyeModeModel.Instance.CurrentEnergy != 0f && this.CurrentLockedCount == 0)
		{
			return;
		}
		if (DeadEyeModeModel.Instance.CurDeadEyeModeStage == EDeadEyeModeStage.WaitSettlement)
		{
			return;
		}
		this.LaunchImp().ContinueWith(delegate()
		{
			base.CloseMe(null);
		});
	}

	// Token: 0x0600C7CD RID: 51149 RVA: 0x002D82DC File Offset: 0x002D64DC
	private UniTask LaunchImp()
	{
		DeadEyeFloaterShooterView.<LaunchImp>d__19 <LaunchImp>d__;
		<LaunchImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LaunchImp>d__.<>4__this = this;
		<LaunchImp>d__.<>1__state = -1;
		<LaunchImp>d__.<>t__builder.Start<DeadEyeFloaterShooterView.<LaunchImp>d__19>(ref <LaunchImp>d__);
		return <LaunchImp>d__.<>t__builder.Task;
	}

	// Token: 0x04005C3E RID: 23614
	private const string END_AUDIO_NAME = "play_sfx_motorcycle_dead_eye_slow_motion_end";

	// Token: 0x04005C3F RID: 23615
	[Nullable(2)]
	private DeadEyeAimItem AimItem;

	// Token: 0x04005C40 RID: 23616
	private readonly List<DeadEyeFloaterShooterTargetItem> TargetItem = new List<DeadEyeFloaterShooterTargetItem>();

	// Token: 0x04005C41 RID: 23617
	private int PlayStartSequenceTargetItemIndex;

	// Token: 0x04005C42 RID: 23618
	private int CurrentLockedCount;

	// Token: 0x04005C43 RID: 23619
	[Nullable(2)]
	private LevelSequencePlayer ButtonSequencePlayer;

	// Token: 0x04005C44 RID: 23620
	private float CurrentDelayTime;

	// Token: 0x02007FCE RID: 32718
	[NullableContext(0)]
	private class EViewComponent
	{
		// Token: 0x04029B97 RID: 170903
		public const int AimItem = 0;

		// Token: 0x04029B98 RID: 170904
		public const int AimTargetItemRoot = 1;

		// Token: 0x04029B99 RID: 170905
		public const int LaunchBtn = 2;
	}
}
