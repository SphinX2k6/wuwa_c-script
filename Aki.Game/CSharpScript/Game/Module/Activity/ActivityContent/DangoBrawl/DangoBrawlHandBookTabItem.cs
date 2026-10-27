using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200680B RID: 26635
	public class DangoBrawlHandBookTabItem : UiPanelBase
	{
		// Token: 0x060426F0 RID: 272112 RVA: 0x01022CCC File Offset: 0x01020ECC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060426F1 RID: 272113 RVA: 0x01022D72 File Offset: 0x01020F72
		public void SetRedDotVisible(bool visible)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x060426F2 RID: 272114 RVA: 0x01022D86 File Offset: 0x01020F86
		public void RefreshTabIndex(int index)
		{
			this.TabIndex = index;
		}

		// Token: 0x060426F3 RID: 272115 RVA: 0x01022D8F File Offset: 0x01020F8F
		public void SetToggleState(EToggleState state, bool bFire)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(state, bFire, false, false);
		}

		// Token: 0x060426F4 RID: 272116 RVA: 0x01022DA6 File Offset: 0x01020FA6
		private void OnToggleClick(EToggleState state)
		{
			Action<int, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(this.TabIndex, base.GetExtendToggle(1));
		}

		// Token: 0x04022A00 RID: 141824
		private int TabIndex;

		// Token: 0x04022A01 RID: 141825
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIExtendToggle> OnClickToggleBack;

		// Token: 0x0200C985 RID: 51589
		private enum ETabItemComponent
		{
			// Token: 0x0403CDC5 RID: 249285
			RedDotItem,
			// Token: 0x0403CDC6 RID: 249286
			TogItem
		}
	}
}
