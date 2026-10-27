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
	// Token: 0x02004ACE RID: 19150
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseShopGoodsDetailPanel : UiPanelBase
	{
		// Token: 0x060319B0 RID: 203184 RVA: 0x00B814AC File Offset: 0x00B7F6AC
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

		// Token: 0x060319B1 RID: 203185 RVA: 0x00B815DC File Offset: 0x00B7F7DC
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseShopGoodsDetailPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseShopGoodsDetailPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060319B2 RID: 203186 RVA: 0x00B8161F File Offset: 0x00B7F81F
		protected override void OnStart()
		{
			TrapDefenseModel.Instance.ViewModelShop.AddOnSelectGoodsDelegate(new Action<ITrapDefenseShopGoods>(this.OnSelectGoods));
		}

		// Token: 0x060319B3 RID: 203187 RVA: 0x00B8163C File Offset: 0x00B7F83C
		protected override void OnBeforeDestroy()
		{
			TrapDefenseModel.Instance.ViewModelShop.RemoveOnSelectGoodsDelegate(new Action<ITrapDefenseShopGoods>(this.OnSelectGoods));
		}

		// Token: 0x060319B4 RID: 203188 RVA: 0x00B81659 File Offset: 0x00B7F859
		public void RefreshPanel(ITrapDefenseShopGoods data)
		{
			if (data == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
		}

		// Token: 0x060319B5 RID: 203189 RVA: 0x00B8167B File Offset: 0x00B7F87B
		private void OnConfirmButtonClick(int _)
		{
		}

		// Token: 0x060319B6 RID: 203190 RVA: 0x00B8167D File Offset: 0x00B7F87D
		private void OnSelectGoods(ITrapDefenseShopGoods goods)
		{
			this.RefreshPanel(goods);
		}

		// Token: 0x0401A807 RID: 108551
		private ButtonItem Button;

		// Token: 0x0200AC43 RID: 44099
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04034578 RID: 214392
			public const int TextName = 0;

			// Token: 0x04034579 RID: 214393
			public const int TextHave = 1;

			// Token: 0x0403457A RID: 214394
			public const int ItemPurchase = 2;

			// Token: 0x0403457B RID: 214395
			public const int ItemConfirmBtn = 3;

			// Token: 0x0403457C RID: 214396
			public const int ItemDetail = 4;

			// Token: 0x0403457D RID: 214397
			public const int TextBtn = 5;

			// Token: 0x0403457E RID: 214398
			public const int ItemUnavailable = 6;

			// Token: 0x0403457F RID: 214399
			public const int TextUnavailable = 7;
		}
	}
}
