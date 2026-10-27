using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Plot
{
	// Token: 0x02006321 RID: 25377
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballPlotOptionItem : GridProxyAbstract<IPinballPlotOptionItemData>
	{
		// Token: 0x0603FD6A RID: 261482 RVA: 0x00F71ACC File Offset: 0x00F6FCCC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnOptionButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FD6B RID: 261483 RVA: 0x00F71B94 File Offset: 0x00F6FD94
		[NullableContext(1)]
		public override void Refresh(IPinballPlotOptionItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			string newText = PinballConfig.Instance.CovertOptionIndexToText(data.OptionIndex);
			base.GetText(1).SetText(newText, true);
			TableTextArgNew optionText = data.OptionText;
			string textStringId = optionText.TextKey ?? "";
			IReadOnlyList<object> args = optionText.Params ?? Array.Empty<object>();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textStringId, args);
		}

		// Token: 0x0603FD6C RID: 261484 RVA: 0x00F71BFF File Offset: 0x00F6FDFF
		private void OnOptionButtonClick()
		{
			if (this.Data == null)
			{
				return;
			}
			this.Data.OptionDelegate(this.Data.OptionIndex);
		}

		// Token: 0x040214F9 RID: 136441
		[Nullable(2)]
		private IPinballPlotOptionItemData Data;

		// Token: 0x0200C51A RID: 50458
		private enum EComponent
		{
			// Token: 0x0403B7BE RID: 243646
			OptionButton,
			// Token: 0x0403B7BF RID: 243647
			OptionTitleText,
			// Token: 0x0403B7C0 RID: 243648
			OptionDescText
		}
	}
}
