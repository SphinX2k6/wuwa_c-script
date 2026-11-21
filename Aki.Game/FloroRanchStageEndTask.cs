using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x0200100C RID: 4108
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchStageEndTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600A377 RID: 41847 RVA: 0x002FF0CE File Offset: 0x002FD2CE
	public FloroRanchStageEndTask(FloroRanchStageEnd data)
	{
		this.StageEndData = data;
	}

	// Token: 0x0600A378 RID: 41848 RVA: 0x002FF0E0 File Offset: 0x002FD2E0
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

	// Token: 0x04006036 RID: 24630
	private readonly FloroRanchStageEnd StageEndData;
}
