using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000749 RID: 1865
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class LifePointDrawConfig : ConfigBase
{
	// Token: 0x060055B9 RID: 21945 RVA: 0x001C2538 File Offset: 0x001C0738
	public LifePointEntrance? GetLifePointEntranceById(int id)
	{
		return ConfigLifePointEntranceById.GetConfig(id, true);
	}

	// Token: 0x060055BA RID: 21946 RVA: 0x001C2541 File Offset: 0x001C0741
	public LifePointGroup? GetLifePointGroupByGroupId(int groupId)
	{
		return ConfigLifePointGroupByGroupId.GetConfig(groupId, true);
	}

	// Token: 0x060055BB RID: 21947 RVA: 0x001C254A File Offset: 0x001C074A
	public LifePointChallenge? GetLifePointChallengeById(int id)
	{
		return ConfigLifePointChallengeById.GetConfig(id, true);
	}

	// Token: 0x060055BC RID: 21948 RVA: 0x001C2553 File Offset: 0x001C0753
	public LifePointActivity? GetLifePointDrawActivityById(int id)
	{
		return ConfigLifePointActivityByActivityId.GetConfig(id, true);
	}

	// Token: 0x17000B4D RID: 2893
	// (get) Token: 0x060055BD RID: 21949 RVA: 0x001C255C File Offset: 0x001C075C
	public static LifePointDrawConfig Instance
	{
		get
		{
			return LifePointDrawConfig._Instance;
		}
	}

	// Token: 0x060055BE RID: 21950 RVA: 0x001C2563 File Offset: 0x001C0763
	public static LifePointDrawConfig GetOrCreateInstance()
	{
		if (LifePointDrawConfig._Instance == null)
		{
			LifePointDrawConfig.CreateInstance();
		}
		return LifePointDrawConfig._Instance;
	}

	// Token: 0x060055BF RID: 21951 RVA: 0x001C2577 File Offset: 0x001C0777
	public static bool CreateInstance()
	{
		if (LifePointDrawConfig._Instance != null)
		{
			return true;
		}
		LifePointDrawConfig._Instance = new LifePointDrawConfig();
		return true;
	}

	// Token: 0x060055C0 RID: 21952 RVA: 0x001C258D File Offset: 0x001C078D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060055C1 RID: 21953 RVA: 0x001C258F File Offset: 0x001C078F
	public static void ResetStaticDefaultValue()
	{
		LifePointDrawConfig._Instance = null;
	}

	// Token: 0x060055C2 RID: 21954 RVA: 0x001C2597 File Offset: 0x001C0797
	static LifePointDrawConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LifePointDrawConfig.CreateStaticDefaultValue), new Action(LifePointDrawConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003B6B RID: 15211
	[Nullable(2)]
	private static LifePointDrawConfig _Instance;
}
