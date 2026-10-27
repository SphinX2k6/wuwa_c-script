using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D64 RID: 23908
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyKeyItem : LongPressKeyItemBase
	{
		// Token: 0x0603CB3A RID: 248634 RVA: 0x00E93154 File Offset: 0x00E91354
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CB3B RID: 248635 RVA: 0x00E931FF File Offset: 0x00E913FF
		protected override UUIText GetKeyText()
		{
			return base.GetText(3);
		}

		// Token: 0x0603CB3C RID: 248636 RVA: 0x00E93208 File Offset: 0x00E91408
		protected override UUITexture GetKeyTexture()
		{
			return base.GetTexture(0);
		}

		// Token: 0x0603CB3D RID: 248637 RVA: 0x00E93211 File Offset: 0x00E91411
		protected override UUITexture GetLongPressTexture()
		{
			return base.GetTexture(2);
		}

		// Token: 0x0603CB3E RID: 248638 RVA: 0x00E9321A File Offset: 0x00E9141A
		protected override UUIItem GetLongPressItem()
		{
			return base.GetItem(1);
		}

		// Token: 0x0200C013 RID: 49171
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039F5A RID: 237402
			KeyTexture,
			// Token: 0x04039F5B RID: 237403
			LongPressItem,
			// Token: 0x04039F5C RID: 237404
			LongPressTexture,
			// Token: 0x04039F5D RID: 237405
			KeyText
		}
	}
}
