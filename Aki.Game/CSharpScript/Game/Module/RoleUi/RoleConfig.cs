using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.World.Model;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02003C96 RID: 15510
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class RoleConfig : ConfigBase
	{
		// Token: 0x06027AF9 RID: 162553 RVA: 0x00B1DE8E File Offset: 0x00B1C08E
		public string GetRoleName(string roleNameId)
		{
			return ConfigMultiTextLang.GetLocalTextNew(roleNameId, null);
		}

		// Token: 0x06027AFA RID: 162554 RVA: 0x00B1DE97 File Offset: 0x00B1C097
		public int? LimitStringCount()
		{
			return ConfigCommonParamById.GetIntConfig("character_name_def_limit");
		}

		// Token: 0x06027AFB RID: 162555 RVA: 0x00B1DEA3 File Offset: 0x00B1C0A3
		public string GetRoleResonanceGrowthDescribe(string describeId)
		{
			return ConfigMultiTextLang.GetLocalTextNew(describeId, null);
		}

		// Token: 0x06027AFC RID: 162556 RVA: 0x00B1DEAC File Offset: 0x00B1C0AC
		public RoleInfo? GetRoleConfig(int id)
		{
			if (id == 0)
			{
				return null;
			}
			return ConfigRoleInfoById.GetConfig(this.GetBaseRoleId(id), true);
		}

		// Token: 0x06027AFD RID: 162557 RVA: 0x00B1DED4 File Offset: 0x00B1C0D4
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

		// Token: 0x06027AFE RID: 162558 RVA: 0x00B1E078 File Offset: 0x00B1C278
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

		// Token: 0x06027AFF RID: 162559 RVA: 0x00B1E100 File Offset: 0x00B1C300
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

		// Token: 0x06027B00 RID: 162560 RVA: 0x00B1E170 File Offset: 0x00B1C370
		public AutoRole? GetAutoRoleConfig(int id)
		{
			return ConfigAutoRoleById.GetConfig(this.GetBaseRoleId(id), true);
		}

		// Token: 0x06027B01 RID: 162561 RVA: 0x00B1E180 File Offset: 0x00B1C380
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

		// Token: 0x06027B02 RID: 162562 RVA: 0x00B1E1CF File Offset: 0x00B1C3CF
		public bool IsTrialRole(int id)
		{
			return id > 100000;
		}

		// Token: 0x06027B03 RID: 162563 RVA: 0x00B1E1DC File Offset: 0x00B1C3DC
		public string GetRoleHeadIcon(int roleId, bool isBig = false)
		{
			RoleInfo? roleConfig = this.GetRoleConfig(roleId);
			if (!isBig)
			{
				return roleConfig.Value.RoleHeadIcon;
			}
			return roleConfig.Value.RoleHeadIconBig;
		}

		// Token: 0x06027B04 RID: 162564 RVA: 0x00B1E214 File Offset: 0x00B1C414
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

		// Token: 0x06027B05 RID: 162565 RVA: 0x00B1E2E0 File Offset: 0x00B1C4E0
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

		// Token: 0x06027B06 RID: 162566 RVA: 0x00B1E3C8 File Offset: 0x00B1C5C8
		public Damage? GetDamageConfig(int damageId)
		{
			return DamageModel.Instance.GetDamageConfigById((long)damageId);
		}

		// Token: 0x06027B07 RID: 162567 RVA: 0x00B1E3D6 File Offset: 0x00B1C5D6
		[NullableContext(2)]
		public IReadOnlyList<RoleBreach> GetRoleBreachList(int groupId)
		{
			return ConfigRoleBreachByBreachGroupId.GetConfigList(groupId, true);
		}

		// Token: 0x06027B08 RID: 162568 RVA: 0x00B1E3DF File Offset: 0x00B1C5DF
		public RoleBreach? GetRoleBreachConfig(int groupId, int level)
		{
			return ConfigRoleBreachByBreachGroupIdAndBreachLevel.GetConfig(groupId, level, true);
		}

		// Token: 0x06027B09 RID: 162569 RVA: 0x00B1E3E9 File Offset: 0x00B1C5E9
		[NullableContext(2)]
		public IReadOnlyList<RoleExpItem> GetRoleExpItemList()
		{
			return ConfigRoleExpItemAll.GetConfigList(true);
		}

		// Token: 0x06027B0A RID: 162570 RVA: 0x00B1E3F4 File Offset: 0x00B1C5F4
		public int? GetRoleExpItemExp(int itemId)
		{
			RoleExpItem? config = ConfigRoleExpItemById.GetConfig(itemId, true);
			if (config == null)
			{
				return null;
			}
			return new int?(config.GetValueOrDefault().BasicExp);
		}

		// Token: 0x06027B0B RID: 162571 RVA: 0x00B1E430 File Offset: 0x00B1C630
		public float? GetRolePerformanceDelayTime()
		{
			return ConfigCommonParamById.GetFloatConfig("action_stand_show_time");
		}

		// Token: 0x06027B0C RID: 162572 RVA: 0x00B1E43C File Offset: 0x00B1C63C
		public int? GetRoleHuluModelId()
		{
			return ConfigCommonParamById.GetIntConfig("role_panel_using_model");
		}

		// Token: 0x06027B0D RID: 162573 RVA: 0x00B1E448 File Offset: 0x00B1C648
		[NullableContext(2)]
		public IReadOnlyList<RoleAnimAudio> GetRoleAudioMap(int roleId)
		{
			return ConfigRoleAnimAudioByRoleId.GetConfigList(roleId, true);
		}

		// Token: 0x06027B0E RID: 162574 RVA: 0x00B1E451 File Offset: 0x00B1C651
		[NullableContext(2)]
		public IReadOnlyList<RoleInfo> GetRoleList()
		{
			return ConfigRoleInfoAll.GetConfigList(true);
		}

		// Token: 0x06027B0F RID: 162575 RVA: 0x00B1E459 File Offset: 0x00B1C659
		[NullableContext(2)]
		public IReadOnlyList<RoleInfo> GetRoleListByType(ERoleType type)
		{
			return ConfigRoleInfoByRoleType.GetConfigList((int)type, true);
		}

		// Token: 0x06027B10 RID: 162576 RVA: 0x00B1E462 File Offset: 0x00B1C662
		public int? GetResonAnimationInterval()
		{
			return ConfigCommonParamById.GetIntConfig("role_reson_animation_interval");
		}

		// Token: 0x06027B11 RID: 162577 RVA: 0x00B1E46E File Offset: 0x00B1C66E
		public int? GetRoleLevelUpSuccessDelayTime()
		{
			return ConfigCommonParamById.GetIntConfig("RoleLevelUpSuccessDelayTime");
		}

		// Token: 0x06027B12 RID: 162578 RVA: 0x00B1E47A File Offset: 0x00B1C67A
		public int? GetRoleBreachSuccessDelayTime()
		{
			return ConfigCommonParamById.GetIntConfig("RoleBreachSuccessDelayTime");
		}

		// Token: 0x06027B13 RID: 162579 RVA: 0x00B1E486 File Offset: 0x00B1C686
		public int? GetWeaponLevelUpSuccessDelayTime()
		{
			return ConfigCommonParamById.GetIntConfig("WeaponLevelUpSuccessDelayTime");
		}

		// Token: 0x06027B14 RID: 162580 RVA: 0x00B1E492 File Offset: 0x00B1C692
		public int? GetWeaponBreachDaDelayTime()
		{
			return ConfigCommonParamById.GetIntConfig("WeaponBreachChangeDelay");
		}

		// Token: 0x06027B15 RID: 162581 RVA: 0x00B1E49E File Offset: 0x00B1C69E
		public int? GetRoleElementSwitchDelayTime()
		{
			return ConfigCommonParamById.GetIntConfig("RoleElementSwitchDelayTime");
		}

		// Token: 0x06027B16 RID: 162582 RVA: 0x00B1E4AA File Offset: 0x00B1C6AA
		public int? GetRoleElementTransferFunctionId()
		{
			return ConfigCommonParamById.GetIntConfig("RoleElementTransferFunctionId");
		}

		// Token: 0x06027B17 RID: 162583 RVA: 0x00B1E4B6 File Offset: 0x00B1C6B6
		public int? GetRoleGenderSwitchDelayTime()
		{
			return ConfigCommonParamById.GetIntConfig("RoleGenderSwitchDelayTime");
		}

		// Token: 0x06027B18 RID: 162584 RVA: 0x00B1E4C2 File Offset: 0x00B1C6C2
		public RoleLevelConsume? GetRoleLevelConsume(int levelConsumeId, int level)
		{
			return ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.GetConfig(levelConsumeId, level, true);
		}

		// Token: 0x06027B19 RID: 162585 RVA: 0x00B1E4CC File Offset: 0x00B1C6CC
		public RoleQualityInfo? GetRoleQualityInfo(int qualityId)
		{
			return ConfigRoleQualityInfoById.GetConfig(qualityId, true);
		}

		// Token: 0x06027B1A RID: 162586 RVA: 0x00B1E4D5 File Offset: 0x00B1C6D5
		public TrialRoleInfo? GetTrialRoleConfig(int id)
		{
			return ConfigTrialRoleInfoById.GetConfig(id, true);
		}

		// Token: 0x06027B1B RID: 162587 RVA: 0x00B1E4DE File Offset: 0x00B1C6DE
		public TrialRoleInfo? GetTrialRoleConfigByGroupId(int id)
		{
			return this.GetGenderRoleTrialByGroupId(id);
		}

		// Token: 0x06027B1C RID: 162588 RVA: 0x00B1E4E8 File Offset: 0x00B1C6E8
		public int GetTrialRoleIdConfigByGroupId(int id)
		{
			TrialRoleInfo? genderRoleTrialByGroupId = this.GetGenderRoleTrialByGroupId(id);
			if (genderRoleTrialByGroupId == null)
			{
				return id;
			}
			return genderRoleTrialByGroupId.Value.Id;
		}

		// Token: 0x06027B1D RID: 162589 RVA: 0x00B1E517 File Offset: 0x00B1C717
		public RoleTrainingDegree? GetRoleTrainingDegreeConfig(int level)
		{
			return ConfigRoleTrainingDegreeByDifficultyLevel.GetConfig(level, true);
		}

		// Token: 0x06027B1E RID: 162590 RVA: 0x00B1E520 File Offset: 0x00B1C720
		[NullableContext(2)]
		public IReadOnlyList<MainRoleConfig> GetMainRoleByGender(LoginDefine.ELoginSex gender)
		{
			return ConfigMainRoleConfigByGender.GetConfigList((int)gender, true);
		}

		// Token: 0x06027B1F RID: 162591 RVA: 0x00B1E529 File Offset: 0x00B1C729
		public MainRoleConfig? GetMainRoleById(int id)
		{
			return ConfigMainRoleConfigById.GetConfig(id, true);
		}

		// Token: 0x06027B20 RID: 162592 RVA: 0x00B1E532 File Offset: 0x00B1C732
		[NullableContext(2)]
		public IReadOnlyList<MainRoleConfig> GetAllMainRoleConfig()
		{
			return ConfigMainRoleConfigAll.GetConfigList(true);
		}

		// Token: 0x06027B21 RID: 162593 RVA: 0x00B1E53A File Offset: 0x00B1C73A
		public RoleTag? GetRoleTagConfig(int tagId)
		{
			return ConfigRoleTagById.GetConfig(tagId, true);
		}

		// Token: 0x06027B22 RID: 162594 RVA: 0x00B1E544 File Offset: 0x00B1C744
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

		// Token: 0x06027B23 RID: 162595 RVA: 0x00B1E5B6 File Offset: 0x00B1C7B6
		[NullableContext(2)]
		public IReadOnlyList<RoleTag> GetAllRoleTagConfig()
		{
			return ConfigRoleTagAll.GetConfigList(true);
		}

		// Token: 0x06027B24 RID: 162596 RVA: 0x00B1E5BE File Offset: 0x00B1C7BE
		protected override bool OnClear()
		{
			this.RoleInfoMap.Clear();
			return true;
		}

		// Token: 0x06027B25 RID: 162597 RVA: 0x00B1E5CC File Offset: 0x00B1C7CC
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

		// Token: 0x06027B26 RID: 162598 RVA: 0x00B1E5F0 File Offset: 0x00B1C7F0
		public RoleBody? GetRoleBodyConfig(int roleId)
		{
			return ConfigRoleBodyById.GetConfig(this.GetRoleConfig(roleId).Value.RoleBody, true);
		}

		// Token: 0x06027B27 RID: 162599 RVA: 0x00B1E61A File Offset: 0x00B1C81A
		public SkillBranch? GetSkillBranchConfigById(int id)
		{
			return ConfigSkillBranchById.GetConfig(id, true);
		}

		// Token: 0x06027B28 RID: 162600 RVA: 0x00B1E624 File Offset: 0x00B1C824
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

		// Token: 0x06027B29 RID: 162601 RVA: 0x00B1E69C File Offset: 0x00B1C89C
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

		// Token: 0x06027B2A RID: 162602 RVA: 0x00B1E6EC File Offset: 0x00B1C8EC
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

		// Token: 0x06027B2B RID: 162603 RVA: 0x00B1E758 File Offset: 0x00B1C958
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

		// Token: 0x06027B2C RID: 162604 RVA: 0x00B1E7BE File Offset: 0x00B1C9BE
		public string GetSkillBranchActivatedDescKey()
		{
			return ConfigCommonParamById.GetStringConfig("SkillBranchActivatedDescKey") ?? "";
		}

		// Token: 0x06027B2D RID: 162605 RVA: 0x00B1E7D3 File Offset: 0x00B1C9D3
		public string GetSkillBranchSwitchSuccessKey()
		{
			return ConfigCommonParamById.GetStringConfig("SkillBranchSwitchSuccessTipsKey") ?? "";
		}

		// Token: 0x06027B2E RID: 162606 RVA: 0x00B1E7E8 File Offset: 0x00B1C9E8
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

		// Token: 0x06027B2F RID: 162607 RVA: 0x00B1E838 File Offset: 0x00B1CA38
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

		// Token: 0x06027B30 RID: 162608 RVA: 0x00B1E888 File Offset: 0x00B1CA88
		public IReadOnlyList<Ornament> GetAllOrnamentConfig()
		{
			IReadOnlyList<Ornament> configList = ConfigOrnamentAll.GetConfigList(true);
			return configList ?? Array.Empty<Ornament>();
		}

		// Token: 0x06027B31 RID: 162609 RVA: 0x00B1E8A8 File Offset: 0x00B1CAA8
		public string GetRoleLangStateGroup(int roleId)
		{
			RoleInfoLang? config = ConfigRoleInfoLangByRoleId.GetConfig(roleId, true);
			if (config == null)
			{
				return "";
			}
			return config.Value.StateGroupName;
		}

		// Token: 0x17005148 RID: 20808
		// (get) Token: 0x06027B32 RID: 162610 RVA: 0x00B1E8DB File Offset: 0x00B1CADB
		public static RoleConfig Instance
		{
			get
			{
				return RoleConfig._Instance;
			}
		}

		// Token: 0x06027B33 RID: 162611 RVA: 0x00B1E8E2 File Offset: 0x00B1CAE2
		public static RoleConfig GetOrCreateInstance()
		{
			if (RoleConfig._Instance == null)
			{
				RoleConfig.CreateInstance();
			}
			return RoleConfig._Instance;
		}

		// Token: 0x06027B34 RID: 162612 RVA: 0x00B1E8F6 File Offset: 0x00B1CAF6
		public static bool CreateInstance()
		{
			if (RoleConfig._Instance != null)
			{
				return true;
			}
			RoleConfig._Instance = new RoleConfig();
			return true;
		}

		// Token: 0x06027B35 RID: 162613 RVA: 0x00B1E90C File Offset: 0x00B1CB0C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06027B36 RID: 162614 RVA: 0x00B1E90E File Offset: 0x00B1CB0E
		public static void ResetStaticDefaultValue()
		{
			RoleConfig._Instance = null;
		}

		// Token: 0x06027B37 RID: 162615 RVA: 0x00B1E916 File Offset: 0x00B1CB16
		static RoleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleConfig.CreateStaticDefaultValue), new Action(RoleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04015A5D RID: 88669
		private readonly Dictionary<int, RoleInfo> RoleInfoMap = new Dictionary<int, RoleInfo>();

		// Token: 0x04015A5E RID: 88670
		[Nullable(2)]
		private static RoleConfig _Instance;
	}
}
