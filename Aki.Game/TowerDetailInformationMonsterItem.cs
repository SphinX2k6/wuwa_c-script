using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002165 RID: 8549
[NullableContext(1)]
[Nullable(0)]
public class TowerDetailInformationMonsterItem : UiPanelBase
{
	// Token: 0x06014FCC RID: 85964 RVA: 0x0061D2C9 File Offset: 0x0061B4C9
	public TowerDetailInformationMonsterItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06014FCD RID: 85965 RVA: 0x0061D2E0 File Offset: 0x0061B4E0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIGridLayout));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014FCE RID: 85966 RVA: 0x0061D36A File Offset: 0x0061B56A
	protected override void OnStart()
	{
		base.GetItem(1).SetUIParent(base.GetGridLayout(2).GetRootComponent(), false);
		this.MonsterLayout = new GenericLayoutNew<TowerDetailInformationMonsterSubItem>(base.GetGridLayout(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TowerDetailInformationMonsterSubItem>(this.CreateMonsterItem), null);
	}

	// Token: 0x06014FCF RID: 85967 RVA: 0x0061D3A4 File Offset: 0x0061B5A4
	private ILayoutItem<TowerDetailInformationMonsterSubItem> CreateMonsterItem(object tempData, UUIItem uiItem, int index)
	{
		TowerDetailMonster towerDetailMonster = (TowerDetailMonster)tempData;
		TowerDetailInformationMonsterSubItem towerDetailInformationMonsterSubItem = new TowerDetailInformationMonsterSubItem(uiItem);
		towerDetailInformationMonsterSubItem.Update(towerDetailMonster.MonsterId, towerDetailMonster.ShowLevel);
		return new LayoutItem<TowerDetailInformationMonsterSubItem>
		{
			Key = index,
			Value = towerDetailInformationMonsterSubItem
		};
	}

	// Token: 0x06014FD0 RID: 85968 RVA: 0x0061D3E9 File Offset: 0x0061B5E9
	public void Update(TowerDetailMonsterData data, ETowerDetailInformationType showType)
	{
		this.MonsterData = data;
		this.RefreshView();
	}

	// Token: 0x06014FD1 RID: 85969 RVA: 0x0061D3F8 File Offset: 0x0061B5F8
	private void RefreshView()
	{
		List<TowerDetailMonster> monsterInfos = this.MonsterData.MonsterInfos;
		this.MonsterLayout.RebuildLayoutByDataNew<TowerDetailMonster>(monsterInfos, null);
	}

	// Token: 0x06014FD2 RID: 85970 RVA: 0x0061D426 File Offset: 0x0061B626
	protected override void OnBeforeDestroy()
	{
		this.MonsterLayout.ClearChildren();
	}

	// Token: 0x0400B2CB RID: 45771
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<TowerDetailInformationMonsterSubItem> MonsterLayout;

	// Token: 0x0400B2CC RID: 45772
	[Nullable(2)]
	private TowerDetailMonsterData MonsterData;

	// Token: 0x020083EA RID: 33770
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402A90C RID: 174348
		public const int TitleText = 0;

		// Token: 0x0402A90D RID: 174349
		public const int MonsterItem = 1;

		// Token: 0x0402A90E RID: 174350
		public const int MonsterScroller = 2;
	}
}
