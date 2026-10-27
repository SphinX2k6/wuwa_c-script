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
	// Token: 0x020051B8 RID: 20920
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCollectCardTabView : UiTabViewBase
	{
		// Token: 0x06035906 RID: 219398 RVA: 0x00CB0340 File Offset: 0x00CAE540
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

		// Token: 0x06035907 RID: 219399 RVA: 0x00CB0408 File Offset: 0x00CAE608
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaCollectCardTabView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaCollectCardTabView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035908 RID: 219400 RVA: 0x00CB044C File Offset: 0x00CAE64C
		protected override void OnStart()
		{
			this.CardScrollView = new LoopScrollView<CollectGridCardItem, CollectGridCardData>(base.GetLoopScrollViewComponent(4), base.GetItem(5).GetOwner() as AUIBaseActor, new Func<CollectGridCardItem>(this.CreateCardItem), false);
			this.RewardLayout = new GenericLayout<CollectRewardItem, int>(base.GetHorizontalLayout(2), new Func<CollectRewardItem>(this.CreateRewardItem), null, false, true);
			this.ElementLayout = new GenericLayout<CardElementCountItem, CardElementCount>(base.GetHorizontalLayout(6), new Func<CardElementCountItem>(this.CreateElementItem), null, false, true);
			this.InturnAniComponent = (base.GetLoopScrollViewComponent(4).GetContent().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController);
		}

		// Token: 0x06035909 RID: 219401 RVA: 0x00CB04F1 File Offset: 0x00CAE6F1
		protected override void OnBeforeShow()
		{
			this.RefreshCard(true);
			this.RefreshElement();
			this.RefreshReward();
		}

		// Token: 0x0603590A RID: 219402 RVA: 0x00CB0508 File Offset: 0x00CAE708
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

		// Token: 0x0603590B RID: 219403 RVA: 0x00CB0548 File Offset: 0x00CAE748
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaCardRewardUpdate, new Action<int>(this.OnCardRewardUpdate));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnCardInfoUpdate));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnCardInfoUpdate));
		}

		// Token: 0x0603590C RID: 219404 RVA: 0x00CB05AC File Offset: 0x00CAE7AC
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardRewardUpdate, new Action<int>(this.OnCardRewardUpdate));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnCardInfoUpdate));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnCardInfoUpdate));
		}

		// Token: 0x0603590D RID: 219405 RVA: 0x00CB0610 File Offset: 0x00CAE810
		private void RefreshCard(bool keepContentPosition)
		{
			List<CollectGridCardData> collectCardDataList = PhantomArenaModel.Instance.GetCollectCardDataList(this.ActivityId, this.SelectedElementId, false);
			this.CardScrollView.RefreshByData(collectCardDataList, keepContentPosition, null, false);
		}

		// Token: 0x0603590E RID: 219406 RVA: 0x00CB0644 File Offset: 0x00CAE844
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

		// Token: 0x0603590F RID: 219407 RVA: 0x00CB0744 File Offset: 0x00CAE944
		private void RefreshReward()
		{
			List<int> cardRewardConfigList = PhantomArenaModel.Instance.GetCardRewardConfigList(this.ActivityId);
			this.RewardLayout.RefreshByData(cardRewardConfigList, null, false);
			int cardUnlockCount = PhantomArenaModel.Instance.GetCardUnlockCount(this.ActivityId);
			base.GetArtText(0).SetText(cardUnlockCount.ToString());
			float cardRewardProgress = PhantomArenaModel.Instance.GetCardRewardProgress(this.ActivityId);
			base.GetSprite(1).SetFillAmount(cardRewardProgress);
		}

		// Token: 0x06035910 RID: 219408 RVA: 0x00CB07B4 File Offset: 0x00CAE9B4
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

		// Token: 0x06035911 RID: 219409 RVA: 0x00CB0848 File Offset: 0x00CAEA48
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

		// Token: 0x06035912 RID: 219410 RVA: 0x00CB08B8 File Offset: 0x00CAEAB8
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

		// Token: 0x06035913 RID: 219411 RVA: 0x00CB0901 File Offset: 0x00CAEB01
		private void OnCardRewardUpdate(int activityId)
		{
			this.RefreshReward();
		}

		// Token: 0x06035914 RID: 219412 RVA: 0x00CB0909 File Offset: 0x00CAEB09
		private void OnCardInfoUpdate(int cardId)
		{
			this.RefreshCard(true);
			this.RefreshElement();
			this.RefreshReward();
		}

		// Token: 0x06035915 RID: 219413 RVA: 0x00CB091E File Offset: 0x00CAEB1E
		private void OnCloseDetailView(int cardId)
		{
		}

		// Token: 0x06035916 RID: 219414 RVA: 0x00CB0920 File Offset: 0x00CAEB20
		private CollectGridCardItem CreateCardItem()
		{
			return new CollectGridCardItem
			{
				CallbackOnClick = new Action<int>(this.OnClickCard)
			};
		}

		// Token: 0x06035917 RID: 219415 RVA: 0x00CB0939 File Offset: 0x00CAEB39
		private CollectRewardItem CreateRewardItem()
		{
			return new CollectRewardItem
			{
				RewardType = ECollectRewardType.Card,
				CallbackClickReward = new Action<int, UUIItem>(this.OnClickReward)
			};
		}

		// Token: 0x06035918 RID: 219416 RVA: 0x00CB0959 File Offset: 0x00CAEB59
		private CardElementCountItem CreateElementItem()
		{
			return new CardElementCountItem
			{
				SelectCallBack = new Action<int>(this.OnSelectElement)
			};
		}

		// Token: 0x06035919 RID: 219417 RVA: 0x00CB0972 File Offset: 0x00CAEB72
		private void OnSelectElement(int elementId)
		{
			this.SelectedElementId = elementId;
			this.RefreshCard(false);
		}

		// Token: 0x0603591A RID: 219418 RVA: 0x00CB0982 File Offset: 0x00CAEB82
		protected override void OnBeforeHide()
		{
			this.RewardPopup.SetActive(false);
		}

		// Token: 0x0401C6F4 RID: 116468
		protected int ActivityId;

		// Token: 0x0401C6F5 RID: 116469
		protected LoopScrollView<CollectGridCardItem, CollectGridCardData> CardScrollView;

		// Token: 0x0401C6F6 RID: 116470
		private GenericLayout<CollectRewardItem, int> RewardLayout;

		// Token: 0x0401C6F7 RID: 116471
		private GenericLayout<CardElementCountItem, CardElementCount> ElementLayout;

		// Token: 0x0401C6F8 RID: 116472
		private CollectRewardPopup RewardPopup;

		// Token: 0x0401C6F9 RID: 116473
		private UUIInturnAnimController InturnAniComponent;

		// Token: 0x0401C6FA RID: 116474
		private int SelectedElementId = -1;

		// Token: 0x0200B342 RID: 45890
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036547 RID: 222535
			public const int TextArtNum = 0;

			// Token: 0x04036548 RID: 222536
			public const int SpriteBar = 1;

			// Token: 0x04036549 RID: 222537
			public const int LayoutReward = 2;

			// Token: 0x0403654A RID: 222538
			public const int PanelReward = 3;

			// Token: 0x0403654B RID: 222539
			public const int LoopCard = 4;

			// Token: 0x0403654C RID: 222540
			public const int ItemCard = 5;

			// Token: 0x0403654D RID: 222541
			public const int LayoutElement = 6;

			// Token: 0x0403654E RID: 222542
			public const int TextPhysical = 7;
		}
	}
}
