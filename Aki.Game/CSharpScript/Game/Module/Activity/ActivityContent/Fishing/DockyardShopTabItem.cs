using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200553F RID: 21823
	public class DockyardShopTabItem : CommonTabItemBase, ITabViewRegister
	{
		// Token: 0x0603623E RID: 221758 RVA: 0x00F1C8C8 File Offset: 0x00F1AAC8
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

		// Token: 0x0603623F RID: 221759 RVA: 0x00F1C96E File Offset: 0x00F1AB6E
		protected override void OnStart()
		{
			base.OnStart();
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x06036240 RID: 221760 RVA: 0x00F1C983 File Offset: 0x00F1AB83
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

		// Token: 0x06036241 RID: 221761 RVA: 0x00F1C9A1 File Offset: 0x00F1ABA1
		[NullableContext(1)]
		protected override void OnUpdateTabIcon(string iconPath)
		{
		}

		// Token: 0x06036242 RID: 221762 RVA: 0x00F1C9A3 File Offset: 0x00F1ABA3
		protected override void OnSetToggleState(EToggleState state, bool bFire)
		{
			base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
		}

		// Token: 0x06036243 RID: 221763 RVA: 0x00F1C9B6 File Offset: 0x00F1ABB6
		[NullableContext(1)]
		protected override UUIExtendToggle GetTabToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06036244 RID: 221764 RVA: 0x00F1C9BF File Offset: 0x00F1ABBF
		[NullableContext(1)]
		public void RegisterViewModule(UiTabViewBase tabView)
		{
			tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
		}

		// Token: 0x06036245 RID: 221765 RVA: 0x00F1C9CD File Offset: 0x00F1ABCD
		public void SetRedDotActive(bool bActive)
		{
			base.GetItem(1).SetUIActive(bActive);
		}

		// Token: 0x0200B1C7 RID: 45511
		private class EComponentDefine
		{
			// Token: 0x04036F46 RID: 225094
			public const int Toggle = 0;

			// Token: 0x04036F47 RID: 225095
			public const int RedDot = 1;
		}
	}
}
