using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AD0 RID: 19152
	public class TrapDefenseShopGoodsPanel : UiPanelBase
	{
		// Token: 0x060319BF RID: 203199 RVA: 0x00B817D0 File Offset: 0x00B7F9D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060319C0 RID: 203200 RVA: 0x00B81921 File Offset: 0x00B7FB21
		protected override void OnStart()
		{
			this.ScrollView = new GenericScrollViewNew<TrapDefenseShopGoodsContainerItem, TrapDefenseShopGoodsListData>(base.GetScrollViewWithScrollbar(5), () => new TrapDefenseShopGoodsContainerItem(), null, false, null);
		}

		// Token: 0x060319C1 RID: 203201 RVA: 0x00B81958 File Offset: 0x00B7FB58
		public UniTask RefreshAsync()
		{
			TrapDefenseShopGoodsPanel.<RefreshAsync>d__4 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<TrapDefenseShopGoodsPanel.<RefreshAsync>d__4>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401A809 RID: 108553
		[Nullable(1)]
		private GenericScrollViewNew<TrapDefenseShopGoodsContainerItem, TrapDefenseShopGoodsListData> ScrollView;

		// Token: 0x0200AC45 RID: 44101
		private class EComponentDefine
		{
			// Token: 0x04034584 RID: 214404
			public const int SpriteShopIcon = 0;

			// Token: 0x04034585 RID: 214405
			public const int TextShopTitle = 1;

			// Token: 0x04034586 RID: 214406
			public const int SpriteShopIconBg = 2;

			// Token: 0x04034587 RID: 214407
			public const int ItemPanel = 3;

			// Token: 0x04034588 RID: 214408
			public const int ItemPanelToggle = 4;

			// Token: 0x04034589 RID: 214409
			public const int ScrollView = 5;

			// Token: 0x0403458A RID: 214410
			public const int BtnConfirm = 6;

			// Token: 0x0403458B RID: 214411
			public const int ItemCaption = 7;

			// Token: 0x0403458C RID: 214412
			public const int TextLimit = 8;
		}
	}
}
