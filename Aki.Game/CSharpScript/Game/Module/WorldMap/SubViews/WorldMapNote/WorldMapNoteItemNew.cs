using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapNote
{
	// Token: 0x020047DF RID: 18399
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class WorldMapNoteItemNew : GridProxyAbstract<WorldMapNoteItemData>
	{
		// Token: 0x06030329 RID: 197417 RVA: 0x00B2B92C File Offset: 0x00B29B2C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603032A RID: 197418 RVA: 0x00B2BA78 File Offset: 0x00B29C78
		[NullableContext(1)]
		public override void Refresh(WorldMapNoteItemData data, bool isSelected, int gridIndex)
		{
			this.DataParam = data;
			UUISprite sprite = base.GetSprite(0);
			this.SetSpriteByPath(data.IconRes, sprite, true, null, null);
			UUIText text = base.GetText(1);
			if (!string.IsNullOrEmpty(data.CustomDesc))
			{
				if (text != null)
				{
					text.SetText(data.CustomDesc, true);
				}
			}
			else if (text != null)
			{
				text.ShowTextNew(data.DescId);
			}
			EMapNoteStyle noteStyle = data.NoteStyle;
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(noteStyle == EMapNoteStyle.Normal);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(noteStyle == EMapNoteStyle.Normal);
			}
			UUIItem item3 = base.GetItem(4);
			if (item3 != null)
			{
				item3.SetUIActive(noteStyle == EMapNoteStyle.Available);
			}
			UUIItem item4 = base.GetItem(5);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(noteStyle == EMapNoteStyle.Available);
		}

		// Token: 0x0603032B RID: 197419 RVA: 0x00B2BB40 File Offset: 0x00B29D40
		private void OnClick()
		{
			if (this.DataParam != null)
			{
				this.DataParam.ClickCallback(this.DataParam.Id);
			}
		}

		// Token: 0x04019F52 RID: 106322
		[Nullable(2)]
		private WorldMapNoteItemData DataParam;

		// Token: 0x0200AA98 RID: 43672
		public static class EChildType
		{
			// Token: 0x04033E68 RID: 212584
			public const int SpriteIcon = 0;

			// Token: 0x04033E69 RID: 212585
			public const int TxtDesc = 1;

			// Token: 0x04033E6A RID: 212586
			public const int BtnNote = 2;

			// Token: 0x04033E6B RID: 212587
			public const int ItemNormalBg = 3;

			// Token: 0x04033E6C RID: 212588
			public const int ItemReceivedBg = 4;

			// Token: 0x04033E6D RID: 212589
			public const int ItemAvailable = 5;

			// Token: 0x04033E6E RID: 212590
			public const int ItemUnAvailable = 6;
		}
	}
}
