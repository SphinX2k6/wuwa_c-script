using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x020013C5 RID: 5061
public class NewPlayerSupportRoleCommonItem : NewPlayerSupportRoleBaseItem
{
	// Token: 0x06008EDA RID: 36570 RVA: 0x001ED754 File Offset: 0x001EB954
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

	// Token: 0x06008EDB RID: 36571 RVA: 0x001ED820 File Offset: 0x001EBA20
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

	// Token: 0x02007A46 RID: 31302
	private class EComponentType
	{
		// Token: 0x040283F2 RID: 164850
		public const int ContentTexture = 0;

		// Token: 0x040283F3 RID: 164851
		public const int DescItem1 = 1;

		// Token: 0x040283F4 RID: 164852
		public const int DescItem2 = 2;

		// Token: 0x040283F5 RID: 164853
		public const int DescItem3 = 3;

		// Token: 0x040283F6 RID: 164854
		public const int ThemeTextTexture = 4;
	}
}
