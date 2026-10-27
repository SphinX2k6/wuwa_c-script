using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Module.InstanceDungeon;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200587B RID: 22651
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonModel : ModelBase
	{
		// Token: 0x06039A2C RID: 236076 RVA: 0x00DB252F File Offset: 0x00DB072F
		protected override bool OnLeaveLevel()
		{
			InstanceDungeonInfo instanceDungeonInfo = this.InstanceDungeonInfo;
			if (instanceDungeonInfo != null)
			{
				instanceDungeonInfo.SetTrack(false, ESetTrackReason.None);
			}
			this.InstanceFinishSuccess = EInstanceFinishState.UnFinish;
			this.InstanceRewardHaveTake = false;
			this.ClearInstanceDungeonInfo();
			return true;
		}

		// Token: 0x06039A2D RID: 236077 RVA: 0x00DB2559 File Offset: 0x00DB0759
		public int GetInstanceId()
		{
			return this.InstanceId;
		}

		// Token: 0x06039A2E RID: 236078 RVA: 0x00DB2561 File Offset: 0x00DB0761
		public void SetInstanceId(int instanceId)
		{
			this.InstanceId = instanceId;
		}

		// Token: 0x17008A79 RID: 35449
		// (get) Token: 0x06039A2F RID: 236079 RVA: 0x00DB256A File Offset: 0x00DB076A
		// (set) Token: 0x06039A30 RID: 236080 RVA: 0x00DB2572 File Offset: 0x00DB0772
		public bool InstanceContinue { get; set; }

		// Token: 0x06039A31 RID: 236081 RVA: 0x00DB257B File Offset: 0x00DB077B
		public void SetMatchTeamInfo(MatchTeamInfo matchTeamInfo)
		{
			this.MatchTeamInfo = matchTeamInfo;
		}

		// Token: 0x06039A32 RID: 236082 RVA: 0x00DB2584 File Offset: 0x00DB0784
		[NullableContext(2)]
		public MatchTeamInfo GetMatchTeamInfo()
		{
			return this.MatchTeamInfo;
		}

		// Token: 0x06039A33 RID: 236083 RVA: 0x00DB258C File Offset: 0x00DB078C
		public void SetMatchTeamHost(int id)
		{
			this.MatchTeamInfo.HostId = id;
		}

		// Token: 0x06039A34 RID: 236084 RVA: 0x00DB259A File Offset: 0x00DB079A
		public void SetMatchTeamState(MatchTeamState state)
		{
			this.MatchTeamInfo.TeamState = state;
		}

		// Token: 0x06039A35 RID: 236085 RVA: 0x00DB25A8 File Offset: 0x00DB07A8
		[NullableContext(2)]
		public string GetMatchTeamName(int playerId)
		{
			foreach (MatchPlayerInfo matchPlayerInfo in this.MatchTeamInfo.PlayerInfos)
			{
				if (matchPlayerInfo.PlayerId == playerId)
				{
					return matchPlayerInfo.PlayerName;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InstanceDungeon;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "获取匹配副本队伍队员信息失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("队员Id", playerId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x06039A36 RID: 236086 RVA: 0x00DB2634 File Offset: 0x00DB0834
		[NullableContext(2)]
		public string GetMatchTeamOnlineId(int playerId)
		{
			foreach (MatchPlayerInfo matchPlayerInfo in this.MatchTeamInfo.PlayerInfos)
			{
				if (matchPlayerInfo.PlayerId == playerId)
				{
					if (Info.Instance.IsPs5Platform())
					{
						return matchPlayerInfo.PsnOnlineId;
					}
					return matchPlayerInfo.XboxOnlineId;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InstanceDungeon;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "获取匹配副本队伍队员信息失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("队员Id", playerId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x06039A37 RID: 236087 RVA: 0x00DB26D4 File Offset: 0x00DB08D4
		public List<int> GetMatchTeamRoleCfgId(int playerId)
		{
			List<int> list = new List<int>();
			foreach (MatchPlayerInfo matchPlayerInfo in this.MatchTeamInfo.PlayerInfos)
			{
				if (matchPlayerInfo.PlayerId == playerId)
				{
					foreach (MatchRoleInfo matchRoleInfo in matchPlayerInfo.RoleInfo)
					{
						list.Add(matchRoleInfo.RoleId);
					}
				}
			}
			return list;
		}

		// Token: 0x06039A38 RID: 236088 RVA: 0x00DB2774 File Offset: 0x00DB0974
		public bool IsMatchTeamHost()
		{
			int playerId = CreatureModel.Instance.GetPlayerId();
			MatchTeamInfo matchTeamInfo = this.MatchTeamInfo;
			int? num = (matchTeamInfo != null) ? new int?(matchTeamInfo.HostId) : null;
			return playerId == num.GetValueOrDefault() & num != null;
		}

		// Token: 0x06039A39 RID: 236089 RVA: 0x00DB27BC File Offset: 0x00DB09BC
		public bool IsTeamNotFull()
		{
			return this.GetTeamSize() < 3;
		}

		// Token: 0x06039A3A RID: 236090 RVA: 0x00DB27C7 File Offset: 0x00DB09C7
		public int GetNeedMatchSize()
		{
			return 3 - this.GetTeamSize();
		}

		// Token: 0x06039A3B RID: 236091 RVA: 0x00DB27D4 File Offset: 0x00DB09D4
		private int GetTeamSize()
		{
			RepeatedField<MatchPlayerInfo> playerInfos = this.MatchTeamInfo.PlayerInfos;
			if (!GameModeModel.Instance.IsMulti)
			{
				return playerInfos.Count;
			}
			int[] allWorldTeamPlayer = OnlineModel.Instance.GetAllWorldTeamPlayer();
			int num = playerInfos.Count + allWorldTeamPlayer.Length;
			foreach (int num2 in allWorldTeamPlayer)
			{
				foreach (MatchPlayerInfo matchPlayerInfo in playerInfos)
				{
					if (num2 == matchPlayerInfo.PlayerId)
					{
						num--;
					}
				}
			}
			return num;
		}

		// Token: 0x06039A3C RID: 236092 RVA: 0x00DB287C File Offset: 0x00DB0A7C
		public bool IsAllPlayerInMatchTeam()
		{
			if (!GameModeModel.Instance.IsMulti)
			{
				return true;
			}
			List<int> list = new List<int>();
			foreach (MatchPlayerInfo matchPlayerInfo in this.MatchTeamInfo.PlayerInfos)
			{
				list.Add(matchPlayerInfo.PlayerId);
			}
			int[] allWorldTeamPlayer = OnlineModel.Instance.GetAllWorldTeamPlayer();
			bool result = true;
			foreach (int item in allWorldTeamPlayer)
			{
				if (!list.Contains(item))
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06039A3D RID: 236093 RVA: 0x00DB291C File Offset: 0x00DB0B1C
		public void InitMatchingTeamConfirmReadyState(RepeatedField<MatchPlayerInfo> players)
		{
			foreach (MatchPlayerInfo matchPlayerInfo in players)
			{
				this.MatchingTeamConfirmState[matchPlayerInfo.PlayerId] = matchPlayerInfo.IsConfirm;
				this.PrewarPlayerReadyState[matchPlayerInfo.PlayerId] = matchPlayerInfo.IsReady;
				foreach (PrewarFormationData prewarFormationData in this.PrewarFormationDataList)
				{
					if (prewarFormationData.GetPlayerId() == matchPlayerInfo.PlayerId)
					{
						prewarFormationData.SetIsReady(matchPlayerInfo.IsReady);
					}
				}
			}
		}

		// Token: 0x06039A3E RID: 236094 RVA: 0x00DB29E4 File Offset: 0x00DB0BE4
		public void SetMatchingPlayerConfirmState(int playerId, bool confirm)
		{
			this.MatchingTeamConfirmState[playerId] = confirm;
		}

		// Token: 0x06039A3F RID: 236095 RVA: 0x00DB29F4 File Offset: 0x00DB0BF4
		public bool? GetMatchingPlayerConfirmStateByPlayerId(int playerId)
		{
			bool value;
			if (this.MatchingTeamConfirmState.TryGetValue(playerId, out value))
			{
				return new bool?(value);
			}
			return null;
		}

		// Token: 0x06039A40 RID: 236096 RVA: 0x00DB2A21 File Offset: 0x00DB0C21
		public bool GetMatchingTeamReady()
		{
			return this.MatchTeamInfo.TeamState == MatchTeamState.ReadyConfirm;
		}

		// Token: 0x06039A41 RID: 236097 RVA: 0x00DB2A34 File Offset: 0x00DB0C34
		public EMatchPlayerUiState GetPlayerUiState(int playerId)
		{
			foreach (MatchPlayerInfo matchPlayerInfo in this.MatchTeamInfo.PlayerInfos)
			{
				if (matchPlayerInfo.PlayerId == playerId)
				{
					return matchPlayerInfo.MatchUiState;
				}
			}
			return EMatchPlayerUiState.Wait;
		}

		// Token: 0x06039A42 RID: 236098 RVA: 0x00DB2A94 File Offset: 0x00DB0C94
		public void SetPlayerUiState(int playerId, EMatchPlayerUiState uiState)
		{
			foreach (MatchPlayerInfo matchPlayerInfo in this.MatchTeamInfo.PlayerInfos)
			{
				if (matchPlayerInfo.PlayerId == playerId)
				{
					matchPlayerInfo.MatchUiState = uiState;
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.OnRefreshPlayerUiState, playerId);
		}

		// Token: 0x06039A43 RID: 236099 RVA: 0x00DB2B00 File Offset: 0x00DB0D00
		public void SetPrewarPlayerReadyState(int playerId, bool ready)
		{
			this.PrewarPlayerReadyState[playerId] = ready;
			foreach (PrewarFormationData prewarFormationData in this.PrewarFormationDataList)
			{
				if (prewarFormationData.GetPlayerId() == playerId)
				{
					prewarFormationData.SetIsReady(ready);
				}
			}
		}

		// Token: 0x06039A44 RID: 236100 RVA: 0x00DB2B6C File Offset: 0x00DB0D6C
		public void RemovePrewarPlayerReadyState(int playerId)
		{
			this.PrewarPlayerReadyState.Remove(playerId);
		}

		// Token: 0x06039A45 RID: 236101 RVA: 0x00DB2B7B File Offset: 0x00DB0D7B
		public void ClearPrewarPlayerReadyState()
		{
			this.PrewarPlayerReadyState.Clear();
		}

		// Token: 0x06039A46 RID: 236102 RVA: 0x00DB2B88 File Offset: 0x00DB0D88
		public void RemoveMatchingTeamConfirmState(int playerId)
		{
			this.MatchingTeamConfirmState.Remove(playerId);
		}

		// Token: 0x06039A47 RID: 236103 RVA: 0x00DB2B97 File Offset: 0x00DB0D97
		public void ClearMatchingTeamConfirmState()
		{
			this.MatchingTeamConfirmState.Clear();
		}

		// Token: 0x06039A48 RID: 236104 RVA: 0x00DB2BA4 File Offset: 0x00DB0DA4
		public bool GetPrewarPlayerReadyState(int playerId)
		{
			bool flag;
			return this.PrewarPlayerReadyState.TryGetValue(playerId, out flag) && flag && flag;
		}

		// Token: 0x06039A49 RID: 236105 RVA: 0x00DB2BC7 File Offset: 0x00DB0DC7
		private void ParseMatchRoleInfo(PrewarFormationData data, MatchRoleInfo info)
		{
			data.SetLevel(info.RoleLevel);
			data.SetConfigId(info.RoleId);
			data.SetSkinId(info.RoleSkinId);
			data.SetMultiSkillBranchId(info.SkillBranchId);
		}

		// Token: 0x06039A4A RID: 236106 RVA: 0x00DB2BFC File Offset: 0x00DB0DFC
		public void SetPrewarFormationDataList()
		{
			this.ClearPrewarData();
			MatchTeamInfo matchTeamInfo = this.GetMatchTeamInfo();
			if (matchTeamInfo == null)
			{
				return;
			}
			foreach (MatchPlayerInfo matchPlayerInfo in matchTeamInfo.PlayerInfos)
			{
				foreach (MatchRoleInfo info in matchPlayerInfo.RoleInfo)
				{
					PrewarFormationData prewarFormationData = new PrewarFormationData();
					prewarFormationData.SetPlayerId(matchPlayerInfo.PlayerId);
					prewarFormationData.SetIsReady(this.GetPrewarPlayerReadyState(matchPlayerInfo.PlayerId));
					prewarFormationData.SetLife(1);
					prewarFormationData.SetMaxLife(1);
					this.ParseMatchRoleInfo(prewarFormationData, info);
					this.PrewarFormationDataList.Add(prewarFormationData);
				}
			}
			this.SortPrewarFormationData();
		}

		// Token: 0x06039A4B RID: 236107 RVA: 0x00DB2CE0 File Offset: 0x00DB0EE0
		public void AddPrewarFormationDataByPlayerInfo(MatchPlayerInfo playerInfo, bool bChangeTeamInfo = true)
		{
			if (bChangeTeamInfo)
			{
				this.MatchTeamInfo.PlayerInfos.Add(playerInfo);
			}
			foreach (MatchRoleInfo info in playerInfo.RoleInfo)
			{
				PrewarFormationData prewarFormationData = new PrewarFormationData();
				prewarFormationData.SetPlayerId(playerInfo.PlayerId);
				prewarFormationData.SetIsReady(this.GetPrewarPlayerReadyState(playerInfo.PlayerId));
				prewarFormationData.SetLife(1);
				prewarFormationData.SetMaxLife(1);
				this.ParseMatchRoleInfo(prewarFormationData, info);
				this.PrewarFormationDataList.Add(prewarFormationData);
			}
			this.SortPrewarFormationData();
		}

		// Token: 0x06039A4C RID: 236108 RVA: 0x00DB2D88 File Offset: 0x00DB0F88
		private void SortPrewarFormationData()
		{
			int hostId = this.GetMatchTeamInfo().HostId;
			int num = 1;
			int num2 = 1;
			foreach (PrewarFormationData prewarFormationData in this.PrewarFormationDataList)
			{
				if (prewarFormationData.GetPlayerId() == hostId)
				{
					prewarFormationData.SetIndex(num++);
					prewarFormationData.SetOnlineNumber(num2);
				}
			}
			num2++;
			foreach (PrewarFormationData prewarFormationData2 in this.PrewarFormationDataList)
			{
				if (prewarFormationData2.GetPlayerId() != hostId)
				{
					prewarFormationData2.SetIndex(num++);
					prewarFormationData2.SetOnlineNumber(num2++);
				}
			}
			this.PrewarFormationDataList.Sort((PrewarFormationData a, PrewarFormationData b) => a.GetIndex() - b.GetIndex());
		}

		// Token: 0x06039A4D RID: 236109 RVA: 0x00DB2E90 File Offset: 0x00DB1090
		public void SetMatchTeamInfoPlayerRole(int playerId, RepeatedField<MatchRoleInfo> roleInfos)
		{
			foreach (MatchPlayerInfo matchPlayerInfo in this.MatchTeamInfo.PlayerInfos)
			{
				if (matchPlayerInfo.PlayerId == playerId)
				{
					int count = matchPlayerInfo.RoleInfo.Count;
					int count2 = roleInfos.Count;
					matchPlayerInfo.RoleInfo.Clear();
					matchPlayerInfo.RoleInfo.AddRange(roleInfos);
					if (count == count2)
					{
						this.ChangePrewarFormationDataRole(matchPlayerInfo);
					}
					if (count < count2)
					{
						this.ResetPrewarFormationDataByPlayer(playerId);
						this.AddPrewarFormationDataByPlayerInfo(matchPlayerInfo, false);
					}
					if (count > count2)
					{
						this.RemovePrewarFormationDataByPlayerInfo(matchPlayerInfo);
					}
				}
			}
			EventSystem.Instance.Emit(EEventName.PrewarFormationChanged);
		}

		// Token: 0x06039A4E RID: 236110 RVA: 0x00DB2F48 File Offset: 0x00DB1148
		public IReadOnlyList<PrewarFormationData> GetPrewarFormationDataList()
		{
			return this.PrewarFormationDataList;
		}

		// Token: 0x06039A4F RID: 236111 RVA: 0x00DB2F50 File Offset: 0x00DB1150
		public bool RemovePrewarFormationDataByPlayer(int playerId)
		{
			bool result = false;
			for (int i = this.PrewarFormationDataList.Count - 1; i >= 0; i--)
			{
				if (this.PrewarFormationDataList[i].GetPlayerId() == playerId)
				{
					result = true;
					this.PrewarFormationDataList.RemoveAt(i);
					this.RemovePrewarPlayerReadyState(playerId);
					this.RemoveMatchingTeamConfirmState(playerId);
				}
			}
			for (int j = this.MatchTeamInfo.PlayerInfos.Count - 1; j >= 0; j--)
			{
				MatchPlayerInfo matchPlayerInfo = this.MatchTeamInfo.PlayerInfos[j];
				if (matchPlayerInfo != null && matchPlayerInfo.PlayerId == playerId)
				{
					result = true;
					this.MatchTeamInfo.PlayerInfos.RemoveAt(j);
				}
			}
			this.SortPrewarFormationData();
			return result;
		}

		// Token: 0x06039A50 RID: 236112 RVA: 0x00DB2FFC File Offset: 0x00DB11FC
		private void ChangePrewarFormationDataRole(MatchPlayerInfo playerInfo)
		{
			int count = this.PrewarFormationDataList.Count;
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				PrewarFormationData prewarFormationData = this.PrewarFormationDataList[i];
				if (playerInfo.PlayerId == prewarFormationData.GetPlayerId())
				{
					MatchRoleInfo info = playerInfo.RoleInfo[num++];
					this.ParseMatchRoleInfo(prewarFormationData, info);
				}
			}
		}

		// Token: 0x06039A51 RID: 236113 RVA: 0x00DB305C File Offset: 0x00DB125C
		private void RemovePrewarFormationDataByPlayerInfo(MatchPlayerInfo playerInfo)
		{
			int playerId = playerInfo.PlayerId;
			RepeatedField<MatchRoleInfo> roleInfo = playerInfo.RoleInfo;
			for (int i = this.PrewarFormationDataList.Count - 1; i >= 0; i--)
			{
				PrewarFormationData prewarFormationData = this.PrewarFormationDataList[i];
				if (prewarFormationData.GetPlayerId() == playerId)
				{
					bool flag = false;
					using (IEnumerator<MatchRoleInfo> enumerator = roleInfo.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.RoleId == prewarFormationData.GetConfigId())
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag)
					{
						this.PrewarFormationDataList.RemoveAt(i);
					}
				}
			}
			this.SortPrewarFormationData();
		}

		// Token: 0x06039A52 RID: 236114 RVA: 0x00DB3108 File Offset: 0x00DB1308
		private void ResetPrewarFormationDataByPlayer(int playerId)
		{
			for (int i = this.PrewarFormationDataList.Count - 1; i >= 0; i--)
			{
				if (this.PrewarFormationDataList[i].GetPlayerId() == playerId)
				{
					this.PrewarFormationDataList.RemoveAt(i);
				}
			}
		}

		// Token: 0x06039A53 RID: 236115 RVA: 0x00DB3150 File Offset: 0x00DB1350
		public bool IsInPrewarFormation(int playerId)
		{
			using (List<PrewarFormationData>.Enumerator enumerator = this.PrewarFormationDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetPlayerId() == playerId)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06039A54 RID: 236116 RVA: 0x00DB31AC File Offset: 0x00DB13AC
		public void ClearPrewarData()
		{
			this.PrewarFormationDataList.Clear();
		}

		// Token: 0x06039A55 RID: 236117 RVA: 0x00DB31B9 File Offset: 0x00DB13B9
		public int MatchingPlayerCount()
		{
			return this.MatchingTeamConfirmState.Count;
		}

		// Token: 0x17008A7A RID: 35450
		// (get) Token: 0x06039A56 RID: 236118 RVA: 0x00DB31C8 File Offset: 0x00DB13C8
		public int FormationAverageRoleLevel
		{
			get
			{
				int num = 0;
				List<BattleRoleSlotData> allSlots = BattleTeamModel.Instance.GetAllSlots();
				if (allSlots == null)
				{
					return 0;
				}
				int num2 = 0;
				foreach (BattleRoleSlotData battleRoleSlotData in allSlots)
				{
					if (battleRoleSlotData.RoleData != null)
					{
						int num3 = num;
						BattleRoleData roleData = battleRoleSlotData.RoleData;
						num = num3 + ((roleData != null) ? roleData.Level : 0);
						num2++;
					}
				}
				if (num2 == 0)
				{
					return 0;
				}
				num /= num2;
				return num;
			}
		}

		// Token: 0x06039A57 RID: 236119 RVA: 0x00DB3254 File Offset: 0x00DB1454
		public bool CheckPrewarFormationAverageLowLevel(int instanceId)
		{
			int fightFormationId = InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.FightFormationId;
			if (fightFormationId != 0)
			{
				Aki.Config.FightFormation value = FormationConfig.Instance.GetFightFormationConfig(fightFormationId).Value;
				if (value.AutoRoleLength > 0 && value.TrialRoleLength > 0)
				{
					return false;
				}
			}
			int formationAverageRoleLevel = this.FormationAverageRoleLevel;
			ValueTuple<bool, int> valueTuple = ActivityModel.Instance.CheckActivityLevelBelongToType(instanceId);
			bool item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			if (item)
			{
				return formationAverageRoleLevel < ActivityModel.Instance.GetActivityLevelRecommendLevel(instanceId, WorldLevelModel.Instance.CurWorldLevel, item2);
			}
			return formationAverageRoleLevel < InstanceDungeonConfig.Instance.GetRecommendLevel(instanceId, WorldLevelModel.Instance.CurWorldLevel);
		}

		// Token: 0x06039A58 RID: 236120 RVA: 0x00DB3302 File Offset: 0x00DB1502
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<InstanceBeInviteData> GetInstanceBeInviteDataList()
		{
			return this.InstanceBeInviteDataList;
		}

		// Token: 0x06039A59 RID: 236121 RVA: 0x00DB330A File Offset: 0x00DB150A
		[NullableContext(2)]
		public void AddInstanceBeInviteData(InstanceBeInviteData data)
		{
			if (data == null)
			{
				return;
			}
			if (this.InstanceBeInviteDataList == null)
			{
				this.InstanceBeInviteDataList = new List<InstanceBeInviteData>();
			}
			else
			{
				this.RemoveInstanceBeInviteData(data.GetPlayerId());
			}
			this.InstanceBeInviteDataList.Add(data);
		}

		// Token: 0x06039A5A RID: 236122 RVA: 0x00DB3340 File Offset: 0x00DB1540
		public bool RemoveInstanceBeInviteData(int playerId)
		{
			for (int i = 0; i < this.InstanceBeInviteDataList.Count; i++)
			{
				if (this.InstanceBeInviteDataList[i].GetPlayerId() == playerId)
				{
					this.InstanceBeInviteDataList.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06039A5B RID: 236123 RVA: 0x00DB3388 File Offset: 0x00DB1588
		public long GetInvitePlayerCd(int playerId)
		{
			long num;
			if (this.InviteCdMap.TryGetValue(playerId, out num) && num != 0L)
			{
				return num;
			}
			return 0L;
		}

		// Token: 0x06039A5C RID: 236124 RVA: 0x00DB33AC File Offset: 0x00DB15AC
		public void SetInvitePlayerCd(int playerId, long value)
		{
			this.InviteCdMap[playerId] = value;
		}

		// Token: 0x06039A5D RID: 236125 RVA: 0x00DB33BB File Offset: 0x00DB15BB
		public InstanceDungeonInfo CreateInstanceInfo(int id)
		{
			this.InstanceDungeonInfo = new InstanceDungeonInfo(id);
			this.InstanceDungeonInfo.InitConfig();
			return this.InstanceDungeonInfo;
		}

		// Token: 0x06039A5E RID: 236126 RVA: 0x00DB33DA File Offset: 0x00DB15DA
		public void ClearInstanceDungeonInfo()
		{
			if (this.InstanceDungeonInfo == null)
			{
				return;
			}
			LogicTreeContainer instanceDungeonInfo = this.InstanceDungeonInfo;
			this.InstanceDungeonInfo = null;
			instanceDungeonInfo.Destroy();
		}

		// Token: 0x06039A5F RID: 236127 RVA: 0x00DB33F7 File Offset: 0x00DB15F7
		[NullableContext(2)]
		public InstanceDungeonInfo GetInstanceDungeonInfo()
		{
			return this.InstanceDungeonInfo;
		}

		// Token: 0x06039A60 RID: 236128 RVA: 0x00DB33FF File Offset: 0x00DB15FF
		public void ResetData()
		{
			this.ClearPrewarData();
			this.ClearPrewarPlayerReadyState();
			this.ClearMatchingTeamConfirmState();
			this.MatchTeamInfo = null;
		}

		// Token: 0x17008A7B RID: 35451
		// (get) Token: 0x06039A61 RID: 236129 RVA: 0x00DB341A File Offset: 0x00DB161A
		// (set) Token: 0x06039A62 RID: 236130 RVA: 0x00DB3422 File Offset: 0x00DB1622
		[Nullable(2)]
		public List<int> LastEnterRoleList { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06039A63 RID: 236131 RVA: 0x00DB342B File Offset: 0x00DB162B
		public void SetInstanceDungeonName(string name)
		{
			this.InstanceDungeonName = name;
		}

		// Token: 0x06039A64 RID: 236132 RVA: 0x00DB3434 File Offset: 0x00DB1634
		[NullableContext(2)]
		public string GetInstanceDungeonName()
		{
			return this.InstanceDungeonName;
		}

		// Token: 0x06039A65 RID: 236133 RVA: 0x00DB343C File Offset: 0x00DB163C
		public void ConstructCurrentDungeonAreaName()
		{
			this.InstanceDungeonName = null;
			if (TowerModel.Instance.CheckInTower())
			{
				this.SetInstanceDungeonName(TowerModel.Instance.GetCurrentFloorName());
			}
		}

		// Token: 0x06039A66 RID: 236134 RVA: 0x00DB3461 File Offset: 0x00DB1661
		public void ClearInstanceEnterContentText()
		{
			this.InstanceEnterContentText = new EnterInstContext();
		}

		// Token: 0x06039A67 RID: 236135 RVA: 0x00DB3470 File Offset: 0x00DB1670
		public unsafe IInstanceDungeonExitConfirmBoxData ParseExitDungeonConfirmData(InstanceDungeon dungeonConfig)
		{
			Span<int> exitDungeonConfirmIdBytes = dungeonConfig.GetExitDungeonConfirmIdBytes();
			return new InstanceDungeonExitConfirmBoxData
			{
				ParseRuleType = (EInstanceDungeonExitConfirmBoxParseRule)((dungeonConfig.ExitDungeonConfirmIdLength > 0) ? (*exitDungeonConfirmIdBytes[0]) : 0),
				UnfinishedBoxId = ((dungeonConfig.ExitDungeonConfirmIdLength > 1) ? new int?(*exitDungeonConfirmIdBytes[1]) : null),
				FinishBoxId = ((dungeonConfig.ExitDungeonConfirmIdLength > 2) ? new int?(*exitDungeonConfirmIdBytes[2]) : null),
				UnfinishedTelBoxId = ((dungeonConfig.ExitDungeonConfirmIdLength > 3) ? new int?(*exitDungeonConfirmIdBytes[3]) : null),
				FinishTelBoxId = ((dungeonConfig.ExitDungeonConfirmIdLength > 4) ? new int?(*exitDungeonConfirmIdBytes[4]) : null)
			};
		}

		// Token: 0x06039A68 RID: 236136 RVA: 0x00DB354C File Offset: 0x00DB174C
		public IInstanceDungeonExitConfirmBoxData GetCurrentDungeonExitConfirmData()
		{
			IInstanceDungeonExitConfirmBoxData instanceDungeonExitConfirmBoxData = this.ParseExitDungeonConfirmData(GameModeModel.Instance.InstanceDungeon.Value);
			int id = GameModeModel.Instance.InstanceDungeon.Value.Id;
			EDungeonSubType instSubType = (EDungeonSubType)GameModeModel.Instance.InstanceDungeon.Value.InstSubType;
			if (instanceDungeonExitConfirmBoxData.ParseRuleType == EInstanceDungeonExitConfirmBoxParseRule.ConfirmBox && (instSubType == EDungeonSubType.RolePlot || instSubType == EDungeonSubType.MainLine || instSubType == EDungeonSubType.SingleDungeon))
			{
				if (InstanceDungeonEntranceModel.Instance.IsDungeonSupportArchive(id))
				{
					if (instanceDungeonExitConfirmBoxData.UnfinishedBoxId.GetValueOrDefault() == 0)
					{
						instanceDungeonExitConfirmBoxData.UnfinishedBoxId = new int?(284);
					}
					if (instanceDungeonExitConfirmBoxData.UnfinishedTelBoxId.GetValueOrDefault() == 0)
					{
						instanceDungeonExitConfirmBoxData.UnfinishedTelBoxId = new int?(284);
					}
				}
				else
				{
					if (instanceDungeonExitConfirmBoxData.UnfinishedBoxId.GetValueOrDefault() == 0)
					{
						instanceDungeonExitConfirmBoxData.UnfinishedBoxId = new int?(285);
					}
					if (instanceDungeonExitConfirmBoxData.UnfinishedTelBoxId.GetValueOrDefault() == 0)
					{
						instanceDungeonExitConfirmBoxData.UnfinishedTelBoxId = new int?(285);
					}
				}
				if (instanceDungeonExitConfirmBoxData.FinishBoxId.GetValueOrDefault() == 0)
				{
					instanceDungeonExitConfirmBoxData.FinishBoxId = new int?(290);
				}
				if (instanceDungeonExitConfirmBoxData.FinishTelBoxId.GetValueOrDefault() == 0)
				{
					instanceDungeonExitConfirmBoxData.FinishTelBoxId = new int?(290);
				}
			}
			return instanceDungeonExitConfirmBoxData;
		}

		// Token: 0x06039A69 RID: 236137 RVA: 0x00DB369C File Offset: 0x00DB189C
		public int? GetCurrentDungeonExitConfirmId()
		{
			IInstanceDungeonExitConfirmBoxData currentDungeonExitConfirmData = this.GetCurrentDungeonExitConfirmData();
			if (this.InstanceFinishSuccess != EInstanceFinishState.UnFinish)
			{
				return currentDungeonExitConfirmData.FinishBoxId;
			}
			return currentDungeonExitConfirmData.UnfinishedBoxId;
		}

		// Token: 0x06039A6A RID: 236138 RVA: 0x00DB36C8 File Offset: 0x00DB18C8
		public int? GetCurrentDungeonTelExitConfirmId()
		{
			IInstanceDungeonExitConfirmBoxData currentDungeonExitConfirmData = this.GetCurrentDungeonExitConfirmData();
			if (InstanceDungeonModel.Instance.InstanceFinishSuccess != EInstanceFinishState.UnFinish)
			{
				return currentDungeonExitConfirmData.FinishTelBoxId;
			}
			return currentDungeonExitConfirmData.UnfinishedTelBoxId;
		}

		// Token: 0x06039A6B RID: 236139 RVA: 0x00DB36F5 File Offset: 0x00DB18F5
		public void ClearInstanceIdsWithSaveData()
		{
			this.InstanceIdsWithSaveData.Clear();
		}

		// Token: 0x06039A6C RID: 236140 RVA: 0x00DB3704 File Offset: 0x00DB1904
		public void AddInstanceIdsWithSaveData(params int[] ids)
		{
			foreach (int item in ids)
			{
				this.InstanceIdsWithSaveData.Add(item);
			}
		}

		// Token: 0x06039A6D RID: 236141 RVA: 0x00DB3732 File Offset: 0x00DB1932
		public bool GetIfInstanceHasSaveData(int instId)
		{
			if (RecallQuestModel.Instance.IsInRecallInstance())
			{
				return RecallQuestModel.Instance.GetIfInstanceHasSaveData(instId);
			}
			return this.InstanceIdsWithSaveData.Contains(instId);
		}

		// Token: 0x17008A7C RID: 35452
		// (get) Token: 0x06039A6E RID: 236142 RVA: 0x00DB3758 File Offset: 0x00DB1958
		public static InstanceDungeonModel Instance
		{
			get
			{
				return InstanceDungeonModel._Instance;
			}
		}

		// Token: 0x06039A6F RID: 236143 RVA: 0x00DB375F File Offset: 0x00DB195F
		public static InstanceDungeonModel GetOrCreateInstance()
		{
			if (InstanceDungeonModel._Instance == null)
			{
				InstanceDungeonModel.CreateInstance();
			}
			return InstanceDungeonModel._Instance;
		}

		// Token: 0x06039A70 RID: 236144 RVA: 0x00DB3773 File Offset: 0x00DB1973
		public static bool CreateInstance()
		{
			if (InstanceDungeonModel._Instance != null)
			{
				return true;
			}
			InstanceDungeonModel._Instance = new InstanceDungeonModel();
			return true;
		}

		// Token: 0x06039A71 RID: 236145 RVA: 0x00DB3789 File Offset: 0x00DB1989
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039A72 RID: 236146 RVA: 0x00DB378B File Offset: 0x00DB198B
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonModel._Instance = null;
		}

		// Token: 0x06039A73 RID: 236147 RVA: 0x00DB3793 File Offset: 0x00DB1993
		static InstanceDungeonModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonModel.CreateStaticDefaultValue), new Action(InstanceDungeonModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E1F9 RID: 123385
		private const int MATCHINGTEAMSIZE = 3;

		// Token: 0x0401E1FA RID: 123386
		private int InstanceId;

		// Token: 0x0401E1FC RID: 123388
		[Nullable(2)]
		private MatchTeamInfo MatchTeamInfo;

		// Token: 0x0401E1FD RID: 123389
		private readonly Dictionary<int, bool> MatchingTeamConfirmState = new Dictionary<int, bool>();

		// Token: 0x0401E1FE RID: 123390
		private readonly List<PrewarFormationData> PrewarFormationDataList = new List<PrewarFormationData>();

		// Token: 0x0401E1FF RID: 123391
		private readonly Dictionary<int, bool> PrewarPlayerReadyState = new Dictionary<int, bool>();

		// Token: 0x0401E200 RID: 123392
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<InstanceBeInviteData> InstanceBeInviteDataList;

		// Token: 0x0401E201 RID: 123393
		private readonly Dictionary<int, long> InviteCdMap = new Dictionary<int, long>();

		// Token: 0x0401E202 RID: 123394
		public EInstanceFinishState InstanceFinishSuccess;

		// Token: 0x0401E203 RID: 123395
		public bool InstanceRewardHaveTake;

		// Token: 0x0401E204 RID: 123396
		[Nullable(2)]
		private InstanceDungeonInfo InstanceDungeonInfo;

		// Token: 0x0401E206 RID: 123398
		[Nullable(2)]
		private string InstanceDungeonName;

		// Token: 0x0401E207 RID: 123399
		public bool? CurrentInstanceIsFinish = new bool?(false);

		// Token: 0x0401E208 RID: 123400
		public bool HidePowerLackConfirmBox;

		// Token: 0x0401E209 RID: 123401
		public EnterInstContext InstanceEnterContentText = new EnterInstContext();

		// Token: 0x0401E20A RID: 123402
		public List<int> TrialRoleDungeonWhiteList = new List<int>();

		// Token: 0x0401E20B RID: 123403
		private readonly HashSet<int> InstanceIdsWithSaveData = new HashSet<int>();

		// Token: 0x0401E20C RID: 123404
		[Nullable(2)]
		private static InstanceDungeonModel _Instance;
	}
}
