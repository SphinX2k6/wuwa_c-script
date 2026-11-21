using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x02005815 RID: 22549
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopActivityData : ActivityBaseData
	{
		// Token: 0x17006B0E RID: 27406
		// (get) Token: 0x06037A5E RID: 227934 RVA: 0x00F8E589 File Offset: 0x00F8C789
		public List<CoopRoleData> CoopRoleDataList
		{
			get
			{
				return new List<CoopRoleData>(this.CoopRoleDataDict.Values);
			}
		}

		// Token: 0x06037A5F RID: 227935 RVA: 0x00F8E59C File Offset: 0x00F8C79C
		protected override void PhraseEx(ActivityData data)
		{
			this.InitCoopRoleItemDataList(data.RoleCoopActivityData.CoopRoleInfos);
			this.InitCoopLevelItemDataList(data.RoleCoopActivityData.CoopTaskCompleteInfos);
			this.InitCoopSpRewardDataList(data.RoleCoopActivityData.RewardGetList);
			this.UpdatePreCompleteLevelIdSet(data.RoleCoopActivityData.PreCompleteIds);
		}

		// Token: 0x06037A60 RID: 227936 RVA: 0x00F8E5ED File Offset: 0x00F8C7ED
		public override bool GetExternalButtonRedPointState()
		{
			return this.IsAnyRoleHasRedDot() || this.IsHasCoopSpRewardRedDot();
		}

		// Token: 0x06037A61 RID: 227937 RVA: 0x00F8E5FF File Offset: 0x00F8C7FF
		public override bool GetExDataRedPointShowState()
		{
			return this.IsAnyRoleHasRedDot() || this.IsHasCoopSpRewardRedDot();
		}

		// Token: 0x06037A62 RID: 227938 RVA: 0x00F8E614 File Offset: 0x00F8C814
		protected override bool GetExDataFinishShowState()
		{
			using (List<CoopSpRewardData>.Enumerator enumerator = this.CoopSpRewardDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State != ECoopSpRewardState.Done)
					{
						return false;
					}
				}
			}
			foreach (CoopRoleData coopRoleData in this.CoopRoleDataDict.Values)
			{
				using (Dictionary<int, CoopLevelData>.ValueCollection.Enumerator enumerator3 = coopRoleData.CoopLevelDataDict.Values.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						if (enumerator3.Current.State != ECoopLevelStatus.Done)
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06037A63 RID: 227939 RVA: 0x00F8E6FC File Offset: 0x00F8C8FC
		private void InitCoopRoleItemDataList(IList<CoopRoleInfo> dataList)
		{
			this.CoopRoleDataDict.Clear();
			foreach (CoopRoleInfo coopRoleInfo in dataList)
			{
				int coopRoleId = coopRoleInfo.CoopRoleId;
				CoopRoleData coopRoleData = new CoopRoleData(coopRoleId);
				this.CoopRoleDataDict[coopRoleId] = coopRoleData;
				IReadOnlyList<CoopRoleLevel> coopConfigAllLevel = CoopConfig.Instance.GetCoopConfigAllLevel(base.Id, coopRoleId);
				if (coopConfigAllLevel != null)
				{
					foreach (CoopRoleLevel coopRoleLevel in coopConfigAllLevel)
					{
						CoopLevelData value = new CoopLevelData(coopRoleLevel.Id);
						coopRoleData.CoopLevelDataDict[coopRoleLevel.Id] = value;
						this.CoopLevelDataDict[coopRoleLevel.Id] = value;
					}
					coopRoleData.UpdateCurLevel(coopRoleInfo.RoleLevel, coopRoleInfo.RewardLevel);
					if (coopRoleInfo.FinishTime != 0L)
					{
						coopRoleData.SetMaxLevelTimeStamp(coopRoleInfo.FinishTime);
					}
				}
			}
			List<int> list = new List<int>(this.CoopRoleDataDict.Keys);
			list.Sort();
			Dictionary<int, CoopRoleData> dictionary = new Dictionary<int, CoopRoleData>();
			foreach (int key in list)
			{
				CoopRoleData value2;
				if (this.CoopRoleDataDict.TryGetValue(key, out value2))
				{
					dictionary[key] = value2;
				}
			}
			this.CoopRoleDataDict = dictionary;
		}

		// Token: 0x06037A64 RID: 227940 RVA: 0x00F8E890 File Offset: 0x00F8CA90
		private void InitCoopLevelItemDataList(IList<CoopTaskCompleteInfo> dataList)
		{
			foreach (CoopTaskCompleteInfo data in dataList)
			{
				this.UpdateOneRoleLevelSubConditionData(data);
			}
		}

		// Token: 0x06037A65 RID: 227941 RVA: 0x00F8E8D8 File Offset: 0x00F8CAD8
		private void InitCoopSpRewardDataList(IList<int> idList)
		{
			this.CoopSpRewardClaimedSet.Clear();
			foreach (int item in idList)
			{
				this.CoopSpRewardClaimedSet.Add(item);
			}
			this.UpdateCoopSpRewardDataList();
		}

		// Token: 0x06037A66 RID: 227942 RVA: 0x00F8E938 File Offset: 0x00F8CB38
		public void UpdatePreCompleteLevelIdSet(IList<int> preCompleteIds)
		{
			foreach (int item in preCompleteIds)
			{
				this.PreCompleteLevelIdSet.Add(item);
			}
			this.UpdateAllCoopRoleLevelDataState();
		}

		// Token: 0x06037A67 RID: 227943 RVA: 0x00F8E98C File Offset: 0x00F8CB8C
		private void UpdateCoopSpRewardDataList()
		{
			IReadOnlyList<CoopSpReward> coopSpRewardConfigByActivityId = CoopConfig.Instance.GetCoopSpRewardConfigByActivityId(base.Id);
			if (coopSpRewardConfigByActivityId == null)
			{
				return;
			}
			int curTotalCoopLevel = this.GetCurTotalCoopLevel();
			if (this.CoopSpRewardDataList.Count != coopSpRewardConfigByActivityId.Count)
			{
				this.CoopSpRewardDataList = new List<CoopSpRewardData>();
			}
			for (int i = 0; i < coopSpRewardConfigByActivityId.Count; i++)
			{
				CoopSpReward coopSpReward = coopSpRewardConfigByActivityId[i];
				ECoopSpRewardState state = ECoopSpRewardState.Lock;
				if (this.CoopSpRewardClaimedSet.Contains(coopSpReward.Id))
				{
					state = ECoopSpRewardState.Done;
				}
				else if (curTotalCoopLevel >= coopSpReward.RoleLevelSum)
				{
					state = ECoopSpRewardState.Reward;
				}
				if (i < this.CoopSpRewardDataList.Count)
				{
					this.CoopSpRewardDataList[i].SetState(state);
				}
				else
				{
					this.CoopSpRewardDataList.Add(new CoopSpRewardData(coopSpReward.Id, state));
				}
			}
		}

		// Token: 0x06037A68 RID: 227944 RVA: 0x00F8EA51 File Offset: 0x00F8CC51
		public bool IsLevelPreComplete(int levelId)
		{
			return this.PreCompleteLevelIdSet.Contains(levelId);
		}

		// Token: 0x06037A69 RID: 227945 RVA: 0x00F8EA60 File Offset: 0x00F8CC60
		public int GetCurTotalCoopLevel()
		{
			int num = 0;
			foreach (CoopRoleData coopRoleData in this.CoopRoleDataList)
			{
				num += coopRoleData.CurRoleLevel;
			}
			return num;
		}

		// Token: 0x06037A6A RID: 227946 RVA: 0x00F8EAB8 File Offset: 0x00F8CCB8
		public bool UpdateOneRoleData(CoopRoleInfo data)
		{
			CoopRoleData coopRoleData;
			if (!this.CoopRoleDataDict.TryGetValue(data.CoopRoleId, out coopRoleData))
			{
				return false;
			}
			int curRoleLevel = coopRoleData.CurRoleLevel;
			coopRoleData.UpdateCurLevel(data.RoleLevel, data.RewardLevel);
			if (data.FinishTime != 0L)
			{
				coopRoleData.SetMaxLevelTimeStamp(data.FinishTime);
			}
			this.UpdateCoopSpRewardDataList();
			return curRoleLevel < data.RoleLevel;
		}

		// Token: 0x06037A6B RID: 227947 RVA: 0x00F8EB1C File Offset: 0x00F8CD1C
		public void UpdateOneRoleLevelSubConditionData(CoopTaskCompleteInfo data)
		{
			CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(data.CoopTaskId);
			if (coopTaskConfigById == null)
			{
				return;
			}
			int coopLevelId = coopTaskConfigById.Value.CoopLevelId;
			CoopLevelData coopLevelData;
			if (!this.CoopLevelDataDict.TryGetValue(coopLevelId, out coopLevelData))
			{
				return;
			}
			if (!coopLevelData.IsHaveSubCondition)
			{
				return;
			}
			coopLevelData.UpdateSubConditionState(data);
		}

		// Token: 0x06037A6C RID: 227948 RVA: 0x00F8EB78 File Offset: 0x00F8CD78
		public void UpdateCoopRoleReward(int levelId)
		{
			CoopRoleLevel? coopConfigById = CoopConfig.Instance.GetCoopConfigById(levelId);
			if (coopConfigById == null || coopConfigById.Value.CoopRoleId == 0)
			{
				return;
			}
			CoopRoleData coopRoleData;
			if (!this.CoopRoleDataDict.TryGetValue(coopConfigById.Value.CoopRoleId, out coopRoleData))
			{
				return;
			}
			coopRoleData.CurRewardLevel = coopRoleData.CurRoleLevel;
			coopRoleData.UpdateAllCoopLevelDataState();
		}

		// Token: 0x06037A6D RID: 227949 RVA: 0x00F8EBE0 File Offset: 0x00F8CDE0
		public void UpdateCoopSpRewardClaimed(List<int> rewardIds)
		{
			foreach (int item in rewardIds)
			{
				this.CoopSpRewardClaimedSet.Add(item);
			}
			this.UpdateCoopSpRewardDataList();
		}

		// Token: 0x06037A6E RID: 227950 RVA: 0x00F8EC3C File Offset: 0x00F8CE3C
		[NullableContext(2)]
		public CoopRoleData GetRoleData(int roleId)
		{
			if (!this.CoopRoleDataDict.ContainsKey(roleId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LZK;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[Coop] 获取Coop角色数据失败，roleId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(roleId);
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			CoopRoleData result;
			this.CoopRoleDataDict.TryGetValue(roleId, out result);
			return result;
		}

		// Token: 0x06037A6F RID: 227951 RVA: 0x00F8ECA8 File Offset: 0x00F8CEA8
		public int GetRoleIndexByRoleId(int roleId)
		{
			int num = new List<int>(this.CoopRoleDataDict.Keys).IndexOf(roleId);
			if (num == -1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LZK;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[Coop] 获取Coop角色索引失败，roleId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(roleId);
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return num;
		}

		// Token: 0x06037A70 RID: 227952 RVA: 0x00F8ED10 File Offset: 0x00F8CF10
		public int GetRoleIdByIndex(int index)
		{
			if (index < 0 || index >= this.CoopRoleDataList.Count)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LZK;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[Coop] 获取Coop角色Id失败，index: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(index);
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return -1;
			}
			return this.CoopRoleDataList[index].RoleId;
		}

		// Token: 0x06037A71 RID: 227953 RVA: 0x00F8ED84 File Offset: 0x00F8CF84
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<CoopLevelData> GetCoopLevelDataListByRoleId(int roleId)
		{
			CoopRoleData coopRoleData;
			if (this.CoopRoleDataDict.TryGetValue(roleId, out coopRoleData))
			{
				return coopRoleData.GetCoopLevelDataList();
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.LZK;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
			defaultInterpolatedStringHandler.AppendLiteral("[Coop] 获取角色Coop等级数据列表失败，roleId: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(roleId);
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}

		// Token: 0x06037A72 RID: 227954 RVA: 0x00F8EDE8 File Offset: 0x00F8CFE8
		public long GetRoleMaxLevelTimeStamp(int roleId)
		{
			CoopRoleData roleData = this.GetRoleData(roleId);
			if (roleData == null)
			{
				return 0L;
			}
			return roleData.MaxLevelTimeStamp;
		}

		// Token: 0x06037A73 RID: 227955 RVA: 0x00F8EE00 File Offset: 0x00F8D000
		[NullableContext(2)]
		public CoopLevelData GetCoopLevelData(int levelId)
		{
			if (!this.CoopLevelDataDict.ContainsKey(levelId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LZK;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[Coop] 获取Coop等级数据失败，levelId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(levelId);
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			CoopLevelData result;
			this.CoopLevelDataDict.TryGetValue(levelId, out result);
			return result;
		}

		// Token: 0x06037A74 RID: 227956 RVA: 0x00F8EE6C File Offset: 0x00F8D06C
		public int GetRoleCurCoopLevel(int roleId)
		{
			CoopRoleData coopRoleData;
			if (this.CoopRoleDataDict.TryGetValue(roleId, out coopRoleData))
			{
				return coopRoleData.CurRoleLevel;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.LZK;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
			defaultInterpolatedStringHandler.AppendLiteral("[Coop] 获取角色Coop等级失败，roleId: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(roleId);
			defaultInterpolatedStringHandler.AppendLiteral("，返回0");
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0;
		}

		// Token: 0x06037A75 RID: 227957 RVA: 0x00F8EEDC File Offset: 0x00F8D0DC
		public int GetRoleCurCoopLevelId(int roleId)
		{
			CoopRoleData coopRoleData;
			this.CoopRoleDataDict.TryGetValue(roleId, out coopRoleData);
			IReadOnlyList<CoopRoleLevel> coopConfigAllLevel = CoopConfig.Instance.GetCoopConfigAllLevel(base.Id, roleId);
			if (coopRoleData == null || coopConfigAllLevel == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LZK;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(65, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[Coop] 获取角色Coop等级Id失败，roleData or allLevelConfig is null，roleId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(roleId);
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return 0;
			}
			CoopRoleLevel? coopRoleLevel = null;
			foreach (CoopRoleLevel value in coopConfigAllLevel)
			{
				if (value.CoopLevel == coopRoleData.CurRoleLevel)
				{
					coopRoleLevel = new CoopRoleLevel?(value);
					break;
				}
			}
			if (coopRoleLevel == null)
			{
				return coopConfigAllLevel[0].Id;
			}
			return coopRoleLevel.GetValueOrDefault().Id;
		}

		// Token: 0x06037A76 RID: 227958 RVA: 0x00F8EFD8 File Offset: 0x00F8D1D8
		public int GetRoleCurCoopLevelIdFinalZero(int roleId)
		{
			CoopRoleData coopRoleData;
			this.CoopRoleDataDict.TryGetValue(roleId, out coopRoleData);
			IReadOnlyList<CoopRoleLevel> coopConfigAllLevel = CoopConfig.Instance.GetCoopConfigAllLevel(base.Id, roleId);
			if (coopRoleData == null || coopConfigAllLevel == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LZK;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(65, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[Coop] 获取角色Coop等级Id失败，roleData or allLevelConfig is null，roleId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(roleId);
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return 0;
			}
			CoopRoleLevel? coopRoleLevel = null;
			foreach (CoopRoleLevel value in coopConfigAllLevel)
			{
				if (value.CoopLevel == coopRoleData.CurRoleLevel)
				{
					coopRoleLevel = new CoopRoleLevel?(value);
					break;
				}
			}
			if (coopRoleLevel == null)
			{
				return 0;
			}
			return coopRoleLevel.GetValueOrDefault().Id;
		}

		// Token: 0x06037A77 RID: 227959 RVA: 0x00F8F0C4 File Offset: 0x00F8D2C4
		public int GetClaimedRewardCount()
		{
			int num = 0;
			using (List<CoopSpRewardData>.Enumerator enumerator = this.CoopSpRewardDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State == ECoopSpRewardState.Done)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06037A78 RID: 227960 RVA: 0x00F8F120 File Offset: 0x00F8D320
		public bool IsRoleCurCoopLevelMax(int roleId)
		{
			CoopRoleData coopRoleData;
			return this.CoopRoleDataDict.TryGetValue(roleId, out coopRoleData) && coopRoleData.IsMaxLevel;
		}

		// Token: 0x06037A79 RID: 227961 RVA: 0x00F8F148 File Offset: 0x00F8D348
		public bool IsAnyRoleHasRedDot()
		{
			foreach (CoopRoleData coopRoleData in this.CoopRoleDataDict.Values)
			{
				if (this.IsRoleHasRedDot(coopRoleData.RoleId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06037A7A RID: 227962 RVA: 0x00F8F1B0 File Offset: 0x00F8D3B0
		public bool IsHasCoopSpRewardRedDot()
		{
			using (List<CoopSpRewardData>.Enumerator enumerator = this.CoopSpRewardDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State == ECoopSpRewardState.Reward)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06037A7B RID: 227963 RVA: 0x00F8F20C File Offset: 0x00F8D40C
		public bool IsRoleHasRedDot(int roleId)
		{
			CoopRoleData coopRoleData;
			return this.CoopRoleDataDict.TryGetValue(roleId, out coopRoleData) && coopRoleData.IsUnLock && (this.IsRoleHasPhotoRedDot(roleId) || this.IsRoleHasCoopLevelRedDot(roleId));
		}

		// Token: 0x06037A7C RID: 227964 RVA: 0x00F8F248 File Offset: 0x00F8D448
		public bool IsRoleHasPhotoRedDot(int roleId)
		{
			return this.IsRoleCurCoopLevelMax(roleId) && !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.CoopRolePhotoRedDot) as ServerStorageSet).Has(roleId);
		}

		// Token: 0x06037A7D RID: 227965 RVA: 0x00F8F274 File Offset: 0x00F8D474
		private bool IsRoleHasCoopLevelRedDot(int roleId)
		{
			CoopRoleData coopRoleData;
			this.CoopRoleDataDict.TryGetValue(roleId, out coopRoleData);
			foreach (CoopLevelData coopLevelData in coopRoleData.CoopLevelDataDict.Values)
			{
				if (coopLevelData.State == ECoopLevelStatus.Reward)
				{
					return true;
				}
				if (coopLevelData.IsShowDoingNew)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06037A7E RID: 227966 RVA: 0x00F8F2F0 File Offset: 0x00F8D4F0
		public void ClearRolePhotoRedDot(int roleId)
		{
		}

		// Token: 0x06037A7F RID: 227967 RVA: 0x00F8F2F4 File Offset: 0x00F8D4F4
		public void UpdateAllCoopRoleLevelDataState()
		{
			foreach (CoopRoleData coopRoleData in this.CoopRoleDataDict.Values)
			{
				coopRoleData.UpdateAllCoopLevelDataState();
			}
		}

		// Token: 0x0401D57A RID: 120186
		public Dictionary<int, CoopRoleData> CoopRoleDataDict = new Dictionary<int, CoopRoleData>();

		// Token: 0x0401D57B RID: 120187
		public Dictionary<int, CoopLevelData> CoopLevelDataDict = new Dictionary<int, CoopLevelData>();

		// Token: 0x0401D57C RID: 120188
		public HashSet<int> CoopSpRewardClaimedSet = new HashSet<int>();

		// Token: 0x0401D57D RID: 120189
		public List<CoopSpRewardData> CoopSpRewardDataList = new List<CoopSpRewardData>();

		// Token: 0x0401D57E RID: 120190
		public HashSet<int> PreCompleteLevelIdSet = new HashSet<int>();
	}
}
