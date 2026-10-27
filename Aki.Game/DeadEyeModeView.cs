using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A7F RID: 6783
[NullableContext(2)]
[Nullable(0)]
public class DeadEyeModeView : UiTickViewBase
{
	// Token: 0x0600C7CF RID: 51151 RVA: 0x002D8328 File Offset: 0x002D6528
	[NullableContext(1)]
	public DeadEyeModeView(UiViewInfo UiViewInfo) : base(UiViewInfo)
	{
	}

	// Token: 0x0600C7D0 RID: 51152 RVA: 0x002D833C File Offset: 0x002D653C
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

	// Token: 0x0600C7D1 RID: 51153 RVA: 0x002D8468 File Offset: 0x002D6668
	protected override UniTask OnBeforeStartAsync()
	{
		DeadEyeModeView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DeadEyeModeView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7D2 RID: 51154 RVA: 0x002D84AB File Offset: 0x002D66AB
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

	// Token: 0x0600C7D3 RID: 51155 RVA: 0x002D84DA File Offset: 0x002D66DA
	protected override void OnAfterDestroy()
	{
		EventSystem.Instance.Remove(EEventName.DeadEyeModeTargetPointLocked, new Action(this.OnTargetPointLocked));
		DeadEyeModeModel.Instance.EnterNextStage();
	}

	// Token: 0x0600C7D4 RID: 51156 RVA: 0x002D8504 File Offset: 0x002D6704
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

	// Token: 0x0600C7D5 RID: 51157 RVA: 0x002D8580 File Offset: 0x002D6780
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

	// Token: 0x0600C7D6 RID: 51158 RVA: 0x002D8658 File Offset: 0x002D6858
	private UniTask InitAimItem()
	{
		DeadEyeModeView.<InitAimItem>d__15 <InitAimItem>d__;
		<InitAimItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAimItem>d__.<>4__this = this;
		<InitAimItem>d__.<>1__state = -1;
		<InitAimItem>d__.<>t__builder.Start<DeadEyeModeView.<InitAimItem>d__15>(ref <InitAimItem>d__);
		return <InitAimItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7D7 RID: 51159 RVA: 0x002D869C File Offset: 0x002D689C
	private UniTask InitProgressItem()
	{
		DeadEyeModeView.<InitProgressItem>d__16 <InitProgressItem>d__;
		<InitProgressItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitProgressItem>d__.<>4__this = this;
		<InitProgressItem>d__.<>1__state = -1;
		<InitProgressItem>d__.<>t__builder.Start<DeadEyeModeView.<InitProgressItem>d__16>(ref <InitProgressItem>d__);
		return <InitProgressItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7D8 RID: 51160 RVA: 0x002D86E0 File Offset: 0x002D68E0
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

	// Token: 0x0600C7D9 RID: 51161 RVA: 0x002D8734 File Offset: 0x002D6934
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

	// Token: 0x0600C7DA RID: 51162 RVA: 0x002D8786 File Offset: 0x002D6986
	private void ShowTargetItemImp()
	{
		if (this.PlayStartSequenceTargetItemIndex >= this.TargetItem.Count)
		{
			return;
		}
		this.PlayTargetItemStartSequence().ContinueWith(new Action(this.ShowTargetItemImp));
	}

	// Token: 0x0600C7DB RID: 51163 RVA: 0x002D87B4 File Offset: 0x002D69B4
	private UniTask PlayTargetItemStartSequence()
	{
		DeadEyeModeView.<PlayTargetItemStartSequence>d__20 <PlayTargetItemStartSequence>d__;
		<PlayTargetItemStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayTargetItemStartSequence>d__.<>4__this = this;
		<PlayTargetItemStartSequence>d__.<>1__state = -1;
		<PlayTargetItemStartSequence>d__.<>t__builder.Start<DeadEyeModeView.<PlayTargetItemStartSequence>d__20>(ref <PlayTargetItemStartSequence>d__);
		return <PlayTargetItemStartSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7DC RID: 51164 RVA: 0x002D87F8 File Offset: 0x002D69F8
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

	// Token: 0x0600C7DD RID: 51165 RVA: 0x002D8848 File Offset: 0x002D6A48
	private UniTask LaunchImp()
	{
		DeadEyeModeView.<LaunchImp>d__22 <LaunchImp>d__;
		<LaunchImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LaunchImp>d__.<>4__this = this;
		<LaunchImp>d__.<>1__state = -1;
		<LaunchImp>d__.<>t__builder.Start<DeadEyeModeView.<LaunchImp>d__22>(ref <LaunchImp>d__);
		return <LaunchImp>d__.<>t__builder.Task;
	}

	// Token: 0x04005C45 RID: 23621
	private DeadEyeAimItem AimItem;

	// Token: 0x04005C46 RID: 23622
	private DeadEyeProgressItem DeadEyeProgressItem;

	// Token: 0x04005C47 RID: 23623
	[Nullable(1)]
	private readonly List<DeadEyeTargetItem> TargetItem = new List<DeadEyeTargetItem>();

	// Token: 0x04005C48 RID: 23624
	private int PlayStartSequenceTargetItemIndex;

	// Token: 0x04005C49 RID: 23625
	private int CurrentLockedCount;

	// Token: 0x04005C4A RID: 23626
	private LevelSequencePlayer ButtonSequencePlayer;

	// Token: 0x04005C4B RID: 23627
	private LevelSequencePlayer TipsSequencePlayer;

	// Token: 0x02007FD4 RID: 32724
	[NullableContext(0)]
	private class EViewComponent
	{
		// Token: 0x04029BB2 RID: 170930
		public const int AimItem = 0;

		// Token: 0x04029BB3 RID: 170931
		public const int AimTargetItemRoot = 1;

		// Token: 0x04029BB4 RID: 170932
		public const int ProgressItem = 2;

		// Token: 0x04029BB5 RID: 170933
		public const int ProgressItem2 = 3;

		// Token: 0x04029BB6 RID: 170934
		public const int AllLockedTips = 4;

		// Token: 0x04029BB7 RID: 170935
		public const int LaunchBtn = 5;
	}
}
