using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020022C8 RID: 8904
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class WorldLevelConfig : ConfigBase
{
	// Token: 0x06015FEE RID: 90094 RVA: 0x0065FC58 File Offset: 0x0065DE58
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

	// Token: 0x06015FEF RID: 90095 RVA: 0x0065FCAD File Offset: 0x0065DEAD
	public int? GetCommonValue(string keyName)
	{
		return ConfigCommonParamById.GetIntConfig(keyName);
	}

	// Token: 0x17002164 RID: 8548
	// (get) Token: 0x06015FF0 RID: 90096 RVA: 0x0065FCB5 File Offset: 0x0065DEB5
	public static WorldLevelConfig Instance
	{
		get
		{
			return WorldLevelConfig._Instance;
		}
	}

	// Token: 0x06015FF1 RID: 90097 RVA: 0x0065FCBC File Offset: 0x0065DEBC
	public static WorldLevelConfig GetOrCreateInstance()
	{
		if (WorldLevelConfig._Instance == null)
		{
			WorldLevelConfig.CreateInstance();
		}
		return WorldLevelConfig._Instance;
	}

	// Token: 0x06015FF2 RID: 90098 RVA: 0x0065FCD0 File Offset: 0x0065DED0
	public static bool CreateInstance()
	{
		if (WorldLevelConfig._Instance != null)
		{
			return true;
		}
		WorldLevelConfig._Instance = new WorldLevelConfig();
		return true;
	}

	// Token: 0x06015FF3 RID: 90099 RVA: 0x0065FCE6 File Offset: 0x0065DEE6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015FF4 RID: 90100 RVA: 0x0065FCE8 File Offset: 0x0065DEE8
	public static void ResetStaticDefaultValue()
	{
		WorldLevelConfig._Instance = null;
	}

	// Token: 0x06015FF5 RID: 90101 RVA: 0x0065FCF0 File Offset: 0x0065DEF0
	static WorldLevelConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WorldLevelConfig.CreateStaticDefaultValue), new Action(WorldLevelConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400B8CA RID: 47306
	[Nullable(2)]
	private static WorldLevelConfig _Instance;
}
