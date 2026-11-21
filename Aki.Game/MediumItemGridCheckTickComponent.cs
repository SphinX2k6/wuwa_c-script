using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DBE RID: 3518
[NullableContext(1)]
[Nullable(0)]
public class MediumItemGridCheckTickComponent : MediumItemGridComponent
{
	// Token: 0x06008FB6 RID: 36790 RVA: 0x002B38F0 File Offset: 0x002B1AF0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008FB7 RID: 36791 RVA: 0x002B3959 File Offset: 0x002B1B59
	protected override string GetResourceId()
	{
		return "UiItem_ItemSelTick";
	}

	// Token: 0x06008FB8 RID: 36792 RVA: 0x002B3960 File Offset: 0x002B1B60
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		IMediumItemGridCheckTickComponentParams mediumItemGridCheckTickComponentParams = data as IMediumItemGridCheckTickComponentParams;
		if (mediumItemGridCheckTickComponentParams == null)
		{
			return;
		}
		bool? isCheckTick = mediumItemGridCheckTickComponentParams.IsCheckTick;
		if (isCheckTick != null)
		{
			this.SetActive(isCheckTick.Value);
			string hexColor = mediumItemGridCheckTickComponentParams.HexColor;
			if (hexColor != null)
			{
				this.SetSpriteColor(hexColor);
			}
			float? alpha = mediumItemGridCheckTickComponentParams.Alpha;
			if (alpha != null)
			{
				this.SetSpriteAlpha(alpha.Value);
			}
			string tickHexColor = mediumItemGridCheckTickComponentParams.TickHexColor;
			if (tickHexColor != null)
			{
				this.SetSpriteTickColor(tickHexColor);
			}
			return;
		}
	}

	// Token: 0x06008FB9 RID: 36793 RVA: 0x002B39DC File Offset: 0x002B1BDC
	public void SetSpriteColor(string hexColor)
	{
		FColor color = FColor.FromHex(hexColor);
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetColor(color);
	}

	// Token: 0x06008FBA RID: 36794 RVA: 0x002B3A02 File Offset: 0x002B1C02
	public void SetSpriteAlpha(float alpha)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetAlpha(alpha);
	}

	// Token: 0x06008FBB RID: 36795 RVA: 0x002B3A18 File Offset: 0x002B1C18
	public void SetSpriteTickColor(string hexColor)
	{
		FColor color = FColor.FromHex(hexColor);
		UUISprite sprite = base.GetSprite(1);
		if (sprite == null)
		{
			return;
		}
		sprite.SetColor(color);
	}

	// Token: 0x06008FBC RID: 36796 RVA: 0x002B3A3E File Offset: 0x002B1C3E
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007003 RID: 28675
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04024964 RID: 149860
		public const int Sprite = 0;

		// Token: 0x04024965 RID: 149861
		public const int SpriteTick = 1;
	}
}
