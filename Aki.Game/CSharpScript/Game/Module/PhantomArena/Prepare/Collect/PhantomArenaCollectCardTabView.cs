using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x02004188 RID: 16776
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCollectCardTabView : UiTabViewBase
	{
		// Token: 0x0602A801 RID: 174081 RVA: 0x00BFD97C File Offset: 0x00BFBB7C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIArtText)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(7, typeof(UUIText))
			};
		}

		// Token: 0x0602A802 RID: 174082 RVA: 0x00BFDA44 File Offset: 0x00BFBC44
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaCollectCardTabView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaCollectCardTabView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A803 RID: 174083 RVA: 0x00BFDA88 File Offset: 0x00BFBC88
		protected override void OnStart()
		{
			this.CardScrollView = new LoopScrollView<CollectGridCardItem, CollectGridCardData>(base.GetLoopScrollViewComponent(4), base.GetItem(5).GetOwner() as AUIBaseActor, new Func<CollectGridCardItem>(this.CreateCardItem), false);
			this.RewardLayout = new GenericLayout<CollectRewardItem, int>(base.GetHorizontalLayout(2), new Func<CollectRewardItem>(this.CreateRewardItem), null, false, true);
			this.ElementLayout = new GenericLayout<CardElementCountItem, CardElementCount>(base.GetHorizontalLayout(6), new Func<CardElementCountItem>(this.CreateElementItem), null, false, true);
			this.InturnAniComponent = (base.GetLoopScrollViewComponent(4).GetContent().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController);
		}

		// Token: 0x0602A804 RID: 174084 RVA: 0x00BFDB2D File Offset: 0x00BFBD2D
		protected override void OnBeforeShow()
		{
			this.RefreshCard(true);
			this.RefreshElement();
			this.RefreshReward();
		}

		// Token: 0x0602A805 RID: 174085 RVA: 0x00BFDB44 File Offset: 0x00BFBD44
		protected override void OnAfterShow()
		{
			this.UiViewSequence.PlaySequence("Start", false, null);
			UUIInturnAnimController inturnAniComponent = this.InturnAniComponent;
			if (inturnAniComponent == null)
			{
				return;
			}
			inturnAniComponent.Play("", -1, false);
		}

		// Token: 0x0602A806 RID: 174086 RVA: 0x00BFDB84 File Offset: 0x00BFBD84
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaCardRewardUpdate, new Action<int>(this.OnCardRewardUpdate));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnCardInfoUpdate));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnCardInfoUpdate));
		}

		// Token: 0x0602A807 RID: 174087 RVA: 0x00BFDBE8 File Offset: 0x00BFBDE8
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardRewardUpdate, new Action<int>(this.OnCardRewardUpdate));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnCardInfoUpdate));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnCardInfoUpdate));
		}

		// Token: 0x0602A808 RID: 174088 RVA: 0x00BFDC4C File Offset: 0x00BFBE4C
		private void RefreshCard(bool keepContentPosition)
		{
			List<CollectGridCardData> collectCardDataList = PhantomArenaModel.Instance.GetCollectCardDataList(this.ActivityId, this.SelectedElementId, false);
			this.CardScrollView.RefreshByData(collectCardDataList, keepContentPosition, null, false);
		}

		// Token: 0x0602A809 RID: 174089 RVA: 0x00BFDC80 File Offset: 0x00BFBE80
		private void RefreshElement()
		{
			List<CardElementCount> collectCardElementDataList = PhantomArenaModel.Instance.GetCollectCardElementDataList(this.ActivityId);
			this.ElementLayout.RefreshByData(collectCardElementDataList, delegate
			{
				GenericLayout<CardElementCountItem, CardElementCount> elementLayout = this.ElementLayout;
				if (elementLayout == null)
				{
					return;
				}
				elementLayout.SelectGridProxyByKey(this.SelectedElementId, false);
			}, false);
			if (!PhantomArenaModel.Instance.IsNewPhantomArenaActivity(this.ActivityId))
			{
				UUIText text = base.GetText(7);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				string multiTextByKey = TextConfig.Instance.GetMultiTextByKey("PhantomBattle_1123", "");
				Dictionary<int, int[]> collectCardElementCount = PhantomArenaModel.Instance.GetCollectCardElementCount(this.ActivityId);
				int[] array = collectCardElementCount.ContainsKey(0) ? collectCardElementCount[0] : null;
				int num = (array != null && array.Length != 0) ? array[0] : 0;
				int num2 = (array != null && array.Length > 1) ? array[1] : 0;
				base.GetText(7).SetText(StringUtils.Format("{0} {1}/{2}", new string[]
				{
					multiTextByKey,
					num.ToString(),
					num2.ToString()
				}), true);
				return;
			}
			UUIText text2 = base.GetText(7);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(false);
		}

		// Token: 0x0602A80A RID: 174090 RVA: 0x00BFDD80 File Offset: 0x00BFBF80
		private void RefreshReward()
		{
			List<int> cardRewardConfigList = PhantomArenaModel.Instance.GetCardRewardConfigList(this.ActivityId);
			this.RewardLayout.RefreshByData(cardRewardConfigList, null, false);
			int cardUnlockCount = PhantomArenaModel.Instance.GetCardUnlockCount(this.ActivityId);
			base.GetArtText(0).SetText(cardUnlockCount.ToString());
			float cardRewardProgress = PhantomArenaModel.Instance.GetCardRewardProgress(this.ActivityId);
			base.GetSprite(1).SetFillAmount(cardRewardProgress);
		}

		// Token: 0x0602A80B RID: 174091 RVA: 0x00BFDDF0 File Offset: 0x00BFBFF0
		private void RequestReward()
		{
			List<int> cardRewardConfigList = PhantomArenaModel.Instance.GetCardRewardConfigList(this.ActivityId);
			List<int> list = new List<int>();
			foreach (int num in cardRewardConfigList)
			{
				if (PhantomArenaModel.Instance.GetCardRewardStateById(num) == ECollectRewardState.Finish)
				{
					list.Add(num);
				}
			}
			if (list.Count <= 0)
			{
				return;
			}
			PhantomArenaController.Instance.CardRewardRequest(list.ToArray(), this.ActivityId);
		}

		// Token: 0x0602A80C RID: 174092 RVA: 0x00BFDE84 File Offset: 0x00BFC084
		private void OnClickReward(int rewardId, UUIItem root)
		{
			if (PhantomArenaModel.Instance.GetCardRewardStateById(rewardId) == ECollectRewardState.Finish)
			{
				this.RequestReward();
				return;
			}
			List<RewardTuple> cardRewardPopupTupleData = PhantomArenaModel.Instance.GetCardRewardPopupTupleData(rewardId);
			RewardPopupData data = new RewardPopupData
			{
				RewardLists = cardRewardPopupTupleData,
				MountItem = root,
				PosBias = new FVector?(new FVector(0f, 30f, 0f))
			};
			this.RewardPopup.Refresh(data);
		}

		// Token: 0x0602A80D RID: 174093 RVA: 0x00BFDEF4 File Offset: 0x00BFC0F4
		private void OnClickCard(int cardId)
		{
			CollectCardDetailViewOpenParam param = new CollectCardDetailViewOpenParam
			{
				CardId = cardId,
				ActivityId = this.ActivityId,
				CallbackOnClose = new Action<int>(this.OnCloseDetailView)
			};
			UiManager.Instance.OpenView(EUiViewName.CollectCardDetailView, param, null);
		}

		// Token: 0x0602A80E RID: 174094 RVA: 0x00BFDF3D File Offset: 0x00BFC13D
		private void OnCardRewardUpdate(int activityId)
		{
			this.RefreshReward();
		}

		// Token: 0x0602A80F RID: 174095 RVA: 0x00BFDF45 File Offset: 0x00BFC145
		private void OnCardInfoUpdate(int cardId)
		{
			this.RefreshCard(true);
			this.RefreshElement();
			this.RefreshReward();
		}

		// Token: 0x0602A810 RID: 174096 RVA: 0x00BFDF5A File Offset: 0x00BFC15A
		private void OnCloseDetailView(int cardId)
		{
		}

		// Token: 0x0602A811 RID: 174097 RVA: 0x00BFDF5C File Offset: 0x00BFC15C
		private CollectGridCardItem CreateCardItem()
		{
			return new CollectGridCardItem
			{
				CallbackOnClick = new Action<int>(this.OnClickCard)
			};
		}

		// Token: 0x0602A812 RID: 174098 RVA: 0x00BFDF75 File Offset: 0x00BFC175
		private CollectRewardItem CreateRewardItem()
		{
			return new CollectRewardItem
			{
				RewardType = ECollectRewardType.Card,
				CallbackClickReward = new Action<int, UUIItem>(this.OnClickReward)
			};
		}

		// Token: 0x0602A813 RID: 174099 RVA: 0x00BFDF95 File Offset: 0x00BFC195
		private CardElementCountItem CreateElementItem()
		{
			return new CardElementCountItem
			{
				SelectCallBack = new Action<int>(this.OnSelectElement)
			};
		}

		// Token: 0x0602A814 RID: 174100 RVA: 0x00BFDFAE File Offset: 0x00BFC1AE
		private void OnSelectElement(int elementId)
		{
			this.SelectedElementId = elementId;
			this.RefreshCard(false);
		}

		// Token: 0x0602A815 RID: 174101 RVA: 0x00BFDFBE File Offset: 0x00BFC1BE
		protected override void OnBeforeHide()
		{
			this.RewardPopup.SetActive(false);
		}

		// Token: 0x04017129 RID: 94505
		protected int ActivityId;

		// Token: 0x0401712A RID: 94506
		protected LoopScrollView<CollectGridCardItem, CollectGridCardData> CardScrollView;

		// Token: 0x0401712B RID: 94507
		private GenericLayout<CollectRewardItem, int> RewardLayout;

		// Token: 0x0401712C RID: 94508
		private GenericLayout<CardElementCountItem, CardElementCount> ElementLayout;

		// Token: 0x0401712D RID: 94509
		private CollectRewardPopup RewardPopup;

		// Token: 0x0401712E RID: 94510
		private UUIInturnAnimController InturnAniComponent;

		// Token: 0x0401712F RID: 94511
		private int SelectedElementId = -1;

		// Token: 0x02009D7A RID: 40314
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030F9A RID: 200602
			public const int TextArtNum = 0;

			// Token: 0x04030F9B RID: 200603
			public const int SpriteBar = 1;

			// Token: 0x04030F9C RID: 200604
			public const int LayoutReward = 2;

			// Token: 0x04030F9D RID: 200605
			public const int PanelReward = 3;

			// Token: 0x04030F9E RID: 200606
			public const int LoopCard = 4;

			// Token: 0x04030F9F RID: 200607
			public const int ItemCard = 5;

			// Token: 0x04030FA0 RID: 200608
			public const int LayoutElement = 6;

			// Token: 0x04030FA1 RID: 200609
			public const int TextPhysical = 7;
		}
	}
}
