using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020012FE RID: 4862
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BusinessConfig : ConfigBase
{
	// Token: 0x0600868A RID: 34442 RVA: 0x001CB8D8 File Offset: 0x001C9AD8
	public TrackMoonEntrust GetDelegationConfig(int delegateId)
	{
		return ConfigTrackMoonEntrustById.GetConfig(delegateId, true).Value;
	}

	// Token: 0x0600868B RID: 34443 RVA: 0x001CB8F4 File Offset: 0x001C9AF4
	public Evaluate GetEvaluateByLevel(int level)
	{
		return ConfigEvaluateById.GetConfig(level, true).Value;
	}

	// Token: 0x0600868C RID: 34444 RVA: 0x001CB910 File Offset: 0x001C9B10
	public Character GetCharacterConfig(int id)
	{
		return ConfigCharacterById.GetConfig(id, true).Value;
	}

	// Token: 0x0600868D RID: 34445 RVA: 0x001CB92C File Offset: 0x001C9B2C
	public EntrustRole GetEntrustRoleById(int id)
	{
		return ConfigEntrustRoleById.GetConfig(id, true).Value;
	}

	// Token: 0x0600868E RID: 34446 RVA: 0x001CB948 File Offset: 0x001C9B48
	public IReadOnlyList<EntrustRole> GetEntrustRoleAll()
	{
		return ConfigEntrustRoleAll.GetConfigList(true);
	}

	// Token: 0x0600868F RID: 34447 RVA: 0x001CB950 File Offset: 0x001C9B50
	public IReadOnlyList<Popularity> GetPopularityAll()
	{
		return ConfigPopularityAll.GetConfigList(true);
	}

	// Token: 0x06008690 RID: 34448 RVA: 0x001CB958 File Offset: 0x001C9B58
	public IReadOnlyList<RoleDevelopCurve> GetRoleDevelopCurveByGroupId(int groupId)
	{
		return ConfigRoleDevelopCurveByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x06008691 RID: 34449 RVA: 0x001CB964 File Offset: 0x001C9B64
	public EntrustFinishDialog GetEntrustFinishDialogByIdAndLevel(int id, int level)
	{
		return ConfigEntrustFinishDialogByEntrustIdAndLevel.GetConfig(id, level, true).Value;
	}

	// Token: 0x06008692 RID: 34450 RVA: 0x001CB984 File Offset: 0x001C9B84
	public EntrustType GetEntrustTypeById(int id)
	{
		return ConfigEntrustTypeById.GetConfig(id, true).Value;
	}

	// Token: 0x06008693 RID: 34451 RVA: 0x001CB9A0 File Offset: 0x001C9BA0
	public TrainRoleDialog GetTrainRoleDialogByIdAndType(int id, int type)
	{
		return ConfigTrainRoleDialogByRoleIdAndTrainType.GetConfig(id, type, true).Value;
	}

	// Token: 0x06008694 RID: 34452 RVA: 0x001CB9C0 File Offset: 0x001C9BC0
	public RoleDevelopType GetRoleDevelopTypeById(int id)
	{
		return ConfigRoleDevelopTypeById.GetConfig(id, true).Value;
	}

	// Token: 0x06008695 RID: 34453 RVA: 0x001CB9DC File Offset: 0x001C9BDC
	public int GetPowerItemId()
	{
		return ConfigCommonParamById.GetIntConfig("MoonFiestaEnergyItemId").GetValueOrDefault();
	}

	// Token: 0x06008696 RID: 34454 RVA: 0x001CB9FC File Offset: 0x001C9BFC
	public int GetCoinItemId()
	{
		return ConfigCommonParamById.GetIntConfig("MoonFiestaCoinItemId").GetValueOrDefault();
	}

	// Token: 0x06008697 RID: 34455 RVA: 0x001CBA1C File Offset: 0x001C9C1C
	public int GetWishItemId()
	{
		return ConfigCommonParamById.GetIntConfig("MoonFiestaWishItemId").GetValueOrDefault();
	}

	// Token: 0x06008698 RID: 34456 RVA: 0x001CBA3C File Offset: 0x001C9C3C
	public int GetPopularityItemId()
	{
		return ConfigCommonParamById.GetIntConfig("MoonFiestaPopularityItemId").GetValueOrDefault();
	}

	// Token: 0x06008699 RID: 34457 RVA: 0x001CBA5C File Offset: 0x001C9C5C
	public int GetTokenItemId()
	{
		return ConfigCommonParamById.GetIntConfig("MoonFiestaTokenItemId").GetValueOrDefault();
	}

	// Token: 0x0600869A RID: 34458 RVA: 0x001CBA7B File Offset: 0x001C9C7B
	public string GetTipsCommonRoleIcon()
	{
		return ConfigCommonParamById.GetStringConfig("MoonFiestaHintRole") ?? "";
	}

	// Token: 0x0600869B RID: 34459 RVA: 0x001CBA90 File Offset: 0x001C9C90
	public int GetSkipAnimDelayTime()
	{
		return ConfigCommonParamById.GetIntConfig("MoonChasingBusinessSkipAnimDelayTime").GetValueOrDefault();
	}

	// Token: 0x0600869C RID: 34460 RVA: 0x001CBAB0 File Offset: 0x001C9CB0
	public int GetEntrustScoreMax()
	{
		return ConfigCommonParamById.GetIntConfig("MoonChasingEntrustScoreMax").GetValueOrDefault();
	}

	// Token: 0x0600869D RID: 34461 RVA: 0x001CBAD0 File Offset: 0x001C9CD0
	public int GetRoleCharacterMax()
	{
		return ConfigCommonParamById.GetIntConfig("MoonChasingRoleCharacterMax").GetValueOrDefault();
	}

	// Token: 0x17000B88 RID: 2952
	// (get) Token: 0x0600869E RID: 34462 RVA: 0x001CBAEF File Offset: 0x001C9CEF
	public static BusinessConfig Instance
	{
		get
		{
			return BusinessConfig._Instance;
		}
	}

	// Token: 0x0600869F RID: 34463 RVA: 0x001CBAF6 File Offset: 0x001C9CF6
	public static BusinessConfig GetOrCreateInstance()
	{
		if (BusinessConfig._Instance == null)
		{
			BusinessConfig.CreateInstance();
		}
		return BusinessConfig._Instance;
	}

	// Token: 0x060086A0 RID: 34464 RVA: 0x001CBB0A File Offset: 0x001C9D0A
	public static bool CreateInstance()
	{
		if (BusinessConfig._Instance != null)
		{
			return true;
		}
		BusinessConfig._Instance = new BusinessConfig();
		return true;
	}

	// Token: 0x060086A1 RID: 34465 RVA: 0x001CBB20 File Offset: 0x001C9D20
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060086A2 RID: 34466 RVA: 0x001CBB22 File Offset: 0x001C9D22
	public static void ResetStaticDefaultValue()
	{
		BusinessConfig._Instance = null;
	}

	// Token: 0x060086A3 RID: 34467 RVA: 0x001CBB2A File Offset: 0x001C9D2A
	static BusinessConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BusinessConfig.CreateStaticDefaultValue), new Action(BusinessConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003C34 RID: 15412
	[Nullable(2)]
	private static BusinessConfig _Instance;
}
