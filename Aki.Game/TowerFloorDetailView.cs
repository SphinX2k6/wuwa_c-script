using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200216B RID: 8555
[NullableContext(1)]
[Nullable(0)]
public class TowerFloorDetailView : UiViewBase
{
	// Token: 0x06014FF0 RID: 86000 RVA: 0x0061DA2A File Offset: 0x0061BC2A
	public TowerFloorDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014FF1 RID: 86001 RVA: 0x0061DA34 File Offset: 0x0061BC34
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

	// Token: 0x06014FF2 RID: 86002 RVA: 0x0061DAE0 File Offset: 0x0061BCE0
	protected override void OnStart()
	{
		int currentSelectDifficulties = TowerModel.Instance.CurrentSelectDifficulties;
		this.FloorLayout = new GenericLayout<TowerDetailItem, int>(base.GetHorizontalLayout(0), new Func<TowerDetailItem>(this.InitFloorItem), null, false, true);
		this.BuffShowLayout = new GenericLayout<TowerBuffShowItem, long>(base.GetVerticalLayout(1), new Func<TowerBuffShowItem>(this.InitBuffItem), null, false, true);
		this.TargetStarLayout = new GenericLayout<TowerStarsComplexItem, ValueTuple<bool, TowerTarget>>(base.GetVerticalLayout(2), new Func<TowerStarsComplexItem>(this.InitTargetStarItem), null, false, true);
		this.MonsterLayout = new GenericLayout<TowerMonsterItem, int>(base.GetGridLayout(3), new Func<TowerMonsterItem>(this.InitMonsterItem), null, false, true);
		TowerConfig? towerInfo = TowerClimbConfig.Instance.GetTowerInfo(TowerModel.Instance.CurrentSelectFloor);
		int[] difficultyAreaAllFloor = TowerModel.Instance.GetDifficultyAreaAllFloor(currentSelectDifficulties, towerInfo.Value.AreaNum);
		this.FloorLayout.RefreshByData(difficultyAreaAllFloor, null, false);
	}

	// Token: 0x06014FF3 RID: 86003 RVA: 0x0061DBBC File Offset: 0x0061BDBC
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

	// Token: 0x06014FF4 RID: 86004 RVA: 0x0061DC11 File Offset: 0x0061BE11
	private TowerDetailItem InitFloorItem()
	{
		TowerDetailItem towerDetailItem = new TowerDetailItem();
		towerDetailItem.BindOnClickToggle(new Action<int>(this.RefreshView));
		return towerDetailItem;
	}

	// Token: 0x06014FF5 RID: 86005 RVA: 0x0061DC2A File Offset: 0x0061BE2A
	private TowerBuffShowItem InitBuffItem()
	{
		return new TowerBuffShowItem();
	}

	// Token: 0x06014FF6 RID: 86006 RVA: 0x0061DC31 File Offset: 0x0061BE31
	private TowerStarsComplexItem InitTargetStarItem()
	{
		return new TowerStarsComplexItem();
	}

	// Token: 0x06014FF7 RID: 86007 RVA: 0x0061DC38 File Offset: 0x0061BE38
	private TowerMonsterItem InitMonsterItem()
	{
		return new TowerMonsterItem();
	}

	// Token: 0x06014FF8 RID: 86008 RVA: 0x0061DC40 File Offset: 0x0061BE40
	private void RefreshView(int towerId)
	{
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(towerId).Value;
		this.BuffShowLayout.RefreshByData(value.ShowBuffs(), null, false);
		int instanceId = value.InstanceId;
		int levelText = InstanceDungeonConfig.Instance.GetRecommendLevel(instanceId, WorldLevelModel.Instance.CurWorldLevel);
		this.MonsterLayout.RefreshByData(value.ShowMonsters(), delegate
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

	// Token: 0x0400B2D3 RID: 45779
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerDetailItem, int> FloorLayout;

	// Token: 0x0400B2D4 RID: 45780
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerBuffShowItem, long> BuffShowLayout;

	// Token: 0x0400B2D5 RID: 45781
	[Nullable(new byte[]
	{
		2,
		1,
		0
	})]
	private GenericLayout<TowerStarsComplexItem, ValueTuple<bool, TowerTarget>> TargetStarLayout;

	// Token: 0x0400B2D6 RID: 45782
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerMonsterItem, int> MonsterLayout;

	// Token: 0x020083F0 RID: 33776
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A920 RID: 174368
		FloorLayout,
		// Token: 0x0402A921 RID: 174369
		ShowBuffLayout,
		// Token: 0x0402A922 RID: 174370
		TargetStarLayout,
		// Token: 0x0402A923 RID: 174371
		MonsterLayout
	}
}
