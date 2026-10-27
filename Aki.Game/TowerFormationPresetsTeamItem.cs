using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002BF3 RID: 11251
[NullableContext(1)]
[Nullable(0)]
public class TowerFormationPresetsTeamItem : UiPanelBase
{
	// Token: 0x060175E5 RID: 95717 RVA: 0x005F1F64 File Offset: 0x005F0164
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

	// Token: 0x060175E6 RID: 95718 RVA: 0x005F1FB0 File Offset: 0x005F01B0
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

	// Token: 0x060175E7 RID: 95719 RVA: 0x005F2077 File Offset: 0x005F0277
	protected override void OnStart()
	{
		this.TeamScrollView = new GenericScrollViewNew<TowerFormationRoleTeamItem, FormationData>(base.GetScrollViewWithScrollbar(0), new Func<TowerFormationRoleTeamItem>(this.OnTeamGridProxyCreate), base.GetItem(1).GetOwner() as AUIBaseActor, false, null);
	}

	// Token: 0x060175E8 RID: 95720 RVA: 0x005F20AA File Offset: 0x005F02AA
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

	// Token: 0x060175E9 RID: 95721 RVA: 0x005F20E4 File Offset: 0x005F02E4
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

	// Token: 0x060175EA RID: 95722 RVA: 0x005F2148 File Offset: 0x005F0348
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

	// Token: 0x060175EB RID: 95723 RVA: 0x005F2190 File Offset: 0x005F0390
	private TowerFormationRoleTeamItem OnTeamGridProxyCreate()
	{
		return new TowerFormationRoleTeamItem
		{
			OnClickCallback = this.TeamSelectCallBack
		};
	}

	// Token: 0x060175EC RID: 95724 RVA: 0x005F21A3 File Offset: 0x005F03A3
	private void OnTeamEditClick()
	{
		FormationController.Instance.OpenFormationView(false, null);
	}

	// Token: 0x060175ED RID: 95725 RVA: 0x005F21B6 File Offset: 0x005F03B6
	protected override void OnBeforeDestroy()
	{
		this.TeamScrollView = null;
	}

	// Token: 0x0400AEE1 RID: 44769
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<TowerFormationRoleTeamItem, FormationData> TeamScrollView;

	// Token: 0x0400AEE2 RID: 44770
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FormationData> TeamList;

	// Token: 0x0400AEE3 RID: 44771
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FormationData> TeamSelectCallBack;

	// Token: 0x020091B2 RID: 37298
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402F240 RID: 193088
		RoleScroll,
		// Token: 0x0402F241 RID: 193089
		RoleItem,
		// Token: 0x0402F242 RID: 193090
		Button
	}
}
