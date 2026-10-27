using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A9D RID: 19101
	public class TrapDefenseDevelopPreviewLevelPointItem : GridProxyAbstract<bool>
	{
		// Token: 0x06031826 RID: 202790 RVA: 0x00B7A2A0 File Offset: 0x00B784A0
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

		// Token: 0x06031827 RID: 202791 RVA: 0x00B7A2E8 File Offset: 0x00B784E8
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(data);
		}

		// Token: 0x0200ABF5 RID: 44021
		private class ELevelPoint
		{
			// Token: 0x0403440E RID: 214030
			public const int Point = 0;
		}
	}
}
