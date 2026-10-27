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
	// Token: 0x020065BB RID: 26043
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardSellTabView : UiTabViewBase, IDockyardViewInterface
	{
		// Token: 0x06041538 RID: 267576 RVA: 0x00FD4C30 File Offset: 0x00FD2E30
		protected unsafe override void OnRegisterComponent()
		{
			this.InitViewModel();
			int num = 4;
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06041539 RID: 267577 RVA: 0x00FD4CE1 File Offset: 0x00FD2EE1
		private void InitViewModel()
		{
			this.Vm = (this.ExtraParams as DockyardShopTabViewModel);
			this.Vm.RegisterView(this);
		}

		// Token: 0x0604153A RID: 267578 RVA: 0x00FD4D00 File Offset: 0x00FD2F00
		private UniTask InitBackpackPanel()
		{
			DockyardSellTabView.<InitBackpackPanel>d__7 <InitBackpackPanel>d__;
			<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBackpackPanel>d__.<>4__this = this;
			<InitBackpackPanel>d__.<>1__state = -1;
			<InitBackpackPanel>d__.<>t__builder.Start<DockyardSellTabView.<InitBackpackPanel>d__7>(ref <InitBackpackPanel>d__);
			return <InitBackpackPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0604153B RID: 267579 RVA: 0x00FD4D44 File Offset: 0x00FD2F44
		private UniTask InitLoopScroll()
		{
			DockyardSellTabView.<InitLoopScroll>d__8 <InitLoopScroll>d__;
			<InitLoopScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoopScroll>d__.<>4__this = this;
			<InitLoopScroll>d__.<>1__state = -1;
			<InitLoopScroll>d__.<>t__builder.Start<DockyardSellTabView.<InitLoopScroll>d__8>(ref <InitLoopScroll>d__);
			return <InitLoopScroll>d__.<>t__builder.Task;
		}

		// Token: 0x0604153C RID: 267580 RVA: 0x00FD4D88 File Offset: 0x00FD2F88
		private UniTask InitTipsPanel()
		{
			DockyardSellTabView.<InitTipsPanel>d__9 <InitTipsPanel>d__;
			<InitTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsPanel>d__.<>4__this = this;
			<InitTipsPanel>d__.<>1__state = -1;
			<InitTipsPanel>d__.<>t__builder.Start<DockyardSellTabView.<InitTipsPanel>d__9>(ref <InitTipsPanel>d__);
			return <InitTipsPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0604153D RID: 267581 RVA: 0x00FD4DCC File Offset: 0x00FD2FCC
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardSellTabView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardSellTabView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604153E RID: 267582 RVA: 0x00FD4E10 File Offset: 0x00FD3010
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			DockyardSellTabView.<OnBeforeShowAsyncImplement>d__11 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<DockyardSellTabView.<OnBeforeShowAsyncImplement>d__11>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0604153F RID: 267583 RVA: 0x00FD4E54 File Offset: 0x00FD3054
		public void ShowTipsPanel(int id)
		{
			DockyardItemBlockOriginalData itemBlockData = this.Vm.GetItemBlockData(id);
			this.TipsPanel.ShowTipsPanel(itemBlockData);
		}

		// Token: 0x06041540 RID: 267584 RVA: 0x00FD4E7A File Offset: 0x00FD307A
		public void HideTipsPanel()
		{
			this.TipsPanel.HideTipsPanel();
		}

		// Token: 0x06041541 RID: 267585 RVA: 0x00FD4E87 File Offset: 0x00FD3087
		[NullableContext(2)]
		public void CloseMe(Action<bool> callback = null)
		{
			this.Vm.NotifyMainViewClose();
		}

		// Token: 0x06041542 RID: 267586 RVA: 0x00FD4E94 File Offset: 0x00FD3094
		public void NotifyQuicklySellActive(bool isActive)
		{
		}

		// Token: 0x06041543 RID: 267587 RVA: 0x00FD4E96 File Offset: 0x00FD3096
		[NullableContext(2)]
		public UUIItem GetQuicklySellPanelParentItem()
		{
			return null;
		}

		// Token: 0x06041544 RID: 267588 RVA: 0x00FD4E99 File Offset: 0x00FD3099
		public void SetTrawlState(bool state)
		{
			this.ListPanel.SetActive(state);
			this.Vm.NotifyMainViewUiBlur(state);
		}

		// Token: 0x04021FF8 RID: 139256
		private DockyardBackpackPanel BackpackPanel;

		// Token: 0x04021FF9 RID: 139257
		private DockyardItemListPanel ListPanel;

		// Token: 0x04021FFA RID: 139258
		private DockyardSellTipsPanel TipsPanel;

		// Token: 0x04021FFB RID: 139259
		private DockyardShopTabViewModel Vm;

		// Token: 0x0200C7D7 RID: 51159
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C5C3 RID: 247235
			public const int BackpackItem = 0;

			// Token: 0x0403C5C4 RID: 247236
			public const int ListItem = 1;

			// Token: 0x0403C5C5 RID: 247237
			public const int TipsItem = 2;

			// Token: 0x0403C5C6 RID: 247238
			public const int SellParentItem = 3;
		}
	}
}
