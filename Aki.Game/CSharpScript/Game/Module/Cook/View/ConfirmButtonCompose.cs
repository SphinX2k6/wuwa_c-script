using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02005B13 RID: 23315
	[NullableContext(1)]
	[Nullable(0)]
	public class ConfirmButtonCompose : UiPanelBase
	{
		// Token: 0x0603B067 RID: 241767 RVA: 0x00E1244F File Offset: 0x00E1064F
		public ConfirmButtonCompose(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B068 RID: 241768 RVA: 0x00E12464 File Offset: 0x00E10664
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

		// Token: 0x0603B069 RID: 241769 RVA: 0x00E1250A File Offset: 0x00E1070A
		public void UpdateText(string text)
		{
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x0603B06A RID: 241770 RVA: 0x00E1251A File Offset: 0x00E1071A
		public void RefreshButton(bool isEnable)
		{
			((base.GetButton(0).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup).SetInteractable(isEnable);
		}

		// Token: 0x0603B06B RID: 241771 RVA: 0x00E12547 File Offset: 0x00E10747
		public void BindClickFunction(Action onClickFunction)
		{
			this.OnClickFunction = onClickFunction;
		}

		// Token: 0x0603B06C RID: 241772 RVA: 0x00E12550 File Offset: 0x00E10750
		private void OnClick()
		{
			Action onClickFunction = this.OnClickFunction;
			if (onClickFunction == null)
			{
				return;
			}
			onClickFunction();
		}

		// Token: 0x0401ECAF RID: 126127
		[Nullable(2)]
		private Action OnClickFunction;

		// Token: 0x0200BD4E RID: 48462
		[NullableContext(0)]
		private enum EConfirmDefine
		{
			// Token: 0x04039187 RID: 233863
			ConfirmButton,
			// Token: 0x04039188 RID: 233864
			ConfirmText
		}
	}
}
