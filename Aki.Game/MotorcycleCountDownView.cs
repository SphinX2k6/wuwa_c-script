using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002233 RID: 8755
public class MotorcycleCountDownView : UiViewBase
{
	// Token: 0x06011159 RID: 69977 RVA: 0x0042A357 File Offset: 0x00428557
	[NullableContext(1)]
	public MotorcycleCountDownView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601115A RID: 69978 RVA: 0x0042A368 File Offset: 0x00428568
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0601115B RID: 69979 RVA: 0x0042A38B File Offset: 0x0042858B
	protected override void OnStart()
	{
		this.CountDownText = base.GetText(0);
	}

	// Token: 0x0601115C RID: 69980 RVA: 0x0042A39A File Offset: 0x0042859A
	protected override void OnBeforeShow()
	{
		BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Custom, MotorcycleCountDownDefine.hideBattleUiChildren, false, true, 0);
	}

	// Token: 0x0601115D RID: 69981 RVA: 0x0042A3B4 File Offset: 0x004285B4
	protected override void OnAfterHide()
	{
		BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Custom, MotorcycleCountDownDefine.hideBattleUiChildren, true, true, 0);
	}

	// Token: 0x0601115E RID: 69982 RVA: 0x0042A3CE File Offset: 0x004285CE
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add<double, double>(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.OnCountDownChanged));
	}

	// Token: 0x0601115F RID: 69983 RVA: 0x0042A3F2 File Offset: 0x004285F2
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove<double, double>(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.OnCountDownChanged));
	}

	// Token: 0x06011160 RID: 69984 RVA: 0x0042A418 File Offset: 0x00428618
	private void OnCountDownChanged(double remainTime, double timerEndTime)
	{
		if (remainTime <= 0.0)
		{
			this.HandleCountDownEnd();
			return;
		}
		string remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat5(remainTime);
		UUIText countDownText = this.CountDownText;
		if (countDownText != null)
		{
			countDownText.SetText(remainTimeDataFormat, true);
		}
		if (remainTime < (double)this.WarningTime)
		{
			this.PlayWarningAnim();
		}
	}

	// Token: 0x06011161 RID: 69985 RVA: 0x0042A467 File Offset: 0x00428667
	private void HandleCountDownEnd()
	{
		GeneralLogicTreeModel.Instance.CountDownViewClosing = true;
		base.CloseMe(delegate(bool success)
		{
			if (success)
			{
				GeneralLogicTreeModel.Instance.CountDownViewClosing = false;
			}
		});
	}

	// Token: 0x06011162 RID: 69986 RVA: 0x0042A49C File Offset: 0x0042869C
	private void PlayWarningAnim()
	{
		if (this.IsInWarning)
		{
			return;
		}
		this.IsInWarning = true;
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Loop", false, null);
	}

	// Token: 0x04008226 RID: 33318
	private bool IsInWarning;

	// Token: 0x04008227 RID: 33319
	private readonly int WarningTime = 10;

	// Token: 0x04008228 RID: 33320
	[Nullable(2)]
	private UUIText CountDownText;

	// Token: 0x02008766 RID: 34662
	private class EChildType
	{
		// Token: 0x0402C02A RID: 180266
		public const int CountDownText = 0;
	}
}
