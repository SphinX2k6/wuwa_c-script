using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A76 RID: 14966
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseShopGoodsDetailPanel : UiPanelBase
	{
		// Token: 0x06026740 RID: 157504 RVA: 0x00AC5460 File Offset: 0x00AC3660
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026741 RID: 157505 RVA: 0x00AC5590 File Offset: 0x00AC3790
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseShopGoodsDetailPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseShopGoodsDetailPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026742 RID: 157506 RVA: 0x00AC55D3 File Offset: 0x00AC37D3
		protected override void OnStart()
		{
			TrapDefenseModel.Instance.ViewModelShop.AddOnSelectGoodsDelegate(new Action<ITrapDefenseShopGoods>(this.OnSelectGoods));
		}

		// Token: 0x06026743 RID: 157507 RVA: 0x00AC55F0 File Offset: 0x00AC37F0
		protected override void OnBeforeDestroy()
		{
			TrapDefenseModel.Instance.ViewModelShop.RemoveOnSelectGoodsDelegate(new Action<ITrapDefenseShopGoods>(this.OnSelectGoods));
		}

		// Token: 0x06026744 RID: 157508 RVA: 0x00AC560D File Offset: 0x00AC380D
		public void RefreshPanel(ITrapDefenseShopGoods data)
		{
			if (data == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
		}

		// Token: 0x06026745 RID: 157509 RVA: 0x00AC562F File Offset: 0x00AC382F
		private void OnConfirmButtonClick(int _)
		{
		}

		// Token: 0x06026746 RID: 157510 RVA: 0x00AC5631 File Offset: 0x00AC3831
		private void OnSelectGoods(ITrapDefenseShopGoods goods)
		{
			this.RefreshPanel(goods);
		}

		// Token: 0x04015159 RID: 86361
		private ButtonItem Button;

		// Token: 0x02009663 RID: 38499
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402EF29 RID: 192297
			public const int TextName = 0;

			// Token: 0x0402EF2A RID: 192298
			public const int TextHave = 1;

			// Token: 0x0402EF2B RID: 192299
			public const int ItemPurchase = 2;

			// Token: 0x0402EF2C RID: 192300
			public const int ItemConfirmBtn = 3;

			// Token: 0x0402EF2D RID: 192301
			public const int ItemDetail = 4;

			// Token: 0x0402EF2E RID: 192302
			public const int TextBtn = 5;

			// Token: 0x0402EF2F RID: 192303
			public const int ItemUnavailable = 6;

			// Token: 0x0402EF30 RID: 192304
			public const int TextUnavailable = 7;
		}
	}
}
