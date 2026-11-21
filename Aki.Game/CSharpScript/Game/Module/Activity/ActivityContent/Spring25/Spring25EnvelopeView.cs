using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x0200501C RID: 20508
	public class Spring25EnvelopeView : UiViewBase
	{
		// Token: 0x06033516 RID: 210198 RVA: 0x00E635BE File Offset: 0x00E617BE
		[NullableContext(1)]
		public Spring25EnvelopeView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033517 RID: 210199 RVA: 0x00E635C8 File Offset: 0x00E617C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.HandleBackClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.HandleConfirmClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033518 RID: 210200 RVA: 0x00E636D4 File Offset: 0x00E618D4
		protected override void OnStart()
		{
			Spring25EnvelopeViewData spring25EnvelopeViewData = this.OpenParam as Spring25EnvelopeViewData;
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), spring25EnvelopeViewData.InfoTextId, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(3), spring25EnvelopeViewData.TitleTextId, Array.Empty<object>());
		}

		// Token: 0x06033519 RID: 210201 RVA: 0x00E63725 File Offset: 0x00E61925
		private void HandleBackClick()
		{
			ActivitySpring25Controller.Instance.HandleResetCurrentSignId();
			base.CloseMe(null);
		}

		// Token: 0x0603351A RID: 210202 RVA: 0x00E63738 File Offset: 0x00E61938
		private void HandleConfirmClick()
		{
			ActivitySpring25Controller.Instance.HandleResetCurrentSignId();
			base.CloseMe(null);
		}

		// Token: 0x0200ACE0 RID: 44256
		private class EComponent
		{
			// Token: 0x0403574C RID: 218956
			public const int InfoText = 0;

			// Token: 0x0403574D RID: 218957
			public const int BackButton = 1;

			// Token: 0x0403574E RID: 218958
			public const int ConfirmButton = 2;

			// Token: 0x0403574F RID: 218959
			public const int TitleText = 3;
		}
	}
}
