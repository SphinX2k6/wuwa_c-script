using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001D4B RID: 7499
[NullableContext(1)]
[Nullable(0)]
public class GamepadConfig : ConfigBase
{
	// Token: 0x0600E379 RID: 58233 RVA: 0x003571B8 File Offset: 0x003553B8
	public PsFeedback? GetPsFeedbackReason(string reason)
	{
		return ConfigPsFeedbackById.GetConfig(reason, true);
	}

	// Token: 0x0600E37A RID: 58234 RVA: 0x003571C1 File Offset: 0x003553C1
	[NullableContext(2)]
	public IReadOnlyList<PsFeedback> GetAllPsFeedbackConfig()
	{
		return ConfigPsFeedbackAll.GetConfigList(true);
	}

	// Token: 0x17001226 RID: 4646
	// (get) Token: 0x0600E37B RID: 58235 RVA: 0x003571C9 File Offset: 0x003553C9
	public static GamepadConfig Instance
	{
		get
		{
			return GamepadConfig._Instance;
		}
	}

	// Token: 0x0600E37C RID: 58236 RVA: 0x003571D0 File Offset: 0x003553D0
	public static GamepadConfig GetOrCreateInstance()
	{
		if (GamepadConfig._Instance == null)
		{
			GamepadConfig.CreateInstance();
		}
		return GamepadConfig._Instance;
	}

	// Token: 0x0600E37D RID: 58237 RVA: 0x003571E4 File Offset: 0x003553E4
	public static bool CreateInstance()
	{
		if (GamepadConfig._Instance != null)
		{
			return true;
		}
		GamepadConfig._Instance = new GamepadConfig();
		return true;
	}

	// Token: 0x0600E37E RID: 58238 RVA: 0x003571FA File Offset: 0x003553FA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E37F RID: 58239 RVA: 0x003571FC File Offset: 0x003553FC
	public static void ResetStaticDefaultValue()
	{
		GamepadConfig._Instance = null;
	}

	// Token: 0x0600E380 RID: 58240 RVA: 0x00357204 File Offset: 0x00355404
	static GamepadConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GamepadConfig.CreateStaticDefaultValue), new Action(GamepadConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006903 RID: 26883
	[Nullable(2)]
	private static GamepadConfig _Instance;
}
