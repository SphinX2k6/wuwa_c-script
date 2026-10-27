using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200464F RID: 17999
	public class PopupCaptionStateItem : UiPanelBase
	{
		// Token: 0x0602E776 RID: 190326 RVA: 0x00ABC27C File Offset: 0x00ABA47C
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

		// Token: 0x0602E777 RID: 190327 RVA: 0x00ABC343 File Offset: 0x00ABA543
		protected override void OnStart()
		{
			this.OldColor = base.GetSprite(1).GetColor();
			this.ChangeColor = FColor.FromHex("FFCC7B");
		}

		// Token: 0x0602E778 RID: 190328 RVA: 0x00ABC367 File Offset: 0x00ABA567
		private void OnClickBtn()
		{
			Action onClickCallBack = this.OnClickCallBack;
			if (onClickCallBack == null)
			{
				return;
			}
			onClickCallBack();
		}

		// Token: 0x0602E779 RID: 190329 RVA: 0x00ABC379 File Offset: 0x00ABA579
		[NullableContext(1)]
		public void BindClick(Action callback)
		{
			this.OnClickCallBack = callback;
		}

		// Token: 0x0602E77A RID: 190330 RVA: 0x00ABC382 File Offset: 0x00ABA582
		[NullableContext(1)]
		public void SetTipsLocalText(string localKey)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), localKey, Array.Empty<object>());
		}

		// Token: 0x0602E77B RID: 190331 RVA: 0x00ABC39C File Offset: 0x00ABA59C
		public void SetCaptionChangeColor(bool useChangeColor)
		{
			FColor color = useChangeColor ? this.ChangeColor : this.OldColor;
			base.GetSprite(1).SetColor(color);
			base.GetText(2).SetColor(color);
		}

		// Token: 0x04018E2C RID: 101932
		private FColor OldColor;

		// Token: 0x04018E2D RID: 101933
		private FColor ChangeColor;

		// Token: 0x04018E2E RID: 101934
		[Nullable(2)]
		protected Action OnClickCallBack;

		// Token: 0x0200A8B4 RID: 43188
		private class EComponents
		{
			// Token: 0x040335B7 RID: 210359
			public const int BtnFunctionA = 0;

			// Token: 0x040335B8 RID: 210360
			public const int SprIcon = 1;

			// Token: 0x040335B9 RID: 210361
			public const int TxtBtnTips = 2;
		}
	}
}
