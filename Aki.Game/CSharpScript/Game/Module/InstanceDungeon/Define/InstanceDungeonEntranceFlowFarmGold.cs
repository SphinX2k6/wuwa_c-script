using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.FarmGold;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058D8 RID: 22744
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonEntranceFlowFarmGold : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x06039CAE RID: 236718 RVA: 0x00DBA743 File Offset: 0x00DB8943
		protected override void OnCreate()
		{
			base.AddStep(delegate
			{
				FarmGoldController.Instance.OpenDefaultFarmGoldView();
			});
			base.AddStep(delegate
			{
				List<ActivityBaseData> activitiesByType = ActivityModel.Instance.GetActivitiesByType(33);
				if (activitiesByType == null || activitiesByType.Count <= 0)
				{
					base.RevertStep();
					return;
				}
				FarmGoldData activityData = activitiesByType[0] as FarmGoldData;
				UiManager.Instance.OpenView(EUiViewName.MultiTeamRoleSelectView, this.GetSelectViewData(activityData), null);
			});
		}

		// Token: 0x06039CAF RID: 236719 RVA: 0x00DBA77C File Offset: 0x00DB897C
		private MultiTeamRoleSelectData GetSelectViewData(FarmGoldData activityData)
		{
			RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
			List<MultiTeamRoleGridData> list = new List<MultiTeamRoleGridData>();
			int instId = InstanceDungeonEntranceModel.Instance.InstanceId;
			int fightFormationId = InstanceDungeonConfig.Instance.GetConfig(instId).Value.FightFormationId;
			this.CurrentFightFormationId = fightFormationId;
			Aki.Config.FightFormation value = FormationConfig.Instance.GetFightFormationConfig(fightFormationId).Value;
			foreach (RoleInstance roleInstance in roleList)
			{
				if (roleInstance.GetRoleId() != 0)
				{
					MultiTeamRoleGridData item = MultiTeamRoleGridData.Phrase(roleInstance, false, value.RecommendFormationIter().Contains(roleInstance.GetRoleId()), false, false);
					list.Add(item);
				}
			}
			List<MultiTeamRoleGridData> list2 = new List<MultiTeamRoleGridData>();
			foreach (int id in value.TrialRoleIter())
			{
				TrialRoleInfo? trialRoleConfigByGroupId = RoleConfig.Instance.GetTrialRoleConfigByGroupId(id);
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(trialRoleConfigByGroupId.Value.Id, true);
				if (roleDataById != null)
				{
					list2.Add(MultiTeamRoleGridData.Phrase(roleDataById, false, false, false, false));
				}
			}
			MultiTeamRoleData item2 = MultiTeamRoleData.Phrase("BossRushNormalRole", list);
			List<MultiTeamRoleData> list3 = new List<MultiTeamRoleData>();
			if (list2.Count > 0)
			{
				MultiTeamRoleData item3 = MultiTeamRoleData.Phrase("BossRushTrailRole", list2);
				list3.Add(item3);
			}
			list3.Add(item2);
			ValueTuple<List<int>, List<int>> battleSelectRolesAndTags = activityData.GetBattleSelectRolesAndTags(instId);
			List<int> item4 = battleSelectRolesAndTags.Item1;
			List<int> item5 = battleSelectRolesAndTags.Item2;
			this.RemoveOutdatedMainRoleTrialIdsAndTags(item4, item5);
			Action<bool> <>9__4;
			MultiTeamRoleSelectData multiTeamRoleSelectData = MultiTeamRoleSelectData.Phrase(new EFilterSortGroupId?(EFilterSortGroupId.EditFormation), 3, item4.ToArray(), delegate
			{
				this.RevertStep();
				RoleModel.Instance.ClearGamePlayRoleEdit(ESkillBranchCacheType.FarmGold);
			}, delegate(int[] roleIds)
			{
				if (roleIds.Count((int x) => x > 0) == 0)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Text_NoRole_Text", Array.Empty<object>());
					return false;
				}
				return true;
			}, delegate(int[] roleIds, int[] tags)
			{
				List<int> list4 = roleIds.ToList<int>();
				activityData.SaveLevelBattleSelectRolesAndTags(instId, list4, tags);
				FarmGoldCtx farmGoldCtx = FarmGoldCtx.Create();
				for (int j = 0; j < roleIds.Length; j++)
				{
					if (roleIds[j] != 0)
					{
						farmGoldCtx.SkillBranchId.Add(tags[j]);
					}
				}
				InstanceDungeonModel.Instance.InstanceEnterContentText.FarmGoldCtx = farmGoldCtx;
				int currentSelectEntranceId = FarmGoldData.CurrentSelectEntranceId;
				UniTask<bool> task = InstanceDungeonController.Instance.PrewarTeamFightRequest(InstanceDungeonEntranceModel.Instance.InstanceId, list4, currentSelectEntranceId, 0, InstanceDungeonEntranceModel.Instance.TransitionOption, TowerDefenseModel.Instance.GetProtocolPhantomIdList(list4));
				Action<bool> continuationFunction;
				if ((continuationFunction = <>9__4) == null)
				{
					continuationFunction = (<>9__4 = delegate(bool result)
					{
						if (!result)
						{
							this.RevertStep();
						}
					});
				}
				task.ContinueWith(continuationFunction);
				RoleModel.Instance.ClearGamePlayRoleEdit(ESkillBranchCacheType.FarmGold);
			}, null, list3, null, "", "Activity_103300004_StartFight");
			BattleTeamModel.Instance.Context.SetInstanceDungeonId(new int?(instId));
			MultiTeamTagDataItem multiTeamTagData = MultiTeamTagDataItem.Phrase(item5.ToArray(), ESkillBranchCacheType.FarmGold);
			multiTeamRoleSelectData.SetMultiTeamTagData(multiTeamTagData);
			multiTeamRoleSelectData.RoleViewSource = ERoleViewSource.FarmGold;
			multiTeamRoleSelectData.IfCanSelectCheck = new Func<int, int[], bool>(this.IfCanSelectCheck);
			return multiTeamRoleSelectData;
		}

		// Token: 0x06039CB0 RID: 236720 RVA: 0x00DBA9DC File Offset: 0x00DB8BDC
		private bool IfCanSelectCheck(int roleConfigId, int[] selectedRoleList)
		{
			if (selectedRoleList.Contains(roleConfigId))
			{
				return true;
			}
			Aki.Config.FightFormation? fightFormationConfig = FormationConfig.Instance.GetFightFormationConfig(this.CurrentFightFormationId);
			if (fightFormationConfig == null)
			{
				return false;
			}
			int num = roleConfigId;
			foreach (int id in fightFormationConfig.Value.TrialRole())
			{
				TrialRoleInfo? trialRoleConfigByGroupId = RoleConfig.Instance.GetTrialRoleConfigByGroupId(id);
				if (trialRoleConfigByGroupId != null && trialRoleConfigByGroupId.Value.Id == roleConfigId)
				{
					num = trialRoleConfigByGroupId.Value.ParentId;
					break;
				}
			}
			if (num != roleConfigId && selectedRoleList.Contains(num))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("BossRushSameFormation", Array.Empty<object>());
				return false;
			}
			RoleModel instance = RoleModel.Instance;
			foreach (int num2 in selectedRoleList)
			{
				if (num2 > 0)
				{
					int num3 = num2;
					if (RoleUtils.IsTrialRole(num2))
					{
						num3 = RoleConfig.Instance.GetTrialRoleConfig(num2).Value.ParentId;
					}
					bool flag = instance.IsMainRole(num3) && instance.IsMainRole(num);
					if (num3 == num || flag)
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("BossRushSameFormation", Array.Empty<object>());
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06039CB1 RID: 236721 RVA: 0x00DBAB2C File Offset: 0x00DB8D2C
		public void RemoveOutdatedMainRoleTrialIdsAndTags(List<int> roleList, List<int> tags)
		{
			if (roleList.Count == 0 || tags.Count == 0 || tags.Count != roleList.Count)
			{
				return;
			}
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			RoleModel instance = RoleModel.Instance;
			for (int i = 0; i < roleList.Count; i++)
			{
				int num = roleList[i];
				if (num > 0)
				{
					if (instance.IsMainRole(num) && instance.GetRoleInstanceById(num) == null)
					{
						roleList[i] = 0;
						tags[i] = 0;
					}
					else if (RoleUtils.IsTrialRole(num))
					{
						TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(num);
						if (trialRoleConfig != null)
						{
							int parentId = trialRoleConfig.Value.ParentId;
							if (instance.IsMainRole(parentId) && trialRoleConfig.Value.Gender != (int)playerGender)
							{
								roleList[i] = 0;
								tags[i] = 0;
							}
						}
					}
				}
			}
		}

		// Token: 0x0401E2C6 RID: 123590
		private int CurrentFightFormationId;
	}
}
