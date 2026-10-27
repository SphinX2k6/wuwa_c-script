using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02004E19 RID: 19993
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeSelectRoleView : UiViewBase
	{
		// Token: 0x06033921 RID: 211233 RVA: 0x00C0E805 File Offset: 0x00C0CA05
		protected override void OnBeforeCreate()
		{
			this.UiSceneRoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleInRogueView);
		}

		// Token: 0x06033922 RID: 211234 RVA: 0x00C0E81C File Offset: 0x00C0CA1C
		public RoguelikeSelectRoleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033923 RID: 211235 RVA: 0x00C0E878 File Offset: 0x00C0CA78
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

		// Token: 0x06033924 RID: 211236 RVA: 0x00C0EB84 File Offset: 0x00C0CD84
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeSelectRoleView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeSelectRoleView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033925 RID: 211237 RVA: 0x00C0EBC7 File Offset: 0x00C0CDC7
		protected override void OnStart()
		{
			RoguelikeSelectRoleGrid.CurSelectRoleItem = null;
			RoguelikeSelectRoleGrid.CurSelectRoleId = 0;
			this.InitRoleList();
			this.IsFirstIn = false;
		}

		// Token: 0x06033926 RID: 211238 RVA: 0x00C0EBE2 File Offset: 0x00C0CDE2
		protected override void OnBeforeShow()
		{
			UiSceneUtils.SetSceneFloorReflection(true, false);
		}

		// Token: 0x06033927 RID: 211239 RVA: 0x00C0EBEC File Offset: 0x00C0CDEC
		protected void InitRoleList()
		{
			int id = (int)this.OpenParam;
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(id);
			Aki.Config.FightFormation? formationConfig = FormationConfig.Instance.GetFightFormationConfig(config.Value.FightFormationId);
			List<RoleDataBase> trailRoleInstanceList = this.GetTrailRoleInstanceList(this.TrialRoleIdList);
			if (trailRoleInstanceList.Count > 0)
			{
				this.RoguelikeSelectRoleDataList.Add(new RoguelikeSelectRoleData(ERoguelikeSelectRoleType.Trail, trailRoleInstanceList, this.AddRoleLevel, this.AddWeaponLevel, this.MaxLevel, formationConfig.Value.LimitRole().ToList<int>(), null));
			}
			int[] showRoleList = formationConfig.Value.LimitRole();
			RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
			RoguelikeModel.Instance.SelectRoleViewShowRoleList = this.UnlockRoleList;
			RoguelikeModel.Instance.SelectRoleViewRecommendRoleList = formationConfig.Value.RecommendFormation().ToList<int>();
			List<RoleDataBase> list = new List<RoleDataBase>();
			using (List<int>.Enumerator enumerator = this.UnlockRoleList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int role = enumerator.Current;
					if (!RoleModel.Instance.IsMainRole(role) || RoleModel.Instance.GetRoleInstanceById(role) != null)
					{
						RoleInstance roleInstance = roleList.FirstOrDefault((RoleInstance r) => r.GetRoleId() == role);
						if (roleInstance != null)
						{
							list.Add(roleInstance);
						}
						else
						{
							list.Add(new RoleInstance(role));
						}
					}
				}
			}
			List<RoleDataBase> list2 = new List<RoleDataBase>();
			using (List<int>.Enumerator enumerator = this.LockRoleList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int roleId = enumerator.Current;
					RoleInstance roleInstance2 = roleList.FirstOrDefault((RoleInstance r) => r.GetRoleId() == roleId);
					if (roleInstance2 != null)
					{
						list2.Add(roleInstance2);
					}
					else
					{
						list2.Add(new RoleInstance(roleId));
					}
				}
			}
			list.Sort(delegate(RoleDataBase a, RoleDataBase b)
			{
				bool flag = showRoleList.Contains(a.GetRoleId()) && a.GetLevelData().GetLevel() != 0;
				bool flag2 = showRoleList.Contains(b.GetRoleId()) && b.GetLevelData().GetLevel() != 0;
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
					bool flag3 = formationConfig.Value.RecommendFormation().Contains(a.GetRoleId());
					bool flag4 = formationConfig.Value.RecommendFormation().Contains(b.GetRoleId());
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
				bool flag = showRoleList.Contains(a.GetRoleId()) && a.GetLevelData().GetLevel() != 0;
				bool flag2 = showRoleList.Contains(b.GetRoleId()) && b.GetLevelData().GetLevel() != 0;
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
					bool flag3 = formationConfig.Value.RecommendFormation().Contains(a.GetRoleId());
					bool flag4 = formationConfig.Value.RecommendFormation().Contains(b.GetRoleId());
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
			this.RoguelikeSelectRoleDataList.Add(new RoguelikeSelectRoleData(ERoguelikeSelectRoleType.Open, list.Cast<RoleDataBase>().ToList<RoleDataBase>(), this.AddRoleLevel, this.AddWeaponLevel, this.MaxLevel, showRoleList.ToList<int>(), formationConfig.Value.RecommendFormation().ToList<int>()));
			this.RoguelikeSelectRoleDataList.Add(new RoguelikeSelectRoleData(ERoguelikeSelectRoleType.UnOpen, list2.Cast<RoleDataBase>().ToList<RoleDataBase>(), this.AddRoleLevel, this.AddWeaponLevel, this.MaxLevel, showRoleList.ToList<int>(), formationConfig.Value.RecommendFormation().ToList<int>()));
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
			filterComponent.UpdateData(EFilterSortGroupId.RogueRole, list.ToList<RoleDataBase>(), Array.Empty<object>());
		}

		// Token: 0x06033928 RID: 211240 RVA: 0x00C0EF84 File Offset: 0x00C0D184
		protected override void OnBeforeDestroy()
		{
			UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.UiSceneRoleActor);
		}

		// Token: 0x06033929 RID: 211241 RVA: 0x00C0EF97 File Offset: 0x00C0D197
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.RoguelikePopularEntriesChange, new Action<IReadOnlyList<int>>(this.OnRoguelikePopularEntriesChange));
		}

		// Token: 0x0603392A RID: 211242 RVA: 0x00C0EFB5 File Offset: 0x00C0D1B5
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikePopularEntriesChange, new Action<IReadOnlyList<int>>(this.OnRoguelikePopularEntriesChange));
		}

		// Token: 0x0603392B RID: 211243 RVA: 0x00C0EFD4 File Offset: 0x00C0D1D4
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

		// Token: 0x0603392C RID: 211244 RVA: 0x00C0F038 File Offset: 0x00C0D238
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

		// Token: 0x0603392D RID: 211245 RVA: 0x00C0F0A8 File Offset: 0x00C0D2A8
		private void OnFilterSort(List<RoleDataBase> dataList, bool isOutSideChange, EFilterSortType operationType)
		{
			if (this.IsFirstIn)
			{
				return;
			}
			this.DynamicScrollViewComponent.GetScrollItemItems().ToList<RoguelikeSelectRoleGrid>().ForEach(delegate(RoguelikeSelectRoleGrid item)
			{
				RoguelikeSelectRoleData data = item.Data;
				if (data != null && data.Type == ERoguelikeSelectRoleType.Open)
				{
					item.Data.RoleIdList = dataList;
					item.RefreshData().AsTask();
				}
			});
		}

		// Token: 0x0603392E RID: 211246 RVA: 0x00C0F0EC File Offset: 0x00C0D2EC
		private RoguelikeSelectRoleGrid CreateItem(RoguelikeSelectRoleData data, UUIItem uiItem, int index)
		{
			RoguelikeSelectRoleGrid roguelikeSelectRoleGrid = new RoguelikeSelectRoleGrid(data);
			roguelikeSelectRoleGrid.BindSelectRoleCallBack(new Action<RoleDataBase, int>(this.OnSelectRoleCallBack));
			return roguelikeSelectRoleGrid;
		}

		// Token: 0x0603392F RID: 211247 RVA: 0x00C0F108 File Offset: 0x00C0D308
		private void OnSelectRoleCallBack(RoleDataBase roleData, int roleType)
		{
			this.SelectRoleData = roleData;
			int recommendLevel = InstanceDungeonConfig.Instance.GetRecommendLevel(this.InstanceId, WorldLevelModel.Instance.CurWorldLevel);
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(this.InstanceId);
			Aki.Config.FightFormation? fightFormationConfig = FormationConfig.Instance.GetFightFormationConfig(config.Value.FightFormationId);
			int num = (this.AddRoleLevel > 0) ? ((this.AddRoleLevel > roleData.GetLevelData().GetLevel()) ? this.AddRoleLevel : roleData.GetLevelData().GetLevel()) : roleData.GetLevelData().GetLevel();
			int dataId = roleData.GetDataId();
			bool flag = RoleModel.Instance.GetRoleInstanceById(dataId) != null;
			bool flag2 = fightFormationConfig.Value.LimitRole().Contains(dataId);
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

		// Token: 0x06033930 RID: 211248 RVA: 0x00C0F2F5 File Offset: 0x00C0D4F5
		private void OnBtnBack()
		{
			InstanceDungeonEntranceController.Instance.RevertEntranceFlowStep();
			base.CloseMe(null);
		}

		// Token: 0x06033931 RID: 211249 RVA: 0x00C0F308 File Offset: 0x00C0D508
		private void OnBtnConfirm()
		{
			int id = (int)this.OpenParam;
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(id);
			if (!FormationConfig.Instance.GetFightFormationConfig(config.Value.FightFormationId).Value.LimitRole().Contains(this.SelectRoleData.GetRoleId()))
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

		// Token: 0x06033932 RID: 211250 RVA: 0x00C0F3B8 File Offset: 0x00C0D5B8
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

		// Token: 0x06033933 RID: 211251 RVA: 0x00C0F4B4 File Offset: 0x00C0D6B4
		private bool CheckHasCanSelectEntry()
		{
			foreach (RougePopularEntrie rougePopularEntrie in RoguelikeConfig.Instance.GetRoguelikePopularEntries())
			{
				if (rougePopularEntrie.Insts().Contains(this.Entries.InstId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06033934 RID: 211252 RVA: 0x00C0F520 File Offset: 0x00C0D720
		private void OnBtnEntrySelect()
		{
			UiManager.Instance.OpenView(EUiViewName.RoguelikeInstanceEntrySelectView, this.Entries, null);
		}

		// Token: 0x06033935 RID: 211253 RVA: 0x00C0F538 File Offset: 0x00C0D738
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

		// Token: 0x06033936 RID: 211254 RVA: 0x00C0F5D3 File Offset: 0x00C0D7D3
		private void OnBtnHelp()
		{
			HelpController.Instance.OpenHelpById(76);
		}

		// Token: 0x0401B5A7 RID: 112039
		protected DynamicScrollView<RoguelikeSelectRoleGrid, RoguelikeSelectRoleBaseGrid, RoguelikeSelectRoleData> DynamicScrollViewComponent;

		// Token: 0x0401B5A8 RID: 112040
		private RoguelikeSelectRoleBaseGrid RoguelikeBaseItem;

		// Token: 0x0401B5A9 RID: 112041
		private readonly List<RoguelikeSelectRoleData> RoguelikeSelectRoleDataList = new List<RoguelikeSelectRoleData>();

		// Token: 0x0401B5AA RID: 112042
		public List<RoleDataBase> ShowRoleList = new List<RoleDataBase>();

		// Token: 0x0401B5AB RID: 112043
		private List<int> TrialRoleIdList = new List<int>();

		// Token: 0x0401B5AC RID: 112044
		private int InstanceId;

		// Token: 0x0401B5AD RID: 112045
		private RoleDataBase SelectRoleData;

		// Token: 0x0401B5AE RID: 112046
		private ERoguelikeSelectRoleType SelectRoleType = ERoguelikeSelectRoleType.Open;

		// Token: 0x0401B5AF RID: 112047
		private TsUiSceneRoleActor UiSceneRoleActor;

		// Token: 0x0401B5B0 RID: 112048
		private FilterSortEntrance<RoleDataBase> FilterComponent;

		// Token: 0x0401B5B1 RID: 112049
		private PopularEntrie Entries;

		// Token: 0x0401B5B2 RID: 112050
		private int AddRoleLevel;

		// Token: 0x0401B5B3 RID: 112051
		private int AddWeaponLevel;

		// Token: 0x0401B5B4 RID: 112052
		private int MaxLevel;

		// Token: 0x0401B5B5 RID: 112053
		private bool IsFirstIn = true;

		// Token: 0x0401B5B6 RID: 112054
		private List<int> UnlockRoleList = new List<int>();

		// Token: 0x0401B5B7 RID: 112055
		private List<int> LockRoleList = new List<int>();

		// Token: 0x0200AFB6 RID: 44982
		[NullableContext(0)]
		private class ERoguelikeSelectRoleViewDefine
		{
			// Token: 0x04035577 RID: 218487
			public const int TopItem = 0;

			// Token: 0x04035578 RID: 218488
			public const int BtnBack = 1;

			// Token: 0x04035579 RID: 218489
			public const int BtnConfirm = 2;

			// Token: 0x0403557A RID: 218490
			public const int DynamicScrollView = 3;

			// Token: 0x0403557B RID: 218491
			public const int DynamicScrollViewGridItem = 4;

			// Token: 0x0403557C RID: 218492
			public const int FilterItem = 5;

			// Token: 0x0403557D RID: 218493
			public const int TxtTitle = 6;

			// Token: 0x0403557E RID: 218494
			public const int TxtDescription = 7;

			// Token: 0x0403557F RID: 218495
			public const int BtnEntrySelect = 8;

			// Token: 0x04035580 RID: 218496
			public const int PanelTips = 9;

			// Token: 0x04035581 RID: 218497
			public const int BtnDetail = 10;

			// Token: 0x04035582 RID: 218498
			public const int TxtEntryNumber = 11;

			// Token: 0x04035583 RID: 218499
			public const int BtnHelp = 12;

			// Token: 0x04035584 RID: 218500
			public const int RoleAddItem = 13;

			// Token: 0x04035585 RID: 218501
			public const int TxtRoleAddLevel = 14;

			// Token: 0x04035586 RID: 218502
			public const int TxtWeaponAddLevel = 15;
		}
	}
}
