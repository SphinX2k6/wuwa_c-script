using System;
using System.Collections.Generic;
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
	// Token: 0x02005852 RID: 22610
	[NullableContext(1)]
	[Nullable(0)]
	internal class TeamItem : UiPanelBase
	{
		// Token: 0x06037BF1 RID: 228337 RVA: 0x00F961C8 File Offset: 0x00F943C8
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

		// Token: 0x06037BF2 RID: 228338 RVA: 0x00F9629D File Offset: 0x00F9449D
		private void OnClickButton()
		{
			UiManager.Instance.OpenView(EUiViewName.MultiTeamRoleSelectView, this.GetSelectViewData(), null);
		}

		// Token: 0x06037BF3 RID: 228339 RVA: 0x00F962B8 File Offset: 0x00F944B8
		private MultiTeamRoleSelectData GetSelectViewData()
		{
			RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
			List<MultiTeamRoleGridData> list = new List<MultiTeamRoleGridData>();
			foreach (RoleInstance roleInstance in roleList)
			{
				if (roleInstance.GetRoleId() != 0)
				{
					MultiTeamRoleGridData item = MultiTeamRoleGridData.Phrase(roleInstance, false, false, false, false, null, false, false, false);
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
							list2.Add(MultiTeamRoleGridData.Phrase(roleDataById, false, false, false, false, null, false, false, false));
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

		// Token: 0x06037BF4 RID: 228340 RVA: 0x00F96470 File Offset: 0x00F94670
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

		// Token: 0x06037BF5 RID: 228341 RVA: 0x00F964D3 File Offset: 0x00F946D3
		public void BindOnSelectRoleCall(Action callBack)
		{
			this.OnChangeRoleCallBack = callBack;
		}

		// Token: 0x06037BF6 RID: 228342 RVA: 0x00F964DC File Offset: 0x00F946DC
		private bool IfCanSelectCheck(int roleConfigId, int[] selectedRoleList)
		{
			if (Array.IndexOf<int>(selectedRoleList, roleConfigId) >= 0)
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
			if (num != roleConfigId && Array.IndexOf<int>(selectedRoleList, num) >= 0)
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

		// Token: 0x06037BF7 RID: 228343 RVA: 0x00F9663C File Offset: 0x00F9483C
		protected override UniTask OnBeforeStartAsync()
		{
			TeamItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TeamItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037BF8 RID: 228344 RVA: 0x00F9667F File Offset: 0x00F9487F
		private BossRushTeamRoleItem CreateTeamRoleItem()
		{
			return new BossRushTeamRoleItem();
		}

		// Token: 0x06037BF9 RID: 228345 RVA: 0x00F96686 File Offset: 0x00F94886
		public void Refresh(BossRushTeamInfo data)
		{
			this.CurrentTeamData = data;
			this.RefreshRecommendLevelText(data);
			this.RefreshElementItem(data);
			this.RefreshTeamRole(data);
			this.RefreshRecommendElementText(data);
		}

		// Token: 0x06037BFA RID: 228346 RVA: 0x00F966AC File Offset: 0x00F948AC
		private void RefreshRecommendElementText(BossRushTeamInfo data)
		{
			if (data == null || data.GetCurrentSelectLevel() == null)
			{
				return;
			}
			string textStringId = (data.GetCurrentSelectLevel().GetRecommendElementIdArray().Length != 0) ? "BossRushRecommendElement" : "BossRushRecommendElementNone";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textStringId, Array.Empty<object>());
		}

		// Token: 0x06037BFB RID: 228347 RVA: 0x00F966F8 File Offset: 0x00F948F8
		private void RefreshRecommendLevelText(BossRushTeamInfo data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BossRushRecommendLevel", new <>z__ReadOnlySingleElementList<object>(data.GetRecommendLevel().ToString()));
		}

		// Token: 0x06037BFC RID: 228348 RVA: 0x00F96730 File Offset: 0x00F94930
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

		// Token: 0x06037BFD RID: 228349 RVA: 0x00F967E4 File Offset: 0x00F949E4
		private void OnSelectTeamRole()
		{
			Action onChangeRoleCallBack = this.OnChangeRoleCallBack;
			if (onChangeRoleCallBack == null)
			{
				return;
			}
			onChangeRoleCallBack();
		}

		// Token: 0x06037BFE RID: 228350 RVA: 0x00F967F8 File Offset: 0x00F949F8
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

		// Token: 0x0401D6BC RID: 120508
		[Nullable(2)]
		private CommonElementItem ElementItem1;

		// Token: 0x0401D6BD RID: 120509
		[Nullable(2)]
		private CommonElementItem ElementItem2;

		// Token: 0x0401D6BE RID: 120510
		private readonly List<CommonElementItem> ElementItemArray = new List<CommonElementItem>();

		// Token: 0x0401D6BF RID: 120511
		[Nullable(2)]
		private Action OnChangeRoleCallBack;

		// Token: 0x0401D6C0 RID: 120512
		[Nullable(2)]
		protected BossRushTeamInfo CurrentTeamData;

		// Token: 0x0401D6C1 RID: 120513
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<BossRushTeamRoleItem, BossRushTeamData> TeamLayout;
	}
}
