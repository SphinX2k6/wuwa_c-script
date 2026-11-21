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
	// Token: 0x02005389 RID: 21385
	public class MotorFightRankDetailView : UiViewBase
	{
		// Token: 0x0603538E RID: 217998 RVA: 0x00EDC9EA File Offset: 0x00EDABEA
		[NullableContext(1)]
		public MotorFightRankDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603538F RID: 217999 RVA: 0x00EDC9F4 File Offset: 0x00EDABF4
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

		// Token: 0x06035390 RID: 218000 RVA: 0x00EDCB68 File Offset: 0x00EDAD68
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightRankDetailView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightRankDetailView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035391 RID: 218001 RVA: 0x00EDCBAB File Offset: 0x00EDADAB
		[NullableContext(1)]
		private MotorFightItemSmallGrid CreateItem()
		{
			return new MotorFightItemSmallGrid();
		}

		// Token: 0x06035392 RID: 218002 RVA: 0x00EDCBB2 File Offset: 0x00EDADB2
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401C12D RID: 114989
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C12E RID: 114990
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<MotorFightItemSmallGrid, MotorFightItemData> ItemLoopScrollView;

		// Token: 0x0200B015 RID: 45077
		private class EComponent
		{
			// Token: 0x040366A2 RID: 222882
			public const int ItemCaption = 0;

			// Token: 0x040366A3 RID: 222883
			public const int TextTitle = 1;

			// Token: 0x040366A4 RID: 222884
			public const int TextureRole = 2;

			// Token: 0x040366A5 RID: 222885
			public const int TextPlayerName = 3;

			// Token: 0x040366A6 RID: 222886
			public const int TextScore = 4;

			// Token: 0x040366A7 RID: 222887
			public const int TextWaveNum = 5;

			// Token: 0x040366A8 RID: 222888
			public const int TextKillNum = 6;

			// Token: 0x040366A9 RID: 222889
			public const int TextBuffGateNum = 7;

			// Token: 0x040366AA RID: 222890
			public const int LoopScrollViewItem = 8;

			// Token: 0x040366AB RID: 222891
			public const int ItemBase = 9;

			// Token: 0x040366AC RID: 222892
			public const int ItemEmptyPanel = 10;
		}
	}
}
