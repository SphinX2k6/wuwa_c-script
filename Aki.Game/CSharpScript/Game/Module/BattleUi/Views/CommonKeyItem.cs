using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D61 RID: 23905
	public class CommonKeyItem : KeyItemBase
	{
		// Token: 0x0603CB0C RID: 248588 RVA: 0x00E92A1C File Offset: 0x00E90C1C
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

		// Token: 0x0603CB0D RID: 248589 RVA: 0x00E92A64 File Offset: 0x00E90C64
		[NullableContext(2)]
		protected override UUIText GetKeyText()
		{
			return null;
		}

		// Token: 0x0603CB0E RID: 248590 RVA: 0x00E92A67 File Offset: 0x00E90C67
		[NullableContext(2)]
		protected override UUITexture GetKeyTexture()
		{
			return base.GetTexture(0);
		}

		// Token: 0x0603CB0F RID: 248591 RVA: 0x00E92A70 File Offset: 0x00E90C70
		protected override void OnSetGray()
		{
			UUITexture keyTexture = this.GetKeyTexture();
			UUIItem uuiitem = keyTexture;
			bool isGray = this.IsGray;
			FColor? fcolor = new FColor?(keyTexture.changeColor);
			uuiitem.SetChangeColor(isGray, fcolor);
		}

		// Token: 0x0200C011 RID: 49169
		private enum EChildType
		{
			// Token: 0x04039F55 RID: 237397
			KeyTexture
		}
	}
}
