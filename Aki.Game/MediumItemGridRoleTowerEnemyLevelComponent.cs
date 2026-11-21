using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DEE RID: 3566
public class MediumItemGridRoleTowerEnemyLevelComponent : MediumItemGridComponent
{
	// Token: 0x060090AD RID: 37037 RVA: 0x002B5E5C File Offset: 0x002B405C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060090AE RID: 37038 RVA: 0x002B5EA4 File Offset: 0x002B40A4
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_EnemyLevel";
	}

	// Token: 0x060090AF RID: 37039 RVA: 0x002B5EAC File Offset: 0x002B40AC
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		if (data is int)
		{
			int num = (int)data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Text_InstanceDungeonRecommendLevel_Text", new <>z__ReadOnlySingleElementList<object>(num));
			this.SetActive(true);
			return;
		}
		this.SetActive(false);
	}

	// Token: 0x060090B0 RID: 37040 RVA: 0x002B5EFA File Offset: 0x002B40FA
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007024 RID: 28708
	private class EChildType
	{
		// Token: 0x040249AD RID: 149933
		public const int LevelText = 0;
	}
}
