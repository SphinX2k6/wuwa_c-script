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

// Token: 0x020011A6 RID: 4518
[NullableContext(1)]
[Nullable(0)]
public class BeginnerCarnivalTaskView : UiViewBase
{
	// Token: 0x06007795 RID: 30613 RVA: 0x001902E6 File Offset: 0x0018E4E6
	public BeginnerCarnivalTaskView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007796 RID: 30614 RVA: 0x001902F0 File Offset: 0x0018E4F0
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

	// Token: 0x06007797 RID: 30615 RVA: 0x00190420 File Offset: 0x0018E620
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshBeginnerCarnivalTask, new Action<int>(this.RefreshBeginnerCarnivalTask));
		EventSystem.Instance.Add(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06007798 RID: 30616 RVA: 0x0019045A File Offset: 0x0018E65A
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshBeginnerCarnivalTask, new Action<int>(this.RefreshBeginnerCarnivalTask));
		EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06007799 RID: 30617 RVA: 0x00190494 File Offset: 0x0018E694
	protected override UniTask OnBeforeStartAsync()
	{
		BeginnerCarnivalTaskView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BeginnerCarnivalTaskView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600779A RID: 30618 RVA: 0x001904D7 File Offset: 0x0018E6D7
	private BeginnerCarnivalTaskItem CreateItem()
	{
		return new BeginnerCarnivalTaskItem();
	}

	// Token: 0x0600779B RID: 30619 RVA: 0x001904DE File Offset: 0x0018E6DE
	protected override void OnStart()
	{
		this.TypeId = (int)this.OpenParam;
	}

	// Token: 0x0600779C RID: 30620 RVA: 0x001904F1 File Offset: 0x0018E6F1
	protected override void OnBeforeShow()
	{
		this.RefreshViewByType(this.TypeId);
	}

	// Token: 0x0600779D RID: 30621 RVA: 0x00190500 File Offset: 0x0018E700
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

	// Token: 0x0600779E RID: 30622 RVA: 0x00190648 File Offset: 0x0018E848
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

	// Token: 0x0600779F RID: 30623 RVA: 0x001906E4 File Offset: 0x0018E8E4
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

	// Token: 0x060077A0 RID: 30624 RVA: 0x0019077F File Offset: 0x0018E97F
	private void RefreshBeginnerCarnivalTask(int index)
	{
		this.RefreshViewByType(index);
	}

	// Token: 0x060077A1 RID: 30625 RVA: 0x00190788 File Offset: 0x0018E988
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

	// Token: 0x04003719 RID: 14105
	private const int MAX_TYPE = 4;

	// Token: 0x0400371A RID: 14106
	private const int MIN_TYPE = 1;

	// Token: 0x0400371B RID: 14107
	private int TypeId;

	// Token: 0x0400371C RID: 14108
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400371D RID: 14109
	private double NextCanClickTime;

	// Token: 0x0400371E RID: 14110
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<BeginnerCarnivalTaskItem, int> ScrollView;
}
