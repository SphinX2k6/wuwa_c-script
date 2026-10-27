using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002D6E RID: 11630
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class WorldLevelConfig : ConfigBase
{
	// Token: 0x0601874C RID: 100172 RVA: 0x00639C40 File Offset: 0x00637E40
	public WorldLevel? GetWorldLevelConfig(int worldLevel)
	{
		WorldLevel? config = ConfigWorldLevelById.GetConfig(worldLevel, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.WorldLevel;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到worldLevel = 的配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("worldLevel", worldLevel);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0601874D RID: 100173 RVA: 0x00639C95 File Offset: 0x00637E95
	public int? GetCommonValue(string keyName)
	{
		return ConfigCommonParamById.GetIntConfig(keyName);
	}

	// Token: 0x17002109 RID: 8457
	// (get) Token: 0x0601874E RID: 100174 RVA: 0x00639C9D File Offset: 0x00637E9D
	public static WorldLevelConfig Instance
	{
		get
		{
			return WorldLevelConfig._Instance;
		}
	}

	// Token: 0x0601874F RID: 100175 RVA: 0x00639CA4 File Offset: 0x00637EA4
	public static WorldLevelConfig GetOrCreateInstance()
	{
		if (WorldLevelConfig._Instance == null)
		{
			WorldLevelConfig.CreateInstance();
		}
		return WorldLevelConfig._Instance;
	}

	// Token: 0x06018750 RID: 100176 RVA: 0x00639CB8 File Offset: 0x00637EB8
	public static bool CreateInstance()
	{
		if (WorldLevelConfig._Instance != null)
		{
			return true;
		}
		WorldLevelConfig._Instance = new WorldLevelConfig();
		return true;
	}

	// Token: 0x06018751 RID: 100177 RVA: 0x00639CCE File Offset: 0x00637ECE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06018752 RID: 100178 RVA: 0x00639CD0 File Offset: 0x00637ED0
	public static void ResetStaticDefaultValue()
	{
		WorldLevelConfig._Instance = null;
	}

	// Token: 0x06018753 RID: 100179 RVA: 0x00639CD8 File Offset: 0x00637ED8
	static WorldLevelConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WorldLevelConfig.CreateStaticDefaultValue), new Action(WorldLevelConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400B555 RID: 46421
	[Nullable(2)]
	private static WorldLevelConfig _Instance;
}
