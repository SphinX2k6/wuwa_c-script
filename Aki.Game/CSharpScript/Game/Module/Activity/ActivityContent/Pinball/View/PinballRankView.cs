using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View
{
	// Token: 0x020062D9 RID: 25305
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballRankView : UiViewBase
	{
		// Token: 0x0603FACC RID: 260812 RVA: 0x00F68097 File Offset: 0x00F66297
		[NullableContext(1)]
		public PinballRankView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603FACD RID: 260813 RVA: 0x00F680A0 File Offset: 0x00F662A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FACE RID: 260814 RVA: 0x00F6816C File Offset: 0x00F6636C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballRankView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballRankView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FACF RID: 260815 RVA: 0x00F681AF File Offset: 0x00F663AF
		[NullableContext(1)]
		private PinballRankItem CreateItem()
		{
			return new PinballRankItem();
		}

		// Token: 0x0603FAD0 RID: 260816 RVA: 0x00F681B6 File Offset: 0x00F663B6
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603FAD1 RID: 260817 RVA: 0x00F681BF File Offset: 0x00F663BF
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(557);
		}

		// Token: 0x0402143D RID: 136253
		private PinballActivityData PinballActivityData;

		// Token: 0x0402143E RID: 136254
		private PopupCaptionItem CaptionItem;

		// Token: 0x0402143F RID: 136255
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<PinballRankItem, PinballRankData> RankScrollView;

		// Token: 0x04021440 RID: 136256
		private PinballRankItem MyRankItem;

		// Token: 0x0200C4C4 RID: 50372
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B600 RID: 243200
			ItemCaption,
			// Token: 0x0403B601 RID: 243201
			LoopViewRank,
			// Token: 0x0403B602 RID: 243202
			ItemRank,
			// Token: 0x0403B603 RID: 243203
			ItemMyRank,
			// Token: 0x0403B604 RID: 243204
			Content
		}
	}
}
