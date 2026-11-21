using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Functional
{
	// Token: 0x020049F9 RID: 18937
	public class FunctionTabItem : UiPanelBase
	{
		// Token: 0x0602F778 RID: 194424 RVA: 0x00D3CE7C File Offset: 0x00D3B07C
		[NullableContext(1)]
		public FunctionTabItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602F779 RID: 194425 RVA: 0x00D3CE94 File Offset: 0x00D3B094
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

		// Token: 0x0602F77A RID: 194426 RVA: 0x00D3CEDC File Offset: 0x00D3B0DC
		public void SetToggleState(bool bSelected)
		{
			base.GetExtendToggle(0).SetToggleState(bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0200A69B RID: 42651
		private class ECompDefine
		{
			// Token: 0x04033806 RID: 210950
			public const int Toggle = 0;
		}
	}
}
