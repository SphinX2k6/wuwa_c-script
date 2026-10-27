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

// Token: 0x02001A85 RID: 6789
[Controller(0)]
public class DrinksController : UiControllerBase
{
	// Token: 0x0600C841 RID: 51265 RVA: 0x002DAF7A File Offset: 0x002D917A
	public void OpenMainView(EDrinksGameplayOpenWay openWay)
	{
		UiManager.Instance.OpenView(EUiViewName.DrinksSelectRoleView, openWay, null);
	}

	// Token: 0x0600C842 RID: 51266 RVA: 0x002DAF94 File Offset: 0x002D9194
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

	// Token: 0x0600C843 RID: 51267 RVA: 0x002DAFEF File Offset: 0x002D91EF
	public void OpenPlayView()
	{
		UiManager.Instance.OpenView(EUiViewName.DrinksGameplayView, null, null);
	}

	// Token: 0x0600C844 RID: 51268 RVA: 0x002DB004 File Offset: 0x002D9204
	public UniTask<bool> RequestMixDrinkSettle()
	{
		DrinksController.<RequestMixDrinkSettle>d__3 <RequestMixDrinkSettle>d__;
		<RequestMixDrinkSettle>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestMixDrinkSettle>d__.<>4__this = this;
		<RequestMixDrinkSettle>d__.<>1__state = -1;
		<RequestMixDrinkSettle>d__.<>t__builder.Start<DrinksController.<RequestMixDrinkSettle>d__3>(ref <RequestMixDrinkSettle>d__);
		return <RequestMixDrinkSettle>d__.<>t__builder.Task;
	}

	// Token: 0x0600C845 RID: 51269 RVA: 0x002DB048 File Offset: 0x002D9248
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

	// Token: 0x0600C846 RID: 51270 RVA: 0x002DB094 File Offset: 0x002D9294
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

	// Token: 0x0600C847 RID: 51271 RVA: 0x002DB0E0 File Offset: 0x002D92E0
	public UniTask GmTestScoreCheck()
	{
		DrinksController.<GmTestScoreCheck>d__6 <GmTestScoreCheck>d__;
		<GmTestScoreCheck>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GmTestScoreCheck>d__.<>4__this = this;
		<GmTestScoreCheck>d__.<>1__state = -1;
		<GmTestScoreCheck>d__.<>t__builder.Start<DrinksController.<GmTestScoreCheck>d__6>(ref <GmTestScoreCheck>d__);
		return <GmTestScoreCheck>d__.<>t__builder.Task;
	}

	// Token: 0x0600C848 RID: 51272 RVA: 0x002DB124 File Offset: 0x002D9324
	public void GmTestCupActor(int id)
	{
		BP_Prop_GobletLiquid_C bp_Prop_GobletLiquid_C = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("Cups").Value, ECollectActorType.Default) as BP_Prop_GobletLiquid_C;
		if (bp_Prop_GobletLiquid_C == null)
		{
			return;
		}
		DrinksModel.Instance.GetSceneController().UpdateWaterById(bp_Prop_GobletLiquid_C, id, Array.Empty<int>(), 1207, false, true);
	}

	// Token: 0x0600C849 RID: 51273 RVA: 0x002DB170 File Offset: 0x002D9370
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

	// Token: 0x0600C84A RID: 51274 RVA: 0x002DB230 File Offset: 0x002D9430
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

	// Token: 0x1700106F RID: 4207
	// (get) Token: 0x0600C84B RID: 51275 RVA: 0x002DB4AC File Offset: 0x002D96AC
	[Nullable(1)]
	public static DrinksController Instance
	{
		[NullableContext(1)]
		get
		{
			return DrinksController._Instance;
		}
	}

	// Token: 0x0600C84C RID: 51276 RVA: 0x002DB4B3 File Offset: 0x002D96B3
	[NullableContext(1)]
	public static DrinksController GetOrCreateInstance()
	{
		if (DrinksController._Instance == null)
		{
			DrinksController.CreateInstance();
		}
		return DrinksController._Instance;
	}

	// Token: 0x0600C84D RID: 51277 RVA: 0x002DB4C7 File Offset: 0x002D96C7
	public static bool CreateInstance()
	{
		if (DrinksController._Instance != null)
		{
			return true;
		}
		DrinksController._Instance = new DrinksController();
		return true;
	}

	// Token: 0x0600C84E RID: 51278 RVA: 0x002DB4DD File Offset: 0x002D96DD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C84F RID: 51279 RVA: 0x002DB4DF File Offset: 0x002D96DF
	public static void ResetStaticDefaultValue()
	{
		DrinksController._Instance = null;
	}

	// Token: 0x0600C850 RID: 51280 RVA: 0x002DB4E7 File Offset: 0x002D96E7
	static DrinksController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DrinksController.CreateStaticDefaultValue), new Action(DrinksController.ResetStaticDefaultValue));
	}

	// Token: 0x04005C62 RID: 23650
	[Nullable(2)]
	private static DrinksController _Instance;
}
