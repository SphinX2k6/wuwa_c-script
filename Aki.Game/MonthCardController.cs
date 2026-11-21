using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001832 RID: 6194
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class MonthCardController : UiControllerBase
{
	// Token: 0x0600F474 RID: 62580 RVA: 0x00475ED2 File Offset: 0x004740D2
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600F475 RID: 62581 RVA: 0x00475ED5 File Offset: 0x004740D5
	private void SetMonthCardRemainDays(int value)
	{
		MonthCardModel.Instance.SetRemainDays(value);
		EventSystem.Instance.Emit(EEventName.ReceiveMonthCardDataEvent);
	}

	// Token: 0x0600F476 RID: 62582 RVA: 0x00475EF4 File Offset: 0x004740F4
	public UniTask RequestMonthCardData()
	{
		MonthCardController.<RequestMonthCardData>d__2 <RequestMonthCardData>d__;
		<RequestMonthCardData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestMonthCardData>d__.<>4__this = this;
		<RequestMonthCardData>d__.<>1__state = -1;
		<RequestMonthCardData>d__.<>t__builder.Start<MonthCardController.<RequestMonthCardData>d__2>(ref <RequestMonthCardData>d__);
		return <RequestMonthCardData>d__.<>t__builder.Task;
	}

	// Token: 0x0600F477 RID: 62583 RVA: 0x00475F37 File Offset: 0x00474137
	private void OnTryOpenMonthCardRewardView()
	{
		this.TryOpenMonthCardRewardView(false);
	}

	// Token: 0x0600F478 RID: 62584 RVA: 0x00475F40 File Offset: 0x00474140
	private void OnLoadingNetDataDone()
	{
		this.RequestMonthCardData().Forget();
	}

	// Token: 0x0600F479 RID: 62585 RVA: 0x00475F50 File Offset: 0x00474150
	[NullableContext(2)]
	private unsafe void OnReceiveDailyRewardNotify(IMessage msg, Net.CallbackStatus status)
	{
		MonthCardDailyRewardNotify monthCardDailyRewardNotify = (MonthCardDailyRewardNotify)msg;
		int count = monthCardDailyRewardNotify.Count;
		int itemId = monthCardDailyRewardNotify.ItemId;
		int days = monthCardDailyRewardNotify.Days;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "MonthCard:【月卡每日奖励】信息推送 - MonthCardDailyRewardNotify";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Count", count);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("itemId", itemId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("remainDays", days);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		TItem value = new TItem(new InventoryDefine.GetItemData(itemId, 0), count);
		MonthCardModel.Instance.ServerDailyReward = new TItem?(value);
		MonthCardModel.Instance.CanShowDailyRewardView = true;
		this.SetMonthCardRemainDays(days);
		this.TryOpenMonthCardRewardView(true);
	}

	// Token: 0x0600F47A RID: 62586 RVA: 0x0047602C File Offset: 0x0047422C
	[NullableContext(2)]
	private void OnMonthCardUse(IMessage msg, Net.CallbackStatus status)
	{
		MonthCardUseNotify monthCardUseNotify = (MonthCardUseNotify)msg;
		int days = monthCardUseNotify.Days;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "MonthCard:【月卡购买通知】-MonthCardBuyNotify-信息推送";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("remainDays", days);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		TItem value = new TItem(new InventoryDefine.GetItemData(monthCardUseNotify.ItemId, 0), monthCardUseNotify.Count);
		MonthCardModel.Instance.ServerOnceReward = new TItem?(value);
		if (MonthCardModel.Instance.GetRemainDays() < 0)
		{
			MonthCardModel.Instance.CanShowDailyRewardView = true;
		}
		this.SetMonthCardRemainDays(days);
		if (GameModeModel.Instance.WorldDoneAndLoadingClosed)
		{
			TItem? serverOnceReward = MonthCardModel.Instance.ServerOnceReward;
			int itemId = serverOnceReward.Value.ItemData.ItemId;
			if (itemId != 0)
			{
				RewardItemData item = new RewardItemData(itemId, serverOnceReward.Value.Count, null, EDropItemType.Normal);
				List<RewardItemData> rewardItemDataList = new List<RewardItemData>
				{
					item
				};
				int monthCardRewardId = PayShopConfig.Instance.GetMonthCardRewardId();
				ItemRewardController.Instance.OpenCommonRewardView(monthCardRewardId, rewardItemDataList, new Action(this.TryOpenMonthCardRewardViewInShop));
				return;
			}
			this.TryOpenMonthCardRewardViewInShop();
		}
	}

	// Token: 0x0600F47B RID: 62587 RVA: 0x00476146 File Offset: 0x00474346
	private void TryOpenMonthCardRewardViewInShop()
	{
		if (MonthCardModel.Instance.CanShowDailyRewardView)
		{
			this.OpenMonthCardRewardView(false);
		}
	}

	// Token: 0x0600F47C RID: 62588 RVA: 0x0047615C File Offset: 0x0047435C
	private void TryOpenMonthCardRewardView(bool isInstantly = false)
	{
		if (MonthCardModel.Instance.CanShowDailyRewardView)
		{
			SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.MonthCard, ESplashScreenType.Config, delegate()
			{
				this.OpenMonthCardRewardView(true);
			});
			SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, isInstantly);
		}
	}

	// Token: 0x0600F47D RID: 62589 RVA: 0x00476195 File Offset: 0x00474395
	private void OpenMonthCardRewardView(bool isBySplashScreen)
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.MonthCardRewardView))
		{
			UiManager.Instance.OpenView(EUiViewName.MonthCardRewardView, isBySplashScreen, null);
		}
	}

	// Token: 0x0600F47E RID: 62590 RVA: 0x004761C0 File Offset: 0x004743C0
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnTryOpenMonthCardRewardView));
	}

	// Token: 0x0600F47F RID: 62591 RVA: 0x00476224 File Offset: 0x00474424
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnTryOpenMonthCardRewardView));
	}

	// Token: 0x0600F480 RID: 62592 RVA: 0x00476288 File Offset: 0x00474488
	private void OnItemUse(int configId, int itemNum)
	{
		ItemInfo value = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(configId).Value;
		int? num = null;
		int value2;
		if (value.Parameters().TryGetValue(13, out value2))
		{
			num = new int?(value2);
		}
		int value3;
		if (num == null && value.Parameters().TryGetValue(14, out value3))
		{
			num = new int?(value3);
		}
		if (num != null)
		{
			GenericPromptController.Instance.ShowPromptByCode("UseMonthCard", Array.Empty<object>());
		}
	}

	// Token: 0x0600F481 RID: 62593 RVA: 0x0047630C File Offset: 0x0047450C
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.MonthCardDailyRewardNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveDailyRewardNotify));
		Net.Instance.Register(ENotifyMessageId.MonthCardUseNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMonthCardUse));
	}

	// Token: 0x0600F482 RID: 62594 RVA: 0x00476346 File Offset: 0x00474546
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.MonthCardDailyRewardNotify);
		Net.Instance.UnRegister(ENotifyMessageId.MonthCardUseNotify);
	}

	// Token: 0x170017C4 RID: 6084
	// (get) Token: 0x0600F483 RID: 62595 RVA: 0x00476368 File Offset: 0x00474568
	public static MonthCardController Instance
	{
		get
		{
			return MonthCardController._Instance;
		}
	}

	// Token: 0x0600F484 RID: 62596 RVA: 0x0047636F File Offset: 0x0047456F
	public static MonthCardController GetOrCreateInstance()
	{
		if (MonthCardController._Instance == null)
		{
			MonthCardController.CreateInstance();
		}
		return MonthCardController._Instance;
	}

	// Token: 0x0600F485 RID: 62597 RVA: 0x00476383 File Offset: 0x00474583
	public static bool CreateInstance()
	{
		if (MonthCardController._Instance != null)
		{
			return true;
		}
		MonthCardController._Instance = new MonthCardController();
		return true;
	}

	// Token: 0x0600F486 RID: 62598 RVA: 0x00476399 File Offset: 0x00474599
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F487 RID: 62599 RVA: 0x0047639B File Offset: 0x0047459B
	public static void ResetStaticDefaultValue()
	{
		MonthCardController._Instance = null;
	}

	// Token: 0x0600F488 RID: 62600 RVA: 0x004763A3 File Offset: 0x004745A3
	static MonthCardController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MonthCardController.CreateStaticDefaultValue), new Action(MonthCardController.ResetStaticDefaultValue));
	}

	// Token: 0x04008928 RID: 35112
	[Nullable(2)]
	private static MonthCardController _Instance;
}
