using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047C6 RID: 18374
	public class BagFullTip : UiPanelBase
	{
		// Token: 0x0602E28E RID: 189070 RVA: 0x00CE0400 File Offset: 0x00CDE600
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

		// Token: 0x0602E28F RID: 189071 RVA: 0x00CE0448 File Offset: 0x00CDE648
		public void SetAdjustPanelVisible(bool isShow)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isShow);
		}

		// Token: 0x0200A3E0 RID: 41952
		private class EChildType
		{
			// Token: 0x04032CA4 RID: 208036
			public const int ItemAdjustPanel = 0;
		}
	}
}
