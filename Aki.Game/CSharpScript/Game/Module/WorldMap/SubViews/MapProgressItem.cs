using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews
{
	// Token: 0x020036ED RID: 14061
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MapProgressItem : GridProxyAbstract<MapProgressItemData>
	{
		// Token: 0x06024998 RID: 149912 RVA: 0x00A56B38 File Offset: 0x00A54D38
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

		// Token: 0x06024999 RID: 149913 RVA: 0x00A56C04 File Offset: 0x00A54E04
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

		// Token: 0x02009432 RID: 37938
		public static class EComponent
		{
			// Token: 0x0402E58E RID: 189838
			public const int TxtTitle = 0;

			// Token: 0x0402E58F RID: 189839
			public const int TexState = 1;

			// Token: 0x0402E590 RID: 189840
			public const int PnlGift = 2;

			// Token: 0x0402E591 RID: 189841
			public const int TxtCount = 3;

			// Token: 0x0402E592 RID: 189842
			public const int SprIcon = 6;
		}
	}
}
