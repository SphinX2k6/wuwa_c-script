using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BEA RID: 11242
[NullableContext(1)]
[Nullable(0)]
public class TowerDetailInformationMonsterItem : UiPanelBase
{
	// Token: 0x0601759B RID: 95643 RVA: 0x005F0769 File Offset: 0x005EE969
	public TowerDetailInformationMonsterItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0601759C RID: 95644 RVA: 0x005F0780 File Offset: 0x005EE980
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

	// Token: 0x0601759D RID: 95645 RVA: 0x005F080A File Offset: 0x005EEA0A
	protected override void OnStart()
	{
		base.GetItem(1).SetUIParent(base.GetGridLayout(2).GetRootComponent(), false);
		this.MonsterLayout = new GenericLayoutNew<TowerDetailInformationMonsterSubItem>(base.GetGridLayout(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TowerDetailInformationMonsterSubItem>(this.CreateMonsterItem), null);
	}

	// Token: 0x0601759E RID: 95646 RVA: 0x005F0844 File Offset: 0x005EEA44
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

	// Token: 0x0601759F RID: 95647 RVA: 0x005F0889 File Offset: 0x005EEA89
	public void Update(TowerDetailMonsterData data, ETowerDetailInformationType showType)
	{
		this.MonsterData = data;
		this.RefreshView();
	}

	// Token: 0x060175A0 RID: 95648 RVA: 0x005F0898 File Offset: 0x005EEA98
	private void RefreshView()
	{
		List<TowerDetailMonster> monsterInfos = this.MonsterData.MonsterInfos;
		this.MonsterLayout.RebuildLayoutByDataNew<TowerDetailMonster>(monsterInfos, null);
	}

	// Token: 0x060175A1 RID: 95649 RVA: 0x005F08C6 File Offset: 0x005EEAC6
	protected override void OnBeforeDestroy()
	{
		this.MonsterLayout.ClearChildren();
	}

	// Token: 0x0400AEC6 RID: 44742
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<TowerDetailInformationMonsterSubItem> MonsterLayout;

	// Token: 0x0400AEC7 RID: 44743
	[Nullable(2)]
	private TowerDetailMonsterData MonsterData;

	// Token: 0x020091A7 RID: 37287
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402F20B RID: 193035
		public const int TitleText = 0;

		// Token: 0x0402F20C RID: 193036
		public const int MonsterItem = 1;

		// Token: 0x0402F20D RID: 193037
		public const int MonsterScroller = 2;
	}
}
