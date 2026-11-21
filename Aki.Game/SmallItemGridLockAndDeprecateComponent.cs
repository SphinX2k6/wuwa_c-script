using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000E3B RID: 3643
public class SmallItemGridLockAndDeprecateComponent : SmallItemGridComponent
{
	// Token: 0x06009301 RID: 37633 RVA: 0x002BDFBE File Offset: 0x002BC1BE
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_InventoryItemState";
	}

	// Token: 0x06009302 RID: 37634 RVA: 0x002BDFC8 File Offset: 0x002BC1C8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009303 RID: 37635 RVA: 0x002BE034 File Offset: 0x002BC234
	[NullableContext(2)]
	protected override void OnRefresh(object tempData)
	{
		ISmallItemGridLockAndDeprecate smallItemGridLockAndDeprecate = (ISmallItemGridLockAndDeprecate)tempData;
		bool valueOrDefault = smallItemGridLockAndDeprecate.IsLock.GetValueOrDefault();
		bool valueOrDefault2 = smallItemGridLockAndDeprecate.IsDeprecate.GetValueOrDefault();
		base.GetSprite(0).SetUIActive(valueOrDefault);
		base.GetSprite(1).SetUIActive(valueOrDefault2);
		this.SetActive(valueOrDefault || valueOrDefault2);
	}

	// Token: 0x02007056 RID: 28758
	private enum EComponent
	{
		// Token: 0x04024A44 RID: 150084
		SpriteLock,
		// Token: 0x04024A45 RID: 150085
		SpriteDeprecate
	}
}
