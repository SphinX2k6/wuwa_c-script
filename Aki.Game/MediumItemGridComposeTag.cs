using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02000DC0 RID: 3520
public class MediumItemGridComposeTag : MediumItemGridComponent
{
	// Token: 0x06008FBF RID: 36799 RVA: 0x002B3A54 File Offset: 0x002B1C54
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008FC0 RID: 36800 RVA: 0x002B3AFF File Offset: 0x002B1CFF
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ComposeItem";
	}

	// Token: 0x06008FC1 RID: 36801 RVA: 0x002B3B08 File Offset: 0x002B1D08
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		CSharpScript.Game.Module.Common.MediumItemGrid.MediumItemGridComposeTag mediumItemGridComposeTag = data as CSharpScript.Game.Module.Common.MediumItemGrid.MediumItemGridComposeTag;
		if (mediumItemGridComposeTag == null)
		{
			return;
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(mediumItemGridComposeTag.IsRefreshItem);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 != null)
		{
			item2.SetUIActive(mediumItemGridComposeTag.IsLimitTimeItem);
		}
		this.RefreshBuffIcon(mediumItemGridComposeTag.BuffItem);
		this.SetActive(mediumItemGridComposeTag.IsRefreshItem || mediumItemGridComposeTag.IsLimitTimeItem || mediumItemGridComposeTag.BuffItem > EMediumItemGridBuffType.None);
	}

	// Token: 0x06008FC2 RID: 36802 RVA: 0x002B3B80 File Offset: 0x002B1D80
	protected void RefreshBuffIcon(EMediumItemGridBuffType buffIconType)
	{
		if (buffIconType == EMediumItemGridBuffType.None)
		{
			UUISprite sprite = base.GetSprite(3);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
			return;
		}
		else
		{
			UUISprite sprite2 = base.GetSprite(3);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(true);
			}
			string text = null;
			MediumItemGridModel instance = MediumItemGridModel.Instance;
			switch (buffIconType)
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
				return;
			}
			UUISprite sprite3 = base.GetSprite(3);
			this.SetSpriteByPath(text, sprite3, false, null, null);
			return;
		}
	}

	// Token: 0x02007004 RID: 28676
	private class EChildType
	{
		// Token: 0x04024966 RID: 149862
		public const int RootItem = 0;

		// Token: 0x04024967 RID: 149863
		public const int LimitTimeItem = 1;

		// Token: 0x04024968 RID: 149864
		public const int RefreshItem = 2;

		// Token: 0x04024969 RID: 149865
		public const int BuffSprite = 3;
	}
}
