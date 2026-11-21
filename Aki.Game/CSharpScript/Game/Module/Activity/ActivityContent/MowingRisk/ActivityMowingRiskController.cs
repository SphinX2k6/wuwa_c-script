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
	// Token: 0x02005322 RID: 21282
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityMowingRiskController : ActivityControllerBase
	{
		// Token: 0x06034F6A RID: 216938 RVA: 0x00ED06AD File Offset: 0x00ECE8AD
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06034F6B RID: 216939 RVA: 0x00ED06AF File Offset: 0x00ECE8AF
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityMowingRisk";
		}

		// Token: 0x06034F6C RID: 216940 RVA: 0x00ED06B6 File Offset: 0x00ECE8B6
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityMowingRiskSubView();
		}

		// Token: 0x06034F6D RID: 216941 RVA: 0x00ED06BD File Offset: 0x00ECE8BD
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			MowingRiskModel.Instance.InitContext();
			return MowingRiskModel.Instance.ActivityData;
		}

		// Token: 0x06034F6E RID: 216942 RVA: 0x00ED06D3 File Offset: 0x00ECE8D3
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06034F6F RID: 216943 RVA: 0x00ED06D8 File Offset: 0x00ECE8D8
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RiskHarvestEndNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleRiskHarvestEndNotify));
			Net.Instance.Register(ENotifyMessageId.RiskHarvestInstUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleRiskHarvestInstUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RiskHarvestArtifactNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleRiskHarvestArtifactNotify));
			Net.Instance.Register(ENotifyMessageId.RiskHarvestBuffUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleRiskHarvestBuffUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RiskHarvestBuffUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleRiskHarvestBuffUnlockNotify));
			Net.Instance.Register(ENotifyMessageId.RiskHarvestActivityUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleRiskHarvestActivityUpdateNotify));
		}

		// Token: 0x06034F70 RID: 216944 RVA: 0x00ED0790 File Offset: 0x00ECE990
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RiskHarvestEndNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RiskHarvestInstUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RiskHarvestArtifactNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RiskHarvestBuffUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RiskHarvestBuffUnlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RiskHarvestActivityUpdateNotify);
		}

		// Token: 0x06034F71 RID: 216945 RVA: 0x00ED0800 File Offset: 0x00ECEA00
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.EnterInstanceDungeon, new Action(this.HandleEnterInstanceDungeon));
			EventSystem.Instance.Add(EEventName.LeaveInstanceDungeon, new Action(this.HandleLeaveInstanceDungeon));
			EventSystem.Instance.Add(EEventName.LeaveInstanceDungeonConfirm, new Action(this.HandleLeaveInstanceDungeonConfirm));
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.HandleWorldDoneAndCloseLoading));
			EventSystem.Instance.Add(EEventName.MowingRiskOnBuffTipsAfterDestroy, new Action(this.HandleMowingRiskOnBuffTipsAfterDestroy));
		}

		// Token: 0x06034F72 RID: 216946 RVA: 0x00ED089C File Offset: 0x00ECEA9C
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.EnterInstanceDungeon, new Action(this.HandleEnterInstanceDungeon));
			EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeon, new Action(this.HandleLeaveInstanceDungeon));
			EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeonConfirm, new Action(this.HandleLeaveInstanceDungeonConfirm));
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.HandleWorldDoneAndCloseLoading));
			EventSystem.Instance.Remove(EEventName.MowingRiskOnBuffTipsAfterDestroy, new Action(this.HandleMowingRiskOnBuffTipsAfterDestroy));
		}

		// Token: 0x06034F73 RID: 216947 RVA: 0x00ED0935 File Offset: 0x00ECEB35
		public override bool GetActivityLevelUnlockState(int instanceId)
		{
			return MowingRiskModel.Instance.IsInstanceUnlockedByInstanceId(instanceId);
		}

		// Token: 0x06034F74 RID: 216948 RVA: 0x00ED0944 File Offset: 0x00ECEB44
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

		// Token: 0x06034F75 RID: 216949 RVA: 0x00ED0984 File Offset: 0x00ECEB84
		[NullableContext(2)]
		private void HandleRiskHarvestInstUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RiskHarvestInstUpdateNotify riskHarvestInstUpdateNotify = (RiskHarvestInstUpdateNotify)msg;
			this.DumpNotifyMessage(riskHarvestInstUpdateNotify);
			MowingRiskModel.Instance.SyncProtocolRiskHarvestInstUpdateNotify(riskHarvestInstUpdateNotify);
		}

		// Token: 0x06034F76 RID: 216950 RVA: 0x00ED09AC File Offset: 0x00ECEBAC
		[NullableContext(2)]
		private void HandleRiskHarvestArtifactNotify(IMessage msg, Net.CallbackStatus status)
		{
			RiskHarvestArtifactNotify riskHarvestArtifactNotify = (RiskHarvestArtifactNotify)msg;
			this.DumpNotifyMessage(riskHarvestArtifactNotify);
			MowingRiskModel.Instance.SyncProtocolRiskHarvestArtifactNotify(riskHarvestArtifactNotify);
		}

		// Token: 0x06034F77 RID: 216951 RVA: 0x00ED09D4 File Offset: 0x00ECEBD4
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

		// Token: 0x06034F78 RID: 216952 RVA: 0x00ED0A18 File Offset: 0x00ECEC18
		[NullableContext(2)]
		private void HandleRiskHarvestBuffUnlockNotify(IMessage msg, Net.CallbackStatus status)
		{
			RiskHarvestBuffUnlockNotify riskHarvestBuffUnlockNotify = (RiskHarvestBuffUnlockNotify)msg;
			this.DumpNotifyMessage(riskHarvestBuffUnlockNotify);
			MowingRiskModel.Instance.SyncProtocolRiskHarvestBuffUnlockNotify(riskHarvestBuffUnlockNotify);
		}

		// Token: 0x06034F79 RID: 216953 RVA: 0x00ED0A40 File Offset: 0x00ECEC40
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

		// Token: 0x06034F7A RID: 216954 RVA: 0x00ED0AC0 File Offset: 0x00ECECC0
		public UniTask RequestRiskHarvestInstRewardRequest(int id)
		{
			ActivityMowingRiskController.<RequestRiskHarvestInstRewardRequest>d__17 <RequestRiskHarvestInstRewardRequest>d__;
			<RequestRiskHarvestInstRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRiskHarvestInstRewardRequest>d__.id = id;
			<RequestRiskHarvestInstRewardRequest>d__.<>1__state = -1;
			<RequestRiskHarvestInstRewardRequest>d__.<>t__builder.Start<ActivityMowingRiskController.<RequestRiskHarvestInstRewardRequest>d__17>(ref <RequestRiskHarvestInstRewardRequest>d__);
			return <RequestRiskHarvestInstRewardRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06034F7B RID: 216955 RVA: 0x00ED0B04 File Offset: 0x00ECED04
		public UniTask RequestRiskHarvestScoreRewardRequest(int id)
		{
			ActivityMowingRiskController.<RequestRiskHarvestScoreRewardRequest>d__18 <RequestRiskHarvestScoreRewardRequest>d__;
			<RequestRiskHarvestScoreRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRiskHarvestScoreRewardRequest>d__.id = id;
			<RequestRiskHarvestScoreRewardRequest>d__.<>1__state = -1;
			<RequestRiskHarvestScoreRewardRequest>d__.<>t__builder.Start<ActivityMowingRiskController.<RequestRiskHarvestScoreRewardRequest>d__18>(ref <RequestRiskHarvestScoreRewardRequest>d__);
			return <RequestRiskHarvestScoreRewardRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06034F7C RID: 216956 RVA: 0x00ED0B48 File Offset: 0x00ECED48
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

		// Token: 0x06034F7D RID: 216957 RVA: 0x00ED0B94 File Offset: 0x00ECED94
		public UniTask RequestRiskHarvestSettleRequest()
		{
			ActivityMowingRiskController.<RequestRiskHarvestSettleRequest>d__20 <RequestRiskHarvestSettleRequest>d__;
			<RequestRiskHarvestSettleRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRiskHarvestSettleRequest>d__.<>1__state = -1;
			<RequestRiskHarvestSettleRequest>d__.<>t__builder.Start<ActivityMowingRiskController.<RequestRiskHarvestSettleRequest>d__20>(ref <RequestRiskHarvestSettleRequest>d__);
			return <RequestRiskHarvestSettleRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06034F7E RID: 216958 RVA: 0x00ED0BCF File Offset: 0x00ECEDCF
		private void HandleLeaveInstanceDungeonConfirm()
		{
			if (!this.CheckInInstanceDungeon())
			{
				return;
			}
			this.RequestRiskHarvestSettleRequest().Forget();
		}

		// Token: 0x06034F7F RID: 216959 RVA: 0x00ED0BE5 File Offset: 0x00ECEDE5
		private void HandleEnterInstanceDungeon()
		{
		}

		// Token: 0x06034F80 RID: 216960 RVA: 0x00ED0BE7 File Offset: 0x00ECEDE7
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

		// Token: 0x06034F81 RID: 216961 RVA: 0x00ED0C12 File Offset: 0x00ECEE12
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

		// Token: 0x06034F82 RID: 216962 RVA: 0x00ED0C4E File Offset: 0x00ECEE4E
		private void HandleMowingRiskOnBuffTipsAfterDestroy()
		{
			this.TryOpenNewBuffTips();
		}

		// Token: 0x06034F83 RID: 216963 RVA: 0x00ED0C56 File Offset: 0x00ECEE56
		private void DumpNotifyMessage(object msg)
		{
		}

		// Token: 0x06034F84 RID: 216964 RVA: 0x00ED0C58 File Offset: 0x00ECEE58
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

		// Token: 0x06034F85 RID: 216965 RVA: 0x00ED0CFC File Offset: 0x00ECEEFC
		private void TryShowBuffBigTip(int buffId)
		{
			IMowingRiskInBattleBuffData extraParam = MowingRiskModel.Instance.BuildInBattleBuffDataById(buffId);
			GenericPromptController.Instance.ShowPromptByItsType<IMowingRiskInBattleBuffData>(EPromptSubViewType.MowingRiskBuff, null, null, null, null, null, null, extraParam, null, false, null);
		}

		// Token: 0x06034F86 RID: 216966 RVA: 0x00ED0D3C File Offset: 0x00ECEF3C
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

		// Token: 0x06034F87 RID: 216967 RVA: 0x00ED0D88 File Offset: 0x00ECEF88
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
				InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false).Forget<bool>();
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

		// Token: 0x06034F88 RID: 216968 RVA: 0x00ED0F60 File Offset: 0x00ECF160
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
				InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false).Forget<bool>();
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

		// Token: 0x06034F89 RID: 216969 RVA: 0x00ED1188 File Offset: 0x00ECF388
		private UniTask WaitForBeInInstance()
		{
			ActivityMowingRiskController.<WaitForBeInInstance>d__32 <WaitForBeInInstance>d__;
			<WaitForBeInInstance>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitForBeInInstance>d__.<>4__this = this;
			<WaitForBeInInstance>d__.<>1__state = -1;
			<WaitForBeInInstance>d__.<>t__builder.Start<ActivityMowingRiskController.<WaitForBeInInstance>d__32>(ref <WaitForBeInInstance>d__);
			return <WaitForBeInInstance>d__.<>t__builder.Task;
		}

		// Token: 0x06034F8A RID: 216970 RVA: 0x00ED11CC File Offset: 0x00ECF3CC
		public bool CheckInInstanceDungeon()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
				return instanceDungeon != null && instanceDungeon.Value.InstSubType == 22;
			}
			return false;
		}

		// Token: 0x06034F8B RID: 216971 RVA: 0x00ED1210 File Offset: 0x00ECF410
		public bool IsMowingRiskInstanceDungeon(int instanceId)
		{
			if (instanceId <= 0)
			{
				return false;
			}
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.GetValueOrDefault().InstSubType == 22;
		}

		// Token: 0x06034F8C RID: 216972 RVA: 0x00ED124D File Offset: 0x00ECF44D
		[NullableContext(2)]
		public string GetInstanceSubtitleTextIdByInstanceId(int id)
		{
			return MowingRiskModel.Instance.BuildInstanceSubtitleTextIdByInstanceId(id);
		}

		// Token: 0x06034F8D RID: 216973 RVA: 0x00ED125A File Offset: 0x00ECF45A
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] GetInstanceSubtitleArgsByInstanceId(int id)
		{
			return MowingRiskModel.Instance.BuildInstanceSubtitleTextArgsByInstanceId(id);
		}

		// Token: 0x06034F8E RID: 216974 RVA: 0x00ED1267 File Offset: 0x00ECF467
		public bool CheckInstanceFinishedByInstanceId(int id)
		{
			return MowingRiskModel.Instance.CheckInstanceFinishedByInstanceId(id);
		}

		// Token: 0x06034F8F RID: 216975 RVA: 0x00ED1274 File Offset: 0x00ECF474
		public bool CheckInstanceUnlockByInstanceId(int id)
		{
			return MowingRiskModel.Instance.IsInstanceUnlockedByInstanceId(id);
		}

		// Token: 0x06034F90 RID: 216976 RVA: 0x00ED1281 File Offset: 0x00ECF481
		public string GetInstanceLockTextIdByInstanceId(int id)
		{
			return MowingRiskModel.Instance.GetInstanceLockTextIdByInstanceId(id);
		}

		// Token: 0x06034F91 RID: 216977 RVA: 0x00ED128E File Offset: 0x00ECF48E
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] GetInstanceLockTextArgsByInstanceId(int id)
		{
			return MowingRiskModel.Instance.GetLockTextArgsByInstanceId(id);
		}

		// Token: 0x06034F92 RID: 216978 RVA: 0x00ED129C File Offset: 0x00ECF49C
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

		// Token: 0x170066CF RID: 26319
		// (get) Token: 0x06034F93 RID: 216979 RVA: 0x00ED1368 File Offset: 0x00ECF568
		public static ActivityMowingRiskController Instance
		{
			get
			{
				return ActivityMowingRiskController._Instance;
			}
		}

		// Token: 0x06034F94 RID: 216980 RVA: 0x00ED136F File Offset: 0x00ECF56F
		public static ActivityMowingRiskController GetOrCreateInstance()
		{
			if (ActivityMowingRiskController._Instance == null)
			{
				ActivityMowingRiskController.CreateInstance();
			}
			return ActivityMowingRiskController._Instance;
		}

		// Token: 0x06034F95 RID: 216981 RVA: 0x00ED1383 File Offset: 0x00ECF583
		public static bool CreateInstance()
		{
			if (ActivityMowingRiskController._Instance != null)
			{
				return true;
			}
			ActivityMowingRiskController._Instance = new ActivityMowingRiskController();
			return true;
		}

		// Token: 0x06034F96 RID: 216982 RVA: 0x00ED1399 File Offset: 0x00ECF599
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034F97 RID: 216983 RVA: 0x00ED139B File Offset: 0x00ECF59B
		public static void ResetStaticDefaultValue()
		{
			ActivityMowingRiskController._Instance = null;
		}

		// Token: 0x06034F98 RID: 216984 RVA: 0x00ED13A3 File Offset: 0x00ECF5A3
		static ActivityMowingRiskController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMowingRiskController.CreateStaticDefaultValue), new Action(ActivityMowingRiskController.ResetStaticDefaultValue));
		}

		// Token: 0x0401BFF4 RID: 114676
		private CustomPromise BeInInstancePromise = new CustomPromise();

		// Token: 0x0401BFF5 RID: 114677
		[Nullable(2)]
		private static ActivityMowingRiskController _Instance;
	}
}
