using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002BAA RID: 11178
public class TimeOfDayAnimController : IStaticVariableResetter
{
	// Token: 0x0601727D RID: 94845 RVA: 0x005DE9C9 File Offset: 0x005DCBC9
	static TimeOfDayAnimController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeOfDayAnimController.CreateStaticDefaultValue), new Action(TimeOfDayAnimController.ResetStaticDefaultValue));
	}

	// Token: 0x0601727E RID: 94846 RVA: 0x005DE9E8 File Offset: 0x005DCBE8
	public static void CreateStaticDefaultValue()
	{
		TimeOfDayAnimController.TickId = 0;
		TimeOfDayAnimController.PrePromise = null;
		TimeOfDayAnimController.CallBack = delegate()
		{
		};
	}

	// Token: 0x0601727F RID: 94847 RVA: 0x005DEA1A File Offset: 0x005DCC1A
	public static void ResetStaticDefaultValue()
	{
		TimeOfDayAnimController.TickId = 0;
		TimeOfDayAnimController.PrePromise = null;
		TimeOfDayAnimController.CallBack = null;
	}

	// Token: 0x06017280 RID: 94848 RVA: 0x005DEA30 File Offset: 0x005DCC30
	[NullableContext(1)]
	public static void PlayTimeAnimation(double startSecond, double setSecond, Action callBack)
	{
		TimeOfDayAnimController.CallBack = callBack;
		UiLayer.Instance.SetShowNormalMaskLayer(true, "");
		TimeOfDayController.Instance.PauseTime();
		TimeOfDayController.Instance.SyncGlobalGameTime(TodDayTime.ConvertToOneDaySecond(setSecond), true);
		UiManager.Instance.OpenView(EUiViewName.TimeOfDayLoadingView, null, delegate(bool success, int viewId)
		{
			UiLayer.Instance.SetShowNormalMaskLayer(false, "");
			TimeOfDayController.Instance.ResumeTimeScale(true);
			if (TimeOfDayAnimController.CallBack != null)
			{
				TimeOfDayAnimController.CallBack();
			}
		});
	}

	// Token: 0x0400AD4B RID: 44363
	public static int TickId;

	// Token: 0x0400AD4C RID: 44364
	[Nullable(2)]
	public static CustomPromise PrePromise;

	// Token: 0x0400AD4D RID: 44365
	[Nullable(2)]
	public static Action CallBack;
}
