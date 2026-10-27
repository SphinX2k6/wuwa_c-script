using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02005676 RID: 22134
	[NullableContext(1)]
	[Nullable(0)]
	public class ConfirmButtonCompose : UiPanelBase
	{
		// Token: 0x06038550 RID: 230736 RVA: 0x00D5DFB7 File Offset: 0x00D5C1B7
		public ConfirmButtonCompose(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06038551 RID: 230737 RVA: 0x00D5DFCC File Offset: 0x00D5C1CC
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

		// Token: 0x06038552 RID: 230738 RVA: 0x00D5E072 File Offset: 0x00D5C272
		public void UpdateText(string text)
		{
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x06038553 RID: 230739 RVA: 0x00D5E082 File Offset: 0x00D5C282
		public void RefreshButton(bool isEnable)
		{
			((UUIInteractionGroup)((AUIBaseActor)base.GetButton(0).GetOwner()).GetComponentByClass(UUIInteractionGroup.StaticClass())).SetInteractable(isEnable);
		}

		// Token: 0x06038554 RID: 230740 RVA: 0x00D5E0AF File Offset: 0x00D5C2AF
		public void BindClickFunction(Action onClickFunction)
		{
			this.OnClickFunction = onClickFunction;
		}

		// Token: 0x06038555 RID: 230741 RVA: 0x00D5E0B8 File Offset: 0x00D5C2B8
		private void OnClick()
		{
			this.OnClickFunction();
		}

		// Token: 0x0401D9B2 RID: 121266
		[Nullable(2)]
		private Action OnClickFunction;

		// Token: 0x0200B840 RID: 47168
		[NullableContext(0)]
		private class EConfirmDefine
		{
			// Token: 0x04037C52 RID: 228434
			public const int ConfirmButton = 0;

			// Token: 0x04037C53 RID: 228435
			public const int ConfirmText = 1;
		}
	}
}
