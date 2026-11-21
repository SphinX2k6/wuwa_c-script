using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02004EE0 RID: 20192
	[NullableContext(1)]
	[Nullable(0)]
	public class GuQinActivityMainViewToggleItem : UiPanelBase
	{
		// Token: 0x06032C06 RID: 207878 RVA: 0x00E40DB0 File Offset: 0x00E3EFB0
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

		// Token: 0x06032C07 RID: 207879 RVA: 0x00E40F82 File Offset: 0x00E3F182
		protected override void OnStart()
		{
			base.GetExtendToggle(8).bLockStateOnSelect = true;
			base.GetExtendToggle(8).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteCallback));
			this.SetToggleState(EToggleState.ETT_UnChecked, true);
		}

		// Token: 0x06032C08 RID: 207880 RVA: 0x00E40FB6 File Offset: 0x00E3F1B6
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

		// Token: 0x06032C09 RID: 207881 RVA: 0x00E40FF0 File Offset: 0x00E3F1F0
		private void OnToggleClick(EToggleState state)
		{
			bool flag = state == EToggleState.ETT_Checked;
			if (flag)
			{
				this.SelectCallback(this, this.Data);
			}
			this.RefreshDisplay(flag);
		}

		// Token: 0x06032C0A RID: 207882 RVA: 0x00E41020 File Offset: 0x00E3F220
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

		// Token: 0x06032C0B RID: 207883 RVA: 0x00E410F5 File Offset: 0x00E3F2F5
		public void SetToggleState(EToggleState state, bool fireEvent)
		{
			base.GetExtendToggle(8).SetToggleStateForce(state, fireEvent, false, false);
		}

		// Token: 0x06032C0C RID: 207884 RVA: 0x00E41107 File Offset: 0x00E3F307
		public void Refresh(GuQinActivityTabData data)
		{
			this.Data = data;
		}

		// Token: 0x06032C0D RID: 207885 RVA: 0x00E41110 File Offset: 0x00E3F310
		public void RefreshRedDot()
		{
			base.GetItem(9).SetUIActive(this.Data.GetIsRedDot());
			base.GetItem(10).SetUIActive(this.Data.GetIsRedDot());
		}

		// Token: 0x0401AF47 RID: 110407
		public GuQinActivityTabData Data;

		// Token: 0x0401AF48 RID: 110408
		public Action<GuQinActivityMainViewToggleItem, GuQinActivityTabData> SelectCallback;

		// Token: 0x0401AF49 RID: 110409
		[Nullable(2)]
		public Action FocusBackCallback;

		// Token: 0x0200AC39 RID: 44089
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04035496 RID: 218262
			public const int PnlNotSelect = 0;

			// Token: 0x04035497 RID: 218263
			public const int PnlNotSelectUnlock = 1;

			// Token: 0x04035498 RID: 218264
			public const int PnlNotSelectLock = 2;

			// Token: 0x04035499 RID: 218265
			public const int PnlNotSelectCompleted = 3;

			// Token: 0x0403549A RID: 218266
			public const int TextNotSelectName = 4;

			// Token: 0x0403549B RID: 218267
			public const int PnlSelect = 5;

			// Token: 0x0403549C RID: 218268
			public const int TextSelectName = 6;

			// Token: 0x0403549D RID: 218269
			public const int PnlSelectCompleted = 7;

			// Token: 0x0403549E RID: 218270
			public const int Toggle = 8;

			// Token: 0x0403549F RID: 218271
			public const int SelectRedDot = 9;

			// Token: 0x040354A0 RID: 218272
			public const int NotSelectRedDot = 10;
		}
	}
}
