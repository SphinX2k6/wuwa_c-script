using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A15 RID: 23061
	[NullableContext(2)]
	[Nullable(0)]
	internal class SolarSchoolEndingPageItem : GridProxyAbstract<int>
	{
		// Token: 0x17006C71 RID: 27761
		// (get) Token: 0x06038CAA RID: 232618 RVA: 0x00FE5A5C File Offset: 0x00FE3C5C
		// (set) Token: 0x06038CAB RID: 232619 RVA: 0x00FE5A64 File Offset: 0x00FE3C64
		public Action<int> ClickCallback { get; set; }

		// Token: 0x06038CAC RID: 232620 RVA: 0x00FE5A70 File Offset: 0x00FE3C70
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChange));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038CAD RID: 232621 RVA: 0x00FE5AF5 File Offset: 0x00FE3CF5
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.SetSelectedState(isSelected);
		}

		// Token: 0x06038CAE RID: 232622 RVA: 0x00FE5AFE File Offset: 0x00FE3CFE
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelectedState(true);
		}

		// Token: 0x06038CAF RID: 232623 RVA: 0x00FE5B07 File Offset: 0x00FE3D07
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelectedState(false);
		}

		// Token: 0x06038CB0 RID: 232624 RVA: 0x00FE5B10 File Offset: 0x00FE3D10
		private void OnToggleStateChange(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			IScrollViewDelegate<IGridProxy<int>, int> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate != null)
			{
				scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
			}
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(base.GridIndex);
		}

		// Token: 0x06038CB1 RID: 232625 RVA: 0x00FE5B4B File Offset: 0x00FE3D4B
		private void SetSelectedState(bool selected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0200B5D5 RID: 46549
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040383BC RID: 230332
			public const int Toggle = 0;
		}
	}
}
