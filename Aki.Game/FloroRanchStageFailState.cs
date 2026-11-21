using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02001014 RID: 4116
public class FloroRanchStageFailState : FloroRanchStateBase
{
	// Token: 0x0600A3A8 RID: 41896 RVA: 0x002FF941 File Offset: 0x002FDB41
	[NullableContext(1)]
	public FloroRanchStageFailState(FloroRanchStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x0600A3A9 RID: 41897 RVA: 0x002FF94C File Offset: 0x002FDB4C
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
