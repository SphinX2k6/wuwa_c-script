using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200120D RID: 4621
[NullableContext(1)]
[Nullable(0)]
public class GamepadConfig : ConfigBase
{
	// Token: 0x0600B796 RID: 46998 RVA: 0x00362BE8 File Offset: 0x00360DE8
	public PsFeedback? GetPsFeedbackReason(string reason)
	{
		return ConfigPsFeedbackById.GetConfig(reason, true);
	}

	// Token: 0x0600B797 RID: 46999 RVA: 0x00362BF1 File Offset: 0x00360DF1
	[NullableContext(2)]
	public IReadOnlyList<PsFeedback> GetAllPsFeedbackConfig()
	{
		return ConfigPsFeedbackAll.GetConfigList(true);
	}

	// Token: 0x17001250 RID: 4688
	// (get) Token: 0x0600B798 RID: 47000 RVA: 0x00362BF9 File Offset: 0x00360DF9
	public static GamepadConfig Instance
	{
		get
		{
			return GamepadConfig._Instance;
		}
	}

	// Token: 0x0600B799 RID: 47001 RVA: 0x00362C00 File Offset: 0x00360E00
	public static GamepadConfig GetOrCreateInstance()
	{
		if (GamepadConfig._Instance == null)
		{
			GamepadConfig.CreateInstance();
		}
		return GamepadConfig._Instance;
	}

	// Token: 0x0600B79A RID: 47002 RVA: 0x00362C14 File Offset: 0x00360E14
	public static bool CreateInstance()
	{
		if (GamepadConfig._Instance != null)
		{
			return true;
		}
		GamepadConfig._Instance = new GamepadConfig();
		return true;
	}

	// Token: 0x0600B79B RID: 47003 RVA: 0x00362C2A File Offset: 0x00360E2A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B79C RID: 47004 RVA: 0x00362C2C File Offset: 0x00360E2C
	public static void ResetStaticDefaultValue()
	{
		GamepadConfig._Instance = null;
	}

	// Token: 0x0600B79D RID: 47005 RVA: 0x00362C34 File Offset: 0x00360E34
	static GamepadConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GamepadConfig.CreateStaticDefaultValue), new Action(GamepadConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040069E2 RID: 27106
	[Nullable(2)]
	private static GamepadConfig _Instance;
}
