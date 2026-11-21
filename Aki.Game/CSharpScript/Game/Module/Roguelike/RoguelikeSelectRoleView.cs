using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.UiComponent;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DE2 RID: 15842
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeSelectRoleView : UiViewBase
	{
		// Token: 0x0602878C RID: 165772 RVA: 0x00B57D11 File Offset: 0x00B55F11
		protected override void OnBeforeCreate()
		{
			this.UiSceneRoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleInRogueView);
		}

		// Token: 0x0602878D RID: 165773 RVA: 0x00B57D28 File Offset: 0x00B55F28
		public RoguelikeSelectRoleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602878E RID: 165774 RVA: 0x00B57D84 File Offset: 0x00B55F84
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIDynScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 5;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnBack));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnConfirm));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnBtnEntrySelect));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnBtnDetail));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnBtnHelp));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602878F RID: 165775 RVA: 0x00B58090 File Offset: 0x00B56290
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeSelectRoleView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeSelectRoleView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028790 RID: 165776 RVA: 0x00B580D3 File Offset: 0x00B562D3
		protected override void OnStart()
		{
			RoguelikeSelectRoleGrid.CurSelectRoleItem = null;
			RoguelikeSelectRoleGrid.CurSelectRoleId = 0;
			this.InitRoleList();
			this.IsFirstIn = false;
		}

		// Token: 0x06028791 RID: 165777 RVA: 0x00B580EE File Offset: 0x00B562EE
		protected override void OnBeforeShow()
		{
			UiSceneUtils.SetSceneFloorReflection(true, false);
		}

		// Token: 0x06028792 RID: 165778 RVA: 0x00B580F8 File Offset: 0x00B562F8
		protected void InitRoleList()
		{
			int id = (int)this.OpenParam;
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(id);
			Aki.Config.FightFormation? formationConfig = FormationConfig.Instance.GetFightFormationConfig(config.Value.FightFormationId);
			List<RoleDataBase> trailRoleInstanceList = this.GetTrailRoleInstanceList(this.TrialRoleIdList);
			if (trailRoleInstanceList.Count > 0)
			{
				this.RoguelikeSelectRoleDataList.Add(new RoguelikeSelectRoleData(ERoguelikeSelectRoleType.Trail, trailRoleInstanceList, this.AddRoleLevel, this.AddWeaponLevel, this.MaxLevel, new List<int>(formationConfig.Value.LimitRole()), null));
			}
			int[] showRoleList = formationConfig.Value.LimitRole();
			RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
			RoguelikeModel.Instance.SelectRoleViewShowRoleList = this.UnlockRoleList;
			RoguelikeModel.Instance.SelectRoleViewRecommendRoleList = new List<int>(formationConfig.Value.RecommendFormation());
			List<RoleDataBase> list = new List<RoleDataBase>();
			foreach (int num in this.UnlockRoleList)
			{
				if (!RoleModel.Instance.IsMainRole(num) || RoleModel.Instance.GetRoleInstanceById(num) != null)
				{
					RoleInstance roleInstance = null;
					foreach (RoleInstance roleInstance2 in roleList)
					{
						if (roleInstance2.GetRoleId() == num)
						{
							roleInstance = roleInstance2;
							break;
						}
					}
					if (roleInstance != null)
					{
						list.Add(roleInstance);
					}
					else
					{
						list.Add(new RoleInstance(num));
					}
				}
			}
			List<RoleDataBase> list2 = new List<RoleDataBase>();
			foreach (int num2 in this.LockRoleList)
			{
				RoleInstance roleInstance3 = null;
				foreach (RoleInstance roleInstance4 in roleList)
				{
					if (roleInstance4.GetRoleId() == num2)
					{
						roleInstance3 = roleInstance4;
						break;
					}
				}
				if (roleInstance3 != null)
				{
					list2.Add(roleInstance3);
				}
				else
				{
					list2.Add(new RoleInstance(num2));
				}
			}
			list.Sort(delegate(RoleDataBase a, RoleDataBase b)
			{
				bool flag = Array.IndexOf<int>(showRoleList, a.GetRoleId()) >= 0 && a.GetLevelData().GetLevel() != 0;
				bool flag2 = Array.IndexOf<int>(showRoleList, b.GetRoleId()) >= 0 && b.GetLevelData().GetLevel() != 0;
				if (flag != flag2)
				{
					if (!flag)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					bool flag3 = Array.IndexOf<int>(formationConfig.Value.RecommendFormation(), a.GetRoleId()) >= 0;
					bool flag4 = Array.IndexOf<int>(formationConfig.Value.RecommendFormation(), b.GetRoleId()) >= 0;
					if (flag3 != flag4)
					{
						if (!flag3)
						{
							return 1;
						}
						return -1;
					}
					else
					{
						int level = a.GetLevelData().GetLevel();
						int level2 = b.GetLevelData().GetLevel();
						if (level != level2)
						{
							if (level <= level2)
							{
								return 1;
							}
							return -1;
						}
						else
						{
							int qualityId = a.GetRoleConfig().QualityId;
							int qualityId2 = b.GetRoleConfig().QualityId;
							if (qualityId != qualityId2)
							{
								if (qualityId <= qualityId2)
								{
									return 1;
								}
								return -1;
							}
							else
							{
								int roleId = a.GetRoleId();
								int roleId2 = b.GetRoleId();
								if (roleId <= roleId2)
								{
									return (roleId < roleId2) ? 1 : 0;
								}
								return -1;
							}
						}
					}
				}
			});
			list2.Sort(delegate(RoleDataBase a, RoleDataBase b)
			{
				bool flag = Array.IndexOf<int>(showRoleList, a.GetRoleId()) >= 0 && a.GetLevelData().GetLevel() != 0;
				bool flag2 = Array.IndexOf<int>(showRoleList, b.GetRoleId()) >= 0 && b.GetLevelData().GetLevel() != 0;
				if (flag != flag2)
				{
					if (!flag)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					bool flag3 = Array.IndexOf<int>(formationConfig.Value.RecommendFormation(), a.GetRoleId()) >= 0;
					bool flag4 = Array.IndexOf<int>(formationConfig.Value.RecommendFormation(), b.GetRoleId()) >= 0;
					if (flag3 != flag4)
					{
						if (!flag3)
						{
							return 1;
						}
						return -1;
					}
					else
					{
						int level = a.GetLevelData().GetLevel();
						int level2 = b.GetLevelData().GetLevel();
						if (level != level2)
						{
							if (level <= level2)
							{
								return 1;
							}
							return -1;
						}
						else
						{
							int qualityId = a.GetRoleConfig().QualityId;
							int qualityId2 = b.GetRoleConfig().QualityId;
							if (qualityId != qualityId2)
							{
								if (qualityId <= qualityId2)
								{
									return 1;
								}
								return -1;
							}
							else
							{
								int roleId = a.GetRoleId();
								int roleId2 = b.GetRoleId();
								if (roleId <= roleId2)
								{
									return (roleId < roleId2) ? 1 : 0;
								}
								return -1;
							}
						}
					}
				}
			});
			this.RoguelikeSelectRoleDataList.Add(new RoguelikeSelectRoleData(ERoguelikeSelectRoleType.Open, new List<RoleDataBase>(list), this.AddRoleLevel, this.AddWeaponLevel, this.MaxLevel, new List<int>(showRoleList), new List<int>(formationConfig.Value.RecommendFormation())));
			this.RoguelikeSelectRoleDataList.Add(new RoguelikeSelectRoleData(ERoguelikeSelectRoleType.UnOpen, new List<RoleDataBase>(list2), this.AddRoleLevel, this.AddWeaponLevel, this.MaxLevel, new List<int>(showRoleList), new List<int>(formationConfig.Value.RecommendFormation())));
			if (list.Count > 0)
			{
				this.SelectRoleData = list[0];
				this.SelectRoleType = ERoguelikeSelectRoleType.Open;
			}
			else if (list2.Count > 0)
			{
				this.SelectRoleData = list2[0];
				this.SelectRoleType = ERoguelikeSelectRoleType.UnOpen;
			}
			else
			{
				Log.Instance.Error(ELogModule.Roguelike, ELogAuthor.BB, "RoguelikeSelectRoleView没有角色数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.DynamicScrollViewComponent.RefreshByData(this.RoguelikeSelectRoleDataList.ToArray(), false, false);
			FilterSortEntrance<RoleDataBase> filterComponent = this.FilterComponent;
			if (filterComponent == null)
			{
				return;
			}
			filterComponent.UpdateData(EFilterSortGroupId.RogueRole, new List<RoleDataBase>(list), Array.Empty<object>());
		}

		// Token: 0x06028793 RID: 165779 RVA: 0x00B58490 File Offset: 0x00B56690
		protected override void OnBeforeDestroy()
		{
			UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.UiSceneRoleActor);
		}

		// Token: 0x06028794 RID: 165780 RVA: 0x00B584A3 File Offset: 0x00B566A3
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.RoguelikePopularEntriesChange, new Action<IReadOnlyList<int>>(this.OnRoguelikePopularEntriesChange));
		}

		// Token: 0x06028795 RID: 165781 RVA: 0x00B584C1 File Offset: 0x00B566C1
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikePopularEntriesChange, new Action<IReadOnlyList<int>>(this.OnRoguelikePopularEntriesChange));
		}

		// Token: 0x06028796 RID: 165782 RVA: 0x00B584E0 File Offset: 0x00B566E0
		protected override void OnHandleLoadScene()
		{
			UiModelBase model = UiSceneManager.Instance.GetRoleSystemRoleActor().Model;
			UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
			if (uiModelActorComponent != null)
			{
				uiModelActorComponent.SetTransformByTag("RoleCase");
			}
			RoleController.Instance.OnSelectedRoleChangeByConfig(this.SelectRoleData.GetRoleId(), -1, null);
			this.OnSelectRoleCallBack(this.SelectRoleData, (int)this.SelectRoleType);
		}

		// Token: 0x06028797 RID: 165783 RVA: 0x00B58544 File Offset: 0x00B56744
		protected List<RoleDataBase> GetTrailRoleInstanceList(List<int> roleIdList)
		{
			List<RoleDataBase> list = new List<RoleDataBase>();
			foreach (int id in roleIdList)
			{
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(RoleConfig.Instance.GetTrialRoleIdConfigByGroupId(id), true);
				if (roleDataById != null)
				{
					list.Add(roleDataById);
				}
			}
			return list;
		}

		// Token: 0x06028798 RID: 165784 RVA: 0x00B585B4 File Offset: 0x00B567B4
		private void OnFilterSort(List<RoleDataBase> dataList, bool isOutSideChange, EFilterSortType operationType)
		{
			if (this.IsFirstIn)
			{
				return;
			}
			foreach (RoguelikeSelectRoleGrid roguelikeSelectRoleGrid in this.DynamicScrollViewComponent.GetScrollItemItems())
			{
				RoguelikeSelectRoleData data = roguelikeSelectRoleGrid.Data;
				if (data != null && data.Type == ERoguelikeSelectRoleType.Open)
				{
					roguelikeSelectRoleGrid.Data.RoleIdList = dataList;
					roguelikeSelectRoleGrid.RefreshData().AsTask();
				}
			}
		}

		// Token: 0x06028799 RID: 165785 RVA: 0x00B58617 File Offset: 0x00B56817
		private RoguelikeSelectRoleGrid CreateItem(RoguelikeSelectRoleData data, UUIItem uiItem, int index)
		{
			RoguelikeSelectRoleGrid roguelikeSelectRoleGrid = new RoguelikeSelectRoleGrid(data);
			roguelikeSelectRoleGrid.BindSelectRoleCallBack(new Action<RoleDataBase, int>(this.OnSelectRoleCallBack));
			return roguelikeSelectRoleGrid;
		}

		// Token: 0x0602879A RID: 165786 RVA: 0x00B58634 File Offset: 0x00B56834
		private void OnSelectRoleCallBack(RoleDataBase roleData, int roleType)
		{
			this.SelectRoleData = roleData;
			int recommendLevel = InstanceDungeonConfig.Instance.GetRecommendLevel(this.InstanceId, WorldLevelModel.Instance.CurWorldLevel);
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(this.InstanceId);
			Aki.Config.FightFormation? fightFormationConfig = FormationConfig.Instance.GetFightFormationConfig(config.Value.FightFormationId);
			int num = (this.AddRoleLevel > 0) ? ((this.AddRoleLevel > roleData.GetLevelData().GetLevel()) ? this.AddRoleLevel : roleData.GetLevelData().GetLevel()) : roleData.GetLevelData().GetLevel();
			int dataId = roleData.GetDataId();
			bool flag = RoleModel.Instance.GetRoleInstanceById(dataId) != null;
			bool flag2 = Array.IndexOf<int>(fightFormationConfig.Value.LimitRole(), dataId) >= 0;
			bool uiactive = recommendLevel > num && flag2 && flag;
			bool uiactive2 = dataId > 100000 || (flag2 && flag);
			bool flag3 = (flag ? WeaponModel.Instance.GetWeaponDataByRoleDataId(roleData.GetDataId(), true).GetLevel() : 0) < this.AddWeaponLevel && !roleData.IsTrialRole() && flag && flag2;
			bool flag4 = roleData.GetLevelData().GetLevel() < this.AddRoleLevel && !roleData.IsTrialRole() && flag && flag2;
			base.GetItem(9).SetUIActive(uiactive);
			base.GetButton(10).RootUIComp.Get().SetUIActive(uiactive2);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "Text_RoleAddLevel_Text", new <>z__ReadOnlySingleElementList<object>(this.AddRoleLevel));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "Text_WeaponAddLevel_Text", new <>z__ReadOnlySingleElementList<object>(this.AddWeaponLevel));
			base.GetText(15).SetUIActive(flag3);
			base.GetText(14).SetUIActive(flag4);
			base.GetItem(13).SetUIActive(flag4 || flag3);
		}

		// Token: 0x0602879B RID: 165787 RVA: 0x00B58827 File Offset: 0x00B56A27
		private void OnBtnBack()
		{
			InstanceDungeonEntranceController.Instance.RevertEntranceFlowStep();
			base.CloseMe(null);
		}

		// Token: 0x0602879C RID: 165788 RVA: 0x00B5883C File Offset: 0x00B56A3C
		private void OnBtnConfirm()
		{
			int id = (int)this.OpenParam;
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(id);
			if (Array.IndexOf<int>(FormationConfig.Instance.GetFightFormationConfig(config.Value.FightFormationId).Value.LimitRole(), this.SelectRoleData.GetRoleId()) < 0)
			{
				ScrollingTipsController.Instance.ShowTipsById("Roguelike_SelectRole_CannotUse", Array.Empty<object>());
				return;
			}
			if (RoleModel.Instance.GetRoleDataById(this.SelectRoleData.GetDataId(), true) == null)
			{
				ScrollingTipsController.Instance.ShowTipsById("Rogue_Dont_Have_Role", Array.Empty<object>());
				return;
			}
			InstanceDungeonEntranceController.Instance.ContinueEntranceFlow();
		}

		// Token: 0x0602879D RID: 165789 RVA: 0x00B588F0 File Offset: 0x00B56AF0
		private void OnRoguelikePopularEntriesChange(IReadOnlyList<int> entries)
		{
			int num = 10000;
			this.Entries.Entries.Clear();
			this.Entries.Entries.AddRange(entries);
			foreach (int id in entries)
			{
				RougePopularEntrie? roguelikePopularEntriesById = RoguelikeConfig.Instance.GetRoguelikePopularEntriesById(id);
				if (roguelikePopularEntriesById != null)
				{
					num += roguelikePopularEntriesById.Value.Rate;
				}
			}
			FColor color = FColor.FromHex("adadad");
			if (num > 10000)
			{
				color = FColor.FromHex("c25757");
			}
			else if (num < 10000)
			{
				color = FColor.FromHex("36cd33");
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "Rogue_Entry_Multiple", new <>z__ReadOnlySingleElementList<object>(num / 100));
			UUIText text = base.GetText(11);
			if (text == null)
			{
				return;
			}
			text.SetColor(color);
		}

		// Token: 0x0602879E RID: 165790 RVA: 0x00B589EC File Offset: 0x00B56BEC
		private bool CheckHasCanSelectEntry()
		{
			foreach (RougePopularEntrie rougePopularEntrie in RoguelikeConfig.Instance.GetRoguelikePopularEntries())
			{
				if (Array.IndexOf<int>(rougePopularEntrie.Insts(), this.Entries.InstId) >= 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602879F RID: 165791 RVA: 0x00B58A58 File Offset: 0x00B56C58
		private void OnBtnEntrySelect()
		{
			UiManager.Instance.OpenView(EUiViewName.RoguelikeInstanceEntrySelectView, this.Entries, null);
		}

		// Token: 0x060287A0 RID: 165792 RVA: 0x00B58A70 File Offset: 0x00B56C70
		private unsafe void OnBtnDetail()
		{
			int num;
			Span<int> span;
			int num2;
			if (this.SelectRoleType == ERoguelikeSelectRoleType.UnOpen)
			{
				RoleController instance = RoleController.Instance;
				ERoleAgentType agentType = ERoleAgentType.Preview;
				int selectRoleId = 0;
				num = 1;
				List<int> list = new List<int>(num);
				CollectionsMarshal.SetCount<int>(list, num);
				span = CollectionsMarshal.AsSpan<int>(list);
				num2 = 0;
				*span[num2] = this.SelectRoleData.GetDataId();
				instance.OpenRoleMainView(agentType, selectRoleId, list, null, null);
				return;
			}
			RoleController instance2 = RoleController.Instance;
			ERoleAgentType agentType2 = ERoleAgentType.Normal;
			int selectRoleId2 = 0;
			num2 = 1;
			List<int> list2 = new List<int>(num2);
			CollectionsMarshal.SetCount<int>(list2, num2);
			span = CollectionsMarshal.AsSpan<int>(list2);
			num = 0;
			*span[num] = this.SelectRoleData.GetDataId();
			instance2.OpenRoleMainView(agentType2, selectRoleId2, list2, null, null);
		}

		// Token: 0x060287A1 RID: 165793 RVA: 0x00B58B0B File Offset: 0x00B56D0B
		private void OnBtnHelp()
		{
			HelpController.Instance.OpenHelpById(76);
		}

		// Token: 0x04015F7A RID: 89978
		protected DynamicScrollView<RoguelikeSelectRoleGrid, RoguelikeSelectRoleBaseGrid, RoguelikeSelectRoleData> DynamicScrollViewComponent;

		// Token: 0x04015F7B RID: 89979
		private RoguelikeSelectRoleBaseGrid RoguelikeBaseItem;

		// Token: 0x04015F7C RID: 89980
		private readonly List<RoguelikeSelectRoleData> RoguelikeSelectRoleDataList = new List<RoguelikeSelectRoleData>();

		// Token: 0x04015F7D RID: 89981
		public List<RoleDataBase> ShowRoleList = new List<RoleDataBase>();

		// Token: 0x04015F7E RID: 89982
		private List<int> TrialRoleIdList = new List<int>();

		// Token: 0x04015F7F RID: 89983
		private int InstanceId;

		// Token: 0x04015F80 RID: 89984
		private RoleDataBase SelectRoleData;

		// Token: 0x04015F81 RID: 89985
		private ERoguelikeSelectRoleType SelectRoleType = ERoguelikeSelectRoleType.Open;

		// Token: 0x04015F82 RID: 89986
		private TsUiSceneRoleActor UiSceneRoleActor;

		// Token: 0x04015F83 RID: 89987
		private FilterSortEntrance<RoleDataBase> FilterComponent;

		// Token: 0x04015F84 RID: 89988
		private PopularEntrie Entries;

		// Token: 0x04015F85 RID: 89989
		private int AddRoleLevel;

		// Token: 0x04015F86 RID: 89990
		private int AddWeaponLevel;

		// Token: 0x04015F87 RID: 89991
		private int MaxLevel;

		// Token: 0x04015F88 RID: 89992
		private bool IsFirstIn = true;

		// Token: 0x04015F89 RID: 89993
		private List<int> UnlockRoleList = new List<int>();

		// Token: 0x04015F8A RID: 89994
		private List<int> LockRoleList = new List<int>();

		// Token: 0x020099EB RID: 39403
		[NullableContext(0)]
		private class ERoguelikeSelectRoleViewDefine
		{
			// Token: 0x0402FFAA RID: 196522
			public const int TopItem = 0;

			// Token: 0x0402FFAB RID: 196523
			public const int BtnBack = 1;

			// Token: 0x0402FFAC RID: 196524
			public const int BtnConfirm = 2;

			// Token: 0x0402FFAD RID: 196525
			public const int DynamicScrollView = 3;

			// Token: 0x0402FFAE RID: 196526
			public const int DynamicScrollViewGridItem = 4;

			// Token: 0x0402FFAF RID: 196527
			public const int FilterItem = 5;

			// Token: 0x0402FFB0 RID: 196528
			public const int TxtTitle = 6;

			// Token: 0x0402FFB1 RID: 196529
			public const int TxtDescription = 7;

			// Token: 0x0402FFB2 RID: 196530
			public const int BtnEntrySelect = 8;

			// Token: 0x0402FFB3 RID: 196531
			public const int PanelTips = 9;

			// Token: 0x0402FFB4 RID: 196532
			public const int BtnDetail = 10;

			// Token: 0x0402FFB5 RID: 196533
			public const int TxtEntryNumber = 11;

			// Token: 0x0402FFB6 RID: 196534
			public const int BtnHelp = 12;

			// Token: 0x0402FFB7 RID: 196535
			public const int RoleAddItem = 13;

			// Token: 0x0402FFB8 RID: 196536
			public const int TxtRoleAddLevel = 14;

			// Token: 0x0402FFB9 RID: 196537
			public const int TxtWeaponAddLevel = 15;
		}
	}
}
