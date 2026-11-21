using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02000F50 RID: 3920
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ExploreLevelController : UiControllerBase
{
	// Token: 0x06009CD0 RID: 40144 RVA: 0x002E79D8 File Offset: 0x002E5BD8
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ExploreLevelNotify, new Action<IMessage, Net.CallbackStatus>(this.ExploreLevelNotify));
	}

	// Token: 0x06009CD1 RID: 40145 RVA: 0x002E79F6 File Offset: 0x002E5BF6
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ExploreLevelNotify);
	}

	// Token: 0x06009CD2 RID: 40146 RVA: 0x002E7A08 File Offset: 0x002E5C08
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

	// Token: 0x06009CD3 RID: 40147 RVA: 0x002E7AAC File Offset: 0x002E5CAC
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

	// Token: 0x06009CD4 RID: 40148 RVA: 0x002E7B5C File Offset: 0x002E5D5C
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

	// Token: 0x06009CD5 RID: 40149 RVA: 0x002E7BB4 File Offset: 0x002E5DB4
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

	// Token: 0x06009CD6 RID: 40150 RVA: 0x002E7C30 File Offset: 0x002E5E30
	public UniTask CountryExploreScoreInfoAsyncRequest(int countryId)
	{
		ExploreLevelController.<CountryExploreScoreInfoAsyncRequest>d__6 <CountryExploreScoreInfoAsyncRequest>d__;
		<CountryExploreScoreInfoAsyncRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CountryExploreScoreInfoAsyncRequest>d__.countryId = countryId;
		<CountryExploreScoreInfoAsyncRequest>d__.<>1__state = -1;
		<CountryExploreScoreInfoAsyncRequest>d__.<>t__builder.Start<ExploreLevelController.<CountryExploreScoreInfoAsyncRequest>d__6>(ref <CountryExploreScoreInfoAsyncRequest>d__);
		return <CountryExploreScoreInfoAsyncRequest>d__.<>t__builder.Task;
	}

	// Token: 0x1700109A RID: 4250
	// (get) Token: 0x06009CD7 RID: 40151 RVA: 0x002E7C73 File Offset: 0x002E5E73
	public static ExploreLevelController Instance
	{
		get
		{
			return ExploreLevelController._Instance;
		}
	}

	// Token: 0x06009CD8 RID: 40152 RVA: 0x002E7C7A File Offset: 0x002E5E7A
	public static ExploreLevelController GetOrCreateInstance()
	{
		if (ExploreLevelController._Instance == null)
		{
			ExploreLevelController.CreateInstance();
		}
		return ExploreLevelController._Instance;
	}

	// Token: 0x06009CD9 RID: 40153 RVA: 0x002E7C8E File Offset: 0x002E5E8E
	public static bool CreateInstance()
	{
		if (ExploreLevelController._Instance != null)
		{
			return true;
		}
		ExploreLevelController._Instance = new ExploreLevelController();
		return true;
	}

	// Token: 0x06009CDA RID: 40154 RVA: 0x002E7CA4 File Offset: 0x002E5EA4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009CDB RID: 40155 RVA: 0x002E7CA6 File Offset: 0x002E5EA6
	public static void ResetStaticDefaultValue()
	{
		ExploreLevelController._Instance = null;
	}

	// Token: 0x06009CDC RID: 40156 RVA: 0x002E7CAE File Offset: 0x002E5EAE
	static ExploreLevelController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreLevelController.CreateStaticDefaultValue), new Action(ExploreLevelController.ResetStaticDefaultValue));
	}

	// Token: 0x04005D4E RID: 23886
	[Nullable(2)]
	private static ExploreLevelController _Instance;
}
