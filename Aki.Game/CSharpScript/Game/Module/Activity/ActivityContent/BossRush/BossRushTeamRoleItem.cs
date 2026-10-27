using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x02006905 RID: 26885
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class BossRushTeamRoleItem : GridProxyAbstract<BossRushTeamData>
	{
		// Token: 0x060430AB RID: 274603 RVA: 0x0105533C File Offset: 0x0105353C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUITexture))
			};
		}

		// Token: 0x060430AC RID: 274604 RVA: 0x01055396 File Offset: 0x01053596
		protected void OnClickButton()
		{
			if (!UiManager.Instance.IsViewShow(EUiViewName.TeamRoleSelectView))
			{
				UiManager.Instance.OpenView(EUiViewName.TeamRoleSelectView, this.GetRoleSelectViewData(), null);
			}
		}

		// Token: 0x060430AD RID: 274605 RVA: 0x010553C0 File Offset: 0x010535C0
		private TeamRoleSelectViewData GetRoleSelectViewData()
		{
			if (this.CurrentTeamData.TeamInfo == null || this.CurrentTeamData.TeamInfo.LevelInfo == null)
			{
				return new TeamRoleSelectViewData(EFilterSortGroupId.EditFormation, 0, new List<RoleDataBase>(), null, null, null, null);
			}
			int fightFormationId = this.CurrentTeamData.TeamInfo.LevelInfo.GetInstanceDungeonConfig().Value.FightFormationId;
			FightFormation? fightFormationConfig = FormationConfig.Instance.GetFightFormationConfig(fightFormationId);
			List<RoleDataBase> list = new List<RoleDataBase>();
			foreach (RoleInstance roleInstance in RoleModel.Instance.GetRoleList())
			{
				if (roleInstance.GetRoleId() != 0)
				{
					list.Add(roleInstance);
				}
			}
			if (fightFormationConfig != null)
			{
				foreach (int id in fightFormationConfig.Value.TrialRole())
				{
					TrialRoleInfo? trialRoleConfigByGroupId = RoleConfig.Instance.GetTrialRoleConfigByGroupId(id);
					if (trialRoleConfigByGroupId != null)
					{
						RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(trialRoleConfigByGroupId.Value.Id, true);
						if (roleDataById != null)
						{
							list.Add(roleDataById);
						}
					}
				}
			}
			int currentRoleId = (this.CurrentTeamData.TeamInfo.GetCurrentTeamMembers().Length > base.GridIndex) ? this.CurrentTeamData.TeamInfo.GetCurrentTeamMembers()[base.GridIndex] : 0;
			TeamRoleSelectViewData teamRoleSelectViewData = new TeamRoleSelectViewData(EFilterSortGroupId.EditFormation, currentRoleId, list, new Action<int>(this.OnEnsureFormation), null, new int?(base.GridIndex + 1), null);
			teamRoleSelectViewData.CanConfirmFunc = new Func<int, bool>(this.CanConfirmFunc);
			teamRoleSelectViewData.CanJoinTeam = new Func<int, bool>(this.CanJoinTeam);
			teamRoleSelectViewData.SetGetConfirmButtonTextFunction(new Func<int, string>(this.GetConfirmButtonTextFunction));
			int[] currentTeamMembers = this.CurrentTeamData.TeamInfo.GetCurrentTeamMembers();
			List<int> list2 = new List<int>();
			foreach (int num in currentTeamMembers)
			{
				if (num != 0)
				{
					list2.Add(num);
				}
			}
			teamRoleSelectViewData.FormationRoleList = list2.ToArray();
			BattleTeamDungeonContext context = BattleTeamModel.Instance.Context;
			BossRushLevelDetailInfo levelInfo = this.CurrentTeamData.TeamInfo.LevelInfo;
			context.SetInstanceDungeonId(new int?((levelInfo != null) ? levelInfo.GetInstanceDungeonConfig().Value.Id : 0));
			return teamRoleSelectViewData;
		}

		// Token: 0x060430AE RID: 274606 RVA: 0x01055624 File Offset: 0x01053824
		[NullableContext(2)]
		private string GetConfirmButtonTextFunction(int roleConfigId)
		{
			if (roleConfigId == 0)
			{
				return null;
			}
			if (this.CurrentTeamData.TeamInfo == null)
			{
				return null;
			}
			int[] currentTeamMembers = this.CurrentTeamData.TeamInfo.GetCurrentTeamMembers();
			int num = (base.GridIndex < currentTeamMembers.Length) ? currentTeamMembers[base.GridIndex] : 0;
			int num2 = Array.IndexOf<int>(currentTeamMembers, roleConfigId);
			if (num == 0 && num2 == -1)
			{
				return "JoinText";
			}
			if (num == roleConfigId)
			{
				return "GoDownText";
			}
			return "ChangeText";
		}

		// Token: 0x060430AF RID: 274607 RVA: 0x01055691 File Offset: 0x01053891
		private bool CanJoinTeam(int roleId)
		{
			return this.CurrentTeamData.TeamInfo != null && Array.IndexOf<int>(this.CurrentTeamData.TeamInfo.GetCurrentTeamMembers(), roleId) == -1;
		}

		// Token: 0x060430B0 RID: 274608 RVA: 0x010556BC File Offset: 0x010538BC
		private bool CanConfirmFunc(int roleId)
		{
			if (this.CurrentTeamData.TeamInfo == null || this.CurrentTeamData.TeamInfo.LevelInfo == null)
			{
				return false;
			}
			int[] currentTeamMembers = this.CurrentTeamData.TeamInfo.GetCurrentTeamMembers();
			if (((base.GridIndex < currentTeamMembers.Length) ? currentTeamMembers[base.GridIndex] : 0) == roleId)
			{
				return true;
			}
			int num = Array.IndexOf<int>(currentTeamMembers, roleId);
			if (num != -1 && num != base.GridIndex)
			{
				return true;
			}
			int fightFormationId = this.CurrentTeamData.TeamInfo.LevelInfo.GetInstanceDungeonConfig().Value.FightFormationId;
			FightFormation? fightFormationConfig = FormationConfig.Instance.GetFightFormationConfig(fightFormationId);
			if (fightFormationConfig == null)
			{
				return true;
			}
			int num2 = roleId;
			bool result = true;
			foreach (int id in fightFormationConfig.Value.TrialRole())
			{
				TrialRoleInfo? trialRoleConfigByGroupId = RoleConfig.Instance.GetTrialRoleConfigByGroupId(id);
				if (trialRoleConfigByGroupId != null && trialRoleConfigByGroupId.Value.Id == roleId)
				{
					num2 = trialRoleConfigByGroupId.Value.ParentId;
					break;
				}
			}
			int[] currentTeamMembers2 = this.CurrentTeamData.TeamInfo.GetCurrentTeamMembers();
			for (int j = 0; j < currentTeamMembers2.Length; j++)
			{
				int num3 = currentTeamMembers2[j];
				if (num3 != 0 && j != base.GridIndex)
				{
					int num4 = num3;
					TrialRoleInfo? trialRoleConfigByGroupId2 = RoleConfig.Instance.GetTrialRoleConfigByGroupId(num3);
					if (trialRoleConfigByGroupId2 != null)
					{
						num4 = trialRoleConfigByGroupId2.Value.ParentId;
					}
					if (num4 == num2)
					{
						result = false;
						ScrollingTipsController.Instance.ShowTipsByTextId("BossRushSameFormation", Array.Empty<object>());
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x060430B1 RID: 274609 RVA: 0x01055864 File Offset: 0x01053A64
		private void OnEnsureFormation(int roleId)
		{
			if (this.CurrentTeamData.TeamInfo == null)
			{
				return;
			}
			int[] currentTeamMembers = this.CurrentTeamData.TeamInfo.GetCurrentTeamMembers();
			int num = (base.GridIndex < currentTeamMembers.Length) ? currentTeamMembers[base.GridIndex] : 0;
			int num2 = Array.IndexOf<int>(currentTeamMembers, roleId);
			if (num == 0 && num2 == -1)
			{
				this.CurrentTeamData.TeamInfo.SetIndexTeamMembers(base.GridIndex, roleId);
			}
			else if (num == roleId)
			{
				this.CurrentTeamData.TeamInfo.SetIndexTeamMembers(base.GridIndex, 0);
			}
			else
			{
				if (num2 != -1)
				{
					this.CurrentTeamData.TeamInfo.SetIndexTeamMembers(num2, num);
				}
				this.CurrentTeamData.TeamInfo.SetIndexTeamMembers(base.GridIndex, roleId);
			}
			this.CurrentTeamData.TeamInfo.ReSortTeamMembers();
			Action onSelectRole = this.CurrentTeamData.OnSelectRole;
			if (onSelectRole == null)
			{
				return;
			}
			onSelectRole();
		}

		// Token: 0x060430B2 RID: 274610 RVA: 0x0105593E File Offset: 0x01053B3E
		public override void Refresh(BossRushTeamData data, bool isSelected, int gridIndex)
		{
			this.CurrentTeamData = data;
			this.RefreshRoleTexture();
		}

		// Token: 0x060430B3 RID: 274611 RVA: 0x01055950 File Offset: 0x01053B50
		private void RefreshRoleTexture()
		{
			if (this.CurrentTeamData.RoleId == 0)
			{
				base.GetTexture(2).SetUIActive(false);
				return;
			}
			base.GetTexture(2).SetUIActive(true);
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.CurrentTeamData.RoleId);
			if (roleConfig != null)
			{
				base.SetRoleIcon(roleConfig.Value.RoleHeadIconCircle, base.GetTexture(2), this.CurrentTeamData.RoleId, null, null);
			}
		}

		// Token: 0x04022E6D RID: 142957
		private BossRushTeamData CurrentTeamData = new BossRushTeamData();
	}
}
