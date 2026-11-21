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
	// Token: 0x02005244 RID: 21060
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballActivityData : ActivityBaseData
	{
		// Token: 0x0603463A RID: 214586 RVA: 0x00EA8AF4 File Offset: 0x00EA6CF4
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

		// Token: 0x0603463B RID: 214587 RVA: 0x00EA8D5C File Offset: 0x00EA6F5C
		private global::PinballRoleData AddRoleData(int configId)
		{
			global::PinballRoleData pinballRoleData = new global::PinballRoleData(configId);
			this.RoleDataMap[configId] = pinballRoleData;
			EventSystem.Instance.Emit<int>(EEventName.RefreshPinballRoleRedDot, configId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			return pinballRoleData;
		}

		// Token: 0x0603463C RID: 214588 RVA: 0x00EA8DA8 File Offset: 0x00EA6FA8
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

		// Token: 0x0603463D RID: 214589 RVA: 0x00EA8DE4 File Offset: 0x00EA6FE4
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

		// Token: 0x0603463E RID: 214590 RVA: 0x00EA8E0C File Offset: 0x00EA700C
		public List<int> GetUnlockRoleList()
		{
			List<int> list = new List<int>();
			foreach (int item in this.RoleDataMap.Keys)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0603463F RID: 214591 RVA: 0x00EA8E6C File Offset: 0x00EA706C
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

		// Token: 0x06034640 RID: 214592 RVA: 0x00EA8ED0 File Offset: 0x00EA70D0
		public void RemoveWeaponData(List<int> incIdList)
		{
			foreach (int key in incIdList)
			{
				this.WeaponDataMap.Remove(key);
			}
		}

		// Token: 0x06034641 RID: 214593 RVA: 0x00EA8F24 File Offset: 0x00EA7124
		[NullableContext(2)]
		public PinballWeaponData GetWeaponDataByIncId(int incId)
		{
			PinballWeaponData result;
			this.WeaponDataMap.TryGetValue(incId, out result);
			return result;
		}

		// Token: 0x06034642 RID: 214594 RVA: 0x00EA8F44 File Offset: 0x00EA7144
		public List<PinballWeaponData> GetWeaponDataAll()
		{
			List<PinballWeaponData> list = new List<PinballWeaponData>();
			foreach (PinballWeaponData item in this.WeaponDataMap.Values)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06034643 RID: 214595 RVA: 0x00EA8FA4 File Offset: 0x00EA71A4
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

		// Token: 0x06034644 RID: 214596 RVA: 0x00EA9004 File Offset: 0x00EA7204
		public void AddAllGmUnlockChapterId()
		{
			foreach (int chapterId in this.ChapterMap.Keys)
			{
				this.AddGmUnlockChapterId(chapterId);
			}
		}

		// Token: 0x06034645 RID: 214597 RVA: 0x00EA905C File Offset: 0x00EA725C
		public void AddGmUnlockChapterId(int chapterId)
		{
			if (this.GmUnlockChapterIdList.Contains(chapterId))
			{
				return;
			}
			this.GmUnlockChapterIdList.Add(chapterId);
		}

		// Token: 0x06034646 RID: 214598 RVA: 0x00EA907C File Offset: 0x00EA727C
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

		// Token: 0x06034647 RID: 214599 RVA: 0x00EA90E0 File Offset: 0x00EA72E0
		public void RemoveAllGmUnlockChapterId()
		{
			this.GmUnlockChapterIdList = new List<int>();
		}

		// Token: 0x06034648 RID: 214600 RVA: 0x00EA90ED File Offset: 0x00EA72ED
		public bool IsGmUnlockChapter(int chapterId)
		{
			return this.GmUnlockChapterIdList.Contains(chapterId);
		}

		// Token: 0x06034649 RID: 214601 RVA: 0x00EA90FC File Offset: 0x00EA72FC
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

		// Token: 0x0603464A RID: 214602 RVA: 0x00EA9150 File Offset: 0x00EA7350
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

		// Token: 0x0603464B RID: 214603 RVA: 0x00EA9230 File Offset: 0x00EA7430
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

		// Token: 0x0603464C RID: 214604 RVA: 0x00EA92B0 File Offset: 0x00EA74B0
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

		// Token: 0x0603464D RID: 214605 RVA: 0x00EA9328 File Offset: 0x00EA7528
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

		// Token: 0x0603464E RID: 214606 RVA: 0x00EA93A4 File Offset: 0x00EA75A4
		[NullableContext(2)]
		public global::PinballChapterData GetChapterData(int chapterId)
		{
			global::PinballChapterData result;
			this.ChapterMap.TryGetValue(chapterId, out result);
			return result;
		}

		// Token: 0x0603464F RID: 214607 RVA: 0x00EA93C4 File Offset: 0x00EA75C4
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

		// Token: 0x06034650 RID: 214608 RVA: 0x00EA9440 File Offset: 0x00EA7640
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

		// Token: 0x06034651 RID: 214609 RVA: 0x00EA94B4 File Offset: 0x00EA76B4
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

		// Token: 0x06034652 RID: 214610 RVA: 0x00EA952C File Offset: 0x00EA772C
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

		// Token: 0x06034653 RID: 214611 RVA: 0x00EA9560 File Offset: 0x00EA7760
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

		// Token: 0x06034654 RID: 214612 RVA: 0x00EA95B9 File Offset: 0x00EA77B9
		private EPinballChapterRedDotState GetChapterRedDotState(int chapterId)
		{
			return (EPinballChapterRedDotState)ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 0, chapterId, 0);
		}

		// Token: 0x06034655 RID: 214613 RVA: 0x00EA95CF File Offset: 0x00EA77CF
		private void SetChapterRedDotState(int chapterId, EPinballChapterRedDotState state)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 0, chapterId, 0, (int)state);
		}

		// Token: 0x06034656 RID: 214614 RVA: 0x00EA95E5 File Offset: 0x00EA77E5
		public bool HasNewChapterRedDot(int chapterId)
		{
			this.UpdateChapterNewUnlockState(chapterId);
			return this.GetChapterRedDotState(chapterId) == EPinballChapterRedDotState.Unread;
		}

		// Token: 0x06034657 RID: 214615 RVA: 0x00EA95F8 File Offset: 0x00EA77F8
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

		// Token: 0x06034658 RID: 214616 RVA: 0x00EA9670 File Offset: 0x00EA7870
		public bool CheckToSetChapterRedDotAsRead(int chapterId)
		{
			if (!this.HasNewChapterRedDot(chapterId))
			{
				return false;
			}
			this.SetChapterRedDotAsRead(chapterId);
			return true;
		}

		// Token: 0x06034659 RID: 214617 RVA: 0x00EA9685 File Offset: 0x00EA7885
		public void SetChapterRedDotAsRead(int chapterId)
		{
			this.SetChapterRedDotState(chapterId, EPinballChapterRedDotState.Read);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603465A RID: 214618 RVA: 0x00EA96A8 File Offset: 0x00EA78A8
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

		// Token: 0x0603465B RID: 214619 RVA: 0x00EA96F4 File Offset: 0x00EA78F4
		public void AddAllGmUnlockLevelId()
		{
			foreach (int levelId in this.LevelRecordMap.Keys)
			{
				this.AddGmUnlockLevelId(levelId);
			}
		}

		// Token: 0x0603465C RID: 214620 RVA: 0x00EA974C File Offset: 0x00EA794C
		public void AddGmUnlockLevelId(int levelId)
		{
			if (this.GmUnlockLevelIdList.Contains(levelId))
			{
				return;
			}
			this.GmUnlockLevelIdList.Add(levelId);
		}

		// Token: 0x0603465D RID: 214621 RVA: 0x00EA9769 File Offset: 0x00EA7969
		public void RemoveAllGmUnlockLevelId()
		{
			this.GmUnlockLevelIdList = new List<int>();
		}

		// Token: 0x0603465E RID: 214622 RVA: 0x00EA9776 File Offset: 0x00EA7976
		public bool IsGmUnlockLevel(int levelId)
		{
			return this.GmUnlockLevelIdList.Contains(levelId);
		}

		// Token: 0x0603465F RID: 214623 RVA: 0x00EA9784 File Offset: 0x00EA7984
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

		// Token: 0x06034660 RID: 214624 RVA: 0x00EA99D6 File Offset: 0x00EA7BD6
		public int GetDailyConfigId()
		{
			return this.DailyConfigId;
		}

		// Token: 0x06034661 RID: 214625 RVA: 0x00EA99E0 File Offset: 0x00EA7BE0
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

		// Token: 0x06034662 RID: 214626 RVA: 0x00EA9A2C File Offset: 0x00EA7C2C
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

		// Token: 0x06034663 RID: 214627 RVA: 0x00EA9B08 File Offset: 0x00EA7D08
		[NullableContext(2)]
		public PinballLevelRecordData GetLevelData(int levelId)
		{
			PinballLevelRecordData result;
			this.LevelRecordMap.TryGetValue(levelId, out result);
			return result;
		}

		// Token: 0x06034664 RID: 214628 RVA: 0x00EA9B28 File Offset: 0x00EA7D28
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

		// Token: 0x06034665 RID: 214629 RVA: 0x00EA9B98 File Offset: 0x00EA7D98
		public int GetLevelMaxStarNum(int levelId)
		{
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(levelId);
			if (pinballLevelConfigById == null)
			{
				return 0;
			}
			return pinballLevelConfigById.Value.StarCondLength;
		}

		// Token: 0x06034666 RID: 214630 RVA: 0x00EA9BCB File Offset: 0x00EA7DCB
		private bool CheckStarConditionPassedByStarByte(int starByte, int conditionId)
		{
			return conditionId > 0 && (starByte & 1 << conditionId) > 0;
		}

		// Token: 0x06034667 RID: 214631 RVA: 0x00EA9BE0 File Offset: 0x00EA7DE0
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

		// Token: 0x06034668 RID: 214632 RVA: 0x00EA9C20 File Offset: 0x00EA7E20
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

		// Token: 0x06034669 RID: 214633 RVA: 0x00EA9C98 File Offset: 0x00EA7E98
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

		// Token: 0x0603466A RID: 214634 RVA: 0x00EA9D1C File Offset: 0x00EA7F1C
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

		// Token: 0x0603466B RID: 214635 RVA: 0x00EA9E08 File Offset: 0x00EA8008
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

		// Token: 0x0603466C RID: 214636 RVA: 0x00EA9E38 File Offset: 0x00EA8038
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

		// Token: 0x0603466D RID: 214637 RVA: 0x00EA9E6C File Offset: 0x00EA806C
		public int GetTitleTipId()
		{
			PinballActivity? config = ConfigPinballActivityByActivityId.GetConfig(base.Id, true);
			if (config == null)
			{
				return 0;
			}
			return config.GetValueOrDefault().TitleTipId;
		}

		// Token: 0x0603466E RID: 214638 RVA: 0x00EA9EA0 File Offset: 0x00EA80A0
		public bool IsRoleFunctionOpen()
		{
			PinballActivity? config = ConfigPinballActivityByActivityId.GetConfig(base.Id, true);
			int num = (config != null) ? config.GetValueOrDefault().RoleFuncId : 0;
			return num == 0 || FunctionModel.Instance.IsOpen(num);
		}

		// Token: 0x0603466F RID: 214639 RVA: 0x00EA9EE8 File Offset: 0x00EA80E8
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

		// Token: 0x06034670 RID: 214640 RVA: 0x00EAA04C File Offset: 0x00EA824C
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

		// Token: 0x06034671 RID: 214641 RVA: 0x00EAA15C File Offset: 0x00EA835C
		public List<PinballTaskData> GetTaskDataList()
		{
			List<PinballTaskData> list = new List<PinballTaskData>();
			foreach (PinballTaskData item in this.TaskDataMap.Values)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06034672 RID: 214642 RVA: 0x00EAA1BC File Offset: 0x00EA83BC
		[NullableContext(2)]
		public PinballTaskData GetTaskDataById(int taskId)
		{
			PinballTaskData result;
			this.TaskDataMap.TryGetValue(taskId, out result);
			return result;
		}

		// Token: 0x06034673 RID: 214643 RVA: 0x00EAA1DC File Offset: 0x00EA83DC
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

		// Token: 0x06034674 RID: 214644 RVA: 0x00EAA250 File Offset: 0x00EA8450
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

		// Token: 0x06034675 RID: 214645 RVA: 0x00EAA2C4 File Offset: 0x00EA84C4
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

		// Token: 0x06034676 RID: 214646 RVA: 0x00EAA338 File Offset: 0x00EA8538
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

		// Token: 0x06034677 RID: 214647 RVA: 0x00EAA350 File Offset: 0x00EA8550
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

		// Token: 0x06034678 RID: 214648 RVA: 0x00EAA3B0 File Offset: 0x00EA85B0
		public override bool GetExDataRedPointShowState()
		{
			return this.IsMainHubEntranceHasRedDot();
		}

		// Token: 0x06034679 RID: 214649 RVA: 0x00EAA3B8 File Offset: 0x00EA85B8
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

		// Token: 0x0603467A RID: 214650 RVA: 0x00EAA42C File Offset: 0x00EA862C
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

		// Token: 0x0603467B RID: 214651 RVA: 0x00EAA4A8 File Offset: 0x00EA86A8
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

		// Token: 0x0603467C RID: 214652 RVA: 0x00EAA52C File Offset: 0x00EA872C
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

		// Token: 0x0603467D RID: 214653 RVA: 0x00EAA594 File Offset: 0x00EA8794
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

		// Token: 0x0603467E RID: 214654 RVA: 0x00EAA5FC File Offset: 0x00EA87FC
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

		// Token: 0x0603467F RID: 214655 RVA: 0x00EAA664 File Offset: 0x00EA8864
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

		// Token: 0x06034680 RID: 214656 RVA: 0x00EAA6C4 File Offset: 0x00EA88C4
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

		// Token: 0x06034681 RID: 214657 RVA: 0x00EAA748 File Offset: 0x00EA8948
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

		// Token: 0x06034682 RID: 214658 RVA: 0x00EAA7FC File Offset: 0x00EA89FC
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

		// Token: 0x06034683 RID: 214659 RVA: 0x00EAA878 File Offset: 0x00EA8A78
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

		// Token: 0x06034684 RID: 214660 RVA: 0x00EAA8F4 File Offset: 0x00EA8AF4
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

		// Token: 0x06034685 RID: 214661 RVA: 0x00EAA946 File Offset: 0x00EA8B46
		private void SortAndUpdateInternalRank()
		{
			this.SortAndUpdateRank(this.RankDataList);
		}

		// Token: 0x06034686 RID: 214662 RVA: 0x00EAA954 File Offset: 0x00EA8B54
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

		// Token: 0x06034687 RID: 214663 RVA: 0x00EAA9D8 File Offset: 0x00EA8BD8
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

		// Token: 0x06034688 RID: 214664 RVA: 0x00EAAAB8 File Offset: 0x00EA8CB8
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

		// Token: 0x06034689 RID: 214665 RVA: 0x00EAAB58 File Offset: 0x00EA8D58
		[NullableContext(2)]
		public void SetMyRankData(Aki.Protocol.PinballRankData rankData)
		{
			this.MyRankData = new global::PinballRankData(true);
			this.MyRankData.SetMyRankData(rankData);
		}

		// Token: 0x0603468A RID: 214666 RVA: 0x00EAAB72 File Offset: 0x00EA8D72
		[NullableContext(2)]
		public global::PinballRankData GetMyRankData()
		{
			return this.MyRankData;
		}

		// Token: 0x0603468B RID: 214667 RVA: 0x00EAAB7C File Offset: 0x00EA8D7C
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

		// Token: 0x0603468C RID: 214668 RVA: 0x00EAAC60 File Offset: 0x00EA8E60
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

		// Token: 0x0603468D RID: 214669 RVA: 0x00EAACB0 File Offset: 0x00EA8EB0
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

		// Token: 0x0603468E RID: 214670 RVA: 0x00EAAD84 File Offset: 0x00EA8F84
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

		// Token: 0x0603468F RID: 214671 RVA: 0x00EAAE00 File Offset: 0x00EA9000
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

		// Token: 0x06034690 RID: 214672 RVA: 0x00EAAE9C File Offset: 0x00EA909C
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

		// Token: 0x06034691 RID: 214673 RVA: 0x00EAAF08 File Offset: 0x00EA9108
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

		// Token: 0x06034692 RID: 214674 RVA: 0x00EAAFA4 File Offset: 0x00EA91A4
		public void UpDateLevelFormationData(GroupFormation data)
		{
			int[] array = new int[data.RoleIds.Count];
			for (int i = 0; i < data.RoleIds.Count; i++)
			{
				array[i] = data.RoleIds[i];
			}
			this.LevelFormationMap[data.LevelGroup] = array;
		}

		// Token: 0x06034693 RID: 214675 RVA: 0x00EAAFF9 File Offset: 0x00EA91F9
		public string GetRecommendTaskTips()
		{
			return "Pinball_Activity_RecommendTaskTips";
		}

		// Token: 0x06034694 RID: 214676 RVA: 0x00EAB000 File Offset: 0x00EA9200
		public int GetRecommendTaskId()
		{
			if (ConfigPinballActivityByActivityId.GetConfig(base.Id, true) == null)
			{
				return 0;
			}
			PinballActivity? pinballActivity;
			return pinballActivity.GetValueOrDefault().RecommendTaskId;
		}

		// Token: 0x06034695 RID: 214677 RVA: 0x00EAB034 File Offset: 0x00EA9234
		public bool IsRecommendTaskFinished()
		{
			int recommendTaskId = this.GetRecommendTaskId();
			return recommendTaskId == 0 || QuestNewModel.Instance.CheckQuestFinished(recommendTaskId);
		}

		// Token: 0x06034696 RID: 214678 RVA: 0x00EAB058 File Offset: 0x00EA9258
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

		// Token: 0x06034697 RID: 214679 RVA: 0x00EAB0BC File Offset: 0x00EA92BC
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

		// Token: 0x06034698 RID: 214680 RVA: 0x00EAB148 File Offset: 0x00EA9348
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

		// Token: 0x06034699 RID: 214681 RVA: 0x00EAB20C File Offset: 0x00EA940C
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

		// Token: 0x0603469A RID: 214682 RVA: 0x00EAB288 File Offset: 0x00EA9488
		public int GetRoleWeaponMaxQuality(int roleId)
		{
			int result;
			this.RoleWeaponMaxQualityMap.TryGetValue(roleId, out result);
			return result;
		}

		// Token: 0x0603469B RID: 214683 RVA: 0x00EAB2A5 File Offset: 0x00EA94A5
		public bool GetRoleWeaponRedDot(int roleId)
		{
			return this.GetRoleWeaponMaxQuality(roleId) > 0;
		}

		// Token: 0x0401BD33 RID: 113971
		private readonly Dictionary<int, PinballWeaponData> WeaponDataMap = new Dictionary<int, PinballWeaponData>();

		// Token: 0x0401BD34 RID: 113972
		protected Dictionary<int, PinballRoleDataBase> RoleDataMap = new Dictionary<int, PinballRoleDataBase>();

		// Token: 0x0401BD35 RID: 113973
		private readonly Dictionary<int, int> RoleWeaponMaxQualityMap = new Dictionary<int, int>();

		// Token: 0x0401BD36 RID: 113974
		private readonly Dictionary<int, int> CommonTypeMaxQualityMap = new Dictionary<int, int>();

		// Token: 0x0401BD37 RID: 113975
		private readonly Dictionary<int, int> PersonTypeMaxQualityMap = new Dictionary<int, int>();

		// Token: 0x0401BD38 RID: 113976
		private readonly Dictionary<int, global::PinballChapterData> ChapterMap = new Dictionary<int, global::PinballChapterData>();

		// Token: 0x0401BD39 RID: 113977
		private readonly Dictionary<int, bool> ChapterUnlockRecord = new Dictionary<int, bool>();

		// Token: 0x0401BD3A RID: 113978
		private readonly Dictionary<int, bool> ChapterNewUnlockRecord = new Dictionary<int, bool>();

		// Token: 0x0401BD3B RID: 113979
		private List<int> GmUnlockChapterIdList = new List<int>();

		// Token: 0x0401BD3C RID: 113980
		private readonly Dictionary<int, PinballLevelRecordData> LevelRecordMap = new Dictionary<int, PinballLevelRecordData>();

		// Token: 0x0401BD3D RID: 113981
		private int DailyConfigId;

		// Token: 0x0401BD3E RID: 113982
		private int RandomDailyLevelId;

		// Token: 0x0401BD3F RID: 113983
		private List<int> GmUnlockLevelIdList = new List<int>();

		// Token: 0x0401BD40 RID: 113984
		private readonly Dictionary<int, PinballTaskData> TaskDataMap = new Dictionary<int, PinballTaskData>();

		// Token: 0x0401BD41 RID: 113985
		private readonly Dictionary<int, PinballTaskData> TimeLimitTaskDataMap = new Dictionary<int, PinballTaskData>();

		// Token: 0x0401BD42 RID: 113986
		private readonly Dictionary<int, PinballTaskData> PermanentTaskDataMap = new Dictionary<int, PinballTaskData>();

		// Token: 0x0401BD43 RID: 113987
		public int ShopId;

		// Token: 0x0401BD44 RID: 113988
		private const int DEFAULT_SHOP_ID = 5;

		// Token: 0x0401BD45 RID: 113989
		private readonly List<global::PinballRankData> RankDataList = new List<global::PinballRankData>();

		// Token: 0x0401BD46 RID: 113990
		[Nullable(2)]
		private global::PinballRankData MyRankData;

		// Token: 0x0401BD47 RID: 113991
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<global::PinballRankData> ConfigRankList;

		// Token: 0x0401BD48 RID: 113992
		public Dictionary<int, int[]> LevelFormationMap = new Dictionary<int, int[]>();

		// Token: 0x0200AE7E RID: 44670
		[NullableContext(0)]
		private enum EStorageKey
		{
			// Token: 0x04035E89 RID: 220809
			ChapterRedDot
		}
	}
}
