using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BF0 RID: 11248
[NullableContext(1)]
[Nullable(0)]
public class TowerFloorDetailView : UiViewBase
{
	// Token: 0x060175BF RID: 95679 RVA: 0x005F0ECA File Offset: 0x005EF0CA
	public TowerFloorDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060175C0 RID: 95680 RVA: 0x005F0ED4 File Offset: 0x005EF0D4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIGridLayout));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060175C1 RID: 95681 RVA: 0x005F0F80 File Offset: 0x005EF180
	protected override void OnStart()
	{
		int currentSelectDifficulties = TowerModel.Instance.CurrentSelectDifficulties;
		this.FloorLayout = new GenericLayout<TowerDetailItem, int>(base.GetHorizontalLayout(0), new Func<TowerDetailItem>(this.InitFloorItem), null, false, true);
		this.BuffShowLayout = new GenericLayout<TowerBuffShowItem, long>(base.GetVerticalLayout(1), new Func<TowerBuffShowItem>(this.InitBuffItem), null, false, true);
		this.TargetStarLayout = new GenericLayout<TowerStarsComplexItem, ValueTuple<bool, TowerTarget>>(base.GetVerticalLayout(2), new Func<TowerStarsComplexItem>(this.InitTargetStarItem), null, false, true);
		this.MonsterLayout = new GenericLayout<TowerMonsterItem, int>(base.GetGridLayout(3), new Func<TowerMonsterItem>(this.InitMonsterItem), null, false, true);
		TowerConfig? towerInfo = TowerClimbConfig.Instance.GetTowerInfo(TowerModel.Instance.CurrentSelectFloor);
		int[] difficultyAreaAllFloor = TowerModel.Instance.GetDifficultyAreaAllFloor(currentSelectDifficulties, towerInfo.Value.AreaNum);
		this.FloorLayout.RefreshByData(difficultyAreaAllFloor.ToList<int>(), null, false);
	}

	// Token: 0x060175C2 RID: 95682 RVA: 0x005F1060 File Offset: 0x005EF260
	protected override void OnBeforeDestroy()
	{
		this.FloorLayout.ClearChildren();
		this.FloorLayout = null;
		this.BuffShowLayout.ClearChildren();
		this.BuffShowLayout = null;
		this.TargetStarLayout.ClearChildren();
		this.TargetStarLayout = null;
		this.MonsterLayout.ClearChildren();
		this.MonsterLayout = null;
	}

	// Token: 0x060175C3 RID: 95683 RVA: 0x005F10B5 File Offset: 0x005EF2B5
	private TowerDetailItem InitFloorItem()
	{
		TowerDetailItem towerDetailItem = new TowerDetailItem();
		towerDetailItem.BindOnClickToggle(new Action<int>(this.RefreshView));
		return towerDetailItem;
	}

	// Token: 0x060175C4 RID: 95684 RVA: 0x005F10CE File Offset: 0x005EF2CE
	private TowerBuffShowItem InitBuffItem()
	{
		return new TowerBuffShowItem();
	}

	// Token: 0x060175C5 RID: 95685 RVA: 0x005F10D5 File Offset: 0x005EF2D5
	private TowerStarsComplexItem InitTargetStarItem()
	{
		return new TowerStarsComplexItem();
	}

	// Token: 0x060175C6 RID: 95686 RVA: 0x005F10DC File Offset: 0x005EF2DC
	private TowerMonsterItem InitMonsterItem()
	{
		return new TowerMonsterItem();
	}

	// Token: 0x060175C7 RID: 95687 RVA: 0x005F10E4 File Offset: 0x005EF2E4
	private void RefreshView(int towerId)
	{
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(towerId).Value;
		this.BuffShowLayout.RefreshByData(value.ShowBuffs().ToList<long>(), null, false);
		int instanceId = value.InstanceId;
		int levelText = InstanceDungeonConfig.Instance.GetRecommendLevel(instanceId, WorldLevelModel.Instance.CurWorldLevel);
		this.MonsterLayout.RefreshByData(value.ShowMonsters().ToList<int>(), delegate
		{
			foreach (TowerMonsterItem towerMonsterItem in this.MonsterLayout.GetLayoutItemList())
			{
				towerMonsterItem.SetLevelText(levelText);
			}
		}, false);
		List<ValueTuple<bool, TowerTarget>> list = new List<ValueTuple<bool, TowerTarget>>();
		List<int> floorStarsIndex = TowerModel.Instance.GetFloorStarsIndex(towerId);
		IReadOnlyList<int> readOnlyList = value.TargetConfig();
		for (int i = 0; i < 3; i++)
		{
			if (i < readOnlyList.Count)
			{
				TowerTarget? targetConfig = TowerClimbConfig.Instance.GetTargetConfig(readOnlyList[i]);
				ValueTuple<bool, TowerTarget> item = new ValueTuple<bool, TowerTarget>(floorStarsIndex != null && floorStarsIndex.Contains(i), targetConfig.Value);
				list.Add(item);
			}
		}
		this.TargetStarLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0400AECE RID: 44750
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerDetailItem, int> FloorLayout;

	// Token: 0x0400AECF RID: 44751
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerBuffShowItem, long> BuffShowLayout;

	// Token: 0x0400AED0 RID: 44752
	[Nullable(new byte[]
	{
		2,
		1,
		0
	})]
	private GenericLayout<TowerStarsComplexItem, ValueTuple<bool, TowerTarget>> TargetStarLayout;

	// Token: 0x0400AED1 RID: 44753
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerMonsterItem, int> MonsterLayout;

	// Token: 0x020091AD RID: 37293
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402F21F RID: 193055
		FloorLayout,
		// Token: 0x0402F220 RID: 193056
		ShowBuffLayout,
		// Token: 0x0402F221 RID: 193057
		TargetStarLayout,
		// Token: 0x0402F222 RID: 193058
		MonsterLayout
	}
}
