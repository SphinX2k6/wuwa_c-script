using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x020053AA RID: 21418
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorFightRankView : UiViewBase
	{
		// Token: 0x06035467 RID: 218215 RVA: 0x00EE1AF4 File Offset: 0x00EDFCF4
		[NullableContext(1)]
		public MotorFightRankView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06035468 RID: 218216 RVA: 0x00EE1B00 File Offset: 0x00EDFD00
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06035469 RID: 218217 RVA: 0x00EE1BAC File Offset: 0x00EDFDAC
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightRankView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightRankView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603546A RID: 218218 RVA: 0x00EE1BEF File Offset: 0x00EDFDEF
		[NullableContext(1)]
		private MotorFightRankItem CreateItem()
		{
			return new MotorFightRankItem();
		}

		// Token: 0x0603546B RID: 218219 RVA: 0x00EE1BF6 File Offset: 0x00EDFDF6
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401C182 RID: 115074
		private MotorFightActivityData MotorFightActivityData;

		// Token: 0x0401C183 RID: 115075
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C184 RID: 115076
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<MotorFightRankItem, MotorFightRankData> RankScrollView;

		// Token: 0x0401C185 RID: 115077
		private MotorFightRankItem MyRankItem;

		// Token: 0x0200B04E RID: 45134
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040367BE RID: 223166
			public const int ItemCaption = 0;

			// Token: 0x040367BF RID: 223167
			public const int LoopViewRank = 1;

			// Token: 0x040367C0 RID: 223168
			public const int ItemRank = 2;

			// Token: 0x040367C1 RID: 223169
			public const int ItemMyRank = 3;
		}
	}
}
