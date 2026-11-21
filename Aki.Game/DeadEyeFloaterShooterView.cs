using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F3D RID: 3901
[NullableContext(1)]
[Nullable(0)]
public class DeadEyeFloaterShooterView : UiTickViewBase
{
	// Token: 0x06009BD2 RID: 39890 RVA: 0x002E3062 File Offset: 0x002E1262
	public DeadEyeFloaterShooterView(UiViewInfo ViewInfo) : base(ViewInfo)
	{
	}

	// Token: 0x06009BD3 RID: 39891 RVA: 0x002E3078 File Offset: 0x002E1278
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

	// Token: 0x06009BD4 RID: 39892 RVA: 0x002E3140 File Offset: 0x002E1340
	protected override UniTask OnBeforeStartAsync()
	{
		DeadEyeFloaterShooterView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DeadEyeFloaterShooterView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009BD5 RID: 39893 RVA: 0x002E3183 File Offset: 0x002E1383
	protected override void OnAfterShow()
	{
		DeadEyeAimItem aimItem = this.AimItem;
		if (aimItem == null)
		{
			return;
		}
		aimItem.ShowAsync().Forget<bool>();
	}

	// Token: 0x06009BD6 RID: 39894 RVA: 0x002E319C File Offset: 0x002E139C
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

	// Token: 0x06009BD7 RID: 39895 RVA: 0x002E3280 File Offset: 0x002E1480
	private UniTask InitAimItem()
	{
		DeadEyeFloaterShooterView.<InitAimItem>d__13 <InitAimItem>d__;
		<InitAimItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAimItem>d__.<>4__this = this;
		<InitAimItem>d__.<>1__state = -1;
		<InitAimItem>d__.<>t__builder.Start<DeadEyeFloaterShooterView.<InitAimItem>d__13>(ref <InitAimItem>d__);
		return <InitAimItem>d__.<>t__builder.Task;
	}

	// Token: 0x06009BD8 RID: 39896 RVA: 0x002E32C4 File Offset: 0x002E14C4
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

	// Token: 0x06009BD9 RID: 39897 RVA: 0x002E3317 File Offset: 0x002E1517
	private void ShowTargetItemImp()
	{
		if (this.PlayStartSequenceTargetItemIndex >= this.TargetItem.Count)
		{
			return;
		}
		this.PlayTargetItemStartSequence().ContinueWith(new Action(this.ShowTargetItemImp));
	}

	// Token: 0x06009BDA RID: 39898 RVA: 0x002E3348 File Offset: 0x002E1548
	private UniTask PlayTargetItemStartSequence()
	{
		DeadEyeFloaterShooterView.<PlayTargetItemStartSequence>d__16 <PlayTargetItemStartSequence>d__;
		<PlayTargetItemStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayTargetItemStartSequence>d__.<>4__this = this;
		<PlayTargetItemStartSequence>d__.<>1__state = -1;
		<PlayTargetItemStartSequence>d__.<>t__builder.Start<DeadEyeFloaterShooterView.<PlayTargetItemStartSequence>d__16>(ref <PlayTargetItemStartSequence>d__);
		return <PlayTargetItemStartSequence>d__.<>t__builder.Task;
	}

	// Token: 0x06009BDB RID: 39899 RVA: 0x002E338B File Offset: 0x002E158B
	protected override void OnAfterDestroy()
	{
		AudioSystem.Instance.PostEvent("play_sfx_motorcycle_dead_eye_slow_motion_end");
		DeadEyeModeModel.Instance.EnterNextStage();
	}

	// Token: 0x06009BDC RID: 39900 RVA: 0x002E33A8 File Offset: 0x002E15A8
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

	// Token: 0x06009BDD RID: 39901 RVA: 0x002E33F8 File Offset: 0x002E15F8
	private UniTask LaunchImp()
	{
		DeadEyeFloaterShooterView.<LaunchImp>d__19 <LaunchImp>d__;
		<LaunchImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LaunchImp>d__.<>4__this = this;
		<LaunchImp>d__.<>1__state = -1;
		<LaunchImp>d__.<>t__builder.Start<DeadEyeFloaterShooterView.<LaunchImp>d__19>(ref <LaunchImp>d__);
		return <LaunchImp>d__.<>t__builder.Task;
	}

	// Token: 0x04005D0D RID: 23821
	private const string END_AUDIO_NAME = "play_sfx_motorcycle_dead_eye_slow_motion_end";

	// Token: 0x04005D0E RID: 23822
	[Nullable(2)]
	private DeadEyeAimItem AimItem;

	// Token: 0x04005D0F RID: 23823
	private readonly List<DeadEyeFloaterShooterTargetItem> TargetItem = new List<DeadEyeFloaterShooterTargetItem>();

	// Token: 0x04005D10 RID: 23824
	private int PlayStartSequenceTargetItemIndex;

	// Token: 0x04005D11 RID: 23825
	private int CurrentLockedCount;

	// Token: 0x04005D12 RID: 23826
	[Nullable(2)]
	private LevelSequencePlayer ButtonSequencePlayer;

	// Token: 0x04005D13 RID: 23827
	private float CurrentDelayTime;

	// Token: 0x0200715D RID: 29021
	[NullableContext(0)]
	private class EViewComponent
	{
		// Token: 0x04024ED4 RID: 151252
		public const int AimItem = 0;

		// Token: 0x04024ED5 RID: 151253
		public const int AimTargetItemRoot = 1;

		// Token: 0x04024ED6 RID: 151254
		public const int LaunchBtn = 2;
	}
}
