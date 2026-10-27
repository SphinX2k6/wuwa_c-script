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
	// Token: 0x0200642C RID: 25644
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorFightRankView : UiViewBase
	{
		// Token: 0x060407A6 RID: 264102 RVA: 0x00F9AB54 File Offset: 0x00F98D54
		[NullableContext(1)]
		public MotorFightRankView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060407A7 RID: 264103 RVA: 0x00F9AB60 File Offset: 0x00F98D60
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

		// Token: 0x060407A8 RID: 264104 RVA: 0x00F9AC0C File Offset: 0x00F98E0C
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightRankView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightRankView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060407A9 RID: 264105 RVA: 0x00F9AC4F File Offset: 0x00F98E4F
		[NullableContext(1)]
		private MotorFightRankItem CreateItem()
		{
			return new MotorFightRankItem();
		}

		// Token: 0x060407AA RID: 264106 RVA: 0x00F9AC56 File Offset: 0x00F98E56
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04021853 RID: 137299
		private MotorFightActivityData MotorFightActivityData;

		// Token: 0x04021854 RID: 137300
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021855 RID: 137301
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<MotorFightRankItem, MotorFightRankData> RankScrollView;

		// Token: 0x04021856 RID: 137302
		private MotorFightRankItem MyRankItem;

		// Token: 0x0200C667 RID: 50791
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403BE61 RID: 245345
			public const int ItemCaption = 0;

			// Token: 0x0403BE62 RID: 245346
			public const int LoopViewRank = 1;

			// Token: 0x0403BE63 RID: 245347
			public const int ItemRank = 2;

			// Token: 0x0403BE64 RID: 245348
			public const int ItemMyRank = 3;
		}
	}
}
