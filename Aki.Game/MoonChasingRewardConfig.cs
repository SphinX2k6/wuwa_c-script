using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200080F RID: 2063
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MoonChasingRewardConfig : ConfigBase
{
	// Token: 0x06005DAB RID: 23979 RVA: 0x001E0FBC File Offset: 0x001DF1BC
	public IReadOnlyList<TrackMoonTargetType> GetAllRewardTargetTypeList()
	{
		return ConfigTrackMoonTargetTypeAll.GetConfigList(true);
	}

	// Token: 0x06005DAC RID: 23980 RVA: 0x001E0FC4 File Offset: 0x001DF1C4
	public TrackMoonTarget GetRewardTargetById(int id)
	{
		return ConfigTrackMoonTargetById.GetConfig(id, true).Value;
	}

	// Token: 0x17000BDF RID: 3039
	// (get) Token: 0x06005DAD RID: 23981 RVA: 0x001E0FE0 File Offset: 0x001DF1E0
	public static MoonChasingRewardConfig Instance
	{
		get
		{
			return MoonChasingRewardConfig._Instance;
		}
	}

	// Token: 0x06005DAE RID: 23982 RVA: 0x001E0FE7 File Offset: 0x001DF1E7
	public static MoonChasingRewardConfig GetOrCreateInstance()
	{
		if (MoonChasingRewardConfig._Instance == null)
		{
			MoonChasingRewardConfig.CreateInstance();
		}
		return MoonChasingRewardConfig._Instance;
	}

	// Token: 0x06005DAF RID: 23983 RVA: 0x001E0FFB File Offset: 0x001DF1FB
	public static bool CreateInstance()
	{
		if (MoonChasingRewardConfig._Instance != null)
		{
			return true;
		}
		MoonChasingRewardConfig._Instance = new MoonChasingRewardConfig();
		return true;
	}

	// Token: 0x06005DB0 RID: 23984 RVA: 0x001E1011 File Offset: 0x001DF211
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005DB1 RID: 23985 RVA: 0x001E1013 File Offset: 0x001DF213
	public static void ResetStaticDefaultValue()
	{
		MoonChasingRewardConfig._Instance = null;
	}

	// Token: 0x06005DB2 RID: 23986 RVA: 0x001E101B File Offset: 0x001DF21B
	static MoonChasingRewardConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonChasingRewardConfig.CreateStaticDefaultValue), new Action(MoonChasingRewardConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003E29 RID: 15913
	[Nullable(2)]
	private static MoonChasingRewardConfig _Instance;
}
