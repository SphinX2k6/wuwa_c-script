using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Sheriff.View;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BDE RID: 15326
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SheriffController : ActivityControllerBase
	{
		// Token: 0x06027515 RID: 161045 RVA: 0x00B07043 File Offset: 0x00B05243
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06027516 RID: 161046 RVA: 0x00B07045 File Offset: 0x00B05245
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiView_ActivitySkyEye";
		}

		// Token: 0x06027517 RID: 161047 RVA: 0x00B0704C File Offset: 0x00B0524C
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new SheriffSubView();
		}

		// Token: 0x06027518 RID: 161048 RVA: 0x00B07053 File Offset: 0x00B05253
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new SheriffActivityData();
		}

		// Token: 0x06027519 RID: 161049 RVA: 0x00B07068 File Offset: 0x00B05268
		[NullableContext(2)]
		public SheriffActivityData GetActivityData()
		{
			SheriffActivityData sheriffActivityData = ActivityModel.Instance.GetActivityById(this.ActivityId) as SheriffActivityData;
			if (sheriffActivityData == null)
			{
				return null;
			}
			return sheriffActivityData;
		}

		// Token: 0x0602751A RID: 161050 RVA: 0x00B07091 File Offset: 0x00B05291
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0602751B RID: 161051 RVA: 0x00B07094 File Offset: 0x00B05294
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.RequestSheriffZoneInfo));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.RequestSheriffZoneInfo));
			EventSystem.Instance.Add<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCurrencyChange));
		}

		// Token: 0x0602751C RID: 161052 RVA: 0x00B070F8 File Offset: 0x00B052F8
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.RequestSheriffZoneInfo));
			EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.RequestSheriffZoneInfo));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCurrencyChange));
		}

		// Token: 0x0602751D RID: 161053 RVA: 0x00B07159 File Offset: 0x00B05359
		private void OnCurrencyChange(IProto_NormalItem item, int count, int lastCount)
		{
			if (item.Id != SheriffModel.Instance.GetShopCurrencyId())
			{
				return;
			}
			if (lastCount >= count)
			{
				return;
			}
			SheriffModel.Instance.ReArmShopRedDot();
		}

		// Token: 0x0602751E RID: 161054 RVA: 0x00B07180 File Offset: 0x00B05380
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.SheriffAnomalyInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSheriffAnomalyInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.SheriffCriminalUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSheriffCriminalUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.SheriffZoneItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSheriffZoneItemUpdateNotify));
		}

		// Token: 0x0602751F RID: 161055 RVA: 0x00B071E1 File Offset: 0x00B053E1
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.SheriffAnomalyInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.SheriffCriminalUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.SheriffZoneItemUpdateNotify);
		}

		// Token: 0x06027520 RID: 161056 RVA: 0x00B07213 File Offset: 0x00B05413
		public void OpenAnalysisClueView(int questionId)
		{
			UiManager.Instance.OpenView(EUiViewName.SheriffMainView, questionId, null);
		}

		// Token: 0x06027521 RID: 161057 RVA: 0x00B0722C File Offset: 0x00B0542C
		[NullableContext(0)]
		public UniTask<bool> OnUiGameplayFinish(int gameplayId, int progressId, int endingId)
		{
			SheriffController.<OnUiGameplayFinish>d__14 <OnUiGameplayFinish>d__;
			<OnUiGameplayFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnUiGameplayFinish>d__.gameplayId = gameplayId;
			<OnUiGameplayFinish>d__.progressId = progressId;
			<OnUiGameplayFinish>d__.endingId = endingId;
			<OnUiGameplayFinish>d__.<>1__state = -1;
			<OnUiGameplayFinish>d__.<>t__builder.Start<SheriffController.<OnUiGameplayFinish>d__14>(ref <OnUiGameplayFinish>d__);
			return <OnUiGameplayFinish>d__.<>t__builder.Task;
		}

		// Token: 0x06027522 RID: 161058 RVA: 0x00B07280 File Offset: 0x00B05480
		[NullableContext(2)]
		private void OnSheriffAnomalyInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			SheriffAnomalyInfoUpdateNotify sheriffAnomalyInfoUpdateNotify = (SheriffAnomalyInfoUpdateNotify)msg;
			SheriffModel.Instance.UpdateAnomalyInfo(sheriffAnomalyInfoUpdateNotify.AnomalyInfos, null);
			SheriffModel.Instance.CheckNeedOpenReportPop();
		}

		// Token: 0x06027523 RID: 161059 RVA: 0x00B072B8 File Offset: 0x00B054B8
		[NullableContext(2)]
		private void OnSheriffCriminalUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			SheriffCriminalUpdateNotify sheriffCriminalUpdateNotify = (SheriffCriminalUpdateNotify)msg;
			SheriffModel.Instance.UpdateCriminalInfo(sheriffCriminalUpdateNotify.CriminalInfos, null);
		}

		// Token: 0x06027524 RID: 161060 RVA: 0x00B072E8 File Offset: 0x00B054E8
		[NullableContext(2)]
		private void OnSheriffZoneItemUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			SheriffZoneItemUpdateNotify sheriffZoneItemUpdateNotify = (SheriffZoneItemUpdateNotify)msg;
			SheriffModel.Instance.UpdateZoneItemCount(sheriffZoneItemUpdateNotify.ZoneId, (int)sheriffZoneItemUpdateNotify.ItemCount);
			EventSystem.Instance.Emit<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, 0, SheriffModel.Instance.ShopId, 0);
		}

		// Token: 0x06027525 RID: 161061 RVA: 0x00B07330 File Offset: 0x00B05530
		private void RequestSheriffZoneInfo(EFunctionType id, bool isOpen)
		{
			if (this.ZoneConfigMap.Count == 0)
			{
				foreach (SheriffZone sheriffZone in SheriffConfig.Instance.GetZoneConfigAll())
				{
					this.ZoneConfigMap[(EFunctionType)sheriffZone.AnomalyFuncId] = sheriffZone.Id;
				}
			}
			if (!this.ZoneConfigMap.ContainsKey(id))
			{
				return;
			}
			if (!isOpen)
			{
				return;
			}
			SheriffZoneInfoRequest sheriffZoneInfoRequest = SheriffZoneInfoRequest.Create();
			int item = this.ZoneConfigMap[id];
			sheriffZoneInfoRequest.ZoneIds.Add(item);
			Net.Instance.Call(ERequestMessageId.SheriffZoneInfoRequest, sheriffZoneInfoRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SheriffZoneInfoResponse sheriffZoneInfoResponse = (SheriffZoneInfoResponse)msg;
				if (ErrorCodeController.Instance.CheckErrorCode(new Aki.Protocol.ErrorCode?(sheriffZoneInfoResponse.ErrorCode), EResponseMessageId.SheriffZoneInfoResponse, true))
				{
					return;
				}
				SheriffModel.Instance.UpdateZoneInfo(sheriffZoneInfoResponse.ZoneInfos);
			}, 0);
		}

		// Token: 0x06027526 RID: 161062 RVA: 0x00B07404 File Offset: 0x00B05604
		public void ReadTerminalFirstOpenRedDot()
		{
			SheriffActivityData activityData = this.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			activityData.ReadTerminalFirstOpenRedDot();
		}

		// Token: 0x06027527 RID: 161063 RVA: 0x00B07418 File Offset: 0x00B05618
		[NullableContext(2)]
		public void OpenSheriffMap(SheriffMapPanelParam panelParams = null)
		{
			SheriffActivityData activityData = this.GetActivityData();
			if (activityData != null)
			{
				activityData.ReadRedDot();
			}
			SheriffMapPanelParam sheriffMapPanelParam = panelParams ?? new SheriffMapPanelParam();
			if (sheriffMapPanelParam.TabType == null)
			{
				sheriffMapPanelParam.TabType = new ESheriffMainTabType?(ESheriffMainTabType.Event);
			}
			if (sheriffMapPanelParam.TargetMarkId == null)
			{
				ESheriffMainTabType? tabType = sheriffMapPanelParam.TabType;
				if (tabType != null)
				{
					ESheriffMainTabType valueOrDefault = tabType.GetValueOrDefault();
					if (valueOrDefault != ESheriffMainTabType.Event)
					{
						if (valueOrDefault == ESheriffMainTabType.Quest)
						{
							SheriffQuestState questState = SheriffModel.Instance.GetQuestState(1, ESheriffQuestType.POI);
							sheriffMapPanelParam.TargetMarkId = new int?(SheriffModel.Instance.GetTargetMapMarkIdByQuestIds(questState.TotalList));
							int? targetMarkId = sheriffMapPanelParam.TargetMarkId;
							int num = 0;
							if (targetMarkId.GetValueOrDefault() == num & targetMarkId != null)
							{
								SheriffQuestState questState2 = SheriffModel.Instance.GetQuestState(1, ESheriffQuestType.Branch);
								sheriffMapPanelParam.TargetMarkId = new int?(SheriffModel.Instance.GetTargetMapMarkIdByQuestIds(questState2.TotalList));
							}
						}
					}
					else
					{
						sheriffMapPanelParam.TargetMarkId = new int?(SheriffModel.Instance.GetTargetAnomalyMarkId());
					}
				}
			}
			WorldMapViewOpenParams mapOpenParam = new WorldMapViewOpenParams
			{
				MarkType = EMarkType.SheriffAnomaly,
				MarkId = sheriffMapPanelParam.TargetMarkId,
				IsNotFocal = new bool?(true),
				IsNotFocusTween = new bool?(true),
				SkipToExtraUiName = new EWorldMapExtraUiPanelName?(EWorldMapExtraUiPanelName.SheriffMapPanel),
				SkipToExtraUiParam = sheriffMapPanelParam
			};
			WorldMapController.Instance.OpenExtraUi(EWorldMapExtraUiPanelName.SheriffMapPanel, mapOpenParam, sheriffMapPanelParam);
		}

		// Token: 0x06027528 RID: 161064 RVA: 0x00B07578 File Offset: 0x00B05778
		public void OpenDetailClueFromQuestPanel()
		{
			SheriffShowClueViewPopInfo param = new SheriffShowClueViewPopInfo
			{
				AnomalyId = SheriffModel.Instance.LastCacheAnomaly,
				ClueId = new int?(SheriffModel.Instance.LastCacheClue)
			};
			UiManager.Instance.OpenView(EUiViewName.SheriffShowClueViewPop, param, null);
		}

		// Token: 0x06027529 RID: 161065 RVA: 0x00B075C4 File Offset: 0x00B057C4
		public void OpenAnomalyConditionView(int anomalyId)
		{
			SheriffAnomaly? anomalyConfigById = SheriffConfig.Instance.GetAnomalyConfigById(anomalyId);
			if (anomalyConfigById == null)
			{
				return;
			}
			List<IActivityConditionData> list = new List<IActivityConditionData>();
			int[] groupConditionIds = ConditionConfig.Instance.GetGroupConditionIds(anomalyConfigById.Value.UnlockConditionGroupId);
			if (groupConditionIds == null)
			{
				return;
			}
			foreach (int conditionId in groupConditionIds)
			{
				Condition? conditionConfig = ConditionConfig.Instance.GetConditionConfig(conditionId);
				if (conditionConfig != null)
				{
					int accessType = -1;
					if (!string.IsNullOrEmpty(conditionConfig.Value.Description))
					{
						if (conditionConfig.Value.AccessId > 0)
						{
							AccessPath? configById = GetWayConfig.Instance.GetConfigById(conditionConfig.Value.AccessId);
							accessType = ((configById != null) ? configById.GetValueOrDefault().SkipName : -1);
						}
						ActivityConditionData item = new ActivityConditionData
						{
							ConditionId = conditionId,
							ConditionTextId = conditionConfig.Value.Description,
							IsFinished = false,
							AccessId = conditionConfig.Value.AccessId,
							AccessType = accessType
						};
						list.Add(item);
					}
				}
			}
			ConditionGroupData param = new ConditionGroupData(anomalyConfigById.Value.UnlockConditionGroupId, list, "", false);
			UiManager.Instance.OpenView(EUiViewName.CommonConditionView, param, null);
		}

		// Token: 0x0602752A RID: 161066 RVA: 0x00B07734 File Offset: 0x00B05934
		public void OpenSheriffReportPop(int criminalId, bool bothPage)
		{
			SheriffReportPopViewParam param = new SheriffReportPopViewParam
			{
				CriminalId = criminalId,
				BothPage = bothPage
			};
			UiManager.Instance.OpenView(EUiViewName.SheriffReportPop, param, null);
		}

		// Token: 0x17005039 RID: 20537
		// (get) Token: 0x0602752B RID: 161067 RVA: 0x00B07766 File Offset: 0x00B05966
		public static SheriffController Instance
		{
			get
			{
				return SheriffController._Instance;
			}
		}

		// Token: 0x0602752C RID: 161068 RVA: 0x00B0776D File Offset: 0x00B0596D
		public static SheriffController GetOrCreateInstance()
		{
			if (SheriffController._Instance == null)
			{
				SheriffController.CreateInstance();
			}
			return SheriffController._Instance;
		}

		// Token: 0x0602752D RID: 161069 RVA: 0x00B07781 File Offset: 0x00B05981
		public static bool CreateInstance()
		{
			if (SheriffController._Instance != null)
			{
				return true;
			}
			SheriffController._Instance = new SheriffController();
			return true;
		}

		// Token: 0x0602752E RID: 161070 RVA: 0x00B07797 File Offset: 0x00B05997
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602752F RID: 161071 RVA: 0x00B07799 File Offset: 0x00B05999
		public static void ResetStaticDefaultValue()
		{
			SheriffController._Instance = null;
		}

		// Token: 0x06027530 RID: 161072 RVA: 0x00B077A1 File Offset: 0x00B059A1
		static SheriffController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SheriffController.CreateStaticDefaultValue), new Action(SheriffController.ResetStaticDefaultValue));
		}

		// Token: 0x0401571A RID: 87834
		public int ActivityId;

		// Token: 0x0401571B RID: 87835
		public Dictionary<EFunctionType, int> ZoneConfigMap = new Dictionary<EFunctionType, int>();

		// Token: 0x0401571C RID: 87836
		[Nullable(2)]
		private static SheriffController _Instance;
	}
}
