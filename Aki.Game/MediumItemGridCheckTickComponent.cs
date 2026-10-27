using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001905 RID: 6405
[NullableContext(1)]
[Nullable(0)]
public class MediumItemGridCheckTickComponent : MediumItemGridComponent
{
	// Token: 0x0600BBCC RID: 48076 RVA: 0x002A9194 File Offset: 0x002A7394
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

	// Token: 0x0600BBCD RID: 48077 RVA: 0x002A91FD File Offset: 0x002A73FD
	protected override string GetResourceId()
	{
		return "UiItem_ItemSelTick";
	}

	// Token: 0x0600BBCE RID: 48078 RVA: 0x002A9204 File Offset: 0x002A7404
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

	// Token: 0x0600BBCF RID: 48079 RVA: 0x002A9280 File Offset: 0x002A7480
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

	// Token: 0x0600BBD0 RID: 48080 RVA: 0x002A92A6 File Offset: 0x002A74A6
	public void SetSpriteAlpha(float alpha)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetAlpha(alpha);
	}

	// Token: 0x0600BBD1 RID: 48081 RVA: 0x002A92BC File Offset: 0x002A74BC
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

	// Token: 0x0600BBD2 RID: 48082 RVA: 0x002A92E2 File Offset: 0x002A74E2
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007E7C RID: 32380
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04029638 RID: 169528
		public const int Sprite = 0;

		// Token: 0x04029639 RID: 169529
		public const int SpriteTick = 1;
	}
}
