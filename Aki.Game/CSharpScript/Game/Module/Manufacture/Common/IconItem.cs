using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02004671 RID: 18033
	public class IconItem : UiPanelBase
	{
		// Token: 0x0602D5B1 RID: 185777 RVA: 0x00CB301F File Offset: 0x00CB121F
		[NullableContext(1)]
		public IconItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602D5B2 RID: 185778 RVA: 0x00CB3034 File Offset: 0x00CB1234
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602D5B3 RID: 185779 RVA: 0x00CB30A0 File Offset: 0x00CB12A0
		public void SetIcon(int itemId)
		{
			base.SetItemIcon(base.GetTexture(3), itemId, null, null);
		}

		// Token: 0x0602D5B4 RID: 185780 RVA: 0x00CB30C8 File Offset: 0x00CB12C8
		public void SetQuality(int itemId)
		{
			base.SetItemQualityIcon(base.GetSprite(4), itemId, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
		}

		// Token: 0x0200A287 RID: 41607
		private class EIconItemDefine
		{
			// Token: 0x040326FD RID: 206589
			public const int IconTexture = 3;

			// Token: 0x040326FE RID: 206590
			public const int QualitySprite = 4;
		}
	}
}
