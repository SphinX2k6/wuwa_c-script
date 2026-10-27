using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x0200609E RID: 24734
	public class Spring25EnvelopeView : UiViewBase
	{
		// Token: 0x0603E852 RID: 256082 RVA: 0x00F1C7FA File Offset: 0x00F1A9FA
		[NullableContext(1)]
		public Spring25EnvelopeView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603E853 RID: 256083 RVA: 0x00F1C804 File Offset: 0x00F1AA04
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

		// Token: 0x0603E854 RID: 256084 RVA: 0x00F1C910 File Offset: 0x00F1AB10
		protected override void OnStart()
		{
			Spring25EnvelopeViewData spring25EnvelopeViewData = this.OpenParam as Spring25EnvelopeViewData;
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), spring25EnvelopeViewData.InfoTextId, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(3), spring25EnvelopeViewData.TitleTextId, Array.Empty<object>());
		}

		// Token: 0x0603E855 RID: 256085 RVA: 0x00F1C961 File Offset: 0x00F1AB61
		private void HandleBackClick()
		{
			ActivitySpring25Controller.Instance.HandleResetCurrentSignId();
			base.CloseMe(null);
		}

		// Token: 0x0603E856 RID: 256086 RVA: 0x00F1C974 File Offset: 0x00F1AB74
		private void HandleConfirmClick()
		{
			ActivitySpring25Controller.Instance.HandleResetCurrentSignId();
			base.CloseMe(null);
		}

		// Token: 0x0200C2F5 RID: 49909
		private class EComponent
		{
			// Token: 0x0403ADE4 RID: 241124
			public const int InfoText = 0;

			// Token: 0x0403ADE5 RID: 241125
			public const int BackButton = 1;

			// Token: 0x0403ADE6 RID: 241126
			public const int ConfirmButton = 2;

			// Token: 0x0403ADE7 RID: 241127
			public const int TitleText = 3;
		}
	}
}
