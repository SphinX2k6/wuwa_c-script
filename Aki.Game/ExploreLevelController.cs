using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001A91 RID: 6801
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ExploreLevelController : UiControllerBase
{
	// Token: 0x0600C8BF RID: 51391 RVA: 0x002DC8A4 File Offset: 0x002DAAA4
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ExploreLevelNotify, new Action<IMessage, Net.CallbackStatus>(this.ExploreLevelNotify));
	}

	// Token: 0x0600C8C0 RID: 51392 RVA: 0x002DC8C2 File Offset: 0x002DAAC2
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ExploreLevelNotify);
	}

	// Token: 0x0600C8C1 RID: 51393 RVA: 0x002DC8D4 File Offset: 0x002DAAD4
	[NullableContext(2)]
	private void ExploreLevelNotify(IMessage msg, Net.CallbackStatus _)
	{
		ExploreLevelNotify exploreLevelNotify = (ExploreLevelNotify)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.ExploreLevel;
		ELogAuthor author = ELogAuthor.LRX;
		string message = "服务端通知探索等级 ExploreLevelNotify";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("notify", exploreLevelNotify);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		ExploreLevelModel instance2 = ExploreLevelModel.Instance;
		foreach (CountryExploreLevel countryExploreLevel in exploreLevelNotify.CountryExploreLevel)
		{
			instance2.SetCountryExploreLevel(countryExploreLevel.CountryId, countryExploreLevel.ExploreLevel);
		}
		EventSystem.Instance.Emit(EEventName.OnExploreLevelNotify);
	}

	// Token: 0x0600C8C2 RID: 51394 RVA: 0x002DC978 File Offset: 0x002DAB78
	public void MultiExploreScoreRewardRequest(Dictionary<int, int> areaIdToProgress)
	{
		MulExploreScoreRewardRequest mulExploreScoreRewardRequest = MulExploreScoreRewardRequest.Create();
		foreach (KeyValuePair<int, int> keyValuePair in areaIdToProgress)
		{
			mulExploreScoreRewardRequest.Rewards[keyValuePair.Key] = keyValuePair.Value;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.ExploreLevel;
		ELogAuthor author = ELogAuthor.LRX;
		string message = "客户端请求请求探索进度评分奖励 ExploreScoreRewardRequest";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("request", mulExploreScoreRewardRequest);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		Net.Instance.Call(ERequestMessageId.MulExploreScoreRewardRequest, mulExploreScoreRewardRequest, new Action<IMessage, Net.CallbackStatus>(this.MultiExploreScoreRewardResponse), 0);
	}

	// Token: 0x0600C8C3 RID: 51395 RVA: 0x002DCA28 File Offset: 0x002DAC28
	[NullableContext(2)]
	private void MultiExploreScoreRewardResponse(IMessage msg, Net.CallbackStatus _)
	{
		MulExploreScoreRewardResponse mulExploreScoreRewardResponse = (MulExploreScoreRewardResponse)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.ExploreLevel;
		ELogAuthor author = ELogAuthor.LRX;
		string message = "服务端返回探索评分奖励 ExploreScoreRewardResponse";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("response", mulExploreScoreRewardResponse);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (mulExploreScoreRewardResponse.ErrorCode != ErrorCode.Success)
		{
			return;
		}
		EventSystem.Instance.Emit(EEventName.OnExploreScoreRewardResponse);
	}

	// Token: 0x0600C8C4 RID: 51396 RVA: 0x002DCA80 File Offset: 0x002DAC80
	[NullableContext(2)]
	public void CountryExploreScoreInfoRequest(int countryId, Action onResponse = null)
	{
		ExploreLevelController.<>c__DisplayClass5_0 CS$<>8__locals1 = new ExploreLevelController.<>c__DisplayClass5_0();
		CS$<>8__locals1.onResponse = onResponse;
		CS$<>8__locals1.countryId = countryId;
		CountryExploreScoreInfoRequest countryExploreScoreInfoRequest = Aki.Protocol.CountryExploreScoreInfoRequest.Create();
		countryExploreScoreInfoRequest.CountryId = CS$<>8__locals1.countryId;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.ExploreLevel;
		ELogAuthor author = ELogAuthor.LRX;
		string message = "客户端请求国家探索评分信息 CountryExploreScoreInfoRequest";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("request", countryExploreScoreInfoRequest);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		Net.Instance.Call(ERequestMessageId.CountryExploreScoreInfoRequest, countryExploreScoreInfoRequest, new Action<IMessage, Net.CallbackStatus>(CS$<>8__locals1.<CountryExploreScoreInfoRequest>g__CountryExploreScoreInfoResponse|0), 0);
	}

	// Token: 0x0600C8C5 RID: 51397 RVA: 0x002DCAFC File Offset: 0x002DACFC
	public UniTask CountryExploreScoreInfoAsyncRequest(int countryId)
	{
		ExploreLevelController.<CountryExploreScoreInfoAsyncRequest>d__6 <CountryExploreScoreInfoAsyncRequest>d__;
		<CountryExploreScoreInfoAsyncRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CountryExploreScoreInfoAsyncRequest>d__.countryId = countryId;
		<CountryExploreScoreInfoAsyncRequest>d__.<>1__state = -1;
		<CountryExploreScoreInfoAsyncRequest>d__.<>t__builder.Start<ExploreLevelController.<CountryExploreScoreInfoAsyncRequest>d__6>(ref <CountryExploreScoreInfoAsyncRequest>d__);
		return <CountryExploreScoreInfoAsyncRequest>d__.<>t__builder.Task;
	}

	// Token: 0x17001075 RID: 4213
	// (get) Token: 0x0600C8C6 RID: 51398 RVA: 0x002DCB3F File Offset: 0x002DAD3F
	public static ExploreLevelController Instance
	{
		get
		{
			return ExploreLevelController._Instance;
		}
	}

	// Token: 0x0600C8C7 RID: 51399 RVA: 0x002DCB46 File Offset: 0x002DAD46
	public static ExploreLevelController GetOrCreateInstance()
	{
		if (ExploreLevelController._Instance == null)
		{
			ExploreLevelController.CreateInstance();
		}
		return ExploreLevelController._Instance;
	}

	// Token: 0x0600C8C8 RID: 51400 RVA: 0x002DCB5A File Offset: 0x002DAD5A
	public static bool CreateInstance()
	{
		if (ExploreLevelController._Instance != null)
		{
			return true;
		}
		ExploreLevelController._Instance = new ExploreLevelController();
		return true;
	}

	// Token: 0x0600C8C9 RID: 51401 RVA: 0x002DCB70 File Offset: 0x002DAD70
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C8CA RID: 51402 RVA: 0x002DCB72 File Offset: 0x002DAD72
	public static void ResetStaticDefaultValue()
	{
		ExploreLevelController._Instance = null;
	}

	// Token: 0x0600C8CB RID: 51403 RVA: 0x002DCB7A File Offset: 0x002DAD7A
	static ExploreLevelController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreLevelController.CreateStaticDefaultValue), new Action(ExploreLevelController.ResetStaticDefaultValue));
	}

	// Token: 0x04005C7F RID: 23679
	[Nullable(2)]
	private static ExploreLevelController _Instance;
}
