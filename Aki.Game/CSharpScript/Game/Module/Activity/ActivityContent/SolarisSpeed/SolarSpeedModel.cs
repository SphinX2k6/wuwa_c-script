using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Personal;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005027 RID: 20519
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SolarSpeedModel : ModelBase
	{
		// Token: 0x060335B0 RID: 210352 RVA: 0x00E658B3 File Offset: 0x00E63AB3
		protected override bool OnInit()
		{
			this.ConfigContext = new SolarSpeedConfigContext(this);
			this.ProtocolContext = new SolarSpeedProtocolContext(this);
			this.UiContext = new SolarSpeedUiContext();
			return true;
		}

		// Token: 0x060335B1 RID: 210353 RVA: 0x00E658D9 File Offset: 0x00E63AD9
		protected override bool OnClear()
		{
			this.ConfigContext.Dispose();
			this.ProtocolContext.Dispose();
			this.UiContext.Dispose();
			return true;
		}

		// Token: 0x17006403 RID: 25603
		// (get) Token: 0x060335B2 RID: 210354 RVA: 0x00E658FD File Offset: 0x00E63AFD
		public int CurrentActivityId
		{
			get
			{
				return this.ProtocolContext.Id;
			}
		}

		// Token: 0x17006404 RID: 25604
		// (get) Token: 0x060335B3 RID: 210355 RVA: 0x00E6590A File Offset: 0x00E63B0A
		public ActivityBaseData ActivityData
		{
			get
			{
				return this.ProtocolContext;
			}
		}

		// Token: 0x17006405 RID: 25605
		// (get) Token: 0x060335B4 RID: 210356 RVA: 0x00E65914 File Offset: 0x00E63B14
		public string ActivityTitleTextId
		{
			get
			{
				SolarSpeedProtocolContext protocolContext = this.ProtocolContext;
				return ((protocolContext.LocalConfig != null) ? protocolContext.LocalConfig.GetValueOrDefault().Title : null) ?? "";
			}
		}

		// Token: 0x17006406 RID: 25606
		// (get) Token: 0x060335B5 RID: 210357 RVA: 0x00E65950 File Offset: 0x00E63B50
		public string ActivityIconPath
		{
			get
			{
				SolarSpeedProtocolContext protocolContext = this.ProtocolContext;
				return ((protocolContext.LocalConfig != null) ? protocolContext.LocalConfig.GetValueOrDefault().TabResource : null) ?? "";
			}
		}

		// Token: 0x17006407 RID: 25607
		// (get) Token: 0x060335B6 RID: 210358 RVA: 0x00E6598C File Offset: 0x00E63B8C
		public string InstanceEntranceIconPath
		{
			get
			{
				InstanceDungeonEntrance? config = InstanceDungeonEntranceConfig.Instance.GetConfig(9000);
				return ((config != null) ? config.GetValueOrDefault().TitleSprite : null) ?? "";
			}
		}

		// Token: 0x17006408 RID: 25608
		// (get) Token: 0x060335B7 RID: 210359 RVA: 0x00E659CD File Offset: 0x00E63BCD
		public int? CurrentChosenTabInRewardView
		{
			get
			{
				return this.UiContext.CurrentChosenTabInRewardView;
			}
		}

		// Token: 0x17006409 RID: 25609
		// (get) Token: 0x060335B8 RID: 210360 RVA: 0x00E659DC File Offset: 0x00E63BDC
		public bool HasLevelRedDot
		{
			get
			{
				foreach (KeyValuePair<int, TeamParKOurCfg> keyValuePair in this.ConfigContext.CurrentCfgCache)
				{
					int num;
					TeamParKOurCfg teamParKOurCfg;
					keyValuePair.Deconstruct(out num, out teamParKOurCfg);
					int id = num;
					if (this.HasRedDotById(id))
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x1700640A RID: 25610
		// (get) Token: 0x060335B9 RID: 210361 RVA: 0x00E65A4C File Offset: 0x00E63C4C
		public bool HasRewardRedDot
		{
			get
			{
				foreach (KeyValuePair<int, TeamParKOurReward> keyValuePair in this.ConfigContext.CurrentRewardCache)
				{
					int num;
					TeamParKOurReward teamParKOurReward;
					keyValuePair.Deconstruct(out num, out teamParKOurReward);
					int id = num;
					if (this.ProtocolContext.GetTaskStateById(id).GetValueOrDefault() == ActivityTaskState.ActivityTaskFinish)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x1700640B RID: 25611
		// (get) Token: 0x060335BA RID: 210362 RVA: 0x00E65ACC File Offset: 0x00E63CCC
		public int TotalRewardCount
		{
			get
			{
				return this.ConfigContext.CurrentRewardCache.Count;
			}
		}

		// Token: 0x1700640C RID: 25612
		// (get) Token: 0x060335BB RID: 210363 RVA: 0x00E65AE0 File Offset: 0x00E63CE0
		public int CurrentCompletedCount
		{
			get
			{
				int num = 0;
				foreach (KeyValuePair<int, TeamParKOurReward> keyValuePair in this.ConfigContext.CurrentRewardCache)
				{
					int num2;
					TeamParKOurReward teamParKOurReward;
					keyValuePair.Deconstruct(out num2, out teamParKOurReward);
					int id = num2;
					ActivityTaskState? taskStateById = this.ProtocolContext.GetTaskStateById(id);
					if (taskStateById != null)
					{
						ActivityTaskState? activityTaskState = taskStateById;
						ActivityTaskState activityTaskState2 = ActivityTaskState.ActivityTaskRunning;
						if (activityTaskState.GetValueOrDefault() > activityTaskState2 & activityTaskState != null)
						{
							num++;
						}
					}
				}
				return num;
			}
		}

		// Token: 0x1700640D RID: 25613
		// (get) Token: 0x060335BC RID: 210364 RVA: 0x00E65B7C File Offset: 0x00E63D7C
		public int DefaultLevelIdInRewardView
		{
			get
			{
				this.UiContext.CurrentChosenTabInRewardView = new int?(1);
				return this.UiContext.CurrentChosenTabInRewardView.Value;
			}
		}

		// Token: 0x060335BD RID: 210365 RVA: 0x00E65B9F File Offset: 0x00E63D9F
		[NullableContext(2)]
		public string GetInfoPicturePathByInstanceId(int instanceId)
		{
			return this.ConfigContext.GetInfoPicturePathByInstanceId(instanceId);
		}

		// Token: 0x060335BE RID: 210366 RVA: 0x00E65BB0 File Offset: 0x00E63DB0
		[NullableContext(2)]
		public string GetIconPathInInstanceSeriesItemByInstanceId(int instanceId)
		{
			int? levelIdByInstanceId = this.ConfigContext.GetLevelIdByInstanceId(instanceId);
			if (levelIdByInstanceId == null)
			{
				return null;
			}
			int rankingById = this.ProtocolContext.GetRankingById(levelIdByInstanceId.Value);
			return this.GetMedalPathByRank(rankingById);
		}

		// Token: 0x060335BF RID: 210367 RVA: 0x00E65BF0 File Offset: 0x00E63DF0
		public int GetHistoryHighScoreInSettleView()
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			return this.GetHistoryHighScoreByInstanceId(instanceId).GetValueOrDefault();
		}

		// Token: 0x060335C0 RID: 210368 RVA: 0x00E65C18 File Offset: 0x00E63E18
		public int? GetHistoryRankByInstanceId(int instanceId)
		{
			int? levelIdByInstanceId = this.ConfigContext.GetLevelIdByInstanceId(instanceId);
			if (levelIdByInstanceId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSpeed;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "不能通过instanceId找到levelId，策划检查配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("instanceId", instanceId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return new int?(this.ProtocolContext.GetRankingById(levelIdByInstanceId.Value));
		}

		// Token: 0x060335C1 RID: 210369 RVA: 0x00E65C8C File Offset: 0x00E63E8C
		public int? GetHistoryHighScoreByInstanceId(int instanceId)
		{
			int? levelIdByInstanceId = this.ConfigContext.GetLevelIdByInstanceId(instanceId);
			if (levelIdByInstanceId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSpeed;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "不能通过instanceId找到levelId，策划检查配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("instanceId", instanceId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return new int?(this.ProtocolContext.GetScoreById(levelIdByInstanceId.Value));
		}

		// Token: 0x060335C2 RID: 210370 RVA: 0x00E65D00 File Offset: 0x00E63F00
		public int? GetHistoryLapRecordByInstanceId(int instanceId)
		{
			int? levelIdByInstanceId = this.ConfigContext.GetLevelIdByInstanceId(instanceId);
			if (levelIdByInstanceId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSpeed;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "不能通过instanceId找到levelId，策划检查配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("instanceId", instanceId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return new int?(this.ProtocolContext.GetLapRecord(levelIdByInstanceId.Value));
		}

		// Token: 0x060335C3 RID: 210371 RVA: 0x00E65D74 File Offset: 0x00E63F74
		[NullableContext(2)]
		public string GetMedalPathByRank(int rank)
		{
			if (rank < 1 || rank > SolarSpeedDefine.medalTexPathMap.Count)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSpeed;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "rank值超出奖牌资源索引范围";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("rank", rank);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return SolarSpeedDefine.medalTexPathMap[rank - 1];
		}

		// Token: 0x060335C4 RID: 210372 RVA: 0x00E65DD0 File Offset: 0x00E63FD0
		[NullableContext(2)]
		public string GetInstanceSubtitleTextIdByInstanceId(int instanceId)
		{
			int? levelIdByInstanceId = this.ConfigContext.GetLevelIdByInstanceId(instanceId);
			if (levelIdByInstanceId == null)
			{
				return null;
			}
			if (!this.IsUnlockById(levelIdByInstanceId.Value))
			{
				return "LianjiPaokuReward_Level_UnLock";
			}
			if (this.ProtocolContext.GetRankingById(levelIdByInstanceId.Value) == 0)
			{
				return "LianjiPaokuReward_Level_NoRecords";
			}
			return "LianjiPaokuReward_Level_TopScore";
		}

		// Token: 0x060335C5 RID: 210373 RVA: 0x00E65E2C File Offset: 0x00E6402C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] GetInstanceSubtitleArgsByInstanceId(int instanceId)
		{
			int? levelIdByInstanceId = this.ConfigContext.GetLevelIdByInstanceId(instanceId);
			if (levelIdByInstanceId == null)
			{
				return null;
			}
			if (this.IsUnlockById(levelIdByInstanceId.Value))
			{
				if (this.ProtocolContext.GetRankingById(levelIdByInstanceId.Value) == 0)
				{
					return null;
				}
				return new string[]
				{
					this.ProtocolContext.GetScoreById(levelIdByInstanceId.Value).ToString()
				};
			}
			else
			{
				string countDownText = TimeUtil.Instance.GetRemainTimeDataFormat3((double)this.ProtocolContext.GetStartTime(levelIdByInstanceId.Value) - TimeUtil.Instance.GetServerTime()).CountDownText;
				if (countDownText != null)
				{
					return new string[]
					{
						countDownText
					};
				}
				return null;
			}
		}

		// Token: 0x060335C6 RID: 210374 RVA: 0x00E65ED8 File Offset: 0x00E640D8
		[NullableContext(2)]
		public string GetInstanceUnlockTextIdByInstanceId(int instanceId)
		{
			int? levelIdByInstanceId = this.ConfigContext.GetLevelIdByInstanceId(instanceId);
			if (levelIdByInstanceId == null)
			{
				return null;
			}
			if (this.IsUnlockById(levelIdByInstanceId.Value))
			{
				return InstanceDungeonConfig.Instance.GetUnlockConditionGroupHintText(instanceId);
			}
			return "LianjiPaokuReward_Level_UnLock";
		}

		// Token: 0x060335C7 RID: 210375 RVA: 0x00E65F20 File Offset: 0x00E64120
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] GetInstanceUnlockArgsByInstanceId(int instanceId)
		{
			int? levelIdByInstanceId = this.ConfigContext.GetLevelIdByInstanceId(instanceId);
			if (levelIdByInstanceId == null)
			{
				return null;
			}
			if (this.IsUnlockById(levelIdByInstanceId.Value))
			{
				return null;
			}
			string countDownText = TimeUtil.Instance.GetRemainTimeDataFormat3((double)this.ProtocolContext.GetStartTime(levelIdByInstanceId.Value) - TimeUtil.Instance.GetServerTime()).CountDownText;
			if (countDownText != null)
			{
				return new string[]
				{
					countDownText
				};
			}
			return null;
		}

		// Token: 0x060335C8 RID: 210376 RVA: 0x00E65F94 File Offset: 0x00E64194
		public bool IsUnlockByInstanceId(int instanceId)
		{
			int? levelIdByInstanceId = this.ConfigContext.GetLevelIdByInstanceId(instanceId);
			return levelIdByInstanceId != null && this.IsUnlockById(levelIdByInstanceId.Value);
		}

		// Token: 0x060335C9 RID: 210377 RVA: 0x00E65FC8 File Offset: 0x00E641C8
		public bool IsClickedById(int instanceId)
		{
			Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.SolarSpeedInstanceClicked, null);
			bool flag;
			return player != null && (player.TryGetValue(instanceId, out flag) && flag);
		}

		// Token: 0x060335CA RID: 210378 RVA: 0x00E65FEE File Offset: 0x00E641EE
		public bool IsUnlockById(int id)
		{
			return (double)this.ProtocolContext.GetStartTime(id) < TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x060335CB RID: 210379 RVA: 0x00E66009 File Offset: 0x00E64209
		public bool HasRedDotById(int id)
		{
			return !this.IsClickedById(id) && this.IsUnlockById(id);
		}

		// Token: 0x060335CC RID: 210380 RVA: 0x00E66020 File Offset: 0x00E64220
		public bool HasRedDotByInstanceId(int instanceId)
		{
			int? levelIdByInstanceId = this.ConfigContext.GetLevelIdByInstanceId(instanceId);
			return levelIdByInstanceId != null && this.HasRedDotById(levelIdByInstanceId.Value);
		}

		// Token: 0x060335CD RID: 210381 RVA: 0x00E66052 File Offset: 0x00E64252
		public void SetCurrentChosenTabInRewardView(int id)
		{
			this.UiContext.CurrentChosenTabInRewardView = new int?(id);
		}

		// Token: 0x060335CE RID: 210382 RVA: 0x00E66065 File Offset: 0x00E64265
		public void SyncTeamParkourTaskNotify(TeamParkourTaskNotify msg)
		{
			this.ProtocolContext.ParseTeamParkourTaskNotify(msg);
		}

		// Token: 0x060335CF RID: 210383 RVA: 0x00E66073 File Offset: 0x00E64273
		public void SyncTeamParkourSettleNotify(TeamParkourSettleNotify msg)
		{
			this.ProtocolContext.ParseTeamParkourSettleNotify(msg);
		}

		// Token: 0x060335D0 RID: 210384 RVA: 0x00E66084 File Offset: 0x00E64284
		public void SyncInstanceClicked(int instanceId)
		{
			int? levelIdByInstanceId = this.ConfigContext.GetLevelIdByInstanceId(instanceId);
			if (levelIdByInstanceId == null)
			{
				return;
			}
			if (!this.IsUnlockById(levelIdByInstanceId.Value))
			{
				return;
			}
			Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.SolarSpeedInstanceClicked, null);
			if (dictionary == null)
			{
				dictionary = new Dictionary<int, bool>();
			}
			if (!dictionary.ContainsKey(levelIdByInstanceId.Value))
			{
				dictionary.Add(levelIdByInstanceId.Value, true);
				LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.SolarSpeedInstanceClicked, dictionary);
			}
		}

		// Token: 0x060335D1 RID: 210385 RVA: 0x00E660F0 File Offset: 0x00E642F0
		public void SyncAfterRewardedById(int id)
		{
			this.ProtocolContext.SetTaskStateRewardedById(id);
		}

		// Token: 0x060335D2 RID: 210386 RVA: 0x00E66100 File Offset: 0x00E64300
		public ISolarSpeedRewardViewData BuildSolarSpeedRewardViewDataById(int id)
		{
			return new SolarSpeedRewardViewData
			{
				TitleTextId = this.ActivityTitleTextId,
				TitleIconPath = this.InstanceEntranceIconPath,
				Score = this.ProtocolContext.GetScoreById(id).ToString(),
				RewardPanelData = new SolarSpeedRewardPanelData
				{
					TabDataList = this.BuildTabCellPanelDataListInRewardView(id),
					RewardDataList = this.BuildRewardCellPanelDataListInRewardViewById(id)
				}
			};
		}

		// Token: 0x060335D3 RID: 210387 RVA: 0x00E6616C File Offset: 0x00E6436C
		private SettleFlag? GetSettleFlagCfgByPlayerSettleInfo(PlayerSettleInfo msg)
		{
			foreach (SettleFlag value in this.ConfigContext.SortedSettleCfgCache)
			{
				switch (value.Id)
				{
				case 1:
					if (msg.Finish && msg.ConsumeTime < value.Args)
					{
						return new SettleFlag?(value);
					}
					break;
				case 2:
					if (msg.Ranking == value.Args)
					{
						return new SettleFlag?(value);
					}
					break;
				case 4:
					if (msg.Ranking != 1 && msg.Finish)
					{
						return new SettleFlag?(value);
					}
					break;
				case 6:
					if (msg.DistancePoints > value.Args && !msg.Finish)
					{
						return new SettleFlag?(value);
					}
					break;
				case 7:
					return new SettleFlag?(value);
				}
			}
			return null;
		}

		// Token: 0x060335D4 RID: 210388 RVA: 0x00E6627C File Offset: 0x00E6447C
		private bool GetRedDotStateInRewardViewById(int id)
		{
			TeamParKOurCfg teamParKOurCfg;
			int[] array = this.ConfigContext.CurrentCfgCache.TryGetValue(id, out teamParKOurCfg) ? teamParKOurCfg.GetTaskListArray() : null;
			if (array == null)
			{
				return false;
			}
			foreach (int id2 in array)
			{
				if (this.ProtocolContext.GetTaskStateById(id2).GetValueOrDefault() == ActivityTaskState.ActivityTaskFinish)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060335D5 RID: 210389 RVA: 0x00E662E0 File Offset: 0x00E644E0
		private bool GetRedDotStateInRewardViewBonus()
		{
			foreach (int id in SolarSpeedDefine.bonusRewardList)
			{
				if (this.ProtocolContext.GetTaskStateById(id).GetValueOrDefault() == ActivityTaskState.ActivityTaskFinish)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060335D6 RID: 210390 RVA: 0x00E66344 File Offset: 0x00E64544
		public ISolarSpeedResultViewData BuildSolarSpeedResultViewData()
		{
			Dictionary<int, PlayerSettleInfo> playerSettleMsgCache = this.ProtocolContext.PlayerSettleMsgCache;
			List<ISolarSpeedRolePanelData> list = new List<ISolarSpeedRolePanelData>();
			foreach (KeyValuePair<int, PlayerSettleInfo> keyValuePair in playerSettleMsgCache)
			{
				int num;
				PlayerSettleInfo playerSettleInfo;
				keyValuePair.Deconstruct(out num, out playerSettleInfo);
				PlayerSettleInfo playerSettleInfo2 = playerSettleInfo;
				int playerId = playerSettleInfo2.PlayerId;
				int ranking = playerSettleInfo2.Ranking;
				int index = ranking - 1;
				OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(playerId);
				bool flag = currentTeamListById != null && currentTeamListById.IsSelf;
				int index2 = (currentTeamListById != null) ? (currentTeamListById.PlayerNumber - 1) : 0;
				SettleFlag? settleFlagCfgByPlayerSettleInfo = this.GetSettleFlagCfgByPlayerSettleInfo(playerSettleInfo2);
				SolarSpeedRolePanelData item = new SolarSpeedRolePanelData
				{
					Rank = ranking,
					PlayerId = playerId,
					IsAddButtonAvailable = (!flag && !FriendModel.Instance.IsMyFriend(playerId)),
					IsSelf = flag,
					BgPath = SolarSpeedDefine.rankBgPathMap[index],
					MedalTexturePath = SolarSpeedDefine.medalTexPathMap[index],
					MedalColorHex = SolarSpeedDefine.medalColorHex[index],
					FxColorHex = SolarSpeedDefine.fxColorHex[index],
					PlayerIndexIconPath = (flag ? SolarSpeedDefine.playerIndexSelfIconMap[index2] : SolarSpeedDefine.playerIndexIconMap[index2]),
					NameText = (((currentTeamListById != null) ? currentTeamListById.PlayerName : null) ?? ""),
					DescTextId = (((settleFlagCfgByPlayerSettleInfo != null) ? settleFlagCfgByPlayerSettleInfo.GetValueOrDefault().Content : null) ?? ""),
					TitleTextId = (((settleFlagCfgByPlayerSettleInfo != null) ? settleFlagCfgByPlayerSettleInfo.GetValueOrDefault().Title : null) ?? ""),
					IconData = new SolarSpeedRoleIconPanelData
					{
						IconPath = ((currentTeamListById == null) ? "" : PersonalModel.Instance.GetPlayerHeadData(currentTeamListById.HeadId, false).GetRoleHeadIconCircle())
					}
				};
				list.Add(item);
			}
			list.Sort((ISolarSpeedRolePanelData a, ISolarSpeedRolePanelData b) => a.Rank - b.Rank);
			if (list.Count > 1)
			{
				ISolarSpeedRolePanelData value = list[0];
				list[0] = list[1];
				list[1] = value;
			}
			SolarSpeedResultViewData solarSpeedResultViewData = new SolarSpeedResultViewData();
			solarSpeedResultViewData.RoleDataList = list;
			solarSpeedResultViewData.PanelType = (() => new SolarSpeedRolePanel());
			solarSpeedResultViewData.ConfirmClick = delegate()
			{
				ActivitySolarSpeedController.Instance.HandleClickNextInResultView();
			};
			return solarSpeedResultViewData;
		}

		// Token: 0x060335D7 RID: 210391 RVA: 0x00E66604 File Offset: 0x00E64804
		private List<ISolarSpeedTabCellPanelData> BuildTabCellPanelDataListInRewardView(int chosenLevelId)
		{
			List<ISolarSpeedTabCellPanelData> list = new List<ISolarSpeedTabCellPanelData>();
			SolarSpeedConfigContext configContext = this.ConfigContext;
			foreach (KeyValuePair<int, TeamParKOurCfg> keyValuePair in this.ConfigContext.CurrentCfgCache)
			{
				int num;
				TeamParKOurCfg teamParKOurCfg;
				keyValuePair.Deconstruct(out num, out teamParKOurCfg);
				int num2 = num;
				SolarSpeedTabCellPanelData item = new SolarSpeedTabCellPanelData
				{
					LevelId = num2,
					RomeNumberPath = (configContext.GetRomePathById(num2) ?? ""),
					TitleTextId = configContext.GetTitleTextIdById(num2),
					IsChosen = (num2 == chosenLevelId),
					IsRedDot = this.GetRedDotStateInRewardViewById(num2)
				};
				list.Add(item);
			}
			SolarSpeedTabCellPanelData item2 = new SolarSpeedTabCellPanelData
			{
				LevelId = 99,
				RomeNumberPath = "/Game/Aki/UI/UIResources/Common/Image/ComImg/T_ComRomeText_07.T_ComRomeText_07",
				TitleTextId = "LianjiPaoku_Bonus_Level_Title",
				IsChosen = (99 == chosenLevelId),
				IsRedDot = this.GetRedDotStateInRewardViewBonus()
			};
			list.Add(item2);
			return list;
		}

		// Token: 0x060335D8 RID: 210392 RVA: 0x00E6670C File Offset: 0x00E6490C
		private List<ISolarSpeedRewardCellPanelData> BuildRewardCellPanelDataListInRewardViewById(int id)
		{
			List<ISolarSpeedRewardCellPanelData> list = new List<ISolarSpeedRewardCellPanelData>();
			SolarSpeedConfigContext configContext = this.ConfigContext;
			foreach (int num in configContext.GetTaskListById(id))
			{
				SolarSpeedRewardCellPanelData solarSpeedRewardCellPanelData = new SolarSpeedRewardCellPanelData();
				solarSpeedRewardCellPanelData.RewardId = num;
				solarSpeedRewardCellPanelData.TitleTextId = (configContext.GetRewardTitleTextId(num) ?? "");
				solarSpeedRewardCellPanelData.ProgressTextId = "LianjiPaoku_Reward_Desc";
				solarSpeedRewardCellPanelData.ProgressTextArgs = new string[]
				{
					this.ProtocolContext.GetCurrentProgressById(num).ToString(),
					this.ProtocolContext.GetCurrentProgressTargetById(num).ToString()
				};
				solarSpeedRewardCellPanelData.ItemsData = configContext.GetRewardItemDataListById(num).ToArray();
				solarSpeedRewardCellPanelData.ButtonTextId = "LianjiPaoku_Button_Receive";
				solarSpeedRewardCellPanelData.ButtonActive = (this.ProtocolContext.GetTaskStateById(num).GetValueOrDefault() == ActivityTaskState.ActivityTaskFinish);
				SolarSpeedRewardCellPanelData solarSpeedRewardCellPanelData2 = solarSpeedRewardCellPanelData;
				ActivityTaskState? taskStateById = this.ProtocolContext.GetTaskStateById(num);
				ActivityTaskState activityTaskState = ActivityTaskState.ActivityTaskRunning;
				solarSpeedRewardCellPanelData2.RightActive = (taskStateById.GetValueOrDefault() == activityTaskState & taskStateById != null);
				solarSpeedRewardCellPanelData.DoneSpriteActive = (this.ProtocolContext.GetTaskStateById(num).GetValueOrDefault() == ActivityTaskState.ActivityTaskTaken);
				SolarSpeedRewardCellPanelData item = solarSpeedRewardCellPanelData;
				list.Add(item);
			}
			list.Sort((ISolarSpeedRewardCellPanelData a, ISolarSpeedRewardCellPanelData b) => a.RewardId - b.RewardId);
			return list;
		}

		// Token: 0x060335D9 RID: 210393 RVA: 0x00E6689C File Offset: 0x00E64A9C
		public ISolarSpeedActivitySubViewData BuildActivitySubViewData()
		{
			return new SolarSpeedActivitySubViewData
			{
				RewardTextId = "LianjiPaokuReward_9000_Preview",
				ButtonTextId = "PrefabTextItem_3950726357_Text",
				RewardRedDotStateGetter = (() => this.HasRewardRedDot),
				ConfirmRedDotStateGetter = (() => this.HasLevelRedDot),
				RewardProgressCurrentGetter = (() => this.CurrentCompletedCount.ToString()),
				RewardProgressTextId = "parkour_award_2_1",
				RewardProgressTotal = this.TotalRewardCount.ToString()
			};
		}

		// Token: 0x060335DA RID: 210394 RVA: 0x00E6691C File Offset: 0x00E64B1C
		public unsafe ReachTargetData BuildSettleReachTargetData()
		{
			int currentRankPointsCache = this.ProtocolContext.CurrentRankPointsCache;
			int currentDistancePointsCache = this.ProtocolContext.CurrentDistancePointsCache;
			int num = currentRankPointsCache + currentDistancePointsCache;
			ReachTargetData reachTargetData = new ReachTargetData();
			int num2 = 2;
			List<IRewardExploreTargetReached> list = new List<IRewardExploreTargetReached>(num2);
			CollectionsMarshal.SetCount<IRewardExploreTargetReached>(list, num2);
			Span<IRewardExploreTargetReached> span = CollectionsMarshal.AsSpan<IRewardExploreTargetReached>(list);
			int num3 = 0;
			ref IRewardExploreTargetReached ptr = ref span[num3];
			RewardExploreTargetReachedData rewardExploreTargetReachedData = new RewardExploreTargetReachedData();
			int num4 = 1;
			List<string> list2 = new List<string>(num4);
			CollectionsMarshal.SetCount<string>(list2, num4);
			Span<string> span2 = CollectionsMarshal.AsSpan<string>(list2);
			int num5 = 0;
			*span2[num5] = currentRankPointsCache.ToString();
			rewardExploreTargetReachedData.Target = list2;
			rewardExploreTargetReachedData.DescriptionTextId = "LianjiPaoku_End_RankScore";
			rewardExploreTargetReachedData.IsReached = true;
			ptr = rewardExploreTargetReachedData;
			num3++;
			ref IRewardExploreTargetReached ptr2 = ref span[num3];
			RewardExploreTargetReachedData rewardExploreTargetReachedData2 = new RewardExploreTargetReachedData();
			num5 = 1;
			List<string> list3 = new List<string>(num5);
			CollectionsMarshal.SetCount<string>(list3, num5);
			span2 = CollectionsMarshal.AsSpan<string>(list3);
			num4 = 0;
			*span2[num4] = currentDistancePointsCache.ToString();
			rewardExploreTargetReachedData2.Target = list3;
			rewardExploreTargetReachedData2.DescriptionTextId = "LianjiPaoku_End_CompleteRank";
			rewardExploreTargetReachedData2.IsReached = true;
			ptr2 = rewardExploreTargetReachedData2;
			reachTargetData.TargetReached = list;
			reachTargetData.IfNewRecord = (num > this.GetHistoryHighScoreInSettleView());
			reachTargetData.FullScore = num;
			reachTargetData.RecordTextId = "LianjiPaoku_End_HistoryRank";
			return reachTargetData;
		}

		// Token: 0x1700640E RID: 25614
		// (get) Token: 0x060335DB RID: 210395 RVA: 0x00E66A3B File Offset: 0x00E64C3B
		public static SolarSpeedModel Instance
		{
			get
			{
				return SolarSpeedModel._Instance;
			}
		}

		// Token: 0x060335DC RID: 210396 RVA: 0x00E66A42 File Offset: 0x00E64C42
		public static SolarSpeedModel GetOrCreateInstance()
		{
			if (SolarSpeedModel._Instance == null)
			{
				SolarSpeedModel.CreateInstance();
			}
			return SolarSpeedModel._Instance;
		}

		// Token: 0x060335DD RID: 210397 RVA: 0x00E66A56 File Offset: 0x00E64C56
		public static bool CreateInstance()
		{
			if (SolarSpeedModel._Instance != null)
			{
				return true;
			}
			SolarSpeedModel._Instance = new SolarSpeedModel();
			return true;
		}

		// Token: 0x060335DE RID: 210398 RVA: 0x00E66A6C File Offset: 0x00E64C6C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060335DF RID: 210399 RVA: 0x00E66A6E File Offset: 0x00E64C6E
		public static void ResetStaticDefaultValue()
		{
			SolarSpeedModel._Instance = null;
		}

		// Token: 0x060335E0 RID: 210400 RVA: 0x00E66A76 File Offset: 0x00E64C76
		static SolarSpeedModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SolarSpeedModel.CreateStaticDefaultValue), new Action(SolarSpeedModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401B4B9 RID: 111801
		private SolarSpeedConfigContext ConfigContext;

		// Token: 0x0401B4BA RID: 111802
		private SolarSpeedProtocolContext ProtocolContext;

		// Token: 0x0401B4BB RID: 111803
		private SolarSpeedUiContext UiContext;

		// Token: 0x0401B4BC RID: 111804
		[Nullable(2)]
		private static SolarSpeedModel _Instance;
	}
}
