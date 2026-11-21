using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000DA5 RID: 3493
public class TipsAttributeItem : UiPanelBase
{
	// Token: 0x06008EE7 RID: 36583 RVA: 0x002AFE10 File Offset: 0x002AE010
	[NullableContext(1)]
	public TipsAttributeItem(UUIItem uiItem, ITipsAttributeItemData data)
	{
		this.Data = data;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06008EE8 RID: 36584 RVA: 0x002AFE2C File Offset: 0x002AE02C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008EE9 RID: 36585 RVA: 0x002AFED8 File Offset: 0x002AE0D8
	protected override void OnStart()
	{
		base.GetSprite(0).useChangeColor = !this.Data.IsMainAttribute;
		base.SetTextureByPath(this.Data.IconPath, base.GetTexture(1), null, null);
		base.GetText(2).ShowTextNew(this.Data.Name);
		base.GetText(3).SetText(AttributeModel.Instance.GetFormatAttributeValueString(this.Data.Id, this.Data.Value, this.Data.IsRatio), true);
	}

	// Token: 0x06008EEA RID: 36586 RVA: 0x002AFF70 File Offset: 0x002AE170
	protected override void OnBeforeDestroy()
	{
		this.Data = null;
	}

	// Token: 0x0400559C RID: 21916
	[Nullable(2)]
	private ITipsAttributeItemData Data;

	// Token: 0x02006FE7 RID: 28647
	private class ETipsAttributeNode
	{
		// Token: 0x040248D6 RID: 149718
		public const int SpriteBackground = 0;

		// Token: 0x040248D7 RID: 149719
		public const int TextureIcon = 1;

		// Token: 0x040248D8 RID: 149720
		public const int TxtName = 2;

		// Token: 0x040248D9 RID: 149721
		public const int TxtValue = 3;
	}
}
