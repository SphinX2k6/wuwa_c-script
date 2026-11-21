using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DAD RID: 15789
	public class RoguelikeActivityNormalInstButton : UiPanelBase
	{
		// Token: 0x060285D7 RID: 165335 RVA: 0x00B4F838 File Offset: 0x00B4DA38
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

		// Token: 0x060285D8 RID: 165336 RVA: 0x00B4F920 File Offset: 0x00B4DB20
		private void ButtonCallback()
		{
			Action buttonCallbackInternal = this.ButtonCallbackInternal;
			if (buttonCallbackInternal == null)
			{
				return;
			}
			buttonCallbackInternal();
		}

		// Token: 0x060285D9 RID: 165337 RVA: 0x00B4F932 File Offset: 0x00B4DB32
		[NullableContext(1)]
		public void SetButtonCallback(Action callback)
		{
			this.ButtonCallbackInternal = callback;
		}

		// Token: 0x060285DA RID: 165338 RVA: 0x00B4F93B File Offset: 0x00B4DB3B
		public void SetProcessingState(bool bVisible)
		{
			base.GetItem(3).SetUIActive(bVisible);
		}

		// Token: 0x04015EEA RID: 89834
		[Nullable(2)]
		private Action ButtonCallbackInternal;

		// Token: 0x020099A0 RID: 39328
		private class EComponents
		{
			// Token: 0x0402FE6E RID: 196206
			public const int BtnConfirm = 0;

			// Token: 0x0402FE6F RID: 196207
			public const int TxtConfirm = 1;

			// Token: 0x0402FE70 RID: 196208
			public const int ItemRedDot = 2;

			// Token: 0x0402FE71 RID: 196209
			public const int PanelProcessing = 3;
		}
	}
}
