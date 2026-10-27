using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057EF RID: 22511
	public class BagFullTip : UiPanelBase
	{
		// Token: 0x0603937A RID: 234362 RVA: 0x00D915B8 File Offset: 0x00D8F7B8
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

		// Token: 0x0603937B RID: 234363 RVA: 0x00D91600 File Offset: 0x00D8F800
		public void SetAdjustPanelVisible(bool isShow)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isShow);
		}

		// Token: 0x0200B9CA RID: 47562
		private class EChildType
		{
			// Token: 0x040382B7 RID: 230071
			public const int ItemAdjustPanel = 0;
		}
	}
}
