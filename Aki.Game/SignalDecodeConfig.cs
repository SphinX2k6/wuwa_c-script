using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001F83 RID: 8067
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class SignalDecodeConfig : ConfigBase
{
	// Token: 0x06013F58 RID: 81752 RVA: 0x005D1F2C File Offset: 0x005D012C
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

	// Token: 0x06013F59 RID: 81753 RVA: 0x005D1F78 File Offset: 0x005D0178
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

	// Token: 0x17001E27 RID: 7719
	// (get) Token: 0x06013F5A RID: 81754 RVA: 0x005D1FC6 File Offset: 0x005D01C6
	public static SignalDecodeConfig Instance
	{
		get
		{
			return SignalDecodeConfig._Instance;
		}
	}

	// Token: 0x06013F5B RID: 81755 RVA: 0x005D1FCD File Offset: 0x005D01CD
	public static SignalDecodeConfig GetOrCreateInstance()
	{
		if (SignalDecodeConfig._Instance == null)
		{
			SignalDecodeConfig.CreateInstance();
		}
		return SignalDecodeConfig._Instance;
	}

	// Token: 0x06013F5C RID: 81756 RVA: 0x005D1FE1 File Offset: 0x005D01E1
	public static bool CreateInstance()
	{
		if (SignalDecodeConfig._Instance != null)
		{
			return true;
		}
		SignalDecodeConfig._Instance = new SignalDecodeConfig();
		return true;
	}

	// Token: 0x06013F5D RID: 81757 RVA: 0x005D1FF7 File Offset: 0x005D01F7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013F5E RID: 81758 RVA: 0x005D1FF9 File Offset: 0x005D01F9
	public static void ResetStaticDefaultValue()
	{
		SignalDecodeConfig._Instance = null;
	}

	// Token: 0x06013F5F RID: 81759 RVA: 0x005D2001 File Offset: 0x005D0201
	static SignalDecodeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SignalDecodeConfig.CreateStaticDefaultValue), new Action(SignalDecodeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400AA00 RID: 43520
	[Nullable(2)]
	private static SignalDecodeConfig _Instance;
}
