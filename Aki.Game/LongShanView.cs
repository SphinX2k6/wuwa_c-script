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

// Token: 0x020012A7 RID: 4775
[NullableContext(1)]
[Nullable(0)]
public class LongShanView : UiViewBase
{
	// Token: 0x060082F7 RID: 33527 RVA: 0x001BD86B File Offset: 0x001BBA6B
	public LongShanView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060082F8 RID: 33528 RVA: 0x001BD874 File Offset: 0x001BBA74
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
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
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
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

	// Token: 0x060082F9 RID: 33529 RVA: 0x001BDA47 File Offset: 0x001BBC47
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.LongShanUpdate, new Action(this.RefreshTasks));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x060082FA RID: 33530 RVA: 0x001BDA81 File Offset: 0x001BBC81
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.LongShanUpdate, new Action(this.RefreshTasks));
		EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x060082FB RID: 33531 RVA: 0x001BDABC File Offset: 0x001BBCBC
	protected override UniTask OnBeforeStartAsync()
	{
		LongShanView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LongShanView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060082FC RID: 33532 RVA: 0x001BDB00 File Offset: 0x001BBD00
	protected override void OnBeforeShow()
	{
		this.RefreshTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTimerRefresh), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		this.RefreshView(this.CurrentIndex);
		this.OnTimerRefresh(0f);
	}

	// Token: 0x060082FD RID: 33533 RVA: 0x001BDB53 File Offset: 0x001BBD53
	protected override void OnBeforeHide()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.RefreshTimer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
			this.RefreshTimer = null;
		}
	}

	// Token: 0x060082FE RID: 33534 RVA: 0x001BDB80 File Offset: 0x001BBD80
	private void OnTimerRefresh(float _)
	{
		if (!this.ActivityBaseData.CheckIfInOpenTime())
		{
			base.CloseMe(null);
			return;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = Math.Max((double)this.ActivityBaseData.EndOpenTime - serverTime, 1.0);
		ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> timeTypeData = this.GetTimeTypeData(num);
		string item = TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(timeTypeData.Item1), new CommonDefine.ETimeType?(timeTypeData.Item2)).CountDownText ?? "";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "ActivityRemainingTime", new <>z__ReadOnlySingleElementList<object>(item));
	}

	// Token: 0x060082FF RID: 33535 RVA: 0x001BDC20 File Offset: 0x001BBE20
	[NullableContext(0)]
	private ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> GetTimeTypeData(double remainTime)
	{
		if (remainTime > 86400.0)
		{
			return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Day, CommonDefine.ETimeType.Hour);
		}
		if (remainTime > 3600.0)
		{
			return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Hour, CommonDefine.ETimeType.Minute);
		}
		if (remainTime > 60.0)
		{
			return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Minute, CommonDefine.ETimeType.Second);
		}
		return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Second, CommonDefine.ETimeType.Second);
	}

	// Token: 0x06008300 RID: 33536 RVA: 0x001BDC70 File Offset: 0x001BBE70
	private LongShanTaskItem CreateTaskItem()
	{
		return new LongShanTaskItem();
	}

	// Token: 0x06008301 RID: 33537 RVA: 0x001BDC77 File Offset: 0x001BBE77
	private PageDot<int> InitPageDot()
	{
		return new PageDot<int>();
	}

	// Token: 0x06008302 RID: 33538 RVA: 0x001BDC80 File Offset: 0x001BBE80
	public void RefreshView(int newIndex)
	{
		this.PageDotLayout.GetLayoutItemByIndex(this.CurrentIndex).UpdateShow(false);
		this.CurrentIndex = newIndex;
		this.PageDotLayout.GetLayoutItemByIndex(this.CurrentIndex).UpdateShow(true);
		int num = this.ActivityBaseData.StageIds[this.CurrentIndex];
		this.ActivityBaseData.SaveNewStageFlag(num);
		LongShanStage value = ConfigLongShanStageById.GetConfig(num, true).Value;
		base.SetTextureByPath(value.Picture, base.GetTexture(9), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.TitleDetail, Array.Empty<object>());
		this.RefreshTasks();
		base.GetButton(5).RootUIComp.Get().SetUIActive(this.CurrentIndex > 0);
		base.GetButton(6).RootUIComp.Get().SetUIActive(this.CurrentIndex < this.ActivityBaseData.StageIds.Length - 1);
	}

	// Token: 0x06008303 RID: 33539 RVA: 0x001BDD88 File Offset: 0x001BBF88
	private int TaskSort(LongShanTaskInfo a, LongShanTaskInfo b)
	{
		if (a.IsTaken != b.IsTaken)
		{
			if (!a.IsTaken)
			{
				return -1;
			}
			return 1;
		}
		else if (a.IsFinished != b.IsFinished)
		{
			if (!a.IsFinished)
			{
				return 1;
			}
			return -1;
		}
		else
		{
			int sortId = ConfigLongShanTaskById.GetConfig(a.Id, true).Value.SortId;
			int sortId2 = ConfigLongShanTaskById.GetConfig(b.Id, true).Value.SortId;
			if (sortId != sortId2)
			{
				return sortId - sortId2;
			}
			return a.Id - b.Id;
		}
	}

	// Token: 0x06008304 RID: 33540 RVA: 0x001BDE18 File Offset: 0x001BC018
	private void RefreshTasks()
	{
		int id = this.ActivityBaseData.StageIds[this.CurrentIndex];
		int progress = this.ActivityBaseData.GetProgress(id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "LongShanStage_ProgressPercentage", new <>z__ReadOnlySingleElementList<object>(progress));
		List<LongShanTaskInfo> list = this.ActivityBaseData.GetStageInfoById(id).Tasks.ToList<LongShanTaskInfo>();
		list.Sort(new Comparison<LongShanTaskInfo>(this.TaskSort));
		GenericScrollViewNew<LongShanTaskItem, LongShanTaskInfo> taskScroll = this.TaskScroll;
		if (taskScroll == null)
		{
			return;
		}
		taskScroll.RefreshByData(list, null, true);
	}

	// Token: 0x06008305 RID: 33541 RVA: 0x001BDEA2 File Offset: 0x001BC0A2
	private void OnClickPre()
	{
		this.RefreshView(this.CurrentIndex - 1);
	}

	// Token: 0x06008306 RID: 33542 RVA: 0x001BDEB4 File Offset: 0x001BC0B4
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

	// Token: 0x06008307 RID: 33543 RVA: 0x001BDF00 File Offset: 0x001BC100
	private void OpenHelpView()
	{
		int helpId = this.ActivityBaseData.GetHelpId();
		HelpController.Instance.OpenHelpById(helpId);
	}

	// Token: 0x06008308 RID: 33544 RVA: 0x001BDF24 File Offset: 0x001BC124
	private void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x06008309 RID: 33545 RVA: 0x001BDF30 File Offset: 0x001BC130
	private void OnActivityClose(IReadOnlySet<int> closeActivities)
	{
		if (closeActivities.Contains(this.ActivityBaseData.Id))
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ActivityEnd);
			confirmBoxDataNew.FunctionMap[1] = new Action(this.<OnActivityClose>g__ConfirmCallback|25_0);
			confirmBoxDataNew.FunctionMap[0] = new Action(this.<OnActivityClose>g__ConfirmCallback|25_0);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
	}

	// Token: 0x0600830A RID: 33546 RVA: 0x001BDF94 File Offset: 0x001BC194
	[CompilerGenerated]
	private void <OnActivityClose>g__ConfirmCallback|25_0()
	{
		base.CloseMe(null);
	}

	// Token: 0x04003B0D RID: 15117
	protected ActivityLongShanData ActivityBaseData;

	// Token: 0x04003B0E RID: 15118
	[Nullable(2)]
	private TimerHandle RefreshTimer;

	// Token: 0x04003B0F RID: 15119
	private int CurrentIndex;

	// Token: 0x04003B10 RID: 15120
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003B11 RID: 15121
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PageDot<int>, int> PageDotLayout;

	// Token: 0x04003B12 RID: 15122
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<LongShanTaskItem, LongShanTaskInfo> TaskScroll;

	// Token: 0x020078C1 RID: 30913
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027C86 RID: 162950
		public const int CaptionItem = 0;

		// Token: 0x04027C87 RID: 162951
		public const int TxtName = 1;

		// Token: 0x04027C88 RID: 162952
		public const int TxtProgress = 2;

		// Token: 0x04027C89 RID: 162953
		public const int LabelFinish = 3;

		// Token: 0x04027C8A RID: 162954
		public const int TaskParent = 4;

		// Token: 0x04027C8B RID: 162955
		public const int BtnPre = 5;

		// Token: 0x04027C8C RID: 162956
		public const int BtnNext = 6;

		// Token: 0x04027C8D RID: 162957
		public const int PageDotLayout = 7;

		// Token: 0x04027C8E RID: 162958
		public const int TxtTime = 8;

		// Token: 0x04027C8F RID: 162959
		public const int TexPicture = 9;
	}
}
