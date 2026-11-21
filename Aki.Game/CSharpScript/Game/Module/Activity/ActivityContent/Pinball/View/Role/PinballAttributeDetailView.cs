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
	// Token: 0x0200527E RID: 21118
	public class PinballAttributeDetailView : UiViewBase
	{
		// Token: 0x06034927 RID: 215335 RVA: 0x00EB539A File Offset: 0x00EB359A
		[NullableContext(1)]
		public PinballAttributeDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06034928 RID: 215336 RVA: 0x00EB53A4 File Offset: 0x00EB35A4
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

		// Token: 0x06034929 RID: 215337 RVA: 0x00EB5430 File Offset: 0x00EB3630
		protected override UniTask OnBeforeStartAsync()
		{
			PinballAttributeDetailView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballAttributeDetailView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603492A RID: 215338 RVA: 0x00EB5473 File Offset: 0x00EB3673
		[NullableContext(1)]
		private PinballAttributeDetailItem CreateAttrItem()
		{
			return new PinballAttributeDetailItem();
		}

		// Token: 0x0603492B RID: 215339 RVA: 0x00EB547A File Offset: 0x00EB367A
		private void OnCloseButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401BDCD RID: 114125
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<IPinballAttributeDetailItemData> AttributeDataList;

		// Token: 0x0401BDCE RID: 114126
		[Nullable(2)]
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401BDCF RID: 114127
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<PinballAttributeDetailItem, IPinballAttributeDetailItemData> AttrScrollView;

		// Token: 0x0200AEDF RID: 44767
		private enum EComponent
		{
			// Token: 0x04036078 RID: 221304
			CaptionItem,
			// Token: 0x04036079 RID: 221305
			AttrScrollView,
			// Token: 0x0403607A RID: 221306
			AttrTemplateItem
		}
	}
}
