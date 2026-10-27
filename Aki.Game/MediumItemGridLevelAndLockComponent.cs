using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200191E RID: 6430
public class MediumItemGridLevelAndLockComponent : MediumItemGridComponent
{
	// Token: 0x0600BC5C RID: 48220 RVA: 0x002AA5F0 File Offset: 0x002A87F0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BC5D RID: 48221 RVA: 0x002AA6DD File Offset: 0x002A88DD
	protected override void OnActivate()
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0600BC5E RID: 48222 RVA: 0x002AA704 File Offset: 0x002A8904
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		IMediumLevelAndLock mediumLevelAndLock = data as IMediumLevelAndLock;
		if (mediumLevelAndLock == null)
		{
			this.SetActive(false);
			return;
		}
		this.SetLevel(mediumLevelAndLock.Level, mediumLevelAndLock.IsUseVision, mediumLevelAndLock.IsLevelInfinite);
		this.SetLock(mediumLevelAndLock.IsLockVisible);
		this.SetDeprecate(mediumLevelAndLock.IsDeprecate);
		UUIText text = base.GetText(2);
		if (text != null)
		{
			UUIItem uuiitem = text;
			bool valueOrDefault = mediumLevelAndLock.IsLevelUseChangeColor.GetValueOrDefault();
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(valueOrDefault, fcolor);
		}
		this.SetActive(true);
	}

	// Token: 0x0600BC5F RID: 48223 RVA: 0x002AA787 File Offset: 0x002A8987
	public void SetLock(bool? bLock)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(bLock.GetValueOrDefault());
	}

	// Token: 0x0600BC60 RID: 48224 RVA: 0x002AA7A1 File Offset: 0x002A89A1
	public void SetDeprecate(bool? isDeprecate)
	{
		UUISprite sprite = base.GetSprite(5);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(isDeprecate.GetValueOrDefault());
	}

	// Token: 0x0600BC61 RID: 48225 RVA: 0x002AA7BC File Offset: 0x002A89BC
	public void SetLevel(int? level, bool? useVision = false, bool? isLevelInfinite = null)
	{
		if (useVision.GetValueOrDefault())
		{
			this.SetNormalLevel(null, null);
			this.SetVisionLevel(level);
			return;
		}
		this.SetVisionLevel(null);
		this.SetNormalLevel(level, isLevelInfinite);
	}

	// Token: 0x0600BC62 RID: 48226 RVA: 0x002AA80C File Offset: 0x002A8A0C
	private void SetNormalLevel(int? level, bool? isLevelInfinite = null)
	{
		UUIItem item = base.GetItem(1);
		if (level == null && !isLevelInfinite.GetValueOrDefault())
		{
			if (item != null && item.IsUIActiveSelf())
			{
				item.SetUIActive(false);
			}
			return;
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetText(isLevelInfinite.GetValueOrDefault() ? "∞" : level.Value.ToString(), true);
		}
		if (item != null && !item.IsUIActiveSelf())
		{
			item.SetUIActive(true);
		}
	}

	// Token: 0x0600BC63 RID: 48227 RVA: 0x002AA88C File Offset: 0x002A8A8C
	private void SetVisionLevel(int? level)
	{
		UUIItem item = base.GetItem(3);
		if (level == null)
		{
			if (item != null && item.IsUIActiveSelf())
			{
				item.SetUIActive(false);
			}
			return;
		}
		UUIText text = base.GetText(4);
		if (text != null)
		{
			text.SetText(level.Value.ToString(), true);
		}
		if (item != null && !item.IsUIActiveSelf())
		{
			item.SetUIActive(true);
		}
	}

	// Token: 0x0600BC64 RID: 48228 RVA: 0x002AA8F1 File Offset: 0x002A8AF1
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemState";
	}

	// Token: 0x02007E8C RID: 32396
	private class EChildType
	{
		// Token: 0x0402965A RID: 169562
		public const int LockSprite = 0;

		// Token: 0x0402965B RID: 169563
		public const int LevelItem = 1;

		// Token: 0x0402965C RID: 169564
		public const int LevelText = 2;

		// Token: 0x0402965D RID: 169565
		public const int VisionLevelItem = 3;

		// Token: 0x0402965E RID: 169566
		public const int VisionLevelText = 4;

		// Token: 0x0402965F RID: 169567
		public const int DeprecateSprite = 5;
	}
}
