using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B6D RID: 7021
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchPermanentRewardView : UiViewBase
{
	// Token: 0x0600D0D1 RID: 53457 RVA: 0x002FB591 File Offset: 0x002F9791
	public FloroRanchPermanentRewardView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D0D2 RID: 53458 RVA: 0x002FB59C File Offset: 0x002F979C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600D0D3 RID: 53459 RVA: 0x002FB628 File Offset: 0x002F9828
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchPermanentRewardView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchPermanentRewardView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D0D4 RID: 53460 RVA: 0x002FB66B File Offset: 0x002F986B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTaskLayout));
	}

	// Token: 0x0600D0D5 RID: 53461 RVA: 0x002FB689 File Offset: 0x002F9889
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTaskLayout));
	}

	// Token: 0x0600D0D6 RID: 53462 RVA: 0x002FB6A8 File Offset: 0x002F98A8
	private void OnRefreshTaskLayout(int activityId)
	{
		FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true);
		if (activityData.Id != activityId)
		{
			return;
		}
		List<FloroRanchTaskData> permanentTaskData = activityData.GetPermanentTaskData();
		this.TaskLayout.RefreshByData(permanentTaskData, null, true);
		EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, activityData.Id);
	}

	// Token: 0x0600D0D7 RID: 53463 RVA: 0x002FB6F7 File Offset: 0x002F98F7
	private FloroRanchTaskItem CreateTaskItem()
	{
		return new FloroRanchTaskItem
		{
			OnGetBtnClick = new Action(this.OnTaskClickCallBack)
		};
	}

	// Token: 0x0600D0D8 RID: 53464 RVA: 0x002FB710 File Offset: 0x002F9910
	private void OnTaskClickCallBack()
	{
		List<int> floroRanchReceivableTaskIds = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true).GetFloroRanchReceivableTaskIds(false, EFloroRanchTaskTabType.Dungeon);
		FloroRanchController.Instance.RequestTaskReward(floroRanchReceivableTaskIds.ToArray());
	}

	// Token: 0x0600D0D9 RID: 53465 RVA: 0x002FB741 File Offset: 0x002F9941
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04005FD5 RID: 24533
	private GenericLayout<FloroRanchTaskItem, FloroRanchTaskData> TaskLayout;

	// Token: 0x020080DE RID: 32990
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A0BA RID: 172218
		public const int ItemCaption = 0;

		// Token: 0x0402A0BB RID: 172219
		public const int LayoutTask = 1;

		// Token: 0x0402A0BC RID: 172220
		public const int ItemTask = 2;
	}
}
