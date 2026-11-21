using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001E16 RID: 7702
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillConfig : ConfigBase
{
	// Token: 0x06013142 RID: 78146 RVA: 0x005947CC File Offset: 0x005929CC
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

	// Token: 0x06013143 RID: 78147 RVA: 0x00594818 File Offset: 0x00592A18
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

	// Token: 0x06013144 RID: 78148 RVA: 0x00594895 File Offset: 0x00592A95
	public IReadOnlyList<SkillLevel> GetSkillLevelConfigList(int skillId)
	{
		return ConfigSkillLevelBySkillLevelGroupId.GetConfigList(skillId, true);
	}

	// Token: 0x06013145 RID: 78149 RVA: 0x005948A0 File Offset: 0x00592AA0
	public string GetSkillTypeNameLocalText(int skillTypeId)
	{
		SkillType? config = ConfigSkillTypeById.GetConfig(skillTypeId, true);
		if (config != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(config.Value.TypeName, null);
		}
		return null;
	}

	// Token: 0x06013146 RID: 78150 RVA: 0x005948D5 File Offset: 0x00592AD5
	public IReadOnlyList<Aki.Config.Skill> GetSkillList(int skillGroupId)
	{
		return ConfigSkillBySkillGroupId.GetConfigList(skillGroupId, true);
	}

	// Token: 0x06013147 RID: 78151 RVA: 0x005948E0 File Offset: 0x00592AE0
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

	// Token: 0x06013148 RID: 78152 RVA: 0x0059492B File Offset: 0x00592B2B
	public IReadOnlyList<SkillTree> GetSkillTreeNodeListByGroupId(int nodeGroupId)
	{
		return ConfigSkillTreeByNodeGroup.GetConfigList(nodeGroupId, true);
	}

	// Token: 0x06013149 RID: 78153 RVA: 0x00594934 File Offset: 0x00592B34
	public SkillTree? GetSkillTreeNodeByGroupIdAndIndex(int nodeGroupId, int nodeIndex)
	{
		SkillTree? config = ConfigSkillTreeByNodeGroupAndNodeIndex.GetConfig(nodeGroupId, nodeIndex, true);
		if (config == null)
		{
			Log.Instance.Error(ELogModule.Role, ELogAuthor.LZK, "技能树配置为空，NodeGroup = " + nodeGroupId.ToString() + ", NodeIndex = " + nodeIndex.ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return config;
	}

	// Token: 0x0601314A RID: 78154 RVA: 0x00594988 File Offset: 0x00592B88
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

	// Token: 0x0601314B RID: 78155 RVA: 0x00594A00 File Offset: 0x00592C00
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

	// Token: 0x0601314C RID: 78156 RVA: 0x00594A4B File Offset: 0x00592C4B
	[NullableContext(1)]
	public IEnumerable<DicIntInt?> GetRoleSkillTreeConsume(int skillNodeId, int level)
	{
		RoleSkillConfig.<GetRoleSkillTreeConsume>d__10 <GetRoleSkillTreeConsume>d__ = new RoleSkillConfig.<GetRoleSkillTreeConsume>d__10(-2);
		<GetRoleSkillTreeConsume>d__.<>4__this = this;
		<GetRoleSkillTreeConsume>d__.<>3__skillNodeId = skillNodeId;
		<GetRoleSkillTreeConsume>d__.<>3__level = level;
		return <GetRoleSkillTreeConsume>d__;
	}

	// Token: 0x0601314D RID: 78157 RVA: 0x00594A6C File Offset: 0x00592C6C
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

	// Token: 0x0601314E RID: 78158 RVA: 0x00594AB8 File Offset: 0x00592CB8
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

	// Token: 0x0601314F RID: 78159 RVA: 0x00594AFC File Offset: 0x00592CFC
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

	// Token: 0x06013150 RID: 78160 RVA: 0x00594B47 File Offset: 0x00592D47
	public RoleSkillInput? GetRoleSkillInputConfigById(int roleId)
	{
		return ConfigRoleSkillInputById.GetConfig(roleId, true);
	}

	// Token: 0x06013151 RID: 78161 RVA: 0x00594B50 File Offset: 0x00592D50
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

	// Token: 0x06013152 RID: 78162 RVA: 0x00594BB8 File Offset: 0x00592DB8
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

	// Token: 0x17001D1F RID: 7455
	// (get) Token: 0x06013153 RID: 78163 RVA: 0x00594C05 File Offset: 0x00592E05
	[Nullable(1)]
	public static RoleSkillConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return RoleSkillConfig._Instance;
		}
	}

	// Token: 0x06013154 RID: 78164 RVA: 0x00594C0C File Offset: 0x00592E0C
	[NullableContext(1)]
	public static RoleSkillConfig GetOrCreateInstance()
	{
		if (RoleSkillConfig._Instance == null)
		{
			RoleSkillConfig.CreateInstance();
		}
		return RoleSkillConfig._Instance;
	}

	// Token: 0x06013155 RID: 78165 RVA: 0x00594C20 File Offset: 0x00592E20
	public static bool CreateInstance()
	{
		if (RoleSkillConfig._Instance != null)
		{
			return true;
		}
		RoleSkillConfig._Instance = new RoleSkillConfig();
		return true;
	}

	// Token: 0x06013156 RID: 78166 RVA: 0x00594C36 File Offset: 0x00592E36
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013157 RID: 78167 RVA: 0x00594C38 File Offset: 0x00592E38
	public static void ResetStaticDefaultValue()
	{
		RoleSkillConfig._Instance = null;
	}

	// Token: 0x06013158 RID: 78168 RVA: 0x00594C40 File Offset: 0x00592E40
	static RoleSkillConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSkillConfig.CreateStaticDefaultValue), new Action(RoleSkillConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A3DE RID: 41950
	private static RoleSkillConfig _Instance;
}
