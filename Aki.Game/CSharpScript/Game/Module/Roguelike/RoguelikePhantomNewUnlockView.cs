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
	// Token: 0x02003DBE RID: 15806
	public class RoguelikePhantomNewUnlockView : UiViewBase
	{
		// Token: 0x0602866B RID: 165483 RVA: 0x00B51CED File Offset: 0x00B4FEED
		[NullableContext(1)]
		public RoguelikePhantomNewUnlockView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602866C RID: 165484 RVA: 0x00B51CF8 File Offset: 0x00B4FEF8
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

		// Token: 0x0602866D RID: 165485 RVA: 0x00B51E24 File Offset: 0x00B50024
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikePhantomNewUnlockView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikePhantomNewUnlockView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602866E RID: 165486 RVA: 0x00B51E67 File Offset: 0x00B50067
		private void CloseBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602866F RID: 165487 RVA: 0x00B51E70 File Offset: 0x00B50070
		[NullableContext(1)]
		private RoguelikePhantomSelectDragItem CreatePhantomSelectDragItem()
		{
			return new RoguelikePhantomSelectDragItem
			{
				CanToggleStateChange = new Func<bool, bool>(this.CanToggleStateChange)
			};
		}

		// Token: 0x06028670 RID: 165488 RVA: 0x00B51E89 File Offset: 0x00B50089
		private bool CanToggleStateChange(bool bState)
		{
			return false;
		}

		// Token: 0x04015F15 RID: 89877
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoguelikePhantomSelectDragItem, IPhantomSelectItemData> PhantomSelectItemLayout;

		// Token: 0x020099B1 RID: 39345
		private class EComponents
		{
			// Token: 0x0402FEBE RID: 196286
			public const int BtnMask = 0;

			// Token: 0x0402FEBF RID: 196287
			public const int TxtTitle = 1;

			// Token: 0x0402FEC0 RID: 196288
			public const int PanelTitle = 2;

			// Token: 0x0402FEC1 RID: 196289
			public const int TxtClose = 3;

			// Token: 0x0402FEC2 RID: 196290
			public const int ScrollView = 4;

			// Token: 0x0402FEC3 RID: 196291
			public const int Content = 5;
		}
	}
}
