using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using Google.Protobuf.Collections;

// Token: 0x0200280E RID: 10254
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class RoleDevConfig : ConfigBase
{
	// Token: 0x060150B1 RID: 86193 RVA: 0x00554158 File Offset: 0x00552358
	public void UpdateDevProsListConfig(RepeatedField<RoleDevPropsConfig> devPropsLists)
	{
		this.DevProsListMap.Clear();
		foreach (RoleDevPropsConfig roleDevPropsConfig in devPropsLists)
		{
			List<IRoleDevProsSpecialGachaConfig> list = new List<IRoleDevProsSpecialGachaConfig>();
			foreach (SpecialGachaPair specialGachaPair in roleDevPropsConfig.SpecialGachaPair)
			{
				list.Add(new RoleDevProsSpecialGachaConfig(specialGachaPair.TypeId, specialGachaPair.GachaId));
			}
			RoleDevProsConfig value = new RoleDevProsConfig
			{
				Id = roleDevPropsConfig.Id,
				ProspectBeginTime = MathUtils.Instance.LongToBigInt(roleDevPropsConfig.ProspectBeginTime) / (long)TimeUtil.Instance.InverseMillisecond,
				ProspectEndTime = MathUtils.Instance.LongToBigInt(roleDevPropsConfig.ProspectEndTime) / (long)TimeUtil.Instance.InverseMillisecond,
				TypeId = roleDevPropsConfig.TypeId,
				GachaId = roleDevPropsConfig.GachaId,
				SpecialGachaId = list,
				SortId = roleDevPropsConfig.SortId
			};
			this.DevProsListMap[(long)roleDevPropsConfig.Id] = value;
		}
	}

	// Token: 0x060150B2 RID: 86194 RVA: 0x00554298 File Offset: 0x00552498
	public void UpdateDevPropsProjectConfig(RepeatedField<RoleDevPropsProjectConfig> devPropsProjects)
	{
		this.DevPropsProjectMap.Clear();
		foreach (RoleDevPropsProjectConfig roleDevPropsProjectConfig in devPropsProjects)
		{
			RoleDevProsProjectConfig value = new RoleDevProsProjectConfig
			{
				Id = roleDevPropsProjectConfig.Id,
				ElementId = roleDevPropsProjectConfig.ElementId,
				RoleName = roleDevPropsProjectConfig.RoleName,
				RoleExperience = roleDevPropsProjectConfig.RoleExperience,
				RoleGoalLevel = roleDevPropsProjectConfig.RoleGoalLevel,
				WeaponGoalLevel = roleDevPropsProjectConfig.WeaponGoalLevel,
				WeaponExperience = roleDevPropsProjectConfig.WeaponExperience,
				RoleItemGroup = roleDevPropsProjectConfig.RoleItemGroup.ToList<int>(),
				WeaponBreachItemGroup = roleDevPropsProjectConfig.WeaponBreachItemGroup.ToList<int>(),
				WeaponType = roleDevPropsProjectConfig.WeaponType,
				SkillItemGroup = roleDevPropsProjectConfig.SkillItemGroup.ToList<int>(),
				PrefectSkillLevel = roleDevPropsProjectConfig.PrefectSkillLevel.ToList<int>(),
				RoleHeadIcon = roleDevPropsProjectConfig.RoleHeadIcon,
				RoleHeadIconSmall = roleDevPropsProjectConfig.RoleHeadIconSmall,
				FormationRoleCard = roleDevPropsProjectConfig.FormationRoleCard
			};
			this.DevPropsProjectMap[(long)roleDevPropsProjectConfig.Id] = value;
		}
	}

	// Token: 0x060150B3 RID: 86195 RVA: 0x005543CC File Offset: 0x005525CC
	public RoleDevProject? GetRoleDevProjectConfig(int roleId)
	{
		RoleDevProject? config = ConfigRoleDevProjectByRoleId.GetConfig(roleId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.WMQ;
			string message = "RoleDevProject表无效roleId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060150B4 RID: 86196 RVA: 0x00554424 File Offset: 0x00552624
	public RoleDevCultivateProject? GetCultivateProjectConfig(int cultivateProjectId)
	{
		RoleDevCultivateProject? config = ConfigRoleDevCultivateProjectByProjectProjectId.GetConfig(cultivateProjectId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.WMQ;
			string message = "RoleDevCultivateProject表无效cultivateProjectId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cultivateProjectId", cultivateProjectId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060150B5 RID: 86197 RVA: 0x0055447C File Offset: 0x0055267C
	public IReadOnlyList<RoleDevLevelLimit> GetLevelLimitConfigList()
	{
		IReadOnlyList<RoleDevLevelLimit> configList = ConfigRoleDevLevelLimitAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.RoleDev, ELogAuthor.WMQ, "RoleDevLevelLimit表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<RoleDevLevelLimit>();
		}
		return configList;
	}

	// Token: 0x060150B6 RID: 86198 RVA: 0x005544BC File Offset: 0x005526BC
	public RoleDevItemJumpGroup? GetItemJumpGroupConfig(int itemId)
	{
		RoleDevItemJumpGroup? config = ConfigRoleDevItemJumpGroupByItemId.GetConfig(itemId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.WMQ;
			string message = "RoleDevItemJumpGroup表无效itemId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060150B7 RID: 86199 RVA: 0x00554514 File Offset: 0x00552714
	[NullableContext(2)]
	public IReadOnlyList<RoleDevItemJumpGroup> GetAllItemJumpGroupConfigs()
	{
		return ConfigRoleDevItemJumpGroupAll.GetConfigList(true);
	}

	// Token: 0x060150B8 RID: 86200 RVA: 0x0055451C File Offset: 0x0055271C
	public RoleDevTypeManage? GetTypeManageConfig(int type)
	{
		RoleDevTypeManage? config = ConfigRoleDevTypeManageByItemType.GetConfig(type, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.WMQ;
			string message = "RoleDevTypeManage表无效type";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060150B9 RID: 86201 RVA: 0x00554574 File Offset: 0x00552774
	public RoleDevPhantomJumpGroup? GetPhantomJumpGroupConfig(int fetterGroupId)
	{
		RoleDevPhantomJumpGroup? config = ConfigRoleDevPhantomJumpGroupByPhantomId.GetConfig(fetterGroupId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.WMQ;
			string message = "RoleDevPhantomJumpGroup表无效fetterGroupId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("fetterGroupId", fetterGroupId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060150BA RID: 86202 RVA: 0x005545CC File Offset: 0x005527CC
	public PropertyIndex? GetPropertyIndexConfigByIndex(int index)
	{
		PropertyIndex? config = ConfigPropertyIndexById.GetConfig(index, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.WMQ;
			string message = "PropertyIndex表无效index";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", index);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060150BB RID: 86203 RVA: 0x00554624 File Offset: 0x00552824
	public int[] GetWeaponRecommendListConfig(int roleId)
	{
		RoleDevProject? config = ConfigRoleDevProjectByRoleId.GetConfig(roleId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.WMQ;
			string message = "RoleDevProject表无效roleId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new int[0];
		}
		return config.Value.RecommandWeapon();
	}

	// Token: 0x060150BC RID: 86204 RVA: 0x00554688 File Offset: 0x00552888
	public RoleDevWeaponJumpGroup? GetWeaponJumpGroupConfigByWeaponId(int weaponId)
	{
		RoleDevWeaponJumpGroup? config = ConfigRoleDevWeaponJumpGroupByWeaponId.GetConfig(weaponId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.WMQ;
			string message = "RoleDevWeaponJumpGroup表无效weaponId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("weaponId", weaponId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060150BD RID: 86205 RVA: 0x005546E0 File Offset: 0x005528E0
	public bool HasRoleDevProsListConfig(int roleId)
	{
		return this.DevProsListMap.ContainsKey((long)roleId);
	}

	// Token: 0x060150BE RID: 86206 RVA: 0x005546F0 File Offset: 0x005528F0
	[NullableContext(2)]
	public IRoleDevProsConfig GetRoleDevProsListConfig(int roleId)
	{
		IRoleDevProsConfig result;
		if (!this.DevProsListMap.TryGetValue((long)roleId, out result))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.LJS;
			string message = "服务器DevPropsList无效roleId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return result;
	}

	// Token: 0x060150BF RID: 86207 RVA: 0x00554740 File Offset: 0x00552940
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyList<IRoleDevProsConfig> GetAllRoleDevProsListConfig()
	{
		return this.DevProsListMap.Values.ToList<IRoleDevProsConfig>();
	}

	// Token: 0x060150C0 RID: 86208 RVA: 0x00554754 File Offset: 0x00552954
	[NullableContext(2)]
	public IRoleDevProsProjectConfig GetRoleDevProsProjectConfig(int roleId)
	{
		IRoleDevProsProjectConfig result;
		if (!this.DevPropsProjectMap.TryGetValue((long)roleId, out result))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.LJS;
			string message = "服务器DevPropsProjectList无效roleId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return result;
	}

	// Token: 0x060150C1 RID: 86209 RVA: 0x005547A4 File Offset: 0x005529A4
	public RoleDevProsRoleItem? GetRoleDevProsRoleItemConfig(int itemGroupId)
	{
		RoleDevProsRoleItem? config = ConfigRoleDevProsRoleItemByItemGroupId.GetConfig(itemGroupId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.WMQ;
			string message = "RoleDevProsRoleItem表无效itemGroupId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemGroupId", itemGroupId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060150C2 RID: 86210 RVA: 0x005547FC File Offset: 0x005529FC
	public RoleDevWeaponItem? GetRoleDevWeaponItemConfig(int weaponType)
	{
		RoleDevWeaponItem? config = ConfigRoleDevWeaponItemByWeaponType.GetConfig(weaponType, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.WMQ;
			string message = "RoleDevWeaponItem表无效weaponType";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("weaponType", weaponType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060150C3 RID: 86211 RVA: 0x00554854 File Offset: 0x00552A54
	public RoleDevCulProjectConfig? GetRoleDevStaticConfig()
	{
		RoleDevCulProjectConfig? config = ConfigRoleDevCulProjectConfigById.GetConfig(1, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.WMQ;
			string message = "RoleDevStatic表无效configId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configId", 1);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060150C4 RID: 86212 RVA: 0x005548AC File Offset: 0x00552AAC
	public int[] GetCanLevelUpSkillNodeIndexList()
	{
		return ConfigCommonParamById.GetIntArrayConfig("RoleDevCanLevelUpSkillNodeIndexList").ToArray<int>();
	}

	// Token: 0x060150C5 RID: 86213 RVA: 0x005548C0 File Offset: 0x00552AC0
	public int GetDefaultSkillNodeIndex()
	{
		int[] canLevelUpSkillNodeIndexList = this.GetCanLevelUpSkillNodeIndexList();
		if (canLevelUpSkillNodeIndexList.Length == 0)
		{
			return 0;
		}
		return canLevelUpSkillNodeIndexList[0];
	}

	// Token: 0x17001BCE RID: 7118
	// (get) Token: 0x060150C6 RID: 86214 RVA: 0x005548DD File Offset: 0x00552ADD
	public static RoleDevConfig Instance
	{
		get
		{
			return RoleDevConfig._Instance;
		}
	}

	// Token: 0x060150C7 RID: 86215 RVA: 0x005548E4 File Offset: 0x00552AE4
	public static RoleDevConfig GetOrCreateInstance()
	{
		if (RoleDevConfig._Instance == null)
		{
			RoleDevConfig.CreateInstance();
		}
		return RoleDevConfig._Instance;
	}

	// Token: 0x060150C8 RID: 86216 RVA: 0x005548F8 File Offset: 0x00552AF8
	public static bool CreateInstance()
	{
		if (RoleDevConfig._Instance != null)
		{
			return true;
		}
		RoleDevConfig._Instance = new RoleDevConfig();
		return true;
	}

	// Token: 0x060150C9 RID: 86217 RVA: 0x0055490E File Offset: 0x00552B0E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060150CA RID: 86218 RVA: 0x00554910 File Offset: 0x00552B10
	public static void ResetStaticDefaultValue()
	{
		RoleDevConfig._Instance = null;
	}

	// Token: 0x060150CB RID: 86219 RVA: 0x00554918 File Offset: 0x00552B18
	static RoleDevConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleDevConfig.CreateStaticDefaultValue), new Action(RoleDevConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04009E2B RID: 40491
	private readonly Dictionary<long, IRoleDevProsConfig> DevProsListMap = new Dictionary<long, IRoleDevProsConfig>();

	// Token: 0x04009E2C RID: 40492
	private readonly Dictionary<long, IRoleDevProsProjectConfig> DevPropsProjectMap = new Dictionary<long, IRoleDevProsProjectConfig>();

	// Token: 0x04009E2D RID: 40493
	[Nullable(2)]
	private static RoleDevConfig _Instance;
}
