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
	// Token: 0x0200415A RID: 16730
	public class DeckBuilderCardDetailTip : UiPanelBase
	{
		// Token: 0x0602A535 RID: 173365 RVA: 0x00BF2B04 File Offset: 0x00BF0D04
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

		// Token: 0x0602A536 RID: 173366 RVA: 0x00BF2BDC File Offset: 0x00BF0DDC
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderCardDetailTip.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderCardDetailTip.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A537 RID: 173367 RVA: 0x00BF2C20 File Offset: 0x00BF0E20
		protected UniTask InitDetailsItem()
		{
			DeckBuilderCardDetailTip.<InitDetailsItem>d__7 <InitDetailsItem>d__;
			<InitDetailsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDetailsItem>d__.<>4__this = this;
			<InitDetailsItem>d__.<>1__state = -1;
			<InitDetailsItem>d__.<>t__builder.Start<DeckBuilderCardDetailTip.<InitDetailsItem>d__7>(ref <InitDetailsItem>d__);
			return <InitDetailsItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602A538 RID: 173368 RVA: 0x00BF2C64 File Offset: 0x00BF0E64
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

		// Token: 0x0602A539 RID: 173369 RVA: 0x00BF2CC8 File Offset: 0x00BF0EC8
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

		// Token: 0x0602A53A RID: 173370 RVA: 0x00BF2D1C File Offset: 0x00BF0F1C
		protected override void OnBeforeHide()
		{
			this.RemoveTimer();
		}

		// Token: 0x0602A53B RID: 173371 RVA: 0x00BF2D24 File Offset: 0x00BF0F24
		public void AddTimer()
		{
			this.RemoveTimer();
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.CheckMouseInTip();
			}, 100f, 1f, null, null, true);
		}

		// Token: 0x0602A53C RID: 173372 RVA: 0x00BF2D55 File Offset: 0x00BF0F55
		public void RemoveTimer()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0602A53D RID: 173373 RVA: 0x00BF2D78 File Offset: 0x00BF0F78
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

		// Token: 0x0602A53E RID: 173374 RVA: 0x00BF2DC3 File Offset: 0x00BF0FC3
		public void RefreshEntryShowState()
		{
			base.GetItem(1).SetUIActive(this.IsEntryShow);
		}

		// Token: 0x0602A53F RID: 173375 RVA: 0x00BF2DD7 File Offset: 0x00BF0FD7
		private void OnCardDescBtnClick()
		{
			this.IsEntryShow = !this.IsEntryShow;
			this.RefreshEntryShowState();
		}

		// Token: 0x0401702D RID: 94253
		[Nullable(1)]
		protected CardDetailItem DetailItem;

		// Token: 0x0401702E RID: 94254
		[Nullable(1)]
		protected CardDetailEntryDescLayoutItem EntryDescLayoutItem;

		// Token: 0x0401702F RID: 94255
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x04017030 RID: 94256
		protected bool IsEntryShow;

		// Token: 0x04017031 RID: 94257
		public bool IsMouseInSlotItem;

		// Token: 0x02009D36 RID: 40246
		private static class EComponents
		{
			// Token: 0x04030E45 RID: 200261
			public const int DescRootItem = 0;

			// Token: 0x04030E46 RID: 200262
			public const int EntryRootItem = 1;

			// Token: 0x04030E47 RID: 200263
			public const int CardDetailsItem = 2;

			// Token: 0x04030E48 RID: 200264
			public const int EntryDescLayout = 3;

			// Token: 0x04030E49 RID: 200265
			public const int EntryDescLayoutItem = 4;

			// Token: 0x04030E4A RID: 200266
			public const int CardDescBtn = 5;

			// Token: 0x04030E4B RID: 200267
			public const int BtnMask = 6;
		}
	}
}
