using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02001907 RID: 6407
public class MediumItemGridComposeTag : MediumItemGridComponent
{
	// Token: 0x0600BBD5 RID: 48085 RVA: 0x002A92F8 File Offset: 0x002A74F8
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

	// Token: 0x0600BBD6 RID: 48086 RVA: 0x002A93A3 File Offset: 0x002A75A3
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ComposeItem";
	}

	// Token: 0x0600BBD7 RID: 48087 RVA: 0x002A93AC File Offset: 0x002A75AC
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

	// Token: 0x0600BBD8 RID: 48088 RVA: 0x002A9424 File Offset: 0x002A7624
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

	// Token: 0x02007E7D RID: 32381
	private class EChildType
	{
		// Token: 0x0402963A RID: 169530
		public const int RootItem = 0;

		// Token: 0x0402963B RID: 169531
		public const int LimitTimeItem = 1;

		// Token: 0x0402963C RID: 169532
		public const int RefreshItem = 2;

		// Token: 0x0402963D RID: 169533
		public const int BuffSprite = 3;
	}
}
