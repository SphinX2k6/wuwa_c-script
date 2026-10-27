using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065C1 RID: 26049
	public class DockyardShopTabItem : CommonTabItemBase, ITabViewRegister
	{
		// Token: 0x06041579 RID: 267641 RVA: 0x00FD588C File Offset: 0x00FD3A8C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604157A RID: 267642 RVA: 0x00FD5932 File Offset: 0x00FD3B32
		protected override void OnStart()
		{
			base.OnStart();
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x0604157B RID: 267643 RVA: 0x00FD5947 File Offset: 0x00FD3B47
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

		// Token: 0x0604157C RID: 267644 RVA: 0x00FD5965 File Offset: 0x00FD3B65
		[NullableContext(1)]
		protected override void OnUpdateTabIcon(string iconPath)
		{
		}

		// Token: 0x0604157D RID: 267645 RVA: 0x00FD5967 File Offset: 0x00FD3B67
		protected override void OnSetToggleState(EToggleState state, bool bFire)
		{
			base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
		}

		// Token: 0x0604157E RID: 267646 RVA: 0x00FD597A File Offset: 0x00FD3B7A
		[NullableContext(1)]
		protected override UUIExtendToggle GetTabToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0604157F RID: 267647 RVA: 0x00FD5983 File Offset: 0x00FD3B83
		[NullableContext(1)]
		public void RegisterViewModule(UiTabViewBase tabView)
		{
			tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
		}

		// Token: 0x06041580 RID: 267648 RVA: 0x00FD5991 File Offset: 0x00FD3B91
		public void SetRedDotActive(bool bActive)
		{
			base.GetItem(1).SetUIActive(bActive);
		}

		// Token: 0x0200C7E4 RID: 51172
		private class EComponentDefine
		{
			// Token: 0x0403C5F8 RID: 247288
			public const int Toggle = 0;

			// Token: 0x0403C5F9 RID: 247289
			public const int RedDot = 1;
		}
	}
}
