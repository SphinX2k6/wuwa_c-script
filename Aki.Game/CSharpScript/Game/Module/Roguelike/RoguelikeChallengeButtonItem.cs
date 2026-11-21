using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D8E RID: 15758
	public class RoguelikeChallengeButtonItem : UiPanelBase
	{
		// Token: 0x060284B9 RID: 165049 RVA: 0x00B490CC File Offset: 0x00B472CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonCallback));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060284BA RID: 165050 RVA: 0x00B491D5 File Offset: 0x00B473D5
		private void ButtonCallback()
		{
			Action buttonCallbackInternal = this.ButtonCallbackInternal;
			if (buttonCallbackInternal == null)
			{
				return;
			}
			buttonCallbackInternal();
		}

		// Token: 0x060284BB RID: 165051 RVA: 0x00B491E7 File Offset: 0x00B473E7
		[NullableContext(1)]
		public void SetButtonCallback(Action callback)
		{
			this.ButtonCallbackInternal = callback;
		}

		// Token: 0x060284BC RID: 165052 RVA: 0x00B491F0 File Offset: 0x00B473F0
		public void SetTxtScore(int count)
		{
			base.GetText(3).SetText(count.ToString(), true);
		}

		// Token: 0x060284BD RID: 165053 RVA: 0x00B49206 File Offset: 0x00B47406
		public void SetProcessingState(bool bVisible)
		{
			base.GetItem(4).SetUIActive(bVisible);
		}

		// Token: 0x04015E71 RID: 89713
		[Nullable(2)]
		private Action ButtonCallbackInternal;

		// Token: 0x02009971 RID: 39281
		private class EComponents
		{
			// Token: 0x0402FD99 RID: 195993
			public const int BtnConfirm = 0;

			// Token: 0x0402FD9A RID: 195994
			public const int TxtConfirm = 1;

			// Token: 0x0402FD9B RID: 195995
			public const int ItemRedDot = 2;

			// Token: 0x0402FD9C RID: 195996
			public const int TxtScore = 3;

			// Token: 0x0402FD9D RID: 195997
			public const int PanelProcessing = 4;
		}
	}
}
