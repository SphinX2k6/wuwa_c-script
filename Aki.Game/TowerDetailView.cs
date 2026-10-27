using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BE6 RID: 11238
[NullableContext(1)]
[Nullable(0)]
public class TowerDetailView : UiViewBase
{
	// Token: 0x06017579 RID: 95609 RVA: 0x005EFF37 File Offset: 0x005EE137
	public TowerDetailView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0601757A RID: 95610 RVA: 0x005EFF40 File Offset: 0x005EE140
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601757B RID: 95611 RVA: 0x005F000C File Offset: 0x005EE20C
	protected override void OnStart()
	{
		this.InformationScroller = new GenericScrollView<TowerDetailInformationItem>(base.GetScrollViewWithScrollbar(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TowerDetailInformationItem>(this.CreateInformationItem), null);
		this.SwitchScroller = new GenericLayoutNew<TowerDetailSwitchItem>(base.GetHorizontalLayout(4), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TowerDetailSwitchItem>(this.CreateSwitchItem), null);
	}

	// Token: 0x0601757C RID: 95612 RVA: 0x005F004C File Offset: 0x005EE24C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnClickSingleTimeTowerDetailSwitchBtn, new Action(this.OnClickSwitchItem));
	}

	// Token: 0x0601757D RID: 95613 RVA: 0x005F006A File Offset: 0x005EE26A
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnClickSingleTimeTowerDetailSwitchBtn, new Action(this.OnClickSwitchItem));
	}

	// Token: 0x0601757E RID: 95614 RVA: 0x005F0088 File Offset: 0x005EE288
	private ILayoutItem<TowerDetailInformationItem> CreateInformationItem(object tempData, UUIItem uiItem, int index)
	{
		TowerInformationData data = (TowerInformationData)tempData;
		TowerDetailInformationItem towerDetailInformationItem = new TowerDetailInformationItem(uiItem);
		towerDetailInformationItem.Update(data);
		return new LayoutItem<TowerDetailInformationItem>
		{
			Key = index,
			Value = towerDetailInformationItem
		};
	}

	// Token: 0x0601757F RID: 95615 RVA: 0x005F00C4 File Offset: 0x005EE2C4
	private ILayoutItem<TowerDetailSwitchItem> CreateSwitchItem(object tempData, UUIItem uiItem, int index)
	{
		TowerSwitchData data = (TowerSwitchData)tempData;
		TowerDetailSwitchItem towerDetailSwitchItem = new TowerDetailSwitchItem(uiItem);
		towerDetailSwitchItem.Update(data);
		return new LayoutItem<TowerDetailSwitchItem>
		{
			Key = index,
			Value = towerDetailSwitchItem
		};
	}

	// Token: 0x06017580 RID: 95616 RVA: 0x005F00FE File Offset: 0x005EE2FE
	protected override void OnAfterShow()
	{
		this.CurrentId = TowerDetailModel.Instance.CurrentSelectDetailId;
		this.RefreshView();
	}

	// Token: 0x06017581 RID: 95617 RVA: 0x005F0116 File Offset: 0x005EE316
	private void RefreshView()
	{
		this.RefreshTitleInfo();
		this.RefreshSwitchScroller();
		this.RefreshInformationScroller();
	}

	// Token: 0x06017582 RID: 95618 RVA: 0x005F012C File Offset: 0x005EE32C
	private void RefreshSwitchScroller()
	{
		List<TowerSwitchData> switchData = TowerDetailModel.Instance.SwitchData;
		this.SwitchScroller.RebuildLayoutByDataNew<TowerSwitchData>(switchData, null);
	}

	// Token: 0x06017583 RID: 95619 RVA: 0x005F015C File Offset: 0x005EE35C
	private void RefreshInformationScroller()
	{
		List<TowerSwitchData> switchData = TowerDetailModel.Instance.SwitchData;
		TowerSwitchData switchData2 = null;
		for (int i = 0; i < switchData.Count; i++)
		{
			TowerSwitchData towerSwitchData = switchData[i];
			if (towerSwitchData.Index == this.CurrentId)
			{
				switchData2 = towerSwitchData;
			}
		}
		List<TowerInformationData> list = new List<TowerInformationData>();
		List<TowerDetailBuffData> buffs = TowerDetailModel.Instance.GetBuffs(switchData2);
		if (buffs != null)
		{
			for (int j = 0; j < buffs.Count; j++)
			{
				TowerDetailBuffData towerDetailBuffData = buffs[j];
				list.Add(new TowerInformationData
				{
					Type = ETowerDetailInformationType.Buff,
					TowerDetailBuffData = towerDetailBuffData,
					Title = towerDetailBuffData.Title,
					Priority = towerDetailBuffData.Priority
				});
			}
		}
		List<TowerDetailMonsterData> monsters = TowerDetailModel.Instance.GetMonsters(switchData2);
		if (monsters != null)
		{
			for (int k = 0; k < monsters.Count; k++)
			{
				TowerDetailMonsterData towerDetailMonsterData = monsters[k];
				list.Add(new TowerInformationData
				{
					Type = ETowerDetailInformationType.Monster,
					MonsterData = towerDetailMonsterData,
					Title = towerDetailMonsterData.Title,
					Priority = towerDetailMonsterData.Priority
				});
			}
		}
		list.Sort(new Comparison<TowerInformationData>(this.SortFunc));
		this.InformationScroller.RefreshByData<TowerInformationData>(list, null);
	}

	// Token: 0x06017584 RID: 95620 RVA: 0x005F02AD File Offset: 0x005EE4AD
	public int SortFunc(TowerInformationData a, TowerInformationData b)
	{
		return a.Priority - b.Priority;
	}

	// Token: 0x06017585 RID: 95621 RVA: 0x005F02BC File Offset: 0x005EE4BC
	private void OnClickSwitchItem()
	{
		this.CurrentId = TowerDetailModel.Instance.CurrentSelectDetailId;
		this.RefreshSwitchScroller();
		this.RefreshInformationScroller();
	}

	// Token: 0x06017586 RID: 95622 RVA: 0x005F02DC File Offset: 0x005EE4DC
	private void RefreshTitleInfo()
	{
		string towerTitle = TowerDetailModel.Instance.TowerTitle;
		base.GetText(0).SetText(towerTitle, true);
	}

	// Token: 0x06017587 RID: 95623 RVA: 0x005F0302 File Offset: 0x005EE502
	protected override void OnBeforeDestroy()
	{
		this.InformationScroller.ClearChildren();
		this.SwitchScroller.ClearChildren();
	}

	// Token: 0x0400AEBE RID: 44734
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<TowerDetailInformationItem> InformationScroller;

	// Token: 0x0400AEBF RID: 44735
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TowerDetailSwitchItem> SwitchScroller;

	// Token: 0x0400AEC0 RID: 44736
	private int CurrentId;

	// Token: 0x020091A3 RID: 37283
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402F1FB RID: 193019
		public const int CurrentSelectTowerTitle = 0;

		// Token: 0x0402F1FC RID: 193020
		public const int InformationItem = 1;

		// Token: 0x0402F1FD RID: 193021
		public const int InformationScroller = 2;

		// Token: 0x0402F1FE RID: 193022
		public const int SwitchItem = 3;

		// Token: 0x0402F1FF RID: 193023
		public const int SwitchScroller = 4;

		// Token: 0x0402F200 RID: 193024
		public const int BackBtn = 5;
	}
}
