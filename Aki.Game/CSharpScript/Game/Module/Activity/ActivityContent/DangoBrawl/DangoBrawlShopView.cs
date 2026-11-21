using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005794 RID: 22420
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlShopView : UiTickViewBase
	{
		// Token: 0x17006A91 RID: 27281
		// (get) Token: 0x0603753B RID: 226619 RVA: 0x00F74072 File Offset: 0x00F72272
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x0603753C RID: 226620 RVA: 0x00F7407E File Offset: 0x00F7227E
		public DangoBrawlShopView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603753D RID: 226621 RVA: 0x00F74090 File Offset: 0x00F72290
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603753E RID: 226622 RVA: 0x00F7415C File Offset: 0x00F7235C
		protected override void OnStart()
		{
			DangoBrawlActivity? activityConfigById = DangoBrawlConfig.Instance.GetActivityConfigById(this.ActivityData.Id);
			if (activityConfigById != null)
			{
				this.ShopId = activityConfigById.Value.ShopId;
			}
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseBtnClick));
			this.LoopScrollView = new LoopScrollView<DangoBrawlShopItem, DangoBrawlShopItemProxy>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, () => new DangoBrawlShopItem(), false);
		}

		// Token: 0x0603753F RID: 226623 RVA: 0x00F7420C File Offset: 0x00F7240C
		protected override void OnBeforeShow()
		{
			if (this.ShopId > 0)
			{
				PayShop payShopConfig = PayShopConfig.Instance.GetPayShopConfig(this.ShopId);
				this.CaptionItem.SetCurrencyItemList(payShopConfig.Money()).Forget();
				this.CaptionItem.SetCurrencyItemVisible(true);
				PayShopController.Instance.SendRequestPayShopUpdate((PayShopDefine.EPayShopTabType)this.ShopId, false, null);
			}
			this.ActivityData.MarkShopRead();
			this.RefreshRemainTime();
		}

		// Token: 0x06037540 RID: 226624 RVA: 0x00F74279 File Offset: 0x00F72479
		protected override void OnTick(float delta)
		{
			this.RefreshRemainTime();
		}

		// Token: 0x06037541 RID: 226625 RVA: 0x00F74284 File Offset: 0x00F72484
		private void RefreshRemainTime()
		{
			string text = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null) ?? "";
			string newText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.EndShowTime, text) ?? "";
			UUIText text2 = base.GetText(3);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(newText, true);
		}

		// Token: 0x06037542 RID: 226626 RVA: 0x00F742D9 File Offset: 0x00F724D9
		protected override void OnBeforeHide()
		{
			if (this.ShopId == -1)
			{
				return;
			}
			PayShopModel.Instance.ReadShopItemCheckFlag((PayShopDefine.EPayShopTabType)this.ShopId, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityData.Id);
		}

		// Token: 0x06037543 RID: 226627 RVA: 0x00F74312 File Offset: 0x00F72512
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, IReadOnlyList<ActivityBuyItem>, string>(EEventName.ActivityPayShopGoodsBuy, new Action<int, IReadOnlyList<ActivityBuyItem>, string>(this.OnActivityPayShopGoodsBuy));
			EventSystem.Instance.Add<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		}

		// Token: 0x06037544 RID: 226628 RVA: 0x00F7434C File Offset: 0x00F7254C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.ActivityPayShopGoodsBuy, new Action<int, IReadOnlyList<ActivityBuyItem>, string>(this.OnActivityPayShopGoodsBuy));
			EventSystem.Instance.Remove<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		}

		// Token: 0x06037545 RID: 226629 RVA: 0x00F74386 File Offset: 0x00F72586
		private void OnActivityPayShopGoodsBuy(int payShopId, IReadOnlyList<ActivityBuyItem> buyItems, string version)
		{
			this.RefreshShop();
		}

		// Token: 0x06037546 RID: 226630 RVA: 0x00F7438E File Offset: 0x00F7258E
		private void OnRefreshPayShop(int payShopId, bool ifItemRefresh)
		{
			if (payShopId != this.ShopId)
			{
				return;
			}
			this.RefreshShop();
		}

		// Token: 0x06037547 RID: 226631 RVA: 0x00F743A0 File Offset: 0x00F725A0
		private void RefreshShop()
		{
			if (this.ShopId == -1)
			{
				return;
			}
			UiAsyncTask task = new UiAsyncTask("RefreshShop", new Func<UniTask>(this.RefreshShopAsync), null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x06037548 RID: 226632 RVA: 0x00F743DC File Offset: 0x00F725DC
		private UniTask RefreshShopAsync()
		{
			DangoBrawlShopView.<RefreshShopAsync>d__18 <RefreshShopAsync>d__;
			<RefreshShopAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshShopAsync>d__.<>4__this = this;
			<RefreshShopAsync>d__.<>1__state = -1;
			<RefreshShopAsync>d__.<>t__builder.Start<DangoBrawlShopView.<RefreshShopAsync>d__18>(ref <RefreshShopAsync>d__);
			return <RefreshShopAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037549 RID: 226633 RVA: 0x00F7441F File Offset: 0x00F7261F
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401D392 RID: 119698
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D393 RID: 119699
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<DangoBrawlShopItem, DangoBrawlShopItemProxy> LoopScrollView;

		// Token: 0x0401D394 RID: 119700
		private int ShopId = -1;

		// Token: 0x0200B3D1 RID: 46033
		[NullableContext(0)]
		private enum EShopComponent
		{
			// Token: 0x040379B5 RID: 227765
			CaptionItem,
			// Token: 0x040379B6 RID: 227766
			LoopScrollView,
			// Token: 0x040379B7 RID: 227767
			LoopItem,
			// Token: 0x040379B8 RID: 227768
			TxtTime,
			// Token: 0x040379B9 RID: 227769
			Self
		}
	}
}
