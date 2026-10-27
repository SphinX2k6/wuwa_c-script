using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200197E RID: 6526
public class SmallItemGridLockAndDeprecateComponent : SmallItemGridComponent
{
	// Token: 0x0600BEF9 RID: 48889 RVA: 0x002B303A File Offset: 0x002B123A
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_InventoryItemState";
	}

	// Token: 0x0600BEFA RID: 48890 RVA: 0x002B3044 File Offset: 0x002B1244
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

	// Token: 0x0600BEFB RID: 48891 RVA: 0x002B30B0 File Offset: 0x002B12B0
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

	// Token: 0x02007EC7 RID: 32455
	private enum EComponent
	{
		// Token: 0x04029707 RID: 169735
		SpriteLock,
		// Token: 0x04029708 RID: 169736
		SpriteDeprecate
	}
}
