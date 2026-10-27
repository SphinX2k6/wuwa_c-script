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
	// Token: 0x02006589 RID: 25993
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingTimeLimitShopTabView : UiTabViewBase
	{
		// Token: 0x0604124E RID: 266830 RVA: 0x00FC9B64 File Offset: 0x00FC7D64
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

		// Token: 0x0604124F RID: 266831 RVA: 0x00FC9BA0 File Offset: 0x00FC7DA0
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

		// Token: 0x06041250 RID: 266832 RVA: 0x00FC9C0C File Offset: 0x00FC7E0C
		protected override void OnStart()
		{
			this.ActivityDataBase = (this.ExtraParams as ActivityFishingData);
			if (this.ActivityDataBase == null)
			{
				return;
			}
			this.LoopScrollView = new LoopScrollView<FishingLimitTimeShopGridItem, IPayShopUnionData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<FishingLimitTimeShopGridItem>(this.InitItem), false);
		}

		// Token: 0x06041251 RID: 266833 RVA: 0x00FC9C63 File Offset: 0x00FC7E63
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Add(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
		}

		// Token: 0x06041252 RID: 266834 RVA: 0x00FC9C9D File Offset: 0x00FC7E9D
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Remove(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
		}

		// Token: 0x06041253 RID: 266835 RVA: 0x00FC9CD8 File Offset: 0x00FC7ED8
		protected override UniTask OnShowAsyncImplementImplement()
		{
			FishingTimeLimitShopTabView.<OnShowAsyncImplementImplement>d__8 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<FishingTimeLimitShopTabView.<OnShowAsyncImplementImplement>d__8>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06041254 RID: 266836 RVA: 0x00FC9D1B File Offset: 0x00FC7F1B
		private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
		{
			this.LoopScrollView.RefreshAllGridProxies();
		}

		// Token: 0x06041255 RID: 266837 RVA: 0x00FC9D28 File Offset: 0x00FC7F28
		private void OnShopVersionCodeChange()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PayShopRefresh);
			confirmBoxDataNew.FunctionMap.Add(1, new Action(FishingTimeLimitShopTabView.<OnShopVersionCodeChange>g__confirmFunction|10_0));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YYZ, "[FishingActivity] PayShop:DockyardBuyTabView 商品VersionCode不同步,打开弹窗", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06041256 RID: 266838 RVA: 0x00FC9D83 File Offset: 0x00FC7F83
		private FishingLimitTimeShopGridItem InitItem()
		{
			return new FishingLimitTimeShopGridItem(this.ActivityDataBase);
		}

		// Token: 0x06041258 RID: 266840 RVA: 0x00FC9D98 File Offset: 0x00FC7F98
		[CompilerGenerated]
		internal static void <OnShopVersionCodeChange>g__confirmFunction|10_0()
		{
			UiManager.Instance.CloseView(EUiViewName.FishingTimeLimitView, null);
		}

		// Token: 0x04021EF7 RID: 138999
		protected LoopScrollView<FishingLimitTimeShopGridItem, IPayShopUnionData> LoopScrollView;

		// Token: 0x04021EF8 RID: 139000
		protected ActivityFishingData ActivityDataBase;

		// Token: 0x0200C783 RID: 51075
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C46B RID: 246891
			public const int Scroll = 0;

			// Token: 0x0403C46C RID: 246892
			public const int ShopItem = 1;
		}
	}
}
