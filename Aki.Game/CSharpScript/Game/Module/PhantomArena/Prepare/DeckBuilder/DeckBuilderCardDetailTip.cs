using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Common.CardDetail;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200518A RID: 20874
	public class DeckBuilderCardDetailTip : UiPanelBase
	{
		// Token: 0x0603563A RID: 218682 RVA: 0x00CA5550 File Offset: 0x00CA3750
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action(this.OnCardDescBtnClick))
			};
		}

		// Token: 0x0603563B RID: 218683 RVA: 0x00CA5628 File Offset: 0x00CA3828
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderCardDetailTip.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderCardDetailTip.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603563C RID: 218684 RVA: 0x00CA566C File Offset: 0x00CA386C
		protected UniTask InitDetailsItem()
		{
			DeckBuilderCardDetailTip.<InitDetailsItem>d__7 <InitDetailsItem>d__;
			<InitDetailsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDetailsItem>d__.<>4__this = this;
			<InitDetailsItem>d__.<>1__state = -1;
			<InitDetailsItem>d__.<>t__builder.Start<DeckBuilderCardDetailTip.<InitDetailsItem>d__7>(ref <InitDetailsItem>d__);
			return <InitDetailsItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603563D RID: 218685 RVA: 0x00CA56B0 File Offset: 0x00CA38B0
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(6);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			this.EntryDescLayoutItem = new CardDetailEntryDescLayoutItem(base.GetLayoutBase(3), base.GetItem(4));
			base.GetItem(1).SetHierarchyIndex(0);
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetRaycastTarget(true);
		}

		// Token: 0x0603563E RID: 218686 RVA: 0x00CA5714 File Offset: 0x00CA3914
		private void CheckMouseInTip()
		{
			if (this.RootItem == null || this.IsMouseInSlotItem)
			{
				this.RemoveTimer();
				return;
			}
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, true);
			if (pointerEventData == null || !pointerEventData.enterComponentStack.Contains(this.RootItem))
			{
				base.SetUiActive(false);
				this.RemoveTimer();
			}
		}

		// Token: 0x0603563F RID: 218687 RVA: 0x00CA5768 File Offset: 0x00CA3968
		protected override void OnBeforeHide()
		{
			this.RemoveTimer();
		}

		// Token: 0x06035640 RID: 218688 RVA: 0x00CA5770 File Offset: 0x00CA3970
		public void AddTimer()
		{
			this.RemoveTimer();
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.CheckMouseInTip();
			}, 100f, 1f, null, null, true);
		}

		// Token: 0x06035641 RID: 218689 RVA: 0x00CA57A1 File Offset: 0x00CA39A1
		public void RemoveTimer()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x06035642 RID: 218690 RVA: 0x00CA57C4 File Offset: 0x00CA39C4
		[NullableContext(2)]
		public void RefreshCard(int cardId, DeckInfo deckInfo = null)
		{
			CardDetailItemData detailViewDetailItemData = PhantomArenaModel.Instance.GetDetailViewDetailItemData(cardId, deckInfo);
			this.DetailItem.Refresh(detailViewDetailItemData);
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId);
			this.EntryDescLayoutItem.RefreshByCardConfig(phantomBattleCardConfig);
			this.IsEntryShow = false;
			this.RefreshEntryShowState();
		}

		// Token: 0x06035643 RID: 218691 RVA: 0x00CA580F File Offset: 0x00CA3A0F
		public void RefreshEntryShowState()
		{
			base.GetItem(1).SetUIActive(this.IsEntryShow);
		}

		// Token: 0x06035644 RID: 218692 RVA: 0x00CA5823 File Offset: 0x00CA3A23
		private void OnCardDescBtnClick()
		{
			this.IsEntryShow = !this.IsEntryShow;
			this.RefreshEntryShowState();
		}

		// Token: 0x0401C5F8 RID: 116216
		[Nullable(1)]
		protected CardDetailItem DetailItem;

		// Token: 0x0401C5F9 RID: 116217
		[Nullable(1)]
		protected CardDetailEntryDescLayoutItem EntryDescLayoutItem;

		// Token: 0x0401C5FA RID: 116218
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0401C5FB RID: 116219
		protected bool IsEntryShow;

		// Token: 0x0401C5FC RID: 116220
		public bool IsMouseInSlotItem;

		// Token: 0x0200B2FD RID: 45821
		private static class EComponents
		{
			// Token: 0x040363F0 RID: 222192
			public const int DescRootItem = 0;

			// Token: 0x040363F1 RID: 222193
			public const int EntryRootItem = 1;

			// Token: 0x040363F2 RID: 222194
			public const int CardDetailsItem = 2;

			// Token: 0x040363F3 RID: 222195
			public const int EntryDescLayout = 3;

			// Token: 0x040363F4 RID: 222196
			public const int EntryDescLayoutItem = 4;

			// Token: 0x040363F5 RID: 222197
			public const int CardDescBtn = 5;

			// Token: 0x040363F6 RID: 222198
			public const int BtnMask = 6;
		}
	}
}
