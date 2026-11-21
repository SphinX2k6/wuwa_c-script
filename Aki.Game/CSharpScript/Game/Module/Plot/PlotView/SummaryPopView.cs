using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004040 RID: 16448
	public class SummaryPopView : UiViewBase
	{
		// Token: 0x06029B11 RID: 170769 RVA: 0x00BC8FAA File Offset: 0x00BC71AA
		[NullableContext(1)]
		public SummaryPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06029B12 RID: 170770 RVA: 0x00BC8FB4 File Offset: 0x00BC71B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnConfirm));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnCancel));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnCancel));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06029B13 RID: 170771 RVA: 0x00BC90E4 File Offset: 0x00BC72E4
		protected override void OnStart()
		{
			this.Done = false;
			SummaryData summaryData = this.OpenParam as SummaryData;
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetText(((summaryData != null) ? summaryData.Text : null) ?? string.Empty, true);
		}

		// Token: 0x06029B14 RID: 170772 RVA: 0x00BC912C File Offset: 0x00BC732C
		protected void OnConfirm()
		{
			if (this.Done)
			{
				return;
			}
			this.Done = true;
			SummaryData summaryData = this.OpenParam as SummaryData;
			Action confirmFunc = (summaryData != null) ? summaryData.ConfirmFunc : null;
			base.CloseMe(delegate(bool _)
			{
				Action confirmFunc = confirmFunc;
				if (confirmFunc == null)
				{
					return;
				}
				confirmFunc();
			});
		}

		// Token: 0x06029B15 RID: 170773 RVA: 0x00BC9180 File Offset: 0x00BC7380
		protected void OnCancel()
		{
			if (this.Done)
			{
				return;
			}
			this.Done = true;
			SummaryData summaryData = this.OpenParam as SummaryData;
			Action cancelFunc = (summaryData != null) ? summaryData.CancelFunc : null;
			base.CloseMe(delegate(bool _)
			{
				Action cancelFunc = cancelFunc;
				if (cancelFunc == null)
				{
					return;
				}
				cancelFunc();
			});
		}

		// Token: 0x04016BFF RID: 93183
		private bool Done;

		// Token: 0x02009C45 RID: 40005
		private static class EChildComp
		{
			// Token: 0x04030A1D RID: 199197
			public const int Exit = 0;

			// Token: 0x04030A1E RID: 199198
			public const int ConfirmButton = 1;

			// Token: 0x04030A1F RID: 199199
			public const int CancelButton = 2;

			// Token: 0x04030A20 RID: 199200
			public const int Text = 3;
		}
	}
}
