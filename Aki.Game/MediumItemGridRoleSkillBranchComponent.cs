using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001932 RID: 6450
public class MediumItemGridRoleSkillBranchComponent : MediumItemGridComponent
{
	// Token: 0x0600BCB3 RID: 48307 RVA: 0x002AB384 File Offset: 0x002A9584
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

	// Token: 0x0600BCB4 RID: 48308 RVA: 0x002AB3CC File Offset: 0x002A95CC
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRoleTag";
	}

	// Token: 0x0600BCB5 RID: 48309 RVA: 0x002AB3D4 File Offset: 0x002A95D4
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

	// Token: 0x02007E97 RID: 32407
	private class EComponent
	{
		// Token: 0x04029675 RID: 169589
		public const int ItemTag = 0;
	}
}
