using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D43 RID: 19779
	public class CommonKeyItem : KeyItemBase
	{
		// Token: 0x06031A67 RID: 203367 RVA: 0x00DE3208 File Offset: 0x00DE1408
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031A68 RID: 203368 RVA: 0x00DE3250 File Offset: 0x00DE1450
		[NullableContext(2)]
		protected override UUIText GetKeyText()
		{
			return null;
		}

		// Token: 0x06031A69 RID: 203369 RVA: 0x00DE3253 File Offset: 0x00DE1453
		[NullableContext(2)]
		protected override UUITexture GetKeyTexture()
		{
			return base.GetTexture(0);
		}

		// Token: 0x06031A6A RID: 203370 RVA: 0x00DE325C File Offset: 0x00DE145C
		protected override void OnSetGray()
		{
			UUITexture keyTexture = this.GetKeyTexture();
			UUIItem uuiitem = keyTexture;
			bool isGray = this.IsGray;
			FColor? fcolor = new FColor?(keyTexture.changeColor);
			uuiitem.SetChangeColor(isGray, fcolor);
		}

		// Token: 0x0200AA17 RID: 43543
		private enum EChildType
		{
			// Token: 0x04034917 RID: 215319
			KeyTexture
		}
	}
}
