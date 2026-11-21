using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A94 RID: 14996
	public class TrapDefenseResultInfoBtn : UiPanelBase
	{
		// Token: 0x06026880 RID: 157824 RVA: 0x00ACCA28 File Offset: 0x00ACAC28
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026881 RID: 157825 RVA: 0x00ACCACE File Offset: 0x00ACACCE
		private void OnClicked()
		{
			if (this.ClickCb != null)
			{
				this.ClickCb();
			}
		}

		// Token: 0x040151DA RID: 86490
		[Nullable(1)]
		public Action ClickCb;

		// Token: 0x0200969F RID: 38559
		internal class EBtn
		{
			// Token: 0x0402F071 RID: 192625
			public const int Panel = 0;

			// Token: 0x0402F072 RID: 192626
			public const int Btn = 1;
		}
	}
}
