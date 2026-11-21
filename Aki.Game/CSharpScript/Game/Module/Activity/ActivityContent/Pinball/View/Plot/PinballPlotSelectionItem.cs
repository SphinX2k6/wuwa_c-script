using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Plot
{
	// Token: 0x020052A2 RID: 21154
	public class PinballPlotSelectionItem : UiPanelBase
	{
		// Token: 0x06034A38 RID: 215608 RVA: 0x00EB8BB4 File Offset: 0x00EB6DB4
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

		// Token: 0x06034A39 RID: 215609 RVA: 0x00EB8C5C File Offset: 0x00EB6E5C
		[NullableContext(1)]
		public void Refresh(IPinballPlotSelectionItemData data)
		{
			this.Data = data;
			string newText = PinballConfig.Instance.CovertOptionIndexToText(data.OptionIndex);
			base.GetText(1).SetText(newText, true);
		}

		// Token: 0x06034A3A RID: 215610 RVA: 0x00EB8C8F File Offset: 0x00EB6E8F
		private void OnOptionButtonClick()
		{
			if (this.Data == null)
			{
				return;
			}
			this.Data.OptionDelegate(this.Data.OptionIndex);
		}

		// Token: 0x0401BE2B RID: 114219
		[Nullable(2)]
		private IPinballPlotSelectionItemData Data;

		// Token: 0x0200AF02 RID: 44802
		private enum EComponent
		{
			// Token: 0x04036124 RID: 221476
			OptionButton,
			// Token: 0x04036125 RID: 221477
			OptionTitleText
		}
	}
}
