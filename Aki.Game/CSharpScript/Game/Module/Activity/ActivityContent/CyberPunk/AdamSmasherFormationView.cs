using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020057F3 RID: 22515
	[NullableContext(1)]
	[Nullable(0)]
	public class AdamSmasherFormationView : UiViewBase
	{
		// Token: 0x060378D5 RID: 227541 RVA: 0x00F86EE0 File Offset: 0x00F850E0
		public AdamSmasherFormationView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060378D6 RID: 227542 RVA: 0x00F86F18 File Offset: 0x00F85118
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIDynScrollViewComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x060378D7 RID: 227543 RVA: 0x00F87024 File Offset: 0x00F85224
		protected override UniTask OnBeforeStartAsync()
		{
			AdamSmasherFormationView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AdamSmasherFormationView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060378D8 RID: 227544 RVA: 0x00F87067 File Offset: 0x00F85267
		protected override void OnStart()
		{
			this.FilterSortEntranceItem.UpdateData(EFilterSortGroupId.EditBattleTeam, this.AllRoleList, Array.Empty<object>());
			this.OnFilterSortUpdate(this.AllRoleList, false, EFilterSortType.Sort);
			this.DynamicRoleGroupLayout.LateScrollTo(0);
			this.RefreshTargetInfo();
			this.RefreshButtonState();
		}

		// Token: 0x060378D9 RID: 227545 RVA: 0x00F870A6 File Offset: 0x00F852A6
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x060378DA RID: 227546 RVA: 0x00F870C4 File Offset: 0x00F852C4
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x060378DB RID: 227547 RVA: 0x00F870E2 File Offset: 0x00F852E2
		protected override void OnBeforeDestroy()
		{
			RoleSelectModel.Instance.ClearData();
			FilterSortEntrance<RoleDataBase> filterSortEntranceItem = this.FilterSortEntranceItem;
			if (filterSortEntranceItem != null)
			{
				filterSortEntranceItem.Destroy(null);
			}
			this.FilterSortEntranceItem = null;
		}

		// Token: 0x060378DC RID: 227548 RVA: 0x00F87108 File Offset: 0x00F85308
		private UniTask InitRoleGroupLayout()
		{
			AdamSmasherFormationView.<InitRoleGroupLayout>d__21 <InitRoleGroupLayout>d__;
			<InitRoleGroupLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleGroupLayout>d__.<>4__this = this;
			<InitRoleGroupLayout>d__.<>1__state = -1;
			<InitRoleGroupLayout>d__.<>t__builder.Start<AdamSmasherFormationView.<InitRoleGroupLayout>d__21>(ref <InitRoleGroupLayout>d__);
			return <InitRoleGroupLayout>d__.<>t__builder.Task;
		}

		// Token: 0x060378DD RID: 227549 RVA: 0x00F8714C File Offset: 0x00F8534C
		private AdamFormationRoleGroupInfo[] GenerateAllRoleGroupInfo([Nullable(new byte[]
		{
			2,
			1
		})] List<RoleDataBase> roleList = null)
		{
			if (roleList == null)
			{
				roleList = this.AllRoleList;
			}
			List<AdamFormationRoleGroupInfo> list = new List<AdamFormationRoleGroupInfo>();
			List<RoleDataBase> classifiedRoleList = this.GetClassifiedRoleList(roleList, true);
			AdamFormationRoleGroupTitleInfo titleInfo = new AdamFormationRoleGroupTitleInfo
			{
				TitleTextId = "AdamChallenge_TrialRole",
				IsEmpty = (classifiedRoleList.Count == 0)
			};
			list.Add(new AdamFormationRoleGroupInfo
			{
				IsTitleType = true,
				TitleInfo = titleInfo
			});
			if (classifiedRoleList.Count > 0)
			{
				list.Add(new AdamFormationRoleGroupInfo
				{
					IsTitleType = false,
					DataList = classifiedRoleList.ToArray()
				});
			}
			List<RoleDataBase> classifiedRoleList2 = this.GetClassifiedRoleList(roleList, false);
			AdamFormationRoleGroupTitleInfo titleInfo2 = new AdamFormationRoleGroupTitleInfo
			{
				TitleTextId = "AdamChallenge_OwnRole",
				IsEmpty = (classifiedRoleList2.Count == 0)
			};
			list.Add(new AdamFormationRoleGroupInfo
			{
				IsTitleType = true,
				TitleInfo = titleInfo2
			});
			if (classifiedRoleList2.Count > 0)
			{
				list.Add(new AdamFormationRoleGroupInfo
				{
					IsTitleType = false,
					DataList = classifiedRoleList2.ToArray()
				});
			}
			return list.ToArray();
		}

		// Token: 0x060378DE RID: 227550 RVA: 0x00F87244 File Offset: 0x00F85444
		private List<RoleDataBase> GetClassifiedRoleList(List<RoleDataBase> wholeRoleList, bool needTrial)
		{
			List<RoleDataBase> list = new List<RoleDataBase>();
			foreach (RoleDataBase roleDataBase in wholeRoleList)
			{
				if (roleDataBase.IsTrialRole() == needTrial)
				{
					list.Add(roleDataBase);
				}
			}
			Dictionary<RoleDataBase, int> originalOrder = new Dictionary<RoleDataBase, int>();
			for (int i = 0; i < list.Count; i++)
			{
				originalOrder[list[i]] = i;
			}
			list.Sort(delegate(RoleDataBase a, RoleDataBase b)
			{
				int level = a.GetLevelData().GetLevel();
				int level2 = b.GetLevelData().GetLevel();
				if (level == level2)
				{
					int num = (this.RecommendedRoleIdSet.Contains(a.GetDataId()) > false) ? 1 : 0;
					int num2 = (this.RecommendedRoleIdSet.Contains(b.GetDataId()) > false) ? 1 : 0;
					if (num != num2)
					{
						return num2 - num;
					}
				}
				int num4;
				int num3 = originalOrder.TryGetValue(a, out num4) ? num4 : 0;
				int num6;
				int num5 = originalOrder.TryGetValue(b, out num6) ? num6 : 0;
				return num3 - num5;
			});
			return list;
		}

		// Token: 0x060378DF RID: 227551 RVA: 0x00F872F8 File Offset: 0x00F854F8
		private void OnFilterSortUpdate(List<RoleDataBase> list, bool isOutSideChange, EFilterSortType operationType)
		{
			Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
			List<RoleDataBase> list2 = new List<RoleDataBase>();
			for (int i = 1; i <= 3; i++)
			{
				RoleDataBase item;
				if (roleIndexMap.TryGetValue(i, out item))
				{
					list2.Add(item);
				}
			}
			foreach (RoleDataBase item2 in list)
			{
				if (!list2.Contains(item2))
				{
					list2.Add(item2);
				}
			}
			this.DynamicRoleGroupLayout.RefreshByData(this.GenerateAllRoleGroupInfo(list2), false, false);
		}

		// Token: 0x060378E0 RID: 227552 RVA: 0x00F87398 File Offset: 0x00F85598
		private AdamFormationRoleContainer OnCreateRoleGroup(AdamFormationRoleGroupInfo data, UUIItem uiItem, int index)
		{
			return new AdamFormationRoleContainer
			{
				RefreshRole = new Action<RoleDataBase>(this.RefreshRoleSelect),
				RecommendedRoleIdSet = this.RecommendedRoleIdSet
			};
		}

		// Token: 0x060378E1 RID: 227553 RVA: 0x00F873BD File Offset: 0x00F855BD
		private void RefreshRoleSelect(RoleDataBase roleData)
		{
			this.CurSelectRole = roleData;
			this.RefreshTeamSelect();
			this.RefreshButtonState();
		}

		// Token: 0x060378E2 RID: 227554 RVA: 0x00F873D2 File Offset: 0x00F855D2
		private WeeklyRogueRolePosItem CreateTeamSlotItem()
		{
			return new WeeklyRogueRolePosItem
			{
				OnBtnClickFunc = new Action<RoleDataBase>(this.OnBtnRolePosClick)
			};
		}

		// Token: 0x060378E3 RID: 227555 RVA: 0x00F873EC File Offset: 0x00F855EC
		[NullableContext(2)]
		private void OnBtnRolePosClick(RoleDataBase data)
		{
			if (data == null)
			{
				return;
			}
			Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
			HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
			foreach (KeyValuePair<int, RoleDataBase> keyValuePair in roleIndexMap)
			{
				if (keyValuePair.Value == data)
				{
					roleIndexMap.Remove(keyValuePair.Key);
					selectedRoleSet.Remove(data.GetDataId());
					break;
				}
			}
			AdamFormationRoleContainer[] scrollItemItems = this.DynamicRoleGroupLayout.GetScrollItemItems();
			for (int i = 0; i < scrollItemItems.Length; i++)
			{
				scrollItemItems[i].Refresh();
			}
			this.RefreshTeamSelect();
			this.RefreshButtonState();
		}

		// Token: 0x060378E4 RID: 227556 RVA: 0x00F874AC File Offset: 0x00F856AC
		private List<int> GetCurrentSelectRoleList()
		{
			Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
			List<int> list = new List<int>();
			for (int i = 1; i <= 3; i++)
			{
				RoleDataBase roleDataBase;
				if (roleIndexMap.TryGetValue(i, out roleDataBase))
				{
					list.Add(roleDataBase.GetDataId());
				}
			}
			return list;
		}

		// Token: 0x060378E5 RID: 227557 RVA: 0x00F874F0 File Offset: 0x00F856F0
		private void RefreshTeamSelect()
		{
			Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
			List<IWeeklyRogueRolePosInfo> list = new List<IWeeklyRogueRolePosInfo>();
			for (int i = 1; i <= 3; i++)
			{
				WeeklyRogueRolePosInfo weeklyRogueRolePosInfo = new WeeklyRogueRolePosInfo();
				RoleDataBase data;
				if (roleIndexMap.TryGetValue(i, out data))
				{
					weeklyRogueRolePosInfo.Data = data;
					weeklyRogueRolePosInfo.IsRecommend = new bool?(false);
				}
				list.Add(weeklyRogueRolePosInfo);
			}
			this.TeamSlotLayout.RefreshByData(list, null, false);
		}

		// Token: 0x060378E6 RID: 227558 RVA: 0x00F87554 File Offset: 0x00F85754
		private void RefreshButtonState()
		{
			bool enableClick = RoleSelectModel.Instance.RoleIndexMap.Count > 0;
			ButtonItem startChallengeButtonItem = this.StartChallengeButtonItem;
			if (startChallengeButtonItem == null)
			{
				return;
			}
			startChallengeButtonItem.SetEnableClick(enableClick);
		}

		// Token: 0x060378E7 RID: 227559 RVA: 0x00F87588 File Offset: 0x00F85788
		private void OnClickStartChallenge(int a)
		{
			List<int> currentSelectRoleList = this.GetCurrentSelectRoleList();
			if (currentSelectRoleList.Count == 0)
			{
				ScrollingTipsController.Instance.ShowTipsById("NoRole", Array.Empty<object>());
				return;
			}
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.SWC, "[AdamSmasherFormation] 提交编队开始挑战", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiLayer.Instance.SetShowMaskLayer("AdamSmasherFormationView.StartChallenge", true);
			AdamSmasherController.Instance.RequestStartChallenge(this.StageId, currentSelectRoleList).ContinueWith(delegate(bool Result)
			{
				UiLayer.Instance.SetShowMaskLayer("AdamSmasherFormationView.StartChallenge", false);
			});
		}

		// Token: 0x060378E8 RID: 227560 RVA: 0x00F87620 File Offset: 0x00F85820
		private void OnClickRoleDetail(int a)
		{
			if (this.CurSelectRole == null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("CharacterDetailsTip", Array.Empty<object>());
				return;
			}
			int dataId = this.CurSelectRole.GetDataId();
			List<int> currentSelectRoleList = this.GetCurrentSelectRoleList();
			List<int> list = new List<int>();
			foreach (RoleDataBase roleDataBase in this.CachedOwnRoleList)
			{
				list.Add(roleDataBase.GetDataId());
			}
			List<int> list2 = new List<int>();
			foreach (int item in currentSelectRoleList)
			{
				if (list.Contains(item))
				{
					list2.Add(item);
				}
			}
			List<int> list3 = new List<int>(list2);
			foreach (int item2 in list)
			{
				if (!list2.Contains(item2))
				{
					list3.Add(item2);
				}
			}
			OpenRoleMainViewData param = new OpenRoleMainViewData
			{
				AgentType = ERoleAgentType.Normal,
				SelectRoleId = new int?(dataId),
				RoleIdList = list3,
				TeamPositionType = new ETeamPositionType?(ETeamPositionType.RoleSelect)
			};
			RoleController.Instance.OpenRoleMainViewByParam(param);
		}

		// Token: 0x060378E9 RID: 227561 RVA: 0x00F87790 File Offset: 0x00F85990
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(this.GetHelpId());
		}

		// Token: 0x060378EA RID: 227562 RVA: 0x00F877A2 File Offset: 0x00F859A2
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060378EB RID: 227563 RVA: 0x00F877AB File Offset: 0x00F859AB
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (closeActivities.Contains(CyberPunkController.Instance.CurrentActivityId))
			{
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			}
		}

		// Token: 0x060378EC RID: 227564 RVA: 0x00F877CC File Offset: 0x00F859CC
		private void RefreshTargetInfo()
		{
			CyberPunkConfig instance = CyberPunkConfig.Instance;
			EdgeRunnerLordGym? edgeRunnerLordGym = (instance != null) ? instance.GetStageConfig(this.StageId) : null;
			if (edgeRunnerLordGym == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "AdamChallenge_Level", new <>z__ReadOnlySingleElementList<object>(edgeRunnerLordGym.Value.Level));
			if (edgeRunnerLordGym.Value.BuffNumLength > 0)
			{
				string[] array = new string[edgeRunnerLordGym.Value.BuffNumLength];
				for (int i = 0; i < edgeRunnerLordGym.Value.BuffNumLength; i++)
				{
					array[i] = edgeRunnerLordGym.Value.BuffNum(i);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(6), edgeRunnerLordGym.Value.BuffDesc, array);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), edgeRunnerLordGym.Value.BuffDesc, Array.Empty<object>());
		}

		// Token: 0x060378ED RID: 227565 RVA: 0x00F878D3 File Offset: 0x00F85AD3
		private int GetHelpId()
		{
			return 0;
		}

		// Token: 0x0401D4E5 RID: 120037
		public const int FORMATION_MAX_NUM = 3;

		// Token: 0x0401D4E6 RID: 120038
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D4E7 RID: 120039
		[Nullable(2)]
		private ButtonItem RoleDetailButtonItem;

		// Token: 0x0401D4E8 RID: 120040
		[Nullable(2)]
		private ButtonItem StartChallengeButtonItem;

		// Token: 0x0401D4E9 RID: 120041
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterSortEntrance<RoleDataBase> FilterSortEntranceItem;

		// Token: 0x0401D4EA RID: 120042
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		protected DynamicScrollView<AdamFormationRoleContainer, AdamFormationRoleSizeItem, AdamFormationRoleGroupInfo> DynamicRoleGroupLayout;

		// Token: 0x0401D4EB RID: 120043
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<WeeklyRogueRolePosItem, IWeeklyRogueRolePosInfo> TeamSlotLayout;

		// Token: 0x0401D4EC RID: 120044
		private List<RoleDataBase> AllRoleList = new List<RoleDataBase>();

		// Token: 0x0401D4ED RID: 120045
		private readonly List<RoleDataBase> CachedTrialRoleList = new List<RoleDataBase>();

		// Token: 0x0401D4EE RID: 120046
		private List<RoleDataBase> CachedOwnRoleList = new List<RoleDataBase>();

		// Token: 0x0401D4EF RID: 120047
		private HashSet<int> RecommendedRoleIdSet = new HashSet<int>();

		// Token: 0x0401D4F0 RID: 120048
		private int StageId;

		// Token: 0x0401D4F1 RID: 120049
		[Nullable(2)]
		private RoleDataBase CurSelectRole;

		// Token: 0x0200B437 RID: 46135
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037BE1 RID: 228321
			Caption,
			// Token: 0x04037BE2 RID: 228322
			DynamicGroupLayout,
			// Token: 0x04037BE3 RID: 228323
			DynamicGroupItem,
			// Token: 0x04037BE4 RID: 228324
			FilterSortItem,
			// Token: 0x04037BE5 RID: 228325
			BossNameText,
			// Token: 0x04037BE6 RID: 228326
			BossLevelText,
			// Token: 0x04037BE7 RID: 228327
			BuffDescText,
			// Token: 0x04037BE8 RID: 228328
			RoleListLayout,
			// Token: 0x04037BE9 RID: 228329
			RoleListGroupItem,
			// Token: 0x04037BEA RID: 228330
			BtnRoleDetail,
			// Token: 0x04037BEB RID: 228331
			BtnStartChallenge
		}
	}
}
