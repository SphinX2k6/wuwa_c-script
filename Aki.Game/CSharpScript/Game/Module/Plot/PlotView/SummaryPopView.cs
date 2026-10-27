using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005070 RID: 20592
	public class SummaryPopView : UiViewBase
	{
		// Token: 0x06034C1C RID: 216092 RVA: 0x00C7BBD2 File Offset: 0x00C79DD2
		[NullableContext(1)]
		public SummaryPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034C1D RID: 216093 RVA: 0x00C7BBDC File Offset: 0x00C79DDC
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

		// Token: 0x06034C1E RID: 216094 RVA: 0x00C7BD0C File Offset: 0x00C79F0C
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

		// Token: 0x06034C1F RID: 216095 RVA: 0x00C7BD54 File Offset: 0x00C79F54
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

		// Token: 0x06034C20 RID: 216096 RVA: 0x00C7BDA8 File Offset: 0x00C79FA8
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

		// Token: 0x0401C1D4 RID: 115156
		private bool Done;

		// Token: 0x0200B20C RID: 45580
		private static class EChildComp
		{
			// Token: 0x04035FC9 RID: 221129
			public const int Exit = 0;

			// Token: 0x04035FCA RID: 221130
			public const int ConfirmButton = 1;

			// Token: 0x04035FCB RID: 221131
			public const int CancelButton = 2;

			// Token: 0x04035FCC RID: 221132
			public const int Text = 3;
		}
	}
}
