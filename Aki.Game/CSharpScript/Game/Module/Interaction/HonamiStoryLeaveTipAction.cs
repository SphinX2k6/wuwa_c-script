using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02004826 RID: 18470
	public class HonamiStoryLeaveTipAction : InteractConfirmActionBase
	{
		// Token: 0x0602E68B RID: 190091 RVA: 0x00CF317C File Offset: 0x00CF137C
		[NullableContext(1)]
		protected override bool OnExecute(InteractSecondConfirmContext context)
		{
			HonamiStoryLeaveTipParams param = new HonamiStoryLeaveTipParams
			{
				LeaveType = EHonamiStoryLeaveType.InteractLeave,
				ConfirmCallback = delegate
				{
					base.ExecuteFinish(true);
				},
				CancelCallback = delegate
				{
					base.ExecuteFinish(false);
				}
			};
			UiManager.Instance.OpenView(EUiViewName.HonamiStoryLeaveTip, param, null);
			return true;
		}

		// Token: 0x0602E68C RID: 190092 RVA: 0x00CF31CC File Offset: 0x00CF13CC
		protected override void OnCancel()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.HonamiStoryLeaveTip))
			{
				UiManager.Instance.CloseView(EUiViewName.HonamiStoryLeaveTip, null);
			}
			base.ExecuteFinish(false);
		}
	}
}
