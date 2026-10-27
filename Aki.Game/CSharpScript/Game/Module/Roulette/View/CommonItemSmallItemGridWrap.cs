using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roulette.View
{
	// Token: 0x02004C9C RID: 19612
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CommonItemSmallItemGridWrap : GridProxyAbstract<ItemRefreshData>
	{
		// Token: 0x06032AE1 RID: 207585 RVA: 0x00BD28BC File Offset: 0x00BD0ABC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032AE2 RID: 207586 RVA: 0x00BD2904 File Offset: 0x00BD0B04
		public override void Refresh(ItemRefreshData data, bool isSelected, int gridIndex)
		{
			this.GridItem.RefreshByConfigId(data.ItemId, null, null, false, false);
			this.GridItem.SetLockVisible(data.NeedLock);
			bool flag = data.Text != null;
			this.GridItem.SetBottomTextVisible(flag);
			if (flag)
			{
				this.GridItem.SetBottomText(data.Text);
			}
		}

		// Token: 0x06032AE3 RID: 207587 RVA: 0x00BD296C File Offset: 0x00BD0B6C
		protected override void OnStart()
		{
			this.GridItem = new CommonItemSmallItemGrid();
			UUIItem item = base.GetItem(0);
			this.GridItem.Initialize(item.GetOwner());
		}

		// Token: 0x06032AE4 RID: 207588 RVA: 0x00BD299D File Offset: 0x00BD0B9D
		protected override void OnBeforeDestroy()
		{
			this.GridItem.Destroy(null);
		}

		// Token: 0x0401AFB1 RID: 110513
		[Nullable(2)]
		public CommonItemSmallItemGrid GridItem;
	}
}
