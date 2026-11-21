using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapNote
{
	// Token: 0x02003710 RID: 14096
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class WorldMapNoteItemNew : GridProxyAbstract<WorldMapNoteItemData>
	{
		// Token: 0x06024AF9 RID: 150265 RVA: 0x00A5B7F8 File Offset: 0x00A599F8
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

		// Token: 0x06024AFA RID: 150266 RVA: 0x00A5B944 File Offset: 0x00A59B44
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

		// Token: 0x06024AFB RID: 150267 RVA: 0x00A5BA0C File Offset: 0x00A59C0C
		private void OnClick()
		{
			if (this.DataParam != null)
			{
				this.DataParam.ClickCallback(this.DataParam.Id);
			}
		}

		// Token: 0x04014606 RID: 83462
		[Nullable(2)]
		private WorldMapNoteItemData DataParam;

		// Token: 0x0200944A RID: 37962
		public static class EChildType
		{
			// Token: 0x0402E5EF RID: 189935
			public const int SpriteIcon = 0;

			// Token: 0x0402E5F0 RID: 189936
			public const int TxtDesc = 1;

			// Token: 0x0402E5F1 RID: 189937
			public const int BtnNote = 2;

			// Token: 0x0402E5F2 RID: 189938
			public const int ItemNormalBg = 3;

			// Token: 0x0402E5F3 RID: 189939
			public const int ItemReceivedBg = 4;

			// Token: 0x0402E5F4 RID: 189940
			public const int ItemAvailable = 5;

			// Token: 0x0402E5F5 RID: 189941
			public const int ItemUnAvailable = 6;
		}
	}
}
