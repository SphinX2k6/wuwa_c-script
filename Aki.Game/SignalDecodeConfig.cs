using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002A08 RID: 10760
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class SignalDecodeConfig : ConfigBase
{
	// Token: 0x06016551 RID: 91473 RVA: 0x005A6F54 File Offset: 0x005A5154
	public CatchSignalGameplay? GetGameplayConfig(string id)
	{
		CatchSignalGameplay? config = ConfigCatchSignalGameplayById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GeneralLogicTree;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "无法找到捕捉信号的配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x06016552 RID: 91474 RVA: 0x005A6FA0 File Offset: 0x005A51A0
	public CatchSignalDifficulty? GetDifficultyConfig(int id)
	{
		CatchSignalDifficulty? config = ConfigCatchSignalDifficultyById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GeneralLogicTree;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "无法找到捕捉信号难度的配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x17001DCE RID: 7630
	// (get) Token: 0x06016553 RID: 91475 RVA: 0x005A6FEE File Offset: 0x005A51EE
	public static SignalDecodeConfig Instance
	{
		get
		{
			return SignalDecodeConfig._Instance;
		}
	}

	// Token: 0x06016554 RID: 91476 RVA: 0x005A6FF5 File Offset: 0x005A51F5
	public static SignalDecodeConfig GetOrCreateInstance()
	{
		if (SignalDecodeConfig._Instance == null)
		{
			SignalDecodeConfig.CreateInstance();
		}
		return SignalDecodeConfig._Instance;
	}

	// Token: 0x06016555 RID: 91477 RVA: 0x005A7009 File Offset: 0x005A5209
	public static bool CreateInstance()
	{
		if (SignalDecodeConfig._Instance != null)
		{
			return true;
		}
		SignalDecodeConfig._Instance = new SignalDecodeConfig();
		return true;
	}

	// Token: 0x06016556 RID: 91478 RVA: 0x005A701F File Offset: 0x005A521F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016557 RID: 91479 RVA: 0x005A7021 File Offset: 0x005A5221
	public static void ResetStaticDefaultValue()
	{
		SignalDecodeConfig._Instance = null;
	}

	// Token: 0x06016558 RID: 91480 RVA: 0x005A7029 File Offset: 0x005A5229
	static SignalDecodeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SignalDecodeConfig.CreateStaticDefaultValue), new Action(SignalDecodeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A616 RID: 42518
	[Nullable(2)]
	private static SignalDecodeConfig _Instance;
}
