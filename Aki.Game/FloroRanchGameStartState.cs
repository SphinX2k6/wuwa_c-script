using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001013 RID: 4115
public class FloroRanchGameStartState : FloroRanchStateBase
{
	// Token: 0x0600A3A5 RID: 41893 RVA: 0x002FF8F3 File Offset: 0x002FDAF3
	[NullableContext(1)]
	public FloroRanchGameStartState(FloroRanchStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x0600A3A6 RID: 41894 RVA: 0x002FF8FC File Offset: 0x002FDAFC
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
