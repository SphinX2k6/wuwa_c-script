using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A45 RID: 14917
	public class TrapDefenseDevelopPreviewLevelPointItem : GridProxyAbstract<bool>
	{
		// Token: 0x060265B6 RID: 157110 RVA: 0x00ABE254 File Offset: 0x00ABC454
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

		// Token: 0x060265B7 RID: 157111 RVA: 0x00ABE29C File Offset: 0x00ABC49C
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(data);
		}

		// Token: 0x02009615 RID: 38421
		private class ELevelPoint
		{
			// Token: 0x0402EDBF RID: 191935
			public const int Point = 0;
		}
	}
}
