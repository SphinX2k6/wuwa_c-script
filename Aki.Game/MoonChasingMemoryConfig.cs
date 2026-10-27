using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001344 RID: 4932
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MoonChasingMemoryConfig : ConfigBase
{
	// Token: 0x0600894C RID: 35148 RVA: 0x001D5277 File Offset: 0x001D3477
	public IReadOnlyList<TrackMoonMemory> GetMemoryByClassify(int classify)
	{
		return ConfigTrackMoonMemoryByClassify.GetConfigList(classify, true) ?? new List<TrackMoonMemory>();
	}

	// Token: 0x0600894D RID: 35149 RVA: 0x001D5289 File Offset: 0x001D3489
	public TrackMoonMemory? GetMemoryById(int id)
	{
		return ConfigTrackMoonMemoryById.GetConfig(id, true);
	}

	// Token: 0x0600894E RID: 35150 RVA: 0x001D5292 File Offset: 0x001D3492
	public IReadOnlyList<TrackMoonMemory> GetAllMemoryInfo()
	{
		return ConfigTrackMoonMemoryAll.GetConfigList(true) ?? new List<TrackMoonMemory>();
	}

	// Token: 0x17000BB9 RID: 3001
	// (get) Token: 0x0600894F RID: 35151 RVA: 0x001D52A3 File Offset: 0x001D34A3
	public static MoonChasingMemoryConfig Instance
	{
		get
		{
			return MoonChasingMemoryConfig._Instance;
		}
	}

	// Token: 0x06008950 RID: 35152 RVA: 0x001D52AA File Offset: 0x001D34AA
	public static MoonChasingMemoryConfig GetOrCreateInstance()
	{
		if (MoonChasingMemoryConfig._Instance == null)
		{
			MoonChasingMemoryConfig.CreateInstance();
		}
		return MoonChasingMemoryConfig._Instance;
	}

	// Token: 0x06008951 RID: 35153 RVA: 0x001D52BE File Offset: 0x001D34BE
	public static bool CreateInstance()
	{
		if (MoonChasingMemoryConfig._Instance != null)
		{
			return true;
		}
		MoonChasingMemoryConfig._Instance = new MoonChasingMemoryConfig();
		return true;
	}

	// Token: 0x06008952 RID: 35154 RVA: 0x001D52D4 File Offset: 0x001D34D4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008953 RID: 35155 RVA: 0x001D52D6 File Offset: 0x001D34D6
	public static void ResetStaticDefaultValue()
	{
		MoonChasingMemoryConfig._Instance = null;
	}

	// Token: 0x06008954 RID: 35156 RVA: 0x001D52DE File Offset: 0x001D34DE
	static MoonChasingMemoryConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonChasingMemoryConfig.CreateStaticDefaultValue), new Action(MoonChasingMemoryConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003D40 RID: 15680
	[Nullable(2)]
	private static MoonChasingMemoryConfig _Instance;
}
