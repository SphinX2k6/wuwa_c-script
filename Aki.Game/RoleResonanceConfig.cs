using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001E55 RID: 7765
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class RoleResonanceConfig : ConfigBase
{
	// Token: 0x06013368 RID: 78696 RVA: 0x0059D98C File Offset: 0x0059BB8C
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

	// Token: 0x06013369 RID: 78697 RVA: 0x0059D9D1 File Offset: 0x0059BBD1
	public ResonantChain? GetRoleResonanceById(int resonanceId)
	{
		return ConfigResonantChainById.GetConfig(resonanceId, true);
	}

	// Token: 0x0601336A RID: 78698 RVA: 0x0059D9DC File Offset: 0x0059BBDC
	public int GetResonanceMaxLevel()
	{
		return ConfigCommonParamById.GetIntConfig("ResonantChainMaxLevel").Value;
	}

	// Token: 0x17001D57 RID: 7511
	// (get) Token: 0x0601336B RID: 78699 RVA: 0x0059D9FB File Offset: 0x0059BBFB
	public static RoleResonanceConfig Instance
	{
		get
		{
			return RoleResonanceConfig._Instance;
		}
	}

	// Token: 0x0601336C RID: 78700 RVA: 0x0059DA02 File Offset: 0x0059BC02
	public static RoleResonanceConfig GetOrCreateInstance()
	{
		if (RoleResonanceConfig._Instance == null)
		{
			RoleResonanceConfig.CreateInstance();
		}
		return RoleResonanceConfig._Instance;
	}

	// Token: 0x0601336D RID: 78701 RVA: 0x0059DA16 File Offset: 0x0059BC16
	public static bool CreateInstance()
	{
		if (RoleResonanceConfig._Instance != null)
		{
			return true;
		}
		RoleResonanceConfig._Instance = new RoleResonanceConfig();
		return true;
	}

	// Token: 0x0601336E RID: 78702 RVA: 0x0059DA2C File Offset: 0x0059BC2C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601336F RID: 78703 RVA: 0x0059DA2E File Offset: 0x0059BC2E
	public static void ResetStaticDefaultValue()
	{
		RoleResonanceConfig._Instance = null;
	}

	// Token: 0x06013370 RID: 78704 RVA: 0x0059DA36 File Offset: 0x0059BC36
	static RoleResonanceConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleResonanceConfig.CreateStaticDefaultValue), new Action(RoleResonanceConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A49C RID: 42140
	[Nullable(2)]
	private static RoleResonanceConfig _Instance;
}
