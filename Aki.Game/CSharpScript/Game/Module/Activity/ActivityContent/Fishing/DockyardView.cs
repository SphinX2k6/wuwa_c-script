using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005535 RID: 21813
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardView : UiTickViewBase, IDockyardViewInterface
	{
		// Token: 0x060361D0 RID: 221648 RVA: 0x00F1B307 File Offset: 0x00F19507
		public DockyardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060361D1 RID: 221649 RVA: 0x00F1B318 File Offset: 0x00F19518
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060361D2 RID: 221650 RVA: 0x00F1B426 File Offset: 0x00F19626
		private void InitViewModel()
		{
			this.Vm = (this.OpenParam as DockyardViewModel);
			this.Vm.RegisterView(this);
		}

		// Token: 0x060361D3 RID: 221651 RVA: 0x00F1B448 File Offset: 0x00F19648
		private UniTask InitFishingCurrencyItem()
		{
			DockyardView.<InitFishingCurrencyItem>d__15 <InitFishingCurrencyItem>d__;
			<InitFishingCurrencyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFishingCurrencyItem>d__.<>4__this = this;
			<InitFishingCurrencyItem>d__.<>1__state = -1;
			<InitFishingCurrencyItem>d__.<>t__builder.Start<DockyardView.<InitFishingCurrencyItem>d__15>(ref <InitFishingCurrencyItem>d__);
			return <InitFishingCurrencyItem>d__.<>t__builder.Task;
		}

		// Token: 0x060361D4 RID: 221652 RVA: 0x00F1B48C File Offset: 0x00F1968C
		private UniTask InitCaption()
		{
			DockyardView.<InitCaption>d__16 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<DockyardView.<InitCaption>d__16>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x060361D5 RID: 221653 RVA: 0x00F1B4D0 File Offset: 0x00F196D0
		private UniTask InitBackpackPanel()
		{
			DockyardView.<InitBackpackPanel>d__17 <InitBackpackPanel>d__;
			<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBackpackPanel>d__.<>4__this = this;
			<InitBackpackPanel>d__.<>1__state = -1;
			<InitBackpackPanel>d__.<>t__builder.Start<DockyardView.<InitBackpackPanel>d__17>(ref <InitBackpackPanel>d__);
			return <InitBackpackPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060361D6 RID: 221654 RVA: 0x00F1B514 File Offset: 0x00F19714
		private UniTask InitStatePanel()
		{
			DockyardView.<InitStatePanel>d__18 <InitStatePanel>d__;
			<InitStatePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitStatePanel>d__.<>4__this = this;
			<InitStatePanel>d__.<>1__state = -1;
			<InitStatePanel>d__.<>t__builder.Start<DockyardView.<InitStatePanel>d__18>(ref <InitStatePanel>d__);
			return <InitStatePanel>d__.<>t__builder.Task;
		}

		// Token: 0x060361D7 RID: 221655 RVA: 0x00F1B558 File Offset: 0x00F19758
		private UniTask InitTipsPanel()
		{
			DockyardView.<InitTipsPanel>d__19 <InitTipsPanel>d__;
			<InitTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsPanel>d__.<>4__this = this;
			<InitTipsPanel>d__.<>1__state = -1;
			<InitTipsPanel>d__.<>t__builder.Start<DockyardView.<InitTipsPanel>d__19>(ref <InitTipsPanel>d__);
			return <InitTipsPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060361D8 RID: 221656 RVA: 0x00F1B59C File Offset: 0x00F1979C
		private UniTask InitLoopScroll()
		{
			DockyardView.<InitLoopScroll>d__20 <InitLoopScroll>d__;
			<InitLoopScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoopScroll>d__.<>4__this = this;
			<InitLoopScroll>d__.<>1__state = -1;
			<InitLoopScroll>d__.<>t__builder.Start<DockyardView.<InitLoopScroll>d__20>(ref <InitLoopScroll>d__);
			return <InitLoopScroll>d__.<>t__builder.Task;
		}

		// Token: 0x060361D9 RID: 221657 RVA: 0x00F1B5E0 File Offset: 0x00F197E0
		private UniTask InitQuestPanel()
		{
			DockyardView.<InitQuestPanel>d__21 <InitQuestPanel>d__;
			<InitQuestPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitQuestPanel>d__.<>4__this = this;
			<InitQuestPanel>d__.<>1__state = -1;
			<InitQuestPanel>d__.<>t__builder.Start<DockyardView.<InitQuestPanel>d__21>(ref <InitQuestPanel>d__);
			return <InitQuestPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060361DA RID: 221658 RVA: 0x00F1B624 File Offset: 0x00F19824
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardView.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardView.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060361DB RID: 221659 RVA: 0x00F1B668 File Offset: 0x00F19868
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			DockyardView.<OnBeforeShowAsyncImplementImplement>d__23 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<DockyardView.<OnBeforeShowAsyncImplementImplement>d__23>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060361DC RID: 221660 RVA: 0x00F1B6AB File Offset: 0x00F198AB
		protected override void OnBeforeShow()
		{
			this.QuestPanel.Refresh();
		}

		// Token: 0x060361DD RID: 221661 RVA: 0x00F1B6B8 File Offset: 0x00F198B8
		protected override void OnTick(float delta)
		{
			if (this.TipDirty)
			{
				if (this.LeftTipsType == DockyardView.ELeftTipsType.ItemTips)
				{
					DockyardItemBlockOriginalData itemBlockData = this.Vm.GetItemBlockData(this.CacheId);
					this.TipsPanel.Refresh(itemBlockData);
					this.TipsPanel.SetPanelVisible(true);
					this.QuestPanel.SetPanelVisible(false);
				}
				else if (this.LeftTipsType == DockyardView.ELeftTipsType.InfoTips)
				{
					this.TipsPanel.SetPanelVisible(false);
					this.QuestPanel.SetPanelVisible(true);
				}
				this.TipDirty = false;
				this.CacheId = 0;
			}
		}

		// Token: 0x060361DE RID: 221662 RVA: 0x00F1B73C File Offset: 0x00F1993C
		public void ShowTipsPanel(int id)
		{
			this.TipDirty = true;
			this.LeftTipsType = DockyardView.ELeftTipsType.ItemTips;
			this.CacheId = id;
		}

		// Token: 0x060361DF RID: 221663 RVA: 0x00F1B753 File Offset: 0x00F19953
		public void HideTipsPanel()
		{
			this.TipDirty = true;
			this.LeftTipsType = DockyardView.ELeftTipsType.InfoTips;
		}

		// Token: 0x060361E0 RID: 221664 RVA: 0x00F1B763 File Offset: 0x00F19963
		public void SetTrawlState(bool state)
		{
			this.StatePanel.SetActive(!state);
			this.ListPanel.SetActive(state);
		}

		// Token: 0x060361E1 RID: 221665 RVA: 0x00F1B780 File Offset: 0x00F19980
		public UUIItem GetQuicklySellPanelParentItem()
		{
			return base.GetItem(5);
		}

		// Token: 0x060361E2 RID: 221666 RVA: 0x00F1B78C File Offset: 0x00F1998C
		public void NotifyQuicklySellActive(bool isActive)
		{
			IDockyardLeftTipsInterface dockyardLeftTipsInterface2;
			if (this.LeftTipsType != DockyardView.ELeftTipsType.ItemTips)
			{
				IDockyardLeftTipsInterface dockyardLeftTipsInterface = this.QuestPanel;
				dockyardLeftTipsInterface2 = dockyardLeftTipsInterface;
			}
			else
			{
				IDockyardLeftTipsInterface dockyardLeftTipsInterface = this.TipsPanel;
				dockyardLeftTipsInterface2 = dockyardLeftTipsInterface;
			}
			IDockyardLeftTipsInterface dockyardLeftTipsInterface3 = dockyardLeftTipsInterface2;
			if (isActive)
			{
				dockyardLeftTipsInterface3.SetPanelVisible(false);
				this.QuestPanel.LockState = true;
				this.TipsPanel.LockState = true;
				return;
			}
			this.QuestPanel.LockState = false;
			this.TipsPanel.LockState = false;
			dockyardLeftTipsInterface3.SetPanelVisible(true);
		}

		// Token: 0x0401C918 RID: 117016
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C919 RID: 117017
		private DockyardBackpackPanel BackpackPanel;

		// Token: 0x0401C91A RID: 117018
		private DockyardStatePanel StatePanel;

		// Token: 0x0401C91B RID: 117019
		private DockyardTipsPanel TipsPanel;

		// Token: 0x0401C91C RID: 117020
		private DockyardItemListPanel ListPanel;

		// Token: 0x0401C91D RID: 117021
		[Nullable(2)]
		private DockyardQuestInfoPanel QuestPanel;

		// Token: 0x0401C91E RID: 117022
		private DockyardViewModel Vm;

		// Token: 0x0401C91F RID: 117023
		private DockyardView.ELeftTipsType LeftTipsType = DockyardView.ELeftTipsType.InfoTips;

		// Token: 0x0401C920 RID: 117024
		private bool TipDirty;

		// Token: 0x0401C921 RID: 117025
		private int CacheId;

		// Token: 0x0200B1AC RID: 45484
		[NullableContext(0)]
		private enum ELeftTipsType
		{
			// Token: 0x04036EDB RID: 224987
			ItemTips,
			// Token: 0x04036EDC RID: 224988
			InfoTips
		}

		// Token: 0x0200B1AD RID: 45485
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036EDD RID: 224989
			public const int CaptionItem = 0;

			// Token: 0x04036EDE RID: 224990
			public const int BackpackItem = 1;

			// Token: 0x04036EDF RID: 224991
			public const int TipsItem = 2;

			// Token: 0x04036EE0 RID: 224992
			public const int StateItem = 3;

			// Token: 0x04036EE1 RID: 224993
			public const int ListItem = 4;

			// Token: 0x04036EE2 RID: 224994
			public const int SellParentItem = 5;

			// Token: 0x04036EE3 RID: 224995
			public const int PanelRootItem = 6;
		}
	}
}
