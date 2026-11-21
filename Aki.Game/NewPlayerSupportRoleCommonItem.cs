using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000879 RID: 2169
public class NewPlayerSupportRoleCommonItem : NewPlayerSupportRoleBaseItem
{
	// Token: 0x0600626F RID: 25199 RVA: 0x001F6274 File Offset: 0x001F4474
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006270 RID: 25200 RVA: 0x001F6340 File Offset: 0x001F4540
	public override void Refresh()
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(3);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		base.SetTextureByPath(this.TrialRoleInfo.Value.ContentTexturePath, base.GetTexture(4), null, null);
	}

	// Token: 0x02006BCC RID: 27596
	private class EComponentType
	{
		// Token: 0x0402370F RID: 145167
		public const int ContentTexture = 0;

		// Token: 0x04023710 RID: 145168
		public const int DescItem1 = 1;

		// Token: 0x04023711 RID: 145169
		public const int DescItem2 = 2;

		// Token: 0x04023712 RID: 145170
		public const int DescItem3 = 3;

		// Token: 0x04023713 RID: 145171
		public const int ThemeTextTexture = 4;
	}
}
