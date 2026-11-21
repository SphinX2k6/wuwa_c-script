using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005789 RID: 22409
	internal class DangoBrawlFinalSettleButton : UiPanelBase
	{
		// Token: 0x060374E2 RID: 226530 RVA: 0x00F71F24 File Offset: 0x00F70124
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060374E3 RID: 226531 RVA: 0x00F71FEB File Offset: 0x00F701EB
		[NullableContext(1)]
		public void SetConfirmText(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
		}

		// Token: 0x060374E4 RID: 226532 RVA: 0x00F72004 File Offset: 0x00F70204
		private void OnClickBtn()
		{
			Action onClickCallBack = this.OnClickCallBack;
			if (onClickCallBack == null)
			{
				return;
			}
			onClickCallBack();
		}

		// Token: 0x0401D374 RID: 119668
		[Nullable(2)]
		public Action OnClickCallBack;

		// Token: 0x0200B3C7 RID: 46023
		private enum EComponent
		{
			// Token: 0x0403796D RID: 227693
			Btn,
			// Token: 0x0403796E RID: 227694
			TxtConfirm,
			// Token: 0x0403796F RID: 227695
			UiItem
		}
	}
}
