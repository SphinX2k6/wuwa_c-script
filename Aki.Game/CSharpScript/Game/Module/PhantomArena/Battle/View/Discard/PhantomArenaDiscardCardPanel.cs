using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005267 RID: 21095
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaDiscardCardPanel : UiPanelBase
	{
		// Token: 0x06035EF4 RID: 220916 RVA: 0x00CC2C28 File Offset: 0x00CC0E28
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

		// Token: 0x06035EF5 RID: 220917 RVA: 0x00CC2D43 File Offset: 0x00CC0F43
		protected override void OnStart()
		{
			this.Scroll = new GenericScrollViewNew<PhantomArenaDiscardCardItem, PhantomCardData>(base.GetScrollViewWithScrollbar(1), new Func<PhantomArenaDiscardCardItem>(this.InitItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x06035EF6 RID: 220918 RVA: 0x00CC2D76 File Offset: 0x00CC0F76
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaChooseCardPanelShow);
		}

		// Token: 0x06035EF7 RID: 220919 RVA: 0x00CC2D88 File Offset: 0x00CC0F88
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			PhantomArenaDiscardCardPanel.<OnBeforeShowAsyncImplement>d__9 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PhantomArenaDiscardCardPanel.<OnBeforeShowAsyncImplement>d__9>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06035EF8 RID: 220920 RVA: 0x00CC2DCC File Offset: 0x00CC0FCC
		protected override void OnAfterHide()
		{
			base.GetItem(3).SetUIActive(true);
			this.ViewProxy.HideCardTips();
			this.ViewProxy.SetCaptionItemActive(true);
			this.ViewProxy.UnRegisterCantDragReason(EPhantomArenaCantDragReason.DiscardCardInteract);
			this.ViewProxy.SetIsMainInVisible(true);
			this.ViewProxy.SetInPanelInteractType(EPhantomArenaBattlePanelInteractType.MainView);
		}

		// Token: 0x06035EF9 RID: 220921 RVA: 0x00CC2E21 File Offset: 0x00CC1021
		private PhantomArenaDiscardCardItem InitItem()
		{
			return new PhantomArenaDiscardCardItem
			{
				ClickCallback = new Action<PhantomCardData, bool>(this.CardClick)
			};
		}

		// Token: 0x06035EFA RID: 220922 RVA: 0x00CC2E3C File Offset: 0x00CC103C
		private void OnVisibleToggleClick(EToggleState state)
		{
			bool flag = state != EToggleState.ETT_Checked;
			this.ViewProxy.SetIsMainInVisible(!flag);
			this.ViewProxy.HideCardTips();
			base.GetItem(3).SetUIActive(flag);
		}

		// Token: 0x06035EFB RID: 220923 RVA: 0x00CC2E78 File Offset: 0x00CC1078
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

		// Token: 0x06035EFC RID: 220924 RVA: 0x00CC2EAB File Offset: 0x00CC10AB
		private void OnEmptyBtnClick()
		{
			this.ViewProxy.HideCardTips();
		}

		// Token: 0x06035EFD RID: 220925 RVA: 0x00CC2EB8 File Offset: 0x00CC10B8
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

		// Token: 0x06035EFE RID: 220926 RVA: 0x00CC2F84 File Offset: 0x00CC1184
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

		// Token: 0x06035EFF RID: 220927 RVA: 0x00CC2FCC File Offset: 0x00CC11CC
		private void CancelChooseLastState()
		{
			if (this.SelectedIdSet.Count <= 0)
			{
				return;
			}
			int num = this.SelectedIdSet.First<int>();
			if (num != 0)
			{
				this.HandleChooseState(num, false);
				this.ResetToggleState(num);
			}
		}

		// Token: 0x06035F00 RID: 220928 RVA: 0x00CC3006 File Offset: 0x00CC1206
		private void ResetToggleState(int selectId)
		{
			PhantomArenaDiscardCardItem scrollItemByKey = this.Scroll.GetScrollItemByKey(selectId);
			if (scrollItemByKey == null)
			{
				return;
			}
			scrollItemByKey.Card.SetToggleState(EToggleState.ETT_UnChecked, false);
		}

		// Token: 0x06035F01 RID: 220929 RVA: 0x00CC302C File Offset: 0x00CC122C
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

		// Token: 0x06035F02 RID: 220930 RVA: 0x00CC30A8 File Offset: 0x00CC12A8
		private void RefreshTitle()
		{
			base.GetText(0).SetText(this.SelectedIdSet.Count.ToString() + "/" + this.Data.LimitCount.ToString(), true);
		}

		// Token: 0x06035F03 RID: 220931 RVA: 0x00CC30F2 File Offset: 0x00CC12F2
		private void RefreshTitleTips()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), this.Data.TitleTips, Array.Empty<object>());
		}

		// Token: 0x06035F04 RID: 220932 RVA: 0x00CC3115 File Offset: 0x00CC1315
		private void RefreshConfirmInteractive()
		{
			base.GetButton(5).SetSelfInteractive(this.SelectedIdSet.Count >= this.Data.LimitCount);
		}

		// Token: 0x06035F05 RID: 220933 RVA: 0x00CC313E File Offset: 0x00CC133E
		public void RegisterViewProxy(PhantomArenaBattleProxy proxy)
		{
			this.ViewProxy = proxy;
		}

		// Token: 0x06035F06 RID: 220934 RVA: 0x00CC3147 File Offset: 0x00CC1347
		public void SetDiscardCardData(IDiscardCardPanelData data)
		{
			this.Data = data;
		}

		// Token: 0x06035F07 RID: 220935 RVA: 0x00CC3150 File Offset: 0x00CC1350
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

		// Token: 0x0401C90B RID: 117003
		protected PhantomArenaBattleProxy ViewProxy;

		// Token: 0x0401C90C RID: 117004
		protected GenericScrollViewNew<PhantomArenaDiscardCardItem, PhantomCardData> Scroll;

		// Token: 0x0401C90D RID: 117005
		protected HashSet<int> SelectedIdSet = new HashSet<int>();

		// Token: 0x0401C90E RID: 117006
		protected IDiscardCardPanelData Data;

		// Token: 0x0401C90F RID: 117007
		protected int CurrentSelectId = -1;

		// Token: 0x0200B44F RID: 46159
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036A1A RID: 223770
			public const int Title = 0;

			// Token: 0x04036A1B RID: 223771
			public const int Scroll = 1;

			// Token: 0x04036A1C RID: 223772
			public const int ScrollItem = 2;

			// Token: 0x04036A1D RID: 223773
			public const int ContentItem = 3;

			// Token: 0x04036A1E RID: 223774
			public const int VisibleToggle = 4;

			// Token: 0x04036A1F RID: 223775
			public const int ConfirmBtn = 5;

			// Token: 0x04036A20 RID: 223776
			public const int EmptyBtn = 6;

			// Token: 0x04036A21 RID: 223777
			public const int TitleTips = 7;
		}
	}
}
