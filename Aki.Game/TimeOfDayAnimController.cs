using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002126 RID: 8486
public class TimeOfDayAnimController : IStaticVariableResetter
{
	// Token: 0x06014CAE RID: 85166 RVA: 0x0060B59D File Offset: 0x0060979D
	static TimeOfDayAnimController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeOfDayAnimController.CreateStaticDefaultValue), new Action(TimeOfDayAnimController.ResetStaticDefaultValue));
	}

	// Token: 0x06014CAF RID: 85167 RVA: 0x0060B5BC File Offset: 0x006097BC
	public static void CreateStaticDefaultValue()
	{
		TimeOfDayAnimController.TickId = 0;
		TimeOfDayAnimController.PrePromise = null;
		TimeOfDayAnimController.CallBack = delegate()
		{
		};
	}

	// Token: 0x06014CB0 RID: 85168 RVA: 0x0060B5EE File Offset: 0x006097EE
	public static void ResetStaticDefaultValue()
	{
		TimeOfDayAnimController.TickId = 0;
		TimeOfDayAnimController.PrePromise = null;
		TimeOfDayAnimController.CallBack = null;
	}

	// Token: 0x06014CB1 RID: 85169 RVA: 0x0060B604 File Offset: 0x00609804
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

	// Token: 0x0400B152 RID: 45394
	public static int TickId;

	// Token: 0x0400B153 RID: 45395
	[Nullable(2)]
	public static CustomPromise PrePromise;

	// Token: 0x0400B154 RID: 45396
	[Nullable(2)]
	public static Action CallBack;
}
