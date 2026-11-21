using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020007B2 RID: 1970
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BusinessConfig : ConfigBase
{
	// Token: 0x06005A25 RID: 23077 RVA: 0x001D4744 File Offset: 0x001D2944
	public TrackMoonEntrust GetDelegationConfig(int delegateId)
	{
		return ConfigTrackMoonEntrustById.GetConfig(delegateId, true).Value;
	}

	// Token: 0x06005A26 RID: 23078 RVA: 0x001D4760 File Offset: 0x001D2960
	public Evaluate GetEvaluateByLevel(int level)
	{
		return ConfigEvaluateById.GetConfig(level, true).Value;
	}

	// Token: 0x06005A27 RID: 23079 RVA: 0x001D477C File Offset: 0x001D297C
	public Character GetCharacterConfig(int id)
	{
		return ConfigCharacterById.GetConfig(id, true).Value;
	}

	// Token: 0x06005A28 RID: 23080 RVA: 0x001D4798 File Offset: 0x001D2998
	public EntrustRole GetEntrustRoleById(int id)
	{
		return ConfigEntrustRoleById.GetConfig(id, true).Value;
	}

	// Token: 0x06005A29 RID: 23081 RVA: 0x001D47B4 File Offset: 0x001D29B4
	public IReadOnlyList<EntrustRole> GetEntrustRoleAll()
	{
		return ConfigEntrustRoleAll.GetConfigList(true);
	}

	// Token: 0x06005A2A RID: 23082 RVA: 0x001D47BC File Offset: 0x001D29BC
	public IReadOnlyList<Popularity> GetPopularityAll()
	{
		return ConfigPopularityAll.GetConfigList(true);
	}

	// Token: 0x06005A2B RID: 23083 RVA: 0x001D47C4 File Offset: 0x001D29C4
	public IReadOnlyList<RoleDevelopCurve> GetRoleDevelopCurveByGroupId(int groupId)
	{
		return ConfigRoleDevelopCurveByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x06005A2C RID: 23084 RVA: 0x001D47D0 File Offset: 0x001D29D0
	public EntrustFinishDialog GetEntrustFinishDialogByIdAndLevel(int id, int level)
	{
		return ConfigEntrustFinishDialogByEntrustIdAndLevel.GetConfig(id, level, true).Value;
	}

	// Token: 0x06005A2D RID: 23085 RVA: 0x001D47F0 File Offset: 0x001D29F0
	public EntrustType GetEntrustTypeById(int id)
	{
		return ConfigEntrustTypeById.GetConfig(id, true).Value;
	}

	// Token: 0x06005A2E RID: 23086 RVA: 0x001D480C File Offset: 0x001D2A0C
	public TrainRoleDialog GetTrainRoleDialogByIdAndType(int id, int type)
	{
		return ConfigTrainRoleDialogByRoleIdAndTrainType.GetConfig(id, type, true).Value;
	}

	// Token: 0x06005A2F RID: 23087 RVA: 0x001D482C File Offset: 0x001D2A2C
	public RoleDevelopType GetRoleDevelopTypeById(int id)
	{
		return ConfigRoleDevelopTypeById.GetConfig(id, true).Value;
	}

	// Token: 0x06005A30 RID: 23088 RVA: 0x001D4848 File Offset: 0x001D2A48
	public int GetPowerItemId()
	{
		return ConfigCommonParamById.GetIntConfig("MoonFiestaEnergyItemId").GetValueOrDefault();
	}

	// Token: 0x06005A31 RID: 23089 RVA: 0x001D4868 File Offset: 0x001D2A68
	public int GetCoinItemId()
	{
		return ConfigCommonParamById.GetIntConfig("MoonFiestaCoinItemId").GetValueOrDefault();
	}

	// Token: 0x06005A32 RID: 23090 RVA: 0x001D4888 File Offset: 0x001D2A88
	public int GetWishItemId()
	{
		return ConfigCommonParamById.GetIntConfig("MoonFiestaWishItemId").GetValueOrDefault();
	}

	// Token: 0x06005A33 RID: 23091 RVA: 0x001D48A8 File Offset: 0x001D2AA8
	public int GetPopularityItemId()
	{
		return ConfigCommonParamById.GetIntConfig("MoonFiestaPopularityItemId").GetValueOrDefault();
	}

	// Token: 0x06005A34 RID: 23092 RVA: 0x001D48C8 File Offset: 0x001D2AC8
	public int GetTokenItemId()
	{
		return ConfigCommonParamById.GetIntConfig("MoonFiestaTokenItemId").GetValueOrDefault();
	}

	// Token: 0x06005A35 RID: 23093 RVA: 0x001D48E7 File Offset: 0x001D2AE7
	public string GetTipsCommonRoleIcon()
	{
		return ConfigCommonParamById.GetStringConfig("MoonFiestaHintRole") ?? "";
	}

	// Token: 0x06005A36 RID: 23094 RVA: 0x001D48FC File Offset: 0x001D2AFC
	public int GetSkipAnimDelayTime()
	{
		return ConfigCommonParamById.GetIntConfig("MoonChasingBusinessSkipAnimDelayTime").GetValueOrDefault();
	}

	// Token: 0x06005A37 RID: 23095 RVA: 0x001D491C File Offset: 0x001D2B1C
	public int GetEntrustScoreMax()
	{
		return ConfigCommonParamById.GetIntConfig("MoonChasingEntrustScoreMax").GetValueOrDefault();
	}

	// Token: 0x06005A38 RID: 23096 RVA: 0x001D493C File Offset: 0x001D2B3C
	public int GetRoleCharacterMax()
	{
		return ConfigCommonParamById.GetIntConfig("MoonChasingRoleCharacterMax").GetValueOrDefault();
	}

	// Token: 0x17000BA8 RID: 2984
	// (get) Token: 0x06005A39 RID: 23097 RVA: 0x001D495B File Offset: 0x001D2B5B
	public static BusinessConfig Instance
	{
		get
		{
			return BusinessConfig._Instance;
		}
	}

	// Token: 0x06005A3A RID: 23098 RVA: 0x001D4962 File Offset: 0x001D2B62
	public static BusinessConfig GetOrCreateInstance()
	{
		if (BusinessConfig._Instance == null)
		{
			BusinessConfig.CreateInstance();
		}
		return BusinessConfig._Instance;
	}

	// Token: 0x06005A3B RID: 23099 RVA: 0x001D4976 File Offset: 0x001D2B76
	public static bool CreateInstance()
	{
		if (BusinessConfig._Instance != null)
		{
			return true;
		}
		BusinessConfig._Instance = new BusinessConfig();
		return true;
	}

	// Token: 0x06005A3C RID: 23100 RVA: 0x001D498C File Offset: 0x001D2B8C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005A3D RID: 23101 RVA: 0x001D498E File Offset: 0x001D2B8E
	public static void ResetStaticDefaultValue()
	{
		BusinessConfig._Instance = null;
	}

	// Token: 0x06005A3E RID: 23102 RVA: 0x001D4996 File Offset: 0x001D2B96
	static BusinessConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BusinessConfig.CreateStaticDefaultValue), new Action(BusinessConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003CCC RID: 15564
	[Nullable(2)]
	private static BusinessConfig _Instance;
}
