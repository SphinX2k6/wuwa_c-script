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
	// Token: 0x0200526B RID: 21099
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballShopView : UiViewBase
	{
		// Token: 0x0603486C RID: 215148 RVA: 0x00EB276C File Offset: 0x00EB096C
		public PinballShopView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603486D RID: 215149 RVA: 0x00EB2778 File Offset: 0x00EB0978
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

		// Token: 0x0603486E RID: 215150 RVA: 0x00EB2804 File Offset: 0x00EB0A04
		protected override UniTask OnBeforeStartAsync()
		{
			PinballShopView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballShopView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603486F RID: 215151 RVA: 0x00EB2847 File Offset: 0x00EB0A47
		protected override void OnBeforeShow()
		{
			this.PauseTimeDilation();
			this.HideCharacter();
			this.RefreshShop();
		}

		// Token: 0x06034870 RID: 215152 RVA: 0x00EB285C File Offset: 0x00EB0A5C
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

		// Token: 0x06034871 RID: 215153 RVA: 0x00EB2910 File Offset: 0x00EB0B10
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, IReadOnlyList<ActivityBuyItem>, string>(EEventName.ActivityPayShopGoodsBuy, new Action<int, IReadOnlyList<ActivityBuyItem>, string>(this.OnActivityPayShopGoodsBuy));
			EventSystem.Instance.Add<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		}

		// Token: 0x06034872 RID: 215154 RVA: 0x00EB294A File Offset: 0x00EB0B4A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.ActivityPayShopGoodsBuy, new Action<int, IReadOnlyList<ActivityBuyItem>, string>(this.OnActivityPayShopGoodsBuy));
			EventSystem.Instance.Remove<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		}

		// Token: 0x06034873 RID: 215155 RVA: 0x00EB2984 File Offset: 0x00EB0B84
		private void OnActivityPayShopGoodsBuy(int payShopId, IReadOnlyList<ActivityBuyItem> buyItems, string version)
		{
			this.RefreshShop();
		}

		// Token: 0x06034874 RID: 215156 RVA: 0x00EB298C File Offset: 0x00EB0B8C
		private void OnRefreshPayShop(int payShopId, bool ifItemRefresh)
		{
			if (payShopId != this.ShopId)
			{
				return;
			}
			this.RefreshShop();
		}

		// Token: 0x06034875 RID: 215157 RVA: 0x00EB299E File Offset: 0x00EB0B9E
		protected void PauseTimeDilation()
		{
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag("PinballShopView");
		}

		// Token: 0x06034876 RID: 215158 RVA: 0x00EB29AF File Offset: 0x00EB0BAF
		protected void ResumeTimeDilation()
		{
			UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("PinballShopView");
		}

		// Token: 0x06034877 RID: 215159 RVA: 0x00EB29C0 File Offset: 0x00EB0BC0
		private void HideCharacter()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity != null)
			{
				CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, false, true, true, "PinballShopView", false);
			}
		}

		// Token: 0x06034878 RID: 215160 RVA: 0x00EB29F4 File Offset: 0x00EB0BF4
		private void ShowCharacter()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity != null)
			{
				CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, true, true, true, "PinballShopView", false);
			}
		}

		// Token: 0x06034879 RID: 215161 RVA: 0x00EB2A28 File Offset: 0x00EB0C28
		private void RefreshShop()
		{
			UiAsyncTask task = new UiAsyncTask("RefreshShop", new Func<UniTask>(this.RefreshShopAsync), null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x0603487A RID: 215162 RVA: 0x00EB2A5C File Offset: 0x00EB0C5C
		private UniTask RefreshShopAsync()
		{
			PinballShopView.<RefreshShopAsync>d__19 <RefreshShopAsync>d__;
			<RefreshShopAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshShopAsync>d__.<>4__this = this;
			<RefreshShopAsync>d__.<>1__state = -1;
			<RefreshShopAsync>d__.<>t__builder.Start<PinballShopView.<RefreshShopAsync>d__19>(ref <RefreshShopAsync>d__);
			return <RefreshShopAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603487B RID: 215163 RVA: 0x00EB2A9F File Offset: 0x00EB0C9F
		private void OnClickBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401BDB3 RID: 114099
		private int ShopId;

		// Token: 0x0401BDB4 RID: 114100
		public PopupCaptionItem PopupCaption;

		// Token: 0x0401BDB5 RID: 114101
		private GenericScrollViewNew<PinballShopRowItem, List<PinballShopItemProxy>> ScrollView;

		// Token: 0x0401BDB6 RID: 114102
		private const int MAX_ITEMS_PER_ROW = 5;

		// Token: 0x0200AEC6 RID: 44742
		[NullableContext(0)]
		private enum EShopComponent
		{
			// Token: 0x04035FFB RID: 221179
			UiItemCatapultStoryCaption,
			// Token: 0x04035FFC RID: 221180
			SvGoods,
			// Token: 0x04035FFD RID: 221181
			UiItemShopList
		}
	}
}
