using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015FB RID: 5627
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerTeamSelectPanel : UiPanelBase
{
	// Token: 0x06009EB9 RID: 40633 RVA: 0x0022AB3C File Offset: 0x00228D3C
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
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009EBA RID: 40634 RVA: 0x0022AC04 File Offset: 0x00228E04
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollViewNew<WheelTowerTeamSelectItem, int>(base.GetScrollViewWithScrollbar(0), new Func<WheelTowerTeamSelectItem>(this.CreateTeamItem), null, false, null);
		int maxFormationId = FormationConfig.Instance.GetMaxFormationId();
		for (int i = 1; i <= maxFormationId; i++)
		{
			this.TeamIdList.Add(i);
		}
		this.ScrollView.RefreshByData(this.TeamIdList, null, false);
	}

	// Token: 0x06009EBB RID: 40635 RVA: 0x0022AC68 File Offset: 0x00228E68
	public void Refresh()
	{
		int selectedIndex = this.ScrollView.GetSelectedIndex();
		WheelTowerTeamSelectItem scrollItemByIndex = this.ScrollView.GetScrollItemByIndex(selectedIndex);
		if (scrollItemByIndex != null)
		{
			scrollItemByIndex.SetToggleForce(false, true);
		}
		this.ScrollView.RefreshByData(this.TeamIdList, null, false);
	}

	// Token: 0x06009EBC RID: 40636 RVA: 0x0022ACAD File Offset: 0x00228EAD
	private WheelTowerTeamSelectItem CreateTeamItem()
	{
		return new WheelTowerTeamSelectItem
		{
			OnToggleClickCallback = new Action<int, int>(this.OnTeamSelect)
		};
	}

	// Token: 0x06009EBD RID: 40637 RVA: 0x0022ACC8 File Offset: 0x00228EC8
	private void OnTeamSelect(int teamId, int index)
	{
		Action<int> onTeamSelectCallback = this.OnTeamSelectCallback;
		if (onTeamSelectCallback != null)
		{
			onTeamSelectCallback(teamId);
		}
		GenericScrollViewNew<WheelTowerTeamSelectItem, int> scrollView = this.ScrollView;
		if (scrollView != null)
		{
			GenericLayout<WheelTowerTeamSelectItem, int> genericLayout = scrollView.GetGenericLayout();
			if (genericLayout != null)
			{
				genericLayout.RefreshWithoutDataSync();
			}
		}
		GenericScrollViewNew<WheelTowerTeamSelectItem, int> scrollView2 = this.ScrollView;
		if (scrollView2 == null)
		{
			return;
		}
		scrollView2.SelectGridProxy(index, false);
	}

	// Token: 0x06009EBE RID: 40638 RVA: 0x0022AD15 File Offset: 0x00228F15
	private void OnBtnClick()
	{
		FormationController.Instance.OpenFormationView(false, null);
	}

	// Token: 0x04004700 RID: 18176
	[Nullable(2)]
	public Action<int> OnTeamSelectCallback;

	// Token: 0x04004701 RID: 18177
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<WheelTowerTeamSelectItem, int> ScrollView;

	// Token: 0x04004702 RID: 18178
	private readonly List<int> TeamIdList = new List<int>();
}
