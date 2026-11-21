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
	// Token: 0x02004853 RID: 18515
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonModel : ModelBase
	{
		// Token: 0x0602E94E RID: 190798 RVA: 0x00D0143B File Offset: 0x00CFF63B
		protected override bool OnLeaveLevel()
		{
			InstanceDungeonInfo instanceDungeonInfo = this.InstanceDungeonInfo;
			if (instanceDungeonInfo != null)
			{
				instanceDungeonInfo.SetTrack(false, ESetTrackReason.None);
			}
			this.ResetInstanceRoundState();
			this.ClearInstanceDungeonInfo();
			return true;
		}

		// Token: 0x0602E94F RID: 190799 RVA: 0x00D0145D File Offset: 0x00CFF65D
		internal void ResetInstanceRoundState()
		{
			this.InstanceFinishSuccess = EInstanceFinishState.UnFinish;
			this.InstanceRewardHaveTake = false;
		}

		// Token: 0x0602E950 RID: 190800 RVA: 0x00D0146D File Offset: 0x00CFF66D
		public int GetInstanceId()
		{
			return this.InstanceId;
		}

		// Token: 0x0602E951 RID: 190801 RVA: 0x00D01475 File Offset: 0x00CFF675
		public void SetInstanceId(int instanceId)
		{
			this.InstanceId = instanceId;
		}

		// Token: 0x17005E45 RID: 24133
		// (get) Token: 0x0602E952 RID: 190802 RVA: 0x00D0147E File Offset: 0x00CFF67E
		// (set) Token: 0x0602E953 RID: 190803 RVA: 0x00D01486 File Offset: 0x00CFF686
		public bool InstanceContinue { get; set; }

		// Token: 0x0602E954 RID: 190804 RVA: 0x00D0148F File Offset: 0x00CFF68F
		public void SetMatchTeamInfo(MatchTeamInfo matchTeamInfo)
		{
			this.MatchTeamInfo = matchTeamInfo;
		}

		// Token: 0x0602E955 RID: 190805 RVA: 0x00D01498 File Offset: 0x00CFF698
		[NullableContext(2)]
		public MatchTeamInfo GetMatchTeamInfo()
		{
			return this.MatchTeamInfo;
		}

		// Token: 0x0602E956 RID: 190806 RVA: 0x00D014A0 File Offset: 0x00CFF6A0
		public void SetMatchTeamHost(int id)
		{
			this.MatchTeamInfo.HostId = id;
		}

		// Token: 0x0602E957 RID: 190807 RVA: 0x00D014AE File Offset: 0x00CFF6AE
		public void SetMatchTeamState(MatchTeamState state)
		{
			this.MatchTeamInfo.TeamState = state;
		}

		// Token: 0x0602E958 RID: 190808 RVA: 0x00D014BC File Offset: 0x00CFF6BC
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

		// Token: 0x0602E959 RID: 190809 RVA: 0x00D01548 File Offset: 0x00CFF748
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

		// Token: 0x0602E95A RID: 190810 RVA: 0x00D015E8 File Offset: 0x00CFF7E8
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

		// Token: 0x0602E95B RID: 190811 RVA: 0x00D01688 File Offset: 0x00CFF888
		public bool IsMatchTeamHost()
		{
			int playerId = CreatureModel.Instance.GetPlayerId();
			MatchTeamInfo matchTeamInfo = this.MatchTeamInfo;
			int? num = (matchTeamInfo != null) ? new int?(matchTeamInfo.HostId) : null;
			return playerId == num.GetValueOrDefault() & num != null;
		}

		// Token: 0x0602E95C RID: 190812 RVA: 0x00D016D0 File Offset: 0x00CFF8D0
		public bool IsTeamNotFull()
		{
			return this.GetTeamSize() < 3;
		}

		// Token: 0x0602E95D RID: 190813 RVA: 0x00D016DB File Offset: 0x00CFF8DB
		public int GetNeedMatchSize()
		{
			return 3 - this.GetTeamSize();
		}

		// Token: 0x0602E95E RID: 190814 RVA: 0x00D016E8 File Offset: 0x00CFF8E8
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

		// Token: 0x0602E95F RID: 190815 RVA: 0x00D01790 File Offset: 0x00CFF990
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

		// Token: 0x0602E960 RID: 190816 RVA: 0x00D01830 File Offset: 0x00CFFA30
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

		// Token: 0x0602E961 RID: 190817 RVA: 0x00D018F8 File Offset: 0x00CFFAF8
		public void SetMatchingPlayerConfirmState(int playerId, bool confirm)
		{
			this.MatchingTeamConfirmState[playerId] = confirm;
		}

		// Token: 0x0602E962 RID: 190818 RVA: 0x00D01908 File Offset: 0x00CFFB08
		public bool? GetMatchingPlayerConfirmStateByPlayerId(int playerId)
		{
			bool value;
			if (this.MatchingTeamConfirmState.TryGetValue(playerId, out value))
			{
				return new bool?(value);
			}
			return null;
		}

		// Token: 0x0602E963 RID: 190819 RVA: 0x00D01935 File Offset: 0x00CFFB35
		public bool GetMatchingTeamReady()
		{
			return this.MatchTeamInfo.TeamState == MatchTeamState.ReadyConfirm;
		}

		// Token: 0x0602E964 RID: 190820 RVA: 0x00D01948 File Offset: 0x00CFFB48
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

		// Token: 0x0602E965 RID: 190821 RVA: 0x00D019A8 File Offset: 0x00CFFBA8
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

		// Token: 0x0602E966 RID: 190822 RVA: 0x00D01A14 File Offset: 0x00CFFC14
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

		// Token: 0x0602E967 RID: 190823 RVA: 0x00D01A80 File Offset: 0x00CFFC80
		public void RemovePrewarPlayerReadyState(int playerId)
		{
			this.PrewarPlayerReadyState.Remove(playerId);
		}

		// Token: 0x0602E968 RID: 190824 RVA: 0x00D01A8F File Offset: 0x00CFFC8F
		public void ClearPrewarPlayerReadyState()
		{
			this.PrewarPlayerReadyState.Clear();
		}

		// Token: 0x0602E969 RID: 190825 RVA: 0x00D01A9C File Offset: 0x00CFFC9C
		public void RemoveMatchingTeamConfirmState(int playerId)
		{
			this.MatchingTeamConfirmState.Remove(playerId);
		}

		// Token: 0x0602E96A RID: 190826 RVA: 0x00D01AAB File Offset: 0x00CFFCAB
		public void ClearMatchingTeamConfirmState()
		{
			this.MatchingTeamConfirmState.Clear();
		}

		// Token: 0x0602E96B RID: 190827 RVA: 0x00D01AB8 File Offset: 0x00CFFCB8
		public bool GetPrewarPlayerReadyState(int playerId)
		{
			bool flag;
			return this.PrewarPlayerReadyState.TryGetValue(playerId, out flag) && flag && flag;
		}

		// Token: 0x0602E96C RID: 190828 RVA: 0x00D01ADB File Offset: 0x00CFFCDB
		private void ParseMatchRoleInfo(PrewarFormationData data, MatchRoleInfo info)
		{
			data.SetLevel(info.RoleLevel);
			data.SetConfigId(info.RoleId);
			data.SetSkinId(info.RoleSkinId);
			data.SetMultiSkillBranchId(info.SkillBranchId);
		}

		// Token: 0x0602E96D RID: 190829 RVA: 0x00D01B10 File Offset: 0x00CFFD10
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

		// Token: 0x0602E96E RID: 190830 RVA: 0x00D01BF4 File Offset: 0x00CFFDF4
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

		// Token: 0x0602E96F RID: 190831 RVA: 0x00D01C9C File Offset: 0x00CFFE9C
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

		// Token: 0x0602E970 RID: 190832 RVA: 0x00D01DA4 File Offset: 0x00CFFFA4
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

		// Token: 0x0602E971 RID: 190833 RVA: 0x00D01E5C File Offset: 0x00D0005C
		public IReadOnlyList<PrewarFormationData> GetPrewarFormationDataList()
		{
			return this.PrewarFormationDataList;
		}

		// Token: 0x0602E972 RID: 190834 RVA: 0x00D01E64 File Offset: 0x00D00064
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

		// Token: 0x0602E973 RID: 190835 RVA: 0x00D01F10 File Offset: 0x00D00110
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

		// Token: 0x0602E974 RID: 190836 RVA: 0x00D01F70 File Offset: 0x00D00170
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

		// Token: 0x0602E975 RID: 190837 RVA: 0x00D0201C File Offset: 0x00D0021C
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

		// Token: 0x0602E976 RID: 190838 RVA: 0x00D02064 File Offset: 0x00D00264
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

		// Token: 0x0602E977 RID: 190839 RVA: 0x00D020C0 File Offset: 0x00D002C0
		public void ClearPrewarData()
		{
			this.PrewarFormationDataList.Clear();
		}

		// Token: 0x0602E978 RID: 190840 RVA: 0x00D020CD File Offset: 0x00D002CD
		public int MatchingPlayerCount()
		{
			return this.MatchingTeamConfirmState.Count;
		}

		// Token: 0x17005E46 RID: 24134
		// (get) Token: 0x0602E979 RID: 190841 RVA: 0x00D020DC File Offset: 0x00D002DC
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

		// Token: 0x0602E97A RID: 190842 RVA: 0x00D02168 File Offset: 0x00D00368
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

		// Token: 0x0602E97B RID: 190843 RVA: 0x00D02216 File Offset: 0x00D00416
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<InstanceBeInviteData> GetInstanceBeInviteDataList()
		{
			return this.InstanceBeInviteDataList;
		}

		// Token: 0x0602E97C RID: 190844 RVA: 0x00D0221E File Offset: 0x00D0041E
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

		// Token: 0x0602E97D RID: 190845 RVA: 0x00D02254 File Offset: 0x00D00454
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

		// Token: 0x0602E97E RID: 190846 RVA: 0x00D0229C File Offset: 0x00D0049C
		public long GetInvitePlayerCd(int playerId)
		{
			long num;
			if (this.InviteCdMap.TryGetValue(playerId, out num) && num != 0L)
			{
				return num;
			}
			return 0L;
		}

		// Token: 0x0602E97F RID: 190847 RVA: 0x00D022C0 File Offset: 0x00D004C0
		public void SetInvitePlayerCd(int playerId, long value)
		{
			this.InviteCdMap[playerId] = value;
		}

		// Token: 0x0602E980 RID: 190848 RVA: 0x00D022CF File Offset: 0x00D004CF
		public InstanceDungeonInfo CreateInstanceInfo(int id)
		{
			this.InstanceDungeonInfo = new InstanceDungeonInfo(id);
			this.InstanceDungeonInfo.InitConfig();
			return this.InstanceDungeonInfo;
		}

		// Token: 0x0602E981 RID: 190849 RVA: 0x00D022EE File Offset: 0x00D004EE
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

		// Token: 0x0602E982 RID: 190850 RVA: 0x00D0230B File Offset: 0x00D0050B
		[NullableContext(2)]
		public InstanceDungeonInfo GetInstanceDungeonInfo()
		{
			return this.InstanceDungeonInfo;
		}

		// Token: 0x0602E983 RID: 190851 RVA: 0x00D02313 File Offset: 0x00D00513
		public void ResetData()
		{
			this.ClearPrewarData();
			this.ClearPrewarPlayerReadyState();
			this.ClearMatchingTeamConfirmState();
			this.MatchTeamInfo = null;
		}

		// Token: 0x17005E47 RID: 24135
		// (get) Token: 0x0602E984 RID: 190852 RVA: 0x00D0232E File Offset: 0x00D0052E
		// (set) Token: 0x0602E985 RID: 190853 RVA: 0x00D02336 File Offset: 0x00D00536
		[Nullable(2)]
		public List<int> LastEnterRoleList { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x0602E986 RID: 190854 RVA: 0x00D0233F File Offset: 0x00D0053F
		public void SetInstanceDungeonName(string name)
		{
			this.InstanceDungeonName = name;
		}

		// Token: 0x0602E987 RID: 190855 RVA: 0x00D02348 File Offset: 0x00D00548
		[NullableContext(2)]
		public string GetInstanceDungeonName()
		{
			return this.InstanceDungeonName;
		}

		// Token: 0x0602E988 RID: 190856 RVA: 0x00D02350 File Offset: 0x00D00550
		public void ConstructCurrentDungeonAreaName()
		{
			this.InstanceDungeonName = null;
			if (TowerModel.Instance.CheckInTower())
			{
				this.SetInstanceDungeonName(TowerModel.Instance.GetCurrentFloorName());
			}
		}

		// Token: 0x0602E989 RID: 190857 RVA: 0x00D02375 File Offset: 0x00D00575
		public void ClearInstanceEnterContentText()
		{
			this.InstanceEnterContentText = new EnterInstContext();
		}

		// Token: 0x0602E98A RID: 190858 RVA: 0x00D02384 File Offset: 0x00D00584
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

		// Token: 0x0602E98B RID: 190859 RVA: 0x00D02460 File Offset: 0x00D00660
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

		// Token: 0x0602E98C RID: 190860 RVA: 0x00D025B0 File Offset: 0x00D007B0
		public int? GetCurrentDungeonExitConfirmId()
		{
			IInstanceDungeonExitConfirmBoxData currentDungeonExitConfirmData = this.GetCurrentDungeonExitConfirmData();
			if (this.InstanceFinishSuccess != EInstanceFinishState.UnFinish)
			{
				return currentDungeonExitConfirmData.FinishBoxId;
			}
			return currentDungeonExitConfirmData.UnfinishedBoxId;
		}

		// Token: 0x0602E98D RID: 190861 RVA: 0x00D025DC File Offset: 0x00D007DC
		public int? GetCurrentDungeonTelExitConfirmId()
		{
			IInstanceDungeonExitConfirmBoxData currentDungeonExitConfirmData = this.GetCurrentDungeonExitConfirmData();
			if (InstanceDungeonModel.Instance.InstanceFinishSuccess != EInstanceFinishState.UnFinish)
			{
				return currentDungeonExitConfirmData.FinishTelBoxId;
			}
			return currentDungeonExitConfirmData.UnfinishedTelBoxId;
		}

		// Token: 0x0602E98E RID: 190862 RVA: 0x00D02609 File Offset: 0x00D00809
		public void ClearInstanceIdsWithSaveData()
		{
			this.InstanceIdsWithSaveData.Clear();
		}

		// Token: 0x0602E98F RID: 190863 RVA: 0x00D02618 File Offset: 0x00D00818
		public void AddInstanceIdsWithSaveData(params int[] ids)
		{
			foreach (int item in ids)
			{
				this.InstanceIdsWithSaveData.Add(item);
			}
		}

		// Token: 0x0602E990 RID: 190864 RVA: 0x00D02646 File Offset: 0x00D00846
		public bool GetIfInstanceHasSaveData(int instId)
		{
			if (RecallQuestModel.Instance.IsInRecallInstance())
			{
				return RecallQuestModel.Instance.GetIfInstanceHasSaveData(instId);
			}
			return this.InstanceIdsWithSaveData.Contains(instId);
		}

		// Token: 0x17005E48 RID: 24136
		// (get) Token: 0x0602E991 RID: 190865 RVA: 0x00D0266C File Offset: 0x00D0086C
		public static InstanceDungeonModel Instance
		{
			get
			{
				return InstanceDungeonModel._Instance;
			}
		}

		// Token: 0x0602E992 RID: 190866 RVA: 0x00D02673 File Offset: 0x00D00873
		public static InstanceDungeonModel GetOrCreateInstance()
		{
			if (InstanceDungeonModel._Instance == null)
			{
				InstanceDungeonModel.CreateInstance();
			}
			return InstanceDungeonModel._Instance;
		}

		// Token: 0x0602E993 RID: 190867 RVA: 0x00D02687 File Offset: 0x00D00887
		public static bool CreateInstance()
		{
			if (InstanceDungeonModel._Instance != null)
			{
				return true;
			}
			InstanceDungeonModel._Instance = new InstanceDungeonModel();
			return true;
		}

		// Token: 0x0602E994 RID: 190868 RVA: 0x00D0269D File Offset: 0x00D0089D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E995 RID: 190869 RVA: 0x00D0269F File Offset: 0x00D0089F
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonModel._Instance = null;
		}

		// Token: 0x0602E996 RID: 190870 RVA: 0x00D026A7 File Offset: 0x00D008A7
		static InstanceDungeonModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonModel.CreateStaticDefaultValue), new Action(InstanceDungeonModel.ResetStaticDefaultValue));
		}

		// Token: 0x04018C96 RID: 101526
		private const int MATCHINGTEAMSIZE = 3;

		// Token: 0x04018C97 RID: 101527
		private int InstanceId;

		// Token: 0x04018C99 RID: 101529
		[Nullable(2)]
		private MatchTeamInfo MatchTeamInfo;

		// Token: 0x04018C9A RID: 101530
		private readonly Dictionary<int, bool> MatchingTeamConfirmState = new Dictionary<int, bool>();

		// Token: 0x04018C9B RID: 101531
		private readonly List<PrewarFormationData> PrewarFormationDataList = new List<PrewarFormationData>();

		// Token: 0x04018C9C RID: 101532
		private readonly Dictionary<int, bool> PrewarPlayerReadyState = new Dictionary<int, bool>();

		// Token: 0x04018C9D RID: 101533
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<InstanceBeInviteData> InstanceBeInviteDataList;

		// Token: 0x04018C9E RID: 101534
		private readonly Dictionary<int, long> InviteCdMap = new Dictionary<int, long>();

		// Token: 0x04018C9F RID: 101535
		public EInstanceFinishState InstanceFinishSuccess;

		// Token: 0x04018CA0 RID: 101536
		public bool InstanceRewardHaveTake;

		// Token: 0x04018CA1 RID: 101537
		[Nullable(2)]
		private InstanceDungeonInfo InstanceDungeonInfo;

		// Token: 0x04018CA3 RID: 101539
		[Nullable(2)]
		private string InstanceDungeonName;

		// Token: 0x04018CA4 RID: 101540
		public bool? CurrentInstanceIsFinish = new bool?(false);

		// Token: 0x04018CA5 RID: 101541
		public bool HidePowerLackConfirmBox;

		// Token: 0x04018CA6 RID: 101542
		public EnterInstContext InstanceEnterContentText = new EnterInstContext();

		// Token: 0x04018CA7 RID: 101543
		public List<int> TrialRoleDungeonWhiteList = new List<int>();

		// Token: 0x04018CA8 RID: 101544
		private readonly HashSet<int> InstanceIdsWithSaveData = new HashSet<int>();

		// Token: 0x04018CA9 RID: 101545
		[Nullable(2)]
		private static InstanceDungeonModel _Instance;
	}
}
