using System;
using System.Collections.Generic;
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
	// Token: 0x02003C12 RID: 15378
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffShopView : UiViewBase
	{
		// Token: 0x06027667 RID: 161383 RVA: 0x00B0B524 File Offset: 0x00B09724
		public SheriffShopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06027668 RID: 161384 RVA: 0x00B0B544 File Offset: 0x00B09744
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

		// Token: 0x06027669 RID: 161385 RVA: 0x00B0B631 File Offset: 0x00B09831
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoodsList));
		}

		// Token: 0x0602766A RID: 161386 RVA: 0x00B0B64F File Offset: 0x00B0984F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoodsList));
		}

		// Token: 0x0602766B RID: 161387 RVA: 0x00B0B670 File Offset: 0x00B09870
		protected override UniTask OnBeforeStartAsync()
		{
			SheriffShopView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SheriffShopView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602766C RID: 161388 RVA: 0x00B0B6B3 File Offset: 0x00B098B3
		private SheriffShopItem InitItem()
		{
			return new SheriffShopItem();
		}

		// Token: 0x0602766D RID: 161389 RVA: 0x00B0B6BC File Offset: 0x00B098BC
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

		// Token: 0x0602766E RID: 161390 RVA: 0x00B0B730 File Offset: 0x00B09930
		private UniTask RefreshCaption()
		{
			SheriffShopView.<RefreshCaption>d__13 <RefreshCaption>d__;
			<RefreshCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCaption>d__.<>4__this = this;
			<RefreshCaption>d__.<>1__state = -1;
			<RefreshCaption>d__.<>t__builder.Start<SheriffShopView.<RefreshCaption>d__13>(ref <RefreshCaption>d__);
			return <RefreshCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0602766F RID: 161391 RVA: 0x00B0B774 File Offset: 0x00B09974
		private UniTask CreateScrollShopMenuAsync()
		{
			SheriffShopView.<CreateScrollShopMenuAsync>d__14 <CreateScrollShopMenuAsync>d__;
			<CreateScrollShopMenuAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateScrollShopMenuAsync>d__.<>4__this = this;
			<CreateScrollShopMenuAsync>d__.<>1__state = -1;
			<CreateScrollShopMenuAsync>d__.<>t__builder.Start<SheriffShopView.<CreateScrollShopMenuAsync>d__14>(ref <CreateScrollShopMenuAsync>d__);
			return <CreateScrollShopMenuAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027670 RID: 161392 RVA: 0x00B0B7B8 File Offset: 0x00B099B8
		private void RefreshShop()
		{
			List<PayShopGoods> shopDataList = SheriffModel.Instance.GetShopDataList(this.SelectedLevel);
			List<IPayShopUnionData> list = new List<IPayShopUnionData>(shopDataList.Count);
			for (int i = 0; i < shopDataList.Count; i++)
			{
				list.Add(shopDataList[i]);
			}
			this.ScrollShop.RefreshByData(list, false, null, false);
		}

		// Token: 0x06027671 RID: 161393 RVA: 0x00B0B810 File Offset: 0x00B09A10
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

		// Token: 0x06027672 RID: 161394 RVA: 0x00B0B884 File Offset: 0x00B09A84
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

		// Token: 0x06027673 RID: 161395 RVA: 0x00B0B8C4 File Offset: 0x00B09AC4
		private void OnRefreshGoodsList(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
		{
			this.RefreshShop();
			this.RefreshCurrencyTxt();
		}

		// Token: 0x040157CA RID: 88010
		private List<int> ShopTabList = new List<int>();

		// Token: 0x040157CB RID: 88011
		private int SelectedLevel;

		// Token: 0x040157CC RID: 88012
		private readonly PopupCaptionItem ItemCaption = new PopupCaptionItem(null);

		// Token: 0x040157CD RID: 88013
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SheriffShopMenuItem, int> TopShopMenu;

		// Token: 0x040157CE RID: 88014
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<SheriffShopItem, IPayShopUnionData> ScrollShop;

		// Token: 0x02009824 RID: 38948
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0402F756 RID: 194390
			public const int ItemCaption = 0;

			// Token: 0x0402F757 RID: 194391
			public const int TxtNum = 1;

			// Token: 0x0402F758 RID: 194392
			public const int ScrollShop = 2;

			// Token: 0x0402F759 RID: 194393
			public const int ShopItem = 3;

			// Token: 0x0402F75A RID: 194394
			public const int TopMenu = 4;

			// Token: 0x0402F75B RID: 194395
			public const int TabItem = 5;
		}
	}
}
