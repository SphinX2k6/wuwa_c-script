using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x0200476B RID: 18283
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoActivityData : ActivityBaseData
	{
		// Token: 0x17005C42 RID: 23618
		// (get) Token: 0x0602DE24 RID: 187940 RVA: 0x00CD7BDC File Offset: 0x00CD5DDC
		public int KurotatoConfigId
		{
			get
			{
				return this.KurotatoConfigIdInternal;
			}
		}

		// Token: 0x0602DE25 RID: 187941 RVA: 0x00CD7BE4 File Offset: 0x00CD5DE4
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

		// Token: 0x0602DE26 RID: 187942 RVA: 0x00CD7C64 File Offset: 0x00CD5E64
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

		// Token: 0x0602DE27 RID: 187943 RVA: 0x00CD7CF4 File Offset: 0x00CD5EF4
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

		// Token: 0x0602DE28 RID: 187944 RVA: 0x00CD7D25 File Offset: 0x00CD5F25
		public override bool GetExDataRedPointShowState()
		{
			return this.IsActHaveRedDot();
		}

		// Token: 0x0602DE29 RID: 187945 RVA: 0x00CD7D30 File Offset: 0x00CD5F30
		public bool IsActHaveRedDot()
		{
			return this.IsNormalRewardViewHasRedDot() || this.IsLimitTimeRewardViewHasRedDot() || this.IsRoleHasRedDot() || this.IsKurotatoItemHasRedDot() || this.IsKurotatoWeaponHasRedDot() || this.IsStageEntranceRedDot(EKurotatoLevelMode.Teach) || this.IsStageEntranceRedDot(EKurotatoLevelMode.Endless) || this.IsScoreRewardHasRedDot();
		}

		// Token: 0x0602DE2A RID: 187946 RVA: 0x00CD7D80 File Offset: 0x00CD5F80
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

		// Token: 0x0602DE2B RID: 187947 RVA: 0x00CD7E88 File Offset: 0x00CD6088
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

		// Token: 0x0602DE2C RID: 187948 RVA: 0x00CD7ED8 File Offset: 0x00CD60D8
		public bool IsLevelUnLock(int id)
		{
			KurotatoLevelData kurotatoLevelData = this.GetKurotatoLevelData(id);
			return kurotatoLevelData != null && kurotatoLevelData.IsUnLock;
		}

		// Token: 0x0602DE2D RID: 187949 RVA: 0x00CD7EF8 File Offset: 0x00CD60F8
		public bool IsLevelFinished(int id)
		{
			KurotatoLevelData kurotatoLevelData = this.GetKurotatoLevelData(id);
			return kurotatoLevelData != null && kurotatoLevelData.IsFinished;
		}

		// Token: 0x0602DE2E RID: 187950 RVA: 0x00CD7F18 File Offset: 0x00CD6118
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

		// Token: 0x0602DE2F RID: 187951 RVA: 0x00CD802C File Offset: 0x00CD622C
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

		// Token: 0x0602DE30 RID: 187952 RVA: 0x00CD809C File Offset: 0x00CD629C
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

		// Token: 0x0602DE31 RID: 187953 RVA: 0x00CD8144 File Offset: 0x00CD6344
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

		// Token: 0x0602DE32 RID: 187954 RVA: 0x00CD81FC File Offset: 0x00CD63FC
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

		// Token: 0x0602DE33 RID: 187955 RVA: 0x00CD824C File Offset: 0x00CD644C
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

		// Token: 0x0602DE34 RID: 187956 RVA: 0x00CD82BC File Offset: 0x00CD64BC
		public int GetCurrentEndlessModeWave()
		{
			List<KurotatoLevelData> list;
			if (!this.LevelGroupMap.TryGetValue(3, out list) || list.Count == 0)
			{
				return 0;
			}
			return list[0].HistoryWave;
		}

		// Token: 0x0602DE35 RID: 187957 RVA: 0x00CD82F0 File Offset: 0x00CD64F0
		public long GetEndlessLevelUnlockTime()
		{
			List<KurotatoLevelData> list;
			if (!this.LevelGroupMap.TryGetValue(3, out list) || list.Count == 0)
			{
				return 0L;
			}
			return list[0].UnlockTime;
		}

		// Token: 0x0602DE36 RID: 187958 RVA: 0x00CD8324 File Offset: 0x00CD6524
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

		// Token: 0x0602DE37 RID: 187959 RVA: 0x00CD8398 File Offset: 0x00CD6598
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

		// Token: 0x0602DE38 RID: 187960 RVA: 0x00CD8410 File Offset: 0x00CD6610
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

		// Token: 0x0602DE39 RID: 187961 RVA: 0x00CD84D4 File Offset: 0x00CD66D4
		private bool CheckRoleIsValid(EKurotatoRoleType type, EPlayerGender gender)
		{
			return type == EKurotatoRoleType.Normal || (type == EKurotatoRoleType.MainRoleMale && gender == EPlayerGender.Male) || (type == EKurotatoRoleType.MainRoleFemale && gender == EPlayerGender.Female);
		}

		// Token: 0x0602DE3A RID: 187962 RVA: 0x00CD84EC File Offset: 0x00CD66EC
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

		// Token: 0x0602DE3B RID: 187963 RVA: 0x00CD853C File Offset: 0x00CD673C
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

		// Token: 0x0602DE3C RID: 187964 RVA: 0x00CD85F8 File Offset: 0x00CD67F8
		public List<KurotatoRoleData> GetKurotatoRoleList()
		{
			return this.RoleList;
		}

		// Token: 0x0602DE3D RID: 187965 RVA: 0x00CD8600 File Offset: 0x00CD6800
		public List<int> GetKurotatoRoleListInLevel(List<int> limitRoleList, List<int> recommendRoleList)
		{
			List<int> list = new List<int>(this.RoleList.Count);
			foreach (KurotatoRoleData kurotatoRoleData in this.RoleList)
			{
				list.Add(kurotatoRoleData.Id);
			}
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
						KurotatoRoleData kurotatoRoleData2 = this.GetKurotatoRoleData(a);
						KurotatoRoleData kurotatoRoleData3 = this.GetKurotatoRoleData(b);
						if (kurotatoRoleData2.HasRoleSelectRedDot != kurotatoRoleData3.HasRoleSelectRedDot)
						{
							if (!kurotatoRoleData2.HasRoleSelectRedDot)
							{
								return 1;
							}
							return -1;
						}
						else
						{
							if (kurotatoRoleData2.IsUnLock == kurotatoRoleData3.IsUnLock)
							{
								return kurotatoRoleData2.SortId - kurotatoRoleData3.SortId;
							}
							if (!kurotatoRoleData2.IsUnLock)
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

		// Token: 0x0602DE3E RID: 187966 RVA: 0x00CD8698 File Offset: 0x00CD6898
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

		// Token: 0x0602DE3F RID: 187967 RVA: 0x00CD86F8 File Offset: 0x00CD68F8
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

		// Token: 0x0602DE40 RID: 187968 RVA: 0x00CD8788 File Offset: 0x00CD6988
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

		// Token: 0x0602DE41 RID: 187969 RVA: 0x00CD87F4 File Offset: 0x00CD69F4
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

		// Token: 0x0602DE42 RID: 187970 RVA: 0x00CD8918 File Offset: 0x00CD6B18
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

		// Token: 0x0602DE43 RID: 187971 RVA: 0x00CD899C File Offset: 0x00CD6B9C
		public void UpdateKurotatoItemData(int itemId)
		{
			KurotatoItemData kurotatoItemData = this.GetKurotatoItemData(itemId);
			if (kurotatoItemData == null)
			{
				return;
			}
			kurotatoItemData.IsUnLock = true;
		}

		// Token: 0x0602DE44 RID: 187972 RVA: 0x00CD89BC File Offset: 0x00CD6BBC
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

		// Token: 0x0602DE45 RID: 187973 RVA: 0x00CD89E8 File Offset: 0x00CD6BE8
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

		// Token: 0x0602DE46 RID: 187974 RVA: 0x00CD8A08 File Offset: 0x00CD6C08
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

		// Token: 0x0602DE47 RID: 187975 RVA: 0x00CD8A74 File Offset: 0x00CD6C74
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

		// Token: 0x0602DE48 RID: 187976 RVA: 0x00CD8AD4 File Offset: 0x00CD6CD4
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

		// Token: 0x0602DE49 RID: 187977 RVA: 0x00CD8B5C File Offset: 0x00CD6D5C
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

		// Token: 0x0602DE4A RID: 187978 RVA: 0x00CD8BF8 File Offset: 0x00CD6DF8
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

		// Token: 0x0602DE4B RID: 187979 RVA: 0x00CD8D1C File Offset: 0x00CD6F1C
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

		// Token: 0x0602DE4C RID: 187980 RVA: 0x00CD8D48 File Offset: 0x00CD6F48
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

		// Token: 0x0602DE4D RID: 187981 RVA: 0x00CD8DCC File Offset: 0x00CD6FCC
		public void UpdateKurotatoWeaponData(int itemId)
		{
			KurotatoWeaponData kurotatoWeaponData = this.GetKurotatoWeaponData(itemId);
			if (kurotatoWeaponData == null)
			{
				return;
			}
			kurotatoWeaponData.IsUnLock = true;
		}

		// Token: 0x0602DE4E RID: 187982 RVA: 0x00CD8DEC File Offset: 0x00CD6FEC
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

		// Token: 0x0602DE4F RID: 187983 RVA: 0x00CD8E0C File Offset: 0x00CD700C
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

		// Token: 0x0602DE50 RID: 187984 RVA: 0x00CD8E78 File Offset: 0x00CD7078
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

		// Token: 0x0602DE51 RID: 187985 RVA: 0x00CD8ED8 File Offset: 0x00CD70D8
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

		// Token: 0x0602DE52 RID: 187986 RVA: 0x00CD8F60 File Offset: 0x00CD7160
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

		// Token: 0x0602DE53 RID: 187987 RVA: 0x00CD8FFC File Offset: 0x00CD71FC
		private void InitKurotatoNormalRewardData(IList<ConditionTask> taskList)
		{
			this.NormalRewardDataMap.Clear();
			foreach (ConditionTask conditionTask in taskList)
			{
				KurotatoNormalRewardItemData value = new KurotatoNormalRewardItemData(conditionTask.Id, conditionTask.Current, conditionTask.Target, (int)conditionTask.Status);
				this.NormalRewardDataMap[conditionTask.Id] = value;
			}
		}

		// Token: 0x0602DE54 RID: 187988 RVA: 0x00CD9078 File Offset: 0x00CD7278
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

		// Token: 0x0602DE55 RID: 187989 RVA: 0x00CD9138 File Offset: 0x00CD7338
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

		// Token: 0x0602DE56 RID: 187990 RVA: 0x00CD91BC File Offset: 0x00CD73BC
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

		// Token: 0x0602DE57 RID: 187991 RVA: 0x00CD9240 File Offset: 0x00CD7440
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

		// Token: 0x0602DE58 RID: 187992 RVA: 0x00CD92C4 File Offset: 0x00CD74C4
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

		// Token: 0x0602DE59 RID: 187993 RVA: 0x00CD9348 File Offset: 0x00CD7548
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

		// Token: 0x0602DE5A RID: 187994 RVA: 0x00CD93A8 File Offset: 0x00CD75A8
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

		// Token: 0x0602DE5B RID: 187995 RVA: 0x00CD93C8 File Offset: 0x00CD75C8
		public List<KurotatoNormalRewardItemData> GetNormalRewardDataList()
		{
			return new List<KurotatoNormalRewardItemData>(this.NormalRewardDataMap.Values);
		}

		// Token: 0x0602DE5C RID: 187996 RVA: 0x00CD93DC File Offset: 0x00CD75DC
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

		// Token: 0x0602DE5D RID: 187997 RVA: 0x00CD944C File Offset: 0x00CD764C
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

		// Token: 0x0602DE5E RID: 187998 RVA: 0x00CD94C0 File Offset: 0x00CD76C0
		public int GetCurrentMilestone()
		{
			if (this.MilestoneItemId == 0)
			{
				KurotatoActivityConfig? activityConfig = KurotatoModel.Instance.GetActivityConfig();
				this.MilestoneItemId = ((activityConfig != null) ? activityConfig.GetValueOrDefault().ScoreItem : 0);
			}
			return InventoryModel.Instance.GetItemCountByConfigId(this.MilestoneItemId, 0);
		}

		// Token: 0x0602DE5F RID: 187999 RVA: 0x00CD9514 File Offset: 0x00CD7714
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

		// Token: 0x0602DE60 RID: 188000 RVA: 0x00CD9574 File Offset: 0x00CD7774
		public void SetScoreRewardReceived(List<int> idList)
		{
			foreach (int item in idList)
			{
				this.ScoreRewardReceivedIdSet.Add(item);
			}
			EventSystem.Instance.Emit(EEventName.OnRefreshKurotatoLimitRewardData);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0602DE61 RID: 188001 RVA: 0x00CD95F0 File Offset: 0x00CD77F0
		public bool IsScoreRewardCanReceived(int id)
		{
			KurotatoScoreAward? kurotatoScoreAwardConfigById = KurotatoConfig.Instance.GetKurotatoScoreAwardConfigById(id);
			return kurotatoScoreAwardConfigById != null && this.GetCurrentMilestone() >= kurotatoScoreAwardConfigById.Value.Score && !this.IsScoreRewardReceived(id);
		}

		// Token: 0x0602DE62 RID: 188002 RVA: 0x00CD9637 File Offset: 0x00CD7837
		public bool IsScoreRewardReceived(int id)
		{
			return this.ScoreRewardReceivedIdSet.Contains(id);
		}

		// Token: 0x0602DE63 RID: 188003 RVA: 0x00CD9648 File Offset: 0x00CD7848
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

		// Token: 0x0602DE64 RID: 188004 RVA: 0x00CD9690 File Offset: 0x00CD7890
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

		// Token: 0x0602DE65 RID: 188005 RVA: 0x00CD9700 File Offset: 0x00CD7900
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

		// Token: 0x0602DE66 RID: 188006 RVA: 0x00CD9760 File Offset: 0x00CD7960
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

		// Token: 0x0602DE67 RID: 188007 RVA: 0x00CD97C0 File Offset: 0x00CD79C0
		public List<KurotatoLimitedTimeRewardItemData> GetLimitedTimeTaskListByTabId(int tabId)
		{
			List<KurotatoLimitedTimeRewardItemData> collection;
			if (!this.TabIdToLimitRewardDataListMap.TryGetValue(tabId, out collection))
			{
				return new List<KurotatoLimitedTimeRewardItemData>();
			}
			return new List<KurotatoLimitedTimeRewardItemData>(collection);
		}

		// Token: 0x0602DE68 RID: 188008 RVA: 0x00CD97EC File Offset: 0x00CD79EC
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

		// Token: 0x0602DE69 RID: 188009 RVA: 0x00CD9868 File Offset: 0x00CD7A68
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

		// Token: 0x0602DE6A RID: 188010 RVA: 0x00CD98D8 File Offset: 0x00CD7AD8
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

		// Token: 0x0602DE6B RID: 188011 RVA: 0x00CD98F8 File Offset: 0x00CD7AF8
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

		// Token: 0x0602DE6C RID: 188012 RVA: 0x00CD996C File Offset: 0x00CD7B6C
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

		// Token: 0x0401881E RID: 100382
		private int KurotatoConfigIdInternal;

		// Token: 0x0401881F RID: 100383
		private readonly Dictionary<int, KurotatoLevelData> LevelMap = new Dictionary<int, KurotatoLevelData>();

		// Token: 0x04018820 RID: 100384
		private readonly Dictionary<int, List<KurotatoLevelData>> LevelGroupMap = new Dictionary<int, List<KurotatoLevelData>>();

		// Token: 0x04018821 RID: 100385
		private readonly Dictionary<int, KurotatoRoleData> RoleMap = new Dictionary<int, KurotatoRoleData>();

		// Token: 0x04018822 RID: 100386
		private readonly List<KurotatoRoleData> RoleList = new List<KurotatoRoleData>();

		// Token: 0x04018823 RID: 100387
		private readonly Dictionary<int, KurotatoItemData> ItemDataMap = new Dictionary<int, KurotatoItemData>();

		// Token: 0x04018824 RID: 100388
		private readonly List<KurotatoItemData> ItemDataList = new List<KurotatoItemData>();

		// Token: 0x04018825 RID: 100389
		private readonly List<IKurotatoMediumItemGridData> ItemGridItemDataList = new List<IKurotatoMediumItemGridData>();

		// Token: 0x04018826 RID: 100390
		private readonly Dictionary<int, KurotatoWeaponData> WeaponDataMap = new Dictionary<int, KurotatoWeaponData>();

		// Token: 0x04018827 RID: 100391
		private readonly List<KurotatoWeaponData> WeaponDataList = new List<KurotatoWeaponData>();

		// Token: 0x04018828 RID: 100392
		private readonly List<IKurotatoMediumItemGridData> WeaponGridItemDataList = new List<IKurotatoMediumItemGridData>();

		// Token: 0x04018829 RID: 100393
		private readonly Dictionary<int, KurotatoNormalRewardItemData> NormalRewardDataMap = new Dictionary<int, KurotatoNormalRewardItemData>();

		// Token: 0x0401882A RID: 100394
		private readonly Dictionary<int, KurotatoLimitedTimeRewardItemData> LimitRewardDataMap = new Dictionary<int, KurotatoLimitedTimeRewardItemData>();

		// Token: 0x0401882B RID: 100395
		private readonly Dictionary<int, List<KurotatoLimitedTimeRewardItemData>> TabIdToLimitRewardDataListMap = new Dictionary<int, List<KurotatoLimitedTimeRewardItemData>>();

		// Token: 0x0401882C RID: 100396
		private int MilestoneItemId;

		// Token: 0x0401882D RID: 100397
		private readonly HashSet<int> ScoreRewardReceivedIdSet = new HashSet<int>();
	}
}
