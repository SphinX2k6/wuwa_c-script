using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;

// Token: 0x020017F7 RID: 6135
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ConsoleParallelVersionController : ControllerBase
{
	// Token: 0x0600F079 RID: 61561 RVA: 0x0046AC98 File Offset: 0x00468E98
	protected override bool OnInit()
	{
		if (!Info.Instance.IsHomeConsolePlatform())
		{
			return true;
		}
		EventSystem.Instance.Add(EEventName.EnterGameSuccess, new Action(this.OnEnterGameSuccess));
		EventSystem.Instance.Add(EEventName.BackLoginView, new Action(this.OnBackLoginView));
		EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnBackLoginView));
		return true;
	}

	// Token: 0x0600F07A RID: 61562 RVA: 0x0046AD08 File Offset: 0x00468F08
	protected override bool OnClear()
	{
		if (!Info.Instance.IsHomeConsolePlatform())
		{
			return true;
		}
		EventSystem.Instance.Remove(EEventName.EnterGameSuccess, new Action(this.OnEnterGameSuccess));
		EventSystem.Instance.Remove(EEventName.BackLoginView, new Action(this.OnBackLoginView));
		EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnBackLoginView));
		this.StopInGameTimer();
		return true;
	}

	// Token: 0x0600F07B RID: 61563 RVA: 0x0046AD7C File Offset: 0x00468F7C
	public void CheckOnEnterLoginServer(Action<bool> onCanEnter)
	{
		if (!Info.Instance.IsHomeConsolePlatform())
		{
			onCanEnter(true);
			return;
		}
		ParallelPackageController.Instance.RefreshCdnConfigAndCheckVersion(delegate(bool needUpdate)
		{
			if (needUpdate)
			{
				this.ShowForceUpdateBox(false);
				onCanEnter(false);
				return;
			}
			onCanEnter(true);
		});
	}

	// Token: 0x0600F07C RID: 61564 RVA: 0x0046ADCC File Offset: 0x00468FCC
	private void OnEnterGameSuccess()
	{
		this.StartInGameTimer();
	}

	// Token: 0x0600F07D RID: 61565 RVA: 0x0046ADD4 File Offset: 0x00468FD4
	private void OnBackLoginView()
	{
		this.StopInGameTimer();
		this.IsUpdateBoxShowing = false;
	}

	// Token: 0x0600F07E RID: 61566 RVA: 0x0046ADE4 File Offset: 0x00468FE4
	private void StartInGameTimer()
	{
		if (!Info.Instance.IsHomeConsolePlatform())
		{
			return;
		}
		this.StopInGameTimer();
		int consoleParallelPackageGap = CommonConfig.Instance.GetConsoleParallelPackageGap();
		if (consoleParallelPackageGap <= 0)
		{
			return;
		}
		float interval = (float)(consoleParallelPackageGap * 60) * 1000f;
		this.InGameCheckTimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnInGameCheckTick), interval, 1f, null, "ConsoleParallelVersionCheck", false);
	}

	// Token: 0x0600F07F RID: 61567 RVA: 0x0046AE49 File Offset: 0x00469049
	private void StopInGameTimer()
	{
		if (this.InGameCheckTimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.InGameCheckTimerHandle);
			this.InGameCheckTimerHandle = null;
		}
	}

	// Token: 0x0600F080 RID: 61568 RVA: 0x0046AE6B File Offset: 0x0046906B
	private void OnInGameCheckTick(float delta)
	{
		ParallelPackageController.Instance.RefreshCdnConfigAndCheckVersion(delegate(bool needUpdate)
		{
			if (needUpdate)
			{
				this.ShowForceUpdateBox(true);
			}
		});
	}

	// Token: 0x0600F081 RID: 61569 RVA: 0x0046AE84 File Offset: 0x00469084
	private void ShowForceUpdateBox(bool inGame)
	{
		if (this.IsUpdateBoxShowing)
		{
			return;
		}
		this.IsUpdateBoxShowing = true;
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ConsoleParallelPackageUpdate);
		confirmBoxDataNew.NotAddChildToTopStackView = true;
		confirmBoxDataNew.DestroyFunction = delegate()
		{
			this.IsUpdateBoxShowing = false;
		};
		string title = ConfigMultiTextLang.GetLocalTextNew("ConsoleParallelPackageUpdateDefaultTitle", null) ?? "";
		string text = ConfigMultiTextLang.GetLocalTextNew("ConsoleParallelPackageUpdateDefaultDesc", null) ?? "";
		confirmBoxDataNew.SetTitle(title);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			text
		});
		confirmBoxDataNew.HasToggle = false;
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap.Add(1, delegate
		{
			if (inGame)
			{
				ReConnectController.Instance.Logout(ELogoutReason.ExitGameConfirmBox);
				return;
			}
			this.IsUpdateBoxShowing = false;
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "ConsoleParallelVersion ShowForceUpdateBox";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("inGame", inGame);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x170016E9 RID: 5865
	// (get) Token: 0x0600F082 RID: 61570 RVA: 0x0046AF7D File Offset: 0x0046917D
	public static ConsoleParallelVersionController Instance
	{
		get
		{
			return ConsoleParallelVersionController._Instance;
		}
	}

	// Token: 0x0600F083 RID: 61571 RVA: 0x0046AF84 File Offset: 0x00469184
	public static ConsoleParallelVersionController GetOrCreateInstance()
	{
		if (ConsoleParallelVersionController._Instance == null)
		{
			ConsoleParallelVersionController.CreateInstance();
		}
		return ConsoleParallelVersionController._Instance;
	}

	// Token: 0x0600F084 RID: 61572 RVA: 0x0046AF98 File Offset: 0x00469198
	public static bool CreateInstance()
	{
		if (ConsoleParallelVersionController._Instance != null)
		{
			return true;
		}
		ConsoleParallelVersionController._Instance = new ConsoleParallelVersionController();
		return true;
	}

	// Token: 0x0600F085 RID: 61573 RVA: 0x0046AFAE File Offset: 0x004691AE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F086 RID: 61574 RVA: 0x0046AFB0 File Offset: 0x004691B0
	public static void ResetStaticDefaultValue()
	{
		ConsoleParallelVersionController._Instance = null;
	}

	// Token: 0x0600F087 RID: 61575 RVA: 0x0046AFB8 File Offset: 0x004691B8
	static ConsoleParallelVersionController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ConsoleParallelVersionController.CreateStaticDefaultValue), new Action(ConsoleParallelVersionController.ResetStaticDefaultValue));
	}

	// Token: 0x040087E5 RID: 34789
	[Nullable(2)]
	private TimerHandle InGameCheckTimerHandle;

	// Token: 0x040087E6 RID: 34790
	private bool IsUpdateBoxShowing;

	// Token: 0x040087E7 RID: 34791
	[Nullable(2)]
	private static ConsoleParallelVersionController _Instance;
}
