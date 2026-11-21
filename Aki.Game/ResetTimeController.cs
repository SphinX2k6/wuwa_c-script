using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002A59 RID: 10841
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ResetTimeController : ControllerBase
{
	// Token: 0x0601B7C8 RID: 112584 RVA: 0x00877E60 File Offset: 0x00876060
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

	// Token: 0x0601B7C9 RID: 112585 RVA: 0x00877F3F File Offset: 0x0087613F
	public override bool Clear()
	{
		this.ResetTime();
		EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
		return true;
	}

	// Token: 0x0601B7CA RID: 112586 RVA: 0x00877F64 File Offset: 0x00876164
	private void OnInputAnyKey(bool press, FKey key)
	{
		this.LastInputTime = Time.Instance.NowSeconds;
	}

	// Token: 0x0601B7CB RID: 112587 RVA: 0x00877F78 File Offset: 0x00876178
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

	// Token: 0x17002C81 RID: 11393
	// (get) Token: 0x0601B7CC RID: 112588 RVA: 0x0087805B File Offset: 0x0087625B
	public static ResetTimeController Instance
	{
		get
		{
			return ResetTimeController._Instance;
		}
	}

	// Token: 0x0601B7CD RID: 112589 RVA: 0x00878062 File Offset: 0x00876262
	public static ResetTimeController GetOrCreateInstance()
	{
		if (ResetTimeController._Instance == null)
		{
			ResetTimeController.CreateInstance();
		}
		return ResetTimeController._Instance;
	}

	// Token: 0x0601B7CE RID: 112590 RVA: 0x00878076 File Offset: 0x00876276
	public static bool CreateInstance()
	{
		if (ResetTimeController._Instance != null)
		{
			return true;
		}
		ResetTimeController._Instance = new ResetTimeController();
		return true;
	}

	// Token: 0x0601B7CF RID: 112591 RVA: 0x0087808C File Offset: 0x0087628C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B7D0 RID: 112592 RVA: 0x0087808E File Offset: 0x0087628E
	public static void ResetStaticDefaultValue()
	{
		ResetTimeController._Instance = null;
	}

	// Token: 0x0601B7D1 RID: 112593 RVA: 0x00878096 File Offset: 0x00876296
	static ResetTimeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ResetTimeController.CreateStaticDefaultValue), new Action(ResetTimeController.ResetStaticDefaultValue));
	}

	// Token: 0x0400ED7E RID: 60798
	public const int PLAY_TIME_SECONDS = 172800;

	// Token: 0x0400ED7F RID: 60799
	public const int AFK_TIME_SECONDS = 3600;

	// Token: 0x0400ED80 RID: 60800
	public const int UPDATE_INTERVAL = 60000;

	// Token: 0x0400ED81 RID: 60801
	private int PassSeconds;

	// Token: 0x0400ED82 RID: 60802
	private double LastInputTime;

	// Token: 0x0400ED83 RID: 60803
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x0400ED84 RID: 60804
	[Nullable(2)]
	private static ResetTimeController _Instance;
}
