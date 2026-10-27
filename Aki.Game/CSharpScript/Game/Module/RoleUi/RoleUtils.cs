using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Skin;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02004CE5 RID: 19685
	[NullableContext(1)]
	[Nullable(0)]
	public static class RoleUtils
	{
		// Token: 0x06032D5E RID: 208222 RVA: 0x00BD9040 File Offset: 0x00BD7240
		public static bool IsTrialRole(int id)
		{
			return id > 100000;
		}

		// Token: 0x06032D5F RID: 208223 RVA: 0x00BD904C File Offset: 0x00BD724C
		public static ETrialRoleType GetTrialRoleType(int id)
		{
			TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(id);
			if (trialRoleConfig == null)
			{
				return ETrialRoleType.None;
			}
			return (ETrialRoleType)trialRoleConfig.Value.Type;
		}

		// Token: 0x06032D60 RID: 208224 RVA: 0x00BD9080 File Offset: 0x00BD7280
		public static bool IsSpecialTrialRole(int id)
		{
			if (!RoleUtils.IsTrialRole(id))
			{
				return false;
			}
			ETrialRoleType trialRoleType = RoleUtils.GetTrialRoleType(id);
			return trialRoleType != ETrialRoleType.None && trialRoleType != ETrialRoleType.NormalTrial;
		}

		// Token: 0x06032D61 RID: 208225 RVA: 0x00BD90AC File Offset: 0x00BD72AC
		public static int GetTrailRoleRealRoleId(int id)
		{
			return RoleConfig.Instance.GetTrialRoleConfig(id).Value.ParentId;
		}

		// Token: 0x06032D62 RID: 208226 RVA: 0x00BD90D4 File Offset: 0x00BD72D4
		public static string GetTrailRoleLabelIconById(int trialRoleId)
		{
			TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(trialRoleId);
			if (trialRoleConfig == null)
			{
				return string.Empty;
			}
			return RoleUtils.GetTrialRoleLabelIconByType((ETrialRoleType)trialRoleConfig.Value.Type);
		}

		// Token: 0x06032D63 RID: 208227 RVA: 0x00BD9110 File Offset: 0x00BD7310
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

		// Token: 0x06032D64 RID: 208228 RVA: 0x00BD9149 File Offset: 0x00BD7349
		public static int GetRoleRealId(int roleId)
		{
			if (!RoleUtils.IsTrialRole(roleId))
			{
				return roleId;
			}
			return RoleUtils.GetTrailRoleRealRoleId(roleId);
		}

		// Token: 0x06032D65 RID: 208229 RVA: 0x00BD915C File Offset: 0x00BD735C
		public static bool NeedInstantAttributeBlend(int roleId)
		{
			int roleRealId = RoleUtils.GetRoleRealId(roleId);
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleRealId);
			return roleConfig != null && roleConfig.GetValueOrDefault().InstantAttributeBlend;
		}

		// Token: 0x06032D66 RID: 208230 RVA: 0x00BD9198 File Offset: 0x00BD7398
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

		// Token: 0x06032D67 RID: 208231 RVA: 0x00BD91E8 File Offset: 0x00BD73E8
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

		// Token: 0x06032D68 RID: 208232 RVA: 0x00BD9231 File Offset: 0x00BD7431
		public static List<int> MergeDefaultOrnaments(List<int> serverWearList, int skinId)
		{
			return RoleOrnamentModel.Instance.MergeDefaultOrnaments(serverWearList, skinId);
		}

		// Token: 0x06032D69 RID: 208233 RVA: 0x00BD9240 File Offset: 0x00BD7440
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

		// Token: 0x06032D6A RID: 208234 RVA: 0x00BD92C8 File Offset: 0x00BD74C8
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

		// Token: 0x06032D6B RID: 208235 RVA: 0x00BD92EC File Offset: 0x00BD74EC
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

		// Token: 0x06032D6C RID: 208236 RVA: 0x00BD9358 File Offset: 0x00BD7558
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

		// Token: 0x0401B0DA RID: 110810
		private const int HEALTH_ATTR_ID = 3;
	}
}
