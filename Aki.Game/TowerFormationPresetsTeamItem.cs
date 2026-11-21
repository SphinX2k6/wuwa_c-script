using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200216E RID: 8558
[NullableContext(1)]
[Nullable(0)]
public class TowerFormationPresetsTeamItem : UiPanelBase
{
	// Token: 0x06015016 RID: 86038 RVA: 0x0061EAA0 File Offset: 0x0061CCA0
	public UniTask Init(UUIItem item)
	{
		TowerFormationPresetsTeamItem.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<TowerFormationPresetsTeamItem.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06015017 RID: 86039 RVA: 0x0061EAEC File Offset: 0x0061CCEC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnTeamEditClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06015018 RID: 86040 RVA: 0x0061EBB3 File Offset: 0x0061CDB3
	protected override void OnStart()
	{
		this.TeamScrollView = new GenericScrollViewNew<TowerFormationRoleTeamItem, FormationData>(base.GetScrollViewWithScrollbar(0), new Func<TowerFormationRoleTeamItem>(this.OnTeamGridProxyCreate), base.GetItem(1).GetOwner() as AUIBaseActor, false, null);
	}

	// Token: 0x06015019 RID: 86041 RVA: 0x0061EBE6 File Offset: 0x0061CDE6
	public void Refresh()
	{
		this.TeamList = this.GetPlayerTeamList();
		GenericScrollViewNew<TowerFormationRoleTeamItem, FormationData> teamScrollView = this.TeamScrollView;
		if (teamScrollView != null)
		{
			teamScrollView.SelectGridProxy(-1, false);
		}
		GenericScrollViewNew<TowerFormationRoleTeamItem, FormationData> teamScrollView2 = this.TeamScrollView;
		if (teamScrollView2 == null)
		{
			return;
		}
		teamScrollView2.RefreshByData(this.TeamList, null, false);
	}

	// Token: 0x0601501A RID: 86042 RVA: 0x0061EC20 File Offset: 0x0061CE20
	public void RefreshRoleSelectState()
	{
		GenericScrollViewNew<TowerFormationRoleTeamItem, FormationData> teamScrollView = this.TeamScrollView;
		List<TowerFormationRoleTeamItem> list = (teamScrollView != null) ? teamScrollView.GetScrollItemList() : null;
		if (list == null)
		{
			return;
		}
		foreach (TowerFormationRoleTeamItem towerFormationRoleTeamItem in list)
		{
			towerFormationRoleTeamItem.RefreshRoleState();
		}
	}

	// Token: 0x0601501B RID: 86043 RVA: 0x0061EC84 File Offset: 0x0061CE84
	private List<FormationData> GetPlayerTeamList()
	{
		List<FormationData> list = new List<FormationData>();
		int maxFormationId = FormationConfig.Instance.GetMaxFormationId();
		for (int i = 1; i <= maxFormationId; i++)
		{
			FormationData formationData = FormationModel.Instance.GetFormationData(i);
			list.Add(formationData ?? new FormationData(i));
		}
		return list;
	}

	// Token: 0x0601501C RID: 86044 RVA: 0x0061ECCC File Offset: 0x0061CECC
	private TowerFormationRoleTeamItem OnTeamGridProxyCreate()
	{
		return new TowerFormationRoleTeamItem
		{
			OnClickCallback = this.TeamSelectCallBack
		};
	}

	// Token: 0x0601501D RID: 86045 RVA: 0x0061ECDF File Offset: 0x0061CEDF
	private void OnTeamEditClick()
	{
		FormationController.Instance.OpenFormationView(false, null);
	}

	// Token: 0x0601501E RID: 86046 RVA: 0x0061ECF2 File Offset: 0x0061CEF2
	protected override void OnBeforeDestroy()
	{
		this.TeamScrollView = null;
	}

	// Token: 0x0400B2E6 RID: 45798
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<TowerFormationRoleTeamItem, FormationData> TeamScrollView;

	// Token: 0x0400B2E7 RID: 45799
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FormationData> TeamList;

	// Token: 0x0400B2E8 RID: 45800
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FormationData> TeamSelectCallBack;

	// Token: 0x020083F5 RID: 33781
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A941 RID: 174401
		RoleScroll,
		// Token: 0x0402A942 RID: 174402
		RoleItem,
		// Token: 0x0402A943 RID: 174403
		Button
	}
}
