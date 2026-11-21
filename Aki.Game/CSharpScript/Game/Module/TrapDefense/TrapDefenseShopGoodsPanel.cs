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
	// Token: 0x02003A78 RID: 14968
	public class TrapDefenseShopGoodsPanel : UiPanelBase
	{
		// Token: 0x0602674F RID: 157519 RVA: 0x00AC5784 File Offset: 0x00AC3984
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

		// Token: 0x06026750 RID: 157520 RVA: 0x00AC58D5 File Offset: 0x00AC3AD5
		protected override void OnStart()
		{
			this.ScrollView = new GenericScrollViewNew<TrapDefenseShopGoodsContainerItem, TrapDefenseShopGoodsListData>(base.GetScrollViewWithScrollbar(5), () => new TrapDefenseShopGoodsContainerItem(), null, false, null);
		}

		// Token: 0x06026751 RID: 157521 RVA: 0x00AC590C File Offset: 0x00AC3B0C
		public UniTask RefreshAsync()
		{
			TrapDefenseShopGoodsPanel.<RefreshAsync>d__4 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<TrapDefenseShopGoodsPanel.<RefreshAsync>d__4>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401515B RID: 86363
		[Nullable(1)]
		private GenericScrollViewNew<TrapDefenseShopGoodsContainerItem, TrapDefenseShopGoodsListData> ScrollView;

		// Token: 0x02009665 RID: 38501
		private class EComponentDefine
		{
			// Token: 0x0402EF35 RID: 192309
			public const int SpriteShopIcon = 0;

			// Token: 0x0402EF36 RID: 192310
			public const int TextShopTitle = 1;

			// Token: 0x0402EF37 RID: 192311
			public const int SpriteShopIconBg = 2;

			// Token: 0x0402EF38 RID: 192312
			public const int ItemPanel = 3;

			// Token: 0x0402EF39 RID: 192313
			public const int ItemPanelToggle = 4;

			// Token: 0x0402EF3A RID: 192314
			public const int ScrollView = 5;

			// Token: 0x0402EF3B RID: 192315
			public const int BtnConfirm = 6;

			// Token: 0x0402EF3C RID: 192316
			public const int ItemCaption = 7;

			// Token: 0x0402EF3D RID: 192317
			public const int TextLimit = 8;
		}
	}
}
