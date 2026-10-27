using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DF5 RID: 19957
	public class RoguelikePhantomNewUnlockView : UiViewBase
	{
		// Token: 0x06033800 RID: 210944 RVA: 0x00C087DD File Offset: 0x00C069DD
		[NullableContext(1)]
		public RoguelikePhantomNewUnlockView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033801 RID: 210945 RVA: 0x00C087E8 File Offset: 0x00C069E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.CloseBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033802 RID: 210946 RVA: 0x00C08914 File Offset: 0x00C06B14
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikePhantomNewUnlockView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikePhantomNewUnlockView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033803 RID: 210947 RVA: 0x00C08957 File Offset: 0x00C06B57
		private void CloseBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06033804 RID: 210948 RVA: 0x00C08960 File Offset: 0x00C06B60
		[NullableContext(1)]
		private RoguelikePhantomSelectDragItem CreatePhantomSelectDragItem()
		{
			return new RoguelikePhantomSelectDragItem
			{
				CanToggleStateChange = new Func<bool, bool>(this.CanToggleStateChange)
			};
		}

		// Token: 0x06033805 RID: 210949 RVA: 0x00C08979 File Offset: 0x00C06B79
		private bool CanToggleStateChange(bool bState)
		{
			return false;
		}

		// Token: 0x0401B542 RID: 111938
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoguelikePhantomSelectDragItem, IPhantomSelectItemData> PhantomSelectItemLayout;

		// Token: 0x0200AF7C RID: 44924
		private class EComponents
		{
			// Token: 0x0403548B RID: 218251
			public const int BtnMask = 0;

			// Token: 0x0403548C RID: 218252
			public const int TxtTitle = 1;

			// Token: 0x0403548D RID: 218253
			public const int PanelTitle = 2;

			// Token: 0x0403548E RID: 218254
			public const int TxtClose = 3;

			// Token: 0x0403548F RID: 218255
			public const int ScrollView = 4;

			// Token: 0x04035490 RID: 218256
			public const int Content = 5;
		}
	}
}
