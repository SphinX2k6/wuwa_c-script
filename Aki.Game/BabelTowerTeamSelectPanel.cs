using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000622 RID: 1570
public class BabelTowerTeamSelectPanel : UiPanelBase
{
	// Token: 0x0600495D RID: 18781 RVA: 0x0018E65C File Offset: 0x0018C85C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600495E RID: 18782 RVA: 0x0018E6C8 File Offset: 0x0018C8C8
	protected override void OnStart()
	{
		this.TeamScroll = new GenericScrollViewNew<BabelTowerPreTeamItem, FormationData>(base.GetScrollViewWithScrollbar(0), new Func<BabelTowerPreTeamItem>(this.CreateTeamItem), null, false, null);
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			this.EmptyStateItem = item;
			this.EmptyStateItem.SetUIActive(false);
		}
	}

	// Token: 0x0600495F RID: 18783 RVA: 0x0018E714 File Offset: 0x0018C914
	public void RefreshTeamList()
	{
		this.SelectedTeamIndex = -1;
		this.TeamList = BabelTowerModel.Instance.GetPresetTeamList();
		GenericScrollViewNew<BabelTowerPreTeamItem, FormationData> teamScroll = this.TeamScroll;
		if (teamScroll != null)
		{
			teamScroll.RefreshByData(this.TeamList, delegate
			{
				this.UpdateAllSelection();
			}, true);
		}
		UUIItem emptyStateItem = this.EmptyStateItem;
		if (emptyStateItem == null)
		{
			return;
		}
		emptyStateItem.SetUIActive(this.TeamList.Count <= 0);
	}

	// Token: 0x06004960 RID: 18784 RVA: 0x0018E77D File Offset: 0x0018C97D
	[NullableContext(1)]
	private BabelTowerPreTeamItem CreateTeamItem()
	{
		return new BabelTowerPreTeamItem
		{
			OnClickCallback = delegate(FormationData formationData, int index)
			{
				this.SelectedTeamIndex = index;
				this.UpdateAllSelection();
				Action<FormationData> onTeamSelect = this.OnTeamSelect;
				if (onTeamSelect == null)
				{
					return;
				}
				onTeamSelect(formationData);
			}
		};
	}

	// Token: 0x06004961 RID: 18785 RVA: 0x0018E798 File Offset: 0x0018C998
	private void UpdateAllSelection()
	{
		GenericScrollViewNew<BabelTowerPreTeamItem, FormationData> teamScroll = this.TeamScroll;
		List<BabelTowerPreTeamItem> list = (teamScroll != null) ? teamScroll.GetScrollItemList() : null;
		if (list == null)
		{
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			BabelTowerPreTeamItem babelTowerPreTeamItem = list[i];
			bool selected = i == this.SelectedTeamIndex;
			babelTowerPreTeamItem.ForceSetSelected(selected);
		}
	}

	// Token: 0x040036A6 RID: 13990
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FormationData> OnTeamSelect;

	// Token: 0x040036A7 RID: 13991
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<BabelTowerPreTeamItem, FormationData> TeamScroll;

	// Token: 0x040036A8 RID: 13992
	[Nullable(1)]
	private List<FormationData> TeamList = new List<FormationData>();

	// Token: 0x040036A9 RID: 13993
	[Nullable(2)]
	private UUIItem EmptyStateItem;

	// Token: 0x040036AA RID: 13994
	private int SelectedTeamIndex = -1;

	// Token: 0x020068CD RID: 26829
	private class EComp
	{
		// Token: 0x04022892 RID: 141458
		public const int TeamScrollView = 0;

		// Token: 0x04022893 RID: 141459
		public const int EmptyState = 1;
	}
}
