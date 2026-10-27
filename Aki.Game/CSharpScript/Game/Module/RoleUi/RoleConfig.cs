using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.World.Model;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02004CE4 RID: 19684
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class RoleConfig : ConfigBase
	{
		// Token: 0x06032D1E RID: 208158 RVA: 0x00BD8586 File Offset: 0x00BD6786
		public string GetRoleName(string roleNameId)
		{
			return ConfigMultiTextLang.GetLocalTextNew(roleNameId, null);
		}

		// Token: 0x06032D1F RID: 208159 RVA: 0x00BD858F File Offset: 0x00BD678F
		public int? LimitStringCount()
		{
			return ConfigCommonParamById.GetIntConfig("character_name_def_limit");
		}

		// Token: 0x06032D20 RID: 208160 RVA: 0x00BD859B File Offset: 0x00BD679B
		public string GetRoleResonanceGrowthDescribe(string describeId)
		{
			return ConfigMultiTextLang.GetLocalTextNew(describeId, null);
		}

		// Token: 0x06032D21 RID: 208161 RVA: 0x00BD85A4 File Offset: 0x00BD67A4
		public RoleInfo? GetRoleConfig(int id)
		{
			if (id == 0)
			{
				return null;
			}
			return ConfigRoleInfoById.GetConfig(this.GetBaseRoleId(id), true);
		}

		// Token: 0x06032D22 RID: 208162 RVA: 0x00BD85CC File Offset: 0x00BD67CC
		[NullableContext(2)]
		public string GetRoleConfigValueByParam(int Id, string param, [Nullable(1)] string tag)
		{
			RoleInfo? roleConfig = this.GetRoleConfig(Id);
			if (roleConfig == null || string.IsNullOrEmpty(param))
			{
				return null;
			}
			if (param != null)
			{
				int length = param.Length;
				if (length != 4)
				{
					if (length != 9)
					{
						switch (length)
						{
						case 12:
							if (param == "RoleHeadIcon")
							{
								return roleConfig.Value.RoleHeadIcon;
							}
							break;
						case 15:
							if (param == "RoleHeadIconBig")
							{
								return roleConfig.Value.RoleHeadIconBig;
							}
							break;
						case 17:
						{
							char c = param[0];
							if (c != 'F')
							{
								if (c == 'R')
								{
									if (param == "RoleHeadIconLarge")
									{
										return roleConfig.Value.RoleHeadIconLarge;
									}
								}
							}
							else if (param == "FormationRoleCard")
							{
								return roleConfig.Value.FormationRoleCard;
							}
							break;
						}
						case 18:
							if (param == "RoleHeadIconCircle")
							{
								return roleConfig.Value.RoleHeadIconCircle;
							}
							break;
						}
					}
					else if (param == "RoleStand")
					{
						return roleConfig.Value.RoleStand;
					}
				}
				else if (param == "Card")
				{
					return roleConfig.Value.Card;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiImageSetting;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "配置的表格字段查询到的资源路径不是字符串类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("配置的表格字段", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x06032D23 RID: 208163 RVA: 0x00BD8770 File Offset: 0x00BD6970
		public RoleMorph? GetRoleMorphConfig(int roleId, int skinId, EUiModelMorphType morphType)
		{
			IReadOnlyList<RoleMorph> configList = ConfigRoleMorphByRoleId.GetConfigList(roleId, true);
			if (configList == null || configList.Count <= 0)
			{
				return null;
			}
			foreach (RoleMorph value in configList)
			{
				if (value.Morph == (int)morphType && value.SkinId == skinId)
				{
					return new RoleMorph?(value);
				}
			}
			return null;
		}

		// Token: 0x06032D24 RID: 208164 RVA: 0x00BD87F8 File Offset: 0x00BD69F8
		[NullableContext(2)]
		public List<RoleMorph> GetRoleMorphConfigList(int roleId, int skinId)
		{
			IReadOnlyList<RoleMorph> configList = ConfigRoleMorphByRoleId.GetConfigList(roleId, true);
			if (configList == null || configList.Count <= 0)
			{
				return null;
			}
			List<RoleMorph> list = new List<RoleMorph>();
			foreach (RoleMorph item in configList)
			{
				if (item.SkinId == skinId)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06032D25 RID: 208165 RVA: 0x00BD8868 File Offset: 0x00BD6A68
		public AutoRole? GetAutoRoleConfig(int id)
		{
			return ConfigAutoRoleById.GetConfig(this.GetBaseRoleId(id), true);
		}

		// Token: 0x06032D26 RID: 208166 RVA: 0x00BD8878 File Offset: 0x00BD6A78
		public int GetBaseRoleId(int id)
		{
			int result = id;
			if (this.IsTrialRole(id))
			{
				TrialRoleInfo? trialRoleInfo = this.GetTrialRoleConfigByGroupId(id);
				if (trialRoleInfo == null)
				{
					trialRoleInfo = this.GetTrialRoleConfig(id);
				}
				if (trialRoleInfo != null)
				{
					result = trialRoleInfo.Value.ParentId;
				}
				else
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06032D27 RID: 208167 RVA: 0x00BD88C7 File Offset: 0x00BD6AC7
		public bool IsTrialRole(int id)
		{
			return id > 100000;
		}

		// Token: 0x06032D28 RID: 208168 RVA: 0x00BD88D4 File Offset: 0x00BD6AD4
		public string GetRoleHeadIcon(int roleId, bool isBig = false)
		{
			RoleInfo? roleConfig = this.GetRoleConfig(roleId);
			if (!isBig)
			{
				return roleConfig.Value.RoleHeadIcon;
			}
			return roleConfig.Value.RoleHeadIconBig;
		}

		// Token: 0x06032D29 RID: 208169 RVA: 0x00BD890C File Offset: 0x00BD6B0C
		public TrialRoleInfo? GetRoleTrialGroupId(int groupId)
		{
			IReadOnlyList<TrialRoleInfo> configList = ConfigTrialRoleInfoByGroupId.GetConfigList(groupId, true);
			if (configList == null || configList.Count <= 0)
			{
				return null;
			}
			int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
			TrialRoleInfo? result = null;
			int num = curWorldLevel - configList[0].WorldLevel;
			foreach (TrialRoleInfo value in configList)
			{
				if (value.WorldLevel == curWorldLevel)
				{
					return new TrialRoleInfo?(value);
				}
				if (value.WorldLevel <= curWorldLevel)
				{
					int num2 = curWorldLevel - value.WorldLevel;
					if (num2 <= num)
					{
						num = num2;
						result = new TrialRoleInfo?(value);
					}
				}
			}
			return result;
		}

		// Token: 0x06032D2A RID: 208170 RVA: 0x00BD89D8 File Offset: 0x00BD6BD8
		public TrialRoleInfo? GetGenderRoleTrialByGroupId(int groupId)
		{
			IReadOnlyList<TrialRoleInfo> configList = ConfigTrialRoleInfoByGroupId.GetConfigList(groupId, true);
			if (configList == null || configList.Count <= 0)
			{
				return null;
			}
			int playerGender = this.GetPlayerGender();
			int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
			TrialRoleInfo? result = null;
			int num = curWorldLevel - configList[0].WorldLevel;
			foreach (TrialRoleInfo value in configList)
			{
				int gender = value.Gender;
				if (gender < 0 || playerGender == gender)
				{
					if (value.WorldLevel == curWorldLevel)
					{
						return new TrialRoleInfo?(value);
					}
					if (value.WorldLevel <= curWorldLevel)
					{
						int num2 = curWorldLevel - value.WorldLevel;
						if (num2 <= num)
						{
							num = num2;
							result = new TrialRoleInfo?(value);
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06032D2B RID: 208171 RVA: 0x00BD8AC0 File Offset: 0x00BD6CC0
		public Damage? GetDamageConfig(int damageId)
		{
			return DamageModel.Instance.GetDamageConfigById((long)damageId);
		}

		// Token: 0x06032D2C RID: 208172 RVA: 0x00BD8ACE File Offset: 0x00BD6CCE
		[NullableContext(2)]
		public IReadOnlyList<RoleBreach> GetRoleBreachList(int groupId)
		{
			return ConfigRoleBreachByBreachGroupId.GetConfigList(groupId, true);
		}

		// Token: 0x06032D2D RID: 208173 RVA: 0x00BD8AD7 File Offset: 0x00BD6CD7
		public RoleBreach? GetRoleBreachConfig(int groupId, int level)
		{
			return ConfigRoleBreachByBreachGroupIdAndBreachLevel.GetConfig(groupId, level, true);
		}

		// Token: 0x06032D2E RID: 208174 RVA: 0x00BD8AE1 File Offset: 0x00BD6CE1
		[NullableContext(2)]
		public IReadOnlyList<RoleExpItem> GetRoleExpItemList()
		{
			return ConfigRoleExpItemAll.GetConfigList(true);
		}

		// Token: 0x06032D2F RID: 208175 RVA: 0x00BD8AEC File Offset: 0x00BD6CEC
		public int? GetRoleExpItemExp(int itemId)
		{
			RoleExpItem? config = ConfigRoleExpItemById.GetConfig(itemId, true);
			if (config == null)
			{
				return null;
			}
			return new int?(config.GetValueOrDefault().BasicExp);
		}

		// Token: 0x06032D30 RID: 208176 RVA: 0x00BD8B28 File Offset: 0x00BD6D28
		public float? GetRolePerformanceDelayTime()
		{
			return ConfigCommonParamById.GetFloatConfig("action_stand_show_time");
		}

		// Token: 0x06032D31 RID: 208177 RVA: 0x00BD8B34 File Offset: 0x00BD6D34
		public int? GetRoleHuluModelId()
		{
			return ConfigCommonParamById.GetIntConfig("role_panel_using_model");
		}

		// Token: 0x06032D32 RID: 208178 RVA: 0x00BD8B40 File Offset: 0x00BD6D40
		[NullableContext(2)]
		public IReadOnlyList<RoleAnimAudio> GetRoleAudioMap(int roleId)
		{
			return ConfigRoleAnimAudioByRoleId.GetConfigList(roleId, true);
		}

		// Token: 0x06032D33 RID: 208179 RVA: 0x00BD8B49 File Offset: 0x00BD6D49
		[NullableContext(2)]
		public IReadOnlyList<RoleInfo> GetRoleList()
		{
			return ConfigRoleInfoAll.GetConfigList(true);
		}

		// Token: 0x06032D34 RID: 208180 RVA: 0x00BD8B51 File Offset: 0x00BD6D51
		[NullableContext(2)]
		public IReadOnlyList<RoleInfo> GetRoleListByType(ERoleType type)
		{
			return ConfigRoleInfoByRoleType.GetConfigList((int)type, true);
		}

		// Token: 0x06032D35 RID: 208181 RVA: 0x00BD8B5A File Offset: 0x00BD6D5A
		public int? GetResonAnimationInterval()
		{
			return ConfigCommonParamById.GetIntConfig("role_reson_animation_interval");
		}

		// Token: 0x06032D36 RID: 208182 RVA: 0x00BD8B66 File Offset: 0x00BD6D66
		public int? GetRoleLevelUpSuccessDelayTime()
		{
			return ConfigCommonParamById.GetIntConfig("RoleLevelUpSuccessDelayTime");
		}

		// Token: 0x06032D37 RID: 208183 RVA: 0x00BD8B72 File Offset: 0x00BD6D72
		public int? GetRoleBreachSuccessDelayTime()
		{
			return ConfigCommonParamById.GetIntConfig("RoleBreachSuccessDelayTime");
		}

		// Token: 0x06032D38 RID: 208184 RVA: 0x00BD8B7E File Offset: 0x00BD6D7E
		public int? GetWeaponLevelUpSuccessDelayTime()
		{
			return ConfigCommonParamById.GetIntConfig("WeaponLevelUpSuccessDelayTime");
		}

		// Token: 0x06032D39 RID: 208185 RVA: 0x00BD8B8A File Offset: 0x00BD6D8A
		public int? GetWeaponBreachDaDelayTime()
		{
			return ConfigCommonParamById.GetIntConfig("WeaponBreachChangeDelay");
		}

		// Token: 0x06032D3A RID: 208186 RVA: 0x00BD8B96 File Offset: 0x00BD6D96
		public int? GetRoleElementSwitchDelayTime()
		{
			return ConfigCommonParamById.GetIntConfig("RoleElementSwitchDelayTime");
		}

		// Token: 0x06032D3B RID: 208187 RVA: 0x00BD8BA2 File Offset: 0x00BD6DA2
		public int? GetRoleElementTransferFunctionId()
		{
			return ConfigCommonParamById.GetIntConfig("RoleElementTransferFunctionId");
		}

		// Token: 0x06032D3C RID: 208188 RVA: 0x00BD8BAE File Offset: 0x00BD6DAE
		public int? GetRoleGenderSwitchDelayTime()
		{
			return ConfigCommonParamById.GetIntConfig("RoleGenderSwitchDelayTime");
		}

		// Token: 0x06032D3D RID: 208189 RVA: 0x00BD8BBA File Offset: 0x00BD6DBA
		public RoleLevelConsume? GetRoleLevelConsume(int levelConsumeId, int level)
		{
			return ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.GetConfig(levelConsumeId, level, true);
		}

		// Token: 0x06032D3E RID: 208190 RVA: 0x00BD8BC4 File Offset: 0x00BD6DC4
		public RoleQualityInfo? GetRoleQualityInfo(int qualityId)
		{
			return ConfigRoleQualityInfoById.GetConfig(qualityId, true);
		}

		// Token: 0x06032D3F RID: 208191 RVA: 0x00BD8BCD File Offset: 0x00BD6DCD
		public TrialRoleInfo? GetTrialRoleConfig(int id)
		{
			return ConfigTrialRoleInfoById.GetConfig(id, true);
		}

		// Token: 0x06032D40 RID: 208192 RVA: 0x00BD8BD6 File Offset: 0x00BD6DD6
		public TrialRoleInfo? GetTrialRoleConfigByGroupId(int id)
		{
			return this.GetGenderRoleTrialByGroupId(id);
		}

		// Token: 0x06032D41 RID: 208193 RVA: 0x00BD8BE0 File Offset: 0x00BD6DE0
		public int GetTrialRoleIdConfigByGroupId(int id)
		{
			TrialRoleInfo? genderRoleTrialByGroupId = this.GetGenderRoleTrialByGroupId(id);
			if (genderRoleTrialByGroupId == null)
			{
				return id;
			}
			return genderRoleTrialByGroupId.Value.Id;
		}

		// Token: 0x06032D42 RID: 208194 RVA: 0x00BD8C0F File Offset: 0x00BD6E0F
		public RoleTrainingDegree? GetRoleTrainingDegreeConfig(int level)
		{
			return ConfigRoleTrainingDegreeByDifficultyLevel.GetConfig(level, true);
		}

		// Token: 0x06032D43 RID: 208195 RVA: 0x00BD8C18 File Offset: 0x00BD6E18
		[NullableContext(2)]
		public IReadOnlyList<MainRoleConfig> GetMainRoleByGender(LoginDefine.ELoginSex gender)
		{
			return ConfigMainRoleConfigByGender.GetConfigList((int)gender, true);
		}

		// Token: 0x06032D44 RID: 208196 RVA: 0x00BD8C21 File Offset: 0x00BD6E21
		public MainRoleConfig? GetMainRoleById(int id)
		{
			return ConfigMainRoleConfigById.GetConfig(id, true);
		}

		// Token: 0x06032D45 RID: 208197 RVA: 0x00BD8C2A File Offset: 0x00BD6E2A
		[NullableContext(2)]
		public IReadOnlyList<MainRoleConfig> GetAllMainRoleConfig()
		{
			return ConfigMainRoleConfigAll.GetConfigList(true);
		}

		// Token: 0x06032D46 RID: 208198 RVA: 0x00BD8C32 File Offset: 0x00BD6E32
		public RoleTag? GetRoleTagConfig(int tagId)
		{
			return ConfigRoleTagById.GetConfig(tagId, true);
		}

		// Token: 0x06032D47 RID: 208199 RVA: 0x00BD8C3C File Offset: 0x00BD6E3C
		public List<int> GetAllRoleTagList()
		{
			List<int> allTagIdList = new List<int>();
			IReadOnlyList<RoleTag> allRoleTagConfig = this.GetAllRoleTagConfig();
			List<RoleTag> list = new List<RoleTag>();
			if (allRoleTagConfig != null)
			{
				list.AddRange(allRoleTagConfig);
			}
			list.Sort((RoleTag a, RoleTag b) => a.SortId - b.SortId);
			list.ForEach(delegate(RoleTag data)
			{
				allTagIdList.Add(data.Id);
			});
			return allTagIdList;
		}

		// Token: 0x06032D48 RID: 208200 RVA: 0x00BD8CAE File Offset: 0x00BD6EAE
		[NullableContext(2)]
		public IReadOnlyList<RoleTag> GetAllRoleTagConfig()
		{
			return ConfigRoleTagAll.GetConfigList(true);
		}

		// Token: 0x06032D49 RID: 208201 RVA: 0x00BD8CB6 File Offset: 0x00BD6EB6
		protected override bool OnClear()
		{
			this.RoleInfoMap.Clear();
			return true;
		}

		// Token: 0x06032D4A RID: 208202 RVA: 0x00BD8CC4 File Offset: 0x00BD6EC4
		private int GetPlayerGender()
		{
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			if (playerGender == EPlayerGender.Female)
			{
				return 0;
			}
			if (playerGender == EPlayerGender.Male)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x06032D4B RID: 208203 RVA: 0x00BD8CE8 File Offset: 0x00BD6EE8
		public RoleBody? GetRoleBodyConfig(int roleId)
		{
			return ConfigRoleBodyById.GetConfig(this.GetRoleConfig(roleId).Value.RoleBody, true);
		}

		// Token: 0x06032D4C RID: 208204 RVA: 0x00BD8D12 File Offset: 0x00BD6F12
		public SkillBranch? GetSkillBranchConfigById(int id)
		{
			return ConfigSkillBranchById.GetConfig(id, true);
		}

		// Token: 0x06032D4D RID: 208205 RVA: 0x00BD8D1C File Offset: 0x00BD6F1C
		public int[] GetRoleBranchIds(int roleId)
		{
			int id = RoleUtils.IsTrialRole(roleId) ? RoleUtils.GetTrailRoleRealRoleId(roleId) : roleId;
			RoleInfo? roleConfig = this.GetRoleConfig(id);
			if (roleConfig == null)
			{
				return new int[0];
			}
			int skillBranchIdsLength = roleConfig.Value.SkillBranchIdsLength;
			int[] array = new int[skillBranchIdsLength];
			for (int i = 0; i < skillBranchIdsLength; i++)
			{
				array[i] = roleConfig.Value.SkillBranchIds(i);
			}
			return array;
		}

		// Token: 0x06032D4E RID: 208206 RVA: 0x00BD8D94 File Offset: 0x00BD6F94
		public List<SkillBranch> GetRoleBranchList(int roleId)
		{
			int[] roleBranchIds = this.GetRoleBranchIds(roleId);
			List<SkillBranch> list = new List<SkillBranch>();
			foreach (int id in roleBranchIds)
			{
				SkillBranch? skillBranchConfigById = this.GetSkillBranchConfigById(id);
				if (skillBranchConfigById != null)
				{
					list.Add(skillBranchConfigById.Value);
				}
			}
			return list;
		}

		// Token: 0x06032D4F RID: 208207 RVA: 0x00BD8DE4 File Offset: 0x00BD6FE4
		public int GetRoleDefaultBranch(int roleId)
		{
			if (RoleUtils.IsTrialRole(roleId))
			{
				TrialRoleInfo? trialRoleConfig = this.GetTrialRoleConfig(roleId);
				if (trialRoleConfig != null && trialRoleConfig.Value.DefaultSkillBranchId != 0)
				{
					return trialRoleConfig.Value.DefaultSkillBranchId;
				}
			}
			RoleInfo? roleConfig = this.GetRoleConfig(roleId);
			if (roleConfig == null)
			{
				return 0;
			}
			return roleConfig.Value.DefaultSkillBranchId;
		}

		// Token: 0x06032D50 RID: 208208 RVA: 0x00BD8E50 File Offset: 0x00BD7050
		public int[] GetSkillNodeBranchIds(int nodeId)
		{
			SkillTree? skillTreeNode = RoleSkillConfig.Instance.GetSkillTreeNode(nodeId);
			if (skillTreeNode == null)
			{
				return new int[0];
			}
			int skillBranchIdsLength = skillTreeNode.Value.SkillBranchIdsLength;
			int[] array = new int[skillBranchIdsLength];
			for (int i = 0; i < skillBranchIdsLength; i++)
			{
				array[i] = skillTreeNode.Value.SkillBranchIds(i);
			}
			return array;
		}

		// Token: 0x06032D51 RID: 208209 RVA: 0x00BD8EB6 File Offset: 0x00BD70B6
		public string GetSkillBranchActivatedDescKey()
		{
			return ConfigCommonParamById.GetStringConfig("SkillBranchActivatedDescKey") ?? "";
		}

		// Token: 0x06032D52 RID: 208210 RVA: 0x00BD8ECB File Offset: 0x00BD70CB
		public string GetSkillBranchSwitchSuccessKey()
		{
			return ConfigCommonParamById.GetStringConfig("SkillBranchSwitchSuccessTipsKey") ?? "";
		}

		// Token: 0x06032D53 RID: 208211 RVA: 0x00BD8EE0 File Offset: 0x00BD70E0
		public List<SkillBranch> GetSkillNodeBranchList(int nodeId)
		{
			int[] skillNodeBranchIds = this.GetSkillNodeBranchIds(nodeId);
			List<SkillBranch> list = new List<SkillBranch>();
			foreach (int id in skillNodeBranchIds)
			{
				SkillBranch? skillBranchConfigById = this.GetSkillBranchConfigById(id);
				if (skillBranchConfigById != null)
				{
					list.Add(skillBranchConfigById.Value);
				}
			}
			return list;
		}

		// Token: 0x06032D54 RID: 208212 RVA: 0x00BD8F30 File Offset: 0x00BD7130
		public Ornament? GetOrnamentConfig(int id)
		{
			Ornament? config = ConfigOrnamentById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RoleOrnament;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "饰品配置为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06032D55 RID: 208213 RVA: 0x00BD8F80 File Offset: 0x00BD7180
		public IReadOnlyList<Ornament> GetAllOrnamentConfig()
		{
			IReadOnlyList<Ornament> configList = ConfigOrnamentAll.GetConfigList(true);
			return configList ?? Array.Empty<Ornament>();
		}

		// Token: 0x06032D56 RID: 208214 RVA: 0x00BD8FA0 File Offset: 0x00BD71A0
		public string GetRoleLangStateGroup(int roleId)
		{
			RoleInfoLang? config = ConfigRoleInfoLangByRoleId.GetConfig(roleId, true);
			if (config == null)
			{
				return "";
			}
			return config.Value.StateGroupName;
		}

		// Token: 0x17007D9E RID: 32158
		// (get) Token: 0x06032D57 RID: 208215 RVA: 0x00BD8FD3 File Offset: 0x00BD71D3
		public static RoleConfig Instance
		{
			get
			{
				return RoleConfig._Instance;
			}
		}

		// Token: 0x06032D58 RID: 208216 RVA: 0x00BD8FDA File Offset: 0x00BD71DA
		public static RoleConfig GetOrCreateInstance()
		{
			if (RoleConfig._Instance == null)
			{
				RoleConfig.CreateInstance();
			}
			return RoleConfig._Instance;
		}

		// Token: 0x06032D59 RID: 208217 RVA: 0x00BD8FEE File Offset: 0x00BD71EE
		public static bool CreateInstance()
		{
			if (RoleConfig._Instance != null)
			{
				return true;
			}
			RoleConfig._Instance = new RoleConfig();
			return true;
		}

		// Token: 0x06032D5A RID: 208218 RVA: 0x00BD9004 File Offset: 0x00BD7204
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032D5B RID: 208219 RVA: 0x00BD9006 File Offset: 0x00BD7206
		public static void ResetStaticDefaultValue()
		{
			RoleConfig._Instance = null;
		}

		// Token: 0x06032D5C RID: 208220 RVA: 0x00BD900E File Offset: 0x00BD720E
		static RoleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleConfig.CreateStaticDefaultValue), new Action(RoleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401B0D8 RID: 110808
		private readonly Dictionary<int, RoleInfo> RoleInfoMap = new Dictionary<int, RoleInfo>();

		// Token: 0x0401B0D9 RID: 110809
		[Nullable(2)]
		private static RoleConfig _Instance;
	}
}
