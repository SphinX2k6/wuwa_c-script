using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002E3 RID: 739
[NullableContext(1)]
[Nullable(0)]
public class KuroSdkReport : Singleton
{
	// Token: 0x06002AE4 RID: 10980 RVA: 0x00103327 File Offset: 0x00101527
	public void Init()
	{
		this.AddEvent();
	}

	// Token: 0x06002AE5 RID: 10981 RVA: 0x0010332F File Offset: 0x0010152F
	public void Report(SdkReportData data)
	{
		HotPatchKuroSdk.Instance.ReportEvent(data);
	}

	// Token: 0x06002AE6 RID: 10982 RVA: 0x0010333C File Offset: 0x0010153C
	private void AddEvent()
	{
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Add<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus, ENodeStatusUpdateReason>(EEventName.OnLogicTreeChildQuestNodeStatusChange, new Action<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus, ENodeStatusUpdateReason>(this.OnChildQuestNodeStatusChange));
		EventSystem.Instance.Add(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x06002AE7 RID: 10983 RVA: 0x001033A0 File Offset: 0x001015A0
	public void OnPlayerLevelChange(int level)
	{
		if (SdkReportLevel.IfNeedReport(level))
		{
			SdkReportLevel data = new SdkReportLevel(null)
			{
				Level = level
			};
			this.Report(data);
		}
	}

	// Token: 0x06002AE8 RID: 10984 RVA: 0x001033CC File Offset: 0x001015CC
	public void OnPlotFinish(FlowContext context)
	{
		if (SdkReportStartFlow.IfNeedReport(context.FlowId, context.FlowStateId))
		{
			SdkReportStartFlow data = new SdkReportStartFlow(null)
			{
				FlowId = context.FlowId
			};
			this.Report(data);
		}
	}

	// Token: 0x06002AE9 RID: 10985 RVA: 0x00103408 File Offset: 0x00101608
	public void OnSdkPay()
	{
		SdkReportPay data = new SdkReportPay(null);
		this.Report(data);
	}

	// Token: 0x06002AEA RID: 10986 RVA: 0x00103424 File Offset: 0x00101624
	public void OnPayShopDirectBuy(int shopItemId)
	{
		if (SdkReportDirectBuy.IfNeedReport(shopItemId))
		{
			SdkReportDirectBuy data = new SdkReportDirectBuy(null)
			{
				PayItemId = shopItemId
			};
			this.Report(data);
		}
	}

	// Token: 0x06002AEB RID: 10987 RVA: 0x0010344E File Offset: 0x0010164E
	public void OnChapterStart(int chapterId, int chapterState)
	{
	}

	// Token: 0x06002AEC RID: 10988 RVA: 0x00103450 File Offset: 0x00101650
	private void OnPayItemSuccess(PayItemSuccess payItem)
	{
		if (SdkReportRecharge.IfNeedReport(payItem.PayItemId))
		{
			SdkReportRecharge data = new SdkReportRecharge(null)
			{
				PayItemId = payItem.PayItemId
			};
			this.Report(data);
		}
	}

	// Token: 0x06002AED RID: 10989 RVA: 0x00103484 File Offset: 0x00101684
	private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason _)
	{
		if (SdkReportQuestFinish.IfNeedReport(questId))
		{
			SdkReportQuestFinish data = new SdkReportQuestFinish(null)
			{
				QuestId = questId
			};
			this.Report(data);
		}
		if (SdkReportChapter.IfNeedReport(questId, 0) && state == QuestState.Finish)
		{
			SdkReportChapter data2 = new SdkReportChapter(null)
			{
				TreeConfigId = questId
			};
			this.Report(data2);
		}
	}

	// Token: 0x06002AEE RID: 10990 RVA: 0x001034D0 File Offset: 0x001016D0
	private void OnChildQuestNodeStatusChange(GeneralContext context, ChildQuestNodeStatus oldStatus, ChildQuestNodeStatus newStatus, ENodeStatusUpdateReason _)
	{
		if (context.Type.GetValueOrDefault() != EGeneralContextType.GeneralLogicTree)
		{
			return;
		}
		GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
		int? num = (generalLogicTreeContext != null) ? new int?(generalLogicTreeContext.TreeConfigId) : null;
		GeneralLogicTreeContext generalLogicTreeContext2 = context as GeneralLogicTreeContext;
		int? num2 = (generalLogicTreeContext2 != null) ? new int?(generalLogicTreeContext2.NodeId) : null;
		if (num == null || num2 == null)
		{
			return;
		}
		if (SdkReportBattleTech.IfNeedReport(num.Value, num2.Value) && newStatus == ChildQuestNodeStatus.CqnsFinished)
		{
			this.Report(new SdkReportBattleTech(null)
			{
				TreeConfigId = num.Value,
				NodeId = num2.Value
			});
		}
	}

	// Token: 0x06002AEF RID: 10991 RVA: 0x00103580 File Offset: 0x00101780
	public void OnGachaResult(int gachaId, IReadOnlyList<Aki.Protocol.GachaResult> message)
	{
		if (gachaId == 0)
		{
			return;
		}
		GachaPoolData gachaPoolData = Array.Find<GachaPoolData>(GachaModel.Instance.GetValidGachaList(), (GachaPoolData value) => value.GachaInfo.Id == gachaId);
		if (gachaPoolData == null)
		{
			return;
		}
		if (GachaConfig.Instance.GetGachaViewInfo(gachaPoolData.PoolInfo.Id) != null)
		{
			GachaViewInfo? gachaViewInfo;
			int type = gachaViewInfo.GetValueOrDefault().Type;
		}
		GachaDefine.EGachaViewType? egachaViewType = null;
		if (egachaViewType.GetValueOrDefault() != GachaDefine.EGachaViewType.RoleUp && egachaViewType.GetValueOrDefault() != GachaDefine.EGachaViewType.RoleCommon)
		{
			return;
		}
		Dictionary<string, int> dictionary = LocalStorage.GetPlayer<Dictionary<string, int>>(ELocalStoragePlayerKey.SdkReportStateMap, null);
		if (dictionary != null)
		{
			int num;
			if (egachaViewType.GetValueOrDefault() == GachaDefine.EGachaViewType.RoleUp && dictionary.TryGetValue("HIGHGACHAPOOLREPORTSTATEKEY", out num) && num == 1)
			{
				return;
			}
			int num2;
			if (egachaViewType.GetValueOrDefault() == GachaDefine.EGachaViewType.RoleCommon && dictionary.TryGetValue("NORMALGACHAPOOLREPORTSTATEKEY", out num2) && num2 == 1)
			{
				return;
			}
		}
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, int>();
		}
		foreach (Aki.Protocol.GachaResult gachaResult in message)
		{
			GachaReward gachaReward = gachaResult.GachaReward;
			int? num3 = (gachaReward != null) ? new int?(gachaReward.ItemId) : null;
			RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(num3.Value);
			if (roleInfoById != null && roleInfoById.Value.QualityId >= 5)
			{
				if (egachaViewType.GetValueOrDefault() == GachaDefine.EGachaViewType.RoleUp)
				{
					SdkReportFirstUpFiveStarHero data = new SdkReportFirstUpFiveStarHero(null);
					this.Report(data);
					dictionary["HIGHGACHAPOOLREPORTSTATEKEY"] = 1;
					LocalStorage.SetPlayer<Dictionary<string, int>>(ELocalStoragePlayerKey.SdkReportStateMap, dictionary);
					break;
				}
				if (egachaViewType.GetValueOrDefault() == GachaDefine.EGachaViewType.RoleCommon)
				{
					SdkReportFirstNormalFiveStarHero data2 = new SdkReportFirstNormalFiveStarHero(null);
					this.Report(data2);
					dictionary["NORMALGACHAPOOLREPORTSTATEKEY"] = 1;
					LocalStorage.SetPlayer<Dictionary<string, int>>(ELocalStoragePlayerKey.SdkReportStateMap, dictionary);
					break;
				}
			}
		}
	}

	// Token: 0x06002AF0 RID: 10992 RVA: 0x00103764 File Offset: 0x00101964
	public void OnRougeFinish()
	{
		Dictionary<string, int> dictionary = LocalStorage.GetPlayer<Dictionary<string, int>>(ELocalStoragePlayerKey.SdkReportStateMap, null);
		int num;
		if (dictionary != null && dictionary.TryGetValue("ROUGEFINISHSTATEKEY", out num) && num == 1)
		{
			return;
		}
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, int>();
		}
		SdkReportGetRougeLevel60 data = new SdkReportGetRougeLevel60(null);
		this.Report(data);
		dictionary["ROUGEFINISHSTATEKEY"] = 1;
		LocalStorage.SetPlayer<Dictionary<string, int>>(ELocalStoragePlayerKey.SdkReportStateMap, dictionary);
	}

	// Token: 0x17000673 RID: 1651
	// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x001037C3 File Offset: 0x001019C3
	public static KuroSdkReport Instance
	{
		get
		{
			if (KuroSdkReport._instance == null)
			{
				KuroSdkReport._instance = new KuroSdkReport();
				KuroSdkReport._instance.OnInit();
			}
			return KuroSdkReport._instance;
		}
	}

	// Token: 0x06002AF2 RID: 10994 RVA: 0x001037E6 File Offset: 0x001019E6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06002AF3 RID: 10995 RVA: 0x001037E8 File Offset: 0x001019E8
	public static void ResetStaticDefaultValue()
	{
		KuroSdkReport instance = KuroSdkReport._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		KuroSdkReport._instance = null;
	}

	// Token: 0x06002AF4 RID: 10996 RVA: 0x00103801 File Offset: 0x00101A01
	static KuroSdkReport()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroSdkReport.CreateStaticDefaultValue), new Action(KuroSdkReport.ResetStaticDefaultValue));
	}

	// Token: 0x040028D2 RID: 10450
	private const int KILLPHANTOMMISSION = 139000025;

	// Token: 0x040028D3 RID: 10451
	private const int CAPTUREPHANTOMMISSION = 139000026;

	// Token: 0x040028D4 RID: 10452
	private const int CHAPTERCPRE1 = 139000025;

	// Token: 0x040028D5 RID: 10453
	private const int CHAPTERCPRE2 = 139000026;

	// Token: 0x040028D6 RID: 10454
	private const int CHAPTERC11 = 139000027;

	// Token: 0x040028D7 RID: 10455
	private const int CHAPTERC12 = 139000029;

	// Token: 0x040028D8 RID: 10456
	private const int CHAPTERC13 = 139000030;

	// Token: 0x040028D9 RID: 10457
	private const int CHAPTERC14 = 139000031;

	// Token: 0x040028DA RID: 10458
	private const int CHAPTERC15 = 114000020;

	// Token: 0x040028DB RID: 10459
	private const int CHAPTERC16 = 140000004;

	// Token: 0x040028DC RID: 10460
	private const int KILLPHANTOMSTEP1 = 6;

	// Token: 0x040028DD RID: 10461
	private const int KILLPHANTOMSTEP2 = 10;

	// Token: 0x040028DE RID: 10462
	private const int KILLPHANTOMSTEP3 = 91;

	// Token: 0x040028DF RID: 10463
	private const int KILLPHANTOMSTEP4 = 132;

	// Token: 0x040028E0 RID: 10464
	private const int GOJINZHOU = 16;

	// Token: 0x040028E1 RID: 10465
	private const int STARTFLOW = 1;

	// Token: 0x040028E2 RID: 10466
	private const int STARTSTATE = 1;

	// Token: 0x040028E3 RID: 10467
	private const int RECHARGEONE = 1;

	// Token: 0x040028E4 RID: 10468
	private const int RECHARGETWO = 2;

	// Token: 0x040028E5 RID: 10469
	private const int RECHARGETHREE = 3;

	// Token: 0x040028E6 RID: 10470
	private const int RECHARGEFOUR = 4;

	// Token: 0x040028E7 RID: 10471
	private const int RECHARGEFIVE = 5;

	// Token: 0x040028E8 RID: 10472
	private const int RECHARGESIX = 6;

	// Token: 0x040028E9 RID: 10473
	private const int REPORTLEVEL8 = 8;

	// Token: 0x040028EA RID: 10474
	private const int REPORTLEVEL10 = 10;

	// Token: 0x040028EB RID: 10475
	private const int REPORTLEVEL12 = 12;

	// Token: 0x040028EC RID: 10476
	private const int REPORTLEVEL15 = 15;

	// Token: 0x040028ED RID: 10477
	private const int REPORTLEVEL20 = 20;

	// Token: 0x040028EE RID: 10478
	private const int REPORTLEVEL25 = 25;

	// Token: 0x040028EF RID: 10479
	private const int REPORTLEVEL30 = 30;

	// Token: 0x040028F0 RID: 10480
	private const int REPORTLEVEL35 = 35;

	// Token: 0x040028F1 RID: 10481
	private const int REPORTLEVEL40 = 40;

	// Token: 0x040028F2 RID: 10482
	private const int REPORTLEVEL45 = 45;

	// Token: 0x040028F3 RID: 10483
	private const string CREATEROLEEVENTID = "101104";

	// Token: 0x040028F4 RID: 10484
	private const string BATTLEEVENTID = "101803";

	// Token: 0x040028F5 RID: 10485
	private const string QUESTEVENTID = "101805";

	// Token: 0x040028F6 RID: 10486
	private const string FLOWEVENTID = "123000";

	// Token: 0x040028F7 RID: 10487
	private const string NORMALGACHAPOOLREPORTSTATEKEY = "NORMALGACHAPOOLREPORTSTATEKEY";

	// Token: 0x040028F8 RID: 10488
	private const string HIGHGACHAPOOLREPORTSTATEKEY = "HIGHGACHAPOOLREPORTSTATEKEY";

	// Token: 0x040028F9 RID: 10489
	private const string ROUGEFINISHSTATEKEY = "ROUGEFINISHSTATEKEY";

	// Token: 0x040028FA RID: 10490
	[Nullable(2)]
	private static KuroSdkReport _instance;
}
