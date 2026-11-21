using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058C6 RID: 22726
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolActivityData : ActivityBaseData
	{
		// Token: 0x06037F54 RID: 229204 RVA: 0x00FA4704 File Offset: 0x00FA2904
		protected override void PhraseEx(ActivityData data)
		{
			if (data.SolarSchoolActivityPb == null)
			{
				return;
			}
			this.RedDotData = SolarSchoolUtils.LoadRedDotData(base.Id);
			this.PhraseTaskInfo(data);
			this.PhraseGalleryInfo(data);
			this.PhraseSavePreview(data);
			this.IsUnlockGallery = data.SolarSchoolActivityPb.GalleryEntryUnlocked;
			this.IsGetLimitTaskProgressReward = data.SolarSchoolActivityPb.LimitTaskProgressRewarded;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, base.Id);
		}

		// Token: 0x06037F55 RID: 229205 RVA: 0x00FA4790 File Offset: 0x00FA2990
		private void PhraseSavePreview(ActivityData data)
		{
			this.SavePreviewMap.Clear();
			if (data.SolarSchoolActivityPb.SavePreview == null)
			{
				return;
			}
			foreach (SolarSchoolSavePreviewPb solarSchoolSavePreviewPb in data.SolarSchoolActivityPb.SavePreview)
			{
				this.SavePreviewMap[solarSchoolSavePreviewPb.SlotId] = solarSchoolSavePreviewPb;
			}
		}

		// Token: 0x06037F56 RID: 229206 RVA: 0x00FA4808 File Offset: 0x00FA2A08
		[NullableContext(2)]
		public SolarSchoolSavePreviewPb GetSavePreview(int slotId)
		{
			SolarSchoolSavePreviewPb result;
			if (!this.SavePreviewMap.TryGetValue(slotId, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06037F57 RID: 229207 RVA: 0x00FA4828 File Offset: 0x00FA2A28
		public void UpdateSavePreview(SolarSchoolSavePreviewPb preview)
		{
			this.SavePreviewMap[preview.SlotId] = preview;
		}

		// Token: 0x06037F58 RID: 229208 RVA: 0x00FA483C File Offset: 0x00FA2A3C
		private void PhraseGalleryInfo(ActivityData data)
		{
			if (data.SolarSchoolActivityPb.Gallery == null)
			{
				return;
			}
			this.GalleryDataMap.Clear();
			foreach (SolarSchoolGallery config in ConfigSolarSchoolGalleryAll.GetConfigList(true))
			{
				SolarSchoolGalleryType type = (SolarSchoolGalleryType)config.Type;
				if (!this.GalleryDataMap.ContainsKey(type))
				{
					this.GalleryDataMap.Add(type, new Dictionary<int, SolarSchoolGalleryData>());
				}
				SolarSchoolGalleryData solarSchoolGalleryData = new SolarSchoolGalleryData();
				solarSchoolGalleryData.Config = config;
				this.GalleryDataMap[type].Add(config.Id, solarSchoolGalleryData);
			}
			foreach (SolarSchoolGalleryPb solarSchoolGalleryPb in data.SolarSchoolActivityPb.Gallery)
			{
				SolarSchoolGalleryData solarSchoolGalleryData2 = this.FindGalleryData(solarSchoolGalleryPb.Id);
				if (solarSchoolGalleryData2 != null)
				{
					solarSchoolGalleryData2.IsUnlock = true;
					solarSchoolGalleryData2.IsGetReward = solarSchoolGalleryPb.IsReward;
				}
			}
		}

		// Token: 0x06037F59 RID: 229209 RVA: 0x00FA4954 File Offset: 0x00FA2B54
		[NullableContext(2)]
		private SolarSchoolGalleryData FindGalleryData(int galleryId)
		{
			SolarSchoolGallery? config = ConfigSolarSchoolGalleryById.GetConfig(galleryId, true);
			Dictionary<int, SolarSchoolGalleryData> dictionary;
			SolarSchoolGalleryData result;
			if (config != null && this.GalleryDataMap.TryGetValue((SolarSchoolGalleryType)config.Value.Type, out dictionary) && dictionary.TryGetValue(galleryId, out result))
			{
				return result;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 图鉴 id 本地无配置，已跳过";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("galleryId", galleryId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x06037F5A RID: 229210 RVA: 0x00FA49D0 File Offset: 0x00FA2BD0
		private bool IsTaskConfigExist(int taskId)
		{
			if (ConfigSolarSchoolTaskById.GetConfig(taskId, true) != null)
			{
				return true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 任务 id 本地无配置，已跳过";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("taskId", taskId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}

		// Token: 0x06037F5B RID: 229211 RVA: 0x00FA4A20 File Offset: 0x00FA2C20
		private Dictionary<int, ConditionTask> GetOrCreateTaskMap(SolarSchoolTaskType taskType)
		{
			Dictionary<int, ConditionTask> dictionary;
			if (!this.AllTaskMap.TryGetValue(taskType, out dictionary))
			{
				dictionary = new Dictionary<int, ConditionTask>();
				this.AllTaskMap.Add(taskType, dictionary);
			}
			return dictionary;
		}

		// Token: 0x06037F5C RID: 229212 RVA: 0x00FA4A54 File Offset: 0x00FA2C54
		public void UpdateTaskInfo(IEnumerable<SolarSchoolTaskTypePb> taskList)
		{
			foreach (SolarSchoolTaskTypePb solarSchoolTaskTypePb in taskList)
			{
				Dictionary<int, ConditionTask> orCreateTaskMap = this.GetOrCreateTaskMap(solarSchoolTaskTypePb.TaskType);
				foreach (ConditionTask conditionTask in solarSchoolTaskTypePb.Task)
				{
					if (this.IsTaskConfigExist(conditionTask.Id))
					{
						orCreateTaskMap[conditionTask.Id] = conditionTask;
					}
				}
			}
		}

		// Token: 0x06037F5D RID: 229213 RVA: 0x00FA4AF8 File Offset: 0x00FA2CF8
		public void UpdateGalleryInfo(IEnumerable<SolarSchoolGalleryPb> galleryList)
		{
			foreach (SolarSchoolGalleryPb solarSchoolGalleryPb in galleryList)
			{
				SolarSchoolGalleryData solarSchoolGalleryData = this.FindGalleryData(solarSchoolGalleryPb.Id);
				if (solarSchoolGalleryData != null)
				{
					solarSchoolGalleryData.IsGetReward = solarSchoolGalleryPb.IsReward;
					solarSchoolGalleryData.IsUnlock = true;
				}
			}
		}

		// Token: 0x06037F5E RID: 229214 RVA: 0x00FA4B5C File Offset: 0x00FA2D5C
		private void PhraseTaskInfo(ActivityData data)
		{
			if (data.SolarSchoolActivityPb.TaskType == null)
			{
				return;
			}
			this.AllTaskMap.Clear();
			foreach (SolarSchoolTaskTypePb solarSchoolTaskTypePb in data.SolarSchoolActivityPb.TaskType)
			{
				Dictionary<int, ConditionTask> orCreateTaskMap = this.GetOrCreateTaskMap(solarSchoolTaskTypePb.TaskType);
				foreach (ConditionTask conditionTask in solarSchoolTaskTypePb.Task)
				{
					if (this.IsTaskConfigExist(conditionTask.Id))
					{
						orCreateTaskMap.Add(conditionTask.Id, conditionTask);
					}
				}
			}
		}

		// Token: 0x06037F5F RID: 229215 RVA: 0x00FA4C24 File Offset: 0x00FA2E24
		private int GetStatusPriority(ConditionTaskState status)
		{
			switch (status)
			{
			case ConditionTaskState.ConditionTaskRunning:
				return 1;
			case ConditionTaskState.ConditionTaskFinish:
				return 0;
			}
			return 2;
		}

		// Token: 0x06037F60 RID: 229216 RVA: 0x00FA4C40 File Offset: 0x00FA2E40
		public List<ConditionTask> GetTaskList(SolarSchoolTaskType taskType)
		{
			Dictionary<int, ConditionTask> dictionary;
			if (!this.AllTaskMap.TryGetValue(taskType, out dictionary))
			{
				return new List<ConditionTask>();
			}
			List<ConditionTask> list = new List<ConditionTask>(dictionary.Values);
			list.Sort(delegate(ConditionTask a, ConditionTask b)
			{
				int statusPriority = this.GetStatusPriority(a.Status);
				int statusPriority2 = this.GetStatusPriority(b.Status);
				if (statusPriority != statusPriority2)
				{
					return statusPriority - statusPriority2;
				}
				return a.Id - b.Id;
			});
			return list;
		}

		// Token: 0x06037F61 RID: 229217 RVA: 0x00FA4C80 File Offset: 0x00FA2E80
		public List<ConditionTask> GetTaskListBySortId(SolarSchoolTaskType taskType)
		{
			Dictionary<int, ConditionTask> dictionary;
			if (!this.AllTaskMap.TryGetValue(taskType, out dictionary))
			{
				return new List<ConditionTask>();
			}
			List<ConditionTask> list = new List<ConditionTask>(dictionary.Values);
			list.Sort(delegate(ConditionTask a, ConditionTask b)
			{
				int statusPriority = this.GetStatusPriority(a.Status);
				int statusPriority2 = this.GetStatusPriority(b.Status);
				if (statusPriority != statusPriority2)
				{
					return statusPriority - statusPriority2;
				}
				int sortId = ConfigSolarSchoolTaskById.GetConfig(a.Id, true).Value.SortId;
				int sortId2 = ConfigSolarSchoolTaskById.GetConfig(b.Id, true).Value.SortId;
				if (sortId != sortId2)
				{
					return sortId - sortId2;
				}
				return a.Id - b.Id;
			});
			return list;
		}

		// Token: 0x06037F62 RID: 229218 RVA: 0x00FA4CC0 File Offset: 0x00FA2EC0
		public int GetTaskFinishNum(SolarSchoolTaskType taskType)
		{
			Dictionary<int, ConditionTask> dictionary;
			if (!this.AllTaskMap.TryGetValue(taskType, out dictionary))
			{
				return 0;
			}
			int num = 0;
			using (Dictionary<int, ConditionTask>.ValueCollection.Enumerator enumerator = dictionary.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status >= ConditionTaskState.ConditionTaskFinish)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06037F63 RID: 229219 RVA: 0x00FA4D2C File Offset: 0x00FA2F2C
		public List<SolarSchoolGalleryData> GetGalleryDataList(SolarSchoolGalleryType galleryType)
		{
			Dictionary<int, SolarSchoolGalleryData> dictionary;
			if (!this.GalleryDataMap.TryGetValue(galleryType, out dictionary))
			{
				return new List<SolarSchoolGalleryData>();
			}
			List<SolarSchoolGalleryData> list = new List<SolarSchoolGalleryData>(dictionary.Values);
			list.Sort((SolarSchoolGalleryData a, SolarSchoolGalleryData b) => a.Config.SortId - b.Config.SortId);
			return list;
		}

		// Token: 0x06037F64 RID: 229220 RVA: 0x00FA4D80 File Offset: 0x00FA2F80
		public List<SolarSchoolGalleryData> GetUnLockGalleryDataList(SolarSchoolGalleryType galleryType)
		{
			Dictionary<int, SolarSchoolGalleryData> dictionary;
			if (!this.GalleryDataMap.TryGetValue(galleryType, out dictionary))
			{
				return new List<SolarSchoolGalleryData>();
			}
			List<SolarSchoolGalleryData> list = new List<SolarSchoolGalleryData>();
			foreach (SolarSchoolGalleryData solarSchoolGalleryData in dictionary.Values)
			{
				if (solarSchoolGalleryData.IsUnlock)
				{
					list.Add(solarSchoolGalleryData);
				}
			}
			list.Sort((SolarSchoolGalleryData a, SolarSchoolGalleryData b) => a.Config.SortId - b.Config.SortId);
			return list;
		}

		// Token: 0x06037F65 RID: 229221 RVA: 0x00FA4E20 File Offset: 0x00FA3020
		public string GetAllGalleryNumText()
		{
			int num = 0;
			int num2 = 0;
			foreach (Dictionary<int, SolarSchoolGalleryData> dictionary in this.GalleryDataMap.Values)
			{
				num += dictionary.Values.Count;
				using (Dictionary<int, SolarSchoolGalleryData>.ValueCollection.Enumerator enumerator2 = dictionary.Values.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.IsUnlock)
						{
							num2++;
						}
					}
				}
			}
			return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("SolarSchoolRewardCounting", null), new string[]
			{
				num2.ToString(),
				num.ToString()
			});
		}

		// Token: 0x06037F66 RID: 229222 RVA: 0x00FA4EF4 File Offset: 0x00FA30F4
		public string GetAllGalleryNumTextByType(SolarSchoolGalleryType galleryType)
		{
			Dictionary<int, SolarSchoolGalleryData> dictionary;
			this.GalleryDataMap.TryGetValue(galleryType, out dictionary);
			int num = (dictionary != null) ? dictionary.Values.Count : 0;
			int num2 = 0;
			if (dictionary != null)
			{
				using (Dictionary<int, SolarSchoolGalleryData>.ValueCollection.Enumerator enumerator = dictionary.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.IsUnlock)
						{
							num2++;
						}
					}
				}
			}
			return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("SolarSchoolRewardCounting", null), new string[]
			{
				num2.ToString(),
				num.ToString()
			});
		}

		// Token: 0x06037F67 RID: 229223 RVA: 0x00FA4F9C File Offset: 0x00FA319C
		public bool IsEndingUnlocked(int endingId)
		{
			Dictionary<int, SolarSchoolGalleryData> dictionary;
			if (!this.GalleryDataMap.TryGetValue(SolarSchoolGalleryType.Ending, out dictionary))
			{
				return false;
			}
			foreach (SolarSchoolGalleryData solarSchoolGalleryData in dictionary.Values)
			{
				if (solarSchoolGalleryData.Config.Param == endingId)
				{
					return solarSchoolGalleryData.IsUnlock;
				}
			}
			return false;
		}

		// Token: 0x06037F68 RID: 229224 RVA: 0x00FA5014 File Offset: 0x00FA3214
		public int GetGalleryTotalNumByType(SolarSchoolGalleryType galleryType)
		{
			Dictionary<int, SolarSchoolGalleryData> dictionary;
			this.GalleryDataMap.TryGetValue(galleryType, out dictionary);
			if (dictionary == null)
			{
				return 0;
			}
			return dictionary.Count;
		}

		// Token: 0x06037F69 RID: 229225 RVA: 0x00FA503C File Offset: 0x00FA323C
		public int GetGalleryUnlockNumByType(SolarSchoolGalleryType galleryType)
		{
			Dictionary<int, SolarSchoolGalleryData> dictionary;
			this.GalleryDataMap.TryGetValue(galleryType, out dictionary);
			if (dictionary == null)
			{
				return 0;
			}
			int num = 0;
			using (Dictionary<int, SolarSchoolGalleryData>.ValueCollection.Enumerator enumerator = dictionary.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnlock)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06037F6A RID: 229226 RVA: 0x00FA50AC File Offset: 0x00FA32AC
		public bool GetStartBtnRedDotState()
		{
			return base.IsUnLock() && !this.IsStartBtnClicked();
		}

		// Token: 0x06037F6B RID: 229227 RVA: 0x00FA50C1 File Offset: 0x00FA32C1
		public void ClearStartBtnRedDot()
		{
			if (this.IsStartBtnClicked())
			{
				return;
			}
			ActivityModel.Instance.SaveActivityDataByKey(base.Id, 1, 1);
		}

		// Token: 0x06037F6C RID: 229228 RVA: 0x00FA50DE File Offset: 0x00FA32DE
		private bool IsStartBtnClicked()
		{
			return ActivityModel.Instance.GetActivityCacheDataByKey(base.Id, 0, 1) != 0;
		}

		// Token: 0x06037F6D RID: 229229 RVA: 0x00FA50F5 File Offset: 0x00FA32F5
		public bool GetFirstOpenRedDotState()
		{
			return base.GetIfFirstOpen();
		}

		// Token: 0x06037F6E RID: 229230 RVA: 0x00FA50FD File Offset: 0x00FA32FD
		public void ClearFirstOpenRedDot()
		{
			if (!base.GetIfFirstOpen())
			{
				return;
			}
			ActivityController.Instance.RequestReadActivity(this);
		}

		// Token: 0x06037F6F RID: 229231 RVA: 0x00FA5113 File Offset: 0x00FA3313
		public bool GetGoEntranceRedDotState()
		{
			return base.IsUnLock() && !this.RedDotData.GoEntranceRedDotConsumed;
		}

		// Token: 0x06037F70 RID: 229232 RVA: 0x00FA512D File Offset: 0x00FA332D
		public void ClearGoEntranceRedDot()
		{
			if (!this.GetGoEntranceRedDotState())
			{
				return;
			}
			this.RedDotData.GoEntranceRedDotConsumed = true;
			SolarSchoolUtils.SaveRedDotData(base.Id, this.RedDotData);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06037F71 RID: 229233 RVA: 0x00FA516C File Offset: 0x00FA336C
		public override bool NeedSelfControlFirstRedPoint()
		{
			return true;
		}

		// Token: 0x06037F72 RID: 229234 RVA: 0x00FA516F File Offset: 0x00FA336F
		public bool IsGalleryViewed(int galleryId)
		{
			return this.RedDotData.ViewedGalleryIds.Contains(galleryId);
		}

		// Token: 0x06037F73 RID: 229235 RVA: 0x00FA5182 File Offset: 0x00FA3382
		public void SetGalleryViewed(int galleryId)
		{
			if (!this.RedDotData.ViewedGalleryIds.Add(galleryId))
			{
				return;
			}
			SolarSchoolUtils.SaveRedDotData(base.Id, this.RedDotData);
			EventSystem.Instance.Emit(EEventName.SolarSchoolGalleryViewedUpdate);
		}

		// Token: 0x06037F74 RID: 229236 RVA: 0x00FA51BA File Offset: 0x00FA33BA
		public bool IsGalleryTabAcked(int galleryId)
		{
			return this.RedDotData.TabAckedGalleryIds.Contains(galleryId);
		}

		// Token: 0x06037F75 RID: 229237 RVA: 0x00FA51D0 File Offset: 0x00FA33D0
		public bool AckGalleryTab(SolarSchoolGalleryType galleryType)
		{
			Dictionary<int, SolarSchoolGalleryData> dictionary;
			if (!this.GalleryDataMap.TryGetValue(galleryType, out dictionary))
			{
				return false;
			}
			bool flag = false;
			foreach (SolarSchoolGalleryData solarSchoolGalleryData in dictionary.Values)
			{
				if (solarSchoolGalleryData.IsUnlock && this.RedDotData.TabAckedGalleryIds.Add(solarSchoolGalleryData.Config.Id))
				{
					flag = true;
				}
			}
			if (flag)
			{
				SolarSchoolUtils.SaveRedDotData(base.Id, this.RedDotData);
				this.EmitGalleryRedDotChanged();
			}
			return flag;
		}

		// Token: 0x06037F76 RID: 229238 RVA: 0x00FA5274 File Offset: 0x00FA3474
		public bool HasUnackedGalleryItem(SolarSchoolGalleryType galleryType)
		{
			Dictionary<int, SolarSchoolGalleryData> dictionary;
			if (!this.GalleryDataMap.TryGetValue(galleryType, out dictionary))
			{
				return false;
			}
			foreach (SolarSchoolGalleryData solarSchoolGalleryData in dictionary.Values)
			{
				if (solarSchoolGalleryData.IsUnlock && !this.IsGalleryTabAcked(solarSchoolGalleryData.Config.Id))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06037F77 RID: 229239 RVA: 0x00FA52F4 File Offset: 0x00FA34F4
		public bool HasAnyGalleryRedDot()
		{
			return this.IsUnlockGallery && (this.GetGalleryHasReward(SolarSchoolGalleryType.Ending) || this.HasUnackedGalleryItem(SolarSchoolGalleryType.Cg) || this.HasUnackedGalleryItem(SolarSchoolGalleryType.Op));
		}

		// Token: 0x06037F78 RID: 229240 RVA: 0x00FA531B File Offset: 0x00FA351B
		private void EmitGalleryRedDotChanged()
		{
			EventSystem.Instance.Emit(EEventName.SolarSchoolGalleryUpdate);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06037F79 RID: 229241 RVA: 0x00FA5344 File Offset: 0x00FA3544
		public bool GetTaskHasReward(SolarSchoolTaskType taskType)
		{
			Dictionary<int, ConditionTask> dictionary;
			if (!this.AllTaskMap.TryGetValue(taskType, out dictionary))
			{
				return false;
			}
			using (Dictionary<int, ConditionTask>.ValueCollection.Enumerator enumerator = dictionary.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == ConditionTaskState.ConditionTaskFinish)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06037F7A RID: 229242 RVA: 0x00FA53B0 File Offset: 0x00FA35B0
		public bool HasLimitProgressReward()
		{
			if (this.IsGetLimitTaskProgressReward)
			{
				return false;
			}
			SolarSchoolActivity? config = ConfigSolarSchoolActivityById.GetConfig(base.Id, true);
			return config != null && this.GetTaskFinishNum(SolarSchoolTaskType.SolarSchoolLimited) >= config.Value.LimitAccNeedNum;
		}

		// Token: 0x06037F7B RID: 229243 RVA: 0x00FA53FA File Offset: 0x00FA35FA
		public bool HasLimitTimeReward()
		{
			return this.GetTaskHasReward(SolarSchoolTaskType.SolarSchoolLimited) || this.HasLimitProgressReward();
		}

		// Token: 0x06037F7C RID: 229244 RVA: 0x00FA5410 File Offset: 0x00FA3610
		public bool GetGalleryHasReward(SolarSchoolGalleryType galleryType)
		{
			Dictionary<int, SolarSchoolGalleryData> dictionary;
			if (!this.GalleryDataMap.TryGetValue(galleryType, out dictionary))
			{
				return false;
			}
			foreach (SolarSchoolGalleryData solarSchoolGalleryData in dictionary.Values)
			{
				if (solarSchoolGalleryData != null && solarSchoolGalleryData.IsUnlock && !solarSchoolGalleryData.IsGetReward)
				{
					SolarSchoolGallery config = solarSchoolGalleryData.Config;
					if (config.DropId > 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06037F7D RID: 229245 RVA: 0x00FA549C File Offset: 0x00FA369C
		public override bool GetExDataRedPointShowState()
		{
			if (this.GetGoEntranceRedDotState() || this.HasLimitProgressReward())
			{
				return true;
			}
			foreach (SolarSchoolTaskType taskType in Enum.GetValues<SolarSchoolTaskType>())
			{
				if (this.GetTaskHasReward(taskType))
				{
					return true;
				}
			}
			return this.GetGalleryHasReward(SolarSchoolGalleryType.Ending);
		}

		// Token: 0x06037F7E RID: 229246 RVA: 0x00FA54E8 File Offset: 0x00FA36E8
		public bool GetTaskRewardIsAllFinish(SolarSchoolTaskType taskType)
		{
			Dictionary<int, ConditionTask> dictionary;
			if (!this.AllTaskMap.TryGetValue(taskType, out dictionary))
			{
				return false;
			}
			int num = 0;
			using (Dictionary<int, ConditionTask>.ValueCollection.Enumerator enumerator = dictionary.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == ConditionTaskState.ConditionTaskTaken)
					{
						num++;
					}
				}
			}
			return num == dictionary.Count;
		}

		// Token: 0x06037F7F RID: 229247 RVA: 0x00FA555C File Offset: 0x00FA375C
		public bool GetGalleryRewardIsAllFinish(SolarSchoolGalleryType galleryType)
		{
			Dictionary<int, SolarSchoolGalleryData> dictionary;
			if (!this.GalleryDataMap.TryGetValue(galleryType, out dictionary))
			{
				return false;
			}
			int num = 0;
			foreach (SolarSchoolGalleryData solarSchoolGalleryData in dictionary.Values)
			{
				if (solarSchoolGalleryData == null || !solarSchoolGalleryData.IsUnlock)
				{
					goto IL_6F;
				}
				SolarSchoolGallery config;
				int dropId;
				if (!solarSchoolGalleryData.IsGetReward)
				{
					config = solarSchoolGalleryData.Config;
					dropId = config.DropId;
					goto IL_66;
				}
				config = solarSchoolGalleryData.Config;
				dropId = config.DropId;
				if (dropId <= 0)
				{
					goto IL_66;
				}
				IL_6A:
				bool flag = true;
				goto IL_72;
				IL_66:
				if (dropId == 0)
				{
					goto IL_6A;
				}
				goto IL_6F;
				IL_72:
				if (flag)
				{
					num++;
					continue;
				}
				continue;
				IL_6F:
				flag = false;
				goto IL_72;
			}
			return num == dictionary.Values.Count;
		}

		// Token: 0x06037F80 RID: 229248 RVA: 0x00FA561C File Offset: 0x00FA381C
		protected override bool GetExDataFinishShowState()
		{
			bool flag = true;
			bool flag2 = base.CheckIfInRewardTime();
			foreach (SolarSchoolTaskType solarSchoolTaskType in Enum.GetValues<SolarSchoolTaskType>())
			{
				if ((solarSchoolTaskType != SolarSchoolTaskType.SolarSchoolLimited || flag2) && !this.GetTaskRewardIsAllFinish(solarSchoolTaskType))
				{
					flag = false;
					break;
				}
			}
			bool flag3 = true;
			foreach (SolarSchoolGalleryType galleryType in Enum.GetValues<SolarSchoolGalleryType>())
			{
				if (!this.GetGalleryRewardIsAllFinish(galleryType))
				{
					flag3 = false;
					break;
				}
			}
			return flag && flag3;
		}

		// Token: 0x06037F81 RID: 229249 RVA: 0x00FA569C File Offset: 0x00FA389C
		public string GetAllFinishTaskNumTextByType(SolarSchoolTaskType taskType)
		{
			Dictionary<int, ConditionTask> dictionary;
			this.AllTaskMap.TryGetValue(taskType, out dictionary);
			int taskFinishNum = this.GetTaskFinishNum(taskType);
			int num = (dictionary != null) ? dictionary.Count : 0;
			return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("SolarSchoolRewardCounting", null), new string[]
			{
				taskFinishNum.ToString(),
				num.ToString()
			});
		}

		// Token: 0x0401D84F RID: 120911
		private readonly Dictionary<SolarSchoolTaskType, Dictionary<int, ConditionTask>> AllTaskMap = new Dictionary<SolarSchoolTaskType, Dictionary<int, ConditionTask>>();

		// Token: 0x0401D850 RID: 120912
		private readonly Dictionary<SolarSchoolGalleryType, Dictionary<int, SolarSchoolGalleryData>> GalleryDataMap = new Dictionary<SolarSchoolGalleryType, Dictionary<int, SolarSchoolGalleryData>>();

		// Token: 0x0401D851 RID: 120913
		private readonly Dictionary<int, SolarSchoolSavePreviewPb> SavePreviewMap = new Dictionary<int, SolarSchoolSavePreviewPb>();

		// Token: 0x0401D852 RID: 120914
		private SolarSchoolRedDotLocalData RedDotData = new SolarSchoolRedDotLocalData();

		// Token: 0x0401D853 RID: 120915
		public bool IsUnlockGallery;

		// Token: 0x0401D854 RID: 120916
		public bool IsGetLimitTaskProgressReward;

		// Token: 0x0200B4AA RID: 46250
		[NullableContext(0)]
		private enum ESolarSchoolStorageKey
		{
			// Token: 0x04037DED RID: 228845
			StartBtnClicked = 1
		}
	}
}
