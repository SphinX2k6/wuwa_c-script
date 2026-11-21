using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roulette.View
{
	// Token: 0x02003C4D RID: 15437
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CommonItemSmallItemGridWrap : GridProxyAbstract<ItemRefreshData>
	{
		// Token: 0x06027894 RID: 161940 RVA: 0x00B17520 File Offset: 0x00B15720
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

		// Token: 0x06027895 RID: 161941 RVA: 0x00B17568 File Offset: 0x00B15768
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

		// Token: 0x06027896 RID: 161942 RVA: 0x00B175D0 File Offset: 0x00B157D0
		protected override void OnStart()
		{
			this.GridItem = new CommonItemSmallItemGrid();
			UUIItem item = base.GetItem(0);
			this.GridItem.Initialize(item.GetOwner());
		}

		// Token: 0x06027897 RID: 161943 RVA: 0x00B17601 File Offset: 0x00B15801
		protected override void OnBeforeDestroy()
		{
			this.GridItem.Destroy(null);
		}

		// Token: 0x0401590E RID: 88334
		[Nullable(2)]
		public CommonItemSmallItemGrid GridItem;
	}
}
