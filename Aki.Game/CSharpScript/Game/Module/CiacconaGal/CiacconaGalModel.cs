using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BBE RID: 23486
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class CiacconaGalModel : ModelBase
	{
		// Token: 0x17008CFE RID: 36094
		// (get) Token: 0x0603B613 RID: 243219 RVA: 0x00E29CEB File Offset: 0x00E27EEB
		public CiacconaGalActivityData ActivityData
		{
			get
			{
				return this.ActivityDataInternal ?? this.GetActivityDataById(104800001);
			}
		}

		// Token: 0x0603B614 RID: 243220 RVA: 0x00E29D02 File Offset: 0x00E27F02
		protected override bool OnClear()
		{
			this.IsCurStepDataListDirty = false;
			this.DataUpdateMask = 0;
			this.DataMap.Clear();
			this.CurStepDataList.Clear();
			this.ActivityDataInternal = null;
			return true;
		}

		// Token: 0x0603B615 RID: 243221 RVA: 0x00E29D30 File Offset: 0x00E27F30
		[NullableContext(0)]
		[return: Nullable(2)]
		private TData GetOrCreateData<[Nullable(1)] TData, TConfig>(int id, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] Func<TConfig, TData> ctor) where TData : class where TConfig : struct
		{
			string name = typeof(TData).Name;
			TConfig? tconfig = null;
			if (name != null)
			{
				switch (name.Length)
				{
				case 19:
					if (name == "CiacconaGalStepData")
					{
						tconfig = (ConfigCiacconaGalStepById.GetConfig(id, true) as TConfig?);
					}
					break;
				case 21:
				{
					char c = name[11];
					if (c != 'C')
					{
						if (c != 'E')
						{
							if (c == 'R')
							{
								if (name == "CiacconaGalRewardData")
								{
									tconfig = (ConfigCiacconaActivityRewardById.GetConfig(id, true) as TConfig?);
								}
							}
						}
						else if (name == "CiacconaGalEndingData")
						{
							tconfig = (ConfigCiacconaGalEndingById.GetConfig(id, true) as TConfig?);
						}
					}
					else if (name == "CiacconaGalChoiceData")
					{
						tconfig = (ConfigCiacconaGalChoiceById.GetConfig(id, true) as TConfig?);
					}
					break;
				}
				case 22:
					if (name == "CiacconaGalChapterData")
					{
						tconfig = (ConfigCiacconaGalChapterById.GetConfig(id, true) as TConfig?);
					}
					break;
				case 23:
					if (name == "CiacconaGalActivityData")
					{
						tconfig = (ConfigCiacconaActivityConfigById.GetConfig(id, true) as TConfig?);
					}
					break;
				case 24:
					if (name == "CiacconaGalSubEndingData")
					{
						tconfig = (ConfigCiacconaGalSubEndingById.GetConfig(id, true) as TConfig?);
					}
					break;
				case 26:
					if (name == "CiacconaGalChapterSlotData")
					{
						tconfig = (ConfigCiacconaChapterSlotById.GetConfig(id, true) as TConfig?);
					}
					break;
				}
			}
			if (tconfig == null)
			{
				return default(TData);
			}
			Dictionary<int, object> dictionary;
			if (!this.DataMap.TryGetValue(name, out dictionary))
			{
				dictionary = new Dictionary<int, object>();
				this.DataMap.Add(name, dictionary);
			}
			object obj;
			if (!dictionary.TryGetValue(id, out obj))
			{
				obj = ctor(tconfig.Value);
				dictionary.Add(id, obj);
			}
			return obj as TData;
		}

		// Token: 0x0603B616 RID: 243222 RVA: 0x00E29F8C File Offset: 0x00E2818C
		[NullableContext(1)]
		public void UpdateByServerActivityData(ActivityData data, int activityId)
		{
			CiacconaActivityPbData ciacconaActivityPbData = data.CiacconaActivityPbData;
			if (ciacconaActivityPbData == null)
			{
				Log.Instance.Error(ELogModule.CiacconaGal, ELogAuthor.HYF, "夏空活动服务器数据异常", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.UpdateAllChapterData(ciacconaActivityPbData.ChapterDatas.ToArray<CiacconaChapterPbData>());
			this.UpdateAllEndingData(ciacconaActivityPbData.ActivityResultDatas.ToArray<CiacconaActivityResultPbData>());
			this.UpdateProgressRewardData(ciacconaActivityPbData.ScheduleRewardDatas.ToArray<CiacconaScheduleRewardPbData>());
			this.ActivityDataInternal = this.GetActivityDataById(activityId);
			this.ActivityDataInternal.UpdateByServerData(ciacconaActivityPbData);
			this.ActivityDataInternal.UpdateEndTime(data.EndShowTime);
			this.DataUpdateMask = -1;
		}

		// Token: 0x0603B617 RID: 243223 RVA: 0x00E2A028 File Offset: 0x00E28228
		[NullableContext(1)]
		public void UpdateAllChapterData(CiacconaChapterPbData[] dataList)
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

		// Token: 0x0603B618 RID: 243224 RVA: 0x00E2A10C File Offset: 0x00E2830C
		[NullableContext(1)]
		public void UpdateAllEndingData(CiacconaActivityResultPbData[] dataList)
		{
			foreach (CiacconaActivityResultPbData ciacconaActivityResultPbData in dataList)
			{
				this.GetEndingDataById(ciacconaActivityResultPbData.ResultId).UpdateByServerData(ciacconaActivityResultPbData);
			}
			this.DataUpdateMask |= 8;
		}

		// Token: 0x0603B619 RID: 243225 RVA: 0x00E2A150 File Offset: 0x00E28350
		[NullableContext(1)]
		public void UpdateProgressRewardData(CiacconaScheduleRewardPbData[] dataList)
		{
			foreach (CiacconaScheduleRewardPbData ciacconaScheduleRewardPbData in dataList)
			{
				this.GetRewardDataById(ciacconaScheduleRewardPbData.RewardId).UpdateByServerData(ciacconaScheduleRewardPbData);
			}
			this.DataUpdateMask |= 4;
		}

		// Token: 0x0603B61A RID: 243226 RVA: 0x00E2A191 File Offset: 0x00E28391
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

		// Token: 0x0603B61B RID: 243227 RVA: 0x00E2A1B7 File Offset: 0x00E283B7
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

		// Token: 0x0603B61C RID: 243228 RVA: 0x00E2A1DA File Offset: 0x00E283DA
		public CiacconaGalChapterData GetChapterDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalChapterData, CiacconaGalChapter>(id, (CiacconaGalChapter config) => new CiacconaGalChapterData(config));
		}

		// Token: 0x0603B61D RID: 243229 RVA: 0x00E2A202 File Offset: 0x00E28402
		public CiacconaGalChoiceData GetChoiceDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalChoiceData, CiacconaGalChoice>(id, (CiacconaGalChoice config) => new CiacconaGalChoiceData(config));
		}

		// Token: 0x0603B61E RID: 243230 RVA: 0x00E2A22A File Offset: 0x00E2842A
		public CiacconaGalEndingData GetEndingDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalEndingData, CiacconaGalEnding>(id, (CiacconaGalEnding config) => new CiacconaGalEndingData(config));
		}

		// Token: 0x0603B61F RID: 243231 RVA: 0x00E2A252 File Offset: 0x00E28452
		public CiacconaGalStepData GetStepDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalStepData, CiacconaGalStep>(id, (CiacconaGalStep config) => new CiacconaGalStepData(config));
		}

		// Token: 0x0603B620 RID: 243232 RVA: 0x00E2A27A File Offset: 0x00E2847A
		[NullableContext(1)]
		public CiacconaGalEndingData[] GetAllEndingDataList()
		{
			return (from config in ConfigCiacconaGalEndingAll.GetConfigList(true)
			select this.GetOrCreateData<CiacconaGalEndingData, CiacconaGalEnding>(config.Id, (CiacconaGalEnding config) => new CiacconaGalEndingData(config))).ToArray<CiacconaGalEndingData>();
		}

		// Token: 0x0603B621 RID: 243233 RVA: 0x00E2A298 File Offset: 0x00E28498
		public CiacconaGalSubEndingData GetSubEndingDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalSubEndingData, CiacconaGalSubEnding>(id, (CiacconaGalSubEnding config) => new CiacconaGalSubEndingData(config));
		}

		// Token: 0x0603B622 RID: 243234 RVA: 0x00E2A2C0 File Offset: 0x00E284C0
		public CiacconaGalChapterSlotData GetChapterSlotDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalChapterSlotData, CiacconaChapterSlot>(id, (CiacconaChapterSlot config) => new CiacconaGalChapterSlotData(config));
		}

		// Token: 0x0603B623 RID: 243235 RVA: 0x00E2A2E8 File Offset: 0x00E284E8
		public CiacconaGalActivityData GetActivityDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalActivityData, CiacconaActivityConfig>(id, (CiacconaActivityConfig config) => new CiacconaGalActivityData(config));
		}

		// Token: 0x0603B624 RID: 243236 RVA: 0x00E2A310 File Offset: 0x00E28510
		public CiacconaGalRewardData GetRewardDataById(int id)
		{
			return this.GetOrCreateData<CiacconaGalRewardData, CiacconaActivityReward>(id, (CiacconaActivityReward config) => new CiacconaGalRewardData(config));
		}

		// Token: 0x0603B625 RID: 243237 RVA: 0x00E2A338 File Offset: 0x00E28538
		[NullableContext(1)]
		public CiacconaGalRewardData[] GetAllRewardDataByActivityId(int activityId)
		{
			return (from config in ConfigCiacconaActivityRewardAll.GetConfigList(true)
			where config.ActivityId == activityId
			select this.GetOrCreateData<CiacconaGalRewardData, CiacconaActivityReward>(config.Id, (CiacconaActivityReward config) => new CiacconaGalRewardData(config))).ToArray<CiacconaGalRewardData>();
		}

		// Token: 0x0603B626 RID: 243238 RVA: 0x00E2A388 File Offset: 0x00E28588
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
				if (chapterDataById.SubEndingIds.Contains(subEndingId))
				{
					return chapterDataById;
				}
			}
			return null;
		}

		// Token: 0x0603B627 RID: 243239 RVA: 0x00E2A3E6 File Offset: 0x00E285E6
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
			return this.ActivityData.SlotIds.Select(delegate(int slotId)
			{
				CiacconaGalChapterSlotData chapterSlotDataById = this.GetChapterSlotDataById(slotId);
				return this.GetChapterDataById(chapterSlotDataById.ChapterId);
			}).ToList<CiacconaGalChapterData>();
		}

		// Token: 0x0603B628 RID: 243240 RVA: 0x00E2A413 File Offset: 0x00E28613
		public bool HasAnyProgressReward()
		{
			return this.GetAllRewardDataByActivityId(this.ActivityData.Id).Any((CiacconaGalRewardData rewardData) => rewardData.CanReceive && !rewardData.IsReceived);
		}

		// Token: 0x0603B629 RID: 243241 RVA: 0x00E2A44A File Offset: 0x00E2864A
		public bool HasAnyEndingReward()
		{
			return this.GetAllEndingDataList().Any((CiacconaGalEndingData endingData) => endingData.IsFinished && !endingData.IsRewarded);
		}

		// Token: 0x0603B62A RID: 243242 RVA: 0x00E2A478 File Offset: 0x00E28678
		public bool HasAnySubEndingReward()
		{
			foreach (int id in this.ActivityData.SlotIds)
			{
				CiacconaGalChapterSlotData chapterSlotDataById = this.GetChapterSlotDataById(id);
				if (this.GetChapterDataById(chapterSlotDataById.ChapterId).SubEndingIds.Select(new Func<int, CiacconaGalSubEndingData>(this.GetSubEndingDataById)).Any((CiacconaGalSubEndingData subEndingData) => subEndingData.IsFinished && !subEndingData.IsRewarded))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603B62B RID: 243243 RVA: 0x00E2A4F8 File Offset: 0x00E286F8
		public bool HasAnySubEndingRewardByChapterId(int chapterId)
		{
			return this.GetChapterDataById(chapterId).SubEndingIds.Select(new Func<int, CiacconaGalSubEndingData>(this.GetSubEndingDataById)).Any((CiacconaGalSubEndingData subEndingData) => subEndingData.IsFinished && !subEndingData.IsRewarded);
		}

		// Token: 0x0603B62C RID: 243244 RVA: 0x00E2A548 File Offset: 0x00E28748
		[NullableContext(0)]
		public ValueTuple<int, int> GetEndingProgress()
		{
			CiacconaGalEndingData[] allEndingDataList = this.GetAllEndingDataList();
			return new ValueTuple<int, int>(allEndingDataList.Count((CiacconaGalEndingData endingData) => endingData.IsFinished), allEndingDataList.Length);
		}

		// Token: 0x0603B62D RID: 243245 RVA: 0x00E2A58C File Offset: 0x00E2878C
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
				using (IEnumerator<CiacconaGalSubEndingData> enumerator = this.GetChapterDataById(chapterSlotDataById.ChapterId).SubEndingIds.Select(new Func<int, CiacconaGalSubEndingData>(this.GetSubEndingDataById)).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.IsRewarded)
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0603B62E RID: 243246 RVA: 0x00E2A64C File Offset: 0x00E2884C
		[NullableContext(0)]
		public ValueTuple<int, int> GetSubEndingProgress()
		{
			int[] slotIds = this.ActivityData.SlotIds;
			int num = 0;
			int num2 = 0;
			foreach (int id in slotIds)
			{
				CiacconaGalChapterSlotData chapterSlotDataById = this.GetChapterSlotDataById(id);
				CiacconaGalSubEndingData[] array2 = this.GetChapterDataById(chapterSlotDataById.ChapterId).SubEndingIds.Select(new Func<int, CiacconaGalSubEndingData>(this.GetSubEndingDataById)).ToArray<CiacconaGalSubEndingData>();
				num += array2.Count((CiacconaGalSubEndingData subEndingData) => subEndingData.IsFinished);
				num2 += array2.Length;
			}
			return new ValueTuple<int, int>(num, num2);
		}

		// Token: 0x0603B62F RID: 243247 RVA: 0x00E2A6E8 File Offset: 0x00E288E8
		[NullableContext(0)]
		public ValueTuple<int, int> GetProgressRewardProgress()
		{
			CiacconaGalRewardData[] allRewardDataByActivityId = this.GetAllRewardDataByActivityId(this.ActivityData.Id);
			return new ValueTuple<int, int>(allRewardDataByActivityId.Count((CiacconaGalRewardData rewardData) => rewardData.CanReceive), allRewardDataByActivityId.Length);
		}

		// Token: 0x0603B630 RID: 243248 RVA: 0x00E2A734 File Offset: 0x00E28934
		[NullableContext(1)]
		public CiacconaGalStepData[] GetCurStepDataList()
		{
			return this.CurStepDataList.ToArray();
		}

		// Token: 0x0603B631 RID: 243249 RVA: 0x00E2A744 File Offset: 0x00E28944
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

		// Token: 0x0603B632 RID: 243250 RVA: 0x00E2A766 File Offset: 0x00E28966
		[NullableContext(1)]
		public void PushCurStepData(CiacconaGalStepData stepData)
		{
			this.IsCurStepDataListDirty = true;
			this.CurStepDataList.Add(stepData);
		}

		// Token: 0x0603B633 RID: 243251 RVA: 0x00E2A77C File Offset: 0x00E2897C
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

		// Token: 0x0603B634 RID: 243252 RVA: 0x00E2A7D0 File Offset: 0x00E289D0
		public void ClearCurStepData()
		{
			this.IsCurStepDataListDirty = true;
			this.CurStepDataList.Clear();
		}

		// Token: 0x17008CFF RID: 36095
		// (get) Token: 0x0603B635 RID: 243253 RVA: 0x00E2A7E4 File Offset: 0x00E289E4
		[Nullable(1)]
		public static CiacconaGalModel Instance
		{
			[NullableContext(1)]
			get
			{
				return CiacconaGalModel._Instance;
			}
		}

		// Token: 0x0603B636 RID: 243254 RVA: 0x00E2A7EB File Offset: 0x00E289EB
		[NullableContext(1)]
		public static CiacconaGalModel GetOrCreateInstance()
		{
			if (CiacconaGalModel._Instance == null)
			{
				CiacconaGalModel.CreateInstance();
			}
			return CiacconaGalModel._Instance;
		}

		// Token: 0x0603B637 RID: 243255 RVA: 0x00E2A7FF File Offset: 0x00E289FF
		public static bool CreateInstance()
		{
			if (CiacconaGalModel._Instance != null)
			{
				return true;
			}
			CiacconaGalModel._Instance = new CiacconaGalModel();
			return true;
		}

		// Token: 0x0603B638 RID: 243256 RVA: 0x00E2A815 File Offset: 0x00E28A15
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B639 RID: 243257 RVA: 0x00E2A817 File Offset: 0x00E28A17
		public static void ResetStaticDefaultValue()
		{
			CiacconaGalModel._Instance = null;
		}

		// Token: 0x0603B63A RID: 243258 RVA: 0x00E2A81F File Offset: 0x00E28A1F
		static CiacconaGalModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CiacconaGalModel.CreateStaticDefaultValue), new Action(CiacconaGalModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401EF51 RID: 126801
		[Nullable(1)]
		private readonly Dictionary<string, Dictionary<int, object>> DataMap = new Dictionary<string, Dictionary<int, object>>();

		// Token: 0x0401EF52 RID: 126802
		[Nullable(1)]
		private readonly List<CiacconaGalStepData> CurStepDataList = new List<CiacconaGalStepData>();

		// Token: 0x0401EF53 RID: 126803
		private CiacconaGalActivityData ActivityDataInternal;

		// Token: 0x0401EF54 RID: 126804
		public int DataUpdateMask;

		// Token: 0x0401EF55 RID: 126805
		public bool IsCurStepDataListDirty;

		// Token: 0x0401EF56 RID: 126806
		private static CiacconaGalModel _Instance;
	}
}
