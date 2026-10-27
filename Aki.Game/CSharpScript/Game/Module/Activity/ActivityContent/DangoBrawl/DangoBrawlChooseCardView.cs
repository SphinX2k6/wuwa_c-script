using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067FC RID: 26620
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlChooseCardView : UiViewBase
	{
		// Token: 0x1700972E RID: 38702
		// (get) Token: 0x06042651 RID: 271953 RVA: 0x0101F76A File Offset: 0x0101D96A
		[Nullable(2)]
		private DangoBrawlDataController DataController
		{
			[NullableContext(2)]
			get
			{
				return DangoBrawlModel.Instance.GetDataController();
			}
		}

		// Token: 0x06042652 RID: 271954 RVA: 0x0101F776 File Offset: 0x0101D976
		public DangoBrawlChooseCardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042653 RID: 271955 RVA: 0x0101F7B4 File Offset: 0x0101D9B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirm));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickHide));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickMask));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042654 RID: 271956 RVA: 0x0101F988 File Offset: 0x0101DB88
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlChooseCardView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlChooseCardView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042655 RID: 271957 RVA: 0x0101F9CB File Offset: 0x0101DBCB
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnDangoBrawlThreeChooseStateChanged, true);
			this.SetUiBlurEnabled(true);
		}

		// Token: 0x06042656 RID: 271958 RVA: 0x0101F9E5 File Offset: 0x0101DBE5
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnDangoBrawlThreeChooseStateChanged, false);
			this.SetUiBlurEnabled(false);
		}

		// Token: 0x06042657 RID: 271959 RVA: 0x0101FA00 File Offset: 0x0101DC00
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlThreeChooseRecover, new Action(this.OnDangoBrawlChooseUiRecover));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlChooseCardRefresh, new Action<int>(this.RefreshSingleCard));
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips != null)
			{
				itemTips.SetTipsVisible(false);
			}
			DangoBrawlDataController dataController = this.DataController;
			if (dataController != null)
			{
				dataController.SetViewIsInThreeChoose(false);
			}
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlThreeChooseClosed);
		}

		// Token: 0x06042658 RID: 271960 RVA: 0x0101FA7C File Offset: 0x0101DC7C
		private UniTask[] CreateCardItems()
		{
			UniTask[] array = new UniTask[this.CardItems.Length];
			for (int i = 0; i < this.CardItems.Length; i++)
			{
				DangoBrawlCardItem dangoBrawlCardItem = this.CreateCardItem();
				this.CardItems[i] = dangoBrawlCardItem;
				array[i] = dangoBrawlCardItem.CreateThenShowByActorAsync(base.GetItem((int)this.CardItemComponents[i]).GetOwner());
			}
			return array;
		}

		// Token: 0x06042659 RID: 271961 RVA: 0x0101FADB File Offset: 0x0101DCDB
		private DangoBrawlCardItem CreateCardItem()
		{
			DangoBrawlCardItem dangoBrawlCardItem = new DangoBrawlCardItem();
			dangoBrawlCardItem.ClickCardCallBack = new Action<int>(this.OnClickCard);
			dangoBrawlCardItem.ClickCardHyperlinkCallBack = new Action<int, UUIItem>(this.OnClickCardHyperlink);
			dangoBrawlCardItem.BindCanToggleExecuteChange(new Func<int, bool>(this.CanToggleExecuteChange));
			return dangoBrawlCardItem;
		}

		// Token: 0x0604265A RID: 271962 RVA: 0x0101FB18 File Offset: 0x0101DD18
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x0604265B RID: 271963 RVA: 0x0101FB1A File Offset: 0x0101DD1A
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x0604265C RID: 271964 RVA: 0x0101FB1C File Offset: 0x0101DD1C
		protected override void OnStart()
		{
			this.RefreshCardList();
		}

		// Token: 0x0604265D RID: 271965 RVA: 0x0101FB24 File Offset: 0x0101DD24
		private void InitUiBlur()
		{
			AUIBaseActor rootActor = this.RootActor;
			this.UiBlur = (((rootActor != null) ? rootActor.GetComponentByClass(TsUiBlur.StaticClass()) : null) as TsUiBlur);
		}

		// Token: 0x0604265E RID: 271966 RVA: 0x0101FB50 File Offset: 0x0101DD50
		private void RefreshCardList()
		{
			this.BuildCardItemDataList();
			for (int i = 0; i < this.CardItems.Length; i++)
			{
				this.RefreshCardAt(i);
			}
		}

		// Token: 0x0604265F RID: 271967 RVA: 0x0101FB7D File Offset: 0x0101DD7D
		private void RefreshSingleCard(int index)
		{
			if (index < 0 || index >= this.CardItems.Length)
			{
				return;
			}
			this.BuildCardItemDataList();
			this.RefreshCardAt(index);
		}

		// Token: 0x06042660 RID: 271968 RVA: 0x0101FB9C File Offset: 0x0101DD9C
		private void RefreshCardAt(int index)
		{
			DangoBrawlCardItem dangoBrawlCardItem = this.CardItems[index];
			if (dangoBrawlCardItem == null)
			{
				return;
			}
			if (index < this.CardDataList.Count)
			{
				UUIItem rootItem = dangoBrawlCardItem.GetRootItem();
				if (rootItem != null)
				{
					rootItem.SetUIActive(true);
				}
				dangoBrawlCardItem.Refresh(this.CardDataList[index], this.SelectedCardIndex == index, index);
				return;
			}
			UUIItem rootItem2 = dangoBrawlCardItem.GetRootItem();
			if (rootItem2 == null)
			{
				return;
			}
			rootItem2.SetUIActive(false);
		}

		// Token: 0x06042661 RID: 271969 RVA: 0x0101FC04 File Offset: 0x0101DE04
		private void BuildCardItemDataList()
		{
			this.CardDataList.Clear();
			ActivityDangoBrawlData myActivityData = ActivityDangoBrawlController.Instance.MyActivityData;
			List<CardInfo> list = (myActivityData != null) ? myActivityData.EventSelectServerData.CardInfos : null;
			if (list != null)
			{
				foreach (CardInfo cardInfo in list)
				{
					this.CardDataList.Add(new DangoBrawlCardItemData(cardInfo.CardId, cardInfo.RemainRefreshCount));
				}
			}
		}

		// Token: 0x06042662 RID: 271970 RVA: 0x0101FC94 File Offset: 0x0101DE94
		private void SetUiBlurEnabled(bool enabled)
		{
			TsUiBlur uiBlur = this.UiBlur;
			if (uiBlur == null)
			{
				return;
			}
			uiBlur.SetEnableUiBlur(enabled);
		}

		// Token: 0x06042663 RID: 271971 RVA: 0x0101FCA8 File Offset: 0x0101DEA8
		private void OnClickCard(int index)
		{
			if (this.SelectedCardIndex != index)
			{
				object obj = (this.SelectedCardIndex >= 0 && this.SelectedCardIndex < this.CardItems.Length) ? this.CardItems[this.SelectedCardIndex] : null;
				this.SelectedCardIndex = index;
				object obj2 = obj;
				if (obj2 == null)
				{
					return;
				}
				obj2.SetToggleState(false, false);
			}
		}

		// Token: 0x06042664 RID: 271972 RVA: 0x0101FCFA File Offset: 0x0101DEFA
		private void OnClickCardHyperlink(int itemId, UUIItem anchor)
		{
			this.ShowItemTipsAdaptive(itemId, anchor).Forget();
		}

		// Token: 0x06042665 RID: 271973 RVA: 0x0101FD0C File Offset: 0x0101DF0C
		private UniTask ShowItemTipsAdaptive(int itemId, UUIItem anchor)
		{
			DangoBrawlChooseCardView.<ShowItemTipsAdaptive>d__28 <ShowItemTipsAdaptive>d__;
			<ShowItemTipsAdaptive>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowItemTipsAdaptive>d__.<>4__this = this;
			<ShowItemTipsAdaptive>d__.itemId = itemId;
			<ShowItemTipsAdaptive>d__.anchor = anchor;
			<ShowItemTipsAdaptive>d__.<>1__state = -1;
			<ShowItemTipsAdaptive>d__.<>t__builder.Start<DangoBrawlChooseCardView.<ShowItemTipsAdaptive>d__28>(ref <ShowItemTipsAdaptive>d__);
			return <ShowItemTipsAdaptive>d__.<>t__builder.Task;
		}

		// Token: 0x06042666 RID: 271974 RVA: 0x0101FD5F File Offset: 0x0101DF5F
		private void OnItemTipsCombineInfoClick(DangoBrawlItemTipsData data)
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlCombineView, new DangoBrawlCombineViewOpenData
			{
				FocusConfigId = data.ItemId,
				AllowCombine = false,
				UseActData = false,
				ShowIntoSelf = true,
				ShowSelfIntoOther = true
			}, null);
		}

		// Token: 0x06042667 RID: 271975 RVA: 0x0101FD9E File Offset: 0x0101DF9E
		private bool CanToggleExecuteChange(int cardIndex)
		{
			return cardIndex != this.SelectedCardIndex;
		}

		// Token: 0x06042668 RID: 271976 RVA: 0x0101FDAC File Offset: 0x0101DFAC
		private void OnClickConfirm()
		{
			if (this.SelectedCardIndex < 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DangoBrawlTips001", Array.Empty<object>());
				return;
			}
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips != null)
			{
				itemTips.SetTipsVisible(false);
			}
			ActivityDangoBrawlController.Instance.RequestEventSelect(this.SelectedCardIndex).Forget<bool>();
			DangoBrawlCardItem dangoBrawlCardItem = (this.SelectedCardIndex >= 0 && this.SelectedCardIndex < this.CardItems.Length) ? this.CardItems[this.SelectedCardIndex] : null;
			if (dangoBrawlCardItem != null)
			{
				dangoBrawlCardItem.PlayChooseSeq();
			}
			base.CloseMe(null);
		}

		// Token: 0x06042669 RID: 271977 RVA: 0x0101FE39 File Offset: 0x0101E039
		private void OnClickHide()
		{
			base.Hide(null);
		}

		// Token: 0x0604266A RID: 271978 RVA: 0x0101FE42 File Offset: 0x0101E042
		private void OnClickMask()
		{
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips == null)
			{
				return;
			}
			itemTips.SetTipsVisible(false);
		}

		// Token: 0x0604266B RID: 271979 RVA: 0x0101FE55 File Offset: 0x0101E055
		private void OnDangoBrawlChooseUiRecover()
		{
			base.Show(null);
		}

		// Token: 0x040229BE RID: 141758
		private int SelectedCardIndex = -1;

		// Token: 0x040229BF RID: 141759
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly DangoBrawlCardItem[] CardItems = new DangoBrawlCardItem[3];

		// Token: 0x040229C0 RID: 141760
		private List<DangoBrawlCardItemData> CardDataList = new List<DangoBrawlCardItemData>();

		// Token: 0x040229C1 RID: 141761
		private readonly DangoBrawlChooseCardView.EComponent[] CardItemComponents = new DangoBrawlChooseCardView.EComponent[]
		{
			DangoBrawlChooseCardView.EComponent.CardItem1,
			DangoBrawlChooseCardView.EComponent.CardItem2,
			DangoBrawlChooseCardView.EComponent.CardItem3
		};

		// Token: 0x040229C2 RID: 141762
		[Nullable(2)]
		private TsUiBlur UiBlur;

		// Token: 0x040229C3 RID: 141763
		[Nullable(2)]
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x0200C96A RID: 51562
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403CD22 RID: 249122
			PnlSelf,
			// Token: 0x0403CD23 RID: 249123
			PnlHLayout,
			// Token: 0x0403CD24 RID: 249124
			CardItem1,
			// Token: 0x0403CD25 RID: 249125
			BtnConfirmB,
			// Token: 0x0403CD26 RID: 249126
			BtnHide,
			// Token: 0x0403CD27 RID: 249127
			ItemTips,
			// Token: 0x0403CD28 RID: 249128
			BtnMask,
			// Token: 0x0403CD29 RID: 249129
			CardItem2,
			// Token: 0x0403CD2A RID: 249130
			CardItem3
		}
	}
}
