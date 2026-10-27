using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02001901 RID: 6401
public class MediumItemGridBuffIconComponent : MediumItemGridComponent
{
	// Token: 0x0600BBB5 RID: 48053 RVA: 0x002A9028 File Offset: 0x002A7228
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

	// Token: 0x0600BBB6 RID: 48054 RVA: 0x002A9070 File Offset: 0x002A7270
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemType";
	}

	// Token: 0x0600BBB7 RID: 48055 RVA: 0x002A9078 File Offset: 0x002A7278
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

	// Token: 0x02007E7B RID: 32379
	private class EChildType
	{
		// Token: 0x04029637 RID: 169527
		public const int BuffTypeSprite = 0;
	}
}
