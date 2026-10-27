using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006839 RID: 26681
	internal class DangoBrawlFinalSettleButton : UiPanelBase
	{
		// Token: 0x0604298E RID: 272782 RVA: 0x01030A18 File Offset: 0x0102EC18
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

		// Token: 0x0604298F RID: 272783 RVA: 0x01030ADF File Offset: 0x0102ECDF
		[NullableContext(1)]
		public void SetConfirmText(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
		}

		// Token: 0x06042990 RID: 272784 RVA: 0x01030AF8 File Offset: 0x0102ECF8
		private void OnClickBtn()
		{
			Action onClickCallBack = this.OnClickCallBack;
			if (onClickCallBack == null)
			{
				return;
			}
			onClickCallBack();
		}

		// Token: 0x04022B17 RID: 142103
		[Nullable(2)]
		public Action OnClickCallBack;

		// Token: 0x0200C9FB RID: 51707
		private enum EComponent
		{
			// Token: 0x0403D084 RID: 249988
			Btn,
			// Token: 0x0403D085 RID: 249989
			TxtConfirm,
			// Token: 0x0403D086 RID: 249990
			UiItem
		}
	}
}
