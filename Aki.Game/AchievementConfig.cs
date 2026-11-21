using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

// Token: 0x020003C3 RID: 963
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class AchievementConfig : ConfigBase
{
	// Token: 0x0600349B RID: 13467 RVA: 0x00137601 File Offset: 0x00135801
	public Achievement? GetAchievementConfig(int achievementId)
	{
		return ConfigAchievementById.GetConfig(achievementId, true);
	}

	// Token: 0x0600349C RID: 13468 RVA: 0x0013760A File Offset: 0x0013580A
	[NullableContext(2)]
	public IReadOnlyList<Achievement> GetAchievementGroupAchievementList(int groupId)
	{
		return ConfigAchievementByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x0600349D RID: 13469 RVA: 0x00137613 File Offset: 0x00135813
	public AchievementStarLevel? GetAchievementStarLevelConfig(int level)
	{
		return ConfigAchievementStarLevelByLevel.GetConfig(level, true);
	}

	// Token: 0x0600349E RID: 13470 RVA: 0x0013761C File Offset: 0x0013581C
	public AchievementGroup? GetAchievementGroupConfig(int achievementGroupId)
	{
		return ConfigAchievementGroupById.GetConfig(achievementGroupId, true);
	}

	// Token: 0x0600349F RID: 13471 RVA: 0x00137625 File Offset: 0x00135825
	public AchievementCategory? GetAchievementCategory(int categoryId)
	{
		return ConfigAchievementCategoryById.GetConfig(categoryId, true);
	}

	// Token: 0x060034A0 RID: 13472 RVA: 0x0013762E File Offset: 0x0013582E
	[NullableContext(2)]
	public IReadOnlyList<AchievementCategory> GetAllAchievementCategory()
	{
		return ConfigAchievementCategoryAll.GetConfigList(true);
	}

	// Token: 0x060034A1 RID: 13473 RVA: 0x00137636 File Offset: 0x00135836
	[NullableContext(2)]
	public IReadOnlyList<AchievementGroup> GetAchievementCategoryGroups(int categoryId)
	{
		return ConfigAchievementGroupByCategory.GetConfigList(categoryId, true);
	}

	// Token: 0x060034A2 RID: 13474 RVA: 0x00137640 File Offset: 0x00135840
	public string GetAchievementTitle(int achievementId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetAchievementConfig(achievementId).Value.Name, null);
	}

	// Token: 0x060034A3 RID: 13475 RVA: 0x0013766C File Offset: 0x0013586C
	public string GetAchievementDesc(int achievementId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetAchievementConfig(achievementId).Value.Desc, null);
	}

	// Token: 0x060034A4 RID: 13476 RVA: 0x00137698 File Offset: 0x00135898
	public bool GetAchievementHiddenState(int achievementId)
	{
		return this.GetAchievementConfig(achievementId).Value.Hidden;
	}

	// Token: 0x060034A5 RID: 13477 RVA: 0x001376BC File Offset: 0x001358BC
	public int GetAchievementNextLink(int achievementId)
	{
		Achievement? achievementConfig = this.GetAchievementConfig(achievementId);
		if (achievementConfig == null)
		{
			return 0;
		}
		return achievementConfig.Value.NextLink;
	}

	// Token: 0x060034A6 RID: 13478 RVA: 0x001376EC File Offset: 0x001358EC
	public int GetThirdPartyTrophyId(int achievementId)
	{
		Achievement? achievementConfig = this.GetAchievementConfig(achievementId);
		if (achievementConfig == null)
		{
			return 0;
		}
		return achievementConfig.Value.ThirdPartyTrophyId;
	}

	// Token: 0x060034A7 RID: 13479 RVA: 0x0013771C File Offset: 0x0013591C
	public string GetExternalTrophyId(int achievementId)
	{
		Achievement? achievementConfig = this.GetAchievementConfig(achievementId);
		if (achievementConfig == null)
		{
			return string.Empty;
		}
		return achievementConfig.Value.ExternalTrophyId;
	}

	// Token: 0x060034A8 RID: 13480 RVA: 0x00137750 File Offset: 0x00135950
	public string GetXSXExternalTrophyId(int achievementId)
	{
		Achievement? achievementConfig = this.GetAchievementConfig(achievementId);
		if (achievementConfig == null)
		{
			return string.Empty;
		}
		return achievementConfig.Value.XSXExternalTrophyId;
	}

	// Token: 0x060034A9 RID: 13481 RVA: 0x00137784 File Offset: 0x00135984
	public int GetAchievementLevel(int achievementId)
	{
		Achievement? achievementConfig = this.GetAchievementConfig(achievementId);
		if (achievementConfig == null)
		{
			return 0;
		}
		return achievementConfig.Value.Level;
	}

	// Token: 0x060034AA RID: 13482 RVA: 0x001377B4 File Offset: 0x001359B4
	public int GetAchievementGroup(int achievementId)
	{
		Achievement? achievementConfig = this.GetAchievementConfig(achievementId);
		if (achievementConfig == null)
		{
			return 0;
		}
		return achievementConfig.Value.GroupId;
	}

	// Token: 0x060034AB RID: 13483 RVA: 0x001377E4 File Offset: 0x001359E4
	public string GetAchievementIcon(int achievementId)
	{
		Achievement? achievementConfig = this.GetAchievementConfig(achievementId);
		if (achievementConfig == null)
		{
			return string.Empty;
		}
		return achievementConfig.Value.IconPath;
	}

	// Token: 0x060034AC RID: 13484 RVA: 0x00137818 File Offset: 0x00135A18
	public DropPackage? GetAchievementReward(int achievementId)
	{
		int num = this.GetAchievementConfig(achievementId).Value.OverrideDropId;
		if (num > 0)
		{
			return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(num);
		}
		num = this.GetAchievementStarLevelConfig(this.GetAchievementLevel(achievementId)).Value.DropId;
		return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(num);
	}

	// Token: 0x060034AD RID: 13485 RVA: 0x00137878 File Offset: 0x00135A78
	public string GetAchievementGroupTitleId(int groupId)
	{
		AchievementGroup? achievementGroupConfig = this.GetAchievementGroupConfig(groupId);
		return ((achievementGroupConfig != null) ? achievementGroupConfig.GetValueOrDefault().Name : null) ?? "";
	}

	// Token: 0x060034AE RID: 13486 RVA: 0x001378B1 File Offset: 0x00135AB1
	public string GetAchievementGroupTitle(int groupId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetAchievementGroupTitleId(groupId), null);
	}

	// Token: 0x060034AF RID: 13487 RVA: 0x001378C0 File Offset: 0x00135AC0
	public int GetAchievementGroupSort(int groupId)
	{
		return this.GetAchievementGroupConfig(groupId).Value.Sort;
	}

	// Token: 0x060034B0 RID: 13488 RVA: 0x001378E4 File Offset: 0x00135AE4
	public string GetAchievementGroupIcon(int groupId)
	{
		return this.GetAchievementGroupConfig(groupId).Value.Icon;
	}

	// Token: 0x060034B1 RID: 13489 RVA: 0x00137908 File Offset: 0x00135B08
	public string GetAchievementGroupSmallIcon(int groupId)
	{
		return this.GetAchievementGroupConfig(groupId).Value.SmallIcon;
	}

	// Token: 0x060034B2 RID: 13490 RVA: 0x0013792C File Offset: 0x00135B2C
	public string GetAchievementGroupBackgroundIcon(int groupId)
	{
		return this.GetAchievementGroupConfig(groupId).Value.BackgroundIcon;
	}

	// Token: 0x060034B3 RID: 13491 RVA: 0x00137950 File Offset: 0x00135B50
	public bool GetAchievementGroupEnable(int groupId)
	{
		return this.GetAchievementGroupConfig(groupId).Value.Enable;
	}

	// Token: 0x060034B4 RID: 13492 RVA: 0x00137974 File Offset: 0x00135B74
	public DropPackage? GetAchievementGroupReward(int groupId)
	{
		AchievementGroup? achievementGroupConfig = this.GetAchievementGroupConfig(groupId);
		if (achievementGroupConfig.Value.DropId == 0)
		{
			return null;
		}
		return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(achievementGroupConfig.Value.DropId);
	}

	// Token: 0x060034B5 RID: 13493 RVA: 0x001379C0 File Offset: 0x00135BC0
	public int GetAchievementGroupCategory(int groupId)
	{
		return this.GetAchievementGroupConfig(groupId).Value.Category;
	}

	// Token: 0x060034B6 RID: 13494 RVA: 0x001379E4 File Offset: 0x00135BE4
	public string GetCategoryOriginalTitle(int categoryId)
	{
		AchievementCategory? achievementCategory = this.GetAchievementCategory(categoryId);
		return ((achievementCategory != null) ? achievementCategory.GetValueOrDefault().Name : null) ?? "";
	}

	// Token: 0x060034B7 RID: 13495 RVA: 0x00137A1D File Offset: 0x00135C1D
	public string GetCategoryTitle(int categoryId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetCategoryOriginalTitle(categoryId), null);
	}

	// Token: 0x060034B8 RID: 13496 RVA: 0x00137A2C File Offset: 0x00135C2C
	public string GetCategoryTexture(int categoryId)
	{
		AchievementCategory? achievementCategory = this.GetAchievementCategory(categoryId);
		return ((achievementCategory != null) ? achievementCategory.GetValueOrDefault().TexturePath : null) ?? "";
	}

	// Token: 0x060034B9 RID: 13497 RVA: 0x00137A68 File Offset: 0x00135C68
	public string GetCategorySprite(int categoryId)
	{
		AchievementCategory? achievementCategory = this.GetAchievementCategory(categoryId);
		return ((achievementCategory != null) ? achievementCategory.GetValueOrDefault().SpritePath : null) ?? "";
	}

	// Token: 0x060034BA RID: 13498 RVA: 0x00137AA4 File Offset: 0x00135CA4
	public int GetCategoryFunctionType(int groupId)
	{
		return this.GetAchievementCategory(groupId).Value.FunctionType;
	}

	// Token: 0x170007B4 RID: 1972
	// (get) Token: 0x060034BB RID: 13499 RVA: 0x00137AC8 File Offset: 0x00135CC8
	public static AchievementConfig Instance
	{
		get
		{
			return AchievementConfig._Instance;
		}
	}

	// Token: 0x060034BC RID: 13500 RVA: 0x00137ACF File Offset: 0x00135CCF
	public static AchievementConfig GetOrCreateInstance()
	{
		if (AchievementConfig._Instance == null)
		{
			AchievementConfig.CreateInstance();
		}
		return AchievementConfig._Instance;
	}

	// Token: 0x060034BD RID: 13501 RVA: 0x00137AE3 File Offset: 0x00135CE3
	public static bool CreateInstance()
	{
		if (AchievementConfig._Instance != null)
		{
			return true;
		}
		AchievementConfig._Instance = new AchievementConfig();
		return true;
	}

	// Token: 0x060034BE RID: 13502 RVA: 0x00137AF9 File Offset: 0x00135CF9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060034BF RID: 13503 RVA: 0x00137AFB File Offset: 0x00135CFB
	public static void ResetStaticDefaultValue()
	{
		AchievementConfig._Instance = null;
	}

	// Token: 0x060034C0 RID: 13504 RVA: 0x00137B03 File Offset: 0x00135D03
	static AchievementConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AchievementConfig.CreateStaticDefaultValue), new Action(AchievementConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04002CD3 RID: 11475
	[Nullable(2)]
	private static AchievementConfig _Instance;
}
