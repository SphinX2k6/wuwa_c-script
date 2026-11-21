using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x0200464C RID: 17996
	[NullableContext(1)]
	[Nullable(0)]
	public class ConfirmButtonCompose : UiPanelBase
	{
		// Token: 0x0602D44D RID: 185421 RVA: 0x00CAC0B7 File Offset: 0x00CAA2B7
		public ConfirmButtonCompose(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602D44E RID: 185422 RVA: 0x00CAC0CC File Offset: 0x00CAA2CC
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

		// Token: 0x0602D44F RID: 185423 RVA: 0x00CAC172 File Offset: 0x00CAA372
		public void UpdateText(string text)
		{
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x0602D450 RID: 185424 RVA: 0x00CAC182 File Offset: 0x00CAA382
		public void RefreshButton(bool isEnable)
		{
			((UUIInteractionGroup)((AUIBaseActor)base.GetButton(0).GetOwner()).GetComponentByClass(UUIInteractionGroup.StaticClass())).SetInteractable(isEnable);
		}

		// Token: 0x0602D451 RID: 185425 RVA: 0x00CAC1AF File Offset: 0x00CAA3AF
		public void BindClickFunction(Action onClickFunction)
		{
			this.OnClickFunction = onClickFunction;
		}

		// Token: 0x0602D452 RID: 185426 RVA: 0x00CAC1B8 File Offset: 0x00CAA3B8
		private void OnClick()
		{
			this.OnClickFunction();
		}

		// Token: 0x0401843D RID: 99389
		[Nullable(2)]
		private Action OnClickFunction;

		// Token: 0x0200A268 RID: 41576
		[NullableContext(0)]
		private class EConfirmDefine
		{
			// Token: 0x04032670 RID: 206448
			public const int ConfirmButton = 0;

			// Token: 0x04032671 RID: 206449
			public const int ConfirmText = 1;
		}
	}
}
