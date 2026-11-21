using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059B5 RID: 22965
	public class SolarSchoolInfoOverviewTabItem : CommonTabItemBase
	{
		// Token: 0x060389BD RID: 231869 RVA: 0x00FD7048 File Offset: 0x00FD5248
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060389BE RID: 231870 RVA: 0x00FD710F File Offset: 0x00FD530F
		private void OnToggleStateChanged(EToggleState state)
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

		// Token: 0x060389BF RID: 231871 RVA: 0x00FD712C File Offset: 0x00FD532C
		[NullableContext(1)]
		protected override void OnUpdateTabIcon(string iconPath)
		{
			if (!string.IsNullOrEmpty(iconPath))
			{
				this.SetSpriteByPath(iconPath, base.GetSprite(1), false, null, null);
			}
		}

		// Token: 0x060389C0 RID: 231872 RVA: 0x00FD715A File Offset: 0x00FD535A
		protected override void OnSetToggleState(EToggleState state, bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(state, fireEvent, false, false);
		}

		// Token: 0x060389C1 RID: 231873 RVA: 0x00FD7171 File Offset: 0x00FD5371
		[NullableContext(1)]
		protected override UUIExtendToggle GetTabToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x060389C2 RID: 231874 RVA: 0x00FD717A File Offset: 0x00FD537A
		public void SetRedDotVisible(bool visible)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x0200B560 RID: 46432
		private class EComponent
		{
			// Token: 0x04038144 RID: 229700
			public const int Toggle = 0;

			// Token: 0x04038145 RID: 229701
			public const int Icon = 1;

			// Token: 0x04038146 RID: 229702
			public const int RedDot = 2;
		}
	}
}
