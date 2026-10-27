using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020028DA RID: 10458
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class RoleResonanceConfig : ConfigBase
{
	// Token: 0x06015964 RID: 88420 RVA: 0x00572AC4 File Offset: 0x00570CC4
	[NullableContext(2)]
	public List<ResonantChain> GetRoleResonanceList(int groupId)
	{
		List<ResonantChain> list = ConfigCommon.ToList<ResonantChain>(ConfigResonantChainByGroupId.GetConfigList(groupId, true));
		if (list == null)
		{
			return null;
		}
		list.Sort((ResonantChain a, ResonantChain b) => a.GroupIndex - b.GroupIndex);
		return list;
	}

	// Token: 0x06015965 RID: 88421 RVA: 0x00572B09 File Offset: 0x00570D09
	public ResonantChain? GetRoleResonanceById(int resonanceId)
	{
		return ConfigResonantChainById.GetConfig(resonanceId, true);
	}

	// Token: 0x06015966 RID: 88422 RVA: 0x00572B14 File Offset: 0x00570D14
	public int GetResonanceMaxLevel()
	{
		return ConfigCommonParamById.GetIntConfig("ResonantChainMaxLevel").Value;
	}

	// Token: 0x17001CFD RID: 7421
	// (get) Token: 0x06015967 RID: 88423 RVA: 0x00572B33 File Offset: 0x00570D33
	public static RoleResonanceConfig Instance
	{
		get
		{
			return RoleResonanceConfig._Instance;
		}
	}

	// Token: 0x06015968 RID: 88424 RVA: 0x00572B3A File Offset: 0x00570D3A
	public static RoleResonanceConfig GetOrCreateInstance()
	{
		if (RoleResonanceConfig._Instance == null)
		{
			RoleResonanceConfig.CreateInstance();
		}
		return RoleResonanceConfig._Instance;
	}

	// Token: 0x06015969 RID: 88425 RVA: 0x00572B4E File Offset: 0x00570D4E
	public static bool CreateInstance()
	{
		if (RoleResonanceConfig._Instance != null)
		{
			return true;
		}
		RoleResonanceConfig._Instance = new RoleResonanceConfig();
		return true;
	}

	// Token: 0x0601596A RID: 88426 RVA: 0x00572B64 File Offset: 0x00570D64
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601596B RID: 88427 RVA: 0x00572B66 File Offset: 0x00570D66
	public static void ResetStaticDefaultValue()
	{
		RoleResonanceConfig._Instance = null;
	}

	// Token: 0x0601596C RID: 88428 RVA: 0x00572B6E File Offset: 0x00570D6E
	static RoleResonanceConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleResonanceConfig.CreateStaticDefaultValue), new Action(RoleResonanceConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A0B2 RID: 41138
	[Nullable(2)]
	private static RoleResonanceConfig _Instance;
}
