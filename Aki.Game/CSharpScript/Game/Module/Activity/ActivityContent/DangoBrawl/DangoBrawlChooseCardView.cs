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
	// Token: 0x0200574C RID: 22348
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlChooseCardView : UiViewBase
	{
		// Token: 0x17006A6F RID: 27247
		// (get) Token: 0x060371A6 RID: 225702 RVA: 0x00F60CAE File Offset: 0x00F5EEAE
		[Nullable(2)]
		private DangoBrawlDataController DataController
		{
			[NullableContext(2)]
			get
			{
				return DangoBrawlModel.Instance.GetDataController();
			}
		}

		// Token: 0x060371A7 RID: 225703 RVA: 0x00F60CBA File Offset: 0x00F5EEBA
		public DangoBrawlChooseCardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060371A8 RID: 225704 RVA: 0x00F60CF8 File Offset: 0x00F5EEF8
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

		// Token: 0x060371A9 RID: 225705 RVA: 0x00F60ECC File Offset: 0x00F5F0CC
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlChooseCardView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlChooseCardView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060371AA RID: 225706 RVA: 0x00F60F0F File Offset: 0x00F5F10F
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnDangoBrawlThreeChooseStateChanged, true);
			this.SetUiBlurEnabled(true);
		}

		// Token: 0x060371AB RID: 225707 RVA: 0x00F60F29 File Offset: 0x00F5F129
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnDangoBrawlThreeChooseStateChanged, false);
			this.SetUiBlurEnabled(false);
		}

		// Token: 0x060371AC RID: 225708 RVA: 0x00F60F44 File Offset: 0x00F5F144
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

		// Token: 0x060371AD RID: 225709 RVA: 0x00F60FC0 File Offset: 0x00F5F1C0
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

		// Token: 0x060371AE RID: 225710 RVA: 0x00F6101F File Offset: 0x00F5F21F
		private DangoBrawlCardItem CreateCardItem()
		{
			DangoBrawlCardItem dangoBrawlCardItem = new DangoBrawlCardItem();
			dangoBrawlCardItem.ClickCardCallBack = new Action<int>(this.OnClickCard);
			dangoBrawlCardItem.ClickCardHyperlinkCallBack = new Action<int, UUIItem>(this.OnClickCardHyperlink);
			dangoBrawlCardItem.BindCanToggleExecuteChange(new Func<int, bool>(this.CanToggleExecuteChange));
			return dangoBrawlCardItem;
		}

		// Token: 0x060371AF RID: 225711 RVA: 0x00F6105C File Offset: 0x00F5F25C
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x060371B0 RID: 225712 RVA: 0x00F6105E File Offset: 0x00F5F25E
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x060371B1 RID: 225713 RVA: 0x00F61060 File Offset: 0x00F5F260
		protected override void OnStart()
		{
			this.RefreshCardList();
		}

		// Token: 0x060371B2 RID: 225714 RVA: 0x00F61068 File Offset: 0x00F5F268
		private void InitUiBlur()
		{
			AUIBaseActor rootActor = this.RootActor;
			this.UiBlur = (((rootActor != null) ? rootActor.GetComponentByClass(TsUiBlur.StaticClass()) : null) as TsUiBlur);
		}

		// Token: 0x060371B3 RID: 225715 RVA: 0x00F61094 File Offset: 0x00F5F294
		private void RefreshCardList()
		{
			this.BuildCardItemDataList();
			for (int i = 0; i < this.CardItems.Length; i++)
			{
				this.RefreshCardAt(i);
			}
		}

		// Token: 0x060371B4 RID: 225716 RVA: 0x00F610C1 File Offset: 0x00F5F2C1
		private void RefreshSingleCard(int index)
		{
			if (index < 0 || index >= this.CardItems.Length)
			{
				return;
			}
			this.BuildCardItemDataList();
			this.RefreshCardAt(index);
		}

		// Token: 0x060371B5 RID: 225717 RVA: 0x00F610E0 File Offset: 0x00F5F2E0
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

		// Token: 0x060371B6 RID: 225718 RVA: 0x00F61148 File Offset: 0x00F5F348
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

		// Token: 0x060371B7 RID: 225719 RVA: 0x00F611D8 File Offset: 0x00F5F3D8
		private void SetUiBlurEnabled(bool enabled)
		{
			TsUiBlur uiBlur = this.UiBlur;
			if (uiBlur == null)
			{
				return;
			}
			uiBlur.SetEnableUiBlur(enabled);
		}

		// Token: 0x060371B8 RID: 225720 RVA: 0x00F611EC File Offset: 0x00F5F3EC
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

		// Token: 0x060371B9 RID: 225721 RVA: 0x00F6123E File Offset: 0x00F5F43E
		private void OnClickCardHyperlink(int itemId, UUIItem anchor)
		{
			this.ShowItemTipsAdaptive(itemId, anchor).Forget();
		}

		// Token: 0x060371BA RID: 225722 RVA: 0x00F61250 File Offset: 0x00F5F450
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

		// Token: 0x060371BB RID: 225723 RVA: 0x00F612A3 File Offset: 0x00F5F4A3
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

		// Token: 0x060371BC RID: 225724 RVA: 0x00F612E2 File Offset: 0x00F5F4E2
		private bool CanToggleExecuteChange(int cardIndex)
		{
			return cardIndex != this.SelectedCardIndex;
		}

		// Token: 0x060371BD RID: 225725 RVA: 0x00F612F0 File Offset: 0x00F5F4F0
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

		// Token: 0x060371BE RID: 225726 RVA: 0x00F6137D File Offset: 0x00F5F57D
		private void OnClickHide()
		{
			base.Hide(null);
		}

		// Token: 0x060371BF RID: 225727 RVA: 0x00F61386 File Offset: 0x00F5F586
		private void OnClickMask()
		{
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips == null)
			{
				return;
			}
			itemTips.SetTipsVisible(false);
		}

		// Token: 0x060371C0 RID: 225728 RVA: 0x00F61399 File Offset: 0x00F5F599
		private void OnDangoBrawlChooseUiRecover()
		{
			base.Show(null);
		}

		// Token: 0x0401D21B RID: 119323
		private int SelectedCardIndex = -1;

		// Token: 0x0401D21C RID: 119324
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly DangoBrawlCardItem[] CardItems = new DangoBrawlCardItem[3];

		// Token: 0x0401D21D RID: 119325
		private List<DangoBrawlCardItemData> CardDataList = new List<DangoBrawlCardItemData>();

		// Token: 0x0401D21E RID: 119326
		private readonly DangoBrawlChooseCardView.EComponent[] CardItemComponents = new DangoBrawlChooseCardView.EComponent[]
		{
			DangoBrawlChooseCardView.EComponent.CardItem1,
			DangoBrawlChooseCardView.EComponent.CardItem2,
			DangoBrawlChooseCardView.EComponent.CardItem3
		};

		// Token: 0x0401D21F RID: 119327
		[Nullable(2)]
		private TsUiBlur UiBlur;

		// Token: 0x0401D220 RID: 119328
		[Nullable(2)]
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x0200B337 RID: 45879
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403760F RID: 226831
			PnlSelf,
			// Token: 0x04037610 RID: 226832
			PnlHLayout,
			// Token: 0x04037611 RID: 226833
			CardItem1,
			// Token: 0x04037612 RID: 226834
			BtnConfirmB,
			// Token: 0x04037613 RID: 226835
			BtnHide,
			// Token: 0x04037614 RID: 226836
			ItemTips,
			// Token: 0x04037615 RID: 226837
			BtnMask,
			// Token: 0x04037616 RID: 226838
			CardItem2,
			// Token: 0x04037617 RID: 226839
			CardItem3
		}
	}
}
