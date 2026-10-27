using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Functional
{
	// Token: 0x02005A1D RID: 23069
	public class FunctionTabItem : UiPanelBase
	{
		// Token: 0x0603A82F RID: 239663 RVA: 0x00DEC8EC File Offset: 0x00DEAAEC
		[NullableContext(1)]
		public FunctionTabItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603A830 RID: 239664 RVA: 0x00DEC904 File Offset: 0x00DEAB04
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A831 RID: 239665 RVA: 0x00DEC94C File Offset: 0x00DEAB4C
		public void SetToggleState(bool bSelected)
		{
			base.GetExtendToggle(0).SetToggleState(bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0200BC92 RID: 48274
		private class ECompDefine
		{
			// Token: 0x04038E3B RID: 233019
			public const int Toggle = 0;
		}
	}
}
