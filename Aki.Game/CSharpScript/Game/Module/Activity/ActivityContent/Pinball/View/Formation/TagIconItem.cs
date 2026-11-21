using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x020052E9 RID: 21225
	public class TagIconItem : UiPanelBase
	{
		// Token: 0x06034D25 RID: 216357 RVA: 0x00EC40A8 File Offset: 0x00EC22A8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034D26 RID: 216358 RVA: 0x00EC4114 File Offset: 0x00EC2314
		[NullableContext(1)]
		public void RefreshPanel(string path, string color)
		{
			base.SetTextureByPath(path, base.GetTexture(1), null, null);
			base.GetItem(0).SetColor(FColor.FromHex(color));
		}

		// Token: 0x0200AF6D RID: 44909
		private enum ETagIconItem
		{
			// Token: 0x0403634E RID: 222030
			BgItem,
			// Token: 0x0403634F RID: 222031
			IconTexture
		}
	}
}
