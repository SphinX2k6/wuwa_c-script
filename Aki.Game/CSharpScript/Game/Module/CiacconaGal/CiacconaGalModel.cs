using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004B9E RID: 19358
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class CiacconaGalModel : ModelBase
	{
		// Token: 0x170060D0 RID: 24784
		// (get) Token: 0x06030560 RID: 197984 RVA: 0x00D7A037 File Offset: 0x00D78237
		public CiacconaGalActivityData ActivityData
		{
			get
			{
				return this.ActivityDataInternal ?? this.GetActivityDataById(104800001);
			}
		}

		// Token: 0x06030561 RID: 197985 RVA: 0x00D7A04E File Offset: 0x00D7824E
		protected override bool OnClear()
		{
			this.IsCurStepDataListDirty = false;
			this.DataUpdateMask = 0;
			this.DataMap.Clear();
			this.CurStepDataList.Clear();
			this.ActivityDataInternal = null;
			return true;
		}

		// Token: 0x06030562 RID: 197986 RVA: 0x00D7A07C File Offset: 0x00D7827C
		[NullableContext(0)]
		[return: Nullable(2)]
		private TData GetOrCreateData<[Nullable(1)] TData, TConfig>(int id, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] Func<TConfig, TData> ctor) where TData : class where TConfig : struct
		{
			TConfig? tconfig = null;
			Type typeFromHandle = typeof(TData);
			if (typeFromHandle == typeof(CiacconaGalChapterData))
			{
				tconfig = (ConfigCiacconaGalChapterById.GetConfig(id, true) as TConfig?);
			}
			else if (typeFromHandle == typeof(CiacconaGalEndingData))
			{
				tconfig = (ConfigCiacconaGalEndingById.GetConfig(id, true) as TConfig?);
			}
			else if (typeFromHandle == typeof(CiacconaGalSubEndingData))
			{
				tconfig = (ConfigCiacconaGalSubEndingById.GetConfig(id, true) as TConfig?);
			}
			else if (typeFromHandle == typeof(CiacconaGalStepData))
			{
				tconfig = (ConfigCiacconaGalStepById.GetConfig(id, true) as TConfig?);
			}
			else if (typeFromHandle == typeof(CiacconaGalChoiceData))
			{
				tconfig = (ConfigCiacconaGalChoiceById.GetConfig(id, true) as TConfig?);
			}
			else if (typeFromHandle == typeof(CiacconaGalChapterSlotData))
			{
				tconfig = (ConfigCiacconaChapterSlotById.GetConfig(id, true) as TConfig?);
			}
			else if (typeFromHandle == typeof(CiacconaGalActivityData))
			{
				tconfig = (ConfigCiacconaActivityConfigById.GetConfig(id, true) as TConfig?);
			}
			else if (typeFromHandle == typeof(CiacconaGalRewardData))
			{
				tconfig = (ConfigCiacconaActivityRewardById.GetConfig(id, true) as TConfig?);
			}
			if (tconfig == null)
			{
				return default(TData);
			}
			Dictionary<int, object> dictionary;
			if (!this.DataMap.TryGetValue(typeFromHandle, out dictionary))
			{
				dictionary = new Dictionary<int, object>();
				this.DataMap.Add(typeFromHandle, dictionary);
			}
			object obj;
			if (!dictionary.TryGetValue(id, out obj))
			{
				obj = ctor(tconfig.Value);
				dictionary.Add(id, obj);
			}
			return obj as TData;
		}

		// Token: 0x06030563 RID: 197987 RVA: 0x00D7A268 File Offset: 0x00D78468
		[NullableContext(1)]
		public void UpdateByServerActivityData(ActivityData data, int activityId)
		{
			CiacconaActivityPbData ciacconaActivityPbData = data.CiacconaActivityPbData;
			if (ciacconaActivityPbData == null)
			{
				Log.Instance.Error(ELogModule.CiacconaGal, ELogAuthor.HYF, "夏空活动服务器数据异常", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.UpdateAllChapterData(ciacconaActivityPbData.ChapterDatas);
			this.UpdateAllEndingData(ciacconaActivityPbData.ActivityResultDatas);
			this.UpdateProgressRewardData(ciacconaActivityPbData.ScheduleRewardDatas);
			this.ActivityDataInternal = this.GetActivityDataById(activityId);
			this.ActivityDataInternal.UpdateByServerData(ciacconaActivityPbData);
			this.ActivityDataInternal.UpdateEndTime(data.EndShowTime);
			this.DataUpdateMask = -1;
		}

		// Token: 0x06030564 RID: 197988 RVA: 0x00D7A2F4 File Offset: 0x00D784F4
		[NullableContext(1)]
		public void UpdateAllChapterData(IReadOnlyList<CiacconaChapterPbData> dataList)
		{
			foreach (CiacconaChapterPbData ciacconaChapterPbData in dataList)
			{
				this.GetChapterDataById(ciacconaChapterPbData.CharacterId).UpdateByServerData(ciacconaChapterPbData);
				foreach (CiacconaChapterChoicePbData ciacconaChapterChoicePbData in ciacconaChapterPbData.ChoiceDatas)
				{
					this.GetChoiceDataById(ciacconaChapterChoicePbData.ChoiceId).UpdateByServerData(ciacconaChapterPbData);
				}
				foreach (CiacconaChapterResultPbData ciacconaChapterResultPbData in ciacconaChapterPbData.ResultDatas)
				{
					this.GetSubEndingDataById(ciacconaChapterResultPbData.ResultId).UpdateByServerData(ciacconaChapterResultPbData);
				}
			}
			this.DataUpdateMask |= 1;
		}

		// Token: 0x06030565 RID: 197989 RVA: 0x00D7A3F4 File Offset: 0x00D785F4
		[NullableContext(1)]
		public void UpdateAllEndingData(IReadOnlyList<CiacconaActivityResultPbData> dataList)
		{
			foreach (CiacconaActivityResultPbData ciacconaActivityResultPbData in dataList)
			{
				this.GetEndingDataById(ciacconaActivityResultPbData.ResultId).UpdateByServerData(ciacconaActivityResultPbData);
			}
			this.DataUpdateMask |= 8;
		}

		// Token: 0x06030566 RID: 197990 RVA: 0x00D7A458 File Offset: 0x00D78658
		[NullableContext(1)]
		public void UpdateProgressRewardData(IReadOnlyList<CiacconaScheduleRewardPbData> dataList)
		{
			foreach (CiacconaScheduleRewardPbData ciacconaScheduleRewardPbData in dataList)
			{
				this.GetRewardDataById(ciacconaScheduleRewardPbData.RewardId).UpdateByServerData(ciacconaScheduleRewardPbData);
			}
			this.DataUpdateMask |= 4;
		}

		// Token: 0x06030567 RID: 197991 RVA: 0x00D7A4BC File Offset: 0x00D786BC
		public void UpdateInspirationData(CiacconaInspirationPbData data)
		{
			if (data == null)
			{
				return;
			}
			CiacconaGalActivityData activityDataInternal = this.ActivityDataInternal;
			if (activityDataInternal != null)
			{
				activityDataInternal.UpdateInspirationData(data);
			}
			this.DataUpdateMask |= 2;
		}

		// Token: 0x06030568 RID: 197992 RVA: 0x00D7A4E2 File Offset: 0x00D786E2
		[NullableContext(1)]
		public void UpdateActivityState(CiacconaActivityStateUnlockUpdateNotify data)
		{
			CiacconaGalActivityData activityDataInternal = this.ActivityDataInternal;
			if (activityDataInternal != null)
			{
				activityDataInternal.UpdateState(data);
			}
			this.DataUpdateMask |= 16;
		}

		// Token: 0x06030569 RID: 197993 RVA: 0x00D7A505 File Offset: 0x00D78705
		public CiacconaGalChapterData GetChapterDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalChapterData, CiacconaGalChapter>(id, (CiacconaGalChapter config) => new CiacconaGalChapterData(config));
		}

		// Token: 0x0603056A RID: 197994 RVA: 0x00D7A52D File Offset: 0x00D7872D
		public CiacconaGalChoiceData GetChoiceDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalChoiceData, CiacconaGalChoice>(id, (CiacconaGalChoice config) => new CiacconaGalChoiceData(config));
		}

		// Token: 0x0603056B RID: 197995 RVA: 0x00D7A555 File Offset: 0x00D78755
		public CiacconaGalEndingData GetEndingDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalEndingData, CiacconaGalEnding>(id, (CiacconaGalEnding config) => new CiacconaGalEndingData(config));
		}

		// Token: 0x0603056C RID: 197996 RVA: 0x00D7A57D File Offset: 0x00D7877D
		public CiacconaGalStepData GetStepDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalStepData, CiacconaGalStep>(id, (CiacconaGalStep config) => new CiacconaGalStepData(config));
		}

		// Token: 0x0603056D RID: 197997 RVA: 0x00D7A5A5 File Offset: 0x00D787A5
		[NullableContext(1)]
		public CiacconaGalEndingData[] GetAllEndingDataList()
		{
			return NoLinq.SelectToArray<CiacconaGalEnding, CiacconaGalEndingData>(ConfigCiacconaGalEndingAll.GetConfigList(true), (CiacconaGalEnding cfg) => this.GetOrCreateData<CiacconaGalEndingData, CiacconaGalEnding>(cfg.Id, (CiacconaGalEnding config) => new CiacconaGalEndingData(config)));
		}

		// Token: 0x0603056E RID: 197998 RVA: 0x00D7A5BE File Offset: 0x00D787BE
		public CiacconaGalSubEndingData GetSubEndingDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalSubEndingData, CiacconaGalSubEnding>(id, (CiacconaGalSubEnding config) => new CiacconaGalSubEndingData(config));
		}

		// Token: 0x0603056F RID: 197999 RVA: 0x00D7A5E6 File Offset: 0x00D787E6
		public CiacconaGalChapterSlotData GetChapterSlotDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalChapterSlotData, CiacconaChapterSlot>(id, (CiacconaChapterSlot config) => new CiacconaGalChapterSlotData(config));
		}

		// Token: 0x06030570 RID: 198000 RVA: 0x00D7A60E File Offset: 0x00D7880E
		public CiacconaGalActivityData GetActivityDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalActivityData, CiacconaActivityConfig>(id, (CiacconaActivityConfig config) => new CiacconaGalActivityData(config));
		}

		// Token: 0x06030571 RID: 198001 RVA: 0x00D7A636 File Offset: 0x00D78836
		public CiacconaGalRewardData GetRewardDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalRewardData, CiacconaActivityReward>(id, (CiacconaActivityReward config) => new CiacconaGalRewardData(config));
		}

		// Token: 0x06030572 RID: 198002 RVA: 0x00D7A660 File Offset: 0x00D78860
		[NullableContext(1)]
		public CiacconaGalRewardData[] GetAllRewardDataByActivityId(int activityId)
		{
			return NoLinq.WhereSelectToArray<CiacconaActivityReward, CiacconaGalRewardData>(ConfigCiacconaActivityRewardAll.GetConfigList(true), (CiacconaActivityReward cfg) => cfg.ActivityId == activityId, (CiacconaActivityReward cfg) => this.GetOrCreateData<CiacconaGalRewardData, CiacconaActivityReward>(cfg.Id, (CiacconaActivityReward config) => new CiacconaGalRewardData(config)));
		}

		// Token: 0x06030573 RID: 198003 RVA: 0x00D7A6A4 File Offset: 0x00D788A4
		public CiacconaGalChapterData GetChapterDataBySubEndingId(int subEndingId)
		{
			if (this.ActivityData == null)
			{
				return null;
			}
			foreach (int id in this.ActivityData.SlotIds)
			{
				CiacconaGalChapterSlotData chapterSlotDataById = this.GetChapterSlotDataById(id);
				CiacconaGalChapterData chapterDataById = this.GetChapterDataById(chapterSlotDataById.ChapterId);
				if (Array.IndexOf<int>(chapterDataById.SubEndingIds, subEndingId) >= 0)
				{
					return chapterDataById;
				}
			}
			return null;
		}

		// Token: 0x06030574 RID: 198004 RVA: 0x00D7A704 File Offset: 0x00D78904
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<CiacconaGalChapterData> GetAllChapterData()
		{
			if (this.ActivityData == null)
			{
				return null;
			}
			int[] slotIds = this.ActivityData.SlotIds;
			List<CiacconaGalChapterData> list = new List<CiacconaGalChapterData>();
			foreach (int id in slotIds)
			{
				CiacconaGalChapterSlotData chapterSlotDataById = this.GetChapterSlotDataById(id);
				list.Add(this.GetChapterDataById(chapterSlotDataById.ChapterId));
			}
			return list;
		}

		// Token: 0x06030575 RID: 198005 RVA: 0x00D7A75C File Offset: 0x00D7895C
		public bool HasAnyProgressReward()
		{
			foreach (CiacconaGalRewardData ciacconaGalRewardData in this.GetAllRewardDataByActivityId(this.ActivityData.Id))
			{
				if (ciacconaGalRewardData.CanReceive && !ciacconaGalRewardData.IsReceived)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06030576 RID: 198006 RVA: 0x00D7A7A0 File Offset: 0x00D789A0
		public bool HasAnyEndingReward()
		{
			foreach (CiacconaGalEndingData ciacconaGalEndingData in this.GetAllEndingDataList())
			{
				if (ciacconaGalEndingData.IsFinished && !ciacconaGalEndingData.IsRewarded)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06030577 RID: 198007 RVA: 0x00D7A7DC File Offset: 0x00D789DC
		public bool HasAnySubEndingReward()
		{
			foreach (int id in this.ActivityData.SlotIds)
			{
				CiacconaGalChapterSlotData chapterSlotDataById = this.GetChapterSlotDataById(id);
				foreach (int id2 in this.GetChapterDataById(chapterSlotDataById.ChapterId).SubEndingIds)
				{
					CiacconaGalSubEndingData subEndingDataById = this.GetSubEndingDataById(id2);
					if (subEndingDataById.IsFinished && !subEndingDataById.IsRewarded)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06030578 RID: 198008 RVA: 0x00D7A85C File Offset: 0x00D78A5C
		public bool HasAnySubEndingRewardByChapterId(int chapterId)
		{
			foreach (int id in this.GetChapterDataById(chapterId).SubEndingIds)
			{
				CiacconaGalSubEndingData subEndingDataById = this.GetSubEndingDataById(id);
				if (subEndingDataById.IsFinished && !subEndingDataById.IsRewarded)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06030579 RID: 198009 RVA: 0x00D7A8A4 File Offset: 0x00D78AA4
		[NullableContext(0)]
		public ValueTuple<int, int> GetEndingProgress()
		{
			CiacconaGalEndingData[] allEndingDataList = this.GetAllEndingDataList();
			int num = 0;
			CiacconaGalEndingData[] array = allEndingDataList;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].IsFinished)
				{
					num++;
				}
			}
			return new ValueTuple<int, int>(num, allEndingDataList.Length);
		}

		// Token: 0x0603057A RID: 198010 RVA: 0x00D7A8E4 File Offset: 0x00D78AE4
		public bool HasAllRewardReceived()
		{
			CiacconaGalEndingData[] allEndingDataList = this.GetAllEndingDataList();
			for (int i = 0; i < allEndingDataList.Length; i++)
			{
				if (!allEndingDataList[i].IsRewarded)
				{
					return false;
				}
			}
			foreach (int id in this.ActivityData.SlotIds)
			{
				CiacconaGalChapterSlotData chapterSlotDataById = this.GetChapterSlotDataById(id);
				foreach (int id2 in this.GetChapterDataById(chapterSlotDataById.ChapterId).SubEndingIds)
				{
					if (!this.GetSubEndingDataById(id2).IsRewarded)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0603057B RID: 198011 RVA: 0x00D7A97C File Offset: 0x00D78B7C
		[NullableContext(0)]
		public ValueTuple<int, int> GetSubEndingProgress()
		{
			int[] slotIds = this.ActivityData.SlotIds;
			int num = 0;
			int num2 = 0;
			foreach (int id in slotIds)
			{
				CiacconaGalChapterSlotData chapterSlotDataById = this.GetChapterSlotDataById(id);
				foreach (int id2 in this.GetChapterDataById(chapterSlotDataById.ChapterId).SubEndingIds)
				{
					CiacconaGalSubEndingData subEndingDataById = this.GetSubEndingDataById(id2);
					num2++;
					if (subEndingDataById.IsFinished)
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, num2);
		}

		// Token: 0x0603057C RID: 198012 RVA: 0x00D7AA04 File Offset: 0x00D78C04
		[NullableContext(0)]
		public ValueTuple<int, int> GetProgressRewardProgress()
		{
			CiacconaGalRewardData[] allRewardDataByActivityId = this.GetAllRewardDataByActivityId(this.ActivityData.Id);
			int num = 0;
			CiacconaGalRewardData[] array = allRewardDataByActivityId;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].CanReceive)
				{
					num++;
				}
			}
			return new ValueTuple<int, int>(num, allRewardDataByActivityId.Length);
		}

		// Token: 0x0603057D RID: 198013 RVA: 0x00D7AA4C File Offset: 0x00D78C4C
		[NullableContext(1)]
		public CiacconaGalStepData[] GetCurStepDataList()
		{
			return this.CurStepDataList.ToArray();
		}

		// Token: 0x0603057E RID: 198014 RVA: 0x00D7AA5C File Offset: 0x00D78C5C
		public bool TryPushCurStepDataById(int id)
		{
			CiacconaGalStepData stepDataById = this.GetStepDataById(id);
			if (stepDataById != null)
			{
				this.PushCurStepData(stepDataById);
				return true;
			}
			return false;
		}

		// Token: 0x0603057F RID: 198015 RVA: 0x00D7AA7E File Offset: 0x00D78C7E
		[NullableContext(1)]
		public void PushCurStepData(CiacconaGalStepData stepData)
		{
			this.IsCurStepDataListDirty = true;
			this.CurStepDataList.Add(stepData);
		}

		// Token: 0x06030580 RID: 198016 RVA: 0x00D7AA94 File Offset: 0x00D78C94
		public CiacconaGalStepData PopCurStepData()
		{
			this.IsCurStepDataListDirty = true;
			if (this.CurStepDataList.Count > 0)
			{
				CiacconaGalStepData result = this.CurStepDataList[this.CurStepDataList.Count - 1];
				this.CurStepDataList.RemoveAt(this.CurStepDataList.Count - 1);
				return result;
			}
			return null;
		}

		// Token: 0x06030581 RID: 198017 RVA: 0x00D7AAE8 File Offset: 0x00D78CE8
		public void ClearCurStepData()
		{
			this.IsCurStepDataListDirty = true;
			this.CurStepDataList.Clear();
		}

		// Token: 0x170060D1 RID: 24785
		// (get) Token: 0x06030582 RID: 198018 RVA: 0x00D7AAFC File Offset: 0x00D78CFC
		[Nullable(1)]
		public static CiacconaGalModel Instance
		{
			[NullableContext(1)]
			get
			{
				return CiacconaGalModel._Instance;
			}
		}

		// Token: 0x06030583 RID: 198019 RVA: 0x00D7AB03 File Offset: 0x00D78D03
		[NullableContext(1)]
		public static CiacconaGalModel GetOrCreateInstance()
		{
			if (CiacconaGalModel._Instance == null)
			{
				CiacconaGalModel.CreateInstance();
			}
			return CiacconaGalModel._Instance;
		}

		// Token: 0x06030584 RID: 198020 RVA: 0x00D7AB17 File Offset: 0x00D78D17
		public static bool CreateInstance()
		{
			if (CiacconaGalModel._Instance != null)
			{
				return true;
			}
			CiacconaGalModel._Instance = new CiacconaGalModel();
			return true;
		}

		// Token: 0x06030585 RID: 198021 RVA: 0x00D7AB2D File Offset: 0x00D78D2D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030586 RID: 198022 RVA: 0x00D7AB2F File Offset: 0x00D78D2F
		public static void ResetStaticDefaultValue()
		{
			CiacconaGalModel._Instance = null;
		}

		// Token: 0x06030587 RID: 198023 RVA: 0x00D7AB37 File Offset: 0x00D78D37
		static CiacconaGalModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CiacconaGalModel.CreateStaticDefaultValue), new Action(CiacconaGalModel.ResetStaticDefaultValue));
		}

		// Token: 0x04019A02 RID: 104962
		[Nullable(1)]
		private readonly Dictionary<Type, Dictionary<int, object>> DataMap = new Dictionary<Type, Dictionary<int, object>>();

		// Token: 0x04019A03 RID: 104963
		[Nullable(1)]
		private readonly List<CiacconaGalStepData> CurStepDataList = new List<CiacconaGalStepData>();

		// Token: 0x04019A04 RID: 104964
		private CiacconaGalActivityData ActivityDataInternal;

		// Token: 0x04019A05 RID: 104965
		public int DataUpdateMask;

		// Token: 0x04019A06 RID: 104966
		public bool IsCurStepDataListDirty;

		// Token: 0x04019A07 RID: 104967
		private static CiacconaGalModel _Instance;
	}
}
