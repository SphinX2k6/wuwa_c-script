using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AEC RID: 19180
	public class TrapDefenseResultInfoBtn : UiPanelBase
	{
		// Token: 0x06031AF0 RID: 203504 RVA: 0x00B88A74 File Offset: 0x00B86C74
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

		// Token: 0x06031AF1 RID: 203505 RVA: 0x00B88B1A File Offset: 0x00B86D1A
		private void OnClicked()
		{
			if (this.ClickCb != null)
			{
				this.ClickCb();
			}
		}

		// Token: 0x0401A888 RID: 108680
		[Nullable(1)]
		public Action ClickCb;

		// Token: 0x0200AC7F RID: 44159
		internal class EBtn
		{
			// Token: 0x040346C0 RID: 214720
			public const int Panel = 0;

			// Token: 0x040346C1 RID: 214721
			public const int Btn = 1;
		}
	}
}
