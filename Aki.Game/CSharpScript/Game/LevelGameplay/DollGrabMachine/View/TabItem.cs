using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x0200606D RID: 24685
	[NullableContext(1)]
	[Nullable(0)]
	internal class TabItem : GridProxyAbstract<int>
	{
		// Token: 0x0603B425 RID: 242725 RVA: 0x010C4ADC File Offset: 0x010C2CDC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B426 RID: 242726 RVA: 0x010C4BA3 File Offset: 0x010C2DA3
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.TabIndex = data;
		}

		// Token: 0x0603B427 RID: 242727 RVA: 0x010C4BAC File Offset: 0x010C2DAC
		private void OnClickToggle(EToggleState _)
		{
			Action<int> onTabClickCallBack = this.OnTabClickCallBack;
			if (onTabClickCallBack == null)
			{
				return;
			}
			onTabClickCallBack(this.TabIndex);
		}

		// Token: 0x0603B428 RID: 242728 RVA: 0x010C4BC4 File Offset: 0x010C2DC4
		public void SetTabClickCallback(Action<int> callback)
		{
			this.OnTabClickCallBack = callback;
		}

		// Token: 0x0603B429 RID: 242729 RVA: 0x010C4BCD File Offset: 0x010C2DCD
		public void SetTabNameKey(string key)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), key, Array.Empty<object>());
		}

		// Token: 0x0603B42A RID: 242730 RVA: 0x010C4BE6 File Offset: 0x010C2DE6
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelect(false, false);
		}

		// Token: 0x0603B42B RID: 242731 RVA: 0x010C4BF0 File Offset: 0x010C2DF0
		public void SetToggleSelect(bool isSelected, bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0401F311 RID: 127761
		private int TabIndex = -1;

		// Token: 0x0401F312 RID: 127762
		[Nullable(2)]
		private Action<int> OnTabClickCallBack;
	}
}
