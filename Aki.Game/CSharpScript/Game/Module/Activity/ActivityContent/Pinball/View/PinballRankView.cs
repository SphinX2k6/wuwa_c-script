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
	// Token: 0x02005257 RID: 21079
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballRankView : UiViewBase
	{
		// Token: 0x0603478D RID: 214925 RVA: 0x00EAEFF3 File Offset: 0x00EAD1F3
		[NullableContext(1)]
		public PinballRankView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603478E RID: 214926 RVA: 0x00EAEFFC File Offset: 0x00EAD1FC
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

		// Token: 0x0603478F RID: 214927 RVA: 0x00EAF0C8 File Offset: 0x00EAD2C8
		protected override UniTask OnBeforeStartAsync()
		{
			PinballRankView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballRankView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034790 RID: 214928 RVA: 0x00EAF10B File Offset: 0x00EAD30B
		[NullableContext(1)]
		private PinballRankItem CreateItem()
		{
			return new PinballRankItem();
		}

		// Token: 0x06034791 RID: 214929 RVA: 0x00EAF112 File Offset: 0x00EAD312
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06034792 RID: 214930 RVA: 0x00EAF11B File Offset: 0x00EAD31B
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(557);
		}

		// Token: 0x0401BD6C RID: 114028
		private PinballActivityData PinballActivityData;

		// Token: 0x0401BD6D RID: 114029
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BD6E RID: 114030
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<PinballRankItem, PinballRankData> RankScrollView;

		// Token: 0x0401BD6F RID: 114031
		private PinballRankItem MyRankItem;

		// Token: 0x0200AEAB RID: 44715
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04035F62 RID: 221026
			ItemCaption,
			// Token: 0x04035F63 RID: 221027
			LoopViewRank,
			// Token: 0x04035F64 RID: 221028
			ItemRank,
			// Token: 0x04035F65 RID: 221029
			ItemMyRank,
			// Token: 0x04035F66 RID: 221030
			Content
		}
	}
}
