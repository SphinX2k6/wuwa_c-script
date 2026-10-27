using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AB2 RID: 19122
	public class TrapDefenseLevelStarItem : GridProxyAbstract<bool>
	{
		// Token: 0x060318C2 RID: 202946 RVA: 0x00B7D4A0 File Offset: 0x00B7B6A0
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

		// Token: 0x060318C3 RID: 202947 RVA: 0x00B7D4E8 File Offset: 0x00B7B6E8
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(data);
		}

		// Token: 0x0401A7A4 RID: 108452
		public bool ItemData;

		// Token: 0x0200AC12 RID: 44050
		private class EChildType
		{
			// Token: 0x0403449B RID: 214171
			public const int ItemActive = 0;
		}
	}
}
