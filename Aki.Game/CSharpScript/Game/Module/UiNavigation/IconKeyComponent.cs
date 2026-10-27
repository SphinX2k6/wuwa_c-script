using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048E9 RID: 18665
	[NullableContext(1)]
	[Nullable(0)]
	public class IconKeyComponent : KeyBaseComponent
	{
		// Token: 0x06030CF3 RID: 199923 RVA: 0x00B55CA8 File Offset: 0x00B53EA8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUITexture))
			};
		}

		// Token: 0x06030CF4 RID: 199924 RVA: 0x00B55D44 File Offset: 0x00B53F44
		protected override UUIText GetNameText()
		{
			return base.GetText(4);
		}

		// Token: 0x06030CF5 RID: 199925 RVA: 0x00B55D4D File Offset: 0x00B53F4D
		protected override UUITexture GetKeyTexture()
		{
			return base.GetTexture(0);
		}

		// Token: 0x06030CF6 RID: 199926 RVA: 0x00B55D56 File Offset: 0x00B53F56
		protected override UUIItem GetLongPressItem()
		{
			return base.GetItem(1);
		}

		// Token: 0x06030CF7 RID: 199927 RVA: 0x00B55D5F File Offset: 0x00B53F5F
		protected override UUIItem GetCircleItem()
		{
			return base.GetItem(2);
		}

		// Token: 0x06030CF8 RID: 199928 RVA: 0x00B55D68 File Offset: 0x00B53F68
		protected override UUIItem GetSquareItem()
		{
			return base.GetItem(3);
		}

		// Token: 0x06030CF9 RID: 199929 RVA: 0x00B55D71 File Offset: 0x00B53F71
		protected override UUITexture GetLongPressTipTexture()
		{
			return base.GetTexture(5);
		}

		// Token: 0x0200ABA0 RID: 43936
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040342D4 RID: 213716
			KeyTexture,
			// Token: 0x040342D5 RID: 213717
			LongPreItem,
			// Token: 0x040342D6 RID: 213718
			CircleItem,
			// Token: 0x040342D7 RID: 213719
			SquareItem,
			// Token: 0x040342D8 RID: 213720
			NameText,
			// Token: 0x040342D9 RID: 213721
			LongPreTipTexture
		}
	}
}
