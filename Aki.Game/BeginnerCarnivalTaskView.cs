using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200065A RID: 1626
[NullableContext(1)]
[Nullable(0)]
public class BeginnerCarnivalTaskView : UiViewBase
{
	// Token: 0x06004B2C RID: 19244 RVA: 0x00198ECA File Offset: 0x001970CA
	public BeginnerCarnivalTaskView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06004B2D RID: 19245 RVA: 0x00198ED4 File Offset: 0x001970D4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickLeftBtn)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickRightBtn))
		};
	}

	// Token: 0x06004B2E RID: 19246 RVA: 0x00199004 File Offset: 0x00197204
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshBeginnerCarnivalTask, new Action<int>(this.RefreshBeginnerCarnivalTask));
		EventSystem.Instance.Add(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06004B2F RID: 19247 RVA: 0x0019903E File Offset: 0x0019723E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshBeginnerCarnivalTask, new Action<int>(this.RefreshBeginnerCarnivalTask));
		EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06004B30 RID: 19248 RVA: 0x00199078 File Offset: 0x00197278
	protected override UniTask OnBeforeStartAsync()
	{
		BeginnerCarnivalTaskView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BeginnerCarnivalTaskView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004B31 RID: 19249 RVA: 0x001990BB File Offset: 0x001972BB
	private BeginnerCarnivalTaskItem CreateItem()
	{
		return new BeginnerCarnivalTaskItem();
	}

	// Token: 0x06004B32 RID: 19250 RVA: 0x001990C2 File Offset: 0x001972C2
	protected override void OnStart()
	{
		this.TypeId = (int)this.OpenParam;
	}

	// Token: 0x06004B33 RID: 19251 RVA: 0x001990D5 File Offset: 0x001972D5
	protected override void OnBeforeShow()
	{
		this.RefreshViewByType(this.TypeId);
	}

	// Token: 0x06004B34 RID: 19252 RVA: 0x001990E4 File Offset: 0x001972E4
	private void RefreshViewByType(int type)
	{
		BeginnerCarnivalData data = BeginnerCarnivalController.Instance.GetBeginnerCarnivalData();
		List<int> taskIdListByTypeId = data.GetTaskIdListByTypeId(type);
		taskIdListByTypeId.Sort(delegate(int a, int b)
		{
			ActivityTaskState status = data.GetTaskDataById(a).Status;
			ActivityTaskState status2 = data.GetTaskDataById(b).Status;
			if (status == status2)
			{
				return a - b;
			}
			int num = (status == ActivityTaskState.ActivityTaskFinish) ? 0 : ((status == ActivityTaskState.ActivityTaskTaken) ? 2 : 1);
			int num2 = (status2 == ActivityTaskState.ActivityTaskFinish) ? 0 : ((status2 == ActivityTaskState.ActivityTaskTaken) ? 2 : 1);
			return num - num2;
		});
		this.ScrollView.RefreshByData(taskIdListByTypeId, null, false);
		this.ScrollView.PlayTurnAnimation();
		ValueTuple<int, int> progress = BeginnerCarnivalController.Instance.GetBeginnerCarnivalData().GetProgress(type);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BeginnerCarnivalCurrentProgress", new <>z__ReadOnlyArray<object>(new object[]
		{
			progress.Item1,
			progress.Item2
		}));
		NewbieCarnivalTaskType? newbieCarnivalTaskType = BeginnerCarnivalConfig.Instance.GetNewbieCarnivalTaskType(type);
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.SetTitleByTextIdAndArgNew(((newbieCarnivalTaskType != null) ? newbieCarnivalTaskType.GetValueOrDefault().Title : null) ?? string.Empty, Array.Empty<object>());
		}
		base.GetItem(6).SetUIActive(this.TypeId == 1);
		base.GetItem(7).SetUIActive(this.TypeId == 2);
		base.GetItem(8).SetUIActive(this.TypeId == 3);
		base.GetItem(9).SetUIActive(this.TypeId == 4);
	}

	// Token: 0x06004B35 RID: 19253 RVA: 0x0019922C File Offset: 0x0019742C
	private void OnClickLeftBtn()
	{
		if (TimeUtil.Instance.GetServerTimeStamp() < this.NextCanClickTime)
		{
			return;
		}
		this.TypeId--;
		if (this.TypeId < 1)
		{
			this.TypeId = 4;
		}
		this.RefreshViewByType(this.TypeId);
		this.NextCanClickTime = TimeUtil.Instance.GetServerTimeStamp() + 100.0;
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.StopSequenceByKey("Switch", false, false);
		}
		UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
		if (uiViewSequence2 == null)
		{
			return;
		}
		uiViewSequence2.PlaySequence("Switch", false, null);
	}

	// Token: 0x06004B36 RID: 19254 RVA: 0x001992C8 File Offset: 0x001974C8
	private void OnClickRightBtn()
	{
		if (TimeUtil.Instance.GetServerTimeStamp() < this.NextCanClickTime)
		{
			return;
		}
		this.TypeId++;
		if (this.TypeId > 4)
		{
			this.TypeId = 1;
		}
		this.RefreshViewByType(this.TypeId);
		this.NextCanClickTime = TimeUtil.Instance.GetServerTimeStamp() + 100.0;
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.StopSequenceByKey("Switch", false, false);
		}
		UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
		if (uiViewSequence2 == null)
		{
			return;
		}
		uiViewSequence2.PlaySequence("Switch", false, null);
	}

	// Token: 0x06004B37 RID: 19255 RVA: 0x00199363 File Offset: 0x00197563
	private void RefreshBeginnerCarnivalTask(int index)
	{
		this.RefreshViewByType(index);
	}

	// Token: 0x06004B38 RID: 19256 RVA: 0x0019936C File Offset: 0x0019756C
	private void OnActivityClose(IReadOnlySet<int> closeActivities)
	{
		if (closeActivities.Contains(BeginnerCarnivalController.Instance.ActivityId))
		{
			Action value = delegate()
			{
				UiManager.Instance.ResetToBattleView(null);
			};
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ActivityEnd);
			confirmBoxDataNew.FunctionMap.Add(1, value);
			confirmBoxDataNew.FunctionMap.Add(0, value);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
	}

	// Token: 0x040037B2 RID: 14258
	private const int MAX_TYPE = 4;

	// Token: 0x040037B3 RID: 14259
	private const int MIN_TYPE = 1;

	// Token: 0x040037B4 RID: 14260
	private int TypeId;

	// Token: 0x040037B5 RID: 14261
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040037B6 RID: 14262
	private double NextCanClickTime;

	// Token: 0x040037B7 RID: 14263
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<BeginnerCarnivalTaskItem, int> ScrollView;
}
