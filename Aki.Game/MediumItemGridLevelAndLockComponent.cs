using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DD7 RID: 3543
public class MediumItemGridLevelAndLockComponent : MediumItemGridComponent
{
	// Token: 0x06009046 RID: 36934 RVA: 0x002B4D4C File Offset: 0x002B2F4C
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

	// Token: 0x06009047 RID: 36935 RVA: 0x002B4E39 File Offset: 0x002B3039
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

	// Token: 0x06009048 RID: 36936 RVA: 0x002B4E60 File Offset: 0x002B3060
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

	// Token: 0x06009049 RID: 36937 RVA: 0x002B4EE3 File Offset: 0x002B30E3
	public void SetLock(bool? bLock)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(bLock.GetValueOrDefault());
	}

	// Token: 0x0600904A RID: 36938 RVA: 0x002B4EFD File Offset: 0x002B30FD
	public void SetDeprecate(bool? isDeprecate)
	{
		UUISprite sprite = base.GetSprite(5);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(isDeprecate.GetValueOrDefault());
	}

	// Token: 0x0600904B RID: 36939 RVA: 0x002B4F18 File Offset: 0x002B3118
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

	// Token: 0x0600904C RID: 36940 RVA: 0x002B4F68 File Offset: 0x002B3168
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

	// Token: 0x0600904D RID: 36941 RVA: 0x002B4FE8 File Offset: 0x002B31E8
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

	// Token: 0x0600904E RID: 36942 RVA: 0x002B504D File Offset: 0x002B324D
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemState";
	}

	// Token: 0x02007013 RID: 28691
	private class EChildType
	{
		// Token: 0x04024986 RID: 149894
		public const int LockSprite = 0;

		// Token: 0x04024987 RID: 149895
		public const int LevelItem = 1;

		// Token: 0x04024988 RID: 149896
		public const int LevelText = 2;

		// Token: 0x04024989 RID: 149897
		public const int VisionLevelItem = 3;

		// Token: 0x0402498A RID: 149898
		public const int VisionLevelText = 4;

		// Token: 0x0402498B RID: 149899
		public const int DeprecateSprite = 5;
	}
}
