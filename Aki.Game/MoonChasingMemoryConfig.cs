using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020007F8 RID: 2040
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MoonChasingMemoryConfig : ConfigBase
{
	// Token: 0x06005CE7 RID: 23783 RVA: 0x001DE0E3 File Offset: 0x001DC2E3
	public IReadOnlyList<TrackMoonMemory> GetMemoryByClassify(int classify)
	{
		return ConfigTrackMoonMemoryByClassify.GetConfigList(classify, true) ?? new List<TrackMoonMemory>();
	}

	// Token: 0x06005CE8 RID: 23784 RVA: 0x001DE0F5 File Offset: 0x001DC2F5
	public TrackMoonMemory? GetMemoryById(int id)
	{
		return ConfigTrackMoonMemoryById.GetConfig(id, true);
	}

	// Token: 0x06005CE9 RID: 23785 RVA: 0x001DE0FE File Offset: 0x001DC2FE
	public IReadOnlyList<TrackMoonMemory> GetAllMemoryInfo()
	{
		return ConfigTrackMoonMemoryAll.GetConfigList(true) ?? new List<TrackMoonMemory>();
	}

	// Token: 0x17000BD9 RID: 3033
	// (get) Token: 0x06005CEA RID: 23786 RVA: 0x001DE10F File Offset: 0x001DC30F
	public static MoonChasingMemoryConfig Instance
	{
		get
		{
			return MoonChasingMemoryConfig._Instance;
		}
	}

	// Token: 0x06005CEB RID: 23787 RVA: 0x001DE116 File Offset: 0x001DC316
	public static MoonChasingMemoryConfig GetOrCreateInstance()
	{
		if (MoonChasingMemoryConfig._Instance == null)
		{
			MoonChasingMemoryConfig.CreateInstance();
		}
		return MoonChasingMemoryConfig._Instance;
	}

	// Token: 0x06005CEC RID: 23788 RVA: 0x001DE12A File Offset: 0x001DC32A
	public static bool CreateInstance()
	{
		if (MoonChasingMemoryConfig._Instance != null)
		{
			return true;
		}
		MoonChasingMemoryConfig._Instance = new MoonChasingMemoryConfig();
		return true;
	}

	// Token: 0x06005CED RID: 23789 RVA: 0x001DE140 File Offset: 0x001DC340
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005CEE RID: 23790 RVA: 0x001DE142 File Offset: 0x001DC342
	public static void ResetStaticDefaultValue()
	{
		MoonChasingMemoryConfig._Instance = null;
	}

	// Token: 0x06005CEF RID: 23791 RVA: 0x001DE14A File Offset: 0x001DC34A
	static MoonChasingMemoryConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonChasingMemoryConfig.CreateStaticDefaultValue), new Action(MoonChasingMemoryConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003DD8 RID: 15832
	[Nullable(2)]
	private static MoonChasingMemoryConfig _Instance;
}
