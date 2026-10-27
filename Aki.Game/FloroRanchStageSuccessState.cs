using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02001B58 RID: 7000
public class FloroRanchStageSuccessState : FloroRanchStateBase
{
	// Token: 0x0600CF9D RID: 53149 RVA: 0x002F4A13 File Offset: 0x002F2C13
	[NullableContext(1)]
	public FloroRanchStageSuccessState(FloroRanchStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x0600CF9E RID: 53150 RVA: 0x002F4A1C File Offset: 0x002F2C1C
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
			if (response.SettleData.IsUnlimited)
			{
				FloroRanchGamePlayModel.Instance.OpenAndRecordView(EUiViewName.FloroRanchDungeonEndlessSettleView, response, null);
				return;
			}
			FloroRanchGamePlayModel.Instance.OpenAndRecordView(EUiViewName.FloroRanchDungeonSuccessSettleView, response, null);
		});
	}
}
