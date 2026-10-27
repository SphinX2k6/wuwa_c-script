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

// Token: 0x02000E2E RID: 3630
[NullableContext(1)]
[Nullable(0)]
public class KuroSdkReport : Singleton
{
	// Token: 0x06005754 RID: 22356 RVA: 0x000FBAF3 File Offset: 0x000F9CF3
	public void Init()
	{
		this.AddEvent();
	}

	// Token: 0x06005755 RID: 22357 RVA: 0x000FBAFB File Offset: 0x000F9CFB
	public void Report(SdkReportData data)
	{
		HotPatchKuroSdk.Instance.ReportEvent(data);
	}

	// Token: 0x06005756 RID: 22358 RVA: 0x000FBB08 File Offset: 0x000F9D08
	private void AddEvent()
	{
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Add<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus, ENodeStatusUpdateReason>(EEventName.OnLogicTreeChildQuestNodeStatusChange, new Action<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus, ENodeStatusUpdateReason>(this.OnChildQuestNodeStatusChange));
		EventSystem.Instance.Add(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x06005757 RID: 22359 RVA: 0x000FBB6C File Offset: 0x000F9D6C
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

	// Token: 0x06005758 RID: 22360 RVA: 0x000FBB98 File Offset: 0x000F9D98
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

	// Token: 0x06005759 RID: 22361 RVA: 0x000FBBD4 File Offset: 0x000F9DD4
	public void OnSdkPay()
	{
		SdkReportPay data = new SdkReportPay(null);
		this.Report(data);
	}

	// Token: 0x0600575A RID: 22362 RVA: 0x000FBBF0 File Offset: 0x000F9DF0
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

	// Token: 0x0600575B RID: 22363 RVA: 0x000FBC1A File Offset: 0x000F9E1A
	public void OnChapterStart(int chapterId, int chapterState)
	{
	}

	// Token: 0x0600575C RID: 22364 RVA: 0x000FBC1C File Offset: 0x000F9E1C
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

	// Token: 0x0600575D RID: 22365 RVA: 0x000FBC50 File Offset: 0x000F9E50
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

	// Token: 0x0600575E RID: 22366 RVA: 0x000FBC9C File Offset: 0x000F9E9C
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

	// Token: 0x0600575F RID: 22367 RVA: 0x000FBD4C File Offset: 0x000F9F4C
	public void OnGachaResult(int gachaId, Aki.Protocol.GachaResult[] message)
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
		for (int i = 0; i < message.Length; i++)
		{
			GachaReward gachaReward = message[i].GachaReward;
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
					return;
				}
				if (egachaViewType.GetValueOrDefault() == GachaDefine.EGachaViewType.RoleCommon)
				{
					SdkReportFirstNormalFiveStarHero data2 = new SdkReportFirstNormalFiveStarHero(null);
					this.Report(data2);
					dictionary["NORMALGACHAPOOLREPORTSTATEKEY"] = 1;
					LocalStorage.SetPlayer<Dictionary<string, int>>(ELocalStoragePlayerKey.SdkReportStateMap, dictionary);
					return;
				}
			}
		}
	}

	// Token: 0x06005760 RID: 22368 RVA: 0x000FBF10 File Offset: 0x000FA110
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

	// Token: 0x1700064F RID: 1615
	// (get) Token: 0x06005761 RID: 22369 RVA: 0x000FBF6F File Offset: 0x000FA16F
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

	// Token: 0x06005762 RID: 22370 RVA: 0x000FBF92 File Offset: 0x000FA192
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005763 RID: 22371 RVA: 0x000FBF94 File Offset: 0x000FA194
	public static void ResetStaticDefaultValue()
	{
		KuroSdkReport instance = KuroSdkReport._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		KuroSdkReport._instance = null;
	}

	// Token: 0x06005764 RID: 22372 RVA: 0x000FBFAD File Offset: 0x000FA1AD
	static KuroSdkReport()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroSdkReport.CreateStaticDefaultValue), new Action(KuroSdkReport.ResetStaticDefaultValue));
	}

	// Token: 0x04002839 RID: 10297
	private const int KILLPHANTOMMISSION = 139000025;

	// Token: 0x0400283A RID: 10298
	private const int CAPTUREPHANTOMMISSION = 139000026;

	// Token: 0x0400283B RID: 10299
	private const int CHAPTERCPRE1 = 139000025;

	// Token: 0x0400283C RID: 10300
	private const int CHAPTERCPRE2 = 139000026;

	// Token: 0x0400283D RID: 10301
	private const int CHAPTERC11 = 139000027;

	// Token: 0x0400283E RID: 10302
	private const int CHAPTERC12 = 139000029;

	// Token: 0x0400283F RID: 10303
	private const int CHAPTERC13 = 139000030;

	// Token: 0x04002840 RID: 10304
	private const int CHAPTERC14 = 139000031;

	// Token: 0x04002841 RID: 10305
	private const int CHAPTERC15 = 114000020;

	// Token: 0x04002842 RID: 10306
	private const int CHAPTERC16 = 140000004;

	// Token: 0x04002843 RID: 10307
	private const int KILLPHANTOMSTEP1 = 6;

	// Token: 0x04002844 RID: 10308
	private const int KILLPHANTOMSTEP2 = 10;

	// Token: 0x04002845 RID: 10309
	private const int KILLPHANTOMSTEP3 = 91;

	// Token: 0x04002846 RID: 10310
	private const int KILLPHANTOMSTEP4 = 132;

	// Token: 0x04002847 RID: 10311
	private const int GOJINZHOU = 16;

	// Token: 0x04002848 RID: 10312
	private const int STARTFLOW = 1;

	// Token: 0x04002849 RID: 10313
	private const int STARTSTATE = 1;

	// Token: 0x0400284A RID: 10314
	private const int RECHARGEONE = 1;

	// Token: 0x0400284B RID: 10315
	private const int RECHARGETWO = 2;

	// Token: 0x0400284C RID: 10316
	private const int RECHARGETHREE = 3;

	// Token: 0x0400284D RID: 10317
	private const int RECHARGEFOUR = 4;

	// Token: 0x0400284E RID: 10318
	private const int RECHARGEFIVE = 5;

	// Token: 0x0400284F RID: 10319
	private const int RECHARGESIX = 6;

	// Token: 0x04002850 RID: 10320
	private const int REPORTLEVEL8 = 8;

	// Token: 0x04002851 RID: 10321
	private const int REPORTLEVEL10 = 10;

	// Token: 0x04002852 RID: 10322
	private const int REPORTLEVEL12 = 12;

	// Token: 0x04002853 RID: 10323
	private const int REPORTLEVEL15 = 15;

	// Token: 0x04002854 RID: 10324
	private const int REPORTLEVEL20 = 20;

	// Token: 0x04002855 RID: 10325
	private const int REPORTLEVEL25 = 25;

	// Token: 0x04002856 RID: 10326
	private const int REPORTLEVEL30 = 30;

	// Token: 0x04002857 RID: 10327
	private const int REPORTLEVEL35 = 35;

	// Token: 0x04002858 RID: 10328
	private const int REPORTLEVEL40 = 40;

	// Token: 0x04002859 RID: 10329
	private const int REPORTLEVEL45 = 45;

	// Token: 0x0400285A RID: 10330
	private const string CREATEROLEEVENTID = "101104";

	// Token: 0x0400285B RID: 10331
	private const string BATTLEEVENTID = "101803";

	// Token: 0x0400285C RID: 10332
	private const string QUESTEVENTID = "101805";

	// Token: 0x0400285D RID: 10333
	private const string FLOWEVENTID = "123000";

	// Token: 0x0400285E RID: 10334
	private const string NORMALGACHAPOOLREPORTSTATEKEY = "NORMALGACHAPOOLREPORTSTATEKEY";

	// Token: 0x0400285F RID: 10335
	private const string HIGHGACHAPOOLREPORTSTATEKEY = "HIGHGACHAPOOLREPORTSTATEKEY";

	// Token: 0x04002860 RID: 10336
	private const string ROUGEFINISHSTATEKEY = "ROUGEFINISHSTATEKEY";

	// Token: 0x04002861 RID: 10337
	[Nullable(2)]
	private static KuroSdkReport _instance;
}
