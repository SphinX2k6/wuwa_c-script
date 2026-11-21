using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Sequence.Seq_BP.BPGobletLiquid;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F44 RID: 3908
[Controller(0)]
public class DrinksController : UiControllerBase
{
	// Token: 0x06009C52 RID: 40018 RVA: 0x002E6122 File Offset: 0x002E4322
	public void OpenMainView(EDrinksGameplayOpenWay openWay)
	{
		UiManager.Instance.OpenView(EUiViewName.DrinksSelectRoleView, openWay, null);
	}

	// Token: 0x06009C53 RID: 40019 RVA: 0x002E613C File Offset: 0x002E433C
	public UniTask<bool> SelectRoleAndPlaySeq(int roleId, EDrinksGameplayOpenWay openWay, int? requireId = null)
	{
		DrinksController.<SelectRoleAndPlaySeq>d__1 <SelectRoleAndPlaySeq>d__;
		<SelectRoleAndPlaySeq>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SelectRoleAndPlaySeq>d__.<>4__this = this;
		<SelectRoleAndPlaySeq>d__.roleId = roleId;
		<SelectRoleAndPlaySeq>d__.openWay = openWay;
		<SelectRoleAndPlaySeq>d__.requireId = requireId;
		<SelectRoleAndPlaySeq>d__.<>1__state = -1;
		<SelectRoleAndPlaySeq>d__.<>t__builder.Start<DrinksController.<SelectRoleAndPlaySeq>d__1>(ref <SelectRoleAndPlaySeq>d__);
		return <SelectRoleAndPlaySeq>d__.<>t__builder.Task;
	}

	// Token: 0x06009C54 RID: 40020 RVA: 0x002E6197 File Offset: 0x002E4397
	public void OpenPlayView()
	{
		UiManager.Instance.OpenView(EUiViewName.DrinksGameplayView, null, null);
	}

	// Token: 0x06009C55 RID: 40021 RVA: 0x002E61AC File Offset: 0x002E43AC
	public UniTask<bool> RequestMixDrinkSettle()
	{
		DrinksController.<RequestMixDrinkSettle>d__3 <RequestMixDrinkSettle>d__;
		<RequestMixDrinkSettle>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestMixDrinkSettle>d__.<>4__this = this;
		<RequestMixDrinkSettle>d__.<>1__state = -1;
		<RequestMixDrinkSettle>d__.<>t__builder.Start<DrinksController.<RequestMixDrinkSettle>d__3>(ref <RequestMixDrinkSettle>d__);
		return <RequestMixDrinkSettle>d__.<>t__builder.Task;
	}

	// Token: 0x06009C56 RID: 40022 RVA: 0x002E61F0 File Offset: 0x002E43F0
	public UniTask<bool> RequestMixDrinkRoleInvite(int roleId)
	{
		DrinksController.<RequestMixDrinkRoleInvite>d__4 <RequestMixDrinkRoleInvite>d__;
		<RequestMixDrinkRoleInvite>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestMixDrinkRoleInvite>d__.<>4__this = this;
		<RequestMixDrinkRoleInvite>d__.roleId = roleId;
		<RequestMixDrinkRoleInvite>d__.<>1__state = -1;
		<RequestMixDrinkRoleInvite>d__.<>t__builder.Start<DrinksController.<RequestMixDrinkRoleInvite>d__4>(ref <RequestMixDrinkRoleInvite>d__);
		return <RequestMixDrinkRoleInvite>d__.<>t__builder.Task;
	}

	// Token: 0x06009C57 RID: 40023 RVA: 0x002E623C File Offset: 0x002E443C
	public UniTask<bool> RequestMixDrinkRoleReward(int configId, int roleId)
	{
		DrinksController.<RequestMixDrinkRoleReward>d__5 <RequestMixDrinkRoleReward>d__;
		<RequestMixDrinkRoleReward>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestMixDrinkRoleReward>d__.configId = configId;
		<RequestMixDrinkRoleReward>d__.roleId = roleId;
		<RequestMixDrinkRoleReward>d__.<>1__state = -1;
		<RequestMixDrinkRoleReward>d__.<>t__builder.Start<DrinksController.<RequestMixDrinkRoleReward>d__5>(ref <RequestMixDrinkRoleReward>d__);
		return <RequestMixDrinkRoleReward>d__.<>t__builder.Task;
	}

	// Token: 0x06009C58 RID: 40024 RVA: 0x002E6288 File Offset: 0x002E4488
	public UniTask GmTestScoreCheck()
	{
		DrinksController.<GmTestScoreCheck>d__6 <GmTestScoreCheck>d__;
		<GmTestScoreCheck>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GmTestScoreCheck>d__.<>4__this = this;
		<GmTestScoreCheck>d__.<>1__state = -1;
		<GmTestScoreCheck>d__.<>t__builder.Start<DrinksController.<GmTestScoreCheck>d__6>(ref <GmTestScoreCheck>d__);
		return <GmTestScoreCheck>d__.<>t__builder.Task;
	}

	// Token: 0x06009C59 RID: 40025 RVA: 0x002E62CC File Offset: 0x002E44CC
	public void GmTestCupActor(int id)
	{
		BP_Prop_GobletLiquid_C bp_Prop_GobletLiquid_C = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("Cups").Value, ECollectActorType.Default) as BP_Prop_GobletLiquid_C;
		if (bp_Prop_GobletLiquid_C == null)
		{
			return;
		}
		DrinksModel.Instance.GetSceneController().UpdateWaterById(bp_Prop_GobletLiquid_C, id, Array.Empty<int>(), 1207, false, true);
	}

	// Token: 0x06009C5A RID: 40026 RVA: 0x002E6318 File Offset: 0x002E4518
	public void ReportDrinksGameplayInvite()
	{
		DrinksGameplayInviteLogEvent drinksGameplayInviteLogEvent = new DrinksGameplayInviteLogEvent();
		DrinksModel instance = DrinksModel.Instance;
		SpringManorData activityData = SpringManorModel.Instance.ActivityData;
		int roleId = instance.GetRoleId();
		drinksGameplayInviteLogEvent.i_activity_id = activityData.Id;
		drinksGameplayInviteLogEvent.i_role_id = roleId;
		drinksGameplayInviteLogEvent.i_inst_id = (int)instance.GameplayOpenWay;
		if (instance.GameplayIsMainQuest)
		{
			drinksGameplayInviteLogEvent.i_first_pass = 0;
		}
		else
		{
			Dictionary<int, IDrinksMixRoleInfo> drinksProgressMap = activityData.GetDrinksProgressMap();
			if (!drinksProgressMap.ContainsKey(roleId))
			{
				drinksGameplayInviteLogEvent.i_first_pass = 1;
				instance.GameplayFirstInvite = true;
			}
			else
			{
				IDrinksMixRoleInfo drinksMixRoleInfo;
				drinksProgressMap.TryGetValue(roleId, out drinksMixRoleInfo);
				drinksGameplayInviteLogEvent.i_first_pass = (drinksMixRoleInfo.FirstPass ? 3 : 2);
				instance.GameplayFirstInvite = false;
			}
		}
		drinksGameplayInviteLogEvent.s_trace_id = instance.GameplayStamp.ToString();
		LogReportController.Instance.LogReport(drinksGameplayInviteLogEvent);
	}

	// Token: 0x06009C5B RID: 40027 RVA: 0x002E63D8 File Offset: 0x002E45D8
	public void ReportDrinksGameplayResult()
	{
		DrinksGameplayResultLogEvent drinksGameplayResultLogEvent = new DrinksGameplayResultLogEvent();
		DrinksModel instance = DrinksModel.Instance;
		SpringManorData activityData = SpringManorModel.Instance.ActivityData;
		int roleId = instance.GetRoleId();
		DrinksResultInfo currentPlayData = instance.GetCurrentPlayData();
		drinksGameplayResultLogEvent.i_activity_id = activityData.Id;
		drinksGameplayResultLogEvent.i_role_id = roleId;
		drinksGameplayResultLogEvent.i_inst_id = (int)instance.GameplayOpenWay;
		Dictionary<int, IDrinksMixRoleInfo> drinksProgressMap = activityData.GetDrinksProgressMap();
		ValueTuple<int, List<IDrinksRequireInfo>> roleState = instance.GetRoleState();
		int item = roleState.Item1;
		List<IDrinksRequireInfo> item2 = roleState.Item2;
		int likenessMax = instance.GetLikenessMax();
		if (instance.GameplayIsMainQuest)
		{
			drinksGameplayResultLogEvent.i_first_pass = 0;
		}
		else if (instance.GameplayFirstInvite)
		{
			drinksGameplayResultLogEvent.i_first_pass = 1;
		}
		else
		{
			IDrinksMixRoleInfo drinksMixRoleInfo;
			drinksProgressMap.TryGetValue(roleId, out drinksMixRoleInfo);
			drinksGameplayResultLogEvent.i_first_pass = (drinksMixRoleInfo.FirstPass ? 3 : 2);
		}
		if (item <= 0)
		{
			drinksGameplayResultLogEvent.i_result = 1;
		}
		else
		{
			drinksGameplayResultLogEvent.i_result = ((item >= likenessMax) ? 3 : 2);
		}
		DrinksDrinkBase? drinkBase = DrinksConfig.Instance.GetDrinkBase(currentPlayData.DrinkBase[0]);
		drinksGameplayResultLogEvent.i_first_tab = drinkBase.Value.DrinkId;
		drinksGameplayResultLogEvent.i_first_count = drinkBase.Value.QTENum;
		DrinksDrinkBase? drinkBase2 = DrinksConfig.Instance.GetDrinkBase(currentPlayData.DrinkBase[1]);
		drinksGameplayResultLogEvent.i_second_tab = drinkBase2.Value.DrinkId;
		drinksGameplayResultLogEvent.i_second_count = drinkBase2.Value.QTENum;
		drinksGameplayResultLogEvent.i_third_tab = ((currentPlayData.Batching != null && currentPlayData.Batching.Count > 0) ? currentPlayData.Batching[0] : -1);
		drinksGameplayResultLogEvent.i_fourth_tab = ((currentPlayData.Batching != null && currentPlayData.Batching.Count > 1) ? currentPlayData.Batching[1] : -1);
		drinksGameplayResultLogEvent.i_fifth_tab = ((currentPlayData.Ornament == 0) ? -1 : currentPlayData.Ornament);
		drinksGameplayResultLogEvent.i_cost_time = (int)((TimeUtil.Instance.GetServerTimeStamp() - instance.GameplayStamp) * TimeUtil.Instance.Millisecond);
		drinksGameplayResultLogEvent.i_require_id = currentPlayData.RequireId;
		drinksGameplayResultLogEvent.o_score_buff = new List<int>();
		foreach (IDrinksRequireInfo drinksRequireInfo in item2)
		{
			drinksGameplayResultLogEvent.o_score_buff.Add((drinksRequireInfo.Completed > false) ? 1 : 0);
		}
		drinksGameplayResultLogEvent.s_trace_id = instance.GameplayStamp.ToString();
		LogReportController.Instance.LogReport(drinksGameplayResultLogEvent);
	}

	// Token: 0x17001094 RID: 4244
	// (get) Token: 0x06009C5C RID: 40028 RVA: 0x002E6654 File Offset: 0x002E4854
	[Nullable(1)]
	public static DrinksController Instance
	{
		[NullableContext(1)]
		get
		{
			return DrinksController._Instance;
		}
	}

	// Token: 0x06009C5D RID: 40029 RVA: 0x002E665B File Offset: 0x002E485B
	[NullableContext(1)]
	public static DrinksController GetOrCreateInstance()
	{
		if (DrinksController._Instance == null)
		{
			DrinksController.CreateInstance();
		}
		return DrinksController._Instance;
	}

	// Token: 0x06009C5E RID: 40030 RVA: 0x002E666F File Offset: 0x002E486F
	public static bool CreateInstance()
	{
		if (DrinksController._Instance != null)
		{
			return true;
		}
		DrinksController._Instance = new DrinksController();
		return true;
	}

	// Token: 0x06009C5F RID: 40031 RVA: 0x002E6685 File Offset: 0x002E4885
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009C60 RID: 40032 RVA: 0x002E6687 File Offset: 0x002E4887
	public static void ResetStaticDefaultValue()
	{
		DrinksController._Instance = null;
	}

	// Token: 0x06009C61 RID: 40033 RVA: 0x002E668F File Offset: 0x002E488F
	static DrinksController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DrinksController.CreateStaticDefaultValue), new Action(DrinksController.ResetStaticDefaultValue));
	}

	// Token: 0x04005D31 RID: 23857
	[Nullable(2)]
	private static DrinksController _Instance;
}
