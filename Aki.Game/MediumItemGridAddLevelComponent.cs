using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DB7 RID: 3511
public class MediumItemGridAddLevelComponent : MediumItemGridComponent
{
	// Token: 0x06008F96 RID: 36758 RVA: 0x002B3698 File Offset: 0x002B1898
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

	// Token: 0x06008F97 RID: 36759 RVA: 0x002B3701 File Offset: 0x002B1901
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRogueRoleType";
	}

	// Token: 0x06008F98 RID: 36760 RVA: 0x002B3708 File Offset: 0x002B1908
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

	// Token: 0x02007001 RID: 28673
	private class EAddLevelComponentDefine
	{
		// Token: 0x04024961 RID: 149857
		public const int TextureIcon = 0;

		// Token: 0x04024962 RID: 149858
		public const int TxtLevel = 1;
	}
}
