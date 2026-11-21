using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048E2 RID: 18658
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrActivityBtnItem : UiPanelBase
	{
		// Token: 0x0602ED3A RID: 191802 RVA: 0x00D0E590 File Offset: 0x00D0C790
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602ED3B RID: 191803 RVA: 0x00D0E657 File Offset: 0x00D0C857
		private void ButtonClick()
		{
			Action buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction();
		}

		// Token: 0x0602ED3C RID: 191804 RVA: 0x00D0E669 File Offset: 0x00D0C869
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x0602ED3D RID: 191805 RVA: 0x00D0E672 File Offset: 0x00D0C872
		public void SetText(string text)
		{
			base.GetText(1).ShowTextNew(text);
		}

		// Token: 0x0602ED3E RID: 191806 RVA: 0x00D0E681 File Offset: 0x00D0C881
		public void SetRedPointVisible(bool visible)
		{
			base.GetItem(2).SetUIActive(visible);
		}

		// Token: 0x04018DA8 RID: 101800
		private Action ButtonFunction;

		// Token: 0x0200A580 RID: 42368
		[NullableContext(0)]
		private class EButtonItemDefine
		{
			// Token: 0x04033325 RID: 209701
			public const int Button = 0;

			// Token: 0x04033326 RID: 209702
			public const int ButtonText = 1;

			// Token: 0x04033327 RID: 209703
			public const int PanelRedPoint = 2;
		}
	}
}
