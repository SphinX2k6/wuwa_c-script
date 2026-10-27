using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x02006570 RID: 25968
	internal class ActivityFunPlayPage : GridProxyAbstract<FunPlaySharpComment>
	{
		// Token: 0x06041142 RID: 266562 RVA: 0x00FC5A3C File Offset: 0x00FC3C3C
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

		// Token: 0x06041143 RID: 266563 RVA: 0x00FC5A84 File Offset: 0x00FC3C84
		public override void Refresh(FunPlaySharpComment data, bool isSelected, int gridIndex)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06041144 RID: 266564 RVA: 0x00FC5A98 File Offset: 0x00FC3C98
		public override void OnSelected(bool fireEvent)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(true);
		}

		// Token: 0x06041145 RID: 266565 RVA: 0x00FC5AAC File Offset: 0x00FC3CAC
		public override void OnDeselected(bool fireEvent)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0200C766 RID: 51046
		private class EComponent
		{
			// Token: 0x0403C3E6 RID: 246758
			public const int DotPic = 0;
		}
	}
}
