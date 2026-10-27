using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001B54 RID: 6996
public class FloroRanchGameStartState : FloroRanchStateBase
{
	// Token: 0x0600CF94 RID: 53140 RVA: 0x002F481B File Offset: 0x002F2A1B
	[NullableContext(1)]
	public FloroRanchGameStartState(FloroRanchStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x0600CF95 RID: 53141 RVA: 0x002F4824 File Offset: 0x002F2A24
	protected override void OnEnter()
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchGamePlayView, null, delegate(bool _, int _)
		{
			if (FloroRanchGamePlayModel.Instance.IsOver)
			{
				this.StageFsm.ChangeState(EFloroRanchStageStateType.StageSuccess);
				return;
			}
			this.StageFsm.ChangeState(EFloroRanchStageStateType.DailyInStage);
		});
	}
}
