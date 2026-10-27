using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x020068A3 RID: 26787
	[NullableContext(1)]
	[Nullable(0)]
	public class AdamSmasherFormationView : UiViewBase
	{
		// Token: 0x06042D7D RID: 273789 RVA: 0x0104594C File Offset: 0x01043B4C
		public AdamSmasherFormationView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042D7E RID: 273790 RVA: 0x01045984 File Offset: 0x01043B84
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

		// Token: 0x06042D7F RID: 273791 RVA: 0x01045A90 File Offset: 0x01043C90
		protected override UniTask OnBeforeStartAsync()
		{
			AdamSmasherFormationView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AdamSmasherFormationView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042D80 RID: 273792 RVA: 0x01045AD3 File Offset: 0x01043CD3
		protected override void OnStart()
		{
			this.FilterSortEntranceItem.UpdateData(EFilterSortGroupId.EditBattleTeam, this.AllRoleList, Array.Empty<object>());
			this.OnFilterSortUpdate(this.AllRoleList, false, EFilterSortType.Sort);
			this.DynamicRoleGroupLayout.LateScrollTo(0);
			this.RefreshTargetInfo();
			this.RefreshButtonState();
		}

		// Token: 0x06042D81 RID: 273793 RVA: 0x01045B12 File Offset: 0x01043D12
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x06042D82 RID: 273794 RVA: 0x01045B30 File Offset: 0x01043D30
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x06042D83 RID: 273795 RVA: 0x01045B4E File Offset: 0x01043D4E
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

		// Token: 0x06042D84 RID: 273796 RVA: 0x01045B74 File Offset: 0x01043D74
		private UniTask InitRoleGroupLayout()
		{
			AdamSmasherFormationView.<InitRoleGroupLayout>d__21 <InitRoleGroupLayout>d__;
			<InitRoleGroupLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleGroupLayout>d__.<>4__this = this;
			<InitRoleGroupLayout>d__.<>1__state = -1;
			<InitRoleGroupLayout>d__.<>t__builder.Start<AdamSmasherFormationView.<InitRoleGroupLayout>d__21>(ref <InitRoleGroupLayout>d__);
			return <InitRoleGroupLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06042D85 RID: 273797 RVA: 0x01045BB8 File Offset: 0x01043DB8
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

		// Token: 0x06042D86 RID: 273798 RVA: 0x01045CB0 File Offset: 0x01043EB0
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

		// Token: 0x06042D87 RID: 273799 RVA: 0x01045D64 File Offset: 0x01043F64
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

		// Token: 0x06042D88 RID: 273800 RVA: 0x01045E04 File Offset: 0x01044004
		private AdamFormationRoleContainer OnCreateRoleGroup(AdamFormationRoleGroupInfo data, UUIItem uiItem, int index)
		{
			return new AdamFormationRoleContainer
			{
				RefreshRole = new Action<RoleDataBase>(this.RefreshRoleSelect),
				RecommendedRoleIdSet = this.RecommendedRoleIdSet
			};
		}

		// Token: 0x06042D89 RID: 273801 RVA: 0x01045E29 File Offset: 0x01044029
		private void RefreshRoleSelect(RoleDataBase roleData)
		{
			this.CurSelectRole = roleData;
			this.RefreshTeamSelect();
			this.RefreshButtonState();
		}

		// Token: 0x06042D8A RID: 273802 RVA: 0x01045E3E File Offset: 0x0104403E
		private WeeklyRogueRolePosItem CreateTeamSlotItem()
		{
			return new WeeklyRogueRolePosItem
			{
				OnBtnClickFunc = new Action<RoleDataBase>(this.OnBtnRolePosClick)
			};
		}

		// Token: 0x06042D8B RID: 273803 RVA: 0x01045E58 File Offset: 0x01044058
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

		// Token: 0x06042D8C RID: 273804 RVA: 0x01045F18 File Offset: 0x01044118
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

		// Token: 0x06042D8D RID: 273805 RVA: 0x01045F5C File Offset: 0x0104415C
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

		// Token: 0x06042D8E RID: 273806 RVA: 0x01045FC0 File Offset: 0x010441C0
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

		// Token: 0x06042D8F RID: 273807 RVA: 0x01045FF4 File Offset: 0x010441F4
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

		// Token: 0x06042D90 RID: 273808 RVA: 0x0104608C File Offset: 0x0104428C
		private void OnClickRoleDetail(int a)
		{
			if (this.CurSelectRole == null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("CharacterDetailsTip", Array.Empty<object>());
				return;
			}
			int dataId = this.CurSelectRole.GetDataId();
			List<int> currentSelectRoleList = this.GetCurrentSelectRoleList();
			List<int> ownedRoleIds = (from role in this.CachedOwnRoleList
			select role.GetDataId()).ToList<int>();
			List<int> ownedSelectedFirst = (from id in currentSelectRoleList
			where ownedRoleIds.Contains(id)
			select id).ToList<int>();
			List<int> list = new List<int>(ownedSelectedFirst);
			list.AddRange(from id in ownedRoleIds
			where !ownedSelectedFirst.Contains(id)
			select id);
			OpenRoleMainViewData param = new OpenRoleMainViewData
			{
				AgentType = ERoleAgentType.Normal,
				SelectRoleId = new int?(dataId),
				RoleIdList = list,
				TeamPositionType = new ETeamPositionType?(ETeamPositionType.RoleSelect)
			};
			RoleController.Instance.OpenRoleMainViewByParam(param);
		}

		// Token: 0x06042D91 RID: 273809 RVA: 0x01046183 File Offset: 0x01044383
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(this.GetHelpId());
		}

		// Token: 0x06042D92 RID: 273810 RVA: 0x01046195 File Offset: 0x01044395
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06042D93 RID: 273811 RVA: 0x0104619E File Offset: 0x0104439E
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (closeActivities.Contains(CyberPunkController.Instance.CurrentActivityId))
			{
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			}
		}

		// Token: 0x06042D94 RID: 273812 RVA: 0x010461BC File Offset: 0x010443BC
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

		// Token: 0x06042D95 RID: 273813 RVA: 0x010462C3 File Offset: 0x010444C3
		private int GetHelpId()
		{
			return 0;
		}

		// Token: 0x04022C89 RID: 142473
		public const int FORMATION_MAX_NUM = 3;

		// Token: 0x04022C8A RID: 142474
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022C8B RID: 142475
		[Nullable(2)]
		private ButtonItem RoleDetailButtonItem;

		// Token: 0x04022C8C RID: 142476
		[Nullable(2)]
		private ButtonItem StartChallengeButtonItem;

		// Token: 0x04022C8D RID: 142477
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterSortEntrance<RoleDataBase> FilterSortEntranceItem;

		// Token: 0x04022C8E RID: 142478
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		protected DynamicScrollView<AdamFormationRoleContainer, AdamFormationRoleSizeItem, AdamFormationRoleGroupInfo> DynamicRoleGroupLayout;

		// Token: 0x04022C8F RID: 142479
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<WeeklyRogueRolePosItem, IWeeklyRogueRolePosInfo> TeamSlotLayout;

		// Token: 0x04022C90 RID: 142480
		private List<RoleDataBase> AllRoleList = new List<RoleDataBase>();

		// Token: 0x04022C91 RID: 142481
		private readonly List<RoleDataBase> CachedTrialRoleList = new List<RoleDataBase>();

		// Token: 0x04022C92 RID: 142482
		private List<RoleDataBase> CachedOwnRoleList = new List<RoleDataBase>();

		// Token: 0x04022C93 RID: 142483
		private HashSet<int> RecommendedRoleIdSet = new HashSet<int>();

		// Token: 0x04022C94 RID: 142484
		private int StageId;

		// Token: 0x04022C95 RID: 142485
		[Nullable(2)]
		private RoleDataBase CurSelectRole;

		// Token: 0x0200CA6E RID: 51822
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403D303 RID: 250627
			Caption,
			// Token: 0x0403D304 RID: 250628
			DynamicGroupLayout,
			// Token: 0x0403D305 RID: 250629
			DynamicGroupItem,
			// Token: 0x0403D306 RID: 250630
			FilterSortItem,
			// Token: 0x0403D307 RID: 250631
			BossNameText,
			// Token: 0x0403D308 RID: 250632
			BossLevelText,
			// Token: 0x0403D309 RID: 250633
			BuffDescText,
			// Token: 0x0403D30A RID: 250634
			RoleListLayout,
			// Token: 0x0403D30B RID: 250635
			RoleListGroupItem,
			// Token: 0x0403D30C RID: 250636
			BtnRoleDetail,
			// Token: 0x0403D30D RID: 250637
			BtnStartChallenge
		}
	}
}
