using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x020051B2 RID: 20914
	[NullableContext(1)]
	[Nullable(0)]
	public class CollectCardDetailView : UiViewBase
	{
		// Token: 0x060358C4 RID: 219332 RVA: 0x00CAF0AD File Offset: 0x00CAD2AD
		public CollectCardDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060358C5 RID: 219333 RVA: 0x00CAF0D8 File Offset: 0x00CAD2D8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnClickLeft)),
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickRight))
			};
		}

		// Token: 0x060358C6 RID: 219334 RVA: 0x00CAF1B0 File Offset: 0x00CAD3B0
		protected override UniTask OnBeforeStartAsync()
		{
			CollectCardDetailView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CollectCardDetailView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358C7 RID: 219335 RVA: 0x00CAF1F3 File Offset: 0x00CAD3F3
		private CollectCardDetailTabItem CreateTabItem()
		{
			return new CollectCardDetailTabItem
			{
				CallbackOnClick = new Action<ECollectCardDetailViewTab>(this.OnClickTab)
			};
		}

		// Token: 0x060358C8 RID: 219336 RVA: 0x00CAF20C File Offset: 0x00CAD40C
		protected override void OnStart()
		{
			if (this.DataList.Count <= 0)
			{
				Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.WDX, "获取卡牌图鉴数据错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (this.CardId < 0 || this.CardIndex < 0)
			{
				this.CardIndex = 0;
				this.CardId = this.DataList[0].CardId;
			}
			this.RefreshTabView();
			this.TabIndex = 0;
			this.TabLayout.SelectGridProxyByKey((ECollectCardDetailViewTab)this.TabIndex, true);
		}

		// Token: 0x060358C9 RID: 219337 RVA: 0x00CAF29A File Offset: 0x00CAD49A
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnUnlockCard));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnUnlockOutlook));
		}

		// Token: 0x060358CA RID: 219338 RVA: 0x00CAF2D4 File Offset: 0x00CAD4D4
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnUnlockCard));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnUnlockOutlook));
		}

		// Token: 0x060358CB RID: 219339 RVA: 0x00CAF310 File Offset: 0x00CAD510
		private void RefreshTabView()
		{
			CollectCardDetailPanel detailPanel = this.DetailPanel;
			if (detailPanel != null)
			{
				detailPanel.Refresh(this.CardId);
			}
			DeckBuilderCardOutlookUnlockPanelData data = new DeckBuilderCardOutlookUnlockPanelData
			{
				CardId = this.CardId
			};
			DeckBuilderCardOutlookUnlockPanel outlookPanel = this.OutlookPanel;
			if (outlookPanel == null)
			{
				return;
			}
			outlookPanel.Refresh(data);
		}

		// Token: 0x060358CC RID: 219340 RVA: 0x00CAF357 File Offset: 0x00CAD557
		private void RefreshSwitchSequence()
		{
			if (this.TabIndex == 0)
			{
				CollectCardDetailPanel detailPanel = this.DetailPanel;
				if (detailPanel == null)
				{
					return;
				}
				detailPanel.PlaySwitchSequence();
				return;
			}
			else
			{
				DeckBuilderCardOutlookUnlockPanel outlookPanel = this.OutlookPanel;
				if (outlookPanel == null)
				{
					return;
				}
				outlookPanel.PlaySwitchSequence();
				return;
			}
		}

		// Token: 0x060358CD RID: 219341 RVA: 0x00CAF384 File Offset: 0x00CAD584
		private void SetTabViewState(ECollectCardDetailViewTab index, bool activeState)
		{
			if (index == ECollectCardDetailViewTab.Detail)
			{
				CollectCardDetailPanel detailPanel = this.DetailPanel;
				if (detailPanel != null)
				{
					detailPanel.SetActive(activeState);
				}
				if (activeState)
				{
					CollectCardDetailPanel detailPanel2 = this.DetailPanel;
					if (detailPanel2 == null)
					{
						return;
					}
					detailPanel2.PlayShowSequence();
					return;
				}
			}
			else
			{
				DeckBuilderCardOutlookUnlockPanel outlookPanel = this.OutlookPanel;
				if (outlookPanel != null)
				{
					outlookPanel.SetActive(activeState);
				}
				if (activeState)
				{
					DeckBuilderCardOutlookUnlockPanel outlookPanel2 = this.OutlookPanel;
					if (outlookPanel2 == null)
					{
						return;
					}
					outlookPanel2.PlayShowSequence();
				}
			}
		}

		// Token: 0x060358CE RID: 219342 RVA: 0x00CAF3DF File Offset: 0x00CAD5DF
		private void OnClickTab(ECollectCardDetailViewTab index)
		{
			if (this.TabIndex >= 0)
			{
				this.SetTabViewState((ECollectCardDetailViewTab)this.TabIndex, false);
			}
			this.TabIndex = (int)index;
			this.TabLayout.SelectGridProxy(this.TabIndex, false);
			this.SetTabViewState((ECollectCardDetailViewTab)this.TabIndex, true);
		}

		// Token: 0x060358CF RID: 219343 RVA: 0x00CAF420 File Offset: 0x00CAD620
		private void OnClickLeft()
		{
			int cardIndex = (this.CardIndex - 1 + this.DataList.Count) % this.DataList.Count;
			this.CardIndex = cardIndex;
			this.CardId = this.DataList[this.CardIndex].CardId;
			this.RefreshTabView();
			this.RefreshSwitchSequence();
		}

		// Token: 0x060358D0 RID: 219344 RVA: 0x00CAF480 File Offset: 0x00CAD680
		private void OnClickRight()
		{
			int cardIndex = (this.CardIndex + 1) % this.DataList.Count;
			this.CardIndex = cardIndex;
			this.CardId = this.DataList[this.CardIndex].CardId;
			this.RefreshTabView();
			this.RefreshSwitchSequence();
		}

		// Token: 0x060358D1 RID: 219345 RVA: 0x00CAF4D1 File Offset: 0x00CAD6D1
		private void OnClickClose()
		{
			base.CloseMe(new Action<bool>(this.OnCloseSuccess));
		}

		// Token: 0x060358D2 RID: 219346 RVA: 0x00CAF4E5 File Offset: 0x00CAD6E5
		private void OnCloseSuccess(bool result)
		{
			if (this.CallbackOnClose != null)
			{
				this.CallbackOnClose(this.CardId);
			}
		}

		// Token: 0x060358D3 RID: 219347 RVA: 0x00CAF500 File Offset: 0x00CAD700
		private void OnUnlockCard(int cardId)
		{
			if (cardId == this.CardId)
			{
				this.RefreshTabView();
				this.RefreshSwitchSequence();
			}
		}

		// Token: 0x060358D4 RID: 219348 RVA: 0x00CAF517 File Offset: 0x00CAD717
		private void OnUnlockOutlook(int cardId)
		{
			if (cardId == this.CardId)
			{
				this.RefreshTabView();
				this.RefreshSwitchSequence();
			}
		}

		// Token: 0x0401C6D8 RID: 116440
		private int CardId = -1;

		// Token: 0x0401C6D9 RID: 116441
		private int ActivityId;

		// Token: 0x0401C6DA RID: 116442
		private int CardIndex = -1;

		// Token: 0x0401C6DB RID: 116443
		private int TabIndex = -1;

		// Token: 0x0401C6DC RID: 116444
		private List<CollectGridCardData> DataList = new List<CollectGridCardData>();

		// Token: 0x0401C6DD RID: 116445
		private CollectCardDetailPanel DetailPanel;

		// Token: 0x0401C6DE RID: 116446
		private DeckBuilderCardOutlookUnlockPanel OutlookPanel;

		// Token: 0x0401C6DF RID: 116447
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C6E0 RID: 116448
		private GenericLayout<CollectCardDetailTabItem, CollectCardDetailViewTabData> TabLayout;

		// Token: 0x0401C6E1 RID: 116449
		private Action<int> CallbackOnClose;

		// Token: 0x0200B338 RID: 45880
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036512 RID: 222482
			public const int TabLayout = 0;

			// Token: 0x04036513 RID: 222483
			public const int CaptionItem = 1;

			// Token: 0x04036514 RID: 222484
			public const int LeftArrowButton = 2;

			// Token: 0x04036515 RID: 222485
			public const int RightArrowButton = 3;

			// Token: 0x04036516 RID: 222486
			public const int ContentItem = 4;

			// Token: 0x04036517 RID: 222487
			public const int ItemTabPanel = 5;
		}
	}
}
