using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x020018FE RID: 6398
public class MediumItemGridAddLevelComponent : MediumItemGridComponent
{
	// Token: 0x0600BBAC RID: 48044 RVA: 0x002A8F3C File Offset: 0x002A713C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BBAD RID: 48045 RVA: 0x002A8FA5 File Offset: 0x002A71A5
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRogueRoleType";
	}

	// Token: 0x0600BBAE RID: 48046 RVA: 0x002A8FAC File Offset: 0x002A71AC
	[NullableContext(2)]
	protected override void OnRefresh(object @params = null)
	{
		if (!(@params is int))
		{
			return;
		}
		int num = (int)@params;
		if (num == 0)
		{
			this.SetActive(false);
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_LevelShow_Text", new <>z__ReadOnlySingleElementList<object>(num));
		this.SetActive(true);
	}

	// Token: 0x02007E7A RID: 32378
	private class EAddLevelComponentDefine
	{
		// Token: 0x04029635 RID: 169525
		public const int TextureIcon = 0;

		// Token: 0x04029636 RID: 169526
		public const int TxtLevel = 1;
	}
}
