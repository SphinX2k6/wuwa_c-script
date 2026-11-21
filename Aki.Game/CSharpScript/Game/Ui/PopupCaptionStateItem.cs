using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003580 RID: 13696
	public class PopupCaptionStateItem : UiPanelBase
	{
		// Token: 0x06022EC0 RID: 143040 RVA: 0x009E98AC File Offset: 0x009E7AAC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06022EC1 RID: 143041 RVA: 0x009E9973 File Offset: 0x009E7B73
		protected override void OnStart()
		{
			this.OldColor = base.GetSprite(1).GetColor();
			this.ChangeColor = FColor.FromHex("FFCC7B");
		}

		// Token: 0x06022EC2 RID: 143042 RVA: 0x009E9997 File Offset: 0x009E7B97
		private void OnClickBtn()
		{
			Action onClickCallBack = this.OnClickCallBack;
			if (onClickCallBack == null)
			{
				return;
			}
			onClickCallBack();
		}

		// Token: 0x06022EC3 RID: 143043 RVA: 0x009E99A9 File Offset: 0x009E7BA9
		[NullableContext(1)]
		public void BindClick(Action callback)
		{
			this.OnClickCallBack = callback;
		}

		// Token: 0x06022EC4 RID: 143044 RVA: 0x009E99B2 File Offset: 0x009E7BB2
		[NullableContext(1)]
		public void SetTipsLocalText(string localKey)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), localKey, Array.Empty<object>());
		}

		// Token: 0x06022EC5 RID: 143045 RVA: 0x009E99CC File Offset: 0x009E7BCC
		public void SetCaptionChangeColor(bool useChangeColor)
		{
			FColor color = useChangeColor ? this.ChangeColor : this.OldColor;
			base.GetSprite(1).SetColor(color);
			base.GetText(2).SetColor(color);
		}

		// Token: 0x04013485 RID: 78981
		private FColor OldColor;

		// Token: 0x04013486 RID: 78982
		private FColor ChangeColor;

		// Token: 0x04013487 RID: 78983
		[Nullable(2)]
		protected Action OnClickCallBack;

		// Token: 0x02009270 RID: 37488
		private class EComponents
		{
			// Token: 0x0402DD4D RID: 187725
			public const int BtnFunctionA = 0;

			// Token: 0x0402DD4E RID: 187726
			public const int SprIcon = 1;

			// Token: 0x0402DD4F RID: 187727
			public const int TxtBtnTips = 2;
		}
	}
}
