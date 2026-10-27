using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200289B RID: 10395
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillConfig : ConfigBase
{
	// Token: 0x06015742 RID: 87874 RVA: 0x00569984 File Offset: 0x00567B84
	public Aki.Config.Skill? GetSkillConfigById(int skillId)
	{
		Aki.Config.Skill? config = ConfigSkillById.GetConfig(skillId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "当前选中的技能配置为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", skillId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x06015743 RID: 87875 RVA: 0x005699D0 File Offset: 0x00567BD0
	public unsafe SkillLevel? GetSkillLevelConfigByGroupIdAndLevel(int skillLevelGroupId, int level)
	{
		SkillLevel? config = ConfigSkillLevelBySkillLevelGroupIdAndSkillId.GetConfig(skillLevelGroupId, level, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "技能配置为空";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("skillLevelGroupId", skillLevelGroupId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("level", level);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return config;
	}

	// Token: 0x06015744 RID: 87876 RVA: 0x00569A4D File Offset: 0x00567C4D
	public IReadOnlyList<SkillLevel> GetSkillLevelConfigList(int skillId)
	{
		return ConfigSkillLevelBySkillLevelGroupId.GetConfigList(skillId, true);
	}

	// Token: 0x06015745 RID: 87877 RVA: 0x00569A58 File Offset: 0x00567C58
	public string GetSkillTypeNameLocalText(int skillTypeId)
	{
		SkillType? config = ConfigSkillTypeById.GetConfig(skillTypeId, true);
		if (config != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(config.Value.TypeName, null);
		}
		return null;
	}

	// Token: 0x06015746 RID: 87878 RVA: 0x00569A8D File Offset: 0x00567C8D
	public IReadOnlyList<Aki.Config.Skill> GetSkillList(int skillGroupId)
	{
		return ConfigSkillBySkillGroupId.GetConfigList(skillGroupId, true);
	}

	// Token: 0x06015747 RID: 87879 RVA: 0x00569A98 File Offset: 0x00567C98
	public SkillTree? GetSkillTreeNode(int nodeId)
	{
		SkillTree? config = ConfigSkillTreeById.GetConfig(nodeId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "技能树配置为空，Id = ";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("nodeId", nodeId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x06015748 RID: 87880 RVA: 0x00569AE3 File Offset: 0x00567CE3
	public IReadOnlyList<SkillTree> GetSkillTreeNodeListByGroupId(int nodeGroupId)
	{
		return ConfigSkillTreeByNodeGroup.GetConfigList(nodeGroupId, true);
	}

	// Token: 0x06015749 RID: 87881 RVA: 0x00569AEC File Offset: 0x00567CEC
	public SkillTree? GetSkillTreeNodeByGroupIdAndIndex(int nodeGroupId, int nodeIndex)
	{
		SkillTree? config = ConfigSkillTreeByNodeGroupAndNodeIndex.GetConfig(nodeGroupId, nodeIndex, true);
		if (config == null)
		{
			Log.Instance.Error(ELogModule.Role, ELogAuthor.LZK, "技能树配置为空，NodeGroup = " + nodeGroupId.ToString() + ", NodeIndex = " + nodeIndex.ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return config;
	}

	// Token: 0x0601574A RID: 87882 RVA: 0x00569B40 File Offset: 0x00567D40
	public SkillTree? GetSkillTreeNodeByGroupIdAndSkillId(int nodeGroupId, int skillId)
	{
		IReadOnlyList<SkillTree> skillTreeNodeListByGroupId = this.GetSkillTreeNodeListByGroupId(nodeGroupId);
		if (skillTreeNodeListByGroupId == null)
		{
			return null;
		}
		foreach (SkillTree value in skillTreeNodeListByGroupId)
		{
			if (value.SkillId == skillId)
			{
				return new SkillTree?(value);
			}
		}
		return null;
	}

	// Token: 0x0601574B RID: 87883 RVA: 0x00569BB8 File Offset: 0x00567DB8
	public SkillCondition? GetSkillConditionById(int skillConditionId)
	{
		SkillCondition? config = ConfigSkillConditionById.GetConfig(skillConditionId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "技能条件配置为空，Id = ";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillConditionId", skillConditionId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x0601574C RID: 87884 RVA: 0x00569C03 File Offset: 0x00567E03
	[NullableContext(1)]
	public IEnumerable<DicIntInt?> GetRoleSkillTreeConsume(int skillNodeId, int level)
	{
		RoleSkillConfig.<GetRoleSkillTreeConsume>d__10 <GetRoleSkillTreeConsume>d__ = new RoleSkillConfig.<GetRoleSkillTreeConsume>d__10(-2);
		<GetRoleSkillTreeConsume>d__.<>4__this = this;
		<GetRoleSkillTreeConsume>d__.<>3__skillNodeId = skillNodeId;
		<GetRoleSkillTreeConsume>d__.<>3__level = level;
		return <GetRoleSkillTreeConsume>d__;
	}

	// Token: 0x0601574D RID: 87885 RVA: 0x00569C24 File Offset: 0x00567E24
	public SkillDescription? GetRoleSkillDescriptionConfigById(int id)
	{
		SkillDescription? config = ConfigSkillDescriptionById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "技能描述配置为空，Id = ";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x0601574E RID: 87886 RVA: 0x00569C70 File Offset: 0x00567E70
	public IReadOnlyList<SkillDescription> GetAllRoleSkillDescConfigByGroupId(int groupId)
	{
		IReadOnlyList<SkillDescription> configList = ConfigSkillDescriptionBySkillLevelGroupId.GetConfigList(groupId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "技能描述配置为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("GroupId", groupId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return configList;
	}

	// Token: 0x0601574F RID: 87887 RVA: 0x00569CB4 File Offset: 0x00567EB4
	public SkillInput? GetSkillInputConfigById(int skillInputId)
	{
		SkillInput? config = ConfigSkillInputById.GetConfig(skillInputId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "技能出招表配置为空，Id = ";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillInputId", skillInputId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x06015750 RID: 87888 RVA: 0x00569CFF File Offset: 0x00567EFF
	public RoleSkillInput? GetRoleSkillInputConfigById(int roleId)
	{
		return ConfigRoleSkillInputById.GetConfig(roleId, true);
	}

	// Token: 0x06015751 RID: 87889 RVA: 0x00569D08 File Offset: 0x00567F08
	public int? GetRoleSkillMaxLevelBySkillNodeId(int skillNodeId)
	{
		int skillId = this.GetSkillTreeNode(skillNodeId).Value.SkillId;
		if (skillId <= 0)
		{
			return null;
		}
		Aki.Config.Skill? skillConfigById = this.GetSkillConfigById(skillId);
		if (skillConfigById == null)
		{
			return null;
		}
		return new int?(skillConfigById.GetValueOrDefault().MaxSkillLevel);
	}

	// Token: 0x06015752 RID: 87890 RVA: 0x00569D70 File Offset: 0x00567F70
	public RoleSkillFightTrick[] GetRoleSkillFightTrickList(int roleId)
	{
		IReadOnlyList<RoleSkillFightTrick> configList = ConfigRoleSkillFightTrickByRoleId.GetConfigList(roleId, true);
		if (configList.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "没有找到任意的战斗技巧表数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return configList.ToArray<RoleSkillFightTrick>();
	}

	// Token: 0x17001CC7 RID: 7367
	// (get) Token: 0x06015753 RID: 87891 RVA: 0x00569DBD File Offset: 0x00567FBD
	[Nullable(1)]
	public static RoleSkillConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return RoleSkillConfig._Instance;
		}
	}

	// Token: 0x06015754 RID: 87892 RVA: 0x00569DC4 File Offset: 0x00567FC4
	[NullableContext(1)]
	public static RoleSkillConfig GetOrCreateInstance()
	{
		if (RoleSkillConfig._Instance == null)
		{
			RoleSkillConfig.CreateInstance();
		}
		return RoleSkillConfig._Instance;
	}

	// Token: 0x06015755 RID: 87893 RVA: 0x00569DD8 File Offset: 0x00567FD8
	public static bool CreateInstance()
	{
		if (RoleSkillConfig._Instance != null)
		{
			return true;
		}
		RoleSkillConfig._Instance = new RoleSkillConfig();
		return true;
	}

	// Token: 0x06015756 RID: 87894 RVA: 0x00569DEE File Offset: 0x00567FEE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015757 RID: 87895 RVA: 0x00569DF0 File Offset: 0x00567FF0
	public static void ResetStaticDefaultValue()
	{
		RoleSkillConfig._Instance = null;
	}

	// Token: 0x06015758 RID: 87896 RVA: 0x00569DF8 File Offset: 0x00567FF8
	static RoleSkillConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSkillConfig.CreateStaticDefaultValue), new Action(RoleSkillConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04009FF5 RID: 40949
	private static RoleSkillConfig _Instance;
}
