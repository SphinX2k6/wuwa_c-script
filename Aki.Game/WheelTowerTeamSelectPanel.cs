using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000AB3 RID: 2739
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerTeamSelectPanel : UiPanelBase
{
	// Token: 0x06007297 RID: 29335 RVA: 0x00234914 File Offset: 0x00232B14
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

	// Token: 0x06007298 RID: 29336 RVA: 0x002349DC File Offset: 0x00232BDC
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

	// Token: 0x06007299 RID: 29337 RVA: 0x00234A40 File Offset: 0x00232C40
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

	// Token: 0x0600729A RID: 29338 RVA: 0x00234A85 File Offset: 0x00232C85
	private WheelTowerTeamSelectItem CreateTeamItem()
	{
		return new WheelTowerTeamSelectItem
		{
			OnToggleClickCallback = new Action<int, int>(this.OnTeamSelect)
		};
	}

	// Token: 0x0600729B RID: 29339 RVA: 0x00234AA0 File Offset: 0x00232CA0
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

	// Token: 0x0600729C RID: 29340 RVA: 0x00234AED File Offset: 0x00232CED
	private void OnBtnClick()
	{
		FormationController.Instance.OpenFormationView(false, null);
	}

	// Token: 0x040047A6 RID: 18342
	[Nullable(2)]
	public Action<int> OnTeamSelectCallback;

	// Token: 0x040047A7 RID: 18343
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<WheelTowerTeamSelectItem, int> ScrollView;

	// Token: 0x040047A8 RID: 18344
	private readonly List<int> TeamIdList = new List<int>();
}
