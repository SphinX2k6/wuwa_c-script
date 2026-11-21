using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02001017 RID: 4119
public class FloroRanchStageSuccessState : FloroRanchStateBase
{
	// Token: 0x0600A3AE RID: 41902 RVA: 0x002FFAEB File Offset: 0x002FDCEB
	[NullableContext(1)]
	public FloroRanchStageSuccessState(FloroRanchStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x0600A3AF RID: 41903 RVA: 0x002FFAF4 File Offset: 0x002FDCF4
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
