using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Pause
{
	// Token: 0x0200573E RID: 22334
	internal class PauseButtonItem : UiPanelBase
	{
		// Token: 0x06038C73 RID: 232563 RVA: 0x00D7B0CC File Offset: 0x00D792CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038C74 RID: 232564 RVA: 0x00D7B172 File Offset: 0x00D79372
		[NullableContext(1)]
		public void SetClickCb(Action cb)
		{
			this.ClickCb = cb;
		}

		// Token: 0x06038C75 RID: 232565 RVA: 0x00D7B17B File Offset: 0x00D7937B
		private void OnClick()
		{
			Action clickCb = this.ClickCb;
			if (clickCb == null)
			{
				return;
			}
			clickCb();
		}

		// Token: 0x0401DC88 RID: 121992
		[Nullable(2)]
		private Action ClickCb;

		// Token: 0x0200B922 RID: 47394
		private enum EPauseBtnComp
		{
			// Token: 0x04037FE2 RID: 229346
			Self,
			// Token: 0x04037FE3 RID: 229347
			Button
		}
	}
}
