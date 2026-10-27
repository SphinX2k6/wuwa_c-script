using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02004C2D RID: 19501
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SheriffController : ActivityControllerBase
	{
		// Token: 0x06032762 RID: 206690 RVA: 0x00BC2413 File Offset: 0x00BC0613
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06032763 RID: 206691 RVA: 0x00BC2415 File Offset: 0x00BC0615
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiView_ActivitySkyEye";
		}

		// Token: 0x06032764 RID: 206692 RVA: 0x00BC241C File Offset: 0x00BC061C
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new SheriffSubView();
		}

		// Token: 0x06032765 RID: 206693 RVA: 0x00BC2423 File Offset: 0x00BC0623
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new SheriffActivityData();
		}

		// Token: 0x06032766 RID: 206694 RVA: 0x00BC2438 File Offset: 0x00BC0638
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

		// Token: 0x06032767 RID: 206695 RVA: 0x00BC2461 File Offset: 0x00BC0661
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06032768 RID: 206696 RVA: 0x00BC2464 File Offset: 0x00BC0664
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.RequestSheriffZoneInfo));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.RequestSheriffZoneInfo));
			EventSystem.Instance.Add<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCurrencyChange));
		}

		// Token: 0x06032769 RID: 206697 RVA: 0x00BC24C8 File Offset: 0x00BC06C8
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.RequestSheriffZoneInfo));
			EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.RequestSheriffZoneInfo));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCurrencyChange));
		}

		// Token: 0x0603276A RID: 206698 RVA: 0x00BC2529 File Offset: 0x00BC0729
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

		// Token: 0x0603276B RID: 206699 RVA: 0x00BC2550 File Offset: 0x00BC0750
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.SheriffAnomalyInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSheriffAnomalyInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.SheriffCriminalUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSheriffCriminalUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.SheriffZoneItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSheriffZoneItemUpdateNotify));
		}

		// Token: 0x0603276C RID: 206700 RVA: 0x00BC25B1 File Offset: 0x00BC07B1
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.SheriffAnomalyInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.SheriffCriminalUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.SheriffZoneItemUpdateNotify);
		}

		// Token: 0x0603276D RID: 206701 RVA: 0x00BC25E3 File Offset: 0x00BC07E3
		public void OpenAnalysisClueView(int questionId)
		{
			UiManager.Instance.OpenView(EUiViewName.SheriffMainView, questionId, null);
		}

		// Token: 0x0603276E RID: 206702 RVA: 0x00BC25FC File Offset: 0x00BC07FC
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

		// Token: 0x0603276F RID: 206703 RVA: 0x00BC2650 File Offset: 0x00BC0850
		[NullableContext(2)]
		private void OnSheriffAnomalyInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			SheriffAnomalyInfoUpdateNotify sheriffAnomalyInfoUpdateNotify = (SheriffAnomalyInfoUpdateNotify)msg;
			SheriffModel.Instance.UpdateAnomalyInfo(sheriffAnomalyInfoUpdateNotify.AnomalyInfos.ToList<SheriffAnomalyInfo>(), null);
			SheriffModel.Instance.CheckNeedOpenReportPop();
		}

		// Token: 0x06032770 RID: 206704 RVA: 0x00BC268C File Offset: 0x00BC088C
		[NullableContext(2)]
		private void OnSheriffCriminalUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			SheriffCriminalUpdateNotify sheriffCriminalUpdateNotify = (SheriffCriminalUpdateNotify)msg;
			SheriffModel.Instance.UpdateCriminalInfo(sheriffCriminalUpdateNotify.CriminalInfos.ToList<SheriffCriminalInfo>(), null);
		}

		// Token: 0x06032771 RID: 206705 RVA: 0x00BC26C0 File Offset: 0x00BC08C0
		[NullableContext(2)]
		private void OnSheriffZoneItemUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			SheriffZoneItemUpdateNotify sheriffZoneItemUpdateNotify = (SheriffZoneItemUpdateNotify)msg;
			SheriffModel.Instance.UpdateZoneItemCount(sheriffZoneItemUpdateNotify.ZoneId, (int)sheriffZoneItemUpdateNotify.ItemCount);
			EventSystem.Instance.Emit<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, 0, SheriffModel.Instance.ShopId, 0);
		}

		// Token: 0x06032772 RID: 206706 RVA: 0x00BC2708 File Offset: 0x00BC0908
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
				SheriffModel.Instance.UpdateZoneInfo(sheriffZoneInfoResponse.ZoneInfos.ToList<SheriffZoneInfo>());
			}, 0);
		}

		// Token: 0x06032773 RID: 206707 RVA: 0x00BC27DC File Offset: 0x00BC09DC
		public void ReadTerminalFirstOpenRedDot()
		{
			SheriffActivityData activityData = this.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			activityData.ReadTerminalFirstOpenRedDot();
		}

		// Token: 0x06032774 RID: 206708 RVA: 0x00BC27F0 File Offset: 0x00BC09F0
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

		// Token: 0x06032775 RID: 206709 RVA: 0x00BC2950 File Offset: 0x00BC0B50
		public void OpenDetailClueFromQuestPanel()
		{
			SheriffShowClueViewPopInfo param = new SheriffShowClueViewPopInfo
			{
				AnomalyId = SheriffModel.Instance.LastCacheAnomaly,
				ClueId = new int?(SheriffModel.Instance.LastCacheClue)
			};
			UiManager.Instance.OpenView(EUiViewName.SheriffShowClueViewPop, param, null);
		}

		// Token: 0x06032776 RID: 206710 RVA: 0x00BC299C File Offset: 0x00BC0B9C
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

		// Token: 0x06032777 RID: 206711 RVA: 0x00BC2B0C File Offset: 0x00BC0D0C
		public void OpenSheriffReportPop(int criminalId, bool bothPage)
		{
			SheriffReportPopViewParam param = new SheriffReportPopViewParam
			{
				CriminalId = criminalId,
				BothPage = bothPage
			};
			UiManager.Instance.OpenView(EUiViewName.SheriffReportPop, param, null);
		}

		// Token: 0x17007C8F RID: 31887
		// (get) Token: 0x06032778 RID: 206712 RVA: 0x00BC2B3E File Offset: 0x00BC0D3E
		public static SheriffController Instance
		{
			get
			{
				return SheriffController._Instance;
			}
		}

		// Token: 0x06032779 RID: 206713 RVA: 0x00BC2B45 File Offset: 0x00BC0D45
		public static SheriffController GetOrCreateInstance()
		{
			if (SheriffController._Instance == null)
			{
				SheriffController.CreateInstance();
			}
			return SheriffController._Instance;
		}

		// Token: 0x0603277A RID: 206714 RVA: 0x00BC2B59 File Offset: 0x00BC0D59
		public static bool CreateInstance()
		{
			if (SheriffController._Instance != null)
			{
				return true;
			}
			SheriffController._Instance = new SheriffController();
			return true;
		}

		// Token: 0x0603277B RID: 206715 RVA: 0x00BC2B6F File Offset: 0x00BC0D6F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603277C RID: 206716 RVA: 0x00BC2B71 File Offset: 0x00BC0D71
		public static void ResetStaticDefaultValue()
		{
			SheriffController._Instance = null;
		}

		// Token: 0x0603277D RID: 206717 RVA: 0x00BC2B79 File Offset: 0x00BC0D79
		static SheriffController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SheriffController.CreateStaticDefaultValue), new Action(SheriffController.ResetStaticDefaultValue));
		}

		// Token: 0x0401ADBD RID: 110013
		public int ActivityId;

		// Token: 0x0401ADBE RID: 110014
		public Dictionary<EFunctionType, int> ZoneConfigMap = new Dictionary<EFunctionType, int>();

		// Token: 0x0401ADBF RID: 110015
		[Nullable(2)]
		private static SheriffController _Instance;
	}
}
