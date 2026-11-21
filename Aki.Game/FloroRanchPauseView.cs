using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200102B RID: 4139
public class FloroRanchPauseView : UiViewBase
{
	// Token: 0x0600A4DC RID: 42204 RVA: 0x0030645D File Offset: 0x0030465D
	[NullableContext(1)]
	public FloroRanchPauseView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A4DD RID: 42205 RVA: 0x00306468 File Offset: 0x00304668
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

	// Token: 0x0600A4DE RID: 42206 RVA: 0x003065BC File Offset: 0x003047BC
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

	// Token: 0x0600A4DF RID: 42207 RVA: 0x0030660B File Offset: 0x0030480B
	private void OnClickReStartButton()
	{
		FloroRanchGamePlayModel.Instance.ReStartGame();
	}

	// Token: 0x0600A4E0 RID: 42208 RVA: 0x00306617 File Offset: 0x00304817
	private void OnClickContinueButton()
	{
		base.CloseMe(delegate(bool _)
		{
			FloroRanchGamePlayModel.Instance.ResumeGame();
		});
	}

	// Token: 0x0600A4E1 RID: 42209 RVA: 0x0030663E File Offset: 0x0030483E
	private void OnClickSaveAndExitButton()
	{
		FloroRanchController.Instance.SendFloroRanchOutRequest(FloroRanchGamePlayModel.Instance.ActivityId, FloroRanchGamePlayModel.Instance.SubInstanceId);
		FloroRanchGamePlayModel.Instance.ExitGame(false);
	}

	// Token: 0x0200726A RID: 29290
	private class EComponent
	{
		// Token: 0x040253E7 RID: 152551
		public const int ExitButton = 0;

		// Token: 0x040253E8 RID: 152552
		public const int ReStartButton = 1;

		// Token: 0x040253E9 RID: 152553
		public const int ContinueButton = 2;

		// Token: 0x040253EA RID: 152554
		public const int SaveAndExitButton = 3;
	}
}
