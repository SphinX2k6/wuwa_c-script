using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02005EF9 RID: 24313
	[NullableContext(1)]
	[Nullable(0)]
	public class GuQinActivityMainViewToggleItem : UiPanelBase
	{
		// Token: 0x0603DC6B RID: 253035 RVA: 0x00EEF0EC File Offset: 0x00EED2EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603DC6C RID: 253036 RVA: 0x00EEF2BE File Offset: 0x00EED4BE
		protected override void OnStart()
		{
			base.GetExtendToggle(8).bLockStateOnSelect = true;
			base.GetExtendToggle(8).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteCallback));
			this.SetToggleState(EToggleState.ETT_UnChecked, true);
		}

		// Token: 0x0603DC6D RID: 253037 RVA: 0x00EEF2F2 File Offset: 0x00EED4F2
		private bool CanExecuteCallback()
		{
			if (this.Data.GetStatus() == EGuQinActivityTabStatus.Lock)
			{
				ScrollingTipsController.Instance.ShowTipsByText(this.Data.GetLockTip());
				Action focusBackCallback = this.FocusBackCallback;
				if (focusBackCallback != null)
				{
					focusBackCallback();
				}
				return false;
			}
			return true;
		}

		// Token: 0x0603DC6E RID: 253038 RVA: 0x00EEF32C File Offset: 0x00EED52C
		private void OnToggleClick(EToggleState state)
		{
			bool flag = state == EToggleState.ETT_Checked;
			if (flag)
			{
				this.SelectCallback(this, this.Data);
			}
			this.RefreshDisplay(flag);
		}

		// Token: 0x0603DC6F RID: 253039 RVA: 0x00EEF35C File Offset: 0x00EED55C
		public void RefreshDisplay(bool isSelected)
		{
			EGuQinActivityTabStatus status = this.Data.GetStatus();
			bool flag = status == EGuQinActivityTabStatus.Progressing;
			bool flag2 = status == EGuQinActivityTabStatus.Lock;
			bool flag3 = status == EGuQinActivityTabStatus.Completed;
			base.GetItem(0).SetUIActive(!isSelected);
			base.GetItem(1).SetUIActive(!isSelected && flag);
			base.GetItem(2).SetUIActive(!isSelected && flag2);
			base.GetItem(3).SetUIActive(!isSelected && flag3);
			base.GetItem(5).SetUIActive(isSelected);
			base.GetItem(7).SetUIActive(isSelected && flag3);
			base.GetText(6).SetUIActive(isSelected);
			base.GetText(4).SetUIActive(!isSelected);
			base.GetItem(9).SetUIActive(this.Data.GetIsRedDot());
			base.GetItem(10).SetUIActive(this.Data.GetIsRedDot());
		}

		// Token: 0x0603DC70 RID: 253040 RVA: 0x00EEF431 File Offset: 0x00EED631
		public void SetToggleState(EToggleState state, bool fireEvent)
		{
			base.GetExtendToggle(8).SetToggleStateForce(state, fireEvent, false, false);
		}

		// Token: 0x0603DC71 RID: 253041 RVA: 0x00EEF443 File Offset: 0x00EED643
		public void Refresh(GuQinActivityTabData data)
		{
			this.Data = data;
		}

		// Token: 0x0603DC72 RID: 253042 RVA: 0x00EEF44C File Offset: 0x00EED64C
		public void RefreshRedDot()
		{
			base.GetItem(9).SetUIActive(this.Data.GetIsRedDot());
			base.GetItem(10).SetUIActive(this.Data.GetIsRedDot());
		}

		// Token: 0x04020475 RID: 132213
		public GuQinActivityTabData Data;

		// Token: 0x04020476 RID: 132214
		public Action<GuQinActivityMainViewToggleItem, GuQinActivityTabData> SelectCallback;

		// Token: 0x04020477 RID: 132215
		[Nullable(2)]
		public Action FocusBackCallback;

		// Token: 0x0200C22B RID: 49707
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403AAA2 RID: 240290
			public const int PnlNotSelect = 0;

			// Token: 0x0403AAA3 RID: 240291
			public const int PnlNotSelectUnlock = 1;

			// Token: 0x0403AAA4 RID: 240292
			public const int PnlNotSelectLock = 2;

			// Token: 0x0403AAA5 RID: 240293
			public const int PnlNotSelectCompleted = 3;

			// Token: 0x0403AAA6 RID: 240294
			public const int TextNotSelectName = 4;

			// Token: 0x0403AAA7 RID: 240295
			public const int PnlSelect = 5;

			// Token: 0x0403AAA8 RID: 240296
			public const int TextSelectName = 6;

			// Token: 0x0403AAA9 RID: 240297
			public const int PnlSelectCompleted = 7;

			// Token: 0x0403AAAA RID: 240298
			public const int Toggle = 8;

			// Token: 0x0403AAAB RID: 240299
			public const int SelectRedDot = 9;

			// Token: 0x0403AAAC RID: 240300
			public const int NotSelectRedDot = 10;
		}
	}
}
