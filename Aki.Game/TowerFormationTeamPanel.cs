using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002BF8 RID: 11256
[NullableContext(1)]
[Nullable(0)]
public class TowerFormationTeamPanel : UiPanelBase
{
	// Token: 0x06017610 RID: 95760 RVA: 0x005F2FB8 File Offset: 0x005F11B8
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

	// Token: 0x06017611 RID: 95761 RVA: 0x005F3004 File Offset: 0x005F1204
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

	// Token: 0x06017612 RID: 95762 RVA: 0x005F30B0 File Offset: 0x005F12B0
	protected override UniTask OnBeforeStartAsync()
	{
		TowerFormationTeamPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TowerFormationTeamPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06017613 RID: 95763 RVA: 0x005F30F3 File Offset: 0x005F12F3
	private TowerFormationTeamTabItem OnTabProxyCreate()
	{
		return new TowerFormationTeamTabItem
		{
			OnSelectCallback = new Action<int>(this.OnTabSelect)
		};
	}

	// Token: 0x06017614 RID: 95764 RVA: 0x005F310C File Offset: 0x005F130C
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

	// Token: 0x06017615 RID: 95765 RVA: 0x005F3186 File Offset: 0x005F1386
	public void RefreshRole(int roleId)
	{
		TowerFormationRoleScrollItem roleScrollItem = this.RoleScrollItem;
		if (roleScrollItem == null)
		{
			return;
		}
		roleScrollItem.RefreshRole(roleId);
	}

	// Token: 0x06017616 RID: 95766 RVA: 0x005F3199 File Offset: 0x005F1399
	public void RefreshRoleList()
	{
		TowerFormationRoleScrollItem roleScrollItem = this.RoleScrollItem;
		if (roleScrollItem == null)
		{
			return;
		}
		roleScrollItem.UpdateRoleListFilter();
	}

	// Token: 0x06017617 RID: 95767 RVA: 0x005F31AB File Offset: 0x005F13AB
	public void RebuildRoleList()
	{
		TowerFormationRoleScrollItem roleScrollItem = this.RoleScrollItem;
		if (roleScrollItem == null)
		{
			return;
		}
		roleScrollItem.RebuildRoleList();
	}

	// Token: 0x06017618 RID: 95768 RVA: 0x005F31BD File Offset: 0x005F13BD
	public bool IsRoleListStale()
	{
		TowerFormationRoleScrollItem roleScrollItem = this.RoleScrollItem;
		return roleScrollItem != null && roleScrollItem.IsRoleListStale();
	}

	// Token: 0x06017619 RID: 95769 RVA: 0x005F31D0 File Offset: 0x005F13D0
	public void RefreshPresetRoleState()
	{
		TowerFormationPresetsTeamItem presetsTeamItem = this.PresetsTeamItem;
		if (presetsTeamItem == null)
		{
			return;
		}
		presetsTeamItem.RefreshRoleSelectState();
	}

	// Token: 0x0601761A RID: 95770 RVA: 0x005F31E2 File Offset: 0x005F13E2
	public List<int> GetRoleIdList()
	{
		TowerFormationRoleScrollItem roleScrollItem = this.RoleScrollItem;
		return ((roleScrollItem != null) ? roleScrollItem.GetRoleIdList() : null) ?? new List<int>();
	}

	// Token: 0x0601761B RID: 95771 RVA: 0x005F31FF File Offset: 0x005F13FF
	protected override void OnBeforeDestroy()
	{
		this.TabLayout = null;
		this.RoleScrollItem = null;
		this.PresetsTeamItem = null;
	}

	// Token: 0x0400AEEE RID: 44782
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TowerFormationTeamTabItem, string> TabLayout;

	// Token: 0x0400AEEF RID: 44783
	[Nullable(2)]
	private TowerFormationRoleScrollItem RoleScrollItem;

	// Token: 0x0400AEF0 RID: 44784
	[Nullable(2)]
	private TowerFormationPresetsTeamItem PresetsTeamItem;

	// Token: 0x0400AEF1 RID: 44785
	private readonly List<string> TabTitleList = new List<string>
	{
		"GhostShipRoleList_Text",
		"GhostShipPreTeam_Text"
	};

	// Token: 0x0400AEF2 RID: 44786
	private bool IsTabInited;

	// Token: 0x0400AEF3 RID: 44787
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleDataBase> RoleSelectCallBack;

	// Token: 0x0400AEF4 RID: 44788
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FormationData> TeamSelectCallBack;

	// Token: 0x0400AEF5 RID: 44789
	[Nullable(2)]
	public Action TabSwitchCallBack;

	// Token: 0x020091BA RID: 37306
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402F25C RID: 193116
		TabScroll,
		// Token: 0x0402F25D RID: 193117
		TabItem,
		// Token: 0x0402F25E RID: 193118
		RoleScrollItem,
		// Token: 0x0402F25F RID: 193119
		PresetsTeamItem
	}
}
