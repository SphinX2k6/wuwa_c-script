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
	// Token: 0x02005507 RID: 21767
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingTimeLimitShopTabView : UiTabViewBase
	{
		// Token: 0x06035F13 RID: 220947 RVA: 0x00F10B14 File Offset: 0x00F0ED14
		protected override void OnBeforeShow()
		{
			UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
			LevelSequencePlayer levelSequencePlayer = (tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06035F14 RID: 220948 RVA: 0x00F10B50 File Offset: 0x00F0ED50
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

		// Token: 0x06035F15 RID: 220949 RVA: 0x00F10BBC File Offset: 0x00F0EDBC
		protected override void OnStart()
		{
			this.ActivityDataBase = (this.ExtraParams as ActivityFishingData);
			if (this.ActivityDataBase == null)
			{
				return;
			}
			this.LoopScrollView = new LoopScrollView<FishingLimitTimeShopGridItem, IPayShopUnionData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<FishingLimitTimeShopGridItem>(this.InitItem), false);
		}

		// Token: 0x06035F16 RID: 220950 RVA: 0x00F10C13 File Offset: 0x00F0EE13
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Add(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
		}

		// Token: 0x06035F17 RID: 220951 RVA: 0x00F10C4D File Offset: 0x00F0EE4D
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Remove(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
		}

		// Token: 0x06035F18 RID: 220952 RVA: 0x00F10C88 File Offset: 0x00F0EE88
		protected override UniTask OnShowAsyncImplementImplement()
		{
			FishingTimeLimitShopTabView.<OnShowAsyncImplementImplement>d__8 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<FishingTimeLimitShopTabView.<OnShowAsyncImplementImplement>d__8>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06035F19 RID: 220953 RVA: 0x00F10CCB File Offset: 0x00F0EECB
		private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
		{
			this.LoopScrollView.RefreshAllGridProxies();
		}

		// Token: 0x06035F1A RID: 220954 RVA: 0x00F10CD8 File Offset: 0x00F0EED8
		private void OnShopVersionCodeChange()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PayShopRefresh);
			confirmBoxDataNew.FunctionMap.Add(1, new Action(FishingTimeLimitShopTabView.<OnShopVersionCodeChange>g__confirmFunction|10_0));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YYZ, "[FishingActivity] PayShop:DockyardBuyTabView 商品VersionCode不同步,打开弹窗", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06035F1B RID: 220955 RVA: 0x00F10D33 File Offset: 0x00F0EF33
		private FishingLimitTimeShopGridItem InitItem()
		{
			return new FishingLimitTimeShopGridItem(this.ActivityDataBase);
		}

		// Token: 0x06035F1D RID: 220957 RVA: 0x00F10D48 File Offset: 0x00F0EF48
		[CompilerGenerated]
		internal static void <OnShopVersionCodeChange>g__confirmFunction|10_0()
		{
			UiManager.Instance.CloseView(EUiViewName.FishingTimeLimitView, null);
		}

		// Token: 0x0401C828 RID: 116776
		protected LoopScrollView<FishingLimitTimeShopGridItem, IPayShopUnionData> LoopScrollView;

		// Token: 0x0401C829 RID: 116777
		protected ActivityFishingData ActivityDataBase;

		// Token: 0x0200B168 RID: 45416
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036DBC RID: 224700
			public const int Scroll = 0;

			// Token: 0x04036DBD RID: 224701
			public const int ShopItem = 1;
		}
	}
}
