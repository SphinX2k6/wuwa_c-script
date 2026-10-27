using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Shop
{
	// Token: 0x020062ED RID: 25325
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballShopView : UiViewBase
	{
		// Token: 0x0603FBAB RID: 261035 RVA: 0x00F6B810 File Offset: 0x00F69A10
		public PinballShopView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603FBAC RID: 261036 RVA: 0x00F6B81C File Offset: 0x00F69A1C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FBAD RID: 261037 RVA: 0x00F6B8A8 File Offset: 0x00F69AA8
		protected override UniTask OnBeforeStartAsync()
		{
			PinballShopView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballShopView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FBAE RID: 261038 RVA: 0x00F6B8EB File Offset: 0x00F69AEB
		protected override void OnBeforeShow()
		{
			this.PauseTimeDilation();
			this.HideCharacter();
			this.RefreshShop();
		}

		// Token: 0x0603FBAF RID: 261039 RVA: 0x00F6B900 File Offset: 0x00F69B00
		protected override void OnBeforeHide()
		{
			this.ResumeTimeDilation();
			this.ShowCharacter();
			foreach (PayShopGoods payShopGoods in PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)this.ShopId, 1, false))
			{
				int goodsId = payShopGoods.GetGoodsId();
				if (goodsId > 0)
				{
					NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.PayShopTabItemChecked, goodsId);
				}
			}
			NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.PayShopTabItemChecked);
			PinballActivityData activityData = PinballModel.Instance.ActivityData;
			int num = (activityData != null) ? activityData.Id : 0;
			if (num > 0)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, num);
			}
		}

		// Token: 0x0603FBB0 RID: 261040 RVA: 0x00F6B9B4 File Offset: 0x00F69BB4
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, IReadOnlyList<ActivityBuyItem>, string>(EEventName.ActivityPayShopGoodsBuy, new Action<int, IReadOnlyList<ActivityBuyItem>, string>(this.OnActivityPayShopGoodsBuy));
			EventSystem.Instance.Add<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		}

		// Token: 0x0603FBB1 RID: 261041 RVA: 0x00F6B9EE File Offset: 0x00F69BEE
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.ActivityPayShopGoodsBuy, new Action<int, IReadOnlyList<ActivityBuyItem>, string>(this.OnActivityPayShopGoodsBuy));
			EventSystem.Instance.Remove<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		}

		// Token: 0x0603FBB2 RID: 261042 RVA: 0x00F6BA28 File Offset: 0x00F69C28
		private void OnActivityPayShopGoodsBuy(int payShopId, IReadOnlyList<ActivityBuyItem> buyItems, string version)
		{
			this.RefreshShop();
		}

		// Token: 0x0603FBB3 RID: 261043 RVA: 0x00F6BA30 File Offset: 0x00F69C30
		private void OnRefreshPayShop(int payShopId, bool ifItemRefresh)
		{
			if (payShopId != this.ShopId)
			{
				return;
			}
			this.RefreshShop();
		}

		// Token: 0x0603FBB4 RID: 261044 RVA: 0x00F6BA42 File Offset: 0x00F69C42
		protected void PauseTimeDilation()
		{
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag("PinballShopView");
		}

		// Token: 0x0603FBB5 RID: 261045 RVA: 0x00F6BA53 File Offset: 0x00F69C53
		protected void ResumeTimeDilation()
		{
			UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("PinballShopView");
		}

		// Token: 0x0603FBB6 RID: 261046 RVA: 0x00F6BA64 File Offset: 0x00F69C64
		private void HideCharacter()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity != null)
			{
				CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, false, true, true, "PinballShopView", false);
			}
		}

		// Token: 0x0603FBB7 RID: 261047 RVA: 0x00F6BA98 File Offset: 0x00F69C98
		private void ShowCharacter()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity != null)
			{
				CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, true, true, true, "PinballShopView", false);
			}
		}

		// Token: 0x0603FBB8 RID: 261048 RVA: 0x00F6BACC File Offset: 0x00F69CCC
		private void RefreshShop()
		{
			UiAsyncTask task = new UiAsyncTask("RefreshShop", new Func<UniTask>(this.RefreshShopAsync), null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x0603FBB9 RID: 261049 RVA: 0x00F6BB00 File Offset: 0x00F69D00
		private UniTask RefreshShopAsync()
		{
			PinballShopView.<RefreshShopAsync>d__19 <RefreshShopAsync>d__;
			<RefreshShopAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshShopAsync>d__.<>4__this = this;
			<RefreshShopAsync>d__.<>1__state = -1;
			<RefreshShopAsync>d__.<>t__builder.Start<PinballShopView.<RefreshShopAsync>d__19>(ref <RefreshShopAsync>d__);
			return <RefreshShopAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FBBA RID: 261050 RVA: 0x00F6BB43 File Offset: 0x00F69D43
		private void OnClickBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x04021484 RID: 136324
		private int ShopId;

		// Token: 0x04021485 RID: 136325
		public PopupCaptionItem PopupCaption;

		// Token: 0x04021486 RID: 136326
		private GenericScrollViewNew<PinballShopRowItem, List<PinballShopItemProxy>> ScrollView;

		// Token: 0x04021487 RID: 136327
		private const int MAX_ITEMS_PER_ROW = 5;

		// Token: 0x0200C4DF RID: 50399
		[NullableContext(0)]
		private enum EShopComponent
		{
			// Token: 0x0403B699 RID: 243353
			UiItemCatapultStoryCaption,
			// Token: 0x0403B69A RID: 243354
			SvGoods,
			// Token: 0x0403B69B RID: 243355
			UiItemShopList
		}
	}
}
