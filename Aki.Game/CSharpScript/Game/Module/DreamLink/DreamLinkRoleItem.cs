using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AAC RID: 23212
	public class DreamLinkRoleItem : UiPanelBase
	{
		// Token: 0x17008C15 RID: 35861
		// (get) Token: 0x0603ACCC RID: 240844 RVA: 0x00E026A7 File Offset: 0x00E008A7
		protected int RoleId
		{
			get
			{
				return this.ActivityBaseData.GetBossRoleId(this.InstId, this.Index);
			}
		}

		// Token: 0x0603ACCD RID: 240845 RVA: 0x00E026C0 File Offset: 0x00E008C0
		[NullableContext(1)]
		public DreamLinkRoleItem(DreamLinkData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0603ACCE RID: 240846 RVA: 0x00E026D0 File Offset: 0x00E008D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickRole));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603ACCF RID: 240847 RVA: 0x00E027B8 File Offset: 0x00E009B8
		private void OnClickRole()
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(this.InstId);
			if (config == null)
			{
				return;
			}
			FightFormation? fightFormationConfig = FormationConfig.Instance.GetFightFormationConfig(config.Value.FightFormationId);
			if (fightFormationConfig == null)
			{
				return;
			}
			List<RoleDataBase> list = new List<RoleDataBase>();
			IReadOnlyList<BattleLinkCharacter> readOnlyList = DreamLinkConfig.Instance.GetRoleConfigList() ?? Array.Empty<BattleLinkCharacter>();
			foreach (int id in fightFormationConfig.Value.TrialRole())
			{
				TrialRoleInfo? trialRoleConfigByGroupId = RoleConfig.Instance.GetTrialRoleConfigByGroupId(id);
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(trialRoleConfigByGroupId.Value.Id, true);
				if (roleDataById != null)
				{
					list.Add(roleDataById);
				}
			}
			bool flag = false;
			foreach (BattleLinkCharacter battleLinkCharacter in readOnlyList)
			{
				if (battleLinkCharacter.IsShowInTeamView)
				{
					RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(battleLinkCharacter.Id);
					if (roleInstanceById != null && (!RoleModel.Instance.IsMainRole(battleLinkCharacter.Id) || !flag))
					{
						if (RoleModel.Instance.IsMainRole(battleLinkCharacter.Id))
						{
							flag = true;
						}
						list.Add(roleInstanceById);
					}
				}
			}
			list.Sort(delegate(RoleDataBase a, RoleDataBase b)
			{
				if (!a.IsTrialRole())
				{
					return -1;
				}
				return 1;
			});
			TeamRoleSelectViewData teamRoleSelectViewData = new TeamRoleSelectViewData(EFilterSortGroupId.EditFormation, this.RoleId, list, delegate(int roleId)
			{
				if (this.RoleId == roleId)
				{
					this.ActivityBaseData.SetBossRoleId(this.InstId, this.Index, 0);
				}
				else
				{
					int roleId2 = this.RoleId;
					List<int> allBossRoleId = this.ActivityBaseData.GetAllBossRoleId(this.InstId);
					for (int j = 0; j < allBossRoleId.Count; j++)
					{
						if (allBossRoleId[j] == roleId)
						{
							this.ActivityBaseData.SetBossRoleId(this.InstId, j, roleId2);
							break;
						}
					}
					this.ActivityBaseData.SetBossRoleId(this.InstId, this.Index, roleId);
				}
				Action refreshHandle = this.RefreshHandle;
				if (refreshHandle == null)
				{
					return;
				}
				refreshHandle();
			}, null, new int?(this.Index + 1), null);
			teamRoleSelectViewData.FormationRoleList = this.ActivityBaseData.GetAllBossRoleId(this.InstId).ToArray();
			teamRoleSelectViewData.IsNeedRevive = new Func<int, bool>(this.IsNeedRevive);
			teamRoleSelectViewData.GetConfirmButtonTextCallBack = new Func<int, string>(this.GetConfirmButtonTextFunction);
			teamRoleSelectViewData.GetConfirmButtonEnableCallBack = new Func<int, bool>(this.CanJoinTeam);
			teamRoleSelectViewData.CanJoinTeam = new Func<int, bool>(this.CanJoinTeam);
			teamRoleSelectViewData.BackCallBack = new Action(this.OnSelectBack);
			RoleController.Instance.OpenTeamRoleSelectView(teamRoleSelectViewData);
		}

		// Token: 0x0603ACD0 RID: 240848 RVA: 0x00E029F4 File Offset: 0x00E00BF4
		private void OnSelectBack()
		{
			List<int> allBossRoleId = this.ActivityBaseData.GetAllBossRoleId(this.InstId);
			for (int i = 0; i < allBossRoleId.Count; i++)
			{
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(allBossRoleId[i], true);
				if ((roleDataById == null || !roleDataById.IsTrialRole()) && RoleModel.Instance.GetRoleInstanceById(allBossRoleId[i]) == null)
				{
					this.ActivityBaseData.SetBossRoleId(this.InstId, i, 0);
					Action refreshHandle = this.RefreshHandle;
					if (refreshHandle != null)
					{
						refreshHandle();
					}
				}
			}
		}

		// Token: 0x0603ACD1 RID: 240849 RVA: 0x00E02A7C File Offset: 0x00E00C7C
		private bool IsNeedRevive(int roleConfigId)
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleConfigId, true);
			return !((roleDataById != null) ? new bool?(roleDataById.IsTrialRole()) : null).GetValueOrDefault() && FormationModel.Instance.IsRoleDead(roleConfigId);
		}

		// Token: 0x0603ACD2 RID: 240850 RVA: 0x00E02AC8 File Offset: 0x00E00CC8
		private bool CanJoinTeam(int roleId)
		{
			if (roleId == this.RoleId)
			{
				return true;
			}
			IReadOnlyList<BattleLinkCharacter> source = DreamLinkConfig.Instance.GetRoleConfigList() ?? Array.Empty<BattleLinkCharacter>();
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			if (FormationModel.Instance.IsRoleDead(roleId) && (roleDataById == null || !roleDataById.IsTrialRole()))
			{
				return false;
			}
			if (!source.Any((BattleLinkCharacter roleConfig) => roleConfig.Id == roleId && roleConfig.IsShowInTeamView) && (roleDataById == null || !roleDataById.IsTrialRole()))
			{
				return false;
			}
			for (int i = 0; i < 3; i++)
			{
				int num = this.ActivityBaseData.GetAllBossRoleId(this.InstId)[i];
				RoleDataBase roleDataById2 = RoleModel.Instance.GetRoleDataById(num, true);
				if (roleDataById2 != null && roleDataById2.IsTrialRole())
				{
					TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(num);
					if (trialRoleConfig != null && trialRoleConfig.Value.ParentId == roleId)
					{
						return false;
					}
				}
				if (roleDataById != null && roleDataById.IsTrialRole())
				{
					TrialRoleInfo? trialRoleConfig2 = RoleConfig.Instance.GetTrialRoleConfig(roleId);
					if (trialRoleConfig2 != null && num == trialRoleConfig2.Value.ParentId)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0603ACD3 RID: 240851 RVA: 0x00E02C0D File Offset: 0x00E00E0D
		[NullableContext(2)]
		private string GetConfirmButtonTextFunction(int roleConfigId)
		{
			if (roleConfigId == 0)
			{
				return null;
			}
			if (this.RoleId == 0)
			{
				return "JoinText";
			}
			if (this.RoleId == roleConfigId)
			{
				return "GoDownText";
			}
			return "ChangeText";
		}

		// Token: 0x0603ACD4 RID: 240852 RVA: 0x00E02C36 File Offset: 0x00E00E36
		public void RefreshInstId(int instId)
		{
			this.InstId = instId;
			this.Refresh();
		}

		// Token: 0x0603ACD5 RID: 240853 RVA: 0x00E02C48 File Offset: 0x00E00E48
		public void Refresh()
		{
			int roleId = this.RoleId;
			bool flag = roleId == 0;
			base.GetTexture(1).SetUIActive(!flag);
			base.GetItem(3).SetUIActive(!flag);
			base.GetItem(2).SetUIActive(flag);
			if (flag)
			{
				return;
			}
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			if (roleDataById == null)
			{
				return;
			}
			if (roleDataById.IsTrialRole())
			{
				TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(roleId);
				if (trialRoleConfig == null)
				{
					return;
				}
				RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(trialRoleConfig.Value.ParentId);
				if (roleConfig == null)
				{
					return;
				}
				base.SetTextureByPath(roleConfig.Value.RoleHeadIcon, base.GetTexture(1), null, null);
				return;
			}
			else
			{
				RoleInfo? roleConfig2 = RoleConfig.Instance.GetRoleConfig(roleId);
				if (roleConfig2 == null)
				{
					return;
				}
				base.SetTextureByPath(roleConfig2.Value.RoleHeadIcon, base.GetTexture(1), null, null);
				return;
			}
		}

		// Token: 0x0401EB01 RID: 125697
		public int Index;

		// Token: 0x0401EB02 RID: 125698
		protected int InstId;

		// Token: 0x0401EB03 RID: 125699
		[Nullable(2)]
		public Action RefreshHandle;

		// Token: 0x0401EB04 RID: 125700
		[Nullable(1)]
		protected DreamLinkData ActivityBaseData;

		// Token: 0x0200BCF7 RID: 48375
		private class EItemDefine
		{
			// Token: 0x04038FDA RID: 233434
			public const int ButtonRole = 0;

			// Token: 0x04038FDB RID: 233435
			public const int TextureRole = 1;

			// Token: 0x04038FDC RID: 233436
			public const int PanelEmpty = 2;

			// Token: 0x04038FDD RID: 233437
			public const int PanelRole = 3;
		}
	}
}
