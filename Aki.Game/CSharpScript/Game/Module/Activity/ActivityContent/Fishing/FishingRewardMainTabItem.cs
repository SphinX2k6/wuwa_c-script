using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006584 RID: 25988
	public class FishingRewardMainTabItem : CommonTabItemBase, ITabViewRegister
	{
		// Token: 0x06041220 RID: 266784 RVA: 0x00FC8E80 File Offset: 0x00FC7080
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

		// Token: 0x06041221 RID: 266785 RVA: 0x00FC8F26 File Offset: 0x00FC7126
		protected override void OnStart()
		{
			this.SetRedDotVisible(false);
		}

		// Token: 0x06041222 RID: 266786 RVA: 0x00FC8F2F File Offset: 0x00FC712F
		[NullableContext(1)]
		public void RegisterViewModule(UiTabViewBase tabView)
		{
			tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
		}

		// Token: 0x06041223 RID: 266787 RVA: 0x00FC8F3D File Offset: 0x00FC713D
		public void SetRedDotVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x06041224 RID: 266788 RVA: 0x00FC8F51 File Offset: 0x00FC7151
		[NullableContext(1)]
		protected override void OnUpdateTabIcon(string iconPath)
		{
		}

		// Token: 0x06041225 RID: 266789 RVA: 0x00FC8F53 File Offset: 0x00FC7153
		protected override void OnSetToggleState(EToggleState state, bool bFire)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state, bFire, false, false);
		}

		// Token: 0x06041226 RID: 266790 RVA: 0x00FC8F6B File Offset: 0x00FC716B
		[NullableContext(1)]
		protected override UUIExtendToggle GetTabToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06041227 RID: 266791 RVA: 0x00FC8F74 File Offset: 0x00FC7174
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

		// Token: 0x04021EE6 RID: 138982
		public int TabIndex;

		// Token: 0x0200C77A RID: 51066
		private class EComponentDefine
		{
			// Token: 0x0403C44A RID: 246858
			public const int Toggle = 0;

			// Token: 0x0403C44B RID: 246859
			public const int RedDot = 1;
		}
	}
}
