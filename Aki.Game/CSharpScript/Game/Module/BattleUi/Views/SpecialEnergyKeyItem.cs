using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D46 RID: 19782
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyKeyItem : LongPressKeyItemBase
	{
		// Token: 0x06031A95 RID: 203413 RVA: 0x00DE3990 File Offset: 0x00DE1B90
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

		// Token: 0x06031A96 RID: 203414 RVA: 0x00DE3A3B File Offset: 0x00DE1C3B
		protected override UUIText GetKeyText()
		{
			return base.GetText(3);
		}

		// Token: 0x06031A97 RID: 203415 RVA: 0x00DE3A44 File Offset: 0x00DE1C44
		protected override UUITexture GetKeyTexture()
		{
			return base.GetTexture(0);
		}

		// Token: 0x06031A98 RID: 203416 RVA: 0x00DE3A4D File Offset: 0x00DE1C4D
		protected override UUITexture GetLongPressTexture()
		{
			return base.GetTexture(2);
		}

		// Token: 0x06031A99 RID: 203417 RVA: 0x00DE3A56 File Offset: 0x00DE1C56
		protected override UUIItem GetLongPressItem()
		{
			return base.GetItem(1);
		}

		// Token: 0x0200AA19 RID: 43545
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403491C RID: 215324
			KeyTexture,
			// Token: 0x0403491D RID: 215325
			LongPressItem,
			// Token: 0x0403491E RID: 215326
			LongPressTexture,
			// Token: 0x0403491F RID: 215327
			KeyText
		}
	}
}
