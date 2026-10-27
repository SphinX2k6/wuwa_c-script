using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018EC RID: 6380
public class TipsAttributeItem : UiPanelBase
{
	// Token: 0x0600BAFD RID: 47869 RVA: 0x002A56A0 File Offset: 0x002A38A0
	[NullableContext(1)]
	public TipsAttributeItem(UUIItem uiItem, ITipsAttributeItemData data)
	{
		this.Data = data;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600BAFE RID: 47870 RVA: 0x002A56BC File Offset: 0x002A38BC
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

	// Token: 0x0600BAFF RID: 47871 RVA: 0x002A5768 File Offset: 0x002A3968
	protected override void OnStart()
	{
		base.GetSprite(0).useChangeColor = !this.Data.IsMainAttribute;
		base.SetTextureByPath(this.Data.IconPath, base.GetTexture(1), null, null);
		base.GetText(2).ShowTextNew(this.Data.Name);
		base.GetText(3).SetText(AttributeModel.Instance.GetFormatAttributeValueString(this.Data.Id, this.Data.Value, this.Data.IsRatio), true);
	}

	// Token: 0x0600BB00 RID: 47872 RVA: 0x002A5800 File Offset: 0x002A3A00
	protected override void OnBeforeDestroy()
	{
		this.Data = null;
	}

	// Token: 0x040054F1 RID: 21745
	[Nullable(2)]
	private ITipsAttributeItemData Data;

	// Token: 0x02007E60 RID: 32352
	private class ETipsAttributeNode
	{
		// Token: 0x040295A9 RID: 169385
		public const int SpriteBackground = 0;

		// Token: 0x040295AA RID: 169386
		public const int TextureIcon = 1;

		// Token: 0x040295AB RID: 169387
		public const int TxtName = 2;

		// Token: 0x040295AC RID: 169388
		public const int TxtValue = 3;
	}
}
