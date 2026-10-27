using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x02006902 RID: 26882
	[NullableContext(1)]
	[Nullable(0)]
	internal class TeamItem : UiPanelBase
	{
		// Token: 0x06043099 RID: 274585 RVA: 0x01054BA0 File Offset: 0x01052DA0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton))
			};
		}

		// Token: 0x0604309A RID: 274586 RVA: 0x01054C75 File Offset: 0x01052E75
		private void OnClickButton()
		{
			UiManager.Instance.OpenView(EUiViewName.MultiTeamRoleSelectView, this.GetSelectViewData(), null);
		}

		// Token: 0x0604309B RID: 274587 RVA: 0x01054C90 File Offset: 0x01052E90
		private MultiTeamRoleSelectData GetSelectViewData()
		{
			RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
			List<MultiTeamRoleGridData> list = new List<MultiTeamRoleGridData>();
			foreach (RoleInstance roleInstance in roleList)
			{
				if (roleInstance.GetRoleId() != 0)
				{
					MultiTeamRoleGridData item = MultiTeamRoleGridData.Phrase(roleInstance, false, false, false, false);
					list.Add(item);
				}
			}
			List<MultiTeamRoleGridData> list2 = new List<MultiTeamRoleGridData>();
			if (this.CurrentTeamData == null || this.CurrentTeamData.LevelInfo == null)
			{
				return this.CreateMultiTeamRoleSelectData(new List<MultiTeamRoleData>(), list);
			}
			int fightFormationId = this.CurrentTeamData.LevelInfo.GetInstanceDungeonConfig().Value.FightFormationId;
			FightFormation? fightFormationConfig = FormationConfig.Instance.GetFightFormationConfig(fightFormationId);
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
							list2.Add(MultiTeamRoleGridData.Phrase(roleDataById, false, false, false, false));
						}
					}
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
			MultiTeamRoleSelectData multiTeamRoleSelectData = MultiTeamRoleSelectData.Phrase(new EFilterSortGroupId?(EFilterSortGroupId.EditFormation), 3, this.CurrentTeamData.GetCurrentTeamMembers(), null, null, delegate(int[] idList, int[] tagList)
			{
				for (int j = 0; j < idList.Length; j++)
				{
					int roleId = idList[j];
					this.CurrentTeamData.SetIndexTeamMembers(j, roleId);
				}
				this.CurrentTeamData.ReSortTeamMembers();
				this.Refresh(this.CurrentTeamData);
				Action onChangeRoleCallBack = this.OnChangeRoleCallBack;
				if (onChangeRoleCallBack == null)
				{
					return;
				}
				onChangeRoleCallBack();
			}, null, list3, null, "", "");
			multiTeamRoleSelectData.IfCanSelectCheck = new Func<int, int[], bool>(this.IfCanSelectCheck);
			return multiTeamRoleSelectData;
		}

		// Token: 0x0604309C RID: 274588 RVA: 0x01054E40 File Offset: 0x01053040
		private MultiTeamRoleSelectData CreateMultiTeamRoleSelectData(List<MultiTeamRoleData> teamRoleDataList, List<MultiTeamRoleGridData> currentRoleTeamRoleGridData)
		{
			MultiTeamRoleData item = MultiTeamRoleData.Phrase("BossRushNormalRole", currentRoleTeamRoleGridData);
			teamRoleDataList.Add(item);
			EFilterSortGroupId? useWay = new EFilterSortGroupId?(EFilterSortGroupId.EditFormation);
			int teamLength = 3;
			BossRushTeamInfo currentTeamData = this.CurrentTeamData;
			return MultiTeamRoleSelectData.Phrase(useWay, teamLength, ((currentTeamData != null) ? currentTeamData.GetCurrentTeamMembers() : null) ?? new int[0], null, null, delegate(int[] idList, int[] tagList)
			{
				if (this.CurrentTeamData != null)
				{
					for (int i = 0; i < idList.Length; i++)
					{
						int roleId = idList[i];
						this.CurrentTeamData.SetIndexTeamMembers(i, roleId);
					}
					this.CurrentTeamData.ReSortTeamMembers();
					this.Refresh(this.CurrentTeamData);
					Action onChangeRoleCallBack = this.OnChangeRoleCallBack;
					if (onChangeRoleCallBack == null)
					{
						return;
					}
					onChangeRoleCallBack();
				}
			}, null, teamRoleDataList, null, "", "");
		}

		// Token: 0x0604309D RID: 274589 RVA: 0x01054EA3 File Offset: 0x010530A3
		public void BindOnSelectRoleCall(Action callBack)
		{
			this.OnChangeRoleCallBack = callBack;
		}

		// Token: 0x0604309E RID: 274590 RVA: 0x01054EAC File Offset: 0x010530AC
		private bool IfCanSelectCheck(int roleConfigId, int[] selectedRoleList)
		{
			if (selectedRoleList.Contains(roleConfigId))
			{
				return true;
			}
			if (this.CurrentTeamData == null || this.CurrentTeamData.LevelInfo == null)
			{
				return false;
			}
			int fightFormationId = this.CurrentTeamData.LevelInfo.GetInstanceDungeonConfig().Value.FightFormationId;
			FightFormation? fightFormationConfig = FormationConfig.Instance.GetFightFormationConfig(fightFormationId);
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
			foreach (int num2 in selectedRoleList)
			{
				int num3 = num2;
				TrialRoleInfo? trialRoleConfigByGroupId2 = RoleConfig.Instance.GetTrialRoleConfigByGroupId(num2);
				if (trialRoleConfigByGroupId2 != null)
				{
					num3 = trialRoleConfigByGroupId2.Value.ParentId;
				}
				if (num3 == num)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("BossRushSameFormation", Array.Empty<object>());
					return false;
				}
			}
			return true;
		}

		// Token: 0x0604309F RID: 274591 RVA: 0x01055008 File Offset: 0x01053208
		protected override UniTask OnBeforeStartAsync()
		{
			TeamItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TeamItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060430A0 RID: 274592 RVA: 0x0105504B File Offset: 0x0105324B
		private BossRushTeamRoleItem CreateTeamRoleItem()
		{
			return new BossRushTeamRoleItem();
		}

		// Token: 0x060430A1 RID: 274593 RVA: 0x01055052 File Offset: 0x01053252
		public void Refresh(BossRushTeamInfo data)
		{
			this.CurrentTeamData = data;
			this.RefreshRecommendLevelText(data);
			this.RefreshElementItem(data);
			this.RefreshTeamRole(data);
			this.RefreshRecommendElementText(data);
		}

		// Token: 0x060430A2 RID: 274594 RVA: 0x01055078 File Offset: 0x01053278
		private void RefreshRecommendElementText(BossRushTeamInfo data)
		{
			if (data == null || data.GetCurrentSelectLevel() == null)
			{
				return;
			}
			string textStringId = (data.GetCurrentSelectLevel().GetRecommendElementIdArray().Length != 0) ? "BossRushRecommendElement" : "BossRushRecommendElementNone";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textStringId, Array.Empty<object>());
		}

		// Token: 0x060430A3 RID: 274595 RVA: 0x010550C4 File Offset: 0x010532C4
		private void RefreshRecommendLevelText(BossRushTeamInfo data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BossRushRecommendLevel", new <>z__ReadOnlySingleElementList<object>(data.GetRecommendLevel().ToString()));
		}

		// Token: 0x060430A4 RID: 274596 RVA: 0x010550FC File Offset: 0x010532FC
		private void RefreshElementItem(BossRushTeamInfo data)
		{
			foreach (CommonElementItem commonElementItem in this.ElementItemArray)
			{
				commonElementItem.SetActive(false);
			}
			if (data == null || data.GetCurrentSelectLevel() == null)
			{
				return;
			}
			int[] recommendElementIdArray = data.GetCurrentSelectLevel().GetRecommendElementIdArray();
			for (int i = 0; i < recommendElementIdArray.Length; i++)
			{
				if (recommendElementIdArray[i] != 0 && i < this.ElementItemArray.Count)
				{
					this.ElementItemArray[i].SetActive(true);
					this.ElementItemArray[i].Refresh(recommendElementIdArray[i], false, i);
				}
			}
		}

		// Token: 0x060430A5 RID: 274597 RVA: 0x010551B0 File Offset: 0x010533B0
		private void OnSelectTeamRole()
		{
			Action onChangeRoleCallBack = this.OnChangeRoleCallBack;
			if (onChangeRoleCallBack == null)
			{
				return;
			}
			onChangeRoleCallBack();
		}

		// Token: 0x060430A6 RID: 274598 RVA: 0x010551C4 File Offset: 0x010533C4
		public void RefreshTeamRole(BossRushTeamInfo data)
		{
			if (data == null || this.TeamLayout == null)
			{
				return;
			}
			int[] currentTeamMembers = data.GetCurrentTeamMembers();
			int num = 3;
			List<BossRushTeamData> list = new List<BossRushTeamData>();
			foreach (int roleId in currentTeamMembers)
			{
				list.Add(new BossRushTeamData
				{
					RoleId = roleId,
					TeamInfo = data,
					OnSelectRole = new Action(this.OnSelectTeamRole)
				});
			}
			while (list.Count < num)
			{
				list.Add(new BossRushTeamData
				{
					RoleId = 0,
					TeamInfo = data,
					OnSelectRole = new Action(this.OnSelectTeamRole)
				});
			}
			this.TeamLayout.RefreshByData(list, null, false);
		}

		// Token: 0x04022E60 RID: 142944
		[Nullable(2)]
		private CommonElementItem ElementItem1;

		// Token: 0x04022E61 RID: 142945
		[Nullable(2)]
		private CommonElementItem ElementItem2;

		// Token: 0x04022E62 RID: 142946
		private readonly List<CommonElementItem> ElementItemArray = new List<CommonElementItem>();

		// Token: 0x04022E63 RID: 142947
		[Nullable(2)]
		private Action OnChangeRoleCallBack;

		// Token: 0x04022E64 RID: 142948
		[Nullable(2)]
		protected BossRushTeamInfo CurrentTeamData;

		// Token: 0x04022E65 RID: 142949
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<BossRushTeamRoleItem, BossRushTeamData> TeamLayout;
	}
}
