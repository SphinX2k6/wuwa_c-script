using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002D39 RID: 11577
[NullableContext(1)]
[Nullable(0)]
public class WeeklyRogueRoleDynamicContainer : UiPanelBase, IDynamicScrollItem<IWeeklyRogueRoleGroupInfo>
{
	// Token: 0x0601855F RID: 99679 RVA: 0x00631C18 File Offset: 0x0062FE18
	public UniTask Init(UUIItem actor)
	{
		WeeklyRogueRoleDynamicContainer.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<WeeklyRogueRoleDynamicContainer.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06018560 RID: 99680 RVA: 0x00631C63 File Offset: 0x0062FE63
	public void ClearItem()
	{
	}

	// Token: 0x06018561 RID: 99681 RVA: 0x00631C65 File Offset: 0x0062FE65
	public AUIBaseActor GetUsingItem(IWeeklyRogueRoleGroupInfo data)
	{
		if (data.IsTitleType)
		{
			return (AUIBaseActor)base.GetItem(2).GetOwner();
		}
		return (AUIBaseActor)base.GetGridLayout(0).GetOwner();
	}

	// Token: 0x06018562 RID: 99682 RVA: 0x00631C92 File Offset: 0x0062FE92
	public void Update(IWeeklyRogueRoleGroupInfo data, int index)
	{
		this.Data = data;
		if (data.IsTitleType)
		{
			this.RefreshTitle(this.Data);
			return;
		}
		this.RefreshRoleList(this.Data);
	}

	// Token: 0x06018563 RID: 99683 RVA: 0x00631CBC File Offset: 0x0062FEBC
	public void InitData(IWeeklyRogueRoleGroupInfo data)
	{
		this.Data = data;
	}

	// Token: 0x06018564 RID: 99684 RVA: 0x00631CC5 File Offset: 0x0062FEC5
	public void Refresh()
	{
		if (this.Data.IsTitleType)
		{
			this.RefreshTitle(this.Data);
			return;
		}
		GenericLayout<WeeklyRogueRoleGridItem, RoleDataBase> roleLayout = this.RoleLayout;
		if (roleLayout == null)
		{
			return;
		}
		roleLayout.RefreshWithoutDataSync();
	}

	// Token: 0x06018565 RID: 99685 RVA: 0x00631CF4 File Offset: 0x0062FEF4
	public void RefreshRoleByRoleId(int roleId)
	{
		if (this.Data.IsTitleType || this.RoleLayout == null)
		{
			return;
		}
		List<RoleDataBase> dataList = this.Data.DataList;
		RoleDataBase roleDataBase = (dataList != null) ? dataList.Find((RoleDataBase role) => role.GetDataId() == roleId) : null;
		if (roleDataBase == null)
		{
			return;
		}
		WeeklyRogueRoleGridItem layoutItemByKey = this.RoleLayout.GetLayoutItemByKey(roleId);
		if (layoutItemByKey == null)
		{
			return;
		}
		bool isSelected = RoleSelectModel.Instance.SelectedRoleSet.Contains(roleId);
		int gridIndex = this.Data.DataList.IndexOf(roleDataBase);
		layoutItemByKey.Refresh(roleDataBase, isSelected, gridIndex);
	}

	// Token: 0x06018566 RID: 99686 RVA: 0x00631D9C File Offset: 0x0062FF9C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x06018567 RID: 99687 RVA: 0x00631E50 File Offset: 0x00630050
	protected override void OnStart()
	{
		base.GetItem(2).SetUIActive(false);
		base.GetGridLayout(0).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06018568 RID: 99688 RVA: 0x00631E84 File Offset: 0x00630084
	private void RefreshTitle(IWeeklyRogueRoleGroupInfo info)
	{
		base.GetGridLayout(0).RootUIComp.Get().SetUIActive(false);
		IWeeklyRogueRoleGroupTitleInfo titleInfo = info.TitleInfo;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), titleInfo.TitleId, Array.Empty<object>());
		base.GetItem(4).SetUIActive(titleInfo.IsUp);
		if (titleInfo.IsUp)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "WeRougeFormationIntegralMultiplier", new <>z__ReadOnlySingleElementList<object>(titleInfo.ScoreRate));
		}
		base.GetItem(6).SetUIActive(titleInfo.IsEmpty);
		base.GetItem(2).SetUIActive(true);
	}

	// Token: 0x06018569 RID: 99689 RVA: 0x00631F30 File Offset: 0x00630130
	private void RefreshRoleList(IWeeklyRogueRoleGroupInfo info)
	{
		WeeklyRogueRoleDynamicContainer.<>c__DisplayClass14_0 CS$<>8__locals1 = new WeeklyRogueRoleDynamicContainer.<>c__DisplayClass14_0();
		CS$<>8__locals1.<>4__this = this;
		base.GetItem(2).SetUIActive(false);
		if (this.RoleLayout == null)
		{
			this.RoleLayout = new GenericLayout<WeeklyRogueRoleGridItem, RoleDataBase>(base.GetGridLayout(0), new Func<WeeklyRogueRoleGridItem>(this.OnCreateRole), null, false, true);
		}
		CS$<>8__locals1.newDataList = info.DataList;
		bool flag = CS$<>8__locals1.newDataList.Count > 0;
		this.RoleLayout.GetRootUiItem().SetUIActive(flag);
		if (flag)
		{
			this.RoleLayout.RefreshByData(CS$<>8__locals1.newDataList, new Action(CS$<>8__locals1.<RefreshRoleList>g__RefreshSelectOn|0), true);
		}
	}

	// Token: 0x0601856A RID: 99690 RVA: 0x00631FCD File Offset: 0x006301CD
	private WeeklyRogueRoleGridItem OnCreateRole()
	{
		WeeklyRogueRoleGridItem weeklyRogueRoleGridItem = new WeeklyRogueRoleGridItem();
		weeklyRogueRoleGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		weeklyRogueRoleGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return weeklyRogueRoleGridItem;
	}

	// Token: 0x0601856B RID: 99691 RVA: 0x00631FF8 File Offset: 0x006301F8
	protected void ToggleFunction(MediumItemGridExtendCallback @params)
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
		RoleDataBase roleDataBase = (RoleDataBase)@params.Data;
		if (@params.State == EToggleState.ETT_UnChecked)
		{
			using (Dictionary<int, RoleDataBase>.Enumerator enumerator = roleIndexMap.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, RoleDataBase> keyValuePair = enumerator.Current;
					if (keyValuePair.Value == roleDataBase)
					{
						roleIndexMap.Remove(keyValuePair.Key);
						selectedRoleSet.Remove(roleDataBase.GetDataId());
						break;
					}
				}
				goto IL_B7;
			}
		}
		if (@params.State == EToggleState.ETT_Checked)
		{
			for (int i = 1; i <= 3; i++)
			{
				if (!roleIndexMap.ContainsKey(i))
				{
					roleIndexMap[i] = roleDataBase;
					selectedRoleSet.Add(roleDataBase.GetDataId());
					break;
				}
			}
		}
		IL_B7:
		GenericLayout<WeeklyRogueRoleGridItem, RoleDataBase> roleLayout = this.RoleLayout;
		if (roleLayout != null)
		{
			roleLayout.RefreshWithoutDataSync();
		}
		Action<RoleDataBase> refreshRole = this.RefreshRole;
		if (refreshRole == null)
		{
			return;
		}
		refreshRole(roleDataBase);
	}

	// Token: 0x0601856C RID: 99692 RVA: 0x006320F0 File Offset: 0x006302F0
	protected bool CanExecuteChangeFunction(object data, bool isForceSelected, EToggleState state)
	{
		if (((RoleDataBase)data).IsTrialRole())
		{
			return false;
		}
		if (state != EToggleState.ETT_UnChecked)
		{
			return true;
		}
		if (RoleSelectModel.Instance.RoleIndexMap.Count >= 3)
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamRoleFull", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x0400B4B4 RID: 46260
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleDataBase> RefreshRole;

	// Token: 0x0400B4B5 RID: 46261
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeeklyRogueRoleGridItem, RoleDataBase> RoleLayout;

	// Token: 0x0400B4B6 RID: 46262
	private IWeeklyRogueRoleGroupInfo Data;

	// Token: 0x0400B4B7 RID: 46263
	private List<RoleDataBase> RoleDataList = new List<RoleDataBase>();
}
