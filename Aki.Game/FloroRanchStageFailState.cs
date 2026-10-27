using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02001B55 RID: 6997
public class FloroRanchStageFailState : FloroRanchStateBase
{
	// Token: 0x0600CF97 RID: 53143 RVA: 0x002F4869 File Offset: 0x002F2A69
	[NullableContext(1)]
	public FloroRanchStageFailState(FloroRanchStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x0600CF98 RID: 53144 RVA: 0x002F4874 File Offset: 0x002F2A74
	protected override void OnEnter()
	{
		FloroRanchGamePlayModel instance = FloroRanchGamePlayModel.Instance;
		int activityId = instance.ActivityId;
		int subInstanceId = instance.SubInstanceId;
		FloroRanchController.Instance.SendFloroRanchSettleDataRequest(activityId, subInstanceId, delegate(FloroRanchSettleDataResponse response)
		{
			if (response == null || !response.ShowMvp)
			{
				FloroRanchGamePlayModel.Instance.ExitGame(true);
				return;
			}
			FloroRanchGamePlayModel.Instance.OpenAndRecordView(EUiViewName.FloroRanchDungeonFailSettleView, response, null);
		});
	}
}
