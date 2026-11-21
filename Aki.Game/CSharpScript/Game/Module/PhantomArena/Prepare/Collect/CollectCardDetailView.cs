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
	// Token: 0x02004182 RID: 16770
	[NullableContext(1)]
	[Nullable(0)]
	public class CollectCardDetailView : UiViewBase
	{
		// Token: 0x0602A7BF RID: 174015 RVA: 0x00BFC6E9 File Offset: 0x00BFA8E9
		public CollectCardDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602A7C0 RID: 174016 RVA: 0x00BFC714 File Offset: 0x00BFA914
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

		// Token: 0x0602A7C1 RID: 174017 RVA: 0x00BFC7EC File Offset: 0x00BFA9EC
		protected override UniTask OnBeforeStartAsync()
		{
			CollectCardDetailView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CollectCardDetailView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A7C2 RID: 174018 RVA: 0x00BFC82F File Offset: 0x00BFAA2F
		private CollectCardDetailTabItem CreateTabItem()
		{
			return new CollectCardDetailTabItem
			{
				CallbackOnClick = new Action<ECollectCardDetailViewTab>(this.OnClickTab)
			};
		}

		// Token: 0x0602A7C3 RID: 174019 RVA: 0x00BFC848 File Offset: 0x00BFAA48
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

		// Token: 0x0602A7C4 RID: 174020 RVA: 0x00BFC8D6 File Offset: 0x00BFAAD6
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnUnlockCard));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnUnlockOutlook));
		}

		// Token: 0x0602A7C5 RID: 174021 RVA: 0x00BFC910 File Offset: 0x00BFAB10
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnUnlockCard));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnUnlockOutlook));
		}

		// Token: 0x0602A7C6 RID: 174022 RVA: 0x00BFC94C File Offset: 0x00BFAB4C
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

		// Token: 0x0602A7C7 RID: 174023 RVA: 0x00BFC993 File Offset: 0x00BFAB93
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

		// Token: 0x0602A7C8 RID: 174024 RVA: 0x00BFC9C0 File Offset: 0x00BFABC0
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

		// Token: 0x0602A7C9 RID: 174025 RVA: 0x00BFCA1B File Offset: 0x00BFAC1B
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

		// Token: 0x0602A7CA RID: 174026 RVA: 0x00BFCA5C File Offset: 0x00BFAC5C
		private void OnClickLeft()
		{
			int cardIndex = (this.CardIndex - 1 + this.DataList.Count) % this.DataList.Count;
			this.CardIndex = cardIndex;
			this.CardId = this.DataList[this.CardIndex].CardId;
			this.RefreshTabView();
			this.RefreshSwitchSequence();
		}

		// Token: 0x0602A7CB RID: 174027 RVA: 0x00BFCABC File Offset: 0x00BFACBC
		private void OnClickRight()
		{
			int cardIndex = (this.CardIndex + 1) % this.DataList.Count;
			this.CardIndex = cardIndex;
			this.CardId = this.DataList[this.CardIndex].CardId;
			this.RefreshTabView();
			this.RefreshSwitchSequence();
		}

		// Token: 0x0602A7CC RID: 174028 RVA: 0x00BFCB0D File Offset: 0x00BFAD0D
		private void OnClickClose()
		{
			base.CloseMe(new Action<bool>(this.OnCloseSuccess));
		}

		// Token: 0x0602A7CD RID: 174029 RVA: 0x00BFCB21 File Offset: 0x00BFAD21
		private void OnCloseSuccess(bool result)
		{
			if (this.CallbackOnClose != null)
			{
				this.CallbackOnClose(this.CardId);
			}
		}

		// Token: 0x0602A7CE RID: 174030 RVA: 0x00BFCB3C File Offset: 0x00BFAD3C
		private void OnUnlockCard(int cardId)
		{
			if (cardId == this.CardId)
			{
				this.RefreshTabView();
				this.RefreshSwitchSequence();
			}
		}

		// Token: 0x0602A7CF RID: 174031 RVA: 0x00BFCB53 File Offset: 0x00BFAD53
		private void OnUnlockOutlook(int cardId)
		{
			if (cardId == this.CardId)
			{
				this.RefreshTabView();
				this.RefreshSwitchSequence();
			}
		}

		// Token: 0x0401710D RID: 94477
		private int CardId = -1;

		// Token: 0x0401710E RID: 94478
		private int ActivityId;

		// Token: 0x0401710F RID: 94479
		private int CardIndex = -1;

		// Token: 0x04017110 RID: 94480
		private int TabIndex = -1;

		// Token: 0x04017111 RID: 94481
		private List<CollectGridCardData> DataList = new List<CollectGridCardData>();

		// Token: 0x04017112 RID: 94482
		private CollectCardDetailPanel DetailPanel;

		// Token: 0x04017113 RID: 94483
		private DeckBuilderCardOutlookUnlockPanel OutlookPanel;

		// Token: 0x04017114 RID: 94484
		private PopupCaptionItem CaptionItem;

		// Token: 0x04017115 RID: 94485
		private GenericLayout<CollectCardDetailTabItem, CollectCardDetailViewTabData> TabLayout;

		// Token: 0x04017116 RID: 94486
		private Action<int> CallbackOnClose;

		// Token: 0x02009D70 RID: 40304
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030F65 RID: 200549
			public const int TabLayout = 0;

			// Token: 0x04030F66 RID: 200550
			public const int CaptionItem = 1;

			// Token: 0x04030F67 RID: 200551
			public const int LeftArrowButton = 2;

			// Token: 0x04030F68 RID: 200552
			public const int RightArrowButton = 3;

			// Token: 0x04030F69 RID: 200553
			public const int ContentItem = 4;

			// Token: 0x04030F6A RID: 200554
			public const int ItemTabPanel = 5;
		}
	}
}
