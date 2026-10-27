using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F86 RID: 24454
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class TotalTopUpController : ActivityControllerBase
	{
		// Token: 0x0603E0EB RID: 254187 RVA: 0x00EFB60C File Offset: 0x00EF980C
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.TotalTopUpActivityInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTotalTopUpUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.TotalTopUpRewardNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRewardNotify));
		}

		// Token: 0x0603E0EC RID: 254188 RVA: 0x00EFB646 File Offset: 0x00EF9846
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.TotalTopUpActivityInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.TotalTopUpRewardNotify);
		}

		// Token: 0x0603E0ED RID: 254189 RVA: 0x00EFB668 File Offset: 0x00EF9868
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnViewDone, new Action<EUiViewName, UiViewBase>(this.OnShopViewOpen));
		}

		// Token: 0x0603E0EE RID: 254190 RVA: 0x00EFB683 File Offset: 0x00EF9883
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnViewDone, new Action<EUiViewName, UiViewBase>(this.OnShopViewOpen));
		}

		// Token: 0x0603E0EF RID: 254191 RVA: 0x00EFB6A0 File Offset: 0x00EF98A0
		private void OnShopViewOpen(EUiViewName viewName, UiViewBase viewBase)
		{
			if (viewName != EUiViewName.PayShopRootView)
			{
				return;
			}
			TotalTopUpData singleActivityData = this.GetSingleActivityData();
			if (singleActivityData == null)
			{
				return;
			}
			singleActivityData.HasRequestedScoreInfo = false;
			TotalTopUpUtil.Debug("商店界面关闭，重置积分信息请求状态", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603E0F0 RID: 254192 RVA: 0x00EFB6E0 File Offset: 0x00EF98E0
		[NullableContext(2)]
		public TotalTopUpData GetSingleActivityData()
		{
			int type = 83;
			List<ActivityBaseData> activitiesByType = ActivityModel.Instance.GetActivitiesByType(type);
			if (activitiesByType == null || activitiesByType.Count <= 0)
			{
				return null;
			}
			if (activitiesByType.Count > 1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityTotalTopUp;
				ELogAuthor author = ELogAuthor.TZJ;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
				defaultInterpolatedStringHandler.AppendLiteral("multiple data found: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(activitiesByType.Count);
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			ActivityBaseData activityBaseData = activitiesByType[0];
			if (activityBaseData == null)
			{
				return null;
			}
			if (!activityBaseData.CheckIfInOpenTime())
			{
				return null;
			}
			return activityBaseData as TotalTopUpData;
		}

		// Token: 0x0603E0F1 RID: 254193 RVA: 0x00EFB778 File Offset: 0x00EF9978
		[NullableContext(2)]
		private void OnTotalTopUpUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			TotalTopUpActivityInfoNotify totalTopUpActivityInfoNotify = (TotalTopUpActivityInfoNotify)msg;
			TotalTopUpUtil.Debug("收到Activity Info Notify", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (totalTopUpActivityInfoNotify.TotalTopUpActivityInfo == null)
			{
				return;
			}
			TotalTopUpData singleActivityData = this.GetSingleActivityData();
			if (singleActivityData == null)
			{
				return;
			}
			singleActivityData.InitData(totalTopUpActivityInfoNotify.TotalTopUpActivityInfo, singleActivityData.Id);
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, singleActivityData.Id);
		}

		// Token: 0x0603E0F2 RID: 254194 RVA: 0x00EFB7DC File Offset: 0x00EF99DC
		[NullableContext(2)]
		private void OnRewardNotify(IMessage msg, Net.CallbackStatus status)
		{
			TotalTopUpRewardNotify totalTopUpRewardNotify = (TotalTopUpRewardNotify)msg;
			List<int> list = new List<int>();
			foreach (TotalTopUpRewardInfo totalTopUpRewardInfo in totalTopUpRewardNotify.TotalTopUpRewardInfo)
			{
				list.Add(totalTopUpRewardInfo.Id);
			}
			string message = "收到奖励通知";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RewardId", string.Join<int>(",", list));
			TotalTopUpUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			TotalTopUpData singleActivityData = this.GetSingleActivityData();
			if (singleActivityData == null)
			{
				return;
			}
			singleActivityData.UpdateReward(totalTopUpRewardNotify.TotalTopUpRewardInfo.ToList<TotalTopUpRewardInfo>());
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, singleActivityData.Id);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, singleActivityData.Id);
		}

		// Token: 0x0603E0F3 RID: 254195 RVA: 0x00EFB8B4 File Offset: 0x00EF9AB4
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603E0F4 RID: 254196 RVA: 0x00EFB8B6 File Offset: 0x00EF9AB6
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			if (!this.IsActivity37View(data))
			{
				return "UiView_CumulativeRechargeMain";
			}
			return "UiItem_CumulativeRecharge37Main";
		}

		// Token: 0x0603E0F5 RID: 254197 RVA: 0x00EFB8CC File Offset: 0x00EF9ACC
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			if (!this.IsActivity37View(data))
			{
				return new TotalTopUpView();
			}
			return new TotalTopUp37View();
		}

		// Token: 0x0603E0F6 RID: 254198 RVA: 0x00EFB8E4 File Offset: 0x00EF9AE4
		private bool IsActivity37View(ActivityBaseData data)
		{
			TotalTopUpConfig instance = TotalTopUpConfig.Instance;
			TotalTopUpViewConfig? totalTopUpViewConfig = (instance != null) ? instance.GetViewConfigByActivityId(data.Id) : null;
			return totalTopUpViewConfig != null && totalTopUpViewConfig.GetValueOrDefault().ViewType == 1;
		}

		// Token: 0x0603E0F7 RID: 254199 RVA: 0x00EFB930 File Offset: 0x00EF9B30
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			TotalTopUpData totalTopUpData = new TotalTopUpData();
			if (data.TotalTopUpActivityInfo != null)
			{
				totalTopUpData.InitData(data.TotalTopUpActivityInfo, data.Id);
			}
			return totalTopUpData;
		}

		// Token: 0x0603E0F8 RID: 254200 RVA: 0x00EFB95E File Offset: 0x00EF9B5E
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.TotalTopUpPickRoleRewardView);
			TotalTopUpPickRoleViewModel totalTopUpPickRoleViewModel = ((viewByName != null) ? viewByName.OpenParam : null) as TotalTopUpPickRoleViewModel;
			return totalTopUpPickRoleViewModel != null && totalTopUpPickRoleViewModel.IsFromActivity;
		}

		// Token: 0x0603E0F9 RID: 254201 RVA: 0x00EFB98C File Offset: 0x00EF9B8C
		public unsafe void RequestClaim(int rewardId, int? selectId = null)
		{
			TotalTopUpUtil.Debug("发送请求领取奖励", default(ReadOnlySpan<ValueTuple<string, object>>));
			TotalTopUpRewardRequest totalTopUpRewardRequest = TotalTopUpRewardRequest.Create();
			totalTopUpRewardRequest.TotalTopUpRewardId = rewardId;
			if (selectId != null)
			{
				totalTopUpRewardRequest.SelectedId.Add(selectId.Value);
			}
			Net.Instance.Call(ERequestMessageId.TotalTopUpRewardRequest, totalTopUpRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				TotalTopUpRewardResponse totalTopUpRewardResponse = (TotalTopUpRewardResponse)msg;
				if (totalTopUpRewardResponse == null || totalTopUpRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					string message = "领取奖励失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RewardId", rewardId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ErrorCode", ((totalTopUpRewardResponse != null) ? new Aki.Protocol.ErrorCode?(totalTopUpRewardResponse.ErrorCode) : null) ?? Aki.Protocol.ErrorCode.UnKnownError);
					TotalTopUpUtil.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					ErrorCodeController.Instance.OpenErrorCodeTipView((totalTopUpRewardResponse != null) ? totalTopUpRewardResponse.ErrorCode : Aki.Protocol.ErrorCode.UnKnownError, 23916, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0603E0FA RID: 254202 RVA: 0x00EFBA04 File Offset: 0x00EF9C04
		[NullableContext(0)]
		public UniTask<bool> RequestScoreInfoAsync(int timeoutMs = 0)
		{
			TotalTopUpController.<RequestScoreInfoAsync>d__15 <RequestScoreInfoAsync>d__;
			<RequestScoreInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestScoreInfoAsync>d__.<>4__this = this;
			<RequestScoreInfoAsync>d__.timeoutMs = timeoutMs;
			<RequestScoreInfoAsync>d__.<>1__state = -1;
			<RequestScoreInfoAsync>d__.<>t__builder.Start<TotalTopUpController.<RequestScoreInfoAsync>d__15>(ref <RequestScoreInfoAsync>d__);
			return <RequestScoreInfoAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E0FB RID: 254203 RVA: 0x00EFBA50 File Offset: 0x00EF9C50
		public int GetGoodsScore(int id)
		{
			TotalTopUpData singleActivityData = this.GetSingleActivityData();
			if (singleActivityData == null)
			{
				return 0;
			}
			int result;
			if (!singleActivityData.GoodsScoreMap.TryGetValue(id, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x0603E0FC RID: 254204 RVA: 0x00EFBA7C File Offset: 0x00EF9C7C
		public int GetRechargeItemScore(int id)
		{
			TotalTopUpData singleActivityData = this.GetSingleActivityData();
			if (singleActivityData == null)
			{
				return 0;
			}
			int result;
			if (!singleActivityData.RechargeItemMap.TryGetValue(id, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x0603E0FD RID: 254205 RVA: 0x00EFBAA8 File Offset: 0x00EF9CA8
		public bool CheckCurrentTotalUpRunning()
		{
			TotalTopUpData singleActivityData = this.GetSingleActivityData();
			return singleActivityData != null && singleActivityData.CheckIfInOpenTime();
		}

		// Token: 0x0603E0FE RID: 254206 RVA: 0x00EFBAC8 File Offset: 0x00EF9CC8
		public void SkipToCurrentActivityView()
		{
			TotalTopUpData singleActivityData = this.GetSingleActivityData();
			if (singleActivityData == null)
			{
				TotalTopUpUtil.Error("跳转累计充值活动界面失败，找不到活动数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			SkipTaskManager.Run(ESkipName.SkipToActivity, new object[]
			{
				singleActivityData.Id
			});
		}

		// Token: 0x0603E0FF RID: 254207 RVA: 0x00EFBB10 File Offset: 0x00EF9D10
		public void SkipToPayShop(PayShopDefine.EPayShopTabType shopId, int tabIndex)
		{
			TotalTopUpController.<>c__DisplayClass20_0 CS$<>8__locals1 = new TotalTopUpController.<>c__DisplayClass20_0();
			CS$<>8__locals1.shopId = shopId;
			CS$<>8__locals1.tabIndex = tabIndex;
			if (this.TryResumePreviousView(EUiViewName.CommonActivityView, EUiViewName.PayShopRootView, new Action<UiViewBase>(CS$<>8__locals1.<SkipToPayShop>g__Callback|0)))
			{
				return;
			}
			ESkipName name = ESkipName.SkipTaskPayShopToSpecifyTab;
			object[] array = new object[2];
			int num = 0;
			int shopId2 = (int)CS$<>8__locals1.shopId;
			array[num] = shopId2.ToString();
			array[1] = CS$<>8__locals1.tabIndex.ToString();
			SkipTaskManager.Run(name, array);
		}

		// Token: 0x0603E100 RID: 254208 RVA: 0x00EFBB7C File Offset: 0x00EF9D7C
		public bool TryResumePreviousView(EUiViewName fromViewName, EUiViewName toViewName, Action<UiViewBase> callbackBeforeClose)
		{
			UiViewBase uiViewBase = UiModel.Instance.PeekNormalView(0);
			if (uiViewBase == null || uiViewBase.ViewInfo.Name != fromViewName)
			{
				return false;
			}
			UiViewBase uiViewBase2 = UiModel.Instance.PeekNormalView(1);
			if (uiViewBase2 == null || uiViewBase2.ViewInfo.Name != toViewName)
			{
				return false;
			}
			if (callbackBeforeClose != null)
			{
				callbackBeforeClose(uiViewBase2);
			}
			uiViewBase.CloseMe(null);
			return true;
		}

		// Token: 0x0603E101 RID: 254209 RVA: 0x00EFBBE4 File Offset: 0x00EF9DE4
		public string GetCurrentScoreIconPath()
		{
			TotalTopUpData singleActivityData = this.GetSingleActivityData();
			if (singleActivityData == null)
			{
				return string.Empty;
			}
			TotalTopUpData totalTopUpData = singleActivityData;
			return ((totalTopUpData.ViewConfig != null) ? totalTopUpData.ViewConfig.GetValueOrDefault().ScoreIcon : null) ?? string.Empty;
		}

		// Token: 0x0603E102 RID: 254210 RVA: 0x00EFBC2C File Offset: 0x00EF9E2C
		public string GetCurrentEnterResourcesId()
		{
			TotalTopUpData singleActivityData = this.GetSingleActivityData();
			if (singleActivityData == null)
			{
				return string.Empty;
			}
			TotalTopUpData totalTopUpData = singleActivityData;
			return ((totalTopUpData.ViewConfig != null) ? totalTopUpData.ViewConfig.GetValueOrDefault().EnterResourcesId : null) ?? string.Empty;
		}

		// Token: 0x0603E103 RID: 254211 RVA: 0x00EFBC74 File Offset: 0x00EF9E74
		public string GetCurrentTagResourcesId()
		{
			TotalTopUpData singleActivityData = this.GetSingleActivityData();
			if (singleActivityData == null)
			{
				return string.Empty;
			}
			TotalTopUpData totalTopUpData = singleActivityData;
			return ((totalTopUpData.ViewConfig != null) ? totalTopUpData.ViewConfig.GetValueOrDefault().TagResourcesId : null) ?? string.Empty;
		}

		// Token: 0x17008FE1 RID: 36833
		// (get) Token: 0x0603E104 RID: 254212 RVA: 0x00EFBCB9 File Offset: 0x00EF9EB9
		public static TotalTopUpController Instance
		{
			get
			{
				return TotalTopUpController._Instance;
			}
		}

		// Token: 0x0603E105 RID: 254213 RVA: 0x00EFBCC0 File Offset: 0x00EF9EC0
		public static TotalTopUpController GetOrCreateInstance()
		{
			if (TotalTopUpController._Instance == null)
			{
				TotalTopUpController.CreateInstance();
			}
			return TotalTopUpController._Instance;
		}

		// Token: 0x0603E106 RID: 254214 RVA: 0x00EFBCD4 File Offset: 0x00EF9ED4
		public static bool CreateInstance()
		{
			if (TotalTopUpController._Instance != null)
			{
				return true;
			}
			TotalTopUpController._Instance = new TotalTopUpController();
			return true;
		}

		// Token: 0x0603E107 RID: 254215 RVA: 0x00EFBCEA File Offset: 0x00EF9EEA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E108 RID: 254216 RVA: 0x00EFBCEC File Offset: 0x00EF9EEC
		public static void ResetStaticDefaultValue()
		{
			TotalTopUpController._Instance = null;
		}

		// Token: 0x0603E109 RID: 254217 RVA: 0x00EFBCF4 File Offset: 0x00EF9EF4
		static TotalTopUpController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TotalTopUpController.CreateStaticDefaultValue), new Action(TotalTopUpController.ResetStaticDefaultValue));
		}

		// Token: 0x0402067E RID: 132734
		[Nullable(2)]
		private static TotalTopUpController _Instance;
	}
}
