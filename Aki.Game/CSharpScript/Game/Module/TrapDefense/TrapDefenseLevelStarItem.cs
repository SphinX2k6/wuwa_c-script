using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A5A RID: 14938
	public class TrapDefenseLevelStarItem : GridProxyAbstract<bool>
	{
		// Token: 0x06026652 RID: 157266 RVA: 0x00AC1454 File Offset: 0x00ABF654
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

		// Token: 0x06026653 RID: 157267 RVA: 0x00AC149C File Offset: 0x00ABF69C
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

		// Token: 0x040150F6 RID: 86262
		public bool ItemData;

		// Token: 0x02009632 RID: 38450
		private class EChildType
		{
			// Token: 0x0402EE4C RID: 192076
			public const int ItemActive = 0;
		}
	}
}
