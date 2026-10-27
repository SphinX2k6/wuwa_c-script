using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001295 RID: 4757
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class LifePointDrawConfig : ConfigBase
{
	// Token: 0x06008222 RID: 33314 RVA: 0x001B9868 File Offset: 0x001B7A68
	public LifePointEntrance? GetLifePointEntranceById(int id)
	{
		return ConfigLifePointEntranceById.GetConfig(id, true);
	}

	// Token: 0x06008223 RID: 33315 RVA: 0x001B9871 File Offset: 0x001B7A71
	public LifePointGroup? GetLifePointGroupByGroupId(int groupId)
	{
		return ConfigLifePointGroupByGroupId.GetConfig(groupId, true);
	}

	// Token: 0x06008224 RID: 33316 RVA: 0x001B987A File Offset: 0x001B7A7A
	public LifePointChallenge? GetLifePointChallengeById(int id)
	{
		return ConfigLifePointChallengeById.GetConfig(id, true);
	}

	// Token: 0x06008225 RID: 33317 RVA: 0x001B9883 File Offset: 0x001B7A83
	public LifePointActivity? GetLifePointDrawActivityById(int id)
	{
		return ConfigLifePointActivityByActivityId.GetConfig(id, true);
	}

	// Token: 0x17000B2D RID: 2861
	// (get) Token: 0x06008226 RID: 33318 RVA: 0x001B988C File Offset: 0x001B7A8C
	public static LifePointDrawConfig Instance
	{
		get
		{
			return LifePointDrawConfig._Instance;
		}
	}

	// Token: 0x06008227 RID: 33319 RVA: 0x001B9893 File Offset: 0x001B7A93
	public static LifePointDrawConfig GetOrCreateInstance()
	{
		if (LifePointDrawConfig._Instance == null)
		{
			LifePointDrawConfig.CreateInstance();
		}
		return LifePointDrawConfig._Instance;
	}

	// Token: 0x06008228 RID: 33320 RVA: 0x001B98A7 File Offset: 0x001B7AA7
	public static bool CreateInstance()
	{
		if (LifePointDrawConfig._Instance != null)
		{
			return true;
		}
		LifePointDrawConfig._Instance = new LifePointDrawConfig();
		return true;
	}

	// Token: 0x06008229 RID: 33321 RVA: 0x001B98BD File Offset: 0x001B7ABD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600822A RID: 33322 RVA: 0x001B98BF File Offset: 0x001B7ABF
	public static void ResetStaticDefaultValue()
	{
		LifePointDrawConfig._Instance = null;
	}

	// Token: 0x0600822B RID: 33323 RVA: 0x001B98C7 File Offset: 0x001B7AC7
	static LifePointDrawConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LifePointDrawConfig.CreateStaticDefaultValue), new Action(LifePointDrawConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003AD3 RID: 15059
	[Nullable(2)]
	private static LifePointDrawConfig _Instance;
}
