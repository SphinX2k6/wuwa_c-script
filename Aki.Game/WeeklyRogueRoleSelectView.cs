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

// Token: 0x020022AF RID: 8879
[NullableContext(1)]
[Nullable(0)]
public class WeeklyRogueRoleSelectView : UiViewBase
{
	// Token: 0x06015EC6 RID: 89798 RVA: 0x0065B2E4 File Offset: 0x006594E4
	public WeeklyRogueRoleSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015EC7 RID: 89799 RVA: 0x0065B2F8 File Offset: 0x006594F8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIDynScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUISprite)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem))
		};
	}

	// Token: 0x06015EC8 RID: 89800 RVA: 0x0065B460 File Offset: 0x00659660
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueRoleSelectView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueRoleSelectView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015EC9 RID: 89801 RVA: 0x0065B4A4 File Offset: 0x006596A4
	protected override void OnStart()
	{
		WeeklyRogueData activityDataNew = WeeklyRogueModel.Instance.ActivityDataNew;
		RogueWeeklyCycle value = activityDataNew.GetCycleConfig().Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), value.BuffDesc, value.BuffDescParam());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "WeRougeFormationMonsterLevel", new <>z__ReadOnlySingleElementList<object>(activityDataNew.GetLvInfo()));
		this.FilterSortEntrance.UpdateData(EFilterSortGroupId.WeeklyRogueEditFormation, this.RoleList, Array.Empty<object>());
	}

	// Token: 0x06015ECA RID: 89802 RVA: 0x0065B528 File Offset: 0x00659728
	protected override void OnBeforeDestroy()
	{
		if (EventSystem.Instance.Has<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView)))
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}
		WeeklyRogueModel.Instance.SelectRoleIdList.Clear();
		FilterSortEntrance<RoleDataBase> filterSortEntrance = this.FilterSortEntrance;
		if (filterSortEntrance != null)
		{
			filterSortEntrance.Destroy(null);
		}
		this.FilterSortEntrance = null;
	}

	// Token: 0x06015ECB RID: 89803 RVA: 0x0065B590 File Offset: 0x00659790
	private void OnClickConfirm(int _)
	{
		List<int> currentSelectRoleList = this.GetCurrentSelectRoleList();
		if (currentSelectRoleList.Count == 0)
		{
			ScrollingTipsController.Instance.ShowTipsById("NoRole", Array.Empty<object>());
			return;
		}
		WeeklyRogueModel.Instance.SelectRoleIdList = currentSelectRoleList;
		UiLayer.Instance.SetShowMaskLayer("WeeklyRogueRoleSelectView.RogueWeeklyArtifactSelectStart", true);
		WeeklyRogueController.Instance.RogueWeeklyArtifactSelectStartRequest().ContinueWith(delegate()
		{
			UiLayer.Instance.SetShowMaskLayer("WeeklyRogueRoleSelectView.RogueWeeklyArtifactSelectStart", false);
		}).Forget();
	}

	// Token: 0x06015ECC RID: 89804 RVA: 0x0065B610 File Offset: 0x00659810
	private void OnClickRoleDetail(int _)
	{
		if (this.CurSelectRole == null)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("CharacterDetailsTip", Array.Empty<object>());
			return;
		}
		bool flag = this.CurSelectRole.IsTrialRole();
		int dataId = this.CurSelectRole.GetDataId();
		List<int> currentSelectRoleList = this.GetCurrentSelectRoleList();
		List<int> list = new List<int>
		{
			dataId
		};
		if (!flag)
		{
			list = new List<int>(currentSelectRoleList);
			foreach (RoleDataBase roleDataBase in this.RoleList)
			{
				if (!roleDataBase.IsTrialRole() && !currentSelectRoleList.Contains(roleDataBase.GetDataId()))
				{
					list.Add(roleDataBase.GetDataId());
				}
			}
		}
		OpenRoleMainViewData param = new OpenRoleMainViewData
		{
			AgentType = ERoleAgentType.Normal,
			SelectRoleId = new int?(dataId),
			RoleIdList = list,
			TeamPositionType = new ETeamPositionType?(ETeamPositionType.RoleSelect)
		};
		RoleController.Instance.OpenRoleMainViewByParam(param);
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		RoleModel.Instance.StartRecordRoleSkillBranchChangeRequest();
	}

	// Token: 0x06015ECD RID: 89805 RVA: 0x0065B730 File Offset: 0x00659930
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.RoleRootView)
		{
			return;
		}
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		List<int> list = RoleModel.Instance.StopRecordRoleSkillBranchChangeRequest();
		if (list.Count <= 0)
		{
			return;
		}
		foreach (int roleId in list)
		{
			DynamicScrollView<WeeklyRogueRoleDynamicContainer, WeeklyRogueRoleDynamicItem, IWeeklyRogueRoleGroupInfo> dynamicRoleGroupLayout = this.DynamicRoleGroupLayout;
			WeeklyRogueRoleDynamicContainer[] array = ((dynamicRoleGroupLayout != null) ? dynamicRoleGroupLayout.GetScrollItemItems() : null) ?? Array.Empty<WeeklyRogueRoleDynamicContainer>();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].RefreshRoleByRoleId(roleId);
			}
		}
		this.RefreshTeamSelect();
	}

	// Token: 0x06015ECE RID: 89806 RVA: 0x0065B7F4 File Offset: 0x006599F4
	private void OnBtnHelpBtn()
	{
		WeeklyRogueData activityDataNew = WeeklyRogueModel.Instance.ActivityDataNew;
		RogueWeeklyCycle? rogueWeeklyCycle = (activityDataNew != null) ? activityDataNew.GetCycleConfig() : null;
		HelpController.Instance.OpenHelpById(rogueWeeklyCycle.Value.HelpId);
	}

	// Token: 0x06015ECF RID: 89807 RVA: 0x0065B83C File Offset: 0x00659A3C
	private UniTask InitRoleGroupLayout()
	{
		WeeklyRogueRoleSelectView.<InitRoleGroupLayout>d__18 <InitRoleGroupLayout>d__;
		<InitRoleGroupLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleGroupLayout>d__.<>4__this = this;
		<InitRoleGroupLayout>d__.<>1__state = -1;
		<InitRoleGroupLayout>d__.<>t__builder.Start<WeeklyRogueRoleSelectView.<InitRoleGroupLayout>d__18>(ref <InitRoleGroupLayout>d__);
		return <InitRoleGroupLayout>d__.<>t__builder.Task;
	}

	// Token: 0x06015ED0 RID: 89808 RVA: 0x0065B880 File Offset: 0x00659A80
	private List<IWeeklyRogueRoleGroupInfo> GenerateAllRoleGroupInfo([Nullable(new byte[]
	{
		2,
		1
	})] List<RoleDataBase> roleList = null)
	{
		List<RoleDataBase> wholeRoleList = roleList ?? this.RoleList;
		List<IWeeklyRogueRoleGroupInfo> list = new List<IWeeklyRogueRoleGroupInfo>();
		List<RoleDataBase> classifiedRoleList = this.GetClassifiedRoleList(wholeRoleList, true);
		bool flag = classifiedRoleList.Count == 0;
		WeeklyRogueRoleGroupTitleInfo weeklyRogueRoleGroupTitleInfo = new WeeklyRogueRoleGroupTitleInfo();
		weeklyRogueRoleGroupTitleInfo.TitleId = "WeRougeFormationRecommendedRole";
		weeklyRogueRoleGroupTitleInfo.IsUp = true;
		WeeklyRogueData activityDataNew = WeeklyRogueModel.Instance.ActivityDataNew;
		weeklyRogueRoleGroupTitleInfo.ScoreRate = ((activityDataNew != null) ? new int?(activityDataNew.GetScoreRate()) : null);
		weeklyRogueRoleGroupTitleInfo.IsEmpty = (classifiedRoleList.Count == 0);
		WeeklyRogueRoleGroupTitleInfo titleInfo = weeklyRogueRoleGroupTitleInfo;
		WeeklyRogueRoleGroupInfo item = new WeeklyRogueRoleGroupInfo
		{
			IsTitleType = true,
			TitleInfo = titleInfo
		};
		list.Add(item);
		if (!flag)
		{
			WeeklyRogueRoleGroupInfo item2 = new WeeklyRogueRoleGroupInfo
			{
				IsTitleType = false,
				DataList = classifiedRoleList
			};
			list.Add(item2);
		}
		List<RoleDataBase> classifiedRoleList2 = this.GetClassifiedRoleList(wholeRoleList, false);
		bool flag2 = classifiedRoleList2.Count == 0;
		WeeklyRogueRoleGroupTitleInfo titleInfo2 = new WeeklyRogueRoleGroupTitleInfo
		{
			TitleId = "WeRougeFormationOtherRole",
			IsUp = false,
			IsEmpty = flag2
		};
		WeeklyRogueRoleGroupInfo item3 = new WeeklyRogueRoleGroupInfo
		{
			IsTitleType = true,
			TitleInfo = titleInfo2
		};
		list.Add(item3);
		if (!flag2)
		{
			WeeklyRogueRoleGroupInfo item4 = new WeeklyRogueRoleGroupInfo
			{
				IsTitleType = false,
				DataList = classifiedRoleList2
			};
			list.Add(item4);
		}
		return list;
	}

	// Token: 0x06015ED1 RID: 89809 RVA: 0x0065B9B8 File Offset: 0x00659BB8
	private List<RoleDataBase> GetClassifiedRoleList(List<RoleDataBase> wholeRoleList, bool needRecommend)
	{
		List<RoleDataBase> list = new List<RoleDataBase>();
		foreach (RoleDataBase roleDataBase in wholeRoleList)
		{
			bool flag = WeeklyRogueModel.Instance.CheckIsRecommendRole(roleDataBase.GetDataId());
			if (needRecommend == flag)
			{
				list.Add(roleDataBase);
			}
		}
		List<ValueTuple<RoleDataBase, int>> list2 = new List<ValueTuple<RoleDataBase, int>>();
		for (int i = 0; i < list.Count; i++)
		{
			list2.Add(new ValueTuple<RoleDataBase, int>(list[i], i));
		}
		list2.Sort(delegate([TupleElementNames(new string[]
		{
			"Role",
			"Index"
		})] [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<RoleDataBase, int> a, [TupleElementNames(new string[]
		{
			"Role",
			"Index"
		})] [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<RoleDataBase, int> b)
		{
			int num = (a.Item1.IsTrialRole() > false) ? 1 : 0;
			int num2 = (b.Item1.IsTrialRole() > false) ? 1 : 0;
			int num3 = num - num2;
			if (num3 == 0)
			{
				return a.Item2 - b.Item2;
			}
			return num3;
		});
		list.Clear();
		foreach (ValueTuple<RoleDataBase, int> valueTuple in list2)
		{
			list.Add(valueTuple.Item1);
		}
		return list;
	}

	// Token: 0x06015ED2 RID: 89810 RVA: 0x0065BAC4 File Offset: 0x00659CC4
	private void UpdateRoleList(List<RoleDataBase> list, bool _1, EFilterSortType _2)
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		List<RoleDataBase> list2 = new List<RoleDataBase>();
		for (int i = 1; i <= 3; i++)
		{
			if (roleIndexMap.ContainsKey(i))
			{
				list2.Add(roleIndexMap[i]);
			}
		}
		foreach (RoleDataBase roleDataBase in list)
		{
			if (roleDataBase != null && !list2.Contains(roleDataBase))
			{
				list2.Add(roleDataBase);
			}
		}
		this.DynamicRoleGroupLayout.RefreshByData(this.GenerateAllRoleGroupInfo(list2).ToArray(), false, false);
	}

	// Token: 0x06015ED3 RID: 89811 RVA: 0x0065BB70 File Offset: 0x00659D70
	private WeeklyRogueRoleDynamicContainer OnCreateRoleGroup(IWeeklyRogueRoleGroupInfo _1, UUIItem _2, int _3)
	{
		return new WeeklyRogueRoleDynamicContainer
		{
			RefreshRole = new Action<RoleDataBase>(this.RefreshRoleSelect)
		};
	}

	// Token: 0x06015ED4 RID: 89812 RVA: 0x0065BB89 File Offset: 0x00659D89
	private void RefreshRoleSelect(RoleDataBase roleData)
	{
		this.CurSelectRole = roleData;
		this.RefreshTeamSelect();
	}

	// Token: 0x06015ED5 RID: 89813 RVA: 0x0065BB98 File Offset: 0x00659D98
	private WeeklyRogueRolePosItem OnCreatePos()
	{
		return new WeeklyRogueRolePosItem
		{
			OnBtnClickFunc = new Action<RoleDataBase>(this.OnBtnRolePosClick)
		};
	}

	// Token: 0x06015ED6 RID: 89814 RVA: 0x0065BBB4 File Offset: 0x00659DB4
	[NullableContext(2)]
	private void OnBtnRolePosClick(RoleDataBase data)
	{
		if (data == null)
		{
			return;
		}
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
		foreach (KeyValuePair<int, RoleDataBase> keyValuePair in new Dictionary<int, RoleDataBase>(roleIndexMap))
		{
			if (keyValuePair.Value == data)
			{
				roleIndexMap.Remove(keyValuePair.Key);
				selectedRoleSet.Remove(data.GetDataId());
				break;
			}
		}
		WeeklyRogueRoleDynamicContainer[] scrollItemItems = this.DynamicRoleGroupLayout.GetScrollItemItems();
		for (int i = 0; i < scrollItemItems.Length; i++)
		{
			scrollItemItems[i].Refresh();
		}
		this.RefreshTeamSelect();
	}

	// Token: 0x06015ED7 RID: 89815 RVA: 0x0065BC74 File Offset: 0x00659E74
	private List<int> GetCurrentSelectRoleList()
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		List<int> list = new List<int>();
		for (int i = 1; i <= 3; i++)
		{
			RoleDataBase roleDataBase;
			if (roleIndexMap.TryGetValue(i, out roleDataBase))
			{
				int dataId = roleDataBase.GetDataId();
				list.Add(dataId);
			}
		}
		return list;
	}

	// Token: 0x06015ED8 RID: 89816 RVA: 0x0065BCBC File Offset: 0x00659EBC
	private void RefreshTeamSelect()
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		bool flag = false;
		List<IWeeklyRogueRolePosInfo> list = new List<IWeeklyRogueRolePosInfo>();
		for (int i = 1; i <= 3; i++)
		{
			WeeklyRogueRolePosInfo weeklyRogueRolePosInfo = new WeeklyRogueRolePosInfo();
			RoleDataBase data;
			if (roleIndexMap.TryGetValue(i, out data))
			{
				weeklyRogueRolePosInfo.Data = data;
				weeklyRogueRolePosInfo.IsRecommend = new bool?(WeeklyRogueModel.Instance.CheckIsRecommendRole(weeklyRogueRolePosInfo.Data.GetDataId()));
				if (!flag && weeklyRogueRolePosInfo.IsRecommend.GetValueOrDefault())
				{
					flag = true;
				}
			}
			list.Add(weeklyRogueRolePosInfo);
		}
		this.TeamPosLayout.RefreshByData(list, null, false);
		this.SetUpState(flag);
	}

	// Token: 0x06015ED9 RID: 89817 RVA: 0x0065BD5C File Offset: 0x00659F5C
	private void SetUpState(bool bUp)
	{
		WeeklyRogueData activityDataNew = WeeklyRogueModel.Instance.ActivityDataNew;
		if (activityDataNew == null)
		{
			return;
		}
		RogueWeeklyCycle? cycleConfig = activityDataNew.GetCycleConfig();
		if (cycleConfig == null)
		{
			return;
		}
		int scoreRate = activityDataNew.GetScoreRate();
		int num = bUp ? cycleConfig.Value.MaxScore : cycleConfig.Value.BaseScore;
		base.GetItem(9).SetUIActive(true);
		UUISprite sprite = base.GetSprite(10);
		UUIItem uuiitem = sprite;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(bUp, fcolor);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "WeRougeFormationIntegralMultiplier", new <>z__ReadOnlySingleElementList<object>(scoreRate));
		UUIText text = base.GetText(3);
		text.SetText(num.ToString(), true);
		UUIItem uuiitem2 = text;
		fcolor = new FColor?(text.changeColor);
		uuiitem2.SetChangeColor(bUp, fcolor);
		base.GetItem(4).SetUIActive(bUp);
	}

	// Token: 0x0400B861 RID: 47201
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400B862 RID: 47202
	[Nullable(2)]
	private ButtonItem ButtonConfirm;

	// Token: 0x0400B863 RID: 47203
	[Nullable(2)]
	private ButtonItem ButtonRoleDetail;

	// Token: 0x0400B864 RID: 47204
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	protected DynamicScrollView<WeeklyRogueRoleDynamicContainer, WeeklyRogueRoleDynamicItem, IWeeklyRogueRoleGroupInfo> DynamicRoleGroupLayout;

	// Token: 0x0400B865 RID: 47205
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeeklyRogueRolePosItem, IWeeklyRogueRolePosInfo> TeamPosLayout;

	// Token: 0x0400B866 RID: 47206
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x0400B867 RID: 47207
	private List<RoleDataBase> RoleList = new List<RoleDataBase>();

	// Token: 0x0400B868 RID: 47208
	[Nullable(2)]
	private RoleDataBase CurSelectRole;

	// Token: 0x02008512 RID: 34066
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402AE4C RID: 175692
		CaptionItem,
		// Token: 0x0402AE4D RID: 175693
		DynamicGroupLayout,
		// Token: 0x0402AE4E RID: 175694
		DynamicGroupItem,
		// Token: 0x0402AE4F RID: 175695
		TxtScore,
		// Token: 0x0402AE50 RID: 175696
		ScoreUpItem,
		// Token: 0x0402AE51 RID: 175697
		TxtEnvironmentLv,
		// Token: 0x0402AE52 RID: 175698
		TxtEnvironment,
		// Token: 0x0402AE53 RID: 175699
		RoleLayout,
		// Token: 0x0402AE54 RID: 175700
		RolePosItem,
		// Token: 0x0402AE55 RID: 175701
		PanelTag,
		// Token: 0x0402AE56 RID: 175702
		SpriteTag,
		// Token: 0x0402AE57 RID: 175703
		TxtTag,
		// Token: 0x0402AE58 RID: 175704
		BtnDetail,
		// Token: 0x0402AE59 RID: 175705
		BtnConfirm,
		// Token: 0x0402AE5A RID: 175706
		FilterSortItem
	}
}
