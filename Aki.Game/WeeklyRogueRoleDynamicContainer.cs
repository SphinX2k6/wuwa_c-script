using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002293 RID: 8851
[NullableContext(1)]
[Nullable(0)]
public class WeeklyRogueRoleDynamicContainer : UiPanelBase, IDynamicScrollItem<IWeeklyRogueRoleGroupInfo>
{
	// Token: 0x06015E01 RID: 89601 RVA: 0x00657C28 File Offset: 0x00655E28
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

	// Token: 0x06015E02 RID: 89602 RVA: 0x00657C73 File Offset: 0x00655E73
	public void ClearItem()
	{
	}

	// Token: 0x06015E03 RID: 89603 RVA: 0x00657C75 File Offset: 0x00655E75
	public AUIBaseActor GetUsingItem(IWeeklyRogueRoleGroupInfo data)
	{
		if (data.IsTitleType)
		{
			return (AUIBaseActor)base.GetItem(2).GetOwner();
		}
		return (AUIBaseActor)base.GetGridLayout(0).GetOwner();
	}

	// Token: 0x06015E04 RID: 89604 RVA: 0x00657CA2 File Offset: 0x00655EA2
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

	// Token: 0x06015E05 RID: 89605 RVA: 0x00657CCC File Offset: 0x00655ECC
	public void InitData(IWeeklyRogueRoleGroupInfo data)
	{
		this.Data = data;
	}

	// Token: 0x06015E06 RID: 89606 RVA: 0x00657CD5 File Offset: 0x00655ED5
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

	// Token: 0x06015E07 RID: 89607 RVA: 0x00657D04 File Offset: 0x00655F04
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

	// Token: 0x06015E08 RID: 89608 RVA: 0x00657DAC File Offset: 0x00655FAC
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

	// Token: 0x06015E09 RID: 89609 RVA: 0x00657E60 File Offset: 0x00656060
	protected override void OnStart()
	{
		base.GetItem(2).SetUIActive(false);
		base.GetGridLayout(0).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06015E0A RID: 89610 RVA: 0x00657E94 File Offset: 0x00656094
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

	// Token: 0x06015E0B RID: 89611 RVA: 0x00657F40 File Offset: 0x00656140
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

	// Token: 0x06015E0C RID: 89612 RVA: 0x00657FDD File Offset: 0x006561DD
	private WeeklyRogueRoleGridItem OnCreateRole()
	{
		WeeklyRogueRoleGridItem weeklyRogueRoleGridItem = new WeeklyRogueRoleGridItem();
		weeklyRogueRoleGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		weeklyRogueRoleGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return weeklyRogueRoleGridItem;
	}

	// Token: 0x06015E0D RID: 89613 RVA: 0x00658008 File Offset: 0x00656208
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

	// Token: 0x06015E0E RID: 89614 RVA: 0x00658100 File Offset: 0x00656300
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

	// Token: 0x0400B829 RID: 47145
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleDataBase> RefreshRole;

	// Token: 0x0400B82A RID: 47146
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeeklyRogueRoleGridItem, RoleDataBase> RoleLayout;

	// Token: 0x0400B82B RID: 47147
	private IWeeklyRogueRoleGroupInfo Data;

	// Token: 0x0400B82C RID: 47148
	private List<RoleDataBase> RoleDataList = new List<RoleDataBase>();
}
