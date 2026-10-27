using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020051D5 RID: 20949
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public abstract class CommonBaseCardItem<[Nullable(2)] TItemData> : CardItemBase<TItemData>
	{
		// Token: 0x060359E0 RID: 219616 RVA: 0x00CB40B0 File Offset: 0x00CB22B0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem))
			};
		}

		// Token: 0x060359E1 RID: 219617 RVA: 0x00CB410B File Offset: 0x00CB230B
		protected UUIItem GetCardRootItem()
		{
			return base.GetItem(0);
		}

		// Token: 0x060359E2 RID: 219618 RVA: 0x00CB4114 File Offset: 0x00CB2314
		protected UUIItem GetContentRootItem()
		{
			return base.GetItem(2);
		}

		// Token: 0x060359E3 RID: 219619 RVA: 0x00CB411D File Offset: 0x00CB231D
		protected UUIItem GetSpineRootItem()
		{
			return base.GetItem(13);
		}

		// Token: 0x0200B364 RID: 45924
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040365F3 RID: 222707
			public const int CardItem = 0;

			// Token: 0x040365F4 RID: 222708
			public const int ContentItem = 2;

			// Token: 0x040365F5 RID: 222709
			public const int SpineRootItem = 13;
		}
	}
}
