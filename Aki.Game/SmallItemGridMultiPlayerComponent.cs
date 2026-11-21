using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000E42 RID: 3650
public class SmallItemGridMultiPlayerComponent : SmallItemGridComponent
{
	// Token: 0x0600930D RID: 37645 RVA: 0x002BE0D7 File Offset: 0x002BC2D7
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_PlayerIcon";
	}

	// Token: 0x0600930E RID: 37646 RVA: 0x002BE0E0 File Offset: 0x002BC2E0
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

	// Token: 0x0600930F RID: 37647 RVA: 0x002BE128 File Offset: 0x002BC328
	[NullableContext(2)]
	protected override void OnRefresh(object @params)
	{
		SmallItemMultiPlayer smallItemMultiPlayer = @params as SmallItemMultiPlayer;
		List<SmallItemMultiPlayerSlot> list = (smallItemMultiPlayer != null) ? smallItemMultiPlayer.Players : null;
		if (list == null || list.Count == 0)
		{
			this.SetActive(false);
			return;
		}
		this.EnsureIconCount(list.Count);
		for (int i = 0; i < this.IconSprites.Count; i++)
		{
			UUISprite uuisprite = this.IconSprites[i];
			if (i < list.Count)
			{
				SmallItemMultiPlayerSlot smallItemMultiPlayerSlot = list[i];
				string resourceId = smallItemMultiPlayerSlot.IsSelf ? SmallItemGridDefine.SelfResIdBySlot[smallItemMultiPlayerSlot.Seat] : SmallItemGridDefine.NormalResIdBySlot[smallItemMultiPlayerSlot.Seat];
				UiResourceConfig instance = UiResourceConfig.Instance;
				string path = ((instance != null) ? instance.GetResourcePath(resourceId) : null) ?? "";
				this.SetSpriteByPath(path, uuisprite, false, null, null);
				uuisprite.SetUIActive(true);
			}
			else
			{
				uuisprite.SetUIActive(false);
			}
		}
		this.SetActive(true);
	}

	// Token: 0x06009310 RID: 37648 RVA: 0x002BE218 File Offset: 0x002BC418
	private void EnsureIconCount(int count)
	{
		if (this.IconSprites.Count == 0)
		{
			this.IconSprites.Add(base.GetSprite(0));
		}
		UUISprite item = this.IconSprites[0];
		UUIItem rootItem = base.GetRootItem();
		while (this.IconSprites.Count < count)
		{
			UUISprite item2 = LguiUtil.Instance.CopyItem(item, rootItem) as UUISprite;
			this.IconSprites.Add(item2);
		}
	}

	// Token: 0x0400567F RID: 22143
	[Nullable(1)]
	private readonly List<UUISprite> IconSprites = new List<UUISprite>();

	// Token: 0x02007057 RID: 28759
	private static class EComponent
	{
		// Token: 0x04024A46 RID: 150086
		public const int SpriteIcon = 0;
	}
}
