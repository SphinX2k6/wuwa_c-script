using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006300 RID: 25344
	public class PinballAttributeDetailView : UiViewBase
	{
		// Token: 0x0603FC66 RID: 261222 RVA: 0x00F6E43E File Offset: 0x00F6C63E
		[NullableContext(1)]
		public PinballAttributeDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603FC67 RID: 261223 RVA: 0x00F6E448 File Offset: 0x00F6C648
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FC68 RID: 261224 RVA: 0x00F6E4D4 File Offset: 0x00F6C6D4
		protected override UniTask OnBeforeStartAsync()
		{
			PinballAttributeDetailView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballAttributeDetailView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FC69 RID: 261225 RVA: 0x00F6E517 File Offset: 0x00F6C717
		[NullableContext(1)]
		private PinballAttributeDetailItem CreateAttrItem()
		{
			return new PinballAttributeDetailItem();
		}

		// Token: 0x0603FC6A RID: 261226 RVA: 0x00F6E51E File Offset: 0x00F6C71E
		private void OnCloseButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0402149E RID: 136350
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<IPinballAttributeDetailItemData> AttributeDataList;

		// Token: 0x0402149F RID: 136351
		[Nullable(2)]
		protected PopupCaptionItem CaptionItem;

		// Token: 0x040214A0 RID: 136352
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<PinballAttributeDetailItem, IPinballAttributeDetailItemData> AttrScrollView;

		// Token: 0x0200C4F8 RID: 50424
		private enum EComponent
		{
			// Token: 0x0403B716 RID: 243478
			CaptionItem,
			// Token: 0x0403B717 RID: 243479
			AttrScrollView,
			// Token: 0x0403B718 RID: 243480
			AttrTemplateItem
		}
	}
}
