using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball
{
	// Token: 0x020062C6 RID: 25286
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballActivityData : ActivityBaseData
	{
		// Token: 0x0603F979 RID: 260473 RVA: 0x00F61B98 File Offset: 0x00F5FD98
		protected override void PhraseEx(ActivityData data)
		{
			PinballModel.Instance.SetActivityId(base.Id);
			PinballActivityData pinballActivityData = data.PinballActivityData;
			if (pinballActivityData == null)
			{
				return;
			}
			foreach (Aki.Protocol.PinballChapterData data2 in pinballActivityData.Chapters)
			{
				this.UpdateChapterData(data2);
			}
			foreach (PinballLevelData data3 in pinballActivityData.Levels)
			{
				this.UpdateLevelData(data3);
			}
			this.CheckChapterUnlocked();
			PinballRoles roles = pinballActivityData.Roles;
			if (roles != null && roles.Roles.Count > 0)
			{
				foreach (Aki.Protocol.PinballRoleData data4 in roles.Roles)
				{
					this.UpdateRoleByServerData(data4);
				}
			}
			PinballWeapons weapons = pinballActivityData.Weapons;
			if (weapons != null && weapons.PinballWeaponList.Count > 0)
			{
				foreach (PinballWeapon data5 in weapons.PinballWeaponList)
				{
					this.UpdateWeaponData(data5);
				}
			}
			if (pinballActivityData.ConditionTasks.Count > 0)
			{
				List<ConditionTask> list = new List<ConditionTask>();
				foreach (ConditionTask item in pinballActivityData.ConditionTasks)
				{
					list.Add(item);
				}
				this.InitTaskData(list);
			}
			PinballActivity? config = ConfigPinballActivityByActivityId.GetConfig(base.Id, true);
			this.ShopId = ((config != null) ? config.GetValueOrDefault().ShopId : 5);
			if (pinballActivityData.GroupFormations.Count > 0)
			{
				List<GroupFormation> list2 = new List<GroupFormation>();
				foreach (GroupFormation item2 in pinballActivityData.GroupFormations)
				{
					list2.Add(item2);
				}
				this.InitLevelFormationData(list2);
			}
			this.UpdateRoleWeaponRedDot();
		}

		// Token: 0x0603F97A RID: 260474 RVA: 0x00F61E00 File Offset: 0x00F60000
		private global::PinballRoleData AddRoleData(int configId)
		{
			global::PinballRoleData pinballRoleData = new global::PinballRoleData(configId);
			this.RoleDataMap[configId] = pinballRoleData;
			EventSystem.Instance.Emit<int>(EEventName.RefreshPinballRoleRedDot, configId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			return pinballRoleData;
		}

		// Token: 0x0603F97B RID: 260475 RVA: 0x00F61E4C File Offset: 0x00F6004C
		public void UpdateRoleByServerData(Aki.Protocol.PinballRoleData data)
		{
			int configId = data.ConfigId;
			PinballRoleDataBase pinballRoleDataBase;
			this.RoleDataMap.TryGetValue(configId, out pinballRoleDataBase);
			if (pinballRoleDataBase == null)
			{
				pinballRoleDataBase = this.AddRoleData(configId);
			}
			pinballRoleDataBase.SetLevel(data.RoleLevel);
		}

		// Token: 0x0603F97C RID: 260476 RVA: 0x00F61E88 File Offset: 0x00F60088
		[NullableContext(2)]
		public global::PinballRoleData GetRoleData(int configId)
		{
			PinballRoleDataBase pinballRoleDataBase;
			if (this.RoleDataMap.TryGetValue(configId, out pinballRoleDataBase))
			{
				return pinballRoleDataBase as global::PinballRoleData;
			}
			return null;
		}

		// Token: 0x0603F97D RID: 260477 RVA: 0x00F61EB0 File Offset: 0x00F600B0
		public List<int> GetUnlockRoleList()
		{
			List<int> list = new List<int>();
			foreach (int item in this.RoleDataMap.Keys)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0603F97E RID: 260478 RVA: 0x00F61F10 File Offset: 0x00F60110
		public PinballWeaponData UpdateWeaponData(PinballWeapon data)
		{
			PinballWeaponData pinballWeaponData;
			this.WeaponDataMap.TryGetValue(data.IncrId, out pinballWeaponData);
			if (pinballWeaponData == null)
			{
				pinballWeaponData = new PinballWeaponData();
			}
			pinballWeaponData.Phrase(data);
			int roleId = pinballWeaponData.RoleId;
			if (roleId > 0)
			{
				global::PinballRoleData roleData = this.GetRoleData(roleId);
				if (roleData != null)
				{
					roleData.SetWeaponData(pinballWeaponData);
				}
			}
			this.WeaponDataMap[data.IncrId] = pinballWeaponData;
			return pinballWeaponData;
		}

		// Token: 0x0603F97F RID: 260479 RVA: 0x00F61F74 File Offset: 0x00F60174
		public void RemoveWeaponData(List<int> incIdList)
		{
			foreach (int key in incIdList)
			{
				this.WeaponDataMap.Remove(key);
			}
		}

		// Token: 0x0603F980 RID: 260480 RVA: 0x00F61FC8 File Offset: 0x00F601C8
		[NullableContext(2)]
		public PinballWeaponData GetWeaponDataByIncId(int incId)
		{
			PinballWeaponData result;
			this.WeaponDataMap.TryGetValue(incId, out result);
			return result;
		}

		// Token: 0x0603F981 RID: 260481 RVA: 0x00F61FE8 File Offset: 0x00F601E8
		public List<PinballWeaponData> GetWeaponDataAll()
		{
			List<PinballWeaponData> list = new List<PinballWeaponData>();
			foreach (PinballWeaponData item in this.WeaponDataMap.Values)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0603F982 RID: 260482 RVA: 0x00F62048 File Offset: 0x00F60248
		public int GetWeaponCountByConfigId(int configId)
		{
			int num = 0;
			using (Dictionary<int, PinballWeaponData>.ValueCollection.Enumerator enumerator = this.WeaponDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Id == configId)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x0603F983 RID: 260483 RVA: 0x00F620A8 File Offset: 0x00F602A8
		public void AddAllGmUnlockChapterId()
		{
			foreach (int chapterId in this.ChapterMap.Keys)
			{
				this.AddGmUnlockChapterId(chapterId);
			}
		}

		// Token: 0x0603F984 RID: 260484 RVA: 0x00F62100 File Offset: 0x00F60300
		public void AddGmUnlockChapterId(int chapterId)
		{
			if (this.GmUnlockChapterIdList.Contains(chapterId))
			{
				return;
			}
			this.GmUnlockChapterIdList.Add(chapterId);
		}

		// Token: 0x0603F985 RID: 260485 RVA: 0x00F62120 File Offset: 0x00F60320
		public void RemoveGmUnlockChapterId(int chapterId)
		{
			List<int> list = new List<int>();
			foreach (int num in this.GmUnlockChapterIdList)
			{
				if (num != chapterId)
				{
					list.Add(num);
				}
			}
			this.GmUnlockChapterIdList = list;
		}

		// Token: 0x0603F986 RID: 260486 RVA: 0x00F62184 File Offset: 0x00F60384
		public void RemoveAllGmUnlockChapterId()
		{
			this.GmUnlockChapterIdList = new List<int>();
		}

		// Token: 0x0603F987 RID: 260487 RVA: 0x00F62191 File Offset: 0x00F60391
		public bool IsGmUnlockChapter(int chapterId)
		{
			return this.GmUnlockChapterIdList.Contains(chapterId);
		}

		// Token: 0x0603F988 RID: 260488 RVA: 0x00F621A0 File Offset: 0x00F603A0
		public void SetGmPassedChapter(int chapterId, bool isPassed)
		{
			global::PinballChapterData pinballChapterData;
			this.ChapterMap.TryGetValue(chapterId, out pinballChapterData);
			if (pinballChapterData == null)
			{
				return;
			}
			foreach (int levelId in pinballChapterData.LevelIds)
			{
				PinballLevelRecordData levelData = this.GetLevelData(levelId);
				if (levelData != null)
				{
					levelData.PassStatus = (isPassed ? EPinballLevelPassStatus.Finished : EPinballLevelPassStatus.Unfinished);
				}
			}
		}

		// Token: 0x0603F989 RID: 260489 RVA: 0x00F621F4 File Offset: 0x00F603F4
		public void UpdateChapterData(Aki.Protocol.PinballChapterData data)
		{
			global::PinballChapterData pinballChapterData;
			this.ChapterMap.TryGetValue(data.ChapterId, out pinballChapterData);
			if (pinballChapterData == null)
			{
				pinballChapterData = new global::PinballChapterData();
				pinballChapterData.ChapterId = data.ChapterId;
			}
			long num = MathUtils.Instance.LongToNumber(data.UnLockTime);
			PinballChapterConfig? pinballChapterConfigById = PinballConfig.Instance.GetPinballChapterConfigById(data.ChapterId);
			int preChapterId = pinballChapterConfigById.Value.PreChapterId;
			int[] array = new int[pinballChapterConfigById.Value.LevelListLength];
			for (int i = 0; i < pinballChapterConfigById.Value.LevelListLength; i++)
			{
				array[i] = pinballChapterConfigById.Value.LevelList(i);
			}
			pinballChapterData.UnlockTime = (int)num;
			pinballChapterData.LevelIds = array;
			pinballChapterData.PreChapterId = preChapterId;
			this.ChapterMap[data.ChapterId] = pinballChapterData;
		}

		// Token: 0x0603F98A RID: 260490 RVA: 0x00F622D4 File Offset: 0x00F604D4
		public List<global::PinballChapterData> GetMainChapterList()
		{
			List<global::PinballChapterData> list = new List<global::PinballChapterData>();
			foreach (global::PinballChapterData pinballChapterData in this.ChapterMap.Values)
			{
				int levelId = pinballChapterData.LevelIds[0];
				PinballLevelRecordData levelData = this.GetLevelData(levelId);
				if (levelData != null && levelData.LevelShowType == EPinballLevelShowType.Normal)
				{
					list.Add(pinballChapterData);
				}
			}
			return list;
		}

		// Token: 0x0603F98B RID: 260491 RVA: 0x00F62354 File Offset: 0x00F60554
		[NullableContext(2)]
		public global::PinballChapterData GetTowerChapterData()
		{
			foreach (global::PinballChapterData pinballChapterData in this.ChapterMap.Values)
			{
				int levelId = pinballChapterData.LevelIds[0];
				PinballLevelRecordData levelData = this.GetLevelData(levelId);
				if (levelData != null && levelData.LevelShowType == EPinballLevelShowType.Tower)
				{
					return pinballChapterData;
				}
			}
			return null;
		}

		// Token: 0x0603F98C RID: 260492 RVA: 0x00F623CC File Offset: 0x00F605CC
		[NullableContext(2)]
		public global::PinballChapterData GetDailyChapterData()
		{
			foreach (global::PinballChapterData pinballChapterData in this.ChapterMap.Values)
			{
				int[] levelIds = pinballChapterData.LevelIds;
				for (int i = 0; i < levelIds.Length; i++)
				{
					if (levelIds[i] == this.DailyConfigId)
					{
						return pinballChapterData;
					}
				}
			}
			return null;
		}

		// Token: 0x0603F98D RID: 260493 RVA: 0x00F62448 File Offset: 0x00F60648
		[NullableContext(2)]
		public global::PinballChapterData GetChapterData(int chapterId)
		{
			global::PinballChapterData result;
			this.ChapterMap.TryGetValue(chapterId, out result);
			return result;
		}

		// Token: 0x0603F98E RID: 260494 RVA: 0x00F62468 File Offset: 0x00F60668
		public int GetChapterIdByLevel(int levelId)
		{
			foreach (global::PinballChapterData pinballChapterData in this.ChapterMap.Values)
			{
				int[] levelIds = pinballChapterData.LevelIds;
				for (int i = 0; i < levelIds.Length; i++)
				{
					if (levelIds[i] == levelId)
					{
						return pinballChapterData.ChapterId;
					}
				}
			}
			return 0;
		}

		// Token: 0x0603F98F RID: 260495 RVA: 0x00F624E4 File Offset: 0x00F606E4
		public EPinballChapterLevelLockStatus GetChapterLockStatus(int chapterId)
		{
			global::PinballChapterData pinballChapterData;
			this.ChapterMap.TryGetValue(chapterId, out pinballChapterData);
			if (pinballChapterData == null)
			{
				return EPinballChapterLevelLockStatus.Lock;
			}
			PinballChapterConfig? pinballChapterConfigById = PinballConfig.Instance.GetPinballChapterConfigById(chapterId);
			if (pinballChapterConfigById == null)
			{
				return EPinballChapterLevelLockStatus.Lock;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			int unlockTime = pinballChapterData.UnlockTime;
			if (serverTime < (double)unlockTime)
			{
				return EPinballChapterLevelLockStatus.Lock;
			}
			int preChapterId = pinballChapterConfigById.Value.PreChapterId;
			if (!this.IsChapterPassed(preChapterId))
			{
				return EPinballChapterLevelLockStatus.PreLock;
			}
			return EPinballChapterLevelLockStatus.Activated;
		}

		// Token: 0x0603F990 RID: 260496 RVA: 0x00F62558 File Offset: 0x00F60758
		private void CheckChapterUnlocked()
		{
			if (this.ChapterUnlockRecord.Count == 0)
			{
				foreach (int num in this.ChapterMap.Keys)
				{
					bool value = this.GetChapterLockStatus(num) == EPinballChapterLevelLockStatus.Activated;
					this.ChapterUnlockRecord[num] = value;
				}
			}
		}

		// Token: 0x0603F991 RID: 260497 RVA: 0x00F625D0 File Offset: 0x00F607D0
		public bool IsNewChapterUnlocked(int targetChapterId)
		{
			this.UpdateChapterNewUnlockState(targetChapterId);
			bool flag;
			this.ChapterNewUnlockRecord.TryGetValue(targetChapterId, out flag);
			if (flag)
			{
				this.ChapterNewUnlockRecord[targetChapterId] = false;
			}
			return flag;
		}

		// Token: 0x0603F992 RID: 260498 RVA: 0x00F62604 File Offset: 0x00F60804
		private void UpdateChapterNewUnlockState(int chapterId)
		{
			bool flag;
			this.ChapterUnlockRecord.TryGetValue(chapterId, out flag);
			bool flag2 = this.GetChapterLockStatus(chapterId) == EPinballChapterLevelLockStatus.Activated;
			if (flag2 && flag != flag2)
			{
				this.ChapterNewUnlockRecord[chapterId] = true;
				if (this.GetChapterRedDotState(chapterId) == EPinballChapterRedDotState.None)
				{
					this.SetChapterRedDotState(chapterId, EPinballChapterRedDotState.Unread);
				}
			}
			this.ChapterUnlockRecord[chapterId] = flag2;
		}

		// Token: 0x0603F993 RID: 260499 RVA: 0x00F6265D File Offset: 0x00F6085D
		private EPinballChapterRedDotState GetChapterRedDotState(int chapterId)
		{
			return (EPinballChapterRedDotState)ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 0, chapterId, 0);
		}

		// Token: 0x0603F994 RID: 260500 RVA: 0x00F62673 File Offset: 0x00F60873
		private void SetChapterRedDotState(int chapterId, EPinballChapterRedDotState state)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 0, chapterId, 0, (int)state);
		}

		// Token: 0x0603F995 RID: 260501 RVA: 0x00F62689 File Offset: 0x00F60889
		public bool HasNewChapterRedDot(int chapterId)
		{
			this.UpdateChapterNewUnlockState(chapterId);
			return this.GetChapterRedDotState(chapterId) == EPinballChapterRedDotState.Unread;
		}

		// Token: 0x0603F996 RID: 260502 RVA: 0x00F6269C File Offset: 0x00F6089C
		public bool HasAnyNewChapterRedDot()
		{
			global::PinballChapterData dailyChapterData = this.GetDailyChapterData();
			int num = (dailyChapterData != null) ? dailyChapterData.ChapterId : 0;
			foreach (int num2 in this.ChapterMap.Keys)
			{
				if (num2 != num && this.HasNewChapterRedDot(num2))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603F997 RID: 260503 RVA: 0x00F62714 File Offset: 0x00F60914
		public bool CheckToSetChapterRedDotAsRead(int chapterId)
		{
			if (!this.HasNewChapterRedDot(chapterId))
			{
				return false;
			}
			this.SetChapterRedDotAsRead(chapterId);
			return true;
		}

		// Token: 0x0603F998 RID: 260504 RVA: 0x00F62729 File Offset: 0x00F60929
		public void SetChapterRedDotAsRead(int chapterId)
		{
			this.SetChapterRedDotState(chapterId, EPinballChapterRedDotState.Read);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603F999 RID: 260505 RVA: 0x00F6274C File Offset: 0x00F6094C
		public bool IsChapterPassed(int chapterId)
		{
			if (chapterId == 0)
			{
				return true;
			}
			global::PinballChapterData pinballChapterData;
			this.ChapterMap.TryGetValue(chapterId, out pinballChapterData);
			if (pinballChapterData == null)
			{
				return false;
			}
			foreach (int levelId in pinballChapterData.LevelIds)
			{
				if (!this.IsLevelPassed(levelId))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603F99A RID: 260506 RVA: 0x00F62798 File Offset: 0x00F60998
		public void AddAllGmUnlockLevelId()
		{
			foreach (int levelId in this.LevelRecordMap.Keys)
			{
				this.AddGmUnlockLevelId(levelId);
			}
		}

		// Token: 0x0603F99B RID: 260507 RVA: 0x00F627F0 File Offset: 0x00F609F0
		public void AddGmUnlockLevelId(int levelId)
		{
			if (this.GmUnlockLevelIdList.Contains(levelId))
			{
				return;
			}
			this.GmUnlockLevelIdList.Add(levelId);
		}

		// Token: 0x0603F99C RID: 260508 RVA: 0x00F6280D File Offset: 0x00F60A0D
		public void RemoveAllGmUnlockLevelId()
		{
			this.GmUnlockLevelIdList = new List<int>();
		}

		// Token: 0x0603F99D RID: 260509 RVA: 0x00F6281A File Offset: 0x00F60A1A
		public bool IsGmUnlockLevel(int levelId)
		{
			return this.GmUnlockLevelIdList.Contains(levelId);
		}

		// Token: 0x0603F99E RID: 260510 RVA: 0x00F62828 File Offset: 0x00F60A28
		public void UpdateLevelData(PinballLevelData data)
		{
			PinballLevelRecordData pinballLevelRecordData;
			this.LevelRecordMap.TryGetValue(data.ConfigId, out pinballLevelRecordData);
			if (pinballLevelRecordData == null)
			{
				pinballLevelRecordData = new PinballLevelRecordData();
				pinballLevelRecordData.LevelId = data.ConfigId;
				pinballLevelRecordData.ChapterId = this.GetChapterIdByLevel(data.ConfigId);
			}
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(data.ConfigId);
			pinballLevelRecordData.LevelShowType = (EPinballLevelShowType)pinballLevelConfigById.Value.Type;
			if (pinballLevelRecordData.LevelShowType == EPinballLevelShowType.Daily)
			{
				this.DailyConfigId = data.ConfigId;
			}
			CowLevel cowLevel = data.CowLevel;
			NormalLevel normalLevel = data.NormalLevel;
			TowerLevel towerLevel = data.TowerLevel;
			DailyLevel dailyLevel = data.DailyLevel;
			if (cowLevel != null)
			{
				int levelMaxScore = this.GetLevelMaxScore(data.ConfigId);
				if (cowLevel.LevelScore > 0)
				{
					bool flag = cowLevel.LevelScore >= levelMaxScore;
					pinballLevelRecordData.PassStatus = (flag ? EPinballLevelPassStatus.Perfect : EPinballLevelPassStatus.Finished);
				}
				else
				{
					pinballLevelRecordData.PassStatus = EPinballLevelPassStatus.Unfinished;
				}
				pinballLevelRecordData.LevelScore = cowLevel.LevelScore;
			}
			if (normalLevel != null)
			{
				int starByte = normalLevel.StarByte;
				int starCondLength = pinballLevelConfigById.Value.StarCondLength;
				int[] array = new int[starCondLength];
				for (int i = 0; i < starCondLength; i++)
				{
					array[i] = pinballLevelConfigById.Value.StarCond(i);
				}
				int[] passedConditionIdsByStarByte = this.GetPassedConditionIdsByStarByte(starByte, array);
				int num = passedConditionIdsByStarByte.Length;
				int num2 = starCondLength;
				if (num > 0)
				{
					bool flag2 = num >= num2;
					pinballLevelRecordData.PassStatus = (flag2 ? EPinballLevelPassStatus.Perfect : EPinballLevelPassStatus.Finished);
				}
				else
				{
					pinballLevelRecordData.PassStatus = EPinballLevelPassStatus.Unfinished;
				}
				pinballLevelRecordData.LevelStarConditionIds = passedConditionIdsByStarByte;
			}
			if (towerLevel != null)
			{
				int starByte2 = towerLevel.StarByte;
				int starCondLength2 = pinballLevelConfigById.Value.StarCondLength;
				int[] array2 = new int[starCondLength2];
				for (int j = 0; j < starCondLength2; j++)
				{
					array2[j] = pinballLevelConfigById.Value.StarCond(j);
				}
				int[] passedConditionIdsByStarByte2 = this.GetPassedConditionIdsByStarByte(starByte2, array2);
				int num3 = passedConditionIdsByStarByte2.Length;
				int num4 = starCondLength2;
				if (num3 > 0)
				{
					bool flag3 = num3 >= num4;
					pinballLevelRecordData.PassStatus = (flag3 ? EPinballLevelPassStatus.Perfect : EPinballLevelPassStatus.Finished);
				}
				else
				{
					pinballLevelRecordData.PassStatus = EPinballLevelPassStatus.Unfinished;
				}
				pinballLevelRecordData.LevelStarConditionIds = passedConditionIdsByStarByte2;
				pinballLevelRecordData.LevelPassedTime = towerLevel.CostTime;
			}
			if (dailyLevel != null)
			{
				this.RandomDailyLevelId = dailyLevel.RandomLevelId;
			}
			this.LevelRecordMap[data.ConfigId] = pinballLevelRecordData;
		}

		// Token: 0x0603F99F RID: 260511 RVA: 0x00F62A7A File Offset: 0x00F60C7A
		public int GetDailyConfigId()
		{
			return this.DailyConfigId;
		}

		// Token: 0x0603F9A0 RID: 260512 RVA: 0x00F62A84 File Offset: 0x00F60C84
		public int GetDailyRandomLevelId()
		{
			if (this.RandomDailyLevelId == 0)
			{
				PinballActivity? pinballActivityConfigByActivityId = PinballConfig.Instance.GetPinballActivityConfigByActivityId(base.Id);
				if (pinballActivityConfigByActivityId != null)
				{
					this.RandomDailyLevelId = pinballActivityConfigByActivityId.Value.DefaultDailyRandomId;
				}
			}
			return this.RandomDailyLevelId;
		}

		// Token: 0x0603F9A1 RID: 260513 RVA: 0x00F62AD0 File Offset: 0x00F60CD0
		public int GetCurDailyRewardDropId()
		{
			int num = 0;
			foreach (PinballLevelRecordData pinballLevelRecordData in this.LevelRecordMap.Values)
			{
				bool flag = pinballLevelRecordData.LevelShowType != EPinballLevelShowType.Daily;
				bool flag2 = pinballLevelRecordData.PassStatus != EPinballLevelPassStatus.Unfinished;
				if (flag && flag2)
				{
					num++;
				}
			}
			IReadOnlyList<PinballDailyConfig> allPinballDailyConfigList = PinballConfig.Instance.GetAllPinballDailyConfigList();
			int dailyClearDropId = allPinballDailyConfigList[0].DailyClearDropId;
			foreach (PinballDailyConfig pinballDailyConfig in allPinballDailyConfigList)
			{
				if (num >= pinballDailyConfig.LevelCompleteNum)
				{
					dailyClearDropId = pinballDailyConfig.DailyClearDropId;
				}
			}
			return dailyClearDropId;
		}

		// Token: 0x0603F9A2 RID: 260514 RVA: 0x00F62BAC File Offset: 0x00F60DAC
		[NullableContext(2)]
		public PinballLevelRecordData GetLevelData(int levelId)
		{
			PinballLevelRecordData result;
			this.LevelRecordMap.TryGetValue(levelId, out result);
			return result;
		}

		// Token: 0x0603F9A3 RID: 260515 RVA: 0x00F62BCC File Offset: 0x00F60DCC
		public List<PinballLevelRecordData> GetLevelDataListInChapter(int levelId)
		{
			List<PinballLevelRecordData> list = new List<PinballLevelRecordData>();
			PinballLevelRecordData levelData = this.GetLevelData(levelId);
			if (levelData == null)
			{
				return new List<PinballLevelRecordData>();
			}
			global::PinballChapterData chapterData = this.GetChapterData(levelData.ChapterId);
			if (chapterData == null)
			{
				return new List<PinballLevelRecordData>();
			}
			foreach (int levelId2 in chapterData.LevelIds)
			{
				PinballLevelRecordData levelData2 = this.GetLevelData(levelId2);
				if (levelData2 != null)
				{
					list.Add(levelData2);
				}
			}
			return list;
		}

		// Token: 0x0603F9A4 RID: 260516 RVA: 0x00F62C3C File Offset: 0x00F60E3C
		public int GetLevelMaxStarNum(int levelId)
		{
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(levelId);
			if (pinballLevelConfigById == null)
			{
				return 0;
			}
			return pinballLevelConfigById.Value.StarCondLength;
		}

		// Token: 0x0603F9A5 RID: 260517 RVA: 0x00F62C6F File Offset: 0x00F60E6F
		private bool CheckStarConditionPassedByStarByte(int starByte, int conditionId)
		{
			return conditionId > 0 && (starByte & 1 << conditionId) > 0;
		}

		// Token: 0x0603F9A6 RID: 260518 RVA: 0x00F62C84 File Offset: 0x00F60E84
		private int[] GetPassedConditionIdsByStarByte(int starByte, int[] conditionIds)
		{
			List<int> list = new List<int>();
			foreach (int num in conditionIds)
			{
				if (this.CheckStarConditionPassedByStarByte(starByte, num))
				{
					list.Add(num);
				}
			}
			return list.ToArray();
		}

		// Token: 0x0603F9A7 RID: 260519 RVA: 0x00F62CC4 File Offset: 0x00F60EC4
		public int GetLevelMaxScore(int levelId)
		{
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(levelId);
			if (pinballLevelConfigById == null)
			{
				return 0;
			}
			int num = 0;
			for (int i = 0; i < pinballLevelConfigById.Value.ScoreLevelRewardLength; i++)
			{
				DicIntInt? dicIntInt = pinballLevelConfigById.Value.ScoreLevelReward(i);
				if (dicIntInt != null)
				{
					int key = dicIntInt.Value.Key;
					if (key > num)
					{
						num = key;
					}
				}
			}
			return num;
		}

		// Token: 0x0603F9A8 RID: 260520 RVA: 0x00F62D3C File Offset: 0x00F60F3C
		public EPinballChapterLevelLockStatus GetLevelLockStatus(int levelId)
		{
			PinballLevelRecordData pinballLevelRecordData;
			this.LevelRecordMap.TryGetValue(levelId, out pinballLevelRecordData);
			if (pinballLevelRecordData == null)
			{
				return EPinballChapterLevelLockStatus.Lock;
			}
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(levelId);
			if (pinballLevelConfigById == null)
			{
				return EPinballChapterLevelLockStatus.Lock;
			}
			int preLevelIdsLength = pinballLevelConfigById.Value.PreLevelIdsLength;
			int[] array = new int[preLevelIdsLength];
			for (int i = 0; i < preLevelIdsLength; i++)
			{
				array[i] = pinballLevelConfigById.Value.PreLevelIds(i);
			}
			if (!this.IsLevelsPassed(array))
			{
				return EPinballChapterLevelLockStatus.PreLock;
			}
			return EPinballChapterLevelLockStatus.Activated;
		}

		// Token: 0x0603F9A9 RID: 260521 RVA: 0x00F62DC0 File Offset: 0x00F60FC0
		public string GetLevelPreConditionLockTexts(int levelId)
		{
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(levelId);
			if (pinballLevelConfigById == null)
			{
				return "";
			}
			List<string> list = new List<string>();
			int num = 0;
			int preLevelIdsLength = pinballLevelConfigById.Value.PreLevelIdsLength;
			for (int i = 0; i < preLevelIdsLength; i++)
			{
				int num2 = pinballLevelConfigById.Value.PreLevelIds(i);
				PinballLevelRecordData pinballLevelRecordData;
				this.LevelRecordMap.TryGetValue(num2, out pinballLevelRecordData);
				if (pinballLevelRecordData != null)
				{
					PinballLevelConfig? pinballLevelConfigById2 = PinballConfig.Instance.GetPinballLevelConfigById(num2);
					if (pinballLevelConfigById2 != null)
					{
						string localTextNew = ConfigMultiTextLang.GetLocalTextNew(pinballLevelConfigById2.Value.Name, null);
						if (pinballLevelRecordData.PassStatus == EPinballLevelPassStatus.Unfinished && localTextNew != null)
						{
							list.Add(localTextNew);
							num++;
						}
					}
				}
			}
			if (num == 0)
			{
				return "";
			}
			return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew((num == 1) ? "Pinball_Level_UnlockInfo" : "Pinball_Level_UnlockInfo_01", null), list.ToArray());
		}

		// Token: 0x0603F9AA RID: 260522 RVA: 0x00F62EAC File Offset: 0x00F610AC
		public bool IsLevelsPassed(int[] levelIdList)
		{
			foreach (int levelId in levelIdList)
			{
				if (!this.IsLevelPassed(levelId))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603F9AB RID: 260523 RVA: 0x00F62EDC File Offset: 0x00F610DC
		public bool IsLevelPassed(int levelId)
		{
			if (levelId == 0)
			{
				return true;
			}
			PinballLevelRecordData pinballLevelRecordData;
			this.LevelRecordMap.TryGetValue(levelId, out pinballLevelRecordData);
			return pinballLevelRecordData != null && pinballLevelRecordData.PassStatus != EPinballLevelPassStatus.Unfinished;
		}

		// Token: 0x0603F9AC RID: 260524 RVA: 0x00F62F10 File Offset: 0x00F61110
		public int GetTitleTipId()
		{
			PinballActivity? config = ConfigPinballActivityByActivityId.GetConfig(base.Id, true);
			if (config == null)
			{
				return 0;
			}
			return config.GetValueOrDefault().TitleTipId;
		}

		// Token: 0x0603F9AD RID: 260525 RVA: 0x00F62F44 File Offset: 0x00F61144
		public bool IsRoleFunctionOpen()
		{
			PinballActivity? config = ConfigPinballActivityByActivityId.GetConfig(base.Id, true);
			int num = (config != null) ? config.GetValueOrDefault().RoleFuncId : 0;
			return num == 0 || FunctionModel.Instance.IsOpen(num);
		}

		// Token: 0x0603F9AE RID: 260526 RVA: 0x00F62F8C File Offset: 0x00F6118C
		public void InitTaskData(List<ConditionTask> taskInfos)
		{
			if (taskInfos == null)
			{
				return;
			}
			this.TaskDataMap.Clear();
			this.TimeLimitTaskDataMap.Clear();
			this.PermanentTaskDataMap.Clear();
			foreach (ConditionTask conditionTask in taskInfos)
			{
				PinballTaskData pinballTaskData = new PinballTaskData(conditionTask);
				PinballTask? pinballTaskConfigById = PinballConfig.Instance.GetPinballTaskConfigById(conditionTask.Id);
				if (pinballTaskConfigById != null)
				{
					string text = pinballTaskConfigById.Value.TaskName ?? "";
					pinballTaskData.QuestNameTextKey = text;
					pinballTaskData.QuestName = (ConfigMultiTextLang.GetLocalTextNew(text, null) ?? text);
					pinballTaskData.SetRewardList(pinballTaskConfigById.Value.DropId);
					pinballTaskData.TaskTab = (EPinballTaskTab)pinballTaskConfigById.Value.TaskTab;
					if (pinballTaskConfigById.Value.TaskType == 1)
					{
						this.TimeLimitTaskDataMap[conditionTask.Id] = pinballTaskData;
					}
					else
					{
						this.PermanentTaskDataMap[conditionTask.Id] = pinballTaskData;
					}
				}
				else
				{
					this.PermanentTaskDataMap[conditionTask.Id] = pinballTaskData;
				}
				this.TaskDataMap[conditionTask.Id] = pinballTaskData;
			}
		}

		// Token: 0x0603F9AF RID: 260527 RVA: 0x00F630F0 File Offset: 0x00F612F0
		public void UpdateTaskData(ConditionTask taskInfo)
		{
			PinballTaskData pinballTaskData;
			this.TaskDataMap.TryGetValue(taskInfo.Id, out pinballTaskData);
			if (pinballTaskData != null)
			{
				pinballTaskData.UpdateTaskData(taskInfo);
				return;
			}
			PinballTaskData pinballTaskData2 = new PinballTaskData(taskInfo);
			PinballTask? pinballTaskConfigById = PinballConfig.Instance.GetPinballTaskConfigById(taskInfo.Id);
			if (pinballTaskConfigById != null)
			{
				string text = pinballTaskConfigById.Value.TaskName ?? "";
				pinballTaskData2.QuestNameTextKey = text;
				pinballTaskData2.QuestName = (ConfigMultiTextLang.GetLocalTextNew(text, null) ?? text);
				pinballTaskData2.SetRewardList(pinballTaskConfigById.Value.DropId);
				pinballTaskData2.TaskTab = (EPinballTaskTab)pinballTaskConfigById.Value.TaskTab;
				if (pinballTaskConfigById.Value.TaskType == 1)
				{
					this.TimeLimitTaskDataMap[taskInfo.Id] = pinballTaskData2;
				}
				else
				{
					this.PermanentTaskDataMap[taskInfo.Id] = pinballTaskData2;
				}
			}
			else
			{
				this.PermanentTaskDataMap[taskInfo.Id] = pinballTaskData2;
			}
			this.TaskDataMap[taskInfo.Id] = pinballTaskData2;
		}

		// Token: 0x0603F9B0 RID: 260528 RVA: 0x00F63200 File Offset: 0x00F61400
		public List<PinballTaskData> GetTaskDataList()
		{
			List<PinballTaskData> list = new List<PinballTaskData>();
			foreach (PinballTaskData item in this.TaskDataMap.Values)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0603F9B1 RID: 260529 RVA: 0x00F63260 File Offset: 0x00F61460
		[NullableContext(2)]
		public PinballTaskData GetTaskDataById(int taskId)
		{
			PinballTaskData result;
			this.TaskDataMap.TryGetValue(taskId, out result);
			return result;
		}

		// Token: 0x0603F9B2 RID: 260530 RVA: 0x00F63280 File Offset: 0x00F61480
		public List<PinballTaskData> GetTaskDataSortList()
		{
			List<PinballTaskData> list = new List<PinballTaskData>();
			foreach (PinballTaskData item in this.TaskDataMap.Values)
			{
				list.Add(item);
			}
			list.Sort((PinballTaskData a, PinballTaskData b) => this.TaskPriority(a) - this.TaskPriority(b));
			return list;
		}

		// Token: 0x0603F9B3 RID: 260531 RVA: 0x00F632F4 File Offset: 0x00F614F4
		public List<PinballTaskData> GetTimeLimitTaskList()
		{
			List<PinballTaskData> list = new List<PinballTaskData>();
			foreach (PinballTaskData item in this.TimeLimitTaskDataMap.Values)
			{
				list.Add(item);
			}
			list.Sort((PinballTaskData a, PinballTaskData b) => this.TaskPriority(a) - this.TaskPriority(b));
			return list;
		}

		// Token: 0x0603F9B4 RID: 260532 RVA: 0x00F63368 File Offset: 0x00F61568
		public List<PinballTaskData> GetPermanentTaskList()
		{
			List<PinballTaskData> list = new List<PinballTaskData>();
			foreach (PinballTaskData item in this.PermanentTaskDataMap.Values)
			{
				list.Add(item);
			}
			list.Sort((PinballTaskData a, PinballTaskData b) => this.TaskPriority(a) - this.TaskPriority(b));
			return list;
		}

		// Token: 0x0603F9B5 RID: 260533 RVA: 0x00F633DC File Offset: 0x00F615DC
		private int TaskPriority(PinballTaskData task)
		{
			if (task.IsUnclaimed)
			{
				return 0;
			}
			if (task.IsDoing)
			{
				return 1;
			}
			return 2;
		}

		// Token: 0x0603F9B6 RID: 260534 RVA: 0x00F633F4 File Offset: 0x00F615F4
		public bool IsExistClaimableTask()
		{
			using (Dictionary<int, PinballTaskData>.ValueCollection.Enumerator enumerator = this.TaskDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnclaimed)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603F9B7 RID: 260535 RVA: 0x00F63454 File Offset: 0x00F61654
		public override bool GetExDataRedPointShowState()
		{
			return this.IsMainHubEntranceHasRedDot();
		}

		// Token: 0x0603F9B8 RID: 260536 RVA: 0x00F6345C File Offset: 0x00F6165C
		public List<int> GetClaimableTaskIdList()
		{
			List<int> list = new List<int>();
			foreach (PinballTaskData pinballTaskData in this.TaskDataMap.Values)
			{
				if (pinballTaskData.IsUnclaimed)
				{
					list.Add(pinballTaskData.Data.Id);
				}
			}
			return list;
		}

		// Token: 0x0603F9B9 RID: 260537 RVA: 0x00F634D0 File Offset: 0x00F616D0
		public List<int> GetClaimablePermanentTaskIdList()
		{
			List<int> list = new List<int>();
			foreach (PinballTaskData pinballTaskData in this.PermanentTaskDataMap.Values)
			{
				if (pinballTaskData.IsUnclaimed && pinballTaskData.Data != null)
				{
					list.Add(pinballTaskData.Data.Id);
				}
			}
			return list;
		}

		// Token: 0x0603F9BA RID: 260538 RVA: 0x00F6354C File Offset: 0x00F6174C
		public List<int> GetClaimableTimeLimitTaskIdListWithoutBigReward()
		{
			List<int> list = new List<int>();
			foreach (PinballTaskData pinballTaskData in this.TimeLimitTaskDataMap.Values)
			{
				if (pinballTaskData.IsUnclaimed && pinballTaskData.Data != null && pinballTaskData.TaskTab != EPinballTaskTab.BigReward)
				{
					list.Add(pinballTaskData.Data.Id);
				}
			}
			return list;
		}

		// Token: 0x0603F9BB RID: 260539 RVA: 0x00F635D0 File Offset: 0x00F617D0
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"claimed",
			"total"
		})]
		public ValueTuple<int, int> GetPermanentTaskProgress()
		{
			List<PinballTaskData> permanentTaskList = this.GetPermanentTaskList();
			int count = permanentTaskList.Count;
			int num = 0;
			using (List<PinballTaskData>.Enumerator enumerator = permanentTaskList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsFinished)
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, count);
		}

		// Token: 0x0603F9BC RID: 260540 RVA: 0x00F63638 File Offset: 0x00F61838
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"claimed",
			"total"
		})]
		public ValueTuple<int, int> GetTimeLimitTaskProgress()
		{
			List<PinballTaskData> timeLimitTaskList = this.GetTimeLimitTaskList();
			int count = timeLimitTaskList.Count;
			int num = 0;
			using (List<PinballTaskData>.Enumerator enumerator = timeLimitTaskList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsFinished)
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, count);
		}

		// Token: 0x0603F9BD RID: 260541 RVA: 0x00F636A0 File Offset: 0x00F618A0
		public bool IsTimeLimitTaskHasRedDot()
		{
			if (!base.CheckIfInRewardTime())
			{
				return false;
			}
			using (Dictionary<int, PinballTaskData>.ValueCollection.Enumerator enumerator = this.TimeLimitTaskDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnclaimed)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603F9BE RID: 260542 RVA: 0x00F63708 File Offset: 0x00F61908
		public bool IsPermanentTaskHasRedDot()
		{
			using (Dictionary<int, PinballTaskData>.ValueCollection.Enumerator enumerator = this.PermanentTaskDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnclaimed)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603F9BF RID: 260543 RVA: 0x00F63768 File Offset: 0x00F61968
		public bool IsShopEntranceHasRedDot()
		{
			if (this.ShopId <= 0)
			{
				return false;
			}
			foreach (PayShopGoods payShopGoods in PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)this.ShopId, 1, false))
			{
				int goodsId = payShopGoods.GetGoodsId();
				if (goodsId > 0 && !NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.PayShopTabItemChecked, goodsId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603F9C0 RID: 260544 RVA: 0x00F637EC File Offset: 0x00F619EC
		public bool IsMainHubEntranceHasRedDot()
		{
			if (this.HasAnyNewChapterRedDot())
			{
				return true;
			}
			if (this.IsPreGuideQuestTaskRedDotActive())
			{
				return true;
			}
			if (this.IsPermanentTaskHasRedDot())
			{
				return true;
			}
			if (this.IsTimeLimitTaskHasRedDot())
			{
				return true;
			}
			if (FunctionModel.Instance.IsOpen(10153) && this.IsShopEntranceHasRedDot())
			{
				return true;
			}
			if (!this.IsRoleFunctionOpen())
			{
				return false;
			}
			foreach (int roleId in this.GetUnlockRoleList())
			{
				if (PinballModel.Instance.GetRoleRedDot(base.Id, roleId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603F9C1 RID: 260545 RVA: 0x00F638A0 File Offset: 0x00F61AA0
		public bool IsPreGuideQuestTaskRedDotActive()
		{
			List<int> preGuideQuestIds = base.GetPreGuideQuestIds();
			if (preGuideQuestIds == null || preGuideQuestIds.Count == 0)
			{
				return false;
			}
			QuestNewModel instance = QuestNewModel.Instance;
			foreach (int questId in preGuideQuestIds)
			{
				if (instance.CheckQuestRedDotDataState(questId).GetValueOrDefault())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603F9C2 RID: 260546 RVA: 0x00F6391C File Offset: 0x00F61B1C
		protected override bool GetExDataFinishShowState()
		{
			Dictionary<int, PinballTaskData> dictionary = base.CheckIfInRewardTime() ? this.TaskDataMap : this.PermanentTaskDataMap;
			if (dictionary.Count <= 0)
			{
				return false;
			}
			using (Dictionary<int, PinballTaskData>.ValueCollection.Enumerator enumerator = dictionary.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsFinished)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0603F9C3 RID: 260547 RVA: 0x00F63998 File Offset: 0x00F61B98
		private void SortAndUpdateRank(List<global::PinballRankData> rankDataList)
		{
			rankDataList.Sort(delegate(global::PinballRankData a, global::PinballRankData b)
			{
				if (a.TowerLevel != b.TowerLevel)
				{
					return b.TowerLevel - a.TowerLevel;
				}
				return a.CostTime - b.CostTime;
			});
			for (int i = 0; i < rankDataList.Count; i++)
			{
				rankDataList[i].Ranking = i + 1;
			}
		}

		// Token: 0x0603F9C4 RID: 260548 RVA: 0x00F639EA File Offset: 0x00F61BEA
		private void SortAndUpdateInternalRank()
		{
			this.SortAndUpdateRank(this.RankDataList);
		}

		// Token: 0x0603F9C5 RID: 260549 RVA: 0x00F639F8 File Offset: 0x00F61BF8
		public void SetRankDataList(List<Aki.Protocol.PinballRankData> rankDataList)
		{
			this.RankDataList.Clear();
			if (rankDataList != null)
			{
				foreach (Aki.Protocol.PinballRankData pinballRankData in rankDataList)
				{
					if (global::PinballRankData.IsValidServerRankData(pinballRankData))
					{
						global::PinballRankData pinballRankData2 = new global::PinballRankData(false);
						pinballRankData2.SetDataByServerInfo(pinballRankData);
						this.RankDataList.Add(pinballRankData2);
					}
				}
				this.SortAndUpdateInternalRank();
			}
			this.ConfigRankList = null;
		}

		// Token: 0x0603F9C6 RID: 260550 RVA: 0x00F63A7C File Offset: 0x00F61C7C
		public List<global::PinballRankData> GetRankList()
		{
			List<global::PinballRankData> list = new List<global::PinballRankData>();
			foreach (global::PinballRankData item in this.RankDataList)
			{
				list.Add(item);
			}
			if (this.MyRankData != null && this.MyRankData.HasData)
			{
				list.Add(this.MyRankData);
			}
			int count = list.Count;
			foreach (global::PinballRankData pinballRankData in this.GetConfigRankList())
			{
				if (pinballRankData.HasData && count < pinballRankData.DisplayThreshold)
				{
					list.Add(pinballRankData);
				}
			}
			this.SortAndUpdateRank(list);
			return list;
		}

		// Token: 0x0603F9C7 RID: 260551 RVA: 0x00F63B5C File Offset: 0x00F61D5C
		private List<global::PinballRankData> GetConfigRankList()
		{
			if (this.ConfigRankList != null)
			{
				return this.ConfigRankList;
			}
			this.ConfigRankList = new List<global::PinballRankData>();
			IReadOnlyList<PinballRank> allPinballRankConfigList = PinballConfig.Instance.GetAllPinballRankConfigList();
			if (allPinballRankConfigList != null)
			{
				foreach (PinballRank pinballRank in allPinballRankConfigList)
				{
					int tower = pinballRank.Tower;
					global::PinballRankData pinballRankData = new global::PinballRankData(false);
					pinballRankData.SetDataByConfig(tower);
					if (pinballRankData.HasData)
					{
						this.ConfigRankList.Add(pinballRankData);
					}
				}
			}
			return this.ConfigRankList;
		}

		// Token: 0x0603F9C8 RID: 260552 RVA: 0x00F63BFC File Offset: 0x00F61DFC
		[NullableContext(2)]
		public void SetMyRankData(Aki.Protocol.PinballRankData rankData)
		{
			this.MyRankData = new global::PinballRankData(true);
			this.MyRankData.SetMyRankData(rankData);
		}

		// Token: 0x0603F9C9 RID: 260553 RVA: 0x00F63C16 File Offset: 0x00F61E16
		[NullableContext(2)]
		public global::PinballRankData GetMyRankData()
		{
			return this.MyRankData;
		}

		// Token: 0x0603F9CA RID: 260554 RVA: 0x00F63C20 File Offset: 0x00F61E20
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"LevelId",
			"TowerNum",
			"CostTime"
		})]
		private ValueTuple<int, int, int>? GetBestPassedTowerLevelContext()
		{
			int num = 0;
			int num2 = 0;
			int item = 0;
			foreach (PinballLevelRecordData pinballLevelRecordData in this.LevelRecordMap.Values)
			{
				if (pinballLevelRecordData.LevelShowType == EPinballLevelShowType.Tower && pinballLevelRecordData.PassStatus == EPinballLevelPassStatus.Perfect)
				{
					PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(pinballLevelRecordData.LevelId);
					int num3 = (pinballLevelConfigById != null) ? pinballLevelConfigById.GetValueOrDefault().TowerNum : 0;
					if (num3 > num || (num3 == num && pinballLevelRecordData.LevelId > num2))
					{
						num = num3;
						num2 = pinballLevelRecordData.LevelId;
						item = pinballLevelRecordData.LevelPassedTime;
					}
				}
			}
			if (num <= 0 || num2 <= 0)
			{
				return null;
			}
			return new ValueTuple<int, int, int>?(new ValueTuple<int, int, int>(num2, num, item));
		}

		// Token: 0x0603F9CB RID: 260555 RVA: 0x00F63D04 File Offset: 0x00F61F04
		[return: TupleElementNames(new string[]
		{
			"RoleId",
			"Level"
		})]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		private List<ValueTuple<int, int>> BuildRankFormationFromRoleIds(int[] roleIds)
		{
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			foreach (int num in roleIds)
			{
				if (num != 0)
				{
					global::PinballRoleData roleData = this.GetRoleData(num);
					list.Add(new ValueTuple<int, int>(num, (roleData != null) ? roleData.GetLevel() : 0));
				}
			}
			return list;
		}

		// Token: 0x0603F9CC RID: 260556 RVA: 0x00F63D54 File Offset: 0x00F61F54
		private int GetFormationGroupFromTowerLevelRecord(int towerLevel)
		{
			int num = 0;
			foreach (PinballLevelRecordData pinballLevelRecordData in this.LevelRecordMap.Values)
			{
				if (pinballLevelRecordData.LevelShowType == EPinballLevelShowType.Tower && pinballLevelRecordData.PassStatus == EPinballLevelPassStatus.Perfect)
				{
					PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(pinballLevelRecordData.LevelId);
					if (pinballLevelConfigById != null && pinballLevelConfigById.Value.TowerNum == towerLevel && (num == 0 || pinballLevelRecordData.LevelId > num))
					{
						num = pinballLevelRecordData.LevelId;
					}
				}
			}
			if (num <= 0)
			{
				return 0;
			}
			PinballLevelConfig? pinballLevelConfigById2 = PinballConfig.Instance.GetPinballLevelConfigById(num);
			if (pinballLevelConfigById2 == null)
			{
				return 0;
			}
			return pinballLevelConfigById2.GetValueOrDefault().FormationGroup;
		}

		// Token: 0x0603F9CD RID: 260557 RVA: 0x00F63E28 File Offset: 0x00F62028
		private int[] ResolveFormationRoleIdsForRank(int formationGroup)
		{
			int[] array;
			this.LevelFormationMap.TryGetValue(formationGroup, out array);
			if (array != null && array.Length != 0)
			{
				return array;
			}
			foreach (int[] array2 in this.LevelFormationMap.Values)
			{
				if (array2 != null && array2.Length != 0)
				{
					return array2;
				}
			}
			return Array.Empty<int>();
		}

		// Token: 0x0603F9CE RID: 260558 RVA: 0x00F63EA4 File Offset: 0x00F620A4
		public void TryFillMyRankFormationFromLocal(global::PinballRankData rankData)
		{
			if (!rankData.IsMyRank || rankData.Formation.Count > 0)
			{
				return;
			}
			int num = (rankData.TowerLevel > 0) ? this.GetFormationGroupFromTowerLevelRecord(rankData.TowerLevel) : 0;
			if (num <= 0)
			{
				ValueTuple<int, int, int>? bestPassedTowerLevelContext = this.GetBestPassedTowerLevelContext();
				if (bestPassedTowerLevelContext == null)
				{
					return;
				}
				PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(bestPassedTowerLevelContext.Value.Item1);
				num = ((pinballLevelConfigById != null) ? pinballLevelConfigById.GetValueOrDefault().FormationGroup : 0);
			}
			int[] roleIds = this.ResolveFormationRoleIdsForRank(num);
			rankData.Formation = this.BuildRankFormationFromRoleIds(roleIds);
		}

		// Token: 0x0603F9CF RID: 260559 RVA: 0x00F63F40 File Offset: 0x00F62140
		public void ApplyLocalTowerRankFallbackToMyRank(global::PinballRankData rankData)
		{
			if (rankData.HasData)
			{
				return;
			}
			ValueTuple<int, int, int>? bestPassedTowerLevelContext = this.GetBestPassedTowerLevelContext();
			if (bestPassedTowerLevelContext == null)
			{
				return;
			}
			rankData.Name = (FunctionModel.Instance.GetPlayerName() ?? "");
			rankData.TowerLevel = bestPassedTowerLevelContext.Value.Item2;
			rankData.CostTime = bestPassedTowerLevelContext.Value.Item3;
			rankData.HasData = true;
		}

		// Token: 0x0603F9D0 RID: 260560 RVA: 0x00F63FAC File Offset: 0x00F621AC
		private void InitLevelFormationData(List<GroupFormation> dataList)
		{
			this.LevelFormationMap.Clear();
			foreach (GroupFormation groupFormation in dataList)
			{
				int[] array = new int[groupFormation.RoleIds.Count];
				for (int i = 0; i < groupFormation.RoleIds.Count; i++)
				{
					array[i] = groupFormation.RoleIds[i];
				}
				this.LevelFormationMap[groupFormation.LevelGroup] = array;
			}
		}

		// Token: 0x0603F9D1 RID: 260561 RVA: 0x00F64048 File Offset: 0x00F62248
		public void UpDateLevelFormationData(GroupFormation data)
		{
			int[] array = new int[data.RoleIds.Count];
			for (int i = 0; i < data.RoleIds.Count; i++)
			{
				array[i] = data.RoleIds[i];
			}
			this.LevelFormationMap[data.LevelGroup] = array;
		}

		// Token: 0x0603F9D2 RID: 260562 RVA: 0x00F6409D File Offset: 0x00F6229D
		public string GetRecommendTaskTips()
		{
			return "Pinball_Activity_RecommendTaskTips";
		}

		// Token: 0x0603F9D3 RID: 260563 RVA: 0x00F640A4 File Offset: 0x00F622A4
		public int GetRecommendTaskId()
		{
			if (ConfigPinballActivityByActivityId.GetConfig(base.Id, true) == null)
			{
				return 0;
			}
			PinballActivity? pinballActivity;
			return pinballActivity.GetValueOrDefault().RecommendTaskId;
		}

		// Token: 0x0603F9D4 RID: 260564 RVA: 0x00F640D8 File Offset: 0x00F622D8
		public bool IsRecommendTaskFinished()
		{
			int recommendTaskId = this.GetRecommendTaskId();
			return recommendTaskId == 0 || QuestNewModel.Instance.CheckQuestFinished(recommendTaskId);
		}

		// Token: 0x0603F9D5 RID: 260565 RVA: 0x00F640FC File Offset: 0x00F622FC
		public string GetRecommendTaskDisplayName()
		{
			int recommendTaskId = this.GetRecommendTaskId();
			if (recommendTaskId == 0)
			{
				return "";
			}
			string questName = QuestNewModel.Instance.GetQuestName(recommendTaskId);
			if (questName != null)
			{
				return questName;
			}
			IQuest questConfig = QuestNewModel.Instance.GetQuestConfig(recommendTaskId);
			string text = (questConfig != null) ? questConfig.TidName : null;
			if (text != null)
			{
				return PublicUtil.Instance.GetConfigTextByKey(text) ?? "";
			}
			return "";
		}

		// Token: 0x0603F9D6 RID: 260566 RVA: 0x00F64160 File Offset: 0x00F62360
		public void UpdateRoleWeaponRedDot()
		{
			this.RebuildWeaponMaxIndex();
			this.RoleWeaponMaxQualityMap.Clear();
			foreach (PinballRoleDataBase pinballRoleDataBase in this.RoleDataMap.Values)
			{
				int id = pinballRoleDataBase.GetId();
				this.RoleWeaponMaxQualityMap[id] = this.CalRoleWeaponMaxQuality(id);
				EventSystem.Instance.Emit<int>(EEventName.RefreshPinballWeaponRedDot, id);
			}
		}

		// Token: 0x0603F9D7 RID: 260567 RVA: 0x00F641EC File Offset: 0x00F623EC
		private void RebuildWeaponMaxIndex()
		{
			this.CommonTypeMaxQualityMap.Clear();
			this.PersonTypeMaxQualityMap.Clear();
			foreach (PinballWeaponData pinballWeaponData in this.WeaponDataMap.Values)
			{
				if (pinballWeaponData.RoleId == 0)
				{
					if (!pinballWeaponData.GetIsPersonWeapon())
					{
						int num;
						this.CommonTypeMaxQualityMap.TryGetValue(pinballWeaponData.Type, out num);
						if (pinballWeaponData.Quality > num)
						{
							this.CommonTypeMaxQualityMap[pinballWeaponData.Type] = pinballWeaponData.Quality;
						}
					}
					else
					{
						this.PersonTypeMaxQualityMap[pinballWeaponData.PersonType] = pinballWeaponData.Quality;
					}
				}
			}
		}

		// Token: 0x0603F9D8 RID: 260568 RVA: 0x00F642B0 File Offset: 0x00F624B0
		private int CalRoleWeaponMaxQuality(int roleId)
		{
			global::PinballRoleData roleData = this.GetRoleData(roleId);
			if (roleData == null || roleData.IsLocked())
			{
				return 0;
			}
			PinballRoleConfig config = roleData.GetConfig();
			PinballWeaponData weaponData = roleData.GetWeaponData();
			int num = (weaponData != null) ? weaponData.Quality : 0;
			int val;
			this.PersonTypeMaxQualityMap.TryGetValue(config.PersonWeaponType, out val);
			int val2;
			this.CommonTypeMaxQualityMap.TryGetValue(config.WeaponType, out val2);
			int num2 = Math.Max(val, val2);
			if (num2 <= num)
			{
				return 0;
			}
			return num2;
		}

		// Token: 0x0603F9D9 RID: 260569 RVA: 0x00F6432C File Offset: 0x00F6252C
		public int GetRoleWeaponMaxQuality(int roleId)
		{
			int result;
			this.RoleWeaponMaxQualityMap.TryGetValue(roleId, out result);
			return result;
		}

		// Token: 0x0603F9DA RID: 260570 RVA: 0x00F64349 File Offset: 0x00F62549
		public bool GetRoleWeaponRedDot(int roleId)
		{
			return this.GetRoleWeaponMaxQuality(roleId) > 0;
		}

		// Token: 0x04021404 RID: 136196
		private readonly Dictionary<int, PinballWeaponData> WeaponDataMap = new Dictionary<int, PinballWeaponData>();

		// Token: 0x04021405 RID: 136197
		protected Dictionary<int, PinballRoleDataBase> RoleDataMap = new Dictionary<int, PinballRoleDataBase>();

		// Token: 0x04021406 RID: 136198
		private readonly Dictionary<int, int> RoleWeaponMaxQualityMap = new Dictionary<int, int>();

		// Token: 0x04021407 RID: 136199
		private readonly Dictionary<int, int> CommonTypeMaxQualityMap = new Dictionary<int, int>();

		// Token: 0x04021408 RID: 136200
		private readonly Dictionary<int, int> PersonTypeMaxQualityMap = new Dictionary<int, int>();

		// Token: 0x04021409 RID: 136201
		private readonly Dictionary<int, global::PinballChapterData> ChapterMap = new Dictionary<int, global::PinballChapterData>();

		// Token: 0x0402140A RID: 136202
		private readonly Dictionary<int, bool> ChapterUnlockRecord = new Dictionary<int, bool>();

		// Token: 0x0402140B RID: 136203
		private readonly Dictionary<int, bool> ChapterNewUnlockRecord = new Dictionary<int, bool>();

		// Token: 0x0402140C RID: 136204
		private List<int> GmUnlockChapterIdList = new List<int>();

		// Token: 0x0402140D RID: 136205
		private readonly Dictionary<int, PinballLevelRecordData> LevelRecordMap = new Dictionary<int, PinballLevelRecordData>();

		// Token: 0x0402140E RID: 136206
		private int DailyConfigId;

		// Token: 0x0402140F RID: 136207
		private int RandomDailyLevelId;

		// Token: 0x04021410 RID: 136208
		private List<int> GmUnlockLevelIdList = new List<int>();

		// Token: 0x04021411 RID: 136209
		private readonly Dictionary<int, PinballTaskData> TaskDataMap = new Dictionary<int, PinballTaskData>();

		// Token: 0x04021412 RID: 136210
		private readonly Dictionary<int, PinballTaskData> TimeLimitTaskDataMap = new Dictionary<int, PinballTaskData>();

		// Token: 0x04021413 RID: 136211
		private readonly Dictionary<int, PinballTaskData> PermanentTaskDataMap = new Dictionary<int, PinballTaskData>();

		// Token: 0x04021414 RID: 136212
		public int ShopId;

		// Token: 0x04021415 RID: 136213
		private const int DEFAULT_SHOP_ID = 5;

		// Token: 0x04021416 RID: 136214
		private readonly List<global::PinballRankData> RankDataList = new List<global::PinballRankData>();

		// Token: 0x04021417 RID: 136215
		[Nullable(2)]
		private global::PinballRankData MyRankData;

		// Token: 0x04021418 RID: 136216
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<global::PinballRankData> ConfigRankList;

		// Token: 0x04021419 RID: 136217
		public Dictionary<int, int[]> LevelFormationMap = new Dictionary<int, int[]>();

		// Token: 0x0200C497 RID: 50327
		[NullableContext(0)]
		private enum EStorageKey
		{
			// Token: 0x0403B527 RID: 242983
			ChapterRedDot
		}
	}
}
