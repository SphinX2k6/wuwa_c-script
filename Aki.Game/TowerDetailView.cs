using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002161 RID: 8545
[NullableContext(1)]
[Nullable(0)]
public class TowerDetailView : UiViewBase
{
	// Token: 0x06014FAA RID: 85930 RVA: 0x0061CA97 File Offset: 0x0061AC97
	public TowerDetailView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06014FAB RID: 85931 RVA: 0x0061CAA0 File Offset: 0x0061ACA0
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

	// Token: 0x06014FAC RID: 85932 RVA: 0x0061CB6C File Offset: 0x0061AD6C
	protected override void OnStart()
	{
		this.InformationScroller = new GenericScrollView<TowerDetailInformationItem>(base.GetScrollViewWithScrollbar(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TowerDetailInformationItem>(this.CreateInformationItem), null);
		this.SwitchScroller = new GenericLayoutNew<TowerDetailSwitchItem>(base.GetHorizontalLayout(4), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TowerDetailSwitchItem>(this.CreateSwitchItem), null);
	}

	// Token: 0x06014FAD RID: 85933 RVA: 0x0061CBAC File Offset: 0x0061ADAC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnClickSingleTimeTowerDetailSwitchBtn, new Action(this.OnClickSwitchItem));
	}

	// Token: 0x06014FAE RID: 85934 RVA: 0x0061CBCA File Offset: 0x0061ADCA
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnClickSingleTimeTowerDetailSwitchBtn, new Action(this.OnClickSwitchItem));
	}

	// Token: 0x06014FAF RID: 85935 RVA: 0x0061CBE8 File Offset: 0x0061ADE8
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

	// Token: 0x06014FB0 RID: 85936 RVA: 0x0061CC24 File Offset: 0x0061AE24
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

	// Token: 0x06014FB1 RID: 85937 RVA: 0x0061CC5E File Offset: 0x0061AE5E
	protected override void OnAfterShow()
	{
		this.CurrentId = TowerDetailModel.Instance.CurrentSelectDetailId;
		this.RefreshView();
	}

	// Token: 0x06014FB2 RID: 85938 RVA: 0x0061CC76 File Offset: 0x0061AE76
	private void RefreshView()
	{
		this.RefreshTitleInfo();
		this.RefreshSwitchScroller();
		this.RefreshInformationScroller();
	}

	// Token: 0x06014FB3 RID: 85939 RVA: 0x0061CC8C File Offset: 0x0061AE8C
	private void RefreshSwitchScroller()
	{
		List<TowerSwitchData> switchData = TowerDetailModel.Instance.SwitchData;
		this.SwitchScroller.RebuildLayoutByDataNew<TowerSwitchData>(switchData, null);
	}

	// Token: 0x06014FB4 RID: 85940 RVA: 0x0061CCBC File Offset: 0x0061AEBC
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

	// Token: 0x06014FB5 RID: 85941 RVA: 0x0061CE0D File Offset: 0x0061B00D
	public int SortFunc(TowerInformationData a, TowerInformationData b)
	{
		return a.Priority - b.Priority;
	}

	// Token: 0x06014FB6 RID: 85942 RVA: 0x0061CE1C File Offset: 0x0061B01C
	private void OnClickSwitchItem()
	{
		this.CurrentId = TowerDetailModel.Instance.CurrentSelectDetailId;
		this.RefreshSwitchScroller();
		this.RefreshInformationScroller();
	}

	// Token: 0x06014FB7 RID: 85943 RVA: 0x0061CE3C File Offset: 0x0061B03C
	private void RefreshTitleInfo()
	{
		string towerTitle = TowerDetailModel.Instance.TowerTitle;
		base.GetText(0).SetText(towerTitle, true);
	}

	// Token: 0x06014FB8 RID: 85944 RVA: 0x0061CE62 File Offset: 0x0061B062
	protected override void OnBeforeDestroy()
	{
		this.InformationScroller.ClearChildren();
		this.SwitchScroller.ClearChildren();
	}

	// Token: 0x0400B2C3 RID: 45763
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<TowerDetailInformationItem> InformationScroller;

	// Token: 0x0400B2C4 RID: 45764
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TowerDetailSwitchItem> SwitchScroller;

	// Token: 0x0400B2C5 RID: 45765
	private int CurrentId;

	// Token: 0x020083E6 RID: 33766
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402A8FC RID: 174332
		public const int CurrentSelectTowerTitle = 0;

		// Token: 0x0402A8FD RID: 174333
		public const int InformationItem = 1;

		// Token: 0x0402A8FE RID: 174334
		public const int InformationScroller = 2;

		// Token: 0x0402A8FF RID: 174335
		public const int SwitchItem = 3;

		// Token: 0x0402A900 RID: 174336
		public const int SwitchScroller = 4;

		// Token: 0x0402A901 RID: 174337
		public const int BackBtn = 5;
	}
}
