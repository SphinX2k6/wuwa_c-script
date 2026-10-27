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
	// Token: 0x020065B7 RID: 26039
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardView : UiTickViewBase, IDockyardViewInterface
	{
		// Token: 0x0604150B RID: 267531 RVA: 0x00FD42CB File Offset: 0x00FD24CB
		public DockyardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0604150C RID: 267532 RVA: 0x00FD42DC File Offset: 0x00FD24DC
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

		// Token: 0x0604150D RID: 267533 RVA: 0x00FD43EA File Offset: 0x00FD25EA
		private void InitViewModel()
		{
			this.Vm = (this.OpenParam as DockyardViewModel);
			this.Vm.RegisterView(this);
		}

		// Token: 0x0604150E RID: 267534 RVA: 0x00FD440C File Offset: 0x00FD260C
		private UniTask InitFishingCurrencyItem()
		{
			DockyardView.<InitFishingCurrencyItem>d__15 <InitFishingCurrencyItem>d__;
			<InitFishingCurrencyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFishingCurrencyItem>d__.<>4__this = this;
			<InitFishingCurrencyItem>d__.<>1__state = -1;
			<InitFishingCurrencyItem>d__.<>t__builder.Start<DockyardView.<InitFishingCurrencyItem>d__15>(ref <InitFishingCurrencyItem>d__);
			return <InitFishingCurrencyItem>d__.<>t__builder.Task;
		}

		// Token: 0x0604150F RID: 267535 RVA: 0x00FD4450 File Offset: 0x00FD2650
		private UniTask InitCaption()
		{
			DockyardView.<InitCaption>d__16 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<DockyardView.<InitCaption>d__16>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x06041510 RID: 267536 RVA: 0x00FD4494 File Offset: 0x00FD2694
		private UniTask InitBackpackPanel()
		{
			DockyardView.<InitBackpackPanel>d__17 <InitBackpackPanel>d__;
			<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBackpackPanel>d__.<>4__this = this;
			<InitBackpackPanel>d__.<>1__state = -1;
			<InitBackpackPanel>d__.<>t__builder.Start<DockyardView.<InitBackpackPanel>d__17>(ref <InitBackpackPanel>d__);
			return <InitBackpackPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06041511 RID: 267537 RVA: 0x00FD44D8 File Offset: 0x00FD26D8
		private UniTask InitStatePanel()
		{
			DockyardView.<InitStatePanel>d__18 <InitStatePanel>d__;
			<InitStatePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitStatePanel>d__.<>4__this = this;
			<InitStatePanel>d__.<>1__state = -1;
			<InitStatePanel>d__.<>t__builder.Start<DockyardView.<InitStatePanel>d__18>(ref <InitStatePanel>d__);
			return <InitStatePanel>d__.<>t__builder.Task;
		}

		// Token: 0x06041512 RID: 267538 RVA: 0x00FD451C File Offset: 0x00FD271C
		private UniTask InitTipsPanel()
		{
			DockyardView.<InitTipsPanel>d__19 <InitTipsPanel>d__;
			<InitTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsPanel>d__.<>4__this = this;
			<InitTipsPanel>d__.<>1__state = -1;
			<InitTipsPanel>d__.<>t__builder.Start<DockyardView.<InitTipsPanel>d__19>(ref <InitTipsPanel>d__);
			return <InitTipsPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06041513 RID: 267539 RVA: 0x00FD4560 File Offset: 0x00FD2760
		private UniTask InitLoopScroll()
		{
			DockyardView.<InitLoopScroll>d__20 <InitLoopScroll>d__;
			<InitLoopScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoopScroll>d__.<>4__this = this;
			<InitLoopScroll>d__.<>1__state = -1;
			<InitLoopScroll>d__.<>t__builder.Start<DockyardView.<InitLoopScroll>d__20>(ref <InitLoopScroll>d__);
			return <InitLoopScroll>d__.<>t__builder.Task;
		}

		// Token: 0x06041514 RID: 267540 RVA: 0x00FD45A4 File Offset: 0x00FD27A4
		private UniTask InitQuestPanel()
		{
			DockyardView.<InitQuestPanel>d__21 <InitQuestPanel>d__;
			<InitQuestPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitQuestPanel>d__.<>4__this = this;
			<InitQuestPanel>d__.<>1__state = -1;
			<InitQuestPanel>d__.<>t__builder.Start<DockyardView.<InitQuestPanel>d__21>(ref <InitQuestPanel>d__);
			return <InitQuestPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06041515 RID: 267541 RVA: 0x00FD45E8 File Offset: 0x00FD27E8
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardView.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardView.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041516 RID: 267542 RVA: 0x00FD462C File Offset: 0x00FD282C
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			DockyardView.<OnBeforeShowAsyncImplementImplement>d__23 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<DockyardView.<OnBeforeShowAsyncImplementImplement>d__23>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06041517 RID: 267543 RVA: 0x00FD466F File Offset: 0x00FD286F
		protected override void OnBeforeShow()
		{
			this.QuestPanel.Refresh();
		}

		// Token: 0x06041518 RID: 267544 RVA: 0x00FD467C File Offset: 0x00FD287C
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

		// Token: 0x06041519 RID: 267545 RVA: 0x00FD4700 File Offset: 0x00FD2900
		public void ShowTipsPanel(int id)
		{
			this.TipDirty = true;
			this.LeftTipsType = DockyardView.ELeftTipsType.ItemTips;
			this.CacheId = id;
		}

		// Token: 0x0604151A RID: 267546 RVA: 0x00FD4717 File Offset: 0x00FD2917
		public void HideTipsPanel()
		{
			this.TipDirty = true;
			this.LeftTipsType = DockyardView.ELeftTipsType.InfoTips;
		}

		// Token: 0x0604151B RID: 267547 RVA: 0x00FD4727 File Offset: 0x00FD2927
		public void SetTrawlState(bool state)
		{
			this.StatePanel.SetActive(!state);
			this.ListPanel.SetActive(state);
		}

		// Token: 0x0604151C RID: 267548 RVA: 0x00FD4744 File Offset: 0x00FD2944
		public UUIItem GetQuicklySellPanelParentItem()
		{
			return base.GetItem(5);
		}

		// Token: 0x0604151D RID: 267549 RVA: 0x00FD4750 File Offset: 0x00FD2950
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

		// Token: 0x04021FE7 RID: 139239
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021FE8 RID: 139240
		private DockyardBackpackPanel BackpackPanel;

		// Token: 0x04021FE9 RID: 139241
		private DockyardStatePanel StatePanel;

		// Token: 0x04021FEA RID: 139242
		private DockyardTipsPanel TipsPanel;

		// Token: 0x04021FEB RID: 139243
		private DockyardItemListPanel ListPanel;

		// Token: 0x04021FEC RID: 139244
		[Nullable(2)]
		private DockyardQuestInfoPanel QuestPanel;

		// Token: 0x04021FED RID: 139245
		private DockyardViewModel Vm;

		// Token: 0x04021FEE RID: 139246
		private DockyardView.ELeftTipsType LeftTipsType = DockyardView.ELeftTipsType.InfoTips;

		// Token: 0x04021FEF RID: 139247
		private bool TipDirty;

		// Token: 0x04021FF0 RID: 139248
		private int CacheId;

		// Token: 0x0200C7C9 RID: 51145
		[NullableContext(0)]
		private enum ELeftTipsType
		{
			// Token: 0x0403C58D RID: 247181
			ItemTips,
			// Token: 0x0403C58E RID: 247182
			InfoTips
		}

		// Token: 0x0200C7CA RID: 51146
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C58F RID: 247183
			public const int CaptionItem = 0;

			// Token: 0x0403C590 RID: 247184
			public const int BackpackItem = 1;

			// Token: 0x0403C591 RID: 247185
			public const int TipsItem = 2;

			// Token: 0x0403C592 RID: 247186
			public const int StateItem = 3;

			// Token: 0x0403C593 RID: 247187
			public const int ListItem = 4;

			// Token: 0x0403C594 RID: 247188
			public const int SellParentItem = 5;

			// Token: 0x0403C595 RID: 247189
			public const int PanelRootItem = 6;
		}
	}
}
