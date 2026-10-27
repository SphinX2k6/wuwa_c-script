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
	// Token: 0x020060A9 RID: 24745
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SolarSpeedModel : ModelBase
	{
		// Token: 0x0603E8EC RID: 256236 RVA: 0x00F1EAEF File Offset: 0x00F1CCEF
		protected override bool OnInit()
		{
			this.ConfigContext = new SolarSpeedConfigContext(this);
			this.ProtocolContext = new SolarSpeedProtocolContext(this);
			this.UiContext = new SolarSpeedUiContext();
			return true;
		}

		// Token: 0x0603E8ED RID: 256237 RVA: 0x00F1EB15 File Offset: 0x00F1CD15
		protected override bool OnClear()
		{
			this.ConfigContext.Dispose();
			this.ProtocolContext.Dispose();
			this.UiContext.Dispose();
			return true;
		}

		// Token: 0x170090A1 RID: 37025
		// (get) Token: 0x0603E8EE RID: 256238 RVA: 0x00F1EB39 File Offset: 0x00F1CD39
		public int CurrentActivityId
		{
			get
			{
				return this.ProtocolContext.Id;
			}
		}

		// Token: 0x170090A2 RID: 37026
		// (get) Token: 0x0603E8EF RID: 256239 RVA: 0x00F1EB46 File Offset: 0x00F1CD46
		public ActivityBaseData ActivityData
		{
			get
			{
				return this.ProtocolContext;
			}
		}

		// Token: 0x170090A3 RID: 37027
		// (get) Token: 0x0603E8F0 RID: 256240 RVA: 0x00F1EB50 File Offset: 0x00F1CD50
		public string ActivityTitleTextId
		{
			get
			{
				SolarSpeedProtocolContext protocolContext = this.ProtocolContext;
				return ((protocolContext.LocalConfig != null) ? protocolContext.LocalConfig.GetValueOrDefault().Title : null) ?? "";
			}
		}

		// Token: 0x170090A4 RID: 37028
		// (get) Token: 0x0603E8F1 RID: 256241 RVA: 0x00F1EB8C File Offset: 0x00F1CD8C
		public string ActivityIconPath
		{
			get
			{
				SolarSpeedProtocolContext protocolContext = this.ProtocolContext;
				return ((protocolContext.LocalConfig != null) ? protocolContext.LocalConfig.GetValueOrDefault().TabResource : null) ?? "";
			}
		}

		// Token: 0x170090A5 RID: 37029
		// (get) Token: 0x0603E8F2 RID: 256242 RVA: 0x00F1EBC8 File Offset: 0x00F1CDC8
		public string InstanceEntranceIconPath
		{
			get
			{
				InstanceDungeonEntrance? config = InstanceDungeonEntranceConfig.Instance.GetConfig(9000);
				return ((config != null) ? config.GetValueOrDefault().TitleSprite : null) ?? "";
			}
		}

		// Token: 0x170090A6 RID: 37030
		// (get) Token: 0x0603E8F3 RID: 256243 RVA: 0x00F1EC09 File Offset: 0x00F1CE09
		public int? CurrentChosenTabInRewardView
		{
			get
			{
				return this.UiContext.CurrentChosenTabInRewardView;
			}
		}

		// Token: 0x170090A7 RID: 37031
		// (get) Token: 0x0603E8F4 RID: 256244 RVA: 0x00F1EC18 File Offset: 0x00F1CE18
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

		// Token: 0x170090A8 RID: 37032
		// (get) Token: 0x0603E8F5 RID: 256245 RVA: 0x00F1EC88 File Offset: 0x00F1CE88
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

		// Token: 0x170090A9 RID: 37033
		// (get) Token: 0x0603E8F6 RID: 256246 RVA: 0x00F1ED08 File Offset: 0x00F1CF08
		public int TotalRewardCount
		{
			get
			{
				return this.ConfigContext.CurrentRewardCache.Count;
			}
		}

		// Token: 0x170090AA RID: 37034
		// (get) Token: 0x0603E8F7 RID: 256247 RVA: 0x00F1ED1C File Offset: 0x00F1CF1C
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

		// Token: 0x170090AB RID: 37035
		// (get) Token: 0x0603E8F8 RID: 256248 RVA: 0x00F1EDB8 File Offset: 0x00F1CFB8
		public int DefaultLevelIdInRewardView
		{
			get
			{
				this.UiContext.CurrentChosenTabInRewardView = new int?(1);
				return this.UiContext.CurrentChosenTabInRewardView.Value;
			}
		}

		// Token: 0x0603E8F9 RID: 256249 RVA: 0x00F1EDDB File Offset: 0x00F1CFDB
		[NullableContext(2)]
		public string GetInfoPicturePathByInstanceId(int instanceId)
		{
			return this.ConfigContext.GetInfoPicturePathByInstanceId(instanceId);
		}

		// Token: 0x0603E8FA RID: 256250 RVA: 0x00F1EDEC File Offset: 0x00F1CFEC
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

		// Token: 0x0603E8FB RID: 256251 RVA: 0x00F1EE2C File Offset: 0x00F1D02C
		public int GetHistoryHighScoreInSettleView()
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			return this.GetHistoryHighScoreByInstanceId(instanceId).GetValueOrDefault();
		}

		// Token: 0x0603E8FC RID: 256252 RVA: 0x00F1EE54 File Offset: 0x00F1D054
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

		// Token: 0x0603E8FD RID: 256253 RVA: 0x00F1EEC8 File Offset: 0x00F1D0C8
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

		// Token: 0x0603E8FE RID: 256254 RVA: 0x00F1EF3C File Offset: 0x00F1D13C
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

		// Token: 0x0603E8FF RID: 256255 RVA: 0x00F1EFB0 File Offset: 0x00F1D1B0
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

		// Token: 0x0603E900 RID: 256256 RVA: 0x00F1F00C File Offset: 0x00F1D20C
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

		// Token: 0x0603E901 RID: 256257 RVA: 0x00F1F068 File Offset: 0x00F1D268
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

		// Token: 0x0603E902 RID: 256258 RVA: 0x00F1F114 File Offset: 0x00F1D314
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

		// Token: 0x0603E903 RID: 256259 RVA: 0x00F1F15C File Offset: 0x00F1D35C
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

		// Token: 0x0603E904 RID: 256260 RVA: 0x00F1F1D0 File Offset: 0x00F1D3D0
		public bool IsUnlockByInstanceId(int instanceId)
		{
			int? levelIdByInstanceId = this.ConfigContext.GetLevelIdByInstanceId(instanceId);
			return levelIdByInstanceId != null && this.IsUnlockById(levelIdByInstanceId.Value);
		}

		// Token: 0x0603E905 RID: 256261 RVA: 0x00F1F204 File Offset: 0x00F1D404
		public bool IsClickedById(int instanceId)
		{
			Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.SolarSpeedInstanceClicked, null);
			bool flag;
			return player != null && (player.TryGetValue(instanceId, out flag) && flag);
		}

		// Token: 0x0603E906 RID: 256262 RVA: 0x00F1F22A File Offset: 0x00F1D42A
		public bool IsUnlockById(int id)
		{
			return (double)this.ProtocolContext.GetStartTime(id) < TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x0603E907 RID: 256263 RVA: 0x00F1F245 File Offset: 0x00F1D445
		public bool HasRedDotById(int id)
		{
			return !this.IsClickedById(id) && this.IsUnlockById(id);
		}

		// Token: 0x0603E908 RID: 256264 RVA: 0x00F1F25C File Offset: 0x00F1D45C
		public bool HasRedDotByInstanceId(int instanceId)
		{
			int? levelIdByInstanceId = this.ConfigContext.GetLevelIdByInstanceId(instanceId);
			return levelIdByInstanceId != null && this.HasRedDotById(levelIdByInstanceId.Value);
		}

		// Token: 0x0603E909 RID: 256265 RVA: 0x00F1F28E File Offset: 0x00F1D48E
		public void SetCurrentChosenTabInRewardView(int id)
		{
			this.UiContext.CurrentChosenTabInRewardView = new int?(id);
		}

		// Token: 0x0603E90A RID: 256266 RVA: 0x00F1F2A1 File Offset: 0x00F1D4A1
		public void SyncTeamParkourTaskNotify(TeamParkourTaskNotify msg)
		{
			this.ProtocolContext.ParseTeamParkourTaskNotify(msg);
		}

		// Token: 0x0603E90B RID: 256267 RVA: 0x00F1F2AF File Offset: 0x00F1D4AF
		public void SyncTeamParkourSettleNotify(TeamParkourSettleNotify msg)
		{
			this.ProtocolContext.ParseTeamParkourSettleNotify(msg);
		}

		// Token: 0x0603E90C RID: 256268 RVA: 0x00F1F2C0 File Offset: 0x00F1D4C0
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

		// Token: 0x0603E90D RID: 256269 RVA: 0x00F1F32C File Offset: 0x00F1D52C
		public void SyncAfterRewardedById(int id)
		{
			this.ProtocolContext.SetTaskStateRewardedById(id);
		}

		// Token: 0x0603E90E RID: 256270 RVA: 0x00F1F33C File Offset: 0x00F1D53C
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

		// Token: 0x0603E90F RID: 256271 RVA: 0x00F1F3A8 File Offset: 0x00F1D5A8
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

		// Token: 0x0603E910 RID: 256272 RVA: 0x00F1F4B8 File Offset: 0x00F1D6B8
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

		// Token: 0x0603E911 RID: 256273 RVA: 0x00F1F51C File Offset: 0x00F1D71C
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

		// Token: 0x0603E912 RID: 256274 RVA: 0x00F1F580 File Offset: 0x00F1D780
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

		// Token: 0x0603E913 RID: 256275 RVA: 0x00F1F840 File Offset: 0x00F1DA40
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

		// Token: 0x0603E914 RID: 256276 RVA: 0x00F1F948 File Offset: 0x00F1DB48
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

		// Token: 0x0603E915 RID: 256277 RVA: 0x00F1FAD8 File Offset: 0x00F1DCD8
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

		// Token: 0x0603E916 RID: 256278 RVA: 0x00F1FB58 File Offset: 0x00F1DD58
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

		// Token: 0x170090AC RID: 37036
		// (get) Token: 0x0603E917 RID: 256279 RVA: 0x00F1FC77 File Offset: 0x00F1DE77
		public static SolarSpeedModel Instance
		{
			get
			{
				return SolarSpeedModel._Instance;
			}
		}

		// Token: 0x0603E918 RID: 256280 RVA: 0x00F1FC7E File Offset: 0x00F1DE7E
		public static SolarSpeedModel GetOrCreateInstance()
		{
			if (SolarSpeedModel._Instance == null)
			{
				SolarSpeedModel.CreateInstance();
			}
			return SolarSpeedModel._Instance;
		}

		// Token: 0x0603E919 RID: 256281 RVA: 0x00F1FC92 File Offset: 0x00F1DE92
		public static bool CreateInstance()
		{
			if (SolarSpeedModel._Instance != null)
			{
				return true;
			}
			SolarSpeedModel._Instance = new SolarSpeedModel();
			return true;
		}

		// Token: 0x0603E91A RID: 256282 RVA: 0x00F1FCA8 File Offset: 0x00F1DEA8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E91B RID: 256283 RVA: 0x00F1FCAA File Offset: 0x00F1DEAA
		public static void ResetStaticDefaultValue()
		{
			SolarSpeedModel._Instance = null;
		}

		// Token: 0x0603E91C RID: 256284 RVA: 0x00F1FCB2 File Offset: 0x00F1DEB2
		static SolarSpeedModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SolarSpeedModel.CreateStaticDefaultValue), new Action(SolarSpeedModel.ResetStaticDefaultValue));
		}

		// Token: 0x04020B8C RID: 134028
		private SolarSpeedConfigContext ConfigContext;

		// Token: 0x04020B8D RID: 134029
		private SolarSpeedProtocolContext ProtocolContext;

		// Token: 0x04020B8E RID: 134030
		private SolarSpeedUiContext UiContext;

		// Token: 0x04020B8F RID: 134031
		[Nullable(2)]
		private static SolarSpeedModel _Instance;
	}
}
