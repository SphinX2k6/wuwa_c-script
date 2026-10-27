using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02001B4D RID: 6989
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchStageEndTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600CF66 RID: 53094 RVA: 0x002F3FF6 File Offset: 0x002F21F6
	public FloroRanchStageEndTask(FloroRanchStageEnd data)
	{
		this.StageEndData = data;
	}

	// Token: 0x0600CF67 RID: 53095 RVA: 0x002F4008 File Offset: 0x002F2208
	protected override void OnExecute()
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchPhaseSettleView, new FloroRanchPhaseSettleViewParam
		{
			StageEndData = this.StageEndData,
			CloseCallback = delegate(bool isSettle)
			{
				base.Complete(delegate
				{
					if (isSettle)
					{
						if (this.StageEndData.Win || this.StageEndData.IsUnlimitedMode)
						{
							FloroRanchGamePlayModel.Instance.ChangeState(EFloroRanchStageStateType.StageSuccess);
							return;
						}
						FloroRanchGamePlayModel.Instance.ChangeState(EFloroRanchStageStateType.StageFail);
					}
				});
			}
		}, null);
	}

	// Token: 0x04005F67 RID: 24423
	private readonly FloroRanchStageEnd StageEndData;
}
