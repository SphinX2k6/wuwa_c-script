using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Pause
{
	// Token: 0x02004715 RID: 18197
	internal class PauseButtonItem : UiPanelBase
	{
		// Token: 0x0602DB83 RID: 187267 RVA: 0x00CC977C File Offset: 0x00CC797C
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

		// Token: 0x0602DB84 RID: 187268 RVA: 0x00CC9822 File Offset: 0x00CC7A22
		[NullableContext(1)]
		public void SetClickCb(Action cb)
		{
			this.ClickCb = cb;
		}

		// Token: 0x0602DB85 RID: 187269 RVA: 0x00CC982B File Offset: 0x00CC7A2B
		private void OnClick()
		{
			Action clickCb = this.ClickCb;
			if (clickCb == null)
			{
				return;
			}
			clickCb();
		}

		// Token: 0x0401871E RID: 100126
		[Nullable(2)]
		private Action ClickCb;

		// Token: 0x0200A343 RID: 41795
		private enum EPauseBtnComp
		{
			// Token: 0x040329F2 RID: 207346
			Self,
			// Token: 0x040329F3 RID: 207347
			Button
		}
	}
}
