using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A75 RID: 23157
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeSelectRoleView : UiViewBase
	{
		// Token: 0x17008BFC RID: 35836
		// (get) Token: 0x0603AAB9 RID: 240313 RVA: 0x00DF882A File Offset: 0x00DF6A2A
		[Nullable(2)]
		public new FlagChallengeSelectRoleViewParams OpenParam
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as FlagChallengeSelectRoleViewParams;
			}
		}

		// Token: 0x0603AABA RID: 240314 RVA: 0x00DF8837 File Offset: 0x00DF6A37
		public FlagChallengeSelectRoleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603AABB RID: 240315 RVA: 0x00DF884C File Offset: 0x00DF6A4C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIText)),
				new ValueTuple<int, Type>(11, typeof(UUIArtText)),
				new ValueTuple<int, Type>(12, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action(this.OnConfirmBtnClick)),
				new ValueTuple<int, Delegate>(6, new Action(this.OnDetailBtnClick))
			};
		}

		// Token: 0x0603AABC RID: 240316 RVA: 0x00DF89F0 File Offset: 0x00DF6BF0
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeSelectRoleView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeSelectRoleView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AABD RID: 240317 RVA: 0x00DF8A34 File Offset: 0x00DF6C34
		protected override void OnStart()
		{
			this.PopupCaption = new PopupCaptionItem(base.GetItem(0));
			this.PopupCaption.SetCloseCallBack(new Action(this.OnCloseClick));
			FlagChallengeConfig.Instance.GetFormationHelpId();
			this.PopupCaption.SetHelpBtnActive(true);
			this.PopupCaption.SetHelpCallBack(new Action(this.OnHelpClick));
			this.RoleLayout = new GenericLayout<FlagChallengeFormationRoleItem, IFlagChallengeFormationRoleItemData>(base.GetHorizontalLayout(12), new Func<FlagChallengeFormationRoleItem>(this.CreateFormationRoleItem), null, false, true);
			this.RefreshFormationRoles();
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
			AUIBaseActor gridActor = base.GetItem(3).GetOwner() as AUIBaseActor;
			this.RoleCategoryScroll = new GenericScrollViewNew<FlagChallengeRoleCategoryItem, FlagChallengeRoleCategoryItemData>(scrollViewWithScrollbar, new Func<FlagChallengeRoleCategoryItem>(this.CreateRoleCategoryItem), gridActor, false, null);
			this.RefreshScrollView(this.RoleDataList);
			UUIItem item = base.GetItem(4);
			this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(item, new TUpdateDataListFunction<RoleDataBase>(this.UpdateRoleList));
			this.FilterSortEntrance.UpdateData(EFilterSortGroupId.EditFormation, this.RoleDataList, Array.Empty<object>());
			int fixedLevel = FlagChallengeModel.Instance.GetFixedLevel(this.ActivityId);
			base.GetArtText(11).SetText(fixedLevel.ToString());
			FlagChallengeLevel? levelConfig = FlagChallengeConfig.Instance.GetLevelConfig(this.LevelId);
			base.GetText(7).ShowTextNew(levelConfig.Value.Name);
			FlagStronghold? strongholdConfig = FlagChallengeConfig.Instance.GetStrongholdConfig(this.StrongholdId);
			base.GetText(8).ShowTextNew(strongholdConfig.Value.Name);
			base.GetText(10).ShowTextNew(strongholdConfig.Value.MonsterDesc);
			FlagChallengeStrongholdData strongholdData = FlagChallengeModel.Instance.GetFlagChallengeData(this.ActivityId).GetStrongholdData(this.StrongholdId);
			int totalLevel = FlagChallengeModel.Instance.GetTotalLevel(this.ActivityId);
			base.GetItem(14).SetUIActive(!strongholdData.IsPass && totalLevel < strongholdConfig.Value.RecommendLevel);
		}

		// Token: 0x0603AABE RID: 240318 RVA: 0x00DF8C34 File Offset: 0x00DF6E34
		protected override void OnBeforeDestroy()
		{
			List<int> formationRoleIdList = this.GetFormationRoleIdList();
			FlagChallengeModel.Instance.SaveFormationInfo(this.ActivityId, new HashSet<int>(formationRoleIdList));
			RoleSelectModel.Instance.ClearData();
		}

		// Token: 0x0603AABF RID: 240319 RVA: 0x00DF8C68 File Offset: 0x00DF6E68
		private void InitViewData()
		{
			FlagChallengeSelectRoleViewParams openParam = this.OpenParam;
			this.ActivityId = openParam.ActivityId;
			this.LevelId = openParam.LevelId;
			this.StrongholdId = openParam.StrongholdId;
			this.RoleDataList = RoleModel.Instance.GetRoleDataList(false);
			this.RoleDataList.Sort((RoleDataBase a, RoleDataBase b) => b.GetRoleConfig().Priority - a.GetRoleConfig().Priority);
			List<RoleDataBase> trialRoleDataList = this.GetTrialRoleDataList();
			HashSet<int> formationInfo = FlagChallengeModel.Instance.GetFlagChallengeData(this.ActivityId).GetFormationInfo();
			List<int> list = new List<int>();
			foreach (int num in formationInfo)
			{
				RoleDataBase roleDataBase = null;
				foreach (RoleDataBase roleDataBase2 in this.RoleDataList)
				{
					if (roleDataBase2.GetRoleId() == num)
					{
						roleDataBase = roleDataBase2;
						break;
					}
				}
				RoleDataBase roleDataBase3 = null;
				foreach (RoleDataBase roleDataBase4 in trialRoleDataList)
				{
					if (roleDataBase4.GetRoleId() == num)
					{
						roleDataBase3 = roleDataBase4;
						break;
					}
				}
				if (roleDataBase3 == null)
				{
					if (roleDataBase == null)
					{
						list.Add(num);
					}
				}
				else if (!RoleModel.Instance.IsRoleOwned(num))
				{
					list.Add(num);
				}
			}
			foreach (int item in list)
			{
				formationInfo.Remove(item);
			}
			RoleSelectModel.Instance.ClearData();
			int num2 = 1;
			foreach (int num3 in formationInfo)
			{
				RoleSelectModel.Instance.SelectedRoleSet.Add(num3);
				RoleSelectModel.Instance.RoleIndexMap.Add(num2, RoleModel.Instance.GetRoleDataById(num3, true));
				num2++;
			}
		}

		// Token: 0x0603AAC0 RID: 240320 RVA: 0x00DF8EC4 File Offset: 0x00DF70C4
		private void RefreshScrollView(List<RoleDataBase> ownRoleList)
		{
			List<FlagChallengeRoleCategoryItemData> list = new List<FlagChallengeRoleCategoryItemData>();
			List<RoleDataBase> trialRoleList = this.GetTrialRoleDataList();
			if (trialRoleList.Count > 0)
			{
				list.Add(new FlagChallengeRoleCategoryItemData
				{
					CategoryType = EFlagChallengeRoleCategoryType.TrialRole,
					TitleKey = "Morale_32_Role_TempRole_Title",
					RoleList = trialRoleList,
					CanSelectRole = new Func<int, EToggleState, bool>(this.CanSelectRole),
					OnSelectRole = new Action<int, EToggleState>(this.OnSelectRole)
				});
			}
			list.Add(new FlagChallengeRoleCategoryItemData
			{
				CategoryType = EFlagChallengeRoleCategoryType.Role,
				TitleKey = "Morale_32_Role_MyRole_Title",
				RoleList = ownRoleList,
				CanSelectRole = new Func<int, EToggleState, bool>(this.CanSelectRole),
				OnSelectRole = new Action<int, EToggleState>(this.OnSelectRole)
			});
			this.RoleCategoryScroll.RefreshByData(list, delegate
			{
				EFlagChallengeRoleCategoryType eflagChallengeRoleCategoryType = (trialRoleList.Count > 0) ? EFlagChallengeRoleCategoryType.TrialRole : EFlagChallengeRoleCategoryType.Role;
				UUIItem itemByKey = this.RoleCategoryScroll.GetItemByKey((int)eflagChallengeRoleCategoryType);
				if (itemByKey != null)
				{
					this.RoleCategoryScroll.ScrollTo(itemByKey, false);
				}
			}, false);
		}

		// Token: 0x0603AAC1 RID: 240321 RVA: 0x00DF8FB0 File Offset: 0x00DF71B0
		private List<RoleDataBase> GetTrialRoleDataList()
		{
			List<RoleDataBase> list = new List<RoleDataBase>();
			List<int> trialRoleIdList = this.GetTrialRoleIdList();
			if (trialRoleIdList != null)
			{
				foreach (int id in trialRoleIdList)
				{
					RoleConfig instance = RoleConfig.Instance;
					TrialRoleInfo? trialRoleInfo = (instance != null) ? instance.GetTrialRoleConfigByGroupId(id) : null;
					RoleModel instance2 = RoleModel.Instance;
					RoleDataBase roleDataBase = (instance2 != null) ? instance2.GetRoleDataById(trialRoleInfo.Value.Id, true) : null;
					if (roleDataBase != null)
					{
						list.Add(roleDataBase);
					}
				}
			}
			return list;
		}

		// Token: 0x0603AAC2 RID: 240322 RVA: 0x00DF9058 File Offset: 0x00DF7258
		private List<int> GetTrialRoleIdList()
		{
			int instId = FlagChallengeConfig.Instance.GetLevelConfig(this.LevelId).Value.InstId;
			InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
			InstanceDungeon? instanceDungeon = (instance != null) ? instance.GetConfig(instId) : null;
			if (instanceDungeon == null)
			{
				return new List<int>();
			}
			FormationConfig instance2 = FormationConfig.Instance;
			FightFormation? fightFormation = (instance2 != null) ? instance2.GetFightFormationConfig(instanceDungeon.Value.FightFormationId) : null;
			if (fightFormation == null)
			{
				return new List<int>();
			}
			return fightFormation.Value.TrialRoleIter().ToList<int>();
		}

		// Token: 0x0603AAC3 RID: 240323 RVA: 0x00DF9104 File Offset: 0x00DF7304
		private void RefreshFormationRoles()
		{
			RoleSelectModel instance = RoleSelectModel.Instance;
			List<IFlagChallengeFormationRoleItemData> list = new List<IFlagChallengeFormationRoleItemData>();
			for (int i = 1; i <= 3; i++)
			{
				RoleDataBase roleData;
				instance.RoleIndexMap.TryGetValue(i, out roleData);
				FlagChallengeFormationRoleItemData item = new FlagChallengeFormationRoleItemData
				{
					Index = i,
					RoleData = roleData
				};
				list.Add(item);
			}
			this.RoleLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0603AAC4 RID: 240324 RVA: 0x00DF9164 File Offset: 0x00DF7364
		private List<int> GetFormationRoleIdList()
		{
			List<int> list = new List<int>();
			for (int i = 1; i <= 3; i++)
			{
				RoleDataBase roleDataBase;
				if (RoleSelectModel.Instance.RoleIndexMap.TryGetValue(i, out roleDataBase) && roleDataBase != null)
				{
					list.Add(roleDataBase.GetRoleId());
				}
			}
			return list;
		}

		// Token: 0x0603AAC5 RID: 240325 RVA: 0x00DF91A8 File Offset: 0x00DF73A8
		private void UpdateRoleList(List<RoleDataBase> list, bool isShowText, EFilterSortType _)
		{
			Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
			List<RoleDataBase> list2 = new List<RoleDataBase>();
			for (int i = 1; i <= 3; i++)
			{
				RoleDataBase roleDataBase;
				if (roleIndexMap.TryGetValue(i, out roleDataBase) && !roleDataBase.IsTrialRole())
				{
					list2.Add(roleDataBase);
				}
			}
			foreach (RoleDataBase item in list)
			{
				if (!list2.Contains(item))
				{
					list2.Add(item);
				}
			}
			this.RefreshScrollView(list2);
		}

		// Token: 0x0603AAC6 RID: 240326 RVA: 0x00DF9244 File Offset: 0x00DF7444
		private FlagChallengeRoleCategoryItem CreateRoleCategoryItem()
		{
			return new FlagChallengeRoleCategoryItem();
		}

		// Token: 0x0603AAC7 RID: 240327 RVA: 0x00DF924B File Offset: 0x00DF744B
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603AAC8 RID: 240328 RVA: 0x00DF9254 File Offset: 0x00DF7454
		private void OnHelpClick()
		{
			int formationHelpId = FlagChallengeConfig.Instance.GetFormationHelpId();
			HelpController.Instance.OpenHelpById(formationHelpId);
		}

		// Token: 0x0603AAC9 RID: 240329 RVA: 0x00DF9278 File Offset: 0x00DF7478
		private void OnConfirmBtnClick()
		{
			List<int> ids = this.GetFormationRoleIdList();
			if (ids.Count == 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("AtLeastOnePlayer", Array.Empty<object>());
				return;
			}
			FlagChallengeLevel? levelConfig = FlagChallengeConfig.Instance.GetLevelConfig(this.LevelId);
			if (ids.Count < 3)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FlagChallengeFormationNotFullConfirm);
				confirmBoxDataNew.FunctionMap.Add(2, delegate
				{
					FlagChallengeController.Instance.RequestChallenge(levelConfig.Value.InstId, this.StrongholdId, ids);
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			FlagChallengeController.Instance.RequestChallenge(levelConfig.Value.InstId, this.StrongholdId, ids);
		}

		// Token: 0x0603AACA RID: 240330 RVA: 0x00DF9340 File Offset: 0x00DF7540
		private void OnDetailBtnClick()
		{
			IEnumerable<int> trialRoleIdList = this.GetTrialRoleIdList();
			List<int> roleIdList = RoleModel.Instance.GetRoleIdList();
			List<int> list = new List<int>(trialRoleIdList);
			list.AddRange(roleIdList);
			HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
			List<int> list2 = new List<int>();
			foreach (int item in list)
			{
				if (!selectedRoleSet.Contains(item))
				{
					list2.Add(item);
				}
			}
			List<int> list3 = new List<int>(this.GetFormationRoleIdList());
			list3.AddRange(list2);
			RoleController.Instance.OpenRoleMainViewByParam(new OpenRoleMainViewData
			{
				AgentType = ERoleAgentType.Normal,
				RoleIdList = list3,
				TeamPositionType = new ETeamPositionType?(ETeamPositionType.RoleSelect)
			});
		}

		// Token: 0x0603AACB RID: 240331 RVA: 0x00DF9404 File Offset: 0x00DF7604
		private bool CanSelectRole(int roleId, EToggleState state)
		{
			if (state != EToggleState.ETT_UnChecked)
			{
				return true;
			}
			if (RoleSelectModel.Instance.SelectedRoleSet.Count >= 3)
			{
				ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamRoleFull", Array.Empty<object>());
				return false;
			}
			if (RoleUtils.HasSameRole(roleId, RoleSelectModel.Instance.SelectedRoleSet.ToArray<int>(), null))
			{
				ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamSameRole", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x0603AACC RID: 240332 RVA: 0x00DF9478 File Offset: 0x00DF7678
		private void OnSelectRole(int roleId, EToggleState state)
		{
			RoleSelectModel instance = RoleSelectModel.Instance;
			if (state == EToggleState.ETT_Checked)
			{
				instance.SelectedRoleSet.Add(roleId);
				for (int i = 1; i <= 3; i++)
				{
					if (!instance.RoleIndexMap.ContainsKey(i))
					{
						RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
						instance.RoleIndexMap.Add(i, roleDataById);
						break;
					}
				}
			}
			else
			{
				instance.SelectedRoleSet.Remove(roleId);
				foreach (KeyValuePair<int, RoleDataBase> keyValuePair in instance.RoleIndexMap)
				{
					if (keyValuePair.Value.GetDataId() == roleId)
					{
						instance.RoleIndexMap.Remove(keyValuePair.Key);
						break;
					}
				}
			}
			this.RefreshFormationRoles();
		}

		// Token: 0x0603AACD RID: 240333 RVA: 0x00DF954C File Offset: 0x00DF774C
		private FlagChallengeFormationRoleItem CreateFormationRoleItem()
		{
			FlagChallengeFormationRoleItem flagChallengeFormationRoleItem = new FlagChallengeFormationRoleItem();
			flagChallengeFormationRoleItem.SetClickCallback(new Action<int>(this.OnClickFormationRoleItem));
			return flagChallengeFormationRoleItem;
		}

		// Token: 0x0603AACE RID: 240334 RVA: 0x00DF9565 File Offset: 0x00DF7765
		private void OnClickFormationRoleItem(int roleId)
		{
			if (!RoleSelectModel.Instance.SelectedRoleSet.Contains(roleId))
			{
				return;
			}
			this.OnSelectRole(roleId, EToggleState.ETT_UnChecked);
			EventSystem.Instance.Emit<int>(EEventName.OnFlagChallengeRoleSelectCategoryUpdate, roleId);
		}

		// Token: 0x0401E9DB RID: 125403
		private int ActivityId;

		// Token: 0x0401E9DC RID: 125404
		private int LevelId;

		// Token: 0x0401E9DD RID: 125405
		private int StrongholdId;

		// Token: 0x0401E9DE RID: 125406
		private PopupCaptionItem PopupCaption;

		// Token: 0x0401E9DF RID: 125407
		private GenericScrollViewNew<FlagChallengeRoleCategoryItem, FlagChallengeRoleCategoryItemData> RoleCategoryScroll;

		// Token: 0x0401E9E0 RID: 125408
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

		// Token: 0x0401E9E1 RID: 125409
		private FlagChallengeStrongholdPanel StrongholdPanel;

		// Token: 0x0401E9E2 RID: 125410
		private List<RoleDataBase> RoleDataList = new List<RoleDataBase>();

		// Token: 0x0401E9E3 RID: 125411
		private GenericLayout<FlagChallengeFormationRoleItem, IFlagChallengeFormationRoleItemData> RoleLayout;
	}
}
