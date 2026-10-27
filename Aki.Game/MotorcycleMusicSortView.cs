using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022CB RID: 8907
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleMusicSortView : UiTickViewBase
{
	// Token: 0x060117D6 RID: 71638 RVA: 0x0044A027 File Offset: 0x00448227
	public MotorcycleMusicSortView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060117D7 RID: 71639 RVA: 0x0044A030 File Offset: 0x00448230
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

	// Token: 0x060117D8 RID: 71640 RVA: 0x0044A0B6 File Offset: 0x004482B6
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnMotorMusicSortDragCancel, new Action(this.OnMotorMusicSortDragCancel));
	}

	// Token: 0x060117D9 RID: 71641 RVA: 0x0044A0D4 File Offset: 0x004482D4
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

	// Token: 0x060117DA RID: 71642 RVA: 0x0044A0FD File Offset: 0x004482FD
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnMotorMusicSortDragCancel, new Action(this.OnMotorMusicSortDragCancel));
	}

	// Token: 0x060117DB RID: 71643 RVA: 0x0044A11C File Offset: 0x0044831C
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleMusicSortView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleMusicSortView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060117DC RID: 71644 RVA: 0x0044A15F File Offset: 0x0044835F
	private void OnDragBeginCallback(DragSortGridAbstract<int> item)
	{
		UUIItem item2 = base.GetItem(0);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x060117DD RID: 71645 RVA: 0x0044A173 File Offset: 0x00448373
	private void OnDragEndCallback(DragSortGridAbstract<int> item)
	{
		UUIItem item2 = base.GetItem(0);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(true);
	}

	// Token: 0x060117DE RID: 71646 RVA: 0x0044A187 File Offset: 0x00448387
	private MotorcycleMusicSortItem CreateItem()
	{
		return new MotorcycleMusicSortItem();
	}

	// Token: 0x060117DF RID: 71647 RVA: 0x0044A18E File Offset: 0x0044838E
	protected override void OnTick(float delta)
	{
		DragSortScrollView<MotorcycleMusicSortItem, int> scrollView = this.ScrollView;
		if (scrollView == null)
		{
			return;
		}
		scrollView.Tick(delta);
	}

	// Token: 0x060117E0 RID: 71648 RVA: 0x0044A1A1 File Offset: 0x004483A1
	protected override void OnAfterTick(float delta)
	{
	}

	// Token: 0x060117E1 RID: 71649 RVA: 0x0044A1A3 File Offset: 0x004483A3
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

	// Token: 0x060117E2 RID: 71650 RVA: 0x0044A1D4 File Offset: 0x004483D4
	private void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x040084CE RID: 33998
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private DragSortScrollView<MotorcycleMusicSortItem, int> ScrollView;

	// Token: 0x040084CF RID: 33999
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<List<int>> OnCallback;

	// Token: 0x02008844 RID: 34884
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402C470 RID: 181360
		public const int ItemCaption = 0;

		// Token: 0x0402C471 RID: 181361
		public const int BtnMask = 1;

		// Token: 0x0402C472 RID: 181362
		public const int SvDefault = 2;

		// Token: 0x0402C473 RID: 181363
		public const int Content = 3;

		// Token: 0x0402C474 RID: 181364
		public const int ListItem = 4;
	}
}
