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
	// Token: 0x02005538 RID: 21816
	public class DockyardBuyTabView : UiTabViewBase
	{
		// Token: 0x060361F3 RID: 221683 RVA: 0x00F1BA90 File Offset: 0x00F19C90
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

		// Token: 0x060361F4 RID: 221684 RVA: 0x00F1BAF9 File Offset: 0x00F19CF9
		protected override void OnStart()
		{
			this.LoopScrollView = new LoopScrollView<DockyardShopGridItem, IPayShopUnionData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<DockyardShopGridItem>(this.InitItem), false);
		}

		// Token: 0x060361F5 RID: 221685 RVA: 0x00F1BB2B File Offset: 0x00F19D2B
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Add(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
		}

		// Token: 0x060361F6 RID: 221686 RVA: 0x00F1BB65 File Offset: 0x00F19D65
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Remove(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
		}

		// Token: 0x060361F7 RID: 221687 RVA: 0x00F1BBA0 File Offset: 0x00F19DA0
		protected override UniTask OnShowAsyncImplementImplement()
		{
			DockyardBuyTabView.<OnShowAsyncImplementImplement>d__6 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<DockyardBuyTabView.<OnShowAsyncImplementImplement>d__6>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060361F8 RID: 221688 RVA: 0x00F1BBE3 File Offset: 0x00F19DE3
		private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
		{
			this.LoopScrollView.RefreshAllGridProxies();
		}

		// Token: 0x060361F9 RID: 221689 RVA: 0x00F1BBF0 File Offset: 0x00F19DF0
		private void OnShopVersionCodeChange()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PayShopRefresh);
			confirmBoxDataNew.FunctionMap.Add(1, new Action(DockyardBuyTabView.<OnShopVersionCodeChange>g__confirmFunction|8_0));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			Log.Instance.Info(ELogModule.Dockyard, ELogAuthor.XXJ, "PayShop:DockyardBuyTabView 商品VersionCode不同步,打开弹窗", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060361FA RID: 221690 RVA: 0x00F1BC4B File Offset: 0x00F19E4B
		[NullableContext(1)]
		private DockyardShopGridItem InitItem()
		{
			return new DockyardShopGridItem();
		}

		// Token: 0x060361FC RID: 221692 RVA: 0x00F1BC5A File Offset: 0x00F19E5A
		[CompilerGenerated]
		internal static void <OnShopVersionCodeChange>g__confirmFunction|8_0()
		{
			UiManager.Instance.CloseView(EUiViewName.DockyardShopMainView, null);
		}

		// Token: 0x0401C928 RID: 117032
		[Nullable(1)]
		protected LoopScrollView<DockyardShopGridItem, IPayShopUnionData> LoopScrollView;

		// Token: 0x0200B1B8 RID: 45496
		private class EComponentDefine
		{
			// Token: 0x04036F0B RID: 225035
			public const int Scroll = 0;

			// Token: 0x04036F0C RID: 225036
			public const int ShopItem = 1;
		}
	}
}
