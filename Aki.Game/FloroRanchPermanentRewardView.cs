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

// Token: 0x0200102C RID: 4140
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchPermanentRewardView : UiViewBase
{
	// Token: 0x0600A4E2 RID: 42210 RVA: 0x00306669 File Offset: 0x00304869
	public FloroRanchPermanentRewardView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A4E3 RID: 42211 RVA: 0x00306674 File Offset: 0x00304874
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

	// Token: 0x0600A4E4 RID: 42212 RVA: 0x00306700 File Offset: 0x00304900
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchPermanentRewardView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchPermanentRewardView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A4E5 RID: 42213 RVA: 0x00306743 File Offset: 0x00304943
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTaskLayout));
	}

	// Token: 0x0600A4E6 RID: 42214 RVA: 0x00306761 File Offset: 0x00304961
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTaskLayout));
	}

	// Token: 0x0600A4E7 RID: 42215 RVA: 0x00306780 File Offset: 0x00304980
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

	// Token: 0x0600A4E8 RID: 42216 RVA: 0x003067CF File Offset: 0x003049CF
	private FloroRanchTaskItem CreateTaskItem()
	{
		return new FloroRanchTaskItem
		{
			OnGetBtnClick = new Action(this.OnTaskClickCallBack)
		};
	}

	// Token: 0x0600A4E9 RID: 42217 RVA: 0x003067E8 File Offset: 0x003049E8
	private void OnTaskClickCallBack()
	{
		List<int> floroRanchReceivableTaskIds = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true).GetFloroRanchReceivableTaskIds(false, EFloroRanchTaskTabType.Dungeon);
		FloroRanchController.Instance.RequestTaskReward(floroRanchReceivableTaskIds.ToArray());
	}

	// Token: 0x0600A4EA RID: 42218 RVA: 0x00306819 File Offset: 0x00304A19
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x040060A4 RID: 24740
	private GenericLayout<FloroRanchTaskItem, FloroRanchTaskData> TaskLayout;

	// Token: 0x0200726C RID: 29292
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040253EE RID: 152558
		public const int ItemCaption = 0;

		// Token: 0x040253EF RID: 152559
		public const int LayoutTask = 1;

		// Token: 0x040253F0 RID: 152560
		public const int ItemTask = 2;
	}
}
