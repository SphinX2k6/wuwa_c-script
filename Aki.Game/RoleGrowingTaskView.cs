using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x020012AA RID: 4778
[NullableContext(1)]
[Nullable(0)]
public class RoleGrowingTaskView : UiViewBase
{
	// Token: 0x06008321 RID: 33569 RVA: 0x001BE390 File Offset: 0x001BC590
	public RoleGrowingTaskView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008322 RID: 33570 RVA: 0x001BE39C File Offset: 0x001BC59C
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

	// Token: 0x06008323 RID: 33571 RVA: 0x001BE550 File Offset: 0x001BC750
	protected override UniTask OnBeforeStartAsync()
	{
		RoleGrowingTaskView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleGrowingTaskView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008324 RID: 33572 RVA: 0x001BE594 File Offset: 0x001BC794
	protected override void OnBeforeShow()
	{
		ActivityController.Instance.CheckIsActivityClose(null, new int?(this.ActivityBaseData.Id));
		this.RefreshView(this.CurrentIndex);
	}

	// Token: 0x06008325 RID: 33573 RVA: 0x001BE5D0 File Offset: 0x001BC7D0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.LongShanUpdate, new Action(this.RefreshTasks));
	}

	// Token: 0x06008326 RID: 33574 RVA: 0x001BE5EE File Offset: 0x001BC7EE
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.LongShanUpdate, new Action(this.RefreshTasks));
	}

	// Token: 0x06008327 RID: 33575 RVA: 0x001BE60C File Offset: 0x001BC80C
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

	// Token: 0x06008328 RID: 33576 RVA: 0x001BE714 File Offset: 0x001BC914
	private void RefreshTasks()
	{
		ActivityLongShanData activity = this.ActivityBaseData;
		int id = activity.StageIds[this.CurrentIndex];
		int progress = activity.GetProgress(id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "LongShanStage_ProgressPercentage", new <>z__ReadOnlySingleElementList<object>(progress));
		List<LongShanTaskInfo> list = activity.GetStageInfoById(id).Tasks.ToList<LongShanTaskInfo>();
		list.Sort((LongShanTaskInfo task1, LongShanTaskInfo task2) => activity.TaskSort(task1, task2));
		this.TaskScroll.RefreshByData(list, null, true);
	}

	// Token: 0x06008329 RID: 33577 RVA: 0x001BE7AB File Offset: 0x001BC9AB
	private LongShanTaskItem CreateTaskItem()
	{
		return new LongShanTaskItem();
	}

	// Token: 0x0600832A RID: 33578 RVA: 0x001BE7B2 File Offset: 0x001BC9B2
	private PageDot<int> InitPageDot()
	{
		return new PageDot<int>();
	}

	// Token: 0x0600832B RID: 33579 RVA: 0x001BE7B9 File Offset: 0x001BC9B9
	private void OnClickPre()
	{
		this.RefreshView(this.CurrentIndex - 1);
	}

	// Token: 0x0600832C RID: 33580 RVA: 0x001BE7CC File Offset: 0x001BC9CC
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

	// Token: 0x04003B18 RID: 15128
	[Nullable(2)]
	protected ActivityLongShanData ActivityBaseData;

	// Token: 0x04003B19 RID: 15129
	protected int CurrentIndex;

	// Token: 0x04003B1A RID: 15130
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04003B1B RID: 15131
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<PageDot<int>, int> PageDotLayout;

	// Token: 0x04003B1C RID: 15132
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericScrollViewNew<LongShanTaskItem, LongShanTaskInfo> TaskScroll;

	// Token: 0x020078C7 RID: 30919
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027CA2 RID: 162978
		public const int CaptionItem = 0;

		// Token: 0x04027CA3 RID: 162979
		public const int TxtName = 1;

		// Token: 0x04027CA4 RID: 162980
		public const int TxtProgress = 2;

		// Token: 0x04027CA5 RID: 162981
		public const int LabelFinish = 3;

		// Token: 0x04027CA6 RID: 162982
		public const int TaskParent = 4;

		// Token: 0x04027CA7 RID: 162983
		public const int BtnPre = 5;

		// Token: 0x04027CA8 RID: 162984
		public const int BtnNext = 6;

		// Token: 0x04027CA9 RID: 162985
		public const int PageDotLayout = 7;

		// Token: 0x04027CAA RID: 162986
		public const int SpriteIcon = 8;
	}
}
