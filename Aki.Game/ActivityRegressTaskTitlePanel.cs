using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014B1 RID: 5297
public class ActivityRegressTaskTitlePanel : UiPanelBase
{
	// Token: 0x06009619 RID: 38425 RVA: 0x002066A8 File Offset: 0x002048A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x0600961A RID: 38426 RVA: 0x00206723 File Offset: 0x00204923
	protected override void OnBeforeDestroy()
	{
		this.RemoveTimerCheck();
	}

	// Token: 0x0600961B RID: 38427 RVA: 0x0020672C File Offset: 0x0020492C
	[NullableContext(1)]
	public void RefreshByData(ActivityRegressTaskDynamicData data)
	{
		bool flag = data.TaskType > ERegressTaskType.Constant;
		base.GetItem(2).SetUIActive(flag);
		base.GetItem(3).SetUIActive(!flag);
		UUIText text = base.GetText(0);
		string textStringId = (data.TaskType == ERegressTaskType.Constant) ? "RecallActivity_Task_Resident" : "RecallActivity_Task_Daily";
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
		UUIItem text2 = base.GetText(1);
		bool flag2 = data.TaskType == ERegressTaskType.Daily;
		text2.SetUIActive(flag2);
		if (flag2)
		{
			this.RemoveTimerCheck();
			this.TimerHandle = TimerSystem.RealTimeInstance.Forever(new TTimerAction(this.RefreshTimerView), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
			this.RefreshTimerView(0f);
		}
	}

	// Token: 0x0600961C RID: 38428 RVA: 0x002067E8 File Offset: 0x002049E8
	private void RefreshTimerView(float _)
	{
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text, "RecallActivity_Task_Daily_Countdown", new <>z__ReadOnlySingleElementList<object>(ActivityRegressModel.Instance.ActivityData.GetNextRefreshTime()));
	}

	// Token: 0x0600961D RID: 38429 RVA: 0x00206821 File Offset: 0x00204A21
	private void RemoveTimerCheck()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0400424F RID: 16975
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x02007AEB RID: 31467
	private class EComponents
	{
		// Token: 0x040286F4 RID: 165620
		public const int TxtTitle = 0;

		// Token: 0x040286F5 RID: 165621
		public const int TxtTips = 1;

		// Token: 0x040286F6 RID: 165622
		public const int TexBG1 = 2;

		// Token: 0x040286F7 RID: 165623
		public const int TexBG2 = 3;
	}
}
