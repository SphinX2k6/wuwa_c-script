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
	// Token: 0x02005539 RID: 21817
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardSellTabView : UiTabViewBase, IDockyardViewInterface
	{
		// Token: 0x060361FD RID: 221693 RVA: 0x00F1BC6C File Offset: 0x00F19E6C
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

		// Token: 0x060361FE RID: 221694 RVA: 0x00F1BD1D File Offset: 0x00F19F1D
		private void InitViewModel()
		{
			this.Vm = (this.ExtraParams as DockyardShopTabViewModel);
			this.Vm.RegisterView(this);
		}

		// Token: 0x060361FF RID: 221695 RVA: 0x00F1BD3C File Offset: 0x00F19F3C
		private UniTask InitBackpackPanel()
		{
			DockyardSellTabView.<InitBackpackPanel>d__7 <InitBackpackPanel>d__;
			<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBackpackPanel>d__.<>4__this = this;
			<InitBackpackPanel>d__.<>1__state = -1;
			<InitBackpackPanel>d__.<>t__builder.Start<DockyardSellTabView.<InitBackpackPanel>d__7>(ref <InitBackpackPanel>d__);
			return <InitBackpackPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06036200 RID: 221696 RVA: 0x00F1BD80 File Offset: 0x00F19F80
		private UniTask InitLoopScroll()
		{
			DockyardSellTabView.<InitLoopScroll>d__8 <InitLoopScroll>d__;
			<InitLoopScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoopScroll>d__.<>4__this = this;
			<InitLoopScroll>d__.<>1__state = -1;
			<InitLoopScroll>d__.<>t__builder.Start<DockyardSellTabView.<InitLoopScroll>d__8>(ref <InitLoopScroll>d__);
			return <InitLoopScroll>d__.<>t__builder.Task;
		}

		// Token: 0x06036201 RID: 221697 RVA: 0x00F1BDC4 File Offset: 0x00F19FC4
		private UniTask InitTipsPanel()
		{
			DockyardSellTabView.<InitTipsPanel>d__9 <InitTipsPanel>d__;
			<InitTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsPanel>d__.<>4__this = this;
			<InitTipsPanel>d__.<>1__state = -1;
			<InitTipsPanel>d__.<>t__builder.Start<DockyardSellTabView.<InitTipsPanel>d__9>(ref <InitTipsPanel>d__);
			return <InitTipsPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06036202 RID: 221698 RVA: 0x00F1BE08 File Offset: 0x00F1A008
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardSellTabView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardSellTabView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036203 RID: 221699 RVA: 0x00F1BE4C File Offset: 0x00F1A04C
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			DockyardSellTabView.<OnBeforeShowAsyncImplement>d__11 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<DockyardSellTabView.<OnBeforeShowAsyncImplement>d__11>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06036204 RID: 221700 RVA: 0x00F1BE90 File Offset: 0x00F1A090
		public void ShowTipsPanel(int id)
		{
			DockyardItemBlockOriginalData itemBlockData = this.Vm.GetItemBlockData(id);
			this.TipsPanel.ShowTipsPanel(itemBlockData);
		}

		// Token: 0x06036205 RID: 221701 RVA: 0x00F1BEB6 File Offset: 0x00F1A0B6
		public void HideTipsPanel()
		{
			this.TipsPanel.HideTipsPanel();
		}

		// Token: 0x06036206 RID: 221702 RVA: 0x00F1BEC3 File Offset: 0x00F1A0C3
		[NullableContext(2)]
		public void CloseMe(Action<bool> callback = null)
		{
			this.Vm.NotifyMainViewClose();
		}

		// Token: 0x06036207 RID: 221703 RVA: 0x00F1BED0 File Offset: 0x00F1A0D0
		public void NotifyQuicklySellActive(bool isActive)
		{
		}

		// Token: 0x06036208 RID: 221704 RVA: 0x00F1BED2 File Offset: 0x00F1A0D2
		[NullableContext(2)]
		public UUIItem GetQuicklySellPanelParentItem()
		{
			return null;
		}

		// Token: 0x06036209 RID: 221705 RVA: 0x00F1BED5 File Offset: 0x00F1A0D5
		public void SetTrawlState(bool state)
		{
			this.ListPanel.SetActive(state);
			this.Vm.NotifyMainViewUiBlur(state);
		}

		// Token: 0x0401C929 RID: 117033
		private DockyardBackpackPanel BackpackPanel;

		// Token: 0x0401C92A RID: 117034
		private DockyardItemListPanel ListPanel;

		// Token: 0x0401C92B RID: 117035
		private DockyardSellTipsPanel TipsPanel;

		// Token: 0x0401C92C RID: 117036
		private DockyardShopTabViewModel Vm;

		// Token: 0x0200B1BA RID: 45498
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036F11 RID: 225041
			public const int BackpackItem = 0;

			// Token: 0x04036F12 RID: 225042
			public const int ListItem = 1;

			// Token: 0x04036F13 RID: 225043
			public const int TipsItem = 2;

			// Token: 0x04036F14 RID: 225044
			public const int SellParentItem = 3;
		}
	}
}
