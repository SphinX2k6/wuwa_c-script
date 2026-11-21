using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02000DBA RID: 3514
public class MediumItemGridBuffIconComponent : MediumItemGridComponent
{
	// Token: 0x06008F9F RID: 36767 RVA: 0x002B3784 File Offset: 0x002B1984
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008FA0 RID: 36768 RVA: 0x002B37CC File Offset: 0x002B19CC
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemType";
	}

	// Token: 0x06008FA1 RID: 36769 RVA: 0x002B37D4 File Offset: 0x002B19D4
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		if (!(data is EMediumItemGridBuffType))
		{
			this.SetActive(false);
			return;
		}
		EMediumItemGridBuffType emediumItemGridBuffType = (EMediumItemGridBuffType)data;
		string text = null;
		MediumItemGridModel instance = MediumItemGridModel.Instance;
		switch (emediumItemGridBuffType)
		{
		case EMediumItemGridBuffType.Attack:
			text = instance.AttackBuffSpritePath;
			break;
		case EMediumItemGridBuffType.Defense:
			text = instance.DefenseBuffSpritePath;
			break;
		case EMediumItemGridBuffType.RestoreHealth:
			text = instance.RestoreHealthBuffSpritePath;
			break;
		case EMediumItemGridBuffType.Recharge:
			text = instance.RechargeBuffSpritePath;
			break;
		case EMediumItemGridBuffType.Resurrection:
			text = instance.ResurrectionBuffSpritePath;
			break;
		case EMediumItemGridBuffType.Explore:
			text = instance.ExploreBuffSpritePath;
			break;
		}
		if (string.IsNullOrEmpty(text))
		{
			this.SetActive(false);
			return;
		}
		UUISprite sprite = base.GetSprite(0);
		this.SetSpriteByPath(text, sprite, false, null, null);
		this.SetActive(true);
	}

	// Token: 0x02007002 RID: 28674
	private class EChildType
	{
		// Token: 0x04024963 RID: 149859
		public const int BuffTypeSprite = 0;
	}
}
