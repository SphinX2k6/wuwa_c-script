using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200584E RID: 22606
	public class HonamiStoryLeaveTipAction : InteractConfirmActionBase
	{
		// Token: 0x0603976F RID: 235375 RVA: 0x00DA44BC File Offset: 0x00DA26BC
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

		// Token: 0x06039770 RID: 235376 RVA: 0x00DA450C File Offset: 0x00DA270C
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
