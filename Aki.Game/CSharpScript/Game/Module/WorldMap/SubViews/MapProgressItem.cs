using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews
{
	// Token: 0x020047BC RID: 18364
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MapProgressItem : GridProxyAbstract<MapProgressItemData>
	{
		// Token: 0x060301C8 RID: 197064 RVA: 0x00B26D2C File Offset: 0x00B24F2C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060301C9 RID: 197065 RVA: 0x00B26DF8 File Offset: 0x00B24FF8
		[NullableContext(1)]
		public override void Refresh(MapProgressItemData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TitleTextId, Array.Empty<object>());
			string resourceId = data.Completed ? "T_MapDifficultyTick" : "T_MapDifficultyEmpty";
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath(resourceId), base.GetTexture(1), null, null);
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(data.CountText, true);
			}
			if (!string.IsNullOrEmpty(data.IconPath))
			{
				this.SetSpriteByPath(data.IconPath, base.GetSprite(6), false, null, null);
			}
		}

		// Token: 0x0200AA7F RID: 43647
		public static class EComponent
		{
			// Token: 0x04033E05 RID: 212485
			public const int TxtTitle = 0;

			// Token: 0x04033E06 RID: 212486
			public const int TexState = 1;

			// Token: 0x04033E07 RID: 212487
			public const int PnlGift = 2;

			// Token: 0x04033E08 RID: 212488
			public const int TxtCount = 3;

			// Token: 0x04033E09 RID: 212489
			public const int SprIcon = 6;
		}
	}
}
