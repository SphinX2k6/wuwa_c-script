using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DC5 RID: 19909
	public class RoguelikeChallengeButtonItem : UiPanelBase
	{
		// Token: 0x0603364C RID: 210508 RVA: 0x00BFFB8C File Offset: 0x00BFDD8C
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

		// Token: 0x0603364D RID: 210509 RVA: 0x00BFFC95 File Offset: 0x00BFDE95
		private void ButtonCallback()
		{
			Action buttonCallbackInternal = this.ButtonCallbackInternal;
			if (buttonCallbackInternal == null)
			{
				return;
			}
			buttonCallbackInternal();
		}

		// Token: 0x0603364E RID: 210510 RVA: 0x00BFFCA7 File Offset: 0x00BFDEA7
		[NullableContext(1)]
		public void SetButtonCallback(Action callback)
		{
			this.ButtonCallbackInternal = callback;
		}

		// Token: 0x0603364F RID: 210511 RVA: 0x00BFFCB0 File Offset: 0x00BFDEB0
		public void SetTxtScore(int count)
		{
			base.GetText(3).SetText(count.ToString(), true);
		}

		// Token: 0x06033650 RID: 210512 RVA: 0x00BFFCC6 File Offset: 0x00BFDEC6
		public void SetProcessingState(bool bVisible)
		{
			base.GetItem(4).SetUIActive(bVisible);
		}

		// Token: 0x0401B49E RID: 111774
		[Nullable(2)]
		private Action ButtonCallbackInternal;

		// Token: 0x0200AF3C RID: 44860
		private class EComponents
		{
			// Token: 0x04035364 RID: 217956
			public const int BtnConfirm = 0;

			// Token: 0x04035365 RID: 217957
			public const int TxtConfirm = 1;

			// Token: 0x04035366 RID: 217958
			public const int ItemRedDot = 2;

			// Token: 0x04035367 RID: 217959
			public const int TxtScore = 3;

			// Token: 0x04035368 RID: 217960
			public const int PanelProcessing = 4;
		}
	}
}
