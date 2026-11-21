using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017AF RID: 6063
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleMusicSortView : UiTickViewBase
{
	// Token: 0x0600EC6D RID: 60525 RVA: 0x00456D4F File Offset: 0x00454F4F
	public MotorcycleMusicSortView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EC6E RID: 60526 RVA: 0x00456D58 File Offset: 0x00454F58
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x0600EC6F RID: 60527 RVA: 0x00456DDE File Offset: 0x00454FDE
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnMotorMusicSortDragCancel, new Action(this.OnMotorMusicSortDragCancel));
	}

	// Token: 0x0600EC70 RID: 60528 RVA: 0x00456DFC File Offset: 0x00454FFC
	private void OnMotorMusicSortDragCancel()
	{
		DragSortScrollView<MotorcycleMusicSortItem, int> scrollView = this.ScrollView;
		if (scrollView != null && scrollView.IsDragging())
		{
			this.ScrollView.CancelDrag();
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600EC71 RID: 60529 RVA: 0x00456E25 File Offset: 0x00455025
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnMotorMusicSortDragCancel, new Action(this.OnMotorMusicSortDragCancel));
	}

	// Token: 0x0600EC72 RID: 60530 RVA: 0x00456E44 File Offset: 0x00455044
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleMusicSortView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleMusicSortView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EC73 RID: 60531 RVA: 0x00456E87 File Offset: 0x00455087
	private void OnDragBeginCallback(DragSortGridAbstract<int> item)
	{
		UUIItem item2 = base.GetItem(0);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0600EC74 RID: 60532 RVA: 0x00456E9B File Offset: 0x0045509B
	private void OnDragEndCallback(DragSortGridAbstract<int> item)
	{
		UUIItem item2 = base.GetItem(0);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(true);
	}

	// Token: 0x0600EC75 RID: 60533 RVA: 0x00456EAF File Offset: 0x004550AF
	private MotorcycleMusicSortItem CreateItem()
	{
		return new MotorcycleMusicSortItem();
	}

	// Token: 0x0600EC76 RID: 60534 RVA: 0x00456EB6 File Offset: 0x004550B6
	protected override void OnTick(float delta)
	{
		DragSortScrollView<MotorcycleMusicSortItem, int> scrollView = this.ScrollView;
		if (scrollView == null)
		{
			return;
		}
		scrollView.Tick(delta);
	}

	// Token: 0x0600EC77 RID: 60535 RVA: 0x00456EC9 File Offset: 0x004550C9
	protected override void OnAfterTick(float delta)
	{
	}

	// Token: 0x0600EC78 RID: 60536 RVA: 0x00456ECB File Offset: 0x004550CB
	protected override void OnBeforeDestroy()
	{
		DragSortScrollView<MotorcycleMusicSortItem, int> scrollView = this.ScrollView;
		if (scrollView != null && scrollView.HasChanged())
		{
			Action<List<int>> onCallback = this.OnCallback;
			if (onCallback == null)
			{
				return;
			}
			onCallback(this.ScrollView.GetSortedData());
		}
	}

	// Token: 0x0600EC79 RID: 60537 RVA: 0x00456EFC File Offset: 0x004550FC
	private void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400860C RID: 34316
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private DragSortScrollView<MotorcycleMusicSortItem, int> ScrollView;

	// Token: 0x0400860D RID: 34317
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<List<int>> OnCallback;

	// Token: 0x020079C8 RID: 31176
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027772 RID: 161650
		public const int ItemCaption = 0;

		// Token: 0x04027773 RID: 161651
		public const int BtnMask = 1;

		// Token: 0x04027774 RID: 161652
		public const int SvDefault = 2;

		// Token: 0x04027775 RID: 161653
		public const int Content = 3;

		// Token: 0x04027776 RID: 161654
		public const int ListItem = 4;
	}
}
