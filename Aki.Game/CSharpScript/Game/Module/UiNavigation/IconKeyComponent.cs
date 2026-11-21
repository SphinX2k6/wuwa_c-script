using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003860 RID: 14432
	[NullableContext(1)]
	[Nullable(0)]
	public class IconKeyComponent : KeyBaseComponent
	{
		// Token: 0x06025820 RID: 153632 RVA: 0x00A90B18 File Offset: 0x00A8ED18
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

		// Token: 0x06025821 RID: 153633 RVA: 0x00A90BB4 File Offset: 0x00A8EDB4
		protected override UUIText GetNameText()
		{
			return base.GetText(4);
		}

		// Token: 0x06025822 RID: 153634 RVA: 0x00A90BBD File Offset: 0x00A8EDBD
		protected override UUITexture GetKeyTexture()
		{
			return base.GetTexture(0);
		}

		// Token: 0x06025823 RID: 153635 RVA: 0x00A90BC6 File Offset: 0x00A8EDC6
		protected override UUIItem GetLongPressItem()
		{
			return base.GetItem(1);
		}

		// Token: 0x06025824 RID: 153636 RVA: 0x00A90BCF File Offset: 0x00A8EDCF
		protected override UUIItem GetCircleItem()
		{
			return base.GetItem(2);
		}

		// Token: 0x06025825 RID: 153637 RVA: 0x00A90BD8 File Offset: 0x00A8EDD8
		protected override UUIItem GetSquareItem()
		{
			return base.GetItem(3);
		}

		// Token: 0x06025826 RID: 153638 RVA: 0x00A90BE1 File Offset: 0x00A8EDE1
		protected override UUITexture GetLongPressTipTexture()
		{
			return base.GetTexture(5);
		}

		// Token: 0x020095AF RID: 38319
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0402EC57 RID: 191575
			KeyTexture,
			// Token: 0x0402EC58 RID: 191576
			LongPreItem,
			// Token: 0x0402EC59 RID: 191577
			CircleItem,
			// Token: 0x0402EC5A RID: 191578
			SquareItem,
			// Token: 0x0402EC5B RID: 191579
			NameText,
			// Token: 0x0402EC5C RID: 191580
			LongPreTipTexture
		}
	}
}
