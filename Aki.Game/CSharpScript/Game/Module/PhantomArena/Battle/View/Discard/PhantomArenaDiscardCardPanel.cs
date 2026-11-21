using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Discard
{
	// Token: 0x02004237 RID: 16951
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaDiscardCardPanel : UiPanelBase
	{
		// Token: 0x0602ADEF RID: 175599 RVA: 0x00C102B8 File Offset: 0x00C0E4B8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnVisibleToggleClick)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnConfirmBtnClick)),
				new ValueTuple<int, Delegate>(6, new Action(this.OnEmptyBtnClick))
			};
		}

		// Token: 0x0602ADF0 RID: 175600 RVA: 0x00C103D3 File Offset: 0x00C0E5D3
		protected override void OnStart()
		{
			this.Scroll = new GenericScrollViewNew<PhantomArenaDiscardCardItem, PhantomCardData>(base.GetScrollViewWithScrollbar(1), new Func<PhantomArenaDiscardCardItem>(this.InitItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x0602ADF1 RID: 175601 RVA: 0x00C10406 File Offset: 0x00C0E606
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaChooseCardPanelShow);
		}

		// Token: 0x0602ADF2 RID: 175602 RVA: 0x00C10418 File Offset: 0x00C0E618
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			PhantomArenaDiscardCardPanel.<OnBeforeShowAsyncImplement>d__9 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PhantomArenaDiscardCardPanel.<OnBeforeShowAsyncImplement>d__9>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602ADF3 RID: 175603 RVA: 0x00C1045C File Offset: 0x00C0E65C
		protected override void OnAfterHide()
		{
			base.GetItem(3).SetUIActive(true);
			this.ViewProxy.HideCardTips();
			this.ViewProxy.SetCaptionItemActive(true);
			this.ViewProxy.UnRegisterCantDragReason(EPhantomArenaCantDragReason.DiscardCardInteract);
			this.ViewProxy.SetIsMainInVisible(true);
			this.ViewProxy.SetInPanelInteractType(EPhantomArenaBattlePanelInteractType.MainView);
		}

		// Token: 0x0602ADF4 RID: 175604 RVA: 0x00C104B1 File Offset: 0x00C0E6B1
		private PhantomArenaDiscardCardItem InitItem()
		{
			return new PhantomArenaDiscardCardItem
			{
				ClickCallback = new Action<PhantomCardData, bool>(this.CardClick)
			};
		}

		// Token: 0x0602ADF5 RID: 175605 RVA: 0x00C104CC File Offset: 0x00C0E6CC
		private void OnVisibleToggleClick(EToggleState state)
		{
			bool flag = state != EToggleState.ETT_Checked;
			this.ViewProxy.SetIsMainInVisible(!flag);
			this.ViewProxy.HideCardTips();
			base.GetItem(3).SetUIActive(flag);
		}

		// Token: 0x0602ADF6 RID: 175606 RVA: 0x00C10508 File Offset: 0x00C0E708
		private void OnConfirmBtnClick()
		{
			this.Data.ConfirmFunc(new List<int>(this.SelectedIdSet)).Finally(delegate()
			{
				if (this.Data.GuideType != null)
				{
					this.ViewProxy.GuideManager.TryFinishGuideByType(this.Data.GuideType.Value, Array.Empty<object>());
				}
			}).Forget();
		}

		// Token: 0x0602ADF7 RID: 175607 RVA: 0x00C1053B File Offset: 0x00C0E73B
		private void OnEmptyBtnClick()
		{
			this.ViewProxy.HideCardTips();
		}

		// Token: 0x0602ADF8 RID: 175608 RVA: 0x00C10548 File Offset: 0x00C0E748
		private void CardClick(PhantomCardData data, bool isSelected)
		{
			int cardId = data.CardId;
			this.HandleSelectState(cardId);
			if (isSelected && this.Data.GuideType != null && !this.ViewProxy.GuideManager.CheckCanExecuteAndShowFailTips(this.Data.GuideType.Value, new object[]
			{
				data.ConfigId
			}))
			{
				return;
			}
			if (isSelected && this.SelectedIdSet.Count >= this.Data.LimitCount)
			{
				if (this.Data.LimitCount > 1)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId(this.Data.SelectedTips, Array.Empty<object>());
					return;
				}
				this.CancelChooseLastState();
			}
			this.HandleChooseState(cardId, isSelected);
			this.RefreshTitle();
			this.RefreshConfirmInteractive();
		}

		// Token: 0x0602ADF9 RID: 175609 RVA: 0x00C10614 File Offset: 0x00C0E814
		private void HandleChooseState(int selectId, bool isSelected)
		{
			PhantomArenaDiscardCardItem scrollItemByKey = this.Scroll.GetScrollItemByKey(selectId);
			if (scrollItemByKey != null)
			{
				scrollItemByKey.SetChooseState(isSelected);
			}
			if (isSelected)
			{
				this.SelectedIdSet.Add(selectId);
				return;
			}
			this.SelectedIdSet.Remove(selectId);
		}

		// Token: 0x0602ADFA RID: 175610 RVA: 0x00C1065C File Offset: 0x00C0E85C
		private void CancelChooseLastState()
		{
			if (this.SelectedIdSet.Count <= 0)
			{
				return;
			}
			int num = 0;
			using (HashSet<int>.Enumerator enumerator = this.SelectedIdSet.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					num = enumerator.Current;
				}
			}
			if (num != 0)
			{
				this.HandleChooseState(num, false);
				this.ResetToggleState(num);
			}
		}

		// Token: 0x0602ADFB RID: 175611 RVA: 0x00C106D0 File Offset: 0x00C0E8D0
		private void ResetToggleState(int selectId)
		{
			PhantomArenaDiscardCardItem scrollItemByKey = this.Scroll.GetScrollItemByKey(selectId);
			if (scrollItemByKey == null)
			{
				return;
			}
			scrollItemByKey.Card.SetToggleState(EToggleState.ETT_UnChecked, false);
		}

		// Token: 0x0602ADFC RID: 175612 RVA: 0x00C106F4 File Offset: 0x00C0E8F4
		private void HandleSelectState(int selectId)
		{
			if (this.CurrentSelectId == selectId)
			{
				return;
			}
			if (this.CurrentSelectId != -1)
			{
				PhantomArenaDiscardCardItem scrollItemByKey = this.Scroll.GetScrollItemByKey(this.CurrentSelectId);
				if (scrollItemByKey != null)
				{
					scrollItemByKey.SetSelectState(false);
				}
			}
			PhantomArenaDiscardCardItem scrollItemByKey2 = this.Scroll.GetScrollItemByKey(selectId);
			if (scrollItemByKey2 != null)
			{
				scrollItemByKey2.SetSelectState(true);
				this.ViewProxy.ShowCardTips(scrollItemByKey2.Card.Data, false);
			}
			this.CurrentSelectId = selectId;
		}

		// Token: 0x0602ADFD RID: 175613 RVA: 0x00C10770 File Offset: 0x00C0E970
		private void RefreshTitle()
		{
			base.GetText(0).SetText(this.SelectedIdSet.Count.ToString() + "/" + this.Data.LimitCount.ToString(), true);
		}

		// Token: 0x0602ADFE RID: 175614 RVA: 0x00C107BA File Offset: 0x00C0E9BA
		private void RefreshTitleTips()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), this.Data.TitleTips, Array.Empty<object>());
		}

		// Token: 0x0602ADFF RID: 175615 RVA: 0x00C107DD File Offset: 0x00C0E9DD
		private void RefreshConfirmInteractive()
		{
			base.GetButton(5).SetSelfInteractive(this.SelectedIdSet.Count >= this.Data.LimitCount);
		}

		// Token: 0x0602AE00 RID: 175616 RVA: 0x00C10806 File Offset: 0x00C0EA06
		public void RegisterViewProxy(PhantomArenaBattleProxy proxy)
		{
			this.ViewProxy = proxy;
		}

		// Token: 0x0602AE01 RID: 175617 RVA: 0x00C1080F File Offset: 0x00C0EA0F
		public void SetDiscardCardData(IDiscardCardPanelData data)
		{
			this.Data = data;
		}

		// Token: 0x0602AE02 RID: 175618 RVA: 0x00C10818 File Offset: 0x00C0EA18
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (configParams[0] == "BattleCardDiscardById")
			{
				int num = int.Parse(configParams[1]);
				foreach (PhantomArenaDiscardCardItem phantomArenaDiscardCardItem in this.Scroll.GetScrollItemList())
				{
					if (phantomArenaDiscardCardItem.Card.Data.ConfigId == num)
					{
						UUIItem rootItem = phantomArenaDiscardCardItem.Card.GetRootItem();
						if (rootItem != null)
						{
							return new UUIItem[]
							{
								rootItem,
								rootItem
							};
						}
					}
				}
			}
			return null;
		}

		// Token: 0x04017340 RID: 95040
		protected PhantomArenaBattleProxy ViewProxy;

		// Token: 0x04017341 RID: 95041
		protected GenericScrollViewNew<PhantomArenaDiscardCardItem, PhantomCardData> Scroll;

		// Token: 0x04017342 RID: 95042
		protected HashSet<int> SelectedIdSet = new HashSet<int>();

		// Token: 0x04017343 RID: 95043
		protected IDiscardCardPanelData Data;

		// Token: 0x04017344 RID: 95044
		protected int CurrentSelectId = -1;

		// Token: 0x02009E87 RID: 40583
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403146D RID: 201837
			public const int Title = 0;

			// Token: 0x0403146E RID: 201838
			public const int Scroll = 1;

			// Token: 0x0403146F RID: 201839
			public const int ScrollItem = 2;

			// Token: 0x04031470 RID: 201840
			public const int ContentItem = 3;

			// Token: 0x04031471 RID: 201841
			public const int VisibleToggle = 4;

			// Token: 0x04031472 RID: 201842
			public const int ConfirmBtn = 5;

			// Token: 0x04031473 RID: 201843
			public const int EmptyBtn = 6;

			// Token: 0x04031474 RID: 201844
			public const int TitleTips = 7;
		}
	}
}
