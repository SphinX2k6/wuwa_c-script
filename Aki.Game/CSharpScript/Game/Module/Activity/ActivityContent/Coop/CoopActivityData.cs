using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068C5 RID: 26821
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopActivityData : ActivityBaseData
	{
		// Token: 0x170097CE RID: 38862
		// (get) Token: 0x06042F06 RID: 274182 RVA: 0x0104CF61 File Offset: 0x0104B161
		public List<CoopRoleData> CoopRoleDataList
		{
			get
			{
				return new List<CoopRoleData>(this.CoopRoleDataDict.Values);
			}
		}

		// Token: 0x06042F07 RID: 274183 RVA: 0x0104CF74 File Offset: 0x0104B174
		protected override void PhraseEx(ActivityData data)
		{
			this.InitCoopRoleItemDataList(data.RoleCoopActivityData.CoopRoleInfos);
			this.InitCoopLevelItemDataList(data.RoleCoopActivityData.CoopTaskCompleteInfos);
			this.InitCoopSpRewardDataList(data.RoleCoopActivityData.RewardGetList);
			this.UpdatePreCompleteLevelIdSet(data.RoleCoopActivityData.PreCompleteIds);
		}

		// Token: 0x06042F08 RID: 274184 RVA: 0x0104CFC5 File Offset: 0x0104B1C5
		public override bool GetExternalButtonRedPointState()
		{
			return this.IsAnyRoleHasRedDot() || this.IsHasCoopSpRewardRedDot();
		}

		// Token: 0x06042F09 RID: 274185 RVA: 0x0104CFD7 File Offset: 0x0104B1D7
		public override bool GetExDataRedPointShowState()
		{
			return this.IsAnyRoleHasRedDot() || this.IsHasCoopSpRewardRedDot();
		}

		// Token: 0x06042F0A RID: 274186 RVA: 0x0104CFEC File Offset: 0x0104B1EC
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

		// Token: 0x06042F0B RID: 274187 RVA: 0x0104D0D4 File Offset: 0x0104B2D4
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

		// Token: 0x06042F0C RID: 274188 RVA: 0x0104D268 File Offset: 0x0104B468
		private void InitCoopLevelItemDataList(IList<CoopTaskCompleteInfo> dataList)
		{
			foreach (CoopTaskCompleteInfo data in dataList)
			{
				this.UpdateOneRoleLevelSubConditionData(data);
			}
		}

		// Token: 0x06042F0D RID: 274189 RVA: 0x0104D2B0 File Offset: 0x0104B4B0
		private void InitCoopSpRewardDataList(IList<int> idList)
		{
			this.CoopSpRewardClaimedSet.Clear();
			foreach (int item in idList)
			{
				this.CoopSpRewardClaimedSet.Add(item);
			}
			this.UpdateCoopSpRewardDataList();
		}

		// Token: 0x06042F0E RID: 274190 RVA: 0x0104D310 File Offset: 0x0104B510
		public void UpdatePreCompleteLevelIdSet(IList<int> preCompleteIds)
		{
			foreach (int item in preCompleteIds)
			{
				this.PreCompleteLevelIdSet.Add(item);
			}
			this.UpdateAllCoopRoleLevelDataState();
		}

		// Token: 0x06042F0F RID: 274191 RVA: 0x0104D364 File Offset: 0x0104B564
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

		// Token: 0x06042F10 RID: 274192 RVA: 0x0104D429 File Offset: 0x0104B629
		public bool IsLevelPreComplete(int levelId)
		{
			return this.PreCompleteLevelIdSet.Contains(levelId);
		}

		// Token: 0x06042F11 RID: 274193 RVA: 0x0104D438 File Offset: 0x0104B638
		public int GetCurTotalCoopLevel()
		{
			int num = 0;
			foreach (CoopRoleData coopRoleData in this.CoopRoleDataList)
			{
				num += coopRoleData.CurRoleLevel;
			}
			return num;
		}

		// Token: 0x06042F12 RID: 274194 RVA: 0x0104D490 File Offset: 0x0104B690
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

		// Token: 0x06042F13 RID: 274195 RVA: 0x0104D4F4 File Offset: 0x0104B6F4
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

		// Token: 0x06042F14 RID: 274196 RVA: 0x0104D550 File Offset: 0x0104B750
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

		// Token: 0x06042F15 RID: 274197 RVA: 0x0104D5B8 File Offset: 0x0104B7B8
		public void UpdateCoopSpRewardClaimed(List<int> rewardIds)
		{
			foreach (int item in rewardIds)
			{
				this.CoopSpRewardClaimedSet.Add(item);
			}
			this.UpdateCoopSpRewardDataList();
		}

		// Token: 0x06042F16 RID: 274198 RVA: 0x0104D614 File Offset: 0x0104B814
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

		// Token: 0x06042F17 RID: 274199 RVA: 0x0104D680 File Offset: 0x0104B880
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

		// Token: 0x06042F18 RID: 274200 RVA: 0x0104D6E8 File Offset: 0x0104B8E8
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

		// Token: 0x06042F19 RID: 274201 RVA: 0x0104D75C File Offset: 0x0104B95C
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

		// Token: 0x06042F1A RID: 274202 RVA: 0x0104D7C0 File Offset: 0x0104B9C0
		public long GetRoleMaxLevelTimeStamp(int roleId)
		{
			CoopRoleData roleData = this.GetRoleData(roleId);
			if (roleData == null)
			{
				return 0L;
			}
			return roleData.MaxLevelTimeStamp;
		}

		// Token: 0x06042F1B RID: 274203 RVA: 0x0104D7D8 File Offset: 0x0104B9D8
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

		// Token: 0x06042F1C RID: 274204 RVA: 0x0104D844 File Offset: 0x0104BA44
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

		// Token: 0x06042F1D RID: 274205 RVA: 0x0104D8B4 File Offset: 0x0104BAB4
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

		// Token: 0x06042F1E RID: 274206 RVA: 0x0104D9B0 File Offset: 0x0104BBB0
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

		// Token: 0x06042F1F RID: 274207 RVA: 0x0104DA9C File Offset: 0x0104BC9C
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

		// Token: 0x06042F20 RID: 274208 RVA: 0x0104DAF8 File Offset: 0x0104BCF8
		public bool IsRoleCurCoopLevelMax(int roleId)
		{
			CoopRoleData coopRoleData;
			return this.CoopRoleDataDict.TryGetValue(roleId, out coopRoleData) && coopRoleData.IsMaxLevel;
		}

		// Token: 0x06042F21 RID: 274209 RVA: 0x0104DB20 File Offset: 0x0104BD20
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

		// Token: 0x06042F22 RID: 274210 RVA: 0x0104DB88 File Offset: 0x0104BD88
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

		// Token: 0x06042F23 RID: 274211 RVA: 0x0104DBE4 File Offset: 0x0104BDE4
		public bool IsRoleHasRedDot(int roleId)
		{
			CoopRoleData coopRoleData;
			return this.CoopRoleDataDict.TryGetValue(roleId, out coopRoleData) && coopRoleData.IsUnLock && (this.IsRoleHasPhotoRedDot(roleId) || this.IsRoleHasCoopLevelRedDot(roleId));
		}

		// Token: 0x06042F24 RID: 274212 RVA: 0x0104DC20 File Offset: 0x0104BE20
		public bool IsRoleHasPhotoRedDot(int roleId)
		{
			return this.IsRoleCurCoopLevelMax(roleId) && !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.CoopRolePhotoRedDot) as ServerStorageSet).Has(roleId);
		}

		// Token: 0x06042F25 RID: 274213 RVA: 0x0104DC4C File Offset: 0x0104BE4C
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

		// Token: 0x06042F26 RID: 274214 RVA: 0x0104DCC8 File Offset: 0x0104BEC8
		public void ClearRolePhotoRedDot(int roleId)
		{
		}

		// Token: 0x06042F27 RID: 274215 RVA: 0x0104DCCC File Offset: 0x0104BECC
		public void UpdateAllCoopRoleLevelDataState()
		{
			foreach (CoopRoleData coopRoleData in this.CoopRoleDataDict.Values)
			{
				coopRoleData.UpdateAllCoopLevelDataState();
			}
		}

		// Token: 0x04022D1E RID: 142622
		public Dictionary<int, CoopRoleData> CoopRoleDataDict = new Dictionary<int, CoopRoleData>();

		// Token: 0x04022D1F RID: 142623
		public Dictionary<int, CoopLevelData> CoopLevelDataDict = new Dictionary<int, CoopLevelData>();

		// Token: 0x04022D20 RID: 142624
		public HashSet<int> CoopSpRewardClaimedSet = new HashSet<int>();

		// Token: 0x04022D21 RID: 142625
		public List<CoopSpRewardData> CoopSpRewardDataList = new List<CoopSpRewardData>();

		// Token: 0x04022D22 RID: 142626
		public HashSet<int> PreCompleteLevelIdSet = new HashSet<int>();
	}
}
