using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x02005794 RID: 22420
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoActivityData : ActivityBaseData
	{
		// Token: 0x1700887A RID: 34938
		// (get) Token: 0x06038F14 RID: 233236 RVA: 0x00D88E8C File Offset: 0x00D8708C
		public int KurotatoConfigId
		{
			get
			{
				return this.KurotatoConfigIdInternal;
			}
		}

		// Token: 0x06038F15 RID: 233237 RVA: 0x00D88E94 File Offset: 0x00D87094
		protected override void OnInit(ActivityData data)
		{
			if (data.KurotatoActivityData == null)
			{
				Log.Instance.Error(ELogModule.Kurotato, ELogAuthor.CXJ, "Kurotato活动数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			KurotatoActivityConfig? activityConfig = KurotatoConfig.Instance.GetActivityConfig(base.Id);
			this.KurotatoConfigIdInternal = ((activityConfig != null) ? activityConfig.GetValueOrDefault().Id : 0);
			this.InitLevelData();
			this.InitRoleData();
			this.InitKurotatoItemData();
			this.InitKurotatoWeaponData();
		}

		// Token: 0x06038F16 RID: 233238 RVA: 0x00D88F14 File Offset: 0x00D87114
		protected override void PhraseEx(ActivityData data)
		{
			KurotatoActivityData kurotatoActivityData = data.KurotatoActivityData;
			if (kurotatoActivityData == null)
			{
				Log.Instance.Error(ELogModule.Kurotato, ELogAuthor.CXJ, "Kurotato活动数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.UpdateLevelData(kurotatoActivityData.KurotatoLevelInfos, false);
			this.UpdateRoleData(kurotatoActivityData.KurotatoRoleInfos, false);
			this.UpdateKurotatoItemDataList(kurotatoActivityData.UnlockItems, false);
			this.UpdateKurotatoWeaponDataList(kurotatoActivityData.UnlockWeapons, false);
			this.InitKurotatoNormalRewardData(kurotatoActivityData.ResTasks);
			this.InitKurotatoLimitRewardData(kurotatoActivityData.LimitTasks);
			this.InitScoreRewardReceivedData(kurotatoActivityData.ScoreTasks);
		}

		// Token: 0x06038F17 RID: 233239 RVA: 0x00D88FA4 File Offset: 0x00D871A4
		protected override bool GetExDataFinishShowState()
		{
			if (!base.IsUnLock())
			{
				return false;
			}
			ValueTuple<int, int> normalRewardProgress = this.GetNormalRewardProgress();
			int item = normalRewardProgress.Item1;
			int item2 = normalRewardProgress.Item2;
			return item >= item2;
		}

		// Token: 0x06038F18 RID: 233240 RVA: 0x00D88FD5 File Offset: 0x00D871D5
		public override bool GetExDataRedPointShowState()
		{
			return this.IsActHaveRedDot();
		}

		// Token: 0x06038F19 RID: 233241 RVA: 0x00D88FE0 File Offset: 0x00D871E0
		public bool IsActHaveRedDot()
		{
			return this.IsNormalRewardViewHasRedDot() || this.IsLimitTimeRewardViewHasRedDot() || this.IsRoleHasRedDot() || this.IsKurotatoItemHasRedDot() || this.IsKurotatoWeaponHasRedDot() || this.IsStageEntranceRedDot(EKurotatoLevelMode.Teach) || this.IsStageEntranceRedDot(EKurotatoLevelMode.Endless) || this.IsScoreRewardHasRedDot();
		}

		// Token: 0x06038F1A RID: 233242 RVA: 0x00D89030 File Offset: 0x00D87230
		private void InitLevelData()
		{
			foreach (KurotatoLevel config in KurotatoConfig.Instance.GetLevelList())
			{
				KurotatoLevelData kurotatoLevelData = new KurotatoLevelData(config, base.Id);
				this.LevelMap[config.Id] = kurotatoLevelData;
				int levelGroup = config.LevelGroup;
				if (!this.LevelGroupMap.ContainsKey(levelGroup))
				{
					this.LevelGroupMap[levelGroup] = new List<KurotatoLevelData>();
				}
				this.LevelGroupMap[levelGroup].Add(kurotatoLevelData);
			}
			using (Dictionary<int, List<KurotatoLevelData>>.ValueCollection.Enumerator enumerator2 = this.LevelGroupMap.Values.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					enumerator2.Current.Sort((KurotatoLevelData a, KurotatoLevelData b) => a.SortId - b.SortId);
				}
			}
		}

		// Token: 0x06038F1B RID: 233243 RVA: 0x00D89138 File Offset: 0x00D87338
		[NullableContext(2)]
		public KurotatoLevelData GetKurotatoLevelData(int id)
		{
			KurotatoLevelData result;
			if (!this.LevelMap.TryGetValue(id, out result))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Kurotato;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "获取KurotatoLevelData失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return result;
		}

		// Token: 0x06038F1C RID: 233244 RVA: 0x00D89188 File Offset: 0x00D87388
		public bool IsLevelUnLock(int id)
		{
			KurotatoLevelData kurotatoLevelData = this.GetKurotatoLevelData(id);
			return kurotatoLevelData != null && kurotatoLevelData.IsUnLock;
		}

		// Token: 0x06038F1D RID: 233245 RVA: 0x00D891A8 File Offset: 0x00D873A8
		public bool IsLevelFinished(int id)
		{
			KurotatoLevelData kurotatoLevelData = this.GetKurotatoLevelData(id);
			return kurotatoLevelData != null && kurotatoLevelData.IsFinished;
		}

		// Token: 0x06038F1E RID: 233246 RVA: 0x00D891C8 File Offset: 0x00D873C8
		public void UpdateLevelData(IList<KurotatoLevelInfo> levelInfoList, bool needEmit = false)
		{
			foreach (KurotatoLevelInfo kurotatoLevelInfo in levelInfoList)
			{
				KurotatoLevelData kurotatoLevelData = this.GetKurotatoLevelData(kurotatoLevelInfo.LevelId);
				if (kurotatoLevelData != null)
				{
					kurotatoLevelData.IsUnLock = kurotatoLevelInfo.IsUnlock;
					kurotatoLevelData.IsFinished = kurotatoLevelInfo.IsFinished;
					kurotatoLevelData.UnlockTime = MathUtils.Instance.LongToNumber(kurotatoLevelInfo.UnlockTime);
					if (kurotatoLevelInfo.EndlessLevelInfo != null && kurotatoLevelInfo.EndlessLevelInfo.PassRoleIds.Count > 0)
					{
						kurotatoLevelData.HistoryWave = kurotatoLevelInfo.EndlessLevelInfo.FinishWave;
						kurotatoLevelData.HistoryRoleId = kurotatoLevelInfo.EndlessLevelInfo.PassRoleIds[0];
						kurotatoLevelData.HistoryKillNum = kurotatoLevelInfo.EndlessLevelInfo.TotalKillCount;
					}
					KurotatoInstInfo instData = kurotatoLevelInfo.InstData;
					kurotatoLevelData.ArchivedData = ((instData != null && instData.RoleId != 0) ? instData : null);
				}
			}
			if (needEmit)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}
		}

		// Token: 0x06038F1F RID: 233247 RVA: 0x00D892DC File Offset: 0x00D874DC
		[NullableContext(0)]
		public ValueTuple<int, int> GetLevelProgress()
		{
			int num = 0;
			using (Dictionary<int, KurotatoLevelData>.ValueCollection.Enumerator enumerator = this.LevelMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsFinished)
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, this.LevelMap.Count);
		}

		// Token: 0x06038F20 RID: 233248 RVA: 0x00D8934C File Offset: 0x00D8754C
		[NullableContext(0)]
		public ValueTuple<int, int> GetLevelProgressByLevelGroup(int levelGroup)
		{
			int num = 0;
			List<KurotatoLevelData> list;
			if (!this.LevelGroupMap.TryGetValue(levelGroup, out list))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Kurotato;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "获取KurotatoLevelData列表失败,LevelGroup下不存在关卡";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LevelGroupId", levelGroup);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return new ValueTuple<int, int>(0, 0);
			}
			using (List<KurotatoLevelData>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsFinished)
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, list.Count);
		}

		// Token: 0x06038F21 RID: 233249 RVA: 0x00D893F4 File Offset: 0x00D875F4
		public int GetLatestUnfinishedLevelId(int levelGroupId)
		{
			List<KurotatoLevelData> list;
			if (!this.LevelGroupMap.TryGetValue(levelGroupId, out list) || list.Count == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Kurotato;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "获取KurotatoLevelData列表失败,LevelGroup下不存在关卡";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LevelGroupId", levelGroupId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			foreach (KurotatoLevelData kurotatoLevelData in list)
			{
				if (!kurotatoLevelData.IsFinished)
				{
					return kurotatoLevelData.Id;
				}
			}
			return list[list.Count - 1].Id;
		}

		// Token: 0x06038F22 RID: 233250 RVA: 0x00D894AC File Offset: 0x00D876AC
		public bool IsStageEntranceUnLock(EKurotatoLevelMode mode)
		{
			if (mode == EKurotatoLevelMode.Teach)
			{
				return true;
			}
			KurotatoLevelGroup? levelGroupConfig = KurotatoConfig.Instance.GetLevelGroupConfig((int)mode);
			if (levelGroupConfig == null)
			{
				return false;
			}
			KurotatoLevelData kurotatoLevelData = this.GetKurotatoLevelData(levelGroupConfig.Value.LevelId);
			return kurotatoLevelData != null && kurotatoLevelData.IsUnLock;
		}

		// Token: 0x06038F23 RID: 233251 RVA: 0x00D894FC File Offset: 0x00D876FC
		public bool IsStageEntranceRedDot(EKurotatoLevelMode mode)
		{
			List<KurotatoLevelData> list;
			if (!this.LevelGroupMap.TryGetValue((int)mode, out list) || list.Count == 0)
			{
				return false;
			}
			using (List<KurotatoLevelData>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HasRedDot)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06038F24 RID: 233252 RVA: 0x00D8956C File Offset: 0x00D8776C
		public int GetCurrentEndlessModeWave()
		{
			List<KurotatoLevelData> list;
			if (!this.LevelGroupMap.TryGetValue(3, out list) || list.Count == 0)
			{
				return 0;
			}
			return list[0].HistoryWave;
		}

		// Token: 0x06038F25 RID: 233253 RVA: 0x00D895A0 File Offset: 0x00D877A0
		public long GetEndlessLevelUnlockTime()
		{
			List<KurotatoLevelData> list;
			if (!this.LevelGroupMap.TryGetValue(3, out list) || list.Count == 0)
			{
				return 0L;
			}
			return list[0].UnlockTime;
		}

		// Token: 0x06038F26 RID: 233254 RVA: 0x00D895D4 File Offset: 0x00D877D4
		public string GetCurrentScoreLevelIcon(int maxWave)
		{
			foreach (KurotatoWaveLevel kurotatoWaveLevel in KurotatoConfig.Instance.GetWaveLevelConfigList())
			{
				if (kurotatoWaveLevel.WaveRange(0) <= maxWave && maxWave <= kurotatoWaveLevel.WaveRange(1))
				{
					return kurotatoWaveLevel.Icon;
				}
			}
			return "";
		}

		// Token: 0x06038F27 RID: 233255 RVA: 0x00D89648 File Offset: 0x00D87848
		public int GetNextLevelId(int currentLevelId)
		{
			KurotatoLevelData kurotatoLevelData = this.GetKurotatoLevelData(currentLevelId);
			if (kurotatoLevelData == null)
			{
				return 0;
			}
			List<KurotatoLevelData> list;
			if (!this.LevelGroupMap.TryGetValue(kurotatoLevelData.LevelGroup, out list))
			{
				return 0;
			}
			int num = list.FindIndex((KurotatoLevelData level) => level.Id == currentLevelId);
			if (num < 0 || num >= list.Count - 1)
			{
				return 0;
			}
			return list[num + 1].Id;
		}

		// Token: 0x06038F28 RID: 233256 RVA: 0x00D896C0 File Offset: 0x00D878C0
		private void InitRoleData()
		{
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			foreach (KurotatoCharacter config in KurotatoConfig.Instance.GetCharacterListByActivityId(this.KurotatoConfigId))
			{
				KurotatoRoleData kurotatoRoleData = new KurotatoRoleData(config, base.Id);
				this.RoleMap[config.Id] = kurotatoRoleData;
				if (this.CheckRoleIsValid((EKurotatoRoleType)config.Type, playerGender))
				{
					this.RoleList.Add(kurotatoRoleData);
				}
			}
			this.RoleList.Sort((KurotatoRoleData a, KurotatoRoleData b) => a.SortId - b.SortId);
		}

		// Token: 0x06038F29 RID: 233257 RVA: 0x00D89784 File Offset: 0x00D87984
		private bool CheckRoleIsValid(EKurotatoRoleType type, EPlayerGender gender)
		{
			return type == EKurotatoRoleType.Normal || (type == EKurotatoRoleType.MainRoleMale && gender == EPlayerGender.Male) || (type == EKurotatoRoleType.MainRoleFemale && gender == EPlayerGender.Female);
		}

		// Token: 0x06038F2A RID: 233258 RVA: 0x00D8979C File Offset: 0x00D8799C
		[NullableContext(2)]
		public KurotatoRoleData GetKurotatoRoleData(int id)
		{
			KurotatoRoleData result;
			if (!this.RoleMap.TryGetValue(id, out result))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Kurotato;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "获取KurotatoRoleData失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return result;
		}

		// Token: 0x06038F2B RID: 233259 RVA: 0x00D897EC File Offset: 0x00D879EC
		public void UpdateRoleData(IList<KurotatoRoleInfo> roleInfoList, bool needEmit = false)
		{
			foreach (KurotatoRoleInfo kurotatoRoleInfo in roleInfoList)
			{
				KurotatoRoleData kurotatoRoleData = this.GetKurotatoRoleData(kurotatoRoleInfo.RoleId);
				if (kurotatoRoleData != null)
				{
					kurotatoRoleData.IsUnLock = kurotatoRoleInfo.IsUnlock;
					kurotatoRoleData.HistoryWave = kurotatoRoleInfo.MaxFinishWave;
					kurotatoRoleData.HistoryKillNum = kurotatoRoleInfo.KillCount;
					KurotatoInstInfo instData = kurotatoRoleInfo.InstData;
					kurotatoRoleData.ArchivedData = ((instData != null && instData.RoleId != 0) ? instData : null);
				}
			}
			if (needEmit)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
				EventSystem.Instance.Emit(EEventName.OnRefreshKurotatoRoleRedDot);
			}
		}

		// Token: 0x06038F2C RID: 233260 RVA: 0x00D898A8 File Offset: 0x00D87AA8
		public List<KurotatoRoleData> GetKurotatoRoleList()
		{
			return this.RoleList;
		}

		// Token: 0x06038F2D RID: 233261 RVA: 0x00D898B0 File Offset: 0x00D87AB0
		public List<int> GetKurotatoRoleListInLevel(List<int> limitRoleList, List<int> recommendRoleList)
		{
			List<int> list = (from data in this.RoleList
			select data.Id).ToList<int>();
			list.Sort(delegate(int a, int b)
			{
				bool flag = limitRoleList.Contains(a);
				bool flag2 = limitRoleList.Contains(b);
				if (flag != flag2)
				{
					if (!flag)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					bool flag3 = recommendRoleList.Contains(a);
					bool flag4 = recommendRoleList.Contains(b);
					if (flag3 != flag4)
					{
						if (!flag3)
						{
							return 1;
						}
						return -1;
					}
					else
					{
						KurotatoRoleData kurotatoRoleData = this.GetKurotatoRoleData(a);
						KurotatoRoleData kurotatoRoleData2 = this.GetKurotatoRoleData(b);
						if (kurotatoRoleData.HasRoleSelectRedDot != kurotatoRoleData2.HasRoleSelectRedDot)
						{
							if (!kurotatoRoleData.HasRoleSelectRedDot)
							{
								return 1;
							}
							return -1;
						}
						else
						{
							if (kurotatoRoleData.IsUnLock == kurotatoRoleData2.IsUnLock)
							{
								return kurotatoRoleData.SortId - kurotatoRoleData2.SortId;
							}
							if (!kurotatoRoleData.IsUnLock)
							{
								return 1;
							}
							return -1;
						}
					}
				}
			});
			return list;
		}

		// Token: 0x06038F2E RID: 233262 RVA: 0x00D8991C File Offset: 0x00D87B1C
		public bool IsRoleHasRedDot()
		{
			using (Dictionary<int, KurotatoRoleData>.ValueCollection.Enumerator enumerator = this.RoleMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HasHandBookRedDot)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06038F2F RID: 233263 RVA: 0x00D8997C File Offset: 0x00D87B7C
		public void ReadRoleRedDot()
		{
			if (!this.IsRoleHasRedDot())
			{
				return;
			}
			foreach (KurotatoRoleData kurotatoRoleData in this.RoleMap.Values)
			{
				if (kurotatoRoleData.HasHandBookRedDot)
				{
					kurotatoRoleData.ReadHandBookRedDot(false);
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			EventSystem.Instance.Emit(EEventName.OnRefreshKurotatoRoleRedDot);
		}

		// Token: 0x06038F30 RID: 233264 RVA: 0x00D89A0C File Offset: 0x00D87C0C
		[NullableContext(0)]
		public ValueTuple<int, int> GetRoleUnlockNum()
		{
			int num = 0;
			using (List<KurotatoRoleData>.Enumerator enumerator = this.RoleList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnLock)
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, this.RoleList.Count);
		}

		// Token: 0x06038F31 RID: 233265 RVA: 0x00D89A78 File Offset: 0x00D87C78
		private void InitKurotatoItemData()
		{
			IReadOnlyList<KurotatoHandbook> kurotatoHandBookListByActivityIdAndType = KurotatoConfig.Instance.GetKurotatoHandBookListByActivityIdAndType(this.KurotatoConfigId, EKurotatoHandBookType.Item);
			if (kurotatoHandBookListByActivityIdAndType == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Kurotato;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "获取KurotatoHandbook道具列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", base.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			foreach (KurotatoHandbook kurotatoHandbook in kurotatoHandBookListByActivityIdAndType)
			{
				KurotatoItem? itemConfigByItemId = KurotatoConfig.Instance.GetItemConfigByItemId(kurotatoHandbook.Index);
				if (itemConfigByItemId == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Kurotato;
					ELogAuthor author2 = ELogAuthor.CXJ;
					string message2 = "获取KurotatoItem配置失败";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("index", kurotatoHandbook.Index);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				else
				{
					KurotatoItemData kurotatoItemData = new KurotatoItemData(itemConfigByItemId.Value, base.Id);
					this.ItemDataMap[itemConfigByItemId.Value.Id] = kurotatoItemData;
					this.ItemDataList.Add(kurotatoItemData);
				}
			}
		}

		// Token: 0x06038F32 RID: 233266 RVA: 0x00D89B9C File Offset: 0x00D87D9C
		public void UpdateKurotatoItemDataList(IList<int> itemIdList, bool needEmit = false)
		{
			foreach (int itemId in itemIdList)
			{
				this.UpdateKurotatoItemData(itemId);
			}
			this.SortItemDataList();
			this.ItemGridItemDataList.Clear();
			if (needEmit)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
				EventSystem.Instance.Emit(EEventName.OnRefreshKurotatoWeaponAndPropRedDot);
			}
		}

		// Token: 0x06038F33 RID: 233267 RVA: 0x00D89C20 File Offset: 0x00D87E20
		public void UpdateKurotatoItemData(int itemId)
		{
			KurotatoItemData kurotatoItemData = this.GetKurotatoItemData(itemId);
			if (kurotatoItemData == null)
			{
				return;
			}
			kurotatoItemData.IsUnLock = true;
		}

		// Token: 0x06038F34 RID: 233268 RVA: 0x00D89C40 File Offset: 0x00D87E40
		private void SortItemDataList()
		{
			this.ItemDataList.Sort(delegate(KurotatoItemData a, KurotatoItemData b)
			{
				if (a.IsUnLock != b.IsUnLock)
				{
					if (!a.IsUnLock)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					if (a.Quality != b.Quality)
					{
						return b.Quality - a.Quality;
					}
					return a.Id - b.Id;
				}
			});
		}

		// Token: 0x06038F35 RID: 233269 RVA: 0x00D89C6C File Offset: 0x00D87E6C
		[NullableContext(2)]
		public KurotatoItemData GetKurotatoItemData(int id)
		{
			KurotatoItemData result;
			if (!this.ItemDataMap.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06038F36 RID: 233270 RVA: 0x00D89C8C File Offset: 0x00D87E8C
		[NullableContext(0)]
		public ValueTuple<int, int> GetItemUnlockNum()
		{
			int num = 0;
			using (List<KurotatoItemData>.Enumerator enumerator = this.ItemDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnLock)
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, this.ItemDataList.Count);
		}

		// Token: 0x06038F37 RID: 233271 RVA: 0x00D89CF8 File Offset: 0x00D87EF8
		public bool IsKurotatoItemHasRedDot()
		{
			using (Dictionary<int, KurotatoItemData>.ValueCollection.Enumerator enumerator = this.ItemDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HasRedDot)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06038F38 RID: 233272 RVA: 0x00D89D58 File Offset: 0x00D87F58
		public void ReadKurotatoItemRedDot()
		{
			if (!this.IsKurotatoItemHasRedDot())
			{
				return;
			}
			foreach (KurotatoItemData kurotatoItemData in this.ItemDataMap.Values)
			{
				kurotatoItemData.ReadRedDot(false);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			EventSystem.Instance.Emit(EEventName.OnRefreshKurotatoWeaponAndPropRedDot);
		}

		// Token: 0x06038F39 RID: 233273 RVA: 0x00D89DE0 File Offset: 0x00D87FE0
		public List<IKurotatoMediumItemGridData> GetKurotatoItemList()
		{
			if (this.ItemGridItemDataList.Count > 0)
			{
				return this.ItemGridItemDataList;
			}
			foreach (KurotatoItemData kurotatoItemData in this.ItemDataList)
			{
				KurotatoMediumItemGridData item = new KurotatoMediumItemGridData
				{
					Id = kurotatoItemData.Id,
					Type = EKurotatoCardType.Item,
					IncId = 0,
					Count = 0
				};
				this.ItemGridItemDataList.Add(item);
			}
			return this.ItemGridItemDataList;
		}

		// Token: 0x06038F3A RID: 233274 RVA: 0x00D89E7C File Offset: 0x00D8807C
		private void InitKurotatoWeaponData()
		{
			IReadOnlyList<KurotatoHandbook> kurotatoHandBookListByActivityIdAndType = KurotatoConfig.Instance.GetKurotatoHandBookListByActivityIdAndType(this.KurotatoConfigId, EKurotatoHandBookType.Weapon);
			if (kurotatoHandBookListByActivityIdAndType == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Kurotato;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "获取KurotatoHandbook武器列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", base.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			foreach (KurotatoHandbook kurotatoHandbook in kurotatoHandBookListByActivityIdAndType)
			{
				KurotatoWeapon? weaponConfigByWeaponId = KurotatoConfig.Instance.GetWeaponConfigByWeaponId(kurotatoHandbook.Index);
				if (weaponConfigByWeaponId == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Kurotato;
					ELogAuthor author2 = ELogAuthor.CXJ;
					string message2 = "获取KurotatoWeapon配置失败";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("index", kurotatoHandbook.Index);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				else
				{
					KurotatoWeaponData kurotatoWeaponData = new KurotatoWeaponData(weaponConfigByWeaponId.Value, base.Id);
					this.WeaponDataMap[weaponConfigByWeaponId.Value.Id] = kurotatoWeaponData;
					this.WeaponDataList.Add(kurotatoWeaponData);
				}
			}
		}

		// Token: 0x06038F3B RID: 233275 RVA: 0x00D89FA0 File Offset: 0x00D881A0
		private void SortWeaponDataList()
		{
			this.WeaponDataList.Sort(delegate(KurotatoWeaponData a, KurotatoWeaponData b)
			{
				if (a.IsUnLock != b.IsUnLock)
				{
					if (!a.IsUnLock)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					if (a.Quality != b.Quality)
					{
						return b.Quality - a.Quality;
					}
					return a.Id - b.Id;
				}
			});
		}

		// Token: 0x06038F3C RID: 233276 RVA: 0x00D89FCC File Offset: 0x00D881CC
		public void UpdateKurotatoWeaponDataList(IList<int> itemIdList, bool needEmit = false)
		{
			foreach (int itemId in itemIdList)
			{
				this.UpdateKurotatoWeaponData(itemId);
			}
			this.SortWeaponDataList();
			this.WeaponGridItemDataList.Clear();
			if (needEmit)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
				EventSystem.Instance.Emit(EEventName.OnRefreshKurotatoWeaponAndPropRedDot);
			}
		}

		// Token: 0x06038F3D RID: 233277 RVA: 0x00D8A050 File Offset: 0x00D88250
		public void UpdateKurotatoWeaponData(int itemId)
		{
			KurotatoWeaponData kurotatoWeaponData = this.GetKurotatoWeaponData(itemId);
			if (kurotatoWeaponData == null)
			{
				return;
			}
			kurotatoWeaponData.IsUnLock = true;
		}

		// Token: 0x06038F3E RID: 233278 RVA: 0x00D8A070 File Offset: 0x00D88270
		[NullableContext(2)]
		public KurotatoWeaponData GetKurotatoWeaponData(int id)
		{
			KurotatoWeaponData result;
			if (!this.WeaponDataMap.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06038F3F RID: 233279 RVA: 0x00D8A090 File Offset: 0x00D88290
		[NullableContext(0)]
		public ValueTuple<int, int> GetWeaponUnlockNum()
		{
			int num = 0;
			using (List<KurotatoWeaponData>.Enumerator enumerator = this.WeaponDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnLock)
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, this.WeaponDataList.Count);
		}

		// Token: 0x06038F40 RID: 233280 RVA: 0x00D8A0FC File Offset: 0x00D882FC
		public bool IsKurotatoWeaponHasRedDot()
		{
			using (Dictionary<int, KurotatoWeaponData>.ValueCollection.Enumerator enumerator = this.WeaponDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HasRedDot)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06038F41 RID: 233281 RVA: 0x00D8A15C File Offset: 0x00D8835C
		public void ReadKurotatoWeaponRedDot()
		{
			if (!this.IsKurotatoWeaponHasRedDot())
			{
				return;
			}
			foreach (KurotatoWeaponData kurotatoWeaponData in this.WeaponDataMap.Values)
			{
				kurotatoWeaponData.ReadRedDot(false);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			EventSystem.Instance.Emit(EEventName.OnRefreshKurotatoWeaponAndPropRedDot);
		}

		// Token: 0x06038F42 RID: 233282 RVA: 0x00D8A1E4 File Offset: 0x00D883E4
		public List<IKurotatoMediumItemGridData> GetKurotatoWeaponList()
		{
			if (this.WeaponGridItemDataList.Count > 0)
			{
				return this.WeaponGridItemDataList;
			}
			foreach (KurotatoWeaponData kurotatoWeaponData in this.WeaponDataList)
			{
				KurotatoMediumItemGridData item = new KurotatoMediumItemGridData
				{
					Id = kurotatoWeaponData.Id,
					Type = EKurotatoCardType.Weapon,
					IncId = 0,
					Count = 0
				};
				this.WeaponGridItemDataList.Add(item);
			}
			return this.WeaponGridItemDataList;
		}

		// Token: 0x06038F43 RID: 233283 RVA: 0x00D8A280 File Offset: 0x00D88480
		private void InitKurotatoNormalRewardData(IList<ConditionTask> taskList)
		{
			this.NormalRewardDataMap.Clear();
			foreach (ConditionTask conditionTask in taskList)
			{
				KurotatoNormalRewardItemData value = new KurotatoNormalRewardItemData(conditionTask.Id, conditionTask.Current, conditionTask.Target, (int)conditionTask.Status);
				this.NormalRewardDataMap[conditionTask.Id] = value;
			}
		}

		// Token: 0x06038F44 RID: 233284 RVA: 0x00D8A2FC File Offset: 0x00D884FC
		private void InitKurotatoLimitRewardData(IList<ConditionTask> taskList)
		{
			this.LimitRewardDataMap.Clear();
			this.TabIdToLimitRewardDataListMap.Clear();
			foreach (ConditionTask conditionTask in taskList)
			{
				KurotatoLimitedTimeRewardItemData kurotatoLimitedTimeRewardItemData = new KurotatoLimitedTimeRewardItemData(conditionTask.Id, conditionTask.Current, conditionTask.Target, (int)conditionTask.Status);
				this.LimitRewardDataMap[conditionTask.Id] = kurotatoLimitedTimeRewardItemData;
				int tabId = kurotatoLimitedTimeRewardItemData.GetTabId();
				if (!this.TabIdToLimitRewardDataListMap.ContainsKey(tabId))
				{
					this.TabIdToLimitRewardDataListMap[tabId] = new List<KurotatoLimitedTimeRewardItemData>();
				}
				this.TabIdToLimitRewardDataListMap[tabId].Add(kurotatoLimitedTimeRewardItemData);
			}
		}

		// Token: 0x06038F45 RID: 233285 RVA: 0x00D8A3BC File Offset: 0x00D885BC
		public void UpdateNormalRewardData(IList<ConditionTask> taskList)
		{
			foreach (ConditionTask conditionTask in taskList)
			{
				KurotatoNormalRewardItemData kurotatoNormalRewardItemData;
				if (this.NormalRewardDataMap.TryGetValue(conditionTask.Id, out kurotatoNormalRewardItemData))
				{
					kurotatoNormalRewardItemData.Refresh(conditionTask);
				}
			}
			EventSystem.Instance.Emit(EEventName.OnRefreshKurotatoNormalRewardData);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06038F46 RID: 233286 RVA: 0x00D8A440 File Offset: 0x00D88640
		public void UpdateLimitTimeRewardData(IList<ConditionTask> taskList)
		{
			foreach (ConditionTask conditionTask in taskList)
			{
				KurotatoLimitedTimeRewardItemData kurotatoLimitedTimeRewardItemData;
				if (this.LimitRewardDataMap.TryGetValue(conditionTask.Id, out kurotatoLimitedTimeRewardItemData))
				{
					kurotatoLimitedTimeRewardItemData.Refresh(conditionTask);
				}
			}
			EventSystem.Instance.Emit(EEventName.OnRefreshKurotatoLimitRewardData);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06038F47 RID: 233287 RVA: 0x00D8A4C4 File Offset: 0x00D886C4
		public void SetNormalRewardReceived(List<int> idList)
		{
			foreach (int key in idList)
			{
				KurotatoNormalRewardItemData kurotatoNormalRewardItemData;
				if (this.NormalRewardDataMap.TryGetValue(key, out kurotatoNormalRewardItemData))
				{
					kurotatoNormalRewardItemData.Status = EKurotatoRewardStatus.Taken;
				}
			}
			EventSystem.Instance.Emit(EEventName.OnRefreshKurotatoNormalRewardData);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06038F48 RID: 233288 RVA: 0x00D8A548 File Offset: 0x00D88748
		public void SetLimitTimeRewardReceived(List<int> idList)
		{
			foreach (int key in idList)
			{
				KurotatoLimitedTimeRewardItemData kurotatoLimitedTimeRewardItemData;
				if (this.LimitRewardDataMap.TryGetValue(key, out kurotatoLimitedTimeRewardItemData))
				{
					kurotatoLimitedTimeRewardItemData.Status = EKurotatoRewardStatus.Taken;
				}
			}
			EventSystem.Instance.Emit(EEventName.OnRefreshKurotatoLimitRewardData);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06038F49 RID: 233289 RVA: 0x00D8A5CC File Offset: 0x00D887CC
		public bool IsNormalRewardViewHasRedDot()
		{
			using (Dictionary<int, KurotatoNormalRewardItemData>.ValueCollection.Enumerator enumerator = this.NormalRewardDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == EKurotatoRewardStatus.CanReceive)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06038F4A RID: 233290 RVA: 0x00D8A62C File Offset: 0x00D8882C
		[NullableContext(2)]
		public KurotatoNormalRewardItemData GetNormalRewardData(int id)
		{
			KurotatoNormalRewardItemData result;
			if (!this.NormalRewardDataMap.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06038F4B RID: 233291 RVA: 0x00D8A64C File Offset: 0x00D8884C
		public List<KurotatoNormalRewardItemData> GetNormalRewardDataList()
		{
			return new List<KurotatoNormalRewardItemData>(this.NormalRewardDataMap.Values);
		}

		// Token: 0x06038F4C RID: 233292 RVA: 0x00D8A660 File Offset: 0x00D88860
		public List<int> GetNormalRewardCanClaimableIdList()
		{
			List<int> list = new List<int>();
			foreach (KurotatoNormalRewardItemData kurotatoNormalRewardItemData in this.NormalRewardDataMap.Values)
			{
				if (kurotatoNormalRewardItemData.Status == EKurotatoRewardStatus.CanReceive)
				{
					list.Add(kurotatoNormalRewardItemData.Id);
				}
			}
			return list;
		}

		// Token: 0x06038F4D RID: 233293 RVA: 0x00D8A6D0 File Offset: 0x00D888D0
		[NullableContext(0)]
		public ValueTuple<int, int> GetNormalRewardProgress()
		{
			int num = 0;
			int count = this.NormalRewardDataMap.Count;
			using (Dictionary<int, KurotatoNormalRewardItemData>.ValueCollection.Enumerator enumerator = this.NormalRewardDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == EKurotatoRewardStatus.Taken)
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, count);
		}

		// Token: 0x06038F4E RID: 233294 RVA: 0x00D8A744 File Offset: 0x00D88944
		public int GetCurrentMilestone()
		{
			if (this.MilestoneItemId == 0)
			{
				KurotatoActivityConfig? activityConfig = KurotatoModel.Instance.GetActivityConfig();
				this.MilestoneItemId = ((activityConfig != null) ? activityConfig.GetValueOrDefault().ScoreItem : 0);
			}
			return InventoryModel.Instance.GetItemCountByConfigId(this.MilestoneItemId, 0);
		}

		// Token: 0x06038F4F RID: 233295 RVA: 0x00D8A798 File Offset: 0x00D88998
		private void InitScoreRewardReceivedData(IList<int> scoreTaskList)
		{
			this.ScoreRewardReceivedIdSet.Clear();
			if (scoreTaskList == null)
			{
				return;
			}
			foreach (int item in scoreTaskList)
			{
				this.ScoreRewardReceivedIdSet.Add(item);
			}
		}

		// Token: 0x06038F50 RID: 233296 RVA: 0x00D8A7F8 File Offset: 0x00D889F8
		public void SetScoreRewardReceived(List<int> idList)
		{
			foreach (int item in idList)
			{
				this.ScoreRewardReceivedIdSet.Add(item);
			}
			EventSystem.Instance.Emit(EEventName.OnRefreshKurotatoLimitRewardData);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06038F51 RID: 233297 RVA: 0x00D8A874 File Offset: 0x00D88A74
		public bool IsScoreRewardCanReceived(int id)
		{
			KurotatoScoreAward? kurotatoScoreAwardConfigById = KurotatoConfig.Instance.GetKurotatoScoreAwardConfigById(id);
			return kurotatoScoreAwardConfigById != null && this.GetCurrentMilestone() >= kurotatoScoreAwardConfigById.Value.Score && !this.IsScoreRewardReceived(id);
		}

		// Token: 0x06038F52 RID: 233298 RVA: 0x00D8A8BB File Offset: 0x00D88ABB
		public bool IsScoreRewardReceived(int id)
		{
			return this.ScoreRewardReceivedIdSet.Contains(id);
		}

		// Token: 0x06038F53 RID: 233299 RVA: 0x00D8A8CC File Offset: 0x00D88ACC
		public int GetLastNotTakenScoreRewardIndex()
		{
			IReadOnlyList<KurotatoScoreAward> allKurotatoScoreAwardConfig = KurotatoConfig.Instance.GetAllKurotatoScoreAwardConfig();
			for (int i = allKurotatoScoreAwardConfig.Count - 1; i >= 0; i--)
			{
				if (this.IsScoreRewardCanReceived(allKurotatoScoreAwardConfig[i].Id))
				{
					return i + 1;
				}
			}
			return 0;
		}

		// Token: 0x06038F54 RID: 233300 RVA: 0x00D8A914 File Offset: 0x00D88B14
		public List<int> GetCanClaimedScoreRewardList()
		{
			List<int> list = new List<int>();
			foreach (KurotatoScoreAward kurotatoScoreAward in KurotatoConfig.Instance.GetAllKurotatoScoreAwardConfig())
			{
				if (this.IsScoreRewardCanReceived(kurotatoScoreAward.Id))
				{
					list.Add(kurotatoScoreAward.Id);
				}
			}
			return list;
		}

		// Token: 0x06038F55 RID: 233301 RVA: 0x00D8A984 File Offset: 0x00D88B84
		public bool IsScoreRewardHasRedDot()
		{
			foreach (KurotatoScoreAward kurotatoScoreAward in KurotatoConfig.Instance.GetAllKurotatoScoreAwardConfig())
			{
				if (this.IsScoreRewardCanReceived(kurotatoScoreAward.Id))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06038F56 RID: 233302 RVA: 0x00D8A9E4 File Offset: 0x00D88BE4
		public bool IsLimitTimeRewardViewHasRedDot()
		{
			using (Dictionary<int, KurotatoLimitedTimeRewardItemData>.ValueCollection.Enumerator enumerator = this.LimitRewardDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == EKurotatoRewardStatus.CanReceive)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06038F57 RID: 233303 RVA: 0x00D8AA44 File Offset: 0x00D88C44
		public List<KurotatoLimitedTimeRewardItemData> GetLimitedTimeTaskListByTabId(int tabId)
		{
			List<KurotatoLimitedTimeRewardItemData> collection;
			if (!this.TabIdToLimitRewardDataListMap.TryGetValue(tabId, out collection))
			{
				return new List<KurotatoLimitedTimeRewardItemData>();
			}
			return new List<KurotatoLimitedTimeRewardItemData>(collection);
		}

		// Token: 0x06038F58 RID: 233304 RVA: 0x00D8AA70 File Offset: 0x00D88C70
		public List<int> GetLimitedTimeTaskCanClaimableIdListByTabId(int tabId)
		{
			List<KurotatoLimitedTimeRewardItemData> list;
			if (!this.TabIdToLimitRewardDataListMap.TryGetValue(tabId, out list))
			{
				return new List<int>();
			}
			List<int> list2 = new List<int>();
			foreach (KurotatoLimitedTimeRewardItemData kurotatoLimitedTimeRewardItemData in list)
			{
				if (kurotatoLimitedTimeRewardItemData.Status == EKurotatoRewardStatus.CanReceive)
				{
					list2.Add(kurotatoLimitedTimeRewardItemData.Id);
				}
			}
			return list2;
		}

		// Token: 0x06038F59 RID: 233305 RVA: 0x00D8AAEC File Offset: 0x00D88CEC
		public bool IsLimitedTimeTaskTabHasAnyClaimable(int tabId)
		{
			List<KurotatoLimitedTimeRewardItemData> list;
			if (!this.TabIdToLimitRewardDataListMap.TryGetValue(tabId, out list) || list.Count <= 0)
			{
				return false;
			}
			using (List<KurotatoLimitedTimeRewardItemData>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == EKurotatoRewardStatus.CanReceive)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06038F5A RID: 233306 RVA: 0x00D8AB5C File Offset: 0x00D88D5C
		[NullableContext(2)]
		public KurotatoLimitedTimeRewardItemData GetLimitedTimeTaskRewardTaskData(int id)
		{
			KurotatoLimitedTimeRewardItemData result;
			if (!this.LimitRewardDataMap.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06038F5B RID: 233307 RVA: 0x00D8AB7C File Offset: 0x00D88D7C
		[NullableContext(0)]
		public ValueTuple<int, int> GetLimitedTimeRewardProgress()
		{
			int num = 0;
			int count = this.LimitRewardDataMap.Count;
			using (Dictionary<int, KurotatoLimitedTimeRewardItemData>.ValueCollection.Enumerator enumerator = this.LimitRewardDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == EKurotatoRewardStatus.Taken)
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, count);
		}

		// Token: 0x06038F5C RID: 233308 RVA: 0x00D8ABF0 File Offset: 0x00D88DF0
		[NullableContext(0)]
		public ValueTuple<int, int> GetLimitedTimeTabRewardProgress(int tabId)
		{
			List<KurotatoLimitedTimeRewardItemData> list;
			if (!this.TabIdToLimitRewardDataListMap.TryGetValue(tabId, out list))
			{
				return new ValueTuple<int, int>(0, 0);
			}
			int num = 0;
			int count = list.Count;
			using (List<KurotatoLimitedTimeRewardItemData>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == EKurotatoRewardStatus.Taken)
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, count);
		}

		// Token: 0x0401DD88 RID: 122248
		private int KurotatoConfigIdInternal;

		// Token: 0x0401DD89 RID: 122249
		private readonly Dictionary<int, KurotatoLevelData> LevelMap = new Dictionary<int, KurotatoLevelData>();

		// Token: 0x0401DD8A RID: 122250
		private readonly Dictionary<int, List<KurotatoLevelData>> LevelGroupMap = new Dictionary<int, List<KurotatoLevelData>>();

		// Token: 0x0401DD8B RID: 122251
		private readonly Dictionary<int, KurotatoRoleData> RoleMap = new Dictionary<int, KurotatoRoleData>();

		// Token: 0x0401DD8C RID: 122252
		private readonly List<KurotatoRoleData> RoleList = new List<KurotatoRoleData>();

		// Token: 0x0401DD8D RID: 122253
		private readonly Dictionary<int, KurotatoItemData> ItemDataMap = new Dictionary<int, KurotatoItemData>();

		// Token: 0x0401DD8E RID: 122254
		private readonly List<KurotatoItemData> ItemDataList = new List<KurotatoItemData>();

		// Token: 0x0401DD8F RID: 122255
		private readonly List<IKurotatoMediumItemGridData> ItemGridItemDataList = new List<IKurotatoMediumItemGridData>();

		// Token: 0x0401DD90 RID: 122256
		private readonly Dictionary<int, KurotatoWeaponData> WeaponDataMap = new Dictionary<int, KurotatoWeaponData>();

		// Token: 0x0401DD91 RID: 122257
		private readonly List<KurotatoWeaponData> WeaponDataList = new List<KurotatoWeaponData>();

		// Token: 0x0401DD92 RID: 122258
		private readonly List<IKurotatoMediumItemGridData> WeaponGridItemDataList = new List<IKurotatoMediumItemGridData>();

		// Token: 0x0401DD93 RID: 122259
		private readonly Dictionary<int, KurotatoNormalRewardItemData> NormalRewardDataMap = new Dictionary<int, KurotatoNormalRewardItemData>();

		// Token: 0x0401DD94 RID: 122260
		private readonly Dictionary<int, KurotatoLimitedTimeRewardItemData> LimitRewardDataMap = new Dictionary<int, KurotatoLimitedTimeRewardItemData>();

		// Token: 0x0401DD95 RID: 122261
		private readonly Dictionary<int, List<KurotatoLimitedTimeRewardItemData>> TabIdToLimitRewardDataListMap = new Dictionary<int, List<KurotatoLimitedTimeRewardItemData>>();

		// Token: 0x0401DD96 RID: 122262
		private int MilestoneItemId;

		// Token: 0x0401DD97 RID: 122263
		private readonly HashSet<int> ScoreRewardReceivedIdSet = new HashSet<int>();
	}
}
