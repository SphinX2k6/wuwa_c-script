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

// Token: 0x0200234D RID: 9037
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class MonthCardController : UiControllerBase
{
	// Token: 0x06011FC4 RID: 73668 RVA: 0x00468E0A File Offset: 0x0046700A
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06011FC5 RID: 73669 RVA: 0x00468E0D File Offset: 0x0046700D
	private void SetMonthCardRemainDays(int value)
	{
		MonthCardModel.Instance.SetRemainDays(value);
		EventSystem.Instance.Emit(EEventName.ReceiveMonthCardDataEvent);
	}

	// Token: 0x06011FC6 RID: 73670 RVA: 0x00468E2C File Offset: 0x0046702C
	public UniTask RequestMonthCardData()
	{
		MonthCardController.<RequestMonthCardData>d__2 <RequestMonthCardData>d__;
		<RequestMonthCardData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestMonthCardData>d__.<>4__this = this;
		<RequestMonthCardData>d__.<>1__state = -1;
		<RequestMonthCardData>d__.<>t__builder.Start<MonthCardController.<RequestMonthCardData>d__2>(ref <RequestMonthCardData>d__);
		return <RequestMonthCardData>d__.<>t__builder.Task;
	}

	// Token: 0x06011FC7 RID: 73671 RVA: 0x00468E6F File Offset: 0x0046706F
	private void OnTryOpenMonthCardRewardView()
	{
		this.TryOpenMonthCardRewardView(false);
	}

	// Token: 0x06011FC8 RID: 73672 RVA: 0x00468E78 File Offset: 0x00467078
	private void OnLoadingNetDataDone()
	{
		this.RequestMonthCardData().Forget();
	}

	// Token: 0x06011FC9 RID: 73673 RVA: 0x00468E88 File Offset: 0x00467088
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

	// Token: 0x06011FCA RID: 73674 RVA: 0x00468F64 File Offset: 0x00467164
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

	// Token: 0x06011FCB RID: 73675 RVA: 0x0046907E File Offset: 0x0046727E
	private void TryOpenMonthCardRewardViewInShop()
	{
		if (MonthCardModel.Instance.CanShowDailyRewardView)
		{
			this.OpenMonthCardRewardView(false);
		}
	}

	// Token: 0x06011FCC RID: 73676 RVA: 0x00469094 File Offset: 0x00467294
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

	// Token: 0x06011FCD RID: 73677 RVA: 0x004690CD File Offset: 0x004672CD
	private void OpenMonthCardRewardView(bool isBySplashScreen)
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.MonthCardRewardView))
		{
			UiManager.Instance.OpenView(EUiViewName.MonthCardRewardView, isBySplashScreen, null);
		}
	}

	// Token: 0x06011FCE RID: 73678 RVA: 0x004690F8 File Offset: 0x004672F8
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnTryOpenMonthCardRewardView));
	}

	// Token: 0x06011FCF RID: 73679 RVA: 0x0046915C File Offset: 0x0046735C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnTryOpenMonthCardRewardView));
	}

	// Token: 0x06011FD0 RID: 73680 RVA: 0x004691C0 File Offset: 0x004673C0
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

	// Token: 0x06011FD1 RID: 73681 RVA: 0x00469244 File Offset: 0x00467444
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.MonthCardDailyRewardNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveDailyRewardNotify));
		Net.Instance.Register(ENotifyMessageId.MonthCardUseNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMonthCardUse));
	}

	// Token: 0x06011FD2 RID: 73682 RVA: 0x0046927E File Offset: 0x0046747E
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.MonthCardDailyRewardNotify);
		Net.Instance.UnRegister(ENotifyMessageId.MonthCardUseNotify);
	}

	// Token: 0x1700178A RID: 6026
	// (get) Token: 0x06011FD3 RID: 73683 RVA: 0x004692A0 File Offset: 0x004674A0
	public static MonthCardController Instance
	{
		get
		{
			return MonthCardController._Instance;
		}
	}

	// Token: 0x06011FD4 RID: 73684 RVA: 0x004692A7 File Offset: 0x004674A7
	public static MonthCardController GetOrCreateInstance()
	{
		if (MonthCardController._Instance == null)
		{
			MonthCardController.CreateInstance();
		}
		return MonthCardController._Instance;
	}

	// Token: 0x06011FD5 RID: 73685 RVA: 0x004692BB File Offset: 0x004674BB
	public static bool CreateInstance()
	{
		if (MonthCardController._Instance != null)
		{
			return true;
		}
		MonthCardController._Instance = new MonthCardController();
		return true;
	}

	// Token: 0x06011FD6 RID: 73686 RVA: 0x004692D1 File Offset: 0x004674D1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011FD7 RID: 73687 RVA: 0x004692D3 File Offset: 0x004674D3
	public static void ResetStaticDefaultValue()
	{
		MonthCardController._Instance = null;
	}

	// Token: 0x06011FD8 RID: 73688 RVA: 0x004692DB File Offset: 0x004674DB
	static MonthCardController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MonthCardController.CreateStaticDefaultValue), new Action(MonthCardController.ResetStaticDefaultValue));
	}

	// Token: 0x040087E5 RID: 34789
	[Nullable(2)]
	private static MonthCardController _Instance;
}
