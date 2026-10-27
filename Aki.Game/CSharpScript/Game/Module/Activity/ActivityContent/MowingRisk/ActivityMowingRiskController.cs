using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.DeadRevive;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063A4 RID: 25508
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityMowingRiskController : ActivityControllerBase
	{
		// Token: 0x060402A9 RID: 262825 RVA: 0x00F89775 File Offset: 0x00F87975
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x060402AA RID: 262826 RVA: 0x00F89777 File Offset: 0x00F87977
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityMowingRisk";
		}

		// Token: 0x060402AB RID: 262827 RVA: 0x00F8977E File Offset: 0x00F8797E
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityMowingRiskSubView();
		}

		// Token: 0x060402AC RID: 262828 RVA: 0x00F89785 File Offset: 0x00F87985
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			MowingRiskModel.Instance.InitContext();
			return MowingRiskModel.Instance.ActivityData;
		}

		// Token: 0x060402AD RID: 262829 RVA: 0x00F8979B File Offset: 0x00F8799B
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x060402AE RID: 262830 RVA: 0x00F897A0 File Offset: 0x00F879A0
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RiskHarvestEndNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleRiskHarvestEndNotify));
			Net.Instance.Register(ENotifyMessageId.RiskHarvestInstUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleRiskHarvestInstUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RiskHarvestArtifactNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleRiskHarvestArtifactNotify));
			Net.Instance.Register(ENotifyMessageId.RiskHarvestBuffUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleRiskHarvestBuffUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RiskHarvestBuffUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleRiskHarvestBuffUnlockNotify));
			Net.Instance.Register(ENotifyMessageId.RiskHarvestActivityUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleRiskHarvestActivityUpdateNotify));
		}

		// Token: 0x060402AF RID: 262831 RVA: 0x00F89858 File Offset: 0x00F87A58
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RiskHarvestEndNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RiskHarvestInstUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RiskHarvestArtifactNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RiskHarvestBuffUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RiskHarvestBuffUnlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RiskHarvestActivityUpdateNotify);
		}

		// Token: 0x060402B0 RID: 262832 RVA: 0x00F898C8 File Offset: 0x00F87AC8
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.EnterInstanceDungeon, new Action(this.HandleEnterInstanceDungeon));
			EventSystem.Instance.Add(EEventName.LeaveInstanceDungeon, new Action(this.HandleLeaveInstanceDungeon));
			EventSystem.Instance.Add(EEventName.LeaveInstanceDungeonConfirm, new Action(this.HandleLeaveInstanceDungeonConfirm));
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.HandleWorldDoneAndCloseLoading));
			EventSystem.Instance.Add(EEventName.MowingRiskOnBuffTipsAfterDestroy, new Action(this.HandleMowingRiskOnBuffTipsAfterDestroy));
		}

		// Token: 0x060402B1 RID: 262833 RVA: 0x00F89964 File Offset: 0x00F87B64
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.EnterInstanceDungeon, new Action(this.HandleEnterInstanceDungeon));
			EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeon, new Action(this.HandleLeaveInstanceDungeon));
			EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeonConfirm, new Action(this.HandleLeaveInstanceDungeonConfirm));
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.HandleWorldDoneAndCloseLoading));
			EventSystem.Instance.Remove(EEventName.MowingRiskOnBuffTipsAfterDestroy, new Action(this.HandleMowingRiskOnBuffTipsAfterDestroy));
		}

		// Token: 0x060402B2 RID: 262834 RVA: 0x00F899FD File Offset: 0x00F87BFD
		public override bool GetActivityLevelUnlockState(int instanceId)
		{
			return MowingRiskModel.Instance.IsInstanceUnlockedByInstanceId(instanceId);
		}

		// Token: 0x060402B3 RID: 262835 RVA: 0x00F89A0C File Offset: 0x00F87C0C
		[NullableContext(2)]
		private void HandleRiskHarvestEndNotify(IMessage msg, Net.CallbackStatus status)
		{
			RiskHarvestEndNotify riskHarvestEndNotify = (RiskHarvestEndNotify)msg;
			this.DumpNotifyMessage(riskHarvestEndNotify);
			if (!GameModeController.Instance.IsInInstance())
			{
				return;
			}
			MowingRiskModel.Instance.SyncProtocolRiskHarvestEndNotify(riskHarvestEndNotify);
			this.TryOpenSettleViewAsync(riskHarvestEndNotify).Forget();
		}

		// Token: 0x060402B4 RID: 262836 RVA: 0x00F89A4C File Offset: 0x00F87C4C
		[NullableContext(2)]
		private void HandleRiskHarvestInstUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RiskHarvestInstUpdateNotify riskHarvestInstUpdateNotify = (RiskHarvestInstUpdateNotify)msg;
			this.DumpNotifyMessage(riskHarvestInstUpdateNotify);
			MowingRiskModel.Instance.SyncProtocolRiskHarvestInstUpdateNotify(riskHarvestInstUpdateNotify);
		}

		// Token: 0x060402B5 RID: 262837 RVA: 0x00F89A74 File Offset: 0x00F87C74
		[NullableContext(2)]
		private void HandleRiskHarvestArtifactNotify(IMessage msg, Net.CallbackStatus status)
		{
			RiskHarvestArtifactNotify riskHarvestArtifactNotify = (RiskHarvestArtifactNotify)msg;
			this.DumpNotifyMessage(riskHarvestArtifactNotify);
			MowingRiskModel.Instance.SyncProtocolRiskHarvestArtifactNotify(riskHarvestArtifactNotify);
		}

		// Token: 0x060402B6 RID: 262838 RVA: 0x00F89A9C File Offset: 0x00F87C9C
		[NullableContext(2)]
		private void HandleRiskHarvestBuffUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RiskHarvestBuffUpdateNotify riskHarvestBuffUpdateNotify = (RiskHarvestBuffUpdateNotify)msg;
			this.DumpNotifyMessage(riskHarvestBuffUpdateNotify);
			MowingRiskModel instance = MowingRiskModel.Instance;
			instance.SyncProtocolRiskHarvestBuffUpdateNotify(riskHarvestBuffUpdateNotify);
			this.TryOpenNewBuffTips();
			EventSystem.Instance.Emit<IMowingRiskInBattleRootData>(EEventName.MowingRiskInBattleRootUpdate, instance.BuildInBattleRootData());
		}

		// Token: 0x060402B7 RID: 262839 RVA: 0x00F89AE0 File Offset: 0x00F87CE0
		[NullableContext(2)]
		private void HandleRiskHarvestBuffUnlockNotify(IMessage msg, Net.CallbackStatus status)
		{
			RiskHarvestBuffUnlockNotify riskHarvestBuffUnlockNotify = (RiskHarvestBuffUnlockNotify)msg;
			this.DumpNotifyMessage(riskHarvestBuffUnlockNotify);
			MowingRiskModel.Instance.SyncProtocolRiskHarvestBuffUnlockNotify(riskHarvestBuffUnlockNotify);
		}

		// Token: 0x060402B8 RID: 262840 RVA: 0x00F89B08 File Offset: 0x00F87D08
		[NullableContext(2)]
		private void HandleRiskHarvestActivityUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RiskHarvestActivityUpdateNotify riskHarvestActivityUpdateNotify = (RiskHarvestActivityUpdateNotify)msg;
			this.DumpNotifyMessage(riskHarvestActivityUpdateNotify);
			MowingRiskModel instance = MowingRiskModel.Instance;
			instance.SyncProtocolRiskHarvestActivityUpdateNotify(riskHarvestActivityUpdateNotify);
			EventSystem.Instance.Emit(EEventName.OnNeedRefreshByProtocol);
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, instance.ActivityData.Id);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, instance.ActivityData.Id);
			EventSystem.Instance.Emit(EEventName.MowingRiskOnRefreshRewardRedDot);
		}

		// Token: 0x060402B9 RID: 262841 RVA: 0x00F89B88 File Offset: 0x00F87D88
		public UniTask RequestRiskHarvestInstRewardRequest(int id)
		{
			ActivityMowingRiskController.<RequestRiskHarvestInstRewardRequest>d__17 <RequestRiskHarvestInstRewardRequest>d__;
			<RequestRiskHarvestInstRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRiskHarvestInstRewardRequest>d__.id = id;
			<RequestRiskHarvestInstRewardRequest>d__.<>1__state = -1;
			<RequestRiskHarvestInstRewardRequest>d__.<>t__builder.Start<ActivityMowingRiskController.<RequestRiskHarvestInstRewardRequest>d__17>(ref <RequestRiskHarvestInstRewardRequest>d__);
			return <RequestRiskHarvestInstRewardRequest>d__.<>t__builder.Task;
		}

		// Token: 0x060402BA RID: 262842 RVA: 0x00F89BCC File Offset: 0x00F87DCC
		public UniTask RequestRiskHarvestScoreRewardRequest(int id)
		{
			ActivityMowingRiskController.<RequestRiskHarvestScoreRewardRequest>d__18 <RequestRiskHarvestScoreRewardRequest>d__;
			<RequestRiskHarvestScoreRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRiskHarvestScoreRewardRequest>d__.id = id;
			<RequestRiskHarvestScoreRewardRequest>d__.<>1__state = -1;
			<RequestRiskHarvestScoreRewardRequest>d__.<>t__builder.Start<ActivityMowingRiskController.<RequestRiskHarvestScoreRewardRequest>d__18>(ref <RequestRiskHarvestScoreRewardRequest>d__);
			return <RequestRiskHarvestScoreRewardRequest>d__.<>t__builder.Task;
		}

		// Token: 0x060402BB RID: 262843 RVA: 0x00F89C10 File Offset: 0x00F87E10
		public UniTask RequestRiskHarvestStarRewardRequest(int id, int index)
		{
			ActivityMowingRiskController.<RequestRiskHarvestStarRewardRequest>d__19 <RequestRiskHarvestStarRewardRequest>d__;
			<RequestRiskHarvestStarRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRiskHarvestStarRewardRequest>d__.id = id;
			<RequestRiskHarvestStarRewardRequest>d__.index = index;
			<RequestRiskHarvestStarRewardRequest>d__.<>1__state = -1;
			<RequestRiskHarvestStarRewardRequest>d__.<>t__builder.Start<ActivityMowingRiskController.<RequestRiskHarvestStarRewardRequest>d__19>(ref <RequestRiskHarvestStarRewardRequest>d__);
			return <RequestRiskHarvestStarRewardRequest>d__.<>t__builder.Task;
		}

		// Token: 0x060402BC RID: 262844 RVA: 0x00F89C5C File Offset: 0x00F87E5C
		public UniTask RequestRiskHarvestSettleRequest()
		{
			ActivityMowingRiskController.<RequestRiskHarvestSettleRequest>d__20 <RequestRiskHarvestSettleRequest>d__;
			<RequestRiskHarvestSettleRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRiskHarvestSettleRequest>d__.<>1__state = -1;
			<RequestRiskHarvestSettleRequest>d__.<>t__builder.Start<ActivityMowingRiskController.<RequestRiskHarvestSettleRequest>d__20>(ref <RequestRiskHarvestSettleRequest>d__);
			return <RequestRiskHarvestSettleRequest>d__.<>t__builder.Task;
		}

		// Token: 0x060402BD RID: 262845 RVA: 0x00F89C97 File Offset: 0x00F87E97
		private void HandleLeaveInstanceDungeonConfirm()
		{
			if (!this.CheckInInstanceDungeon())
			{
				return;
			}
			this.RequestRiskHarvestSettleRequest().Forget();
		}

		// Token: 0x060402BE RID: 262846 RVA: 0x00F89CAD File Offset: 0x00F87EAD
		private void HandleEnterInstanceDungeon()
		{
		}

		// Token: 0x060402BF RID: 262847 RVA: 0x00F89CAF File Offset: 0x00F87EAF
		private void HandleLeaveInstanceDungeon()
		{
			if (!this.CheckInInstanceDungeon())
			{
				return;
			}
			DeadReviveModel.Instance.HandleOnClickGiveUpExternal = null;
			InstanceDungeonEntranceController.Instance.IsSettleExternalProcess = false;
			MowingRiskModel.Instance.ResetCacheInBattle();
		}

		// Token: 0x060402C0 RID: 262848 RVA: 0x00F89CDA File Offset: 0x00F87EDA
		private void HandleWorldDoneAndCloseLoading()
		{
			if (!this.CheckInInstanceDungeon())
			{
				return;
			}
			DeadReviveModel.Instance.HandleOnClickGiveUpExternal = delegate()
			{
				this.RequestRiskHarvestSettleRequest().Forget();
			};
			InstanceDungeonEntranceController.Instance.IsSettleExternalProcess = true;
			CustomPromise beInInstancePromise = this.BeInInstancePromise;
			if (beInInstancePromise == null)
			{
				return;
			}
			beInInstancePromise.SetResult();
		}

		// Token: 0x060402C1 RID: 262849 RVA: 0x00F89D16 File Offset: 0x00F87F16
		private void HandleMowingRiskOnBuffTipsAfterDestroy()
		{
			this.TryOpenNewBuffTips();
		}

		// Token: 0x060402C2 RID: 262850 RVA: 0x00F89D1E File Offset: 0x00F87F1E
		private void DumpNotifyMessage(object msg)
		{
		}

		// Token: 0x060402C3 RID: 262851 RVA: 0x00F89D20 File Offset: 0x00F87F20
		private void TryOpenNewBuffTips()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.MowingBuffNewBuffTipsView) || !this.CheckInInstanceDungeon())
			{
				return;
			}
			MowingRiskModel instance = MowingRiskModel.Instance;
			int? nextNewBuffId = instance.NextNewBuffId;
			if (nextNewBuffId != null)
			{
				int? num = nextNewBuffId;
				int num2 = 0;
				if (!(num.GetValueOrDefault() == num2 & num != null))
				{
					IMowingRiskNewBasicBuffTipsData param = instance.BuildNewBuffTipsDataById(nextNewBuffId.Value);
					UiManager.Instance.OpenView(EUiViewName.MowingBuffNewBuffTipsView, param, null);
					if (instance.IsSuperBuffById(nextNewBuffId.Value))
					{
						this.TryShowBuffBigTip(nextNewBuffId.Value);
						EventSystem.Instance.Emit(EEventName.MowingRiskOnNeedPlayLevelUpSequence);
					}
				}
			}
		}

		// Token: 0x060402C4 RID: 262852 RVA: 0x00F89DC4 File Offset: 0x00F87FC4
		private void TryShowBuffBigTip(int buffId)
		{
			IMowingRiskInBattleBuffData extraParam = MowingRiskModel.Instance.BuildInBattleBuffDataById(buffId);
			GenericPromptController.Instance.ShowPromptByItsType<IMowingRiskInBattleBuffData>(EPromptSubViewType.MowingRiskBuff, null, null, null, null, null, null, extraParam, null, false, null);
		}

		// Token: 0x060402C5 RID: 262853 RVA: 0x00F89E04 File Offset: 0x00F88004
		private UniTask TryOpenSettleViewAsync(RiskHarvestEndNotify message)
		{
			ActivityMowingRiskController.<TryOpenSettleViewAsync>d__29 <TryOpenSettleViewAsync>d__;
			<TryOpenSettleViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryOpenSettleViewAsync>d__.<>4__this = this;
			<TryOpenSettleViewAsync>d__.message = message;
			<TryOpenSettleViewAsync>d__.<>1__state = -1;
			<TryOpenSettleViewAsync>d__.<>t__builder.Start<ActivityMowingRiskController.<TryOpenSettleViewAsync>d__29>(ref <TryOpenSettleViewAsync>d__);
			return <TryOpenSettleViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060402C6 RID: 262854 RVA: 0x00F89E50 File Offset: 0x00F88050
		private void OpenAccumulatedScoreSettleView(RiskHarvestEndNotify message)
		{
			Action<int> onClickedCallback = delegate(int index)
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
			};
			RewardExploreConfirmButtonData item = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "riskofrain_UIBacktoworld",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = true,
				OnClickedCallback = onClickedCallback
			};
			Action<int> onClickedCallback2 = delegate(int _)
			{
				InstanceDungeonEntranceController.Instance.RestartInstanceDungeon().Forget<bool>();
			};
			RewardExploreConfirmButtonData item2 = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "ConfirmBox_133_ButtonText_1",
				IsTimeDownCloseView = false,
				IsClickedCloseView = false,
				OnClickedCallback = onClickedCallback2,
				DescriptionTextId = null
			};
			int maxScoreById = MowingRiskModel.Instance.GetMaxScoreById(message.Id);
			AccumulatedScoreData accumulatedScoreData = new AccumulatedScoreData
			{
				DetailScoreDataList = new List<IAccumulatedScoreLineData>
				{
					new AccumulatedScoreLineData
					{
						DescTextId = "RiskHarvest_Timepoint",
						ScoreText = message.TimeScore.ToString()
					},
					new AccumulatedScoreLineData
					{
						DescTextId = "RiskHarvest_Monsterpoint",
						ScoreText = message.MonsterScore.ToString()
					}
				},
				TotalScoreDataList = new List<IAccumulatedScoreLineData>
				{
					new AccumulatedScoreLineData
					{
						DescTextId = "RiskHarvest_Score",
						ScoreText = message.TotalScore.ToString()
					}
				},
				CurScore = message.InstScore,
				MaxScore = maxScoreById
			};
			string titleTextId = (message.TimeScore > 0) ? null : "riskofrain_UIFinish";
			ItemRewardController.Instance.OpenExploreRewardView(message.Pass ? 3013 : 3012, message.Pass, null, null, null, new List<IRewardExploreConfirmButton>
			{
				item,
				item2
			}, null, null, null, null, null, null, null, null, null, accumulatedScoreData, titleTextId);
		}

		// Token: 0x060402C7 RID: 262855 RVA: 0x00F8A028 File Offset: 0x00F88228
		private unsafe void OpenNotAccumulatedScoreSettleView(RiskHarvestEndNotify message)
		{
			Action<int> onClickedCallback = delegate(int _)
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
			};
			RewardExploreConfirmButtonData item = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "riskofrain_UIBacktoworld",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = true,
				OnClickedCallback = onClickedCallback
			};
			Action<int> onClickedCallback2 = delegate(int _)
			{
				InstanceDungeonEntranceController.Instance.RestartInstanceDungeon().Forget<bool>();
			};
			RewardExploreConfirmButtonData rewardExploreConfirmButtonData = new RewardExploreConfirmButtonData();
			rewardExploreConfirmButtonData.ButtonTextId = "ConfirmBox_133_ButtonText_1";
			rewardExploreConfirmButtonData.DescriptionTextId = "RiskHarvest_HistoryToppoint";
			int num = 1;
			List<object> list = new List<object>(num);
			CollectionsMarshal.SetCount<object>(list, num);
			Span<object> span = CollectionsMarshal.AsSpan<object>(list);
			int index = 0;
			*span[index] = MowingRiskModel.Instance.GetRecordScoreById(message.Id).ToString();
			rewardExploreConfirmButtonData.DescriptionArgs = list;
			rewardExploreConfirmButtonData.IsTimeDownCloseView = false;
			rewardExploreConfirmButtonData.IsClickedCloseView = false;
			rewardExploreConfirmButtonData.OnClickedCallback = onClickedCallback2;
			RewardExploreConfirmButtonData item2 = rewardExploreConfirmButtonData;
			int maxScoreById = MowingRiskModel.Instance.GetMaxScoreById(message.Id);
			int totalScore = message.TotalScore;
			string titleTextId = (message.TimeScore > 0) ? null : "riskofrain_UIFinish";
			ItemRewardController.Instance.OpenExploreRewardView(message.Pass ? 3013 : 3012, message.Pass, null, null, null, new List<IRewardExploreConfirmButton>
			{
				item,
				item2
			}, null, null, null, null, null, null, null, new ReachTargetData
			{
				TargetReached = new List<IRewardExploreTargetReached>
				{
					new RewardExploreTargetReachedData
					{
						Target = new List<string>
						{
							message.TimeScore.ToString()
						},
						DescriptionTextId = "RiskHarvest_Timepoint",
						IsReached = true
					},
					new RewardExploreTargetReachedData
					{
						Target = new List<string>
						{
							message.MonsterScore.ToString()
						},
						DescriptionTextId = "RiskHarvest_Monsterpoint",
						IsReached = true
					}
				},
				IfNewRecord = false,
				FullScore = totalScore,
				RecordTextId = ((totalScore < maxScoreById) ? "RiskHarvest_Score" : "RiskHarvest_Scorelimit")
			}, null, null, titleTextId);
		}

		// Token: 0x060402C8 RID: 262856 RVA: 0x00F8A250 File Offset: 0x00F88450
		private UniTask WaitForBeInInstance()
		{
			ActivityMowingRiskController.<WaitForBeInInstance>d__32 <WaitForBeInInstance>d__;
			<WaitForBeInInstance>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitForBeInInstance>d__.<>4__this = this;
			<WaitForBeInInstance>d__.<>1__state = -1;
			<WaitForBeInInstance>d__.<>t__builder.Start<ActivityMowingRiskController.<WaitForBeInInstance>d__32>(ref <WaitForBeInInstance>d__);
			return <WaitForBeInInstance>d__.<>t__builder.Task;
		}

		// Token: 0x060402C9 RID: 262857 RVA: 0x00F8A294 File Offset: 0x00F88494
		public bool CheckInInstanceDungeon()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
				return instanceDungeon != null && instanceDungeon.Value.InstSubType == 22;
			}
			return false;
		}

		// Token: 0x060402CA RID: 262858 RVA: 0x00F8A2D8 File Offset: 0x00F884D8
		public bool IsMowingRiskInstanceDungeon(int instanceId)
		{
			if (instanceId <= 0)
			{
				return false;
			}
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.GetValueOrDefault().InstSubType == 22;
		}

		// Token: 0x060402CB RID: 262859 RVA: 0x00F8A315 File Offset: 0x00F88515
		[NullableContext(2)]
		public string GetInstanceSubtitleTextIdByInstanceId(int id)
		{
			return MowingRiskModel.Instance.BuildInstanceSubtitleTextIdByInstanceId(id);
		}

		// Token: 0x060402CC RID: 262860 RVA: 0x00F8A322 File Offset: 0x00F88522
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] GetInstanceSubtitleArgsByInstanceId(int id)
		{
			return MowingRiskModel.Instance.BuildInstanceSubtitleTextArgsByInstanceId(id);
		}

		// Token: 0x060402CD RID: 262861 RVA: 0x00F8A32F File Offset: 0x00F8852F
		public bool CheckInstanceFinishedByInstanceId(int id)
		{
			return MowingRiskModel.Instance.CheckInstanceFinishedByInstanceId(id);
		}

		// Token: 0x060402CE RID: 262862 RVA: 0x00F8A33C File Offset: 0x00F8853C
		public bool CheckInstanceUnlockByInstanceId(int id)
		{
			return MowingRiskModel.Instance.IsInstanceUnlockedByInstanceId(id);
		}

		// Token: 0x060402CF RID: 262863 RVA: 0x00F8A349 File Offset: 0x00F88549
		public string GetInstanceLockTextIdByInstanceId(int id)
		{
			return MowingRiskModel.Instance.GetInstanceLockTextIdByInstanceId(id);
		}

		// Token: 0x060402D0 RID: 262864 RVA: 0x00F8A356 File Offset: 0x00F88556
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] GetInstanceLockTextArgsByInstanceId(int id)
		{
			return MowingRiskModel.Instance.GetLockTextArgsByInstanceId(id);
		}

		// Token: 0x060402D1 RID: 262865 RVA: 0x00F8A364 File Offset: 0x00F88564
		public IInstanceDungeonEntranceViewSelectData GetEntranceViewDefaultSelectData(Dictionary<int, List<int>> instanceByTitleMap)
		{
			int seriesId = 0;
			int instanceId = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in instanceByTitleMap)
			{
				seriesId = keyValuePair.Key;
				foreach (int num in keyValuePair.Value)
				{
					instanceId = num;
					if (!this.CheckInstanceFinishedByInstanceId(num))
					{
						return new InstanceDungeonEntranceViewSelectData
						{
							InstanceId = instanceId,
							SeriesId = seriesId
						};
					}
				}
			}
			return new InstanceDungeonEntranceViewSelectData
			{
				InstanceId = instanceId,
				SeriesId = seriesId
			};
		}

		// Token: 0x1700936D RID: 37741
		// (get) Token: 0x060402D2 RID: 262866 RVA: 0x00F8A430 File Offset: 0x00F88630
		public static ActivityMowingRiskController Instance
		{
			get
			{
				return ActivityMowingRiskController._Instance;
			}
		}

		// Token: 0x060402D3 RID: 262867 RVA: 0x00F8A437 File Offset: 0x00F88637
		public static ActivityMowingRiskController GetOrCreateInstance()
		{
			if (ActivityMowingRiskController._Instance == null)
			{
				ActivityMowingRiskController.CreateInstance();
			}
			return ActivityMowingRiskController._Instance;
		}

		// Token: 0x060402D4 RID: 262868 RVA: 0x00F8A44B File Offset: 0x00F8864B
		public static bool CreateInstance()
		{
			if (ActivityMowingRiskController._Instance != null)
			{
				return true;
			}
			ActivityMowingRiskController._Instance = new ActivityMowingRiskController();
			return true;
		}

		// Token: 0x060402D5 RID: 262869 RVA: 0x00F8A461 File Offset: 0x00F88661
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060402D6 RID: 262870 RVA: 0x00F8A463 File Offset: 0x00F88663
		public static void ResetStaticDefaultValue()
		{
			ActivityMowingRiskController._Instance = null;
		}

		// Token: 0x060402D7 RID: 262871 RVA: 0x00F8A46B File Offset: 0x00F8866B
		static ActivityMowingRiskController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMowingRiskController.CreateStaticDefaultValue), new Action(ActivityMowingRiskController.ResetStaticDefaultValue));
		}

		// Token: 0x040216C5 RID: 136901
		private CustomPromise BeInInstancePromise = new CustomPromise();

		// Token: 0x040216C6 RID: 136902
		[Nullable(2)]
		private static ActivityMowingRiskController _Instance;
	}
}
