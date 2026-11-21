using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DEC RID: 3564
public class MediumItemGridRoleSkillBranchComponent : MediumItemGridComponent
{
	// Token: 0x060090A4 RID: 37028 RVA: 0x002B5C7C File Offset: 0x002B3E7C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060090A5 RID: 37029 RVA: 0x002B5CC4 File Offset: 0x002B3EC4
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRoleTag";
	}

	// Token: 0x060090A6 RID: 37030 RVA: 0x002B5CCC File Offset: 0x002B3ECC
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		if (data is int)
		{
			int num = (int)data;
			this.SetActive(true);
			UUIItem item = base.GetItem(0);
			int num2 = (num == 0) ? 0 : 180;
			FVector fvector = new FVector(0f, (float)num2, 0f);
			FRotator frotator = FRotator.MakeFromEuler(fvector);
			item.SetUIRelativeRotation(frotator);
			return;
		}
	}

	// Token: 0x02007020 RID: 28704
	private class EComponent
	{
		// Token: 0x040249A7 RID: 149927
		public const int ItemTag = 0;
	}
}
