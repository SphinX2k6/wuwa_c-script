using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Plot
{
	// Token: 0x02006324 RID: 25380
	public class PinballPlotSelectionItem : UiPanelBase
	{
		// Token: 0x0603FD77 RID: 261495 RVA: 0x00F71C58 File Offset: 0x00F6FE58
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnOptionButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FD78 RID: 261496 RVA: 0x00F71D00 File Offset: 0x00F6FF00
		[NullableContext(1)]
		public void Refresh(IPinballPlotSelectionItemData data)
		{
			this.Data = data;
			string newText = PinballConfig.Instance.CovertOptionIndexToText(data.OptionIndex);
			base.GetText(1).SetText(newText, true);
		}

		// Token: 0x0603FD79 RID: 261497 RVA: 0x00F71D33 File Offset: 0x00F6FF33
		private void OnOptionButtonClick()
		{
			if (this.Data == null)
			{
				return;
			}
			this.Data.OptionDelegate(this.Data.OptionIndex);
		}

		// Token: 0x040214FC RID: 136444
		[Nullable(2)]
		private IPinballPlotSelectionItemData Data;

		// Token: 0x0200C51B RID: 50459
		private enum EComponent
		{
			// Token: 0x0403B7C2 RID: 243650
			OptionButton,
			// Token: 0x0403B7C3 RID: 243651
			OptionTitleText
		}
	}
}
