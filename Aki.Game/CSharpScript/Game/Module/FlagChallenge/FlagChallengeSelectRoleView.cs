using System;
using System.Collections.Generic;
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
	// Token: 0x02004A51 RID: 19025
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeSelectRoleView : UiViewBase
	{
		// Token: 0x17005FCA RID: 24522
		// (get) Token: 0x0602FA02 RID: 195074 RVA: 0x00D48DAE File Offset: 0x00D46FAE
		[Nullable(2)]
		public new FlagChallengeSelectRoleViewParams OpenParam
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as FlagChallengeSelectRoleViewParams;
			}
		}

		// Token: 0x0602FA03 RID: 195075 RVA: 0x00D48DBB File Offset: 0x00D46FBB
		public FlagChallengeSelectRoleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602FA04 RID: 195076 RVA: 0x00D48DD0 File Offset: 0x00D46FD0
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

		// Token: 0x0602FA05 RID: 195077 RVA: 0x00D48F74 File Offset: 0x00D47174
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeSelectRoleView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeSelectRoleView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FA06 RID: 195078 RVA: 0x00D48FB8 File Offset: 0x00D471B8
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

		// Token: 0x0602FA07 RID: 195079 RVA: 0x00D491B8 File Offset: 0x00D473B8
		protected override void OnBeforeDestroy()
		{
			List<int> formationRoleIdList = this.GetFormationRoleIdList();
			FlagChallengeModel.Instance.SaveFormationInfo(this.ActivityId, new HashSet<int>(formationRoleIdList));
			RoleSelectModel.Instance.ClearData();
		}

		// Token: 0x0602FA08 RID: 195080 RVA: 0x00D491EC File Offset: 0x00D473EC
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

		// Token: 0x0602FA09 RID: 195081 RVA: 0x00D49448 File Offset: 0x00D47648
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

		// Token: 0x0602FA0A RID: 195082 RVA: 0x00D49534 File Offset: 0x00D47734
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

		// Token: 0x0602FA0B RID: 195083 RVA: 0x00D495DC File Offset: 0x00D477DC
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
			return new List<int>(fightFormation.Value.TrialRoleIter());
		}

		// Token: 0x0602FA0C RID: 195084 RVA: 0x00D49688 File Offset: 0x00D47888
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

		// Token: 0x0602FA0D RID: 195085 RVA: 0x00D496E8 File Offset: 0x00D478E8
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

		// Token: 0x0602FA0E RID: 195086 RVA: 0x00D4972C File Offset: 0x00D4792C
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

		// Token: 0x0602FA0F RID: 195087 RVA: 0x00D497C8 File Offset: 0x00D479C8
		private FlagChallengeRoleCategoryItem CreateRoleCategoryItem()
		{
			return new FlagChallengeRoleCategoryItem();
		}

		// Token: 0x0602FA10 RID: 195088 RVA: 0x00D497CF File Offset: 0x00D479CF
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602FA11 RID: 195089 RVA: 0x00D497D8 File Offset: 0x00D479D8
		private void OnHelpClick()
		{
			int formationHelpId = FlagChallengeConfig.Instance.GetFormationHelpId();
			HelpController.Instance.OpenHelpById(formationHelpId);
		}

		// Token: 0x0602FA12 RID: 195090 RVA: 0x00D497FC File Offset: 0x00D479FC
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

		// Token: 0x0602FA13 RID: 195091 RVA: 0x00D498C4 File Offset: 0x00D47AC4
		private void OnDetailBtnClick()
		{
			IEnumerable<int> trialRoleIdList = this.GetTrialRoleIdList();
			List<int> roleIdList = RoleModel.Instance.GetRoleIdList(null);
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

		// Token: 0x0602FA14 RID: 195092 RVA: 0x00D4998C File Offset: 0x00D47B8C
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
			HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
			int[] array = new int[selectedRoleSet.Count];
			selectedRoleSet.CopyTo(array);
			if (RoleUtils.HasSameRole(roleId, array, null))
			{
				ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamSameRole", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x0602FA15 RID: 195093 RVA: 0x00D49A0C File Offset: 0x00D47C0C
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

		// Token: 0x0602FA16 RID: 195094 RVA: 0x00D49AE0 File Offset: 0x00D47CE0
		private FlagChallengeFormationRoleItem CreateFormationRoleItem()
		{
			FlagChallengeFormationRoleItem flagChallengeFormationRoleItem = new FlagChallengeFormationRoleItem();
			flagChallengeFormationRoleItem.SetClickCallback(new Action<int>(this.OnClickFormationRoleItem));
			return flagChallengeFormationRoleItem;
		}

		// Token: 0x0602FA17 RID: 195095 RVA: 0x00D49AF9 File Offset: 0x00D47CF9
		private void OnClickFormationRoleItem(int roleId)
		{
			if (!RoleSelectModel.Instance.SelectedRoleSet.Contains(roleId))
			{
				return;
			}
			this.OnSelectRole(roleId, EToggleState.ETT_UnChecked);
			EventSystem.Instance.Emit<int>(EEventName.OnFlagChallengeRoleSelectCategoryUpdate, roleId);
		}

		// Token: 0x04019482 RID: 103554
		private int ActivityId;

		// Token: 0x04019483 RID: 103555
		private int LevelId;

		// Token: 0x04019484 RID: 103556
		private int StrongholdId;

		// Token: 0x04019485 RID: 103557
		private PopupCaptionItem PopupCaption;

		// Token: 0x04019486 RID: 103558
		private GenericScrollViewNew<FlagChallengeRoleCategoryItem, FlagChallengeRoleCategoryItemData> RoleCategoryScroll;

		// Token: 0x04019487 RID: 103559
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

		// Token: 0x04019488 RID: 103560
		private FlagChallengeStrongholdPanel StrongholdPanel;

		// Token: 0x04019489 RID: 103561
		private List<RoleDataBase> RoleDataList = new List<RoleDataBase>();

		// Token: 0x0401948A RID: 103562
		private GenericLayout<FlagChallengeFormationRoleItem, IFlagChallengeFormationRoleItemData> RoleLayout;
	}
}
