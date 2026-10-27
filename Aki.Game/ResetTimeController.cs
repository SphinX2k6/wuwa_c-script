using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020034E5 RID: 13541
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ResetTimeController : ControllerBase
{
	// Token: 0x0601DABA RID: 121530 RVA: 0x0084FAE8 File Offset: 0x0084DCE8
	protected unsafe override bool OnInit()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Timer;
		ELogAuthor author = ELogAuthor.YZ;
		string message = "ResetTimeController.OnInit";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PassSeconds", this.PassSeconds);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LastInputTime", this.LastInputTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("NowSeconds", Time.Instance.NowSeconds);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		EventSystem.Instance.Add(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
		this.TimerHandle = TimerSystem.Instance.Forever(delegate(float _)
		{
			this.PassSeconds += 60;
			if (this.PassSeconds >= 172800 && Time.Instance.NowSeconds - this.LastInputTime > 3600.0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Timer;
				ELogAuthor author2 = ELogAuthor.YZ;
				string message2 = "ResetTimeController.Logout";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PassSeconds", this.PassSeconds);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("LastInputTime", this.LastInputTime);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("NowSeconds", Time.Instance.NowSeconds);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				ReConnectController.Instance.Logout(ELogoutReason.ResetTime);
			}
		}, 60000f, 1f, null, null, true);
		return true;
	}

	// Token: 0x0601DABB RID: 121531 RVA: 0x0084FBC7 File Offset: 0x0084DDC7
	public override bool Clear()
	{
		this.ResetTime();
		EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
		return true;
	}

	// Token: 0x0601DABC RID: 121532 RVA: 0x0084FBEC File Offset: 0x0084DDEC
	private void OnInputAnyKey(bool press, FKey key)
	{
		this.LastInputTime = Time.Instance.NowSeconds;
	}

	// Token: 0x0601DABD RID: 121533 RVA: 0x0084FC00 File Offset: 0x0084DE00
	public unsafe void ResetTime()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Timer;
		ELogAuthor author = ELogAuthor.YZ;
		string message = "ResetTimeController.ResetTime";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PassSeconds", this.PassSeconds);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LastInputTime", this.LastInputTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("NowSeconds", Time.Instance.NowSeconds);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		if (this.TimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		this.PassSeconds = 0;
		this.LastInputTime = 0.0;
		UWorld world = GlobalData.World;
		if (world == null)
		{
			return;
		}
		world.ResetAllTimeSeconds(0f);
	}

	// Token: 0x170028E9 RID: 10473
	// (get) Token: 0x0601DABE RID: 121534 RVA: 0x0084FCE3 File Offset: 0x0084DEE3
	public static ResetTimeController Instance
	{
		get
		{
			return ResetTimeController._Instance;
		}
	}

	// Token: 0x0601DABF RID: 121535 RVA: 0x0084FCEA File Offset: 0x0084DEEA
	public static ResetTimeController GetOrCreateInstance()
	{
		if (ResetTimeController._Instance == null)
		{
			ResetTimeController.CreateInstance();
		}
		return ResetTimeController._Instance;
	}

	// Token: 0x0601DAC0 RID: 121536 RVA: 0x0084FCFE File Offset: 0x0084DEFE
	public static bool CreateInstance()
	{
		if (ResetTimeController._Instance != null)
		{
			return true;
		}
		ResetTimeController._Instance = new ResetTimeController();
		return true;
	}

	// Token: 0x0601DAC1 RID: 121537 RVA: 0x0084FD14 File Offset: 0x0084DF14
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DAC2 RID: 121538 RVA: 0x0084FD16 File Offset: 0x0084DF16
	public static void ResetStaticDefaultValue()
	{
		ResetTimeController._Instance = null;
	}

	// Token: 0x0601DAC3 RID: 121539 RVA: 0x0084FD1E File Offset: 0x0084DF1E
	static ResetTimeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ResetTimeController.CreateStaticDefaultValue), new Action(ResetTimeController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E8C7 RID: 59591
	public const int PLAY_TIME_SECONDS = 172800;

	// Token: 0x0400E8C8 RID: 59592
	public const int AFK_TIME_SECONDS = 3600;

	// Token: 0x0400E8C9 RID: 59593
	public const int UPDATE_INTERVAL = 60000;

	// Token: 0x0400E8CA RID: 59594
	private int PassSeconds;

	// Token: 0x0400E8CB RID: 59595
	private double LastInputTime;

	// Token: 0x0400E8CC RID: 59596
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x0400E8CD RID: 59597
	[Nullable(2)]
	private static ResetTimeController _Instance;
}
