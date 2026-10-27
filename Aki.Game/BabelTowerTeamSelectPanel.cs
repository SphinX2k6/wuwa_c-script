using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200116E RID: 4462
public class BabelTowerTeamSelectPanel : UiPanelBase
{
	// Token: 0x060075C6 RID: 30150 RVA: 0x00185AB4 File Offset: 0x00183CB4
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

	// Token: 0x060075C7 RID: 30151 RVA: 0x00185B20 File Offset: 0x00183D20
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

	// Token: 0x060075C8 RID: 30152 RVA: 0x00185B6C File Offset: 0x00183D6C
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

	// Token: 0x060075C9 RID: 30153 RVA: 0x00185BD5 File Offset: 0x00183DD5
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

	// Token: 0x060075CA RID: 30154 RVA: 0x00185BF0 File Offset: 0x00183DF0
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

	// Token: 0x0400360D RID: 13837
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FormationData> OnTeamSelect;

	// Token: 0x0400360E RID: 13838
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<BabelTowerPreTeamItem, FormationData> TeamScroll;

	// Token: 0x0400360F RID: 13839
	[Nullable(1)]
	private List<FormationData> TeamList = new List<FormationData>();

	// Token: 0x04003610 RID: 13840
	[Nullable(2)]
	private UUIItem EmptyStateItem;

	// Token: 0x04003611 RID: 13841
	private int SelectedTeamIndex = -1;

	// Token: 0x02007740 RID: 30528
	private class EComp
	{
		// Token: 0x04027559 RID: 161113
		public const int TeamScrollView = 0;

		// Token: 0x0402755A RID: 161114
		public const int EmptyState = 1;
	}
}
