using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004AF5 RID: 19189
	public class IconItem : UiPanelBase
	{
		// Token: 0x0602FFDF RID: 196575 RVA: 0x00D6327A File Offset: 0x00D6147A
		[NullableContext(1)]
		public IconItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602FFE0 RID: 196576 RVA: 0x00D63290 File Offset: 0x00D61490
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

		// Token: 0x0602FFE1 RID: 196577 RVA: 0x00D632FC File Offset: 0x00D614FC
		public void SetIcon(int itemId)
		{
			base.SetItemIcon(base.GetTexture(3), itemId, null, null);
		}

		// Token: 0x0602FFE2 RID: 196578 RVA: 0x00D63324 File Offset: 0x00D61524
		public void SetQuality(int itemId)
		{
			base.SetItemQualityIcon(base.GetSprite(4), itemId, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
		}

		// Token: 0x0200A758 RID: 42840
		private enum EIconItemDefine
		{
			// Token: 0x04033B56 RID: 211798
			IconTexture = 3,
			// Token: 0x04033B57 RID: 211799
			QualitySprite
		}
	}
}
