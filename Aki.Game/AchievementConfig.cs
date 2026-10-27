using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

// Token: 0x02000F0E RID: 3854
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class AchievementConfig : ConfigBase
{
	// Token: 0x06006103 RID: 24835 RVA: 0x0012ECDD File Offset: 0x0012CEDD
	public Achievement? GetAchievementConfig(int achievementId)
	{
		return ConfigAchievementById.GetConfig(achievementId, true);
	}

	// Token: 0x06006104 RID: 24836 RVA: 0x0012ECE6 File Offset: 0x0012CEE6
	[NullableContext(2)]
	public IReadOnlyList<Achievement> GetAchievementGroupAchievementList(int groupId)
	{
		return ConfigAchievementByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x06006105 RID: 24837 RVA: 0x0012ECEF File Offset: 0x0012CEEF
	public AchievementStarLevel? GetAchievementStarLevelConfig(int level)
	{
		return ConfigAchievementStarLevelByLevel.GetConfig(level, true);
	}

	// Token: 0x06006106 RID: 24838 RVA: 0x0012ECF8 File Offset: 0x0012CEF8
	public AchievementGroup? GetAchievementGroupConfig(int achievementGroupId)
	{
		return ConfigAchievementGroupById.GetConfig(achievementGroupId, true);
	}

	// Token: 0x06006107 RID: 24839 RVA: 0x0012ED01 File Offset: 0x0012CF01
	public AchievementCategory? GetAchievementCategory(int categoryId)
	{
		return ConfigAchievementCategoryById.GetConfig(categoryId, true);
	}

	// Token: 0x06006108 RID: 24840 RVA: 0x0012ED0A File Offset: 0x0012CF0A
	[NullableContext(2)]
	public IReadOnlyList<AchievementCategory> GetAllAchievementCategory()
	{
		return ConfigAchievementCategoryAll.GetConfigList(true);
	}

	// Token: 0x06006109 RID: 24841 RVA: 0x0012ED12 File Offset: 0x0012CF12
	[NullableContext(2)]
	public IReadOnlyList<AchievementGroup> GetAchievementCategoryGroups(int categoryId)
	{
		return ConfigAchievementGroupByCategory.GetConfigList(categoryId, true);
	}

	// Token: 0x0600610A RID: 24842 RVA: 0x0012ED1C File Offset: 0x0012CF1C
	public string GetAchievementTitle(int achievementId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetAchievementConfig(achievementId).Value.Name, null);
	}

	// Token: 0x0600610B RID: 24843 RVA: 0x0012ED48 File Offset: 0x0012CF48
	public string GetAchievementDesc(int achievementId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetAchievementConfig(achievementId).Value.Desc, null);
	}

	// Token: 0x0600610C RID: 24844 RVA: 0x0012ED74 File Offset: 0x0012CF74
	public bool GetAchievementHiddenState(int achievementId)
	{
		return this.GetAchievementConfig(achievementId).Value.Hidden;
	}

	// Token: 0x0600610D RID: 24845 RVA: 0x0012ED98 File Offset: 0x0012CF98
	public int GetAchievementNextLink(int achievementId)
	{
		Achievement? achievementConfig = this.GetAchievementConfig(achievementId);
		if (achievementConfig == null)
		{
			return 0;
		}
		return achievementConfig.Value.NextLink;
	}

	// Token: 0x0600610E RID: 24846 RVA: 0x0012EDC8 File Offset: 0x0012CFC8
	public int GetThirdPartyTrophyId(int achievementId)
	{
		Achievement? achievementConfig = this.GetAchievementConfig(achievementId);
		if (achievementConfig == null)
		{
			return 0;
		}
		return achievementConfig.Value.ThirdPartyTrophyId;
	}

	// Token: 0x0600610F RID: 24847 RVA: 0x0012EDF8 File Offset: 0x0012CFF8
	public string GetExternalTrophyId(int achievementId)
	{
		Achievement? achievementConfig = this.GetAchievementConfig(achievementId);
		if (achievementConfig == null)
		{
			return string.Empty;
		}
		return achievementConfig.Value.ExternalTrophyId;
	}

	// Token: 0x06006110 RID: 24848 RVA: 0x0012EE2C File Offset: 0x0012D02C
	public string GetXSXExternalTrophyId(int achievementId)
	{
		Achievement? achievementConfig = this.GetAchievementConfig(achievementId);
		if (achievementConfig == null)
		{
			return string.Empty;
		}
		return achievementConfig.Value.XSXExternalTrophyId;
	}

	// Token: 0x06006111 RID: 24849 RVA: 0x0012EE60 File Offset: 0x0012D060
	public int GetAchievementLevel(int achievementId)
	{
		Achievement? achievementConfig = this.GetAchievementConfig(achievementId);
		if (achievementConfig == null)
		{
			return 0;
		}
		return achievementConfig.Value.Level;
	}

	// Token: 0x06006112 RID: 24850 RVA: 0x0012EE90 File Offset: 0x0012D090
	public int GetAchievementGroup(int achievementId)
	{
		Achievement? achievementConfig = this.GetAchievementConfig(achievementId);
		if (achievementConfig == null)
		{
			return 0;
		}
		return achievementConfig.Value.GroupId;
	}

	// Token: 0x06006113 RID: 24851 RVA: 0x0012EEC0 File Offset: 0x0012D0C0
	public string GetAchievementIcon(int achievementId)
	{
		Achievement? achievementConfig = this.GetAchievementConfig(achievementId);
		if (achievementConfig == null)
		{
			return string.Empty;
		}
		return achievementConfig.Value.IconPath;
	}

	// Token: 0x06006114 RID: 24852 RVA: 0x0012EEF4 File Offset: 0x0012D0F4
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

	// Token: 0x06006115 RID: 24853 RVA: 0x0012EF54 File Offset: 0x0012D154
	public string GetAchievementGroupTitleId(int groupId)
	{
		AchievementGroup? achievementGroupConfig = this.GetAchievementGroupConfig(groupId);
		return ((achievementGroupConfig != null) ? achievementGroupConfig.GetValueOrDefault().Name : null) ?? "";
	}

	// Token: 0x06006116 RID: 24854 RVA: 0x0012EF8D File Offset: 0x0012D18D
	public string GetAchievementGroupTitle(int groupId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetAchievementGroupTitleId(groupId), null);
	}

	// Token: 0x06006117 RID: 24855 RVA: 0x0012EF9C File Offset: 0x0012D19C
	public int GetAchievementGroupSort(int groupId)
	{
		return this.GetAchievementGroupConfig(groupId).Value.Sort;
	}

	// Token: 0x06006118 RID: 24856 RVA: 0x0012EFC0 File Offset: 0x0012D1C0
	public string GetAchievementGroupIcon(int groupId)
	{
		return this.GetAchievementGroupConfig(groupId).Value.Icon;
	}

	// Token: 0x06006119 RID: 24857 RVA: 0x0012EFE4 File Offset: 0x0012D1E4
	public string GetAchievementGroupSmallIcon(int groupId)
	{
		return this.GetAchievementGroupConfig(groupId).Value.SmallIcon;
	}

	// Token: 0x0600611A RID: 24858 RVA: 0x0012F008 File Offset: 0x0012D208
	public string GetAchievementGroupBackgroundIcon(int groupId)
	{
		return this.GetAchievementGroupConfig(groupId).Value.BackgroundIcon;
	}

	// Token: 0x0600611B RID: 24859 RVA: 0x0012F02C File Offset: 0x0012D22C
	public bool GetAchievementGroupEnable(int groupId)
	{
		return this.GetAchievementGroupConfig(groupId).Value.Enable;
	}

	// Token: 0x0600611C RID: 24860 RVA: 0x0012F050 File Offset: 0x0012D250
	public DropPackage? GetAchievementGroupReward(int groupId)
	{
		AchievementGroup? achievementGroupConfig = this.GetAchievementGroupConfig(groupId);
		if (achievementGroupConfig.Value.DropId == 0)
		{
			return null;
		}
		return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(achievementGroupConfig.Value.DropId);
	}

	// Token: 0x0600611D RID: 24861 RVA: 0x0012F09C File Offset: 0x0012D29C
	public int GetAchievementGroupCategory(int groupId)
	{
		return this.GetAchievementGroupConfig(groupId).Value.Category;
	}

	// Token: 0x0600611E RID: 24862 RVA: 0x0012F0C0 File Offset: 0x0012D2C0
	public string GetCategoryOriginalTitle(int categoryId)
	{
		AchievementCategory? achievementCategory = this.GetAchievementCategory(categoryId);
		return ((achievementCategory != null) ? achievementCategory.GetValueOrDefault().Name : null) ?? "";
	}

	// Token: 0x0600611F RID: 24863 RVA: 0x0012F0F9 File Offset: 0x0012D2F9
	public string GetCategoryTitle(int categoryId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetCategoryOriginalTitle(categoryId), null);
	}

	// Token: 0x06006120 RID: 24864 RVA: 0x0012F108 File Offset: 0x0012D308
	public string GetCategoryTexture(int categoryId)
	{
		AchievementCategory? achievementCategory = this.GetAchievementCategory(categoryId);
		return ((achievementCategory != null) ? achievementCategory.GetValueOrDefault().TexturePath : null) ?? "";
	}

	// Token: 0x06006121 RID: 24865 RVA: 0x0012F144 File Offset: 0x0012D344
	public string GetCategorySprite(int categoryId)
	{
		AchievementCategory? achievementCategory = this.GetAchievementCategory(categoryId);
		return ((achievementCategory != null) ? achievementCategory.GetValueOrDefault().SpritePath : null) ?? "";
	}

	// Token: 0x06006122 RID: 24866 RVA: 0x0012F180 File Offset: 0x0012D380
	public int GetCategoryFunctionType(int groupId)
	{
		return this.GetAchievementCategory(groupId).Value.FunctionType;
	}

	// Token: 0x17000792 RID: 1938
	// (get) Token: 0x06006123 RID: 24867 RVA: 0x0012F1A4 File Offset: 0x0012D3A4
	public static AchievementConfig Instance
	{
		get
		{
			return AchievementConfig._Instance;
		}
	}

	// Token: 0x06006124 RID: 24868 RVA: 0x0012F1AB File Offset: 0x0012D3AB
	public static AchievementConfig GetOrCreateInstance()
	{
		if (AchievementConfig._Instance == null)
		{
			AchievementConfig.CreateInstance();
		}
		return AchievementConfig._Instance;
	}

	// Token: 0x06006125 RID: 24869 RVA: 0x0012F1BF File Offset: 0x0012D3BF
	public static bool CreateInstance()
	{
		if (AchievementConfig._Instance != null)
		{
			return true;
		}
		AchievementConfig._Instance = new AchievementConfig();
		return true;
	}

	// Token: 0x06006126 RID: 24870 RVA: 0x0012F1D5 File Offset: 0x0012D3D5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006127 RID: 24871 RVA: 0x0012F1D7 File Offset: 0x0012D3D7
	public static void ResetStaticDefaultValue()
	{
		AchievementConfig._Instance = null;
	}

	// Token: 0x06006128 RID: 24872 RVA: 0x0012F1DF File Offset: 0x0012D3DF
	static AchievementConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AchievementConfig.CreateStaticDefaultValue), new Action(AchievementConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04002C3A RID: 11322
	[Nullable(2)]
	private static AchievementConfig _Instance;
}
