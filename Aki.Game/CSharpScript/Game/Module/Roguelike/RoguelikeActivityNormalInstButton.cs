using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DE4 RID: 19940
	public class RoguelikeActivityNormalInstButton : UiPanelBase
	{
		// Token: 0x0603376C RID: 210796 RVA: 0x00C06328 File Offset: 0x00C04528
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonCallback));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603376D RID: 210797 RVA: 0x00C06410 File Offset: 0x00C04610
		private void ButtonCallback()
		{
			Action buttonCallbackInternal = this.ButtonCallbackInternal;
			if (buttonCallbackInternal == null)
			{
				return;
			}
			buttonCallbackInternal();
		}

		// Token: 0x0603376E RID: 210798 RVA: 0x00C06422 File Offset: 0x00C04622
		[NullableContext(1)]
		public void SetButtonCallback(Action callback)
		{
			this.ButtonCallbackInternal = callback;
		}

		// Token: 0x0603376F RID: 210799 RVA: 0x00C0642B File Offset: 0x00C0462B
		public void SetProcessingState(bool bVisible)
		{
			base.GetItem(3).SetUIActive(bVisible);
		}

		// Token: 0x0401B517 RID: 111895
		[Nullable(2)]
		private Action ButtonCallbackInternal;

		// Token: 0x0200AF6B RID: 44907
		private class EComponents
		{
			// Token: 0x0403543B RID: 218171
			public const int BtnConfirm = 0;

			// Token: 0x0403543C RID: 218172
			public const int TxtConfirm = 1;

			// Token: 0x0403543D RID: 218173
			public const int ItemRedDot = 2;

			// Token: 0x0403543E RID: 218174
			public const int PanelProcessing = 3;
		}
	}
}
