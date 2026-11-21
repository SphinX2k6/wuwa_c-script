using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004AF4 RID: 19188
	[NullableContext(1)]
	[Nullable(0)]
	public class ConfirmButtonCompose : UiPanelBase
	{
		// Token: 0x0602FFD9 RID: 196569 RVA: 0x00D63167 File Offset: 0x00D61367
		public ConfirmButtonCompose(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602FFDA RID: 196570 RVA: 0x00D6317C File Offset: 0x00D6137C
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602FFDB RID: 196571 RVA: 0x00D63222 File Offset: 0x00D61422
		public void UpdateText(string text)
		{
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x0602FFDC RID: 196572 RVA: 0x00D63232 File Offset: 0x00D61432
		public void RefreshButton(bool isEnable)
		{
			((base.GetButton(0).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup).SetInteractable(isEnable);
		}

		// Token: 0x0602FFDD RID: 196573 RVA: 0x00D6325F File Offset: 0x00D6145F
		public void BindClickFunction(Action onClickFunction)
		{
			this.OnClickFunction = onClickFunction;
		}

		// Token: 0x0602FFDE RID: 196574 RVA: 0x00D63268 File Offset: 0x00D61468
		private void OnClick()
		{
			Action onClickFunction = this.OnClickFunction;
			if (onClickFunction == null)
			{
				return;
			}
			onClickFunction();
		}

		// Token: 0x0401976B RID: 104299
		[Nullable(2)]
		private Action OnClickFunction;

		// Token: 0x0200A757 RID: 42839
		[NullableContext(0)]
		private enum EConfirmDefine
		{
			// Token: 0x04033B53 RID: 211795
			ConfirmButton,
			// Token: 0x04033B54 RID: 211796
			ConfirmText
		}
	}
}
