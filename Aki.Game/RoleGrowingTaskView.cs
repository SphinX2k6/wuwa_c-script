using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200075E RID: 1886
[NullableContext(1)]
[Nullable(0)]
public class RoleGrowingTaskView : UiViewBase
{
	// Token: 0x060056B8 RID: 22200 RVA: 0x001C7120 File Offset: 0x001C5320
	public RoleGrowingTaskView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060056B9 RID: 22201 RVA: 0x001C712C File Offset: 0x001C532C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickPre));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickNext));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060056BA RID: 22202 RVA: 0x001C72E0 File Offset: 0x001C54E0
	protected override UniTask OnBeforeStartAsync()
	{
		RoleGrowingTaskView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleGrowingTaskView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060056BB RID: 22203 RVA: 0x001C7324 File Offset: 0x001C5524
	protected override void OnBeforeShow()
	{
		ActivityController.Instance.CheckIsActivityClose(null, new int?(this.ActivityBaseData.Id));
		this.RefreshView(this.CurrentIndex);
	}

	// Token: 0x060056BC RID: 22204 RVA: 0x001C7360 File Offset: 0x001C5560
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.LongShanUpdate, new Action(this.RefreshTasks));
	}

	// Token: 0x060056BD RID: 22205 RVA: 0x001C737E File Offset: 0x001C557E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.LongShanUpdate, new Action(this.RefreshTasks));
	}

	// Token: 0x060056BE RID: 22206 RVA: 0x001C739C File Offset: 0x001C559C
	protected void RefreshView(int newIndex)
	{
		this.PageDotLayout.GetLayoutItemByIndex(this.CurrentIndex).UpdateShow(false);
		this.CurrentIndex = newIndex;
		this.PageDotLayout.GetLayoutItemByIndex(this.CurrentIndex).UpdateShow(true);
		int num = this.ActivityBaseData.StageIds[this.CurrentIndex];
		LongShanStage value = ConfigLongShanStageById.GetConfig(num, true).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.TitleDetail, Array.Empty<object>());
		this.SetSpriteByPath(value.Picture, base.GetSprite(8), false, null, null);
		base.GetButton(5).RootUIComp.Get().SetUIActive(this.CurrentIndex > 0);
		base.GetButton(6).RootUIComp.Get().SetUIActive(this.CurrentIndex < this.ActivityBaseData.StageIds.Length - 1);
		this.RefreshTasks();
		this.ActivityBaseData.SaveNewStageFlag(num);
	}

	// Token: 0x060056BF RID: 22207 RVA: 0x001C74A4 File Offset: 0x001C56A4
	private void RefreshTasks()
	{
		ActivityLongShanData activity = this.ActivityBaseData;
		int id = activity.StageIds[this.CurrentIndex];
		int progress = activity.GetProgress(id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "LongShanStage_ProgressPercentage", new <>z__ReadOnlySingleElementList<object>(progress));
		List<LongShanTaskInfo> list = new List<LongShanTaskInfo>(activity.GetStageInfoById(id).Tasks);
		list.Sort((LongShanTaskInfo task1, LongShanTaskInfo task2) => activity.TaskSort(task1, task2));
		this.TaskScroll.RefreshByData(list, null, true);
	}

	// Token: 0x060056C0 RID: 22208 RVA: 0x001C753B File Offset: 0x001C573B
	private LongShanTaskItem CreateTaskItem()
	{
		return new LongShanTaskItem();
	}

	// Token: 0x060056C1 RID: 22209 RVA: 0x001C7542 File Offset: 0x001C5742
	private PageDot<int> InitPageDot()
	{
		return new PageDot<int>();
	}

	// Token: 0x060056C2 RID: 22210 RVA: 0x001C7549 File Offset: 0x001C5749
	private void OnClickPre()
	{
		this.RefreshView(this.CurrentIndex - 1);
	}

	// Token: 0x060056C3 RID: 22211 RVA: 0x001C755C File Offset: 0x001C575C
	private void OnClickNext()
	{
		int num = this.ActivityBaseData.StageIds[this.CurrentIndex + 1];
		if (this.ActivityBaseData.GetStageInfoById(num) != null)
		{
			this.RefreshView(this.CurrentIndex + 1);
			return;
		}
		ActivityLongShanController.Instance.ShowUnlockTip(num);
	}

	// Token: 0x04003BB0 RID: 15280
	[Nullable(2)]
	protected ActivityLongShanData ActivityBaseData;

	// Token: 0x04003BB1 RID: 15281
	protected int CurrentIndex;

	// Token: 0x04003BB2 RID: 15282
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04003BB3 RID: 15283
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<PageDot<int>, int> PageDotLayout;

	// Token: 0x04003BB4 RID: 15284
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericScrollViewNew<LongShanTaskItem, LongShanTaskInfo> TaskScroll;

	// Token: 0x02006A51 RID: 27217
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022FD0 RID: 143312
		public const int CaptionItem = 0;

		// Token: 0x04022FD1 RID: 143313
		public const int TxtName = 1;

		// Token: 0x04022FD2 RID: 143314
		public const int TxtProgress = 2;

		// Token: 0x04022FD3 RID: 143315
		public const int LabelFinish = 3;

		// Token: 0x04022FD4 RID: 143316
		public const int TaskParent = 4;

		// Token: 0x04022FD5 RID: 143317
		public const int BtnPre = 5;

		// Token: 0x04022FD6 RID: 143318
		public const int BtnNext = 6;

		// Token: 0x04022FD7 RID: 143319
		public const int PageDotLayout = 7;

		// Token: 0x04022FD8 RID: 143320
		public const int SpriteIcon = 8;
	}
}
