using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Skin;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02003C97 RID: 15511
	[NullableContext(1)]
	[Nullable(0)]
	public static class RoleUtils
	{
		// Token: 0x06027B39 RID: 162617 RVA: 0x00B1E948 File Offset: 0x00B1CB48
		public static bool IsTrialRole(int id)
		{
			return id > 100000;
		}

		// Token: 0x06027B3A RID: 162618 RVA: 0x00B1E954 File Offset: 0x00B1CB54
		public static ETrialRoleType GetTrialRoleType(int id)
		{
			TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(id);
			if (trialRoleConfig == null)
			{
				return ETrialRoleType.None;
			}
			return (ETrialRoleType)trialRoleConfig.Value.Type;
		}

		// Token: 0x06027B3B RID: 162619 RVA: 0x00B1E988 File Offset: 0x00B1CB88
		public static bool IsSpecialTrialRole(int id)
		{
			if (!RoleUtils.IsTrialRole(id))
			{
				return false;
			}
			ETrialRoleType trialRoleType = RoleUtils.GetTrialRoleType(id);
			return trialRoleType != ETrialRoleType.None && trialRoleType != ETrialRoleType.NormalTrial;
		}

		// Token: 0x06027B3C RID: 162620 RVA: 0x00B1E9B4 File Offset: 0x00B1CBB4
		public static int GetTrailRoleRealRoleId(int id)
		{
			return RoleConfig.Instance.GetTrialRoleConfig(id).Value.ParentId;
		}

		// Token: 0x06027B3D RID: 162621 RVA: 0x00B1E9DC File Offset: 0x00B1CBDC
		public static string GetTrailRoleLabelIconById(int trialRoleId)
		{
			TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(trialRoleId);
			if (trialRoleConfig == null)
			{
				return string.Empty;
			}
			return RoleUtils.GetTrialRoleLabelIconByType((ETrialRoleType)trialRoleConfig.Value.Type);
		}

		// Token: 0x06027B3E RID: 162622 RVA: 0x00B1EA18 File Offset: 0x00B1CC18
		public static string GetTrialRoleLabelIconByType(ETrialRoleType trialRoleType)
		{
			switch (trialRoleType)
			{
			case ETrialRoleType.NormalTrial:
				return "SP_TagRoleTrial00";
			case ETrialRoleType.NewbieSupportTrial:
				return "SP_TagRoleTrial02";
			case ETrialRoleType.ReturnSupportTrial:
				return "SP_TagRoleTrial01";
			case ETrialRoleType.NewbieSupportTrialV2:
				return "SP_TagRoleTrial02";
			default:
				return "SP_TagRoleTrial00";
			}
		}

		// Token: 0x06027B3F RID: 162623 RVA: 0x00B1EA51 File Offset: 0x00B1CC51
		public static int GetRoleRealId(int roleId)
		{
			if (!RoleUtils.IsTrialRole(roleId))
			{
				return roleId;
			}
			return RoleUtils.GetTrailRoleRealRoleId(roleId);
		}

		// Token: 0x06027B40 RID: 162624 RVA: 0x00B1EA64 File Offset: 0x00B1CC64
		public static bool NeedInstantAttributeBlend(int roleId)
		{
			int roleRealId = RoleUtils.GetRoleRealId(roleId);
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleRealId);
			return roleConfig != null && roleConfig.GetValueOrDefault().InstantAttributeBlend;
		}

		// Token: 0x06027B41 RID: 162625 RVA: 0x00B1EAA0 File Offset: 0x00B1CCA0
		public static bool HasMultiTrialRole(int roleId, int[] roleIdList, int? replaceIndex = null)
		{
			if (RoleUtils.FindRoleIdIndex(roleId, roleIdList) != -1)
			{
				return false;
			}
			int[] array = RoleUtils.BuildSimulatedList(roleId, roleIdList, replaceIndex);
			if (RoleUtils.IsSpecialTrialRole(roleId))
			{
				foreach (int num in array)
				{
					if (num != roleId && RoleUtils.IsSpecialTrialRole(num))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06027B42 RID: 162626 RVA: 0x00B1EAF0 File Offset: 0x00B1CCF0
		public static bool HasSameRole(int roleId, int[] roleIdList, int? replaceIndex = null)
		{
			if (RoleUtils.FindRoleIdIndex(roleId, roleIdList) != -1)
			{
				return false;
			}
			foreach (int num in RoleUtils.BuildSimulatedList(roleId, roleIdList, replaceIndex))
			{
				if (roleId != num && RoleUtils.GetRoleRealId(roleId) == RoleUtils.GetRoleRealId(num))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06027B43 RID: 162627 RVA: 0x00B1EB39 File Offset: 0x00B1CD39
		public static List<int> MergeDefaultOrnaments(List<int> serverWearList, int skinId)
		{
			return RoleOrnamentModel.Instance.MergeDefaultOrnaments(serverWearList, skinId);
		}

		// Token: 0x06027B44 RID: 162628 RVA: 0x00B1EB48 File Offset: 0x00B1CD48
		public static int GetSkinOrnamentModelId(int skinId, int ornamentId)
		{
			Ornament value = RoleConfig.Instance.GetOrnamentConfig(ornamentId).Value;
			RoleSkin value2 = SkinConfig.Instance.GetRoleSkinConfig(skinId).Value;
			if (!RoleModel.Instance.IsMainRole(value2.RoleId))
			{
				return value.ModelId(0);
			}
			if (RoleConfig.Instance.GetMainRoleById(value2.RoleId).Value.Gender != 1)
			{
				return value.ModelId(1);
			}
			return value.ModelId(0);
		}

		// Token: 0x06027B45 RID: 162629 RVA: 0x00B1EBD0 File Offset: 0x00B1CDD0
		private static int FindRoleIdIndex(int roleId, int[] roleIdList)
		{
			for (int i = 0; i < roleIdList.Length; i++)
			{
				if (roleIdList[i] == roleId)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06027B46 RID: 162630 RVA: 0x00B1EBF4 File Offset: 0x00B1CDF4
		private static int[] BuildSimulatedList(int roleId, int[] roleIdList, int? replaceIndex)
		{
			if (replaceIndex != null)
			{
				int? num = replaceIndex;
				int num2 = 0;
				if (!(num.GetValueOrDefault() < num2 & num != null))
				{
					num = replaceIndex;
					num2 = roleIdList.Length;
					if (!(num.GetValueOrDefault() >= num2 & num != null))
					{
						int[] array = new int[roleIdList.Length];
						roleIdList.CopyTo(array, 0);
						array[replaceIndex.Value] = roleId;
						return array;
					}
				}
			}
			return roleIdList;
		}

		// Token: 0x06027B47 RID: 162631 RVA: 0x00B1EC60 File Offset: 0x00B1CE60
		public static bool IsRoleDead(int roleConfigId)
		{
			SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)roleConfigId, new GetTeamItemOptions
			{
				ParamType = ETeamParamType.ConfigId,
				OnlyMyRole = new bool?(true)
			});
			if (teamItem != null)
			{
				return teamItem.IsDead();
			}
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleConfigId, true);
			return roleDataById == null || roleDataById.GetAttributeData().GetAttrValueById(3) <= 0;
		}

		// Token: 0x04015A5F RID: 88671
		private const int HEALTH_ATTR_ID = 3;
	}
}
