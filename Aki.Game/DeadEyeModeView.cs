using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F3E RID: 3902
[NullableContext(2)]
[Nullable(0)]
public class DeadEyeModeView : UiTickViewBase
{
	// Token: 0x06009BDF RID: 39903 RVA: 0x002E3444 File Offset: 0x002E1644
	[NullableContext(1)]
	public DeadEyeModeView(UiViewInfo UiViewInfo) : base(UiViewInfo)
	{
	}

	// Token: 0x06009BE0 RID: 39904 RVA: 0x002E3458 File Offset: 0x002E1658
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
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
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnLaunchButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009BE1 RID: 39905 RVA: 0x002E3584 File Offset: 0x002E1784
	protected override UniTask OnBeforeStartAsync()
	{
		DeadEyeModeView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DeadEyeModeView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009BE2 RID: 39906 RVA: 0x002E35C7 File Offset: 0x002E17C7
	protected override void OnAfterShow()
	{
		this.ShowTargetItemList();
		DeadEyeProgressItem deadEyeProgressItem = this.DeadEyeProgressItem;
		if (deadEyeProgressItem != null)
		{
			deadEyeProgressItem.Show(null);
		}
		DeadEyeAimItem aimItem = this.AimItem;
		if (aimItem == null)
		{
			return;
		}
		aimItem.ShowAsync().Forget<bool>();
	}

	// Token: 0x06009BE3 RID: 39907 RVA: 0x002E35F6 File Offset: 0x002E17F6
	protected override void OnAfterDestroy()
	{
		EventSystem.Instance.Remove(EEventName.DeadEyeModeTargetPointLocked, new Action(this.OnTargetPointLocked));
		DeadEyeModeModel.Instance.EnterNextStage();
	}

	// Token: 0x06009BE4 RID: 39908 RVA: 0x002E3620 File Offset: 0x002E1820
	protected override void OnTick(float delta)
	{
		foreach (DeadEyeTargetItem deadEyeTargetItem in this.TargetItem)
		{
			deadEyeTargetItem.OnTick(delta);
		}
		DeadEyeProgressItem deadEyeProgressItem = this.DeadEyeProgressItem;
		if (deadEyeProgressItem != null)
		{
			deadEyeProgressItem.OnTick(delta);
		}
		if (DeadEyeModeModel.Instance.CurrentEnergy == 0f)
		{
			this.OnLaunchButtonClick();
		}
	}

	// Token: 0x06009BE5 RID: 39909 RVA: 0x002E369C File Offset: 0x002E189C
	private void OnTargetPointLocked()
	{
		this.CurrentLockedCount = 0;
		using (List<DeadEyeTargetItem>.Enumerator enumerator = this.TargetItem.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsLocked)
				{
					this.CurrentLockedCount++;
				}
			}
		}
		bool flag = this.CurrentLockedCount == this.TargetItem.Count;
		UUIButtonComponent button = base.GetButton(5);
		if (button != null)
		{
			button.SetEnable(this.CurrentLockedCount > 0);
		}
		if (flag && DeadEyeModeModel.Instance.CurDeadEyeModeStage == EDeadEyeModeStage.AimInput)
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			LevelSequencePlayer tipsSequencePlayer = this.TipsSequencePlayer;
			if (tipsSequencePlayer == null)
			{
				return;
			}
			tipsSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
	}

	// Token: 0x06009BE6 RID: 39910 RVA: 0x002E3774 File Offset: 0x002E1974
	private UniTask InitAimItem()
	{
		DeadEyeModeView.<InitAimItem>d__15 <InitAimItem>d__;
		<InitAimItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAimItem>d__.<>4__this = this;
		<InitAimItem>d__.<>1__state = -1;
		<InitAimItem>d__.<>t__builder.Start<DeadEyeModeView.<InitAimItem>d__15>(ref <InitAimItem>d__);
		return <InitAimItem>d__.<>t__builder.Task;
	}

	// Token: 0x06009BE7 RID: 39911 RVA: 0x002E37B8 File Offset: 0x002E19B8
	private UniTask InitProgressItem()
	{
		DeadEyeModeView.<InitProgressItem>d__16 <InitProgressItem>d__;
		<InitProgressItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitProgressItem>d__.<>4__this = this;
		<InitProgressItem>d__.<>1__state = -1;
		<InitProgressItem>d__.<>t__builder.Start<DeadEyeModeView.<InitProgressItem>d__16>(ref <InitProgressItem>d__);
		return <InitProgressItem>d__.<>t__builder.Task;
	}

	// Token: 0x06009BE8 RID: 39912 RVA: 0x002E37FC File Offset: 0x002E19FC
	[NullableContext(1)]
	private UniTask InitTargetItems(IEnumerable<EntityHandle> targetEntityHandles, IEnumerable<Vector> targetLocations)
	{
		DeadEyeModeView.<InitTargetItems>d__17 <InitTargetItems>d__;
		<InitTargetItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTargetItems>d__.<>4__this = this;
		<InitTargetItems>d__.targetEntityHandles = targetEntityHandles;
		<InitTargetItems>d__.targetLocations = targetLocations;
		<InitTargetItems>d__.<>1__state = -1;
		<InitTargetItems>d__.<>t__builder.Start<DeadEyeModeView.<InitTargetItems>d__17>(ref <InitTargetItems>d__);
		return <InitTargetItems>d__.<>t__builder.Task;
	}

	// Token: 0x06009BE9 RID: 39913 RVA: 0x002E3850 File Offset: 0x002E1A50
	private void ShowTargetItemList()
	{
		this.TargetItem.Sort(delegate(DeadEyeTargetItem a, DeadEyeTargetItem b)
		{
			double x = a.GetScreenPositionWithoutClamp(null).X;
			double x2 = b.GetScreenPositionWithoutClamp(null).X;
			if (x < x2)
			{
				return -1;
			}
			if (x > x2)
			{
				return 1;
			}
			return 0;
		});
		this.PlayStartSequenceTargetItemIndex = 0;
		if (this.TargetItem.Count == 0)
		{
			return;
		}
		this.ShowTargetItemImp();
	}

	// Token: 0x06009BEA RID: 39914 RVA: 0x002E38A2 File Offset: 0x002E1AA2
	private void ShowTargetItemImp()
	{
		if (this.PlayStartSequenceTargetItemIndex >= this.TargetItem.Count)
		{
			return;
		}
		this.PlayTargetItemStartSequence().ContinueWith(new Action(this.ShowTargetItemImp));
	}

	// Token: 0x06009BEB RID: 39915 RVA: 0x002E38D0 File Offset: 0x002E1AD0
	private UniTask PlayTargetItemStartSequence()
	{
		DeadEyeModeView.<PlayTargetItemStartSequence>d__20 <PlayTargetItemStartSequence>d__;
		<PlayTargetItemStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayTargetItemStartSequence>d__.<>4__this = this;
		<PlayTargetItemStartSequence>d__.<>1__state = -1;
		<PlayTargetItemStartSequence>d__.<>t__builder.Start<DeadEyeModeView.<PlayTargetItemStartSequence>d__20>(ref <PlayTargetItemStartSequence>d__);
		return <PlayTargetItemStartSequence>d__.<>t__builder.Task;
	}

	// Token: 0x06009BEC RID: 39916 RVA: 0x002E3914 File Offset: 0x002E1B14
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

	// Token: 0x06009BED RID: 39917 RVA: 0x002E3964 File Offset: 0x002E1B64
	private UniTask LaunchImp()
	{
		DeadEyeModeView.<LaunchImp>d__22 <LaunchImp>d__;
		<LaunchImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LaunchImp>d__.<>4__this = this;
		<LaunchImp>d__.<>1__state = -1;
		<LaunchImp>d__.<>t__builder.Start<DeadEyeModeView.<LaunchImp>d__22>(ref <LaunchImp>d__);
		return <LaunchImp>d__.<>t__builder.Task;
	}

	// Token: 0x04005D14 RID: 23828
	private DeadEyeAimItem AimItem;

	// Token: 0x04005D15 RID: 23829
	private DeadEyeProgressItem DeadEyeProgressItem;

	// Token: 0x04005D16 RID: 23830
	[Nullable(1)]
	private readonly List<DeadEyeTargetItem> TargetItem = new List<DeadEyeTargetItem>();

	// Token: 0x04005D17 RID: 23831
	private int PlayStartSequenceTargetItemIndex;

	// Token: 0x04005D18 RID: 23832
	private int CurrentLockedCount;

	// Token: 0x04005D19 RID: 23833
	private LevelSequencePlayer ButtonSequencePlayer;

	// Token: 0x04005D1A RID: 23834
	private LevelSequencePlayer TipsSequencePlayer;

	// Token: 0x02007163 RID: 29027
	[NullableContext(0)]
	private class EViewComponent
	{
		// Token: 0x04024EEF RID: 151279
		public const int AimItem = 0;

		// Token: 0x04024EF0 RID: 151280
		public const int AimTargetItemRoot = 1;

		// Token: 0x04024EF1 RID: 151281
		public const int ProgressItem = 2;

		// Token: 0x04024EF2 RID: 151282
		public const int ProgressItem2 = 3;

		// Token: 0x04024EF3 RID: 151283
		public const int AllLockedTips = 4;

		// Token: 0x04024EF4 RID: 151284
		public const int LaunchBtn = 5;
	}
}
