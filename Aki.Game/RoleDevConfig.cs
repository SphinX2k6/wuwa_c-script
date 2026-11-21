using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using Google.Protobuf.Collections;

// Token: 0x02001D89 RID: 7561
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class RoleDevConfig : ConfigBase
{
	// Token: 0x06012AB1 RID: 76465 RVA: 0x0057EF2C File Offset: 0x0057D12C
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

	// Token: 0x06012AB2 RID: 76466 RVA: 0x0057F06C File Offset: 0x0057D26C
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
				RoleItemGroup = new List<int>(roleDevPropsProjectConfig.RoleItemGroup),
				WeaponBreachItemGroup = new List<int>(roleDevPropsProjectConfig.WeaponBreachItemGroup),
				WeaponType = roleDevPropsProjectConfig.WeaponType,
				SkillItemGroup = new List<int>(roleDevPropsProjectConfig.SkillItemGroup),
				PrefectSkillLevel = new List<int>(roleDevPropsProjectConfig.PrefectSkillLevel),
				RoleHeadIcon = roleDevPropsProjectConfig.RoleHeadIcon,
				RoleHeadIconSmall = roleDevPropsProjectConfig.RoleHeadIconSmall,
				FormationRoleCard = roleDevPropsProjectConfig.FormationRoleCard
			};
			this.DevPropsProjectMap[(long)roleDevPropsProjectConfig.Id] = value;
		}
	}

	// Token: 0x06012AB3 RID: 76467 RVA: 0x0057F1A0 File Offset: 0x0057D3A0
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

	// Token: 0x06012AB4 RID: 76468 RVA: 0x0057F1F8 File Offset: 0x0057D3F8
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

	// Token: 0x06012AB5 RID: 76469 RVA: 0x0057F250 File Offset: 0x0057D450
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

	// Token: 0x06012AB6 RID: 76470 RVA: 0x0057F290 File Offset: 0x0057D490
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

	// Token: 0x06012AB7 RID: 76471 RVA: 0x0057F2E8 File Offset: 0x0057D4E8
	[NullableContext(2)]
	public IReadOnlyList<RoleDevItemJumpGroup> GetAllItemJumpGroupConfigs()
	{
		return ConfigRoleDevItemJumpGroupAll.GetConfigList(true);
	}

	// Token: 0x06012AB8 RID: 76472 RVA: 0x0057F2F0 File Offset: 0x0057D4F0
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

	// Token: 0x06012AB9 RID: 76473 RVA: 0x0057F348 File Offset: 0x0057D548
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

	// Token: 0x06012ABA RID: 76474 RVA: 0x0057F3A0 File Offset: 0x0057D5A0
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

	// Token: 0x06012ABB RID: 76475 RVA: 0x0057F3F8 File Offset: 0x0057D5F8
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

	// Token: 0x06012ABC RID: 76476 RVA: 0x0057F45C File Offset: 0x0057D65C
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

	// Token: 0x06012ABD RID: 76477 RVA: 0x0057F4B4 File Offset: 0x0057D6B4
	public bool HasRoleDevProsListConfig(int roleId)
	{
		return this.DevProsListMap.ContainsKey((long)roleId);
	}

	// Token: 0x06012ABE RID: 76478 RVA: 0x0057F4C4 File Offset: 0x0057D6C4
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

	// Token: 0x06012ABF RID: 76479 RVA: 0x0057F514 File Offset: 0x0057D714
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyList<IRoleDevProsConfig> GetAllRoleDevProsListConfig()
	{
		return new List<IRoleDevProsConfig>(this.DevProsListMap.Values);
	}

	// Token: 0x06012AC0 RID: 76480 RVA: 0x0057F528 File Offset: 0x0057D728
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

	// Token: 0x06012AC1 RID: 76481 RVA: 0x0057F578 File Offset: 0x0057D778
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

	// Token: 0x06012AC2 RID: 76482 RVA: 0x0057F5D0 File Offset: 0x0057D7D0
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

	// Token: 0x06012AC3 RID: 76483 RVA: 0x0057F628 File Offset: 0x0057D828
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

	// Token: 0x06012AC4 RID: 76484 RVA: 0x0057F680 File Offset: 0x0057D880
	public int[] GetCanLevelUpSkillNodeIndexList()
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("RoleDevCanLevelUpSkillNodeIndexList");
		int[] array = new int[intArrayConfig.Count];
		for (int i = 0; i < intArrayConfig.Count; i++)
		{
			array[i] = intArrayConfig[i];
		}
		return array;
	}

	// Token: 0x06012AC5 RID: 76485 RVA: 0x0057F6C0 File Offset: 0x0057D8C0
	public int GetDefaultSkillNodeIndex()
	{
		int[] canLevelUpSkillNodeIndexList = this.GetCanLevelUpSkillNodeIndexList();
		if (canLevelUpSkillNodeIndexList.Length == 0)
		{
			return 0;
		}
		return canLevelUpSkillNodeIndexList[0];
	}

	// Token: 0x17001C26 RID: 7206
	// (get) Token: 0x06012AC6 RID: 76486 RVA: 0x0057F6DD File Offset: 0x0057D8DD
	public static RoleDevConfig Instance
	{
		get
		{
			return RoleDevConfig._Instance;
		}
	}

	// Token: 0x06012AC7 RID: 76487 RVA: 0x0057F6E4 File Offset: 0x0057D8E4
	public static RoleDevConfig GetOrCreateInstance()
	{
		if (RoleDevConfig._Instance == null)
		{
			RoleDevConfig.CreateInstance();
		}
		return RoleDevConfig._Instance;
	}

	// Token: 0x06012AC8 RID: 76488 RVA: 0x0057F6F8 File Offset: 0x0057D8F8
	public static bool CreateInstance()
	{
		if (RoleDevConfig._Instance != null)
		{
			return true;
		}
		RoleDevConfig._Instance = new RoleDevConfig();
		return true;
	}

	// Token: 0x06012AC9 RID: 76489 RVA: 0x0057F70E File Offset: 0x0057D90E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012ACA RID: 76490 RVA: 0x0057F710 File Offset: 0x0057D910
	public static void ResetStaticDefaultValue()
	{
		RoleDevConfig._Instance = null;
	}

	// Token: 0x06012ACB RID: 76491 RVA: 0x0057F718 File Offset: 0x0057D918
	static RoleDevConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleDevConfig.CreateStaticDefaultValue), new Action(RoleDevConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A214 RID: 41492
	private readonly Dictionary<long, IRoleDevProsConfig> DevProsListMap = new Dictionary<long, IRoleDevProsConfig>();

	// Token: 0x0400A215 RID: 41493
	private readonly Dictionary<long, IRoleDevProsProjectConfig> DevPropsProjectMap = new Dictionary<long, IRoleDevProsProjectConfig>();

	// Token: 0x0400A216 RID: 41494
	[Nullable(2)]
	private static RoleDevConfig _Instance;
}
