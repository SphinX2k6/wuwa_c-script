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
	// Token: 0x02006844 RID: 26692
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlShopView : UiTickViewBase
	{
		// Token: 0x17009750 RID: 38736
		// (get) Token: 0x060429E7 RID: 272871 RVA: 0x01032B66 File Offset: 0x01030D66
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x060429E8 RID: 272872 RVA: 0x01032B72 File Offset: 0x01030D72
		public DangoBrawlShopView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060429E9 RID: 272873 RVA: 0x01032B84 File Offset: 0x01030D84
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

		// Token: 0x060429EA RID: 272874 RVA: 0x01032C50 File Offset: 0x01030E50
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

		// Token: 0x060429EB RID: 272875 RVA: 0x01032D00 File Offset: 0x01030F00
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

		// Token: 0x060429EC RID: 272876 RVA: 0x01032D6D File Offset: 0x01030F6D
		protected override void OnTick(float delta)
		{
			this.RefreshRemainTime();
		}

		// Token: 0x060429ED RID: 272877 RVA: 0x01032D78 File Offset: 0x01030F78
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

		// Token: 0x060429EE RID: 272878 RVA: 0x01032DCD File Offset: 0x01030FCD
		protected override void OnBeforeHide()
		{
			if (this.ShopId == -1)
			{
				return;
			}
			PayShopModel.Instance.ReadShopItemCheckFlag((PayShopDefine.EPayShopTabType)this.ShopId, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityData.Id);
		}

		// Token: 0x060429EF RID: 272879 RVA: 0x01032E06 File Offset: 0x01031006
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, IReadOnlyList<ActivityBuyItem>, string>(EEventName.ActivityPayShopGoodsBuy, new Action<int, IReadOnlyList<ActivityBuyItem>, string>(this.OnActivityPayShopGoodsBuy));
			EventSystem.Instance.Add<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		}

		// Token: 0x060429F0 RID: 272880 RVA: 0x01032E40 File Offset: 0x01031040
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.ActivityPayShopGoodsBuy, new Action<int, IReadOnlyList<ActivityBuyItem>, string>(this.OnActivityPayShopGoodsBuy));
			EventSystem.Instance.Remove<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		}

		// Token: 0x060429F1 RID: 272881 RVA: 0x01032E7A File Offset: 0x0103107A
		private void OnActivityPayShopGoodsBuy(int payShopId, IReadOnlyList<ActivityBuyItem> buyItems, string version)
		{
			this.RefreshShop();
		}

		// Token: 0x060429F2 RID: 272882 RVA: 0x01032E82 File Offset: 0x01031082
		private void OnRefreshPayShop(int payShopId, bool ifItemRefresh)
		{
			if (payShopId != this.ShopId)
			{
				return;
			}
			this.RefreshShop();
		}

		// Token: 0x060429F3 RID: 272883 RVA: 0x01032E94 File Offset: 0x01031094
		private void RefreshShop()
		{
			if (this.ShopId == -1)
			{
				return;
			}
			UiAsyncTask task = new UiAsyncTask("RefreshShop", new Func<UniTask>(this.RefreshShopAsync), null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x060429F4 RID: 272884 RVA: 0x01032ED0 File Offset: 0x010310D0
		private UniTask RefreshShopAsync()
		{
			DangoBrawlShopView.<RefreshShopAsync>d__18 <RefreshShopAsync>d__;
			<RefreshShopAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshShopAsync>d__.<>4__this = this;
			<RefreshShopAsync>d__.<>1__state = -1;
			<RefreshShopAsync>d__.<>t__builder.Start<DangoBrawlShopView.<RefreshShopAsync>d__18>(ref <RefreshShopAsync>d__);
			return <RefreshShopAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060429F5 RID: 272885 RVA: 0x01032F13 File Offset: 0x01031113
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04022B35 RID: 142133
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022B36 RID: 142134
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<DangoBrawlShopItem, DangoBrawlShopItemProxy> LoopScrollView;

		// Token: 0x04022B37 RID: 142135
		private int ShopId = -1;

		// Token: 0x0200CA05 RID: 51717
		[NullableContext(0)]
		private enum EShopComponent
		{
			// Token: 0x0403D0CC RID: 250060
			CaptionItem,
			// Token: 0x0403D0CD RID: 250061
			LoopScrollView,
			// Token: 0x0403D0CE RID: 250062
			LoopItem,
			// Token: 0x0403D0CF RID: 250063
			TxtTime,
			// Token: 0x0403D0D0 RID: 250064
			Self
		}
	}
}
