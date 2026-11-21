using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020041A5 RID: 16805
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public abstract class CommonBaseCardItem<[Nullable(2)] TItemData> : CardItemBase<TItemData>
	{
		// Token: 0x0602A8DB RID: 174299 RVA: 0x00C016EC File Offset: 0x00BFF8EC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem))
			};
		}

		// Token: 0x0602A8DC RID: 174300 RVA: 0x00C01747 File Offset: 0x00BFF947
		protected UUIItem GetCardRootItem()
		{
			return base.GetItem(0);
		}

		// Token: 0x0602A8DD RID: 174301 RVA: 0x00C01750 File Offset: 0x00BFF950
		protected UUIItem GetContentRootItem()
		{
			return base.GetItem(2);
		}

		// Token: 0x0602A8DE RID: 174302 RVA: 0x00C01759 File Offset: 0x00BFF959
		protected UUIItem GetSpineRootItem()
		{
			return base.GetItem(13);
		}

		// Token: 0x02009D9C RID: 40348
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04031046 RID: 200774
			public const int CardItem = 0;

			// Token: 0x04031047 RID: 200775
			public const int ContentItem = 2;

			// Token: 0x04031048 RID: 200776
			public const int SpineRootItem = 13;
		}
	}
}
