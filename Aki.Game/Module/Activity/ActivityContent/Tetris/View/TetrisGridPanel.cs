using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FC7 RID: 12231
	public class TetrisGridPanel : UiPanelBase
	{
		// Token: 0x0601D094 RID: 118932 RVA: 0x008DEA31 File Offset: 0x008DCC31
		public TetrisGridPanel(int row = 0, int column = 0)
		{
		}

		// Token: 0x0601D095 RID: 118933 RVA: 0x008DEA48 File Offset: 0x008DCC48
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D096 RID: 118934 RVA: 0x008DEAD4 File Offset: 0x008DCCD4
		[NullableContext(1)]
		public void Refresh(CellInstance data)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				string smallIconPath = data.GetSmallIconPath();
				if (!string.IsNullOrWhiteSpace(smallIconPath))
				{
					sprite.SetUIActive(true);
					this.SetSpriteByPath(smallIconPath, sprite, false, null, null);
				}
				else
				{
					sprite.SetUIActive(false);
				}
			}
			UUISprite sprite2 = base.GetSprite(0);
			if (sprite2 != null)
			{
				string bgPath = data.GetBgPath();
				if (!string.IsNullOrWhiteSpace(bgPath))
				{
					sprite2.SetUIActive(true);
					this.SetSpriteByPath(bgPath, sprite2, false, null, null);
					return;
				}
				sprite2.SetUIActive(false);
			}
		}

		// Token: 0x0400F497 RID: 62615
		public int Row = row;

		// Token: 0x0400F498 RID: 62616
		public int Column = column;

		// Token: 0x02008C52 RID: 35922
		private static class EComponents
		{
			// Token: 0x0402C691 RID: 181905
			public const int GridBg = 0;

			// Token: 0x0402C692 RID: 181906
			public const int GridIcon = 1;

			// Token: 0x0402C693 RID: 181907
			public const int Highlight = 2;
		}
	}
}
