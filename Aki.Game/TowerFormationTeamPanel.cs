using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002173 RID: 8563
[NullableContext(1)]
[Nullable(0)]
public class TowerFormationTeamPanel : UiPanelBase
{
	// Token: 0x06015041 RID: 86081 RVA: 0x0061FAF4 File Offset: 0x0061DCF4
	public UniTask Init(UUIItem item)
	{
		TowerFormationTeamPanel.<Init>d__9 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<TowerFormationTeamPanel.<Init>d__9>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06015042 RID: 86082 RVA: 0x0061FB40 File Offset: 0x0061DD40
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06015043 RID: 86083 RVA: 0x0061FBEC File Offset: 0x0061DDEC
	protected override UniTask OnBeforeStartAsync()
	{
		TowerFormationTeamPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TowerFormationTeamPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015044 RID: 86084 RVA: 0x0061FC2F File Offset: 0x0061DE2F
	private TowerFormationTeamTabItem OnTabProxyCreate()
	{
		return new TowerFormationTeamTabItem
		{
			OnSelectCallback = new Action<int>(this.OnTabSelect)
		};
	}

	// Token: 0x06015045 RID: 86085 RVA: 0x0061FC48 File Offset: 0x0061DE48
	private void OnTabSelect(int index)
	{
		bool flag = index == 0;
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		if (flag)
		{
			TowerFormationRoleScrollItem roleScrollItem = this.RoleScrollItem;
			if (roleScrollItem != null)
			{
				roleScrollItem.UpdateRoleListFilter();
			}
		}
		else
		{
			TowerFormationPresetsTeamItem presetsTeamItem = this.PresetsTeamItem;
			if (presetsTeamItem != null)
			{
				presetsTeamItem.Refresh();
			}
		}
		if (this.IsTabInited)
		{
			Action tabSwitchCallBack = this.TabSwitchCallBack;
			if (tabSwitchCallBack == null)
			{
				return;
			}
			tabSwitchCallBack();
		}
	}

	// Token: 0x06015046 RID: 86086 RVA: 0x0061FCC2 File Offset: 0x0061DEC2
	public void RefreshRole(int roleId)
	{
		TowerFormationRoleScrollItem roleScrollItem = this.RoleScrollItem;
		if (roleScrollItem == null)
		{
			return;
		}
		roleScrollItem.RefreshRole(roleId);
	}

	// Token: 0x06015047 RID: 86087 RVA: 0x0061FCD5 File Offset: 0x0061DED5
	public void RefreshRoleList()
	{
		TowerFormationRoleScrollItem roleScrollItem = this.RoleScrollItem;
		if (roleScrollItem == null)
		{
			return;
		}
		roleScrollItem.UpdateRoleListFilter();
	}

	// Token: 0x06015048 RID: 86088 RVA: 0x0061FCE7 File Offset: 0x0061DEE7
	public void RebuildRoleList()
	{
		TowerFormationRoleScrollItem roleScrollItem = this.RoleScrollItem;
		if (roleScrollItem == null)
		{
			return;
		}
		roleScrollItem.RebuildRoleList();
	}

	// Token: 0x06015049 RID: 86089 RVA: 0x0061FCF9 File Offset: 0x0061DEF9
	public bool IsRoleListStale()
	{
		TowerFormationRoleScrollItem roleScrollItem = this.RoleScrollItem;
		return roleScrollItem != null && roleScrollItem.IsRoleListStale();
	}

	// Token: 0x0601504A RID: 86090 RVA: 0x0061FD0C File Offset: 0x0061DF0C
	public void RefreshPresetRoleState()
	{
		TowerFormationPresetsTeamItem presetsTeamItem = this.PresetsTeamItem;
		if (presetsTeamItem == null)
		{
			return;
		}
		presetsTeamItem.RefreshRoleSelectState();
	}

	// Token: 0x0601504B RID: 86091 RVA: 0x0061FD1E File Offset: 0x0061DF1E
	public List<int> GetRoleIdList()
	{
		TowerFormationRoleScrollItem roleScrollItem = this.RoleScrollItem;
		return ((roleScrollItem != null) ? roleScrollItem.GetRoleIdList() : null) ?? new List<int>();
	}

	// Token: 0x0601504C RID: 86092 RVA: 0x0061FD3B File Offset: 0x0061DF3B
	protected override void OnBeforeDestroy()
	{
		this.TabLayout = null;
		this.RoleScrollItem = null;
		this.PresetsTeamItem = null;
	}

	// Token: 0x0400B2F3 RID: 45811
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TowerFormationTeamTabItem, string> TabLayout;

	// Token: 0x0400B2F4 RID: 45812
	[Nullable(2)]
	private TowerFormationRoleScrollItem RoleScrollItem;

	// Token: 0x0400B2F5 RID: 45813
	[Nullable(2)]
	private TowerFormationPresetsTeamItem PresetsTeamItem;

	// Token: 0x0400B2F6 RID: 45814
	private readonly List<string> TabTitleList = new List<string>
	{
		"GhostShipRoleList_Text",
		"GhostShipPreTeam_Text"
	};

	// Token: 0x0400B2F7 RID: 45815
	private bool IsTabInited;

	// Token: 0x0400B2F8 RID: 45816
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleDataBase> RoleSelectCallBack;

	// Token: 0x0400B2F9 RID: 45817
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FormationData> TeamSelectCallBack;

	// Token: 0x0400B2FA RID: 45818
	[Nullable(2)]
	public Action TabSwitchCallBack;

	// Token: 0x020083FD RID: 33789
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A95D RID: 174429
		TabScroll,
		// Token: 0x0402A95E RID: 174430
		TabItem,
		// Token: 0x0402A95F RID: 174431
		RoleScrollItem,
		// Token: 0x0402A960 RID: 174432
		PresetsTeamItem
	}
}
