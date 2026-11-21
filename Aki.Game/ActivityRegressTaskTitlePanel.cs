using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000965 RID: 2405
public class ActivityRegressTaskTitlePanel : UiPanelBase
{
	// Token: 0x060069AE RID: 27054 RVA: 0x0020F614 File Offset: 0x0020D814
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

	// Token: 0x060069AF RID: 27055 RVA: 0x0020F68F File Offset: 0x0020D88F
	protected override void OnBeforeDestroy()
	{
		this.RemoveTimerCheck();
	}

	// Token: 0x060069B0 RID: 27056 RVA: 0x0020F698 File Offset: 0x0020D898
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

	// Token: 0x060069B1 RID: 27057 RVA: 0x0020F754 File Offset: 0x0020D954
	private void RefreshTimerView(float _)
	{
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text, "RecallActivity_Task_Daily_Countdown", new <>z__ReadOnlySingleElementList<object>(ActivityRegressModel.Instance.ActivityData.GetNextRefreshTime()));
	}

	// Token: 0x060069B2 RID: 27058 RVA: 0x0020F78D File Offset: 0x0020D98D
	private void RemoveTimerCheck()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x040042E7 RID: 17127
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x02006C6F RID: 27759
	private class EComponents
	{
		// Token: 0x04023A0E RID: 145934
		public const int TxtTitle = 0;

		// Token: 0x04023A0F RID: 145935
		public const int TxtTips = 1;

		// Token: 0x04023A10 RID: 145936
		public const int TexBG1 = 2;

		// Token: 0x04023A11 RID: 145937
		public const int TexBG2 = 3;
	}
}
