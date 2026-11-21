using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DBB RID: 15803
	public class RoguelikePhantomDotItem : GridProxyAbstract<int>
	{
		// Token: 0x06028657 RID: 165463 RVA: 0x00B519C0 File Offset: 0x00B4FBC0
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

		// Token: 0x06028658 RID: 165464 RVA: 0x00B51A08 File Offset: 0x00B4FC08
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			base.GetItem(0).SetUIActive(isSelected);
		}

		// Token: 0x06028659 RID: 165465 RVA: 0x00B51A17 File Offset: 0x00B4FC17
		public override void OnDeselected(bool fireEvent)
		{
			base.GetItem(0).SetUIActive(false);
		}

		// Token: 0x0602865A RID: 165466 RVA: 0x00B51A26 File Offset: 0x00B4FC26
		public override void OnSelected(bool fireEvent)
		{
			base.GetItem(0).SetUIActive(true);
		}

		// Token: 0x020099AE RID: 39342
		private class EComponents
		{
			// Token: 0x0402FEB7 RID: 196279
			public const int Item = 0;
		}
	}
}
