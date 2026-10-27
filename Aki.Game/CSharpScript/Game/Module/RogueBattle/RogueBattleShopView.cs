using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004F03 RID: 20227
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleShopView : UiViewBase
	{
		// Token: 0x06033DE7 RID: 212455 RVA: 0x00C2709B File Offset: 0x00C2529B
		public RogueBattleShopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033DE8 RID: 212456 RVA: 0x00C270A4 File Offset: 0x00C252A4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(5, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUITexture)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(9, new Action(this.OnBtnInfo))
			};
		}

		// Token: 0x06033DE9 RID: 212457 RVA: 0x00C271BD File Offset: 0x00C253BD
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RogueBattleSelectOption, new Action(this.OnBuyItem));
		}

		// Token: 0x06033DEA RID: 212458 RVA: 0x00C271DB File Offset: 0x00C253DB
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RogueBattleSelectOption, new Action(this.OnBuyItem));
		}

		// Token: 0x06033DEB RID: 212459 RVA: 0x00C271FC File Offset: 0x00C253FC
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleShopView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleShopView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033DEC RID: 212460 RVA: 0x00C27240 File Offset: 0x00C25440
		protected override void OnAfterShow()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Show", false, null, false);
		}

		// Token: 0x06033DED RID: 212461 RVA: 0x00C27268 File Offset: 0x00C25468
		private void OnSelectItem(int gridIndex, RogueResGainData data)
		{
			this.DetailPanel.Refresh(data);
			LoopScrollView<RogueBattleShopGrid, RogueResGainData> goodsLayout = this.GoodsLayout;
			if (goodsLayout == null)
			{
				return;
			}
			goodsLayout.SelectGridProxy(gridIndex, false);
		}

		// Token: 0x06033DEE RID: 212462 RVA: 0x00C27288 File Offset: 0x00C25488
		private void OnBuyItem()
		{
			UiAsyncTask task = new UiAsyncTask("RefreshWeeklyRogueShop", delegate()
			{
				RogueBattleShopView.<<OnBuyItem>b__11_0>d <<OnBuyItem>b__11_0>d;
				<<OnBuyItem>b__11_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OnBuyItem>b__11_0>d.<>4__this = this;
				<<OnBuyItem>b__11_0>d.<>1__state = -1;
				<<OnBuyItem>b__11_0>d.<>t__builder.Start<RogueBattleShopView.<<OnBuyItem>b__11_0>d>(ref <<OnBuyItem>b__11_0>d);
				return <<OnBuyItem>b__11_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x06033DEF RID: 212463 RVA: 0x00C272B5 File Offset: 0x00C254B5
		private void OnBtnInfo()
		{
		}

		// Token: 0x06033DF0 RID: 212464 RVA: 0x00C272B7 File Offset: 0x00C254B7
		private RogueBattleShopGrid CreateGoodsItem()
		{
			return new RogueBattleShopGrid
			{
				SelectCallback = new Action<int, RogueResGainData>(this.OnSelectItem)
			};
		}

		// Token: 0x06033DF1 RID: 212465 RVA: 0x00C272D0 File Offset: 0x00C254D0
		public UniTask RefreshItemList()
		{
			RogueBattleShopView.<RefreshItemList>d__14 <RefreshItemList>d__;
			<RefreshItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshItemList>d__.<>4__this = this;
			<RefreshItemList>d__.<>1__state = -1;
			<RefreshItemList>d__.<>t__builder.Start<RogueBattleShopView.<RefreshItemList>d__14>(ref <RefreshItemList>d__);
			return <RefreshItemList>d__.<>t__builder.Task;
		}

		// Token: 0x0401B923 RID: 112931
		[Nullable(2)]
		public LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B924 RID: 112932
		[Nullable(2)]
		public PopupCaptionItem CaptionItem;

		// Token: 0x0401B925 RID: 112933
		[Nullable(2)]
		public RogueBattleShopDetail DetailPanel;

		// Token: 0x0401B926 RID: 112934
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public LoopScrollView<RogueBattleShopGrid, RogueResGainData> GoodsLayout;
	}
}
