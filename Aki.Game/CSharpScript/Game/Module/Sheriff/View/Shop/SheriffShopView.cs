using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Shop
{
	// Token: 0x02004C61 RID: 19553
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffShopView : UiViewBase
	{
		// Token: 0x060328B4 RID: 207028 RVA: 0x00BC68D8 File Offset: 0x00BC4AD8
		public SheriffShopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060328B5 RID: 207029 RVA: 0x00BC68F8 File Offset: 0x00BC4AF8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060328B6 RID: 207030 RVA: 0x00BC69E5 File Offset: 0x00BC4BE5
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoodsList));
		}

		// Token: 0x060328B7 RID: 207031 RVA: 0x00BC6A03 File Offset: 0x00BC4C03
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoodsList));
		}

		// Token: 0x060328B8 RID: 207032 RVA: 0x00BC6A24 File Offset: 0x00BC4C24
		protected override UniTask OnBeforeStartAsync()
		{
			SheriffShopView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SheriffShopView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060328B9 RID: 207033 RVA: 0x00BC6A67 File Offset: 0x00BC4C67
		private SheriffShopItem InitItem()
		{
			return new SheriffShopItem();
		}

		// Token: 0x060328BA RID: 207034 RVA: 0x00BC6A70 File Offset: 0x00BC4C70
		protected override void OnStart()
		{
			this.RefreshShop();
			this.RefreshCurrencyTxt();
			foreach (SheriffShopMenuItem sheriffShopMenuItem in this.TopShopMenu.GetLayoutItemList())
			{
				if (sheriffShopMenuItem.Level == this.SelectedLevel)
				{
					sheriffShopMenuItem.SetSelect();
				}
			}
		}

		// Token: 0x060328BB RID: 207035 RVA: 0x00BC6AE4 File Offset: 0x00BC4CE4
		private UniTask RefreshCaption()
		{
			SheriffShopView.<RefreshCaption>d__13 <RefreshCaption>d__;
			<RefreshCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCaption>d__.<>4__this = this;
			<RefreshCaption>d__.<>1__state = -1;
			<RefreshCaption>d__.<>t__builder.Start<SheriffShopView.<RefreshCaption>d__13>(ref <RefreshCaption>d__);
			return <RefreshCaption>d__.<>t__builder.Task;
		}

		// Token: 0x060328BC RID: 207036 RVA: 0x00BC6B28 File Offset: 0x00BC4D28
		private UniTask CreateScrollShopMenuAsync()
		{
			SheriffShopView.<CreateScrollShopMenuAsync>d__14 <CreateScrollShopMenuAsync>d__;
			<CreateScrollShopMenuAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateScrollShopMenuAsync>d__.<>4__this = this;
			<CreateScrollShopMenuAsync>d__.<>1__state = -1;
			<CreateScrollShopMenuAsync>d__.<>t__builder.Start<SheriffShopView.<CreateScrollShopMenuAsync>d__14>(ref <CreateScrollShopMenuAsync>d__);
			return <CreateScrollShopMenuAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060328BD RID: 207037 RVA: 0x00BC6B6C File Offset: 0x00BC4D6C
		private void RefreshShop()
		{
			List<PayShopGoods> shopDataList = SheriffModel.Instance.GetShopDataList(this.SelectedLevel);
			this.ScrollShop.RefreshByData(shopDataList.Cast<IPayShopUnionData>().ToList<IPayShopUnionData>(), false, null, false);
		}

		// Token: 0x060328BE RID: 207038 RVA: 0x00BC6BA4 File Offset: 0x00BC4DA4
		private void OnClickTopShopMenuItem(int id)
		{
			foreach (SheriffShopMenuItem sheriffShopMenuItem in this.TopShopMenu.GetLayoutItemList())
			{
				if (sheriffShopMenuItem.Level == this.SelectedLevel)
				{
					sheriffShopMenuItem.SetDeselect();
				}
			}
			this.SelectedLevel = id;
			this.RefreshShop();
		}

		// Token: 0x060328BF RID: 207039 RVA: 0x00BC6C18 File Offset: 0x00BC4E18
		private void RefreshCurrencyTxt()
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				UUIText uuitext = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(SheriffModel.Instance.GetShopItemCount());
				uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}

		// Token: 0x060328C0 RID: 207040 RVA: 0x00BC6C58 File Offset: 0x00BC4E58
		private void OnRefreshGoodsList(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
		{
			this.RefreshShop();
			this.RefreshCurrencyTxt();
		}

		// Token: 0x0401AE6D RID: 110189
		private List<int> ShopTabList = new List<int>();

		// Token: 0x0401AE6E RID: 110190
		private int SelectedLevel;

		// Token: 0x0401AE6F RID: 110191
		private readonly PopupCaptionItem ItemCaption = new PopupCaptionItem(null);

		// Token: 0x0401AE70 RID: 110192
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SheriffShopMenuItem, int> TopShopMenu;

		// Token: 0x0401AE71 RID: 110193
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<SheriffShopItem, IPayShopUnionData> ScrollShop;

		// Token: 0x0200AE06 RID: 44550
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04034DB1 RID: 216497
			public const int ItemCaption = 0;

			// Token: 0x04034DB2 RID: 216498
			public const int TxtNum = 1;

			// Token: 0x04034DB3 RID: 216499
			public const int ScrollShop = 2;

			// Token: 0x04034DB4 RID: 216500
			public const int ShopItem = 3;

			// Token: 0x04034DB5 RID: 216501
			public const int TopMenu = 4;

			// Token: 0x04034DB6 RID: 216502
			public const int TabItem = 5;
		}
	}
}
