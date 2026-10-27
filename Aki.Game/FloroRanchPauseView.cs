using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B6C RID: 7020
public class FloroRanchPauseView : UiViewBase
{
	// Token: 0x0600D0CB RID: 53451 RVA: 0x002FB385 File Offset: 0x002F9585
	[NullableContext(1)]
	public FloroRanchPauseView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D0CC RID: 53452 RVA: 0x002FB390 File Offset: 0x002F9590
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickExitButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickReStartButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickContinueButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickSaveAndExitButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D0CD RID: 53453 RVA: 0x002FB4E4 File Offset: 0x002F96E4
	private void OnClickExitButton()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FloroRanchExitConfirm);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			if (FloroRanchGamePlayModel.Instance.IsEndlessMode)
			{
				FloroRanchGamePlayModel.Instance.ChangeState(EFloroRanchStageStateType.StageSuccess);
				return;
			}
			FloroRanchGamePlayModel.Instance.ChangeState(EFloroRanchStageStateType.StageFail);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600D0CE RID: 53454 RVA: 0x002FB533 File Offset: 0x002F9733
	private void OnClickReStartButton()
	{
		FloroRanchGamePlayModel.Instance.ReStartGame();
	}

	// Token: 0x0600D0CF RID: 53455 RVA: 0x002FB53F File Offset: 0x002F973F
	private void OnClickContinueButton()
	{
		base.CloseMe(delegate(bool _)
		{
			FloroRanchGamePlayModel.Instance.ResumeGame();
		});
	}

	// Token: 0x0600D0D0 RID: 53456 RVA: 0x002FB566 File Offset: 0x002F9766
	private void OnClickSaveAndExitButton()
	{
		FloroRanchController.Instance.SendFloroRanchOutRequest(FloroRanchGamePlayModel.Instance.ActivityId, FloroRanchGamePlayModel.Instance.SubInstanceId);
		FloroRanchGamePlayModel.Instance.ExitGame(false);
	}

	// Token: 0x020080DC RID: 32988
	private class EComponent
	{
		// Token: 0x0402A0B3 RID: 172211
		public const int ExitButton = 0;

		// Token: 0x0402A0B4 RID: 172212
		public const int ReStartButton = 1;

		// Token: 0x0402A0B5 RID: 172213
		public const int ContinueButton = 2;

		// Token: 0x0402A0B6 RID: 172214
		public const int SaveAndExitButton = 3;
	}
}
