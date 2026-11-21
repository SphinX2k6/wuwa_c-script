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
	// Token: 0x02003ECC RID: 16076
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleShopView : UiViewBase
	{
		// Token: 0x06028C52 RID: 166994 RVA: 0x00B7063B File Offset: 0x00B6E83B
		public RogueBattleShopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028C53 RID: 166995 RVA: 0x00B70644 File Offset: 0x00B6E844
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

		// Token: 0x06028C54 RID: 166996 RVA: 0x00B7075D File Offset: 0x00B6E95D
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RogueBattleSelectOption, new Action(this.OnBuyItem));
		}

		// Token: 0x06028C55 RID: 166997 RVA: 0x00B7077B File Offset: 0x00B6E97B
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RogueBattleSelectOption, new Action(this.OnBuyItem));
		}

		// Token: 0x06028C56 RID: 166998 RVA: 0x00B7079C File Offset: 0x00B6E99C
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleShopView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleShopView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028C57 RID: 166999 RVA: 0x00B707E0 File Offset: 0x00B6E9E0
		protected override void OnAfterShow()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Show", false, null, false);
		}

		// Token: 0x06028C58 RID: 167000 RVA: 0x00B70808 File Offset: 0x00B6EA08
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

		// Token: 0x06028C59 RID: 167001 RVA: 0x00B70828 File Offset: 0x00B6EA28
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

		// Token: 0x06028C5A RID: 167002 RVA: 0x00B70855 File Offset: 0x00B6EA55
		private void OnBtnInfo()
		{
		}

		// Token: 0x06028C5B RID: 167003 RVA: 0x00B70857 File Offset: 0x00B6EA57
		private RogueBattleShopGrid CreateGoodsItem()
		{
			return new RogueBattleShopGrid
			{
				SelectCallback = new Action<int, RogueResGainData>(this.OnSelectItem)
			};
		}

		// Token: 0x06028C5C RID: 167004 RVA: 0x00B70870 File Offset: 0x00B6EA70
		public UniTask RefreshItemList()
		{
			RogueBattleShopView.<RefreshItemList>d__14 <RefreshItemList>d__;
			<RefreshItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshItemList>d__.<>4__this = this;
			<RefreshItemList>d__.<>1__state = -1;
			<RefreshItemList>d__.<>t__builder.Start<RogueBattleShopView.<RefreshItemList>d__14>(ref <RefreshItemList>d__);
			return <RefreshItemList>d__.<>t__builder.Task;
		}

		// Token: 0x040162F6 RID: 90870
		[Nullable(2)]
		public LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040162F7 RID: 90871
		[Nullable(2)]
		public PopupCaptionItem CaptionItem;

		// Token: 0x040162F8 RID: 90872
		[Nullable(2)]
		public RogueBattleShopDetail DetailPanel;

		// Token: 0x040162F9 RID: 90873
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public LoopScrollView<RogueBattleShopGrid, RogueResGainData> GoodsLayout;
	}
}
