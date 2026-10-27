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
	// Token: 0x0200640B RID: 25611
	public class MotorFightRankDetailView : UiViewBase
	{
		// Token: 0x060406CD RID: 263885 RVA: 0x00F95A4A File Offset: 0x00F93C4A
		[NullableContext(1)]
		public MotorFightRankDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060406CE RID: 263886 RVA: 0x00F95A54 File Offset: 0x00F93C54
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060406CF RID: 263887 RVA: 0x00F95BC8 File Offset: 0x00F93DC8
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightRankDetailView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightRankDetailView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060406D0 RID: 263888 RVA: 0x00F95C0B File Offset: 0x00F93E0B
		[NullableContext(1)]
		private MotorFightItemSmallGrid CreateItem()
		{
			return new MotorFightItemSmallGrid();
		}

		// Token: 0x060406D1 RID: 263889 RVA: 0x00F95C12 File Offset: 0x00F93E12
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x040217FE RID: 137214
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040217FF RID: 137215
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<MotorFightItemSmallGrid, MotorFightItemData> ItemLoopScrollView;

		// Token: 0x0200C62E RID: 50734
		private class EComponent
		{
			// Token: 0x0403BD45 RID: 245061
			public const int ItemCaption = 0;

			// Token: 0x0403BD46 RID: 245062
			public const int TextTitle = 1;

			// Token: 0x0403BD47 RID: 245063
			public const int TextureRole = 2;

			// Token: 0x0403BD48 RID: 245064
			public const int TextPlayerName = 3;

			// Token: 0x0403BD49 RID: 245065
			public const int TextScore = 4;

			// Token: 0x0403BD4A RID: 245066
			public const int TextWaveNum = 5;

			// Token: 0x0403BD4B RID: 245067
			public const int TextKillNum = 6;

			// Token: 0x0403BD4C RID: 245068
			public const int TextBuffGateNum = 7;

			// Token: 0x0403BD4D RID: 245069
			public const int LoopScrollViewItem = 8;

			// Token: 0x0403BD4E RID: 245070
			public const int ItemBase = 9;

			// Token: 0x0403BD4F RID: 245071
			public const int ItemEmptyPanel = 10;
		}
	}
}
