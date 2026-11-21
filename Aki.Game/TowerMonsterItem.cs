using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002177 RID: 8567
public class TowerMonsterItem : GridProxyAbstract<int>
{
	// Token: 0x06015062 RID: 86114 RVA: 0x006203FC File Offset: 0x0061E5FC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06015063 RID: 86115 RVA: 0x006204A7 File Offset: 0x0061E6A7
	protected override void OnStart()
	{
		this.ElementLayout = new GenericLayout<TowerElementItem, int>(base.GetHorizontalLayout(3), new Func<TowerElementItem>(this.CreateElementItem), null, false, true);
	}

	// Token: 0x06015064 RID: 86116 RVA: 0x006204CC File Offset: 0x0061E6CC
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		string monsterIcon = MonsterInfoConfig.Instance.GetMonsterIcon(data);
		base.SetTextureByPath(monsterIcon, base.GetTexture(2), null, null);
		int[] data2 = MonsterInfoConfig.Instance.GetMonsterInfoConfig(data).Value.ElementIdArray();
		GenericLayout<TowerElementItem, int> elementLayout = this.ElementLayout;
		if (elementLayout != null)
		{
			elementLayout.RefreshByData(data2, null, false);
		}
		string monsterName = MonsterInfoConfig.Instance.GetMonsterName(data);
		base.GetText(0).SetText(monsterName, true);
		int instanceId = TowerClimbConfig.Instance.GetTowerInfo(TowerModel.Instance.CurrentSelectFloor).Value.InstanceId;
		int recommendLevel = InstanceDungeonConfig.Instance.GetRecommendLevel(instanceId, WorldLevelModel.Instance.CurWorldLevel);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_InstanceDungeonRecommendLevel_Text", new <>z__ReadOnlySingleElementList<object>(recommendLevel));
	}

	// Token: 0x06015065 RID: 86117 RVA: 0x006205AB File Offset: 0x0061E7AB
	public void SetLevelText(int level)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_InstanceDungeonRecommendLevel_Text", new <>z__ReadOnlySingleElementList<object>(level));
	}

	// Token: 0x06015066 RID: 86118 RVA: 0x006205CE File Offset: 0x0061E7CE
	[NullableContext(1)]
	private TowerElementItem CreateElementItem()
	{
		return new TowerElementItem();
	}

	// Token: 0x0400B2FE RID: 45822
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerElementItem, int> ElementLayout;

	// Token: 0x02008403 RID: 33795
	private enum EChildType
	{
		// Token: 0x0402A985 RID: 174469
		NameText,
		// Token: 0x0402A986 RID: 174470
		LevelText,
		// Token: 0x0402A987 RID: 174471
		MonsterTexture,
		// Token: 0x0402A988 RID: 174472
		ElementLayout
	}
}
