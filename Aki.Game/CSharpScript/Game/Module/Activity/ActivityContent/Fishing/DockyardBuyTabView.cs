using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065BA RID: 26042
	public class DockyardBuyTabView : UiTabViewBase
	{
		// Token: 0x0604152E RID: 267566 RVA: 0x00FD4A54 File Offset: 0x00FD2C54
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604152F RID: 267567 RVA: 0x00FD4ABD File Offset: 0x00FD2CBD
		protected override void OnStart()
		{
			this.LoopScrollView = new LoopScrollView<DockyardShopGridItem, IPayShopUnionData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<DockyardShopGridItem>(this.InitItem), false);
		}

		// Token: 0x06041530 RID: 267568 RVA: 0x00FD4AEF File Offset: 0x00FD2CEF
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Add(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
		}

		// Token: 0x06041531 RID: 267569 RVA: 0x00FD4B29 File Offset: 0x00FD2D29
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Remove(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
		}

		// Token: 0x06041532 RID: 267570 RVA: 0x00FD4B64 File Offset: 0x00FD2D64
		protected override UniTask OnShowAsyncImplementImplement()
		{
			DockyardBuyTabView.<OnShowAsyncImplementImplement>d__6 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<DockyardBuyTabView.<OnShowAsyncImplementImplement>d__6>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06041533 RID: 267571 RVA: 0x00FD4BA7 File Offset: 0x00FD2DA7
		private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
		{
			this.LoopScrollView.RefreshAllGridProxies();
		}

		// Token: 0x06041534 RID: 267572 RVA: 0x00FD4BB4 File Offset: 0x00FD2DB4
		private void OnShopVersionCodeChange()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PayShopRefresh);
			confirmBoxDataNew.FunctionMap.Add(1, new Action(DockyardBuyTabView.<OnShopVersionCodeChange>g__confirmFunction|8_0));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			Log.Instance.Info(ELogModule.Dockyard, ELogAuthor.XXJ, "PayShop:DockyardBuyTabView 商品VersionCode不同步,打开弹窗", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06041535 RID: 267573 RVA: 0x00FD4C0F File Offset: 0x00FD2E0F
		[NullableContext(1)]
		private DockyardShopGridItem InitItem()
		{
			return new DockyardShopGridItem();
		}

		// Token: 0x06041537 RID: 267575 RVA: 0x00FD4C1E File Offset: 0x00FD2E1E
		[CompilerGenerated]
		internal static void <OnShopVersionCodeChange>g__confirmFunction|8_0()
		{
			UiManager.Instance.CloseView(EUiViewName.DockyardShopMainView, null);
		}

		// Token: 0x04021FF7 RID: 139255
		[Nullable(1)]
		protected LoopScrollView<DockyardShopGridItem, IPayShopUnionData> LoopScrollView;

		// Token: 0x0200C7D5 RID: 51157
		private class EComponentDefine
		{
			// Token: 0x0403C5BD RID: 247229
			public const int Scroll = 0;

			// Token: 0x0403C5BE RID: 247230
			public const int ShopItem = 1;
		}
	}
}
