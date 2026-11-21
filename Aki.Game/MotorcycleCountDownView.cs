using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001717 RID: 5911
public class MotorcycleCountDownView : UiViewBase
{
	// Token: 0x0600E5EF RID: 58863 RVA: 0x00436EFB File Offset: 0x004350FB
	[NullableContext(1)]
	public MotorcycleCountDownView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E5F0 RID: 58864 RVA: 0x00436F0C File Offset: 0x0043510C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600E5F1 RID: 58865 RVA: 0x00436F2F File Offset: 0x0043512F
	protected override void OnStart()
	{
		this.CountDownText = base.GetText(0);
	}

	// Token: 0x0600E5F2 RID: 58866 RVA: 0x00436F3E File Offset: 0x0043513E
	protected override void OnBeforeShow()
	{
		BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Custom, MotorcycleCountDownDefine.hideBattleUiChildren, false, true, 0);
	}

	// Token: 0x0600E5F3 RID: 58867 RVA: 0x00436F58 File Offset: 0x00435158
	protected override void OnAfterHide()
	{
		BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Custom, MotorcycleCountDownDefine.hideBattleUiChildren, true, true, 0);
	}

	// Token: 0x0600E5F4 RID: 58868 RVA: 0x00436F72 File Offset: 0x00435172
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add<double, double>(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.OnCountDownChanged));
	}

	// Token: 0x0600E5F5 RID: 58869 RVA: 0x00436F96 File Offset: 0x00435196
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove<double, double>(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.OnCountDownChanged));
	}

	// Token: 0x0600E5F6 RID: 58870 RVA: 0x00436FBC File Offset: 0x004351BC
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

	// Token: 0x0600E5F7 RID: 58871 RVA: 0x0043700B File Offset: 0x0043520B
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

	// Token: 0x0600E5F8 RID: 58872 RVA: 0x00437040 File Offset: 0x00435240
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

	// Token: 0x04008364 RID: 33636
	private bool IsInWarning;

	// Token: 0x04008365 RID: 33637
	private readonly int WarningTime = 10;

	// Token: 0x04008366 RID: 33638
	[Nullable(2)]
	private UUIText CountDownText;

	// Token: 0x020078EF RID: 30959
	private class EChildType
	{
		// Token: 0x04027342 RID: 160578
		public const int CountDownText = 0;
	}
}
