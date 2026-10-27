using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002BFC RID: 11260
public class TowerMonsterItem : GridProxyAbstract<int>
{
	// Token: 0x06017631 RID: 95793 RVA: 0x005F38C4 File Offset: 0x005F1AC4
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

	// Token: 0x06017632 RID: 95794 RVA: 0x005F396F File Offset: 0x005F1B6F
	protected override void OnStart()
	{
		this.ElementLayout = new GenericLayout<TowerElementItem, int>(base.GetHorizontalLayout(3), new Func<TowerElementItem>(this.CreateElementItem), null, false, true);
	}

	// Token: 0x06017633 RID: 95795 RVA: 0x005F3994 File Offset: 0x005F1B94
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		string monsterIcon = MonsterInfoConfig.Instance.GetMonsterIcon(data);
		base.SetTextureByPath(monsterIcon, base.GetTexture(2), null, null);
		int[] source = MonsterInfoConfig.Instance.GetMonsterInfoConfig(data).Value.ElementIdArray();
		GenericLayout<TowerElementItem, int> elementLayout = this.ElementLayout;
		if (elementLayout != null)
		{
			elementLayout.RefreshByData(source.ToList<int>(), null, false);
		}
		string monsterName = MonsterInfoConfig.Instance.GetMonsterName(data);
		base.GetText(0).SetText(monsterName, true);
		int instanceId = TowerClimbConfig.Instance.GetTowerInfo(TowerModel.Instance.CurrentSelectFloor).Value.InstanceId;
		int recommendLevel = InstanceDungeonConfig.Instance.GetRecommendLevel(instanceId, WorldLevelModel.Instance.CurWorldLevel);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_InstanceDungeonRecommendLevel_Text", new <>z__ReadOnlySingleElementList<object>(recommendLevel));
	}

	// Token: 0x06017634 RID: 95796 RVA: 0x005F3A78 File Offset: 0x005F1C78
	public void SetLevelText(int level)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_InstanceDungeonRecommendLevel_Text", new <>z__ReadOnlySingleElementList<object>(level));
	}

	// Token: 0x06017635 RID: 95797 RVA: 0x005F3A9B File Offset: 0x005F1C9B
	[NullableContext(1)]
	private TowerElementItem CreateElementItem()
	{
		return new TowerElementItem();
	}

	// Token: 0x0400AEF9 RID: 44793
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerElementItem, int> ElementLayout;

	// Token: 0x020091C0 RID: 37312
	private enum EChildType
	{
		// Token: 0x0402F284 RID: 193156
		NameText,
		// Token: 0x0402F285 RID: 193157
		LevelText,
		// Token: 0x0402F286 RID: 193158
		MonsterTexture,
		// Token: 0x0402F287 RID: 193159
		ElementLayout
	}
}
