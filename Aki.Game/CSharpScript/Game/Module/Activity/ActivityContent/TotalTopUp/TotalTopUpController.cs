using System;
using System.Collections.Generic;
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
	// Token: 0x02004F6D RID: 20333
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class TotalTopUpController : ActivityControllerBase
	{
		// Token: 0x06033085 RID: 209029 RVA: 0x00E4D2DC File Offset: 0x00E4B4DC
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.TotalTopUpActivityInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTotalTopUpUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.TotalTopUpRewardNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRewardNotify));
		}

		// Token: 0x06033086 RID: 209030 RVA: 0x00E4D316 File Offset: 0x00E4B516
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.TotalTopUpActivityInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.TotalTopUpRewardNotify);
		}

		// Token: 0x06033087 RID: 209031 RVA: 0x00E4D338 File Offset: 0x00E4B538
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnViewDone, new Action<EUiViewName, UiViewBase>(this.OnShopViewOpen));
		}

		// Token: 0x06033088 RID: 209032 RVA: 0x00E4D353 File Offset: 0x00E4B553
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnViewDone, new Action<EUiViewName, UiViewBase>(this.OnShopViewOpen));
		}

		// Token: 0x06033089 RID: 209033 RVA: 0x00E4D370 File Offset: 0x00E4B570
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

		// Token: 0x0603308A RID: 209034 RVA: 0x00E4D3B0 File Offset: 0x00E4B5B0
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

		// Token: 0x0603308B RID: 209035 RVA: 0x00E4D448 File Offset: 0x00E4B648
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

		// Token: 0x0603308C RID: 209036 RVA: 0x00E4D4AC File Offset: 0x00E4B6AC
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
			singleActivityData.UpdateReward(totalTopUpRewardNotify.TotalTopUpRewardInfo);
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, singleActivityData.Id);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, singleActivityData.Id);
		}

		// Token: 0x0603308D RID: 209037 RVA: 0x00E4D580 File Offset: 0x00E4B780
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603308E RID: 209038 RVA: 0x00E4D582 File Offset: 0x00E4B782
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			if (!this.IsActivity37View(data))
			{
				return "UiView_CumulativeRechargeMain";
			}
			return "UiItem_CumulativeRecharge37Main";
		}

		// Token: 0x0603308F RID: 209039 RVA: 0x00E4D598 File Offset: 0x00E4B798
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			if (!this.IsActivity37View(data))
			{
				return new TotalTopUpView();
			}
			return new TotalTopUp37View();
		}

		// Token: 0x06033090 RID: 209040 RVA: 0x00E4D5B0 File Offset: 0x00E4B7B0
		private bool IsActivity37View(ActivityBaseData data)
		{
			TotalTopUpConfig instance = TotalTopUpConfig.Instance;
			TotalTopUpViewConfig? totalTopUpViewConfig = (instance != null) ? instance.GetViewConfigByActivityId(data.Id) : null;
			return totalTopUpViewConfig != null && totalTopUpViewConfig.GetValueOrDefault().ViewType == 1;
		}

		// Token: 0x06033091 RID: 209041 RVA: 0x00E4D5FC File Offset: 0x00E4B7FC
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			TotalTopUpData totalTopUpData = new TotalTopUpData();
			if (data.TotalTopUpActivityInfo != null)
			{
				totalTopUpData.InitData(data.TotalTopUpActivityInfo, data.Id);
			}
			return totalTopUpData;
		}

		// Token: 0x06033092 RID: 209042 RVA: 0x00E4D62A File Offset: 0x00E4B82A
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.TotalTopUpPickRoleRewardView);
			TotalTopUpPickRoleViewModel totalTopUpPickRoleViewModel = ((viewByName != null) ? viewByName.OpenParam : null) as TotalTopUpPickRoleViewModel;
			return totalTopUpPickRoleViewModel != null && totalTopUpPickRoleViewModel.IsFromActivity;
		}

		// Token: 0x06033093 RID: 209043 RVA: 0x00E4D658 File Offset: 0x00E4B858
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
					ErrorCodeController.Instance.OpenErrorCodeTipView((totalTopUpRewardResponse != null) ? totalTopUpRewardResponse.ErrorCode : Aki.Protocol.ErrorCode.UnKnownError, 27942, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06033094 RID: 209044 RVA: 0x00E4D6D0 File Offset: 0x00E4B8D0
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

		// Token: 0x06033095 RID: 209045 RVA: 0x00E4D71C File Offset: 0x00E4B91C
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

		// Token: 0x06033096 RID: 209046 RVA: 0x00E4D748 File Offset: 0x00E4B948
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

		// Token: 0x06033097 RID: 209047 RVA: 0x00E4D774 File Offset: 0x00E4B974
		public bool CheckCurrentTotalUpRunning()
		{
			TotalTopUpData singleActivityData = this.GetSingleActivityData();
			return singleActivityData != null && singleActivityData.CheckIfInOpenTime();
		}

		// Token: 0x06033098 RID: 209048 RVA: 0x00E4D794 File Offset: 0x00E4B994
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

		// Token: 0x06033099 RID: 209049 RVA: 0x00E4D7DC File Offset: 0x00E4B9DC
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

		// Token: 0x0603309A RID: 209050 RVA: 0x00E4D848 File Offset: 0x00E4BA48
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

		// Token: 0x0603309B RID: 209051 RVA: 0x00E4D8B0 File Offset: 0x00E4BAB0
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

		// Token: 0x0603309C RID: 209052 RVA: 0x00E4D8F8 File Offset: 0x00E4BAF8
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

		// Token: 0x0603309D RID: 209053 RVA: 0x00E4D940 File Offset: 0x00E4BB40
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

		// Token: 0x170063B3 RID: 25523
		// (get) Token: 0x0603309E RID: 209054 RVA: 0x00E4D985 File Offset: 0x00E4BB85
		public static TotalTopUpController Instance
		{
			get
			{
				return TotalTopUpController._Instance;
			}
		}

		// Token: 0x0603309F RID: 209055 RVA: 0x00E4D98C File Offset: 0x00E4BB8C
		public static TotalTopUpController GetOrCreateInstance()
		{
			if (TotalTopUpController._Instance == null)
			{
				TotalTopUpController.CreateInstance();
			}
			return TotalTopUpController._Instance;
		}

		// Token: 0x060330A0 RID: 209056 RVA: 0x00E4D9A0 File Offset: 0x00E4BBA0
		public static bool CreateInstance()
		{
			if (TotalTopUpController._Instance != null)
			{
				return true;
			}
			TotalTopUpController._Instance = new TotalTopUpController();
			return true;
		}

		// Token: 0x060330A1 RID: 209057 RVA: 0x00E4D9B6 File Offset: 0x00E4BBB6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060330A2 RID: 209058 RVA: 0x00E4D9B8 File Offset: 0x00E4BBB8
		public static void ResetStaticDefaultValue()
		{
			TotalTopUpController._Instance = null;
		}

		// Token: 0x060330A3 RID: 209059 RVA: 0x00E4D9C0 File Offset: 0x00E4BBC0
		static TotalTopUpController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TotalTopUpController.CreateStaticDefaultValue), new Action(TotalTopUpController.ResetStaticDefaultValue));
		}

		// Token: 0x0401B150 RID: 110928
		[Nullable(2)]
		private static TotalTopUpController _Instance;
	}
}
