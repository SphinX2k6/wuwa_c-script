using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200662F RID: 26159
	public class FishingTechTabItem : CommonTabItemBase, ITabViewRegister
	{
		// Token: 0x0604193C RID: 268604 RVA: 0x00FE7ACC File Offset: 0x00FE5CCC
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604193D RID: 268605 RVA: 0x00FE7B51 File Offset: 0x00FE5D51
		private void OnToggle(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				Action<int> selectedCallBack = this.SelectedCallBack;
				if (selectedCallBack == null)
				{
					return;
				}
				selectedCallBack(base.GridIndex);
			}
		}

		// Token: 0x0604193E RID: 268606 RVA: 0x00FE7B6F File Offset: 0x00FE5D6F
		[NullableContext(1)]
		protected override void OnUpdateTabIcon(string iconPath)
		{
		}

		// Token: 0x0604193F RID: 268607 RVA: 0x00FE7B71 File Offset: 0x00FE5D71
		protected override void OnSetToggleState(EToggleState state, bool bFire)
		{
			base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
		}

		// Token: 0x06041940 RID: 268608 RVA: 0x00FE7B84 File Offset: 0x00FE5D84
		[NullableContext(1)]
		protected override UUIExtendToggle GetTabToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06041941 RID: 268609 RVA: 0x00FE7B8D File Offset: 0x00FE5D8D
		[NullableContext(1)]
		public void RegisterViewModule(UiTabViewBase tabView)
		{
			tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
		}

		// Token: 0x0200C84C RID: 51276
		private class EComponentDefine
		{
			// Token: 0x0403C816 RID: 247830
			public const int Toggle = 0;
		}
	}
}
