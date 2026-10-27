using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001985 RID: 6533
public class SmallItemGridMultiPlayerComponent : SmallItemGridComponent
{
	// Token: 0x0600BF05 RID: 48901 RVA: 0x002B3153 File Offset: 0x002B1353
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_PlayerIcon";
	}

	// Token: 0x0600BF06 RID: 48902 RVA: 0x002B315C File Offset: 0x002B135C
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

	// Token: 0x0600BF07 RID: 48903 RVA: 0x002B31A4 File Offset: 0x002B13A4
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

	// Token: 0x0600BF08 RID: 48904 RVA: 0x002B3294 File Offset: 0x002B1494
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

	// Token: 0x040055D2 RID: 21970
	[Nullable(1)]
	private readonly List<UUISprite> IconSprites = new List<UUISprite>();

	// Token: 0x02007EC8 RID: 32456
	private static class EComponent
	{
		// Token: 0x04029709 RID: 169737
		public const int SpriteIcon = 0;
	}
}
