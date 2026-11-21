using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005502 RID: 21762
	public class FishingRewardMainTabItem : CommonTabItemBase, ITabViewRegister
	{
		// Token: 0x06035EE5 RID: 220901 RVA: 0x00F0FE34 File Offset: 0x00F0E034
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

		// Token: 0x06035EE6 RID: 220902 RVA: 0x00F0FEDA File Offset: 0x00F0E0DA
		protected override void OnStart()
		{
			this.SetRedDotVisible(false);
		}

		// Token: 0x06035EE7 RID: 220903 RVA: 0x00F0FEE3 File Offset: 0x00F0E0E3
		[NullableContext(1)]
		public void RegisterViewModule(UiTabViewBase tabView)
		{
			tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
		}

		// Token: 0x06035EE8 RID: 220904 RVA: 0x00F0FEF1 File Offset: 0x00F0E0F1
		public void SetRedDotVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x06035EE9 RID: 220905 RVA: 0x00F0FF05 File Offset: 0x00F0E105
		[NullableContext(1)]
		protected override void OnUpdateTabIcon(string iconPath)
		{
		}

		// Token: 0x06035EEA RID: 220906 RVA: 0x00F0FF07 File Offset: 0x00F0E107
		protected override void OnSetToggleState(EToggleState state, bool bFire)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state, bFire, false, false);
		}

		// Token: 0x06035EEB RID: 220907 RVA: 0x00F0FF1F File Offset: 0x00F0E11F
		[NullableContext(1)]
		protected override UUIExtendToggle GetTabToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06035EEC RID: 220908 RVA: 0x00F0FF28 File Offset: 0x00F0E128
		protected void OnToggle(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				Action<int> selectedCallBack = this.SelectedCallBack;
				if (selectedCallBack == null)
				{
					return;
				}
				selectedCallBack(this.TabIndex);
			}
		}

		// Token: 0x0401C817 RID: 116759
		public int TabIndex;

		// Token: 0x0200B15F RID: 45407
		private class EComponentDefine
		{
			// Token: 0x04036D9B RID: 224667
			public const int Toggle = 0;

			// Token: 0x04036D9C RID: 224668
			public const int RedDot = 1;
		}
	}
}
