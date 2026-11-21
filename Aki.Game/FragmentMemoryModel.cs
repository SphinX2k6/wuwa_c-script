using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x020010DD RID: 4317
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class FragmentMemoryModel : ModelBase
{
	// Token: 0x0600AC2A RID: 44074 RVA: 0x0032B20B File Offset: 0x0032940B
	public void OnPhotoMemoryResponse(PhotoMemoryResponse response)
	{
		this.RebuildTopicData(response.Topics);
	}

	// Token: 0x0600AC2B RID: 44075 RVA: 0x0032B219 File Offset: 0x00329419
	public void OnPhotoMemoryUpdate(PhotoMemoryUpdateNotify notify)
	{
		this.UpdateTopicData(notify.Topics);
		EventSystem.Instance.Emit(EEventName.OnFragmentMemoryDataUpdate);
	}

	// Token: 0x0600AC2C RID: 44076 RVA: 0x0032B237 File Offset: 0x00329437
	public void TryRemoveCurrentTrackEntity()
	{
		if (this.CurrentTrackMapMarkId != 0)
		{
			MapModel.Instance.RemoveMapMark(new EMarkType?(EMarkType.Entity), new int?(this.CurrentTrackMapMarkId));
			this.CurrentTrackMapMarkId = 0;
		}
	}

	// Token: 0x0600AC2D RID: 44077 RVA: 0x0032B264 File Offset: 0x00329464
	public void TryRemoveUntrackedCurrentTrackEntity()
	{
		if (this.CurrentTrackMapMarkId == 0)
		{
			return;
		}
		TrackMapMarkParams curTrackMark = MapModel.Instance.GetCurTrackMark();
		if (curTrackMark != null && curTrackMark.MarkType == EMarkType.Entity && curTrackMark.MarkId == this.CurrentTrackMapMarkId)
		{
			return;
		}
		this.TryRemoveCurrentTrackEntity();
	}

	// Token: 0x0600AC2E RID: 44078 RVA: 0x0032B2A8 File Offset: 0x003294A8
	private void UpdateTopicData(IEnumerable<PhotoMemoryTopicInfo> data)
	{
		foreach (PhotoMemoryTopicInfo photoMemoryTopicInfo in data)
		{
			int id = photoMemoryTopicInfo.Id;
			FragmentMemoryTopicData fragmentMemoryTopicData;
			if (this.TopicDataMap.TryGetValue(id, out fragmentMemoryTopicData))
			{
				fragmentMemoryTopicData.Phrase(photoMemoryTopicInfo);
			}
			else
			{
				FragmentMemoryTopicData value = this.CreateTopicData(photoMemoryTopicInfo);
				this.TopicDataMap.Add(id, value);
			}
			foreach (FragmentMemoryCollectData fragmentMemoryCollectData in this.TopicDataMap[id].GetCollectDataList())
			{
				if (this.MemoryCollectMap.ContainsKey(fragmentMemoryCollectData.GetId()))
				{
					this.MemoryCollectMap[fragmentMemoryCollectData.GetId()] = fragmentMemoryCollectData;
				}
				else
				{
					this.MemoryCollectMap.Add(fragmentMemoryCollectData.GetId(), fragmentMemoryCollectData);
				}
			}
		}
		EventSystem.Instance.Emit(EEventName.FragmentRewardEntranceRedDot);
	}

	// Token: 0x0600AC2F RID: 44079 RVA: 0x0032B3BC File Offset: 0x003295BC
	private void RebuildTopicData(IEnumerable<PhotoMemoryTopicInfo> topicInfo)
	{
		this.TopicDataMap.Clear();
		this.MemoryCollectMap.Clear();
		foreach (PhotoMemoryTopicInfo photoMemoryTopicInfo in topicInfo)
		{
			FragmentMemoryTopicData fragmentMemoryTopicData = this.CreateTopicData(photoMemoryTopicInfo);
			this.TopicDataMap.Add(photoMemoryTopicInfo.Id, fragmentMemoryTopicData);
			foreach (FragmentMemoryCollectData fragmentMemoryCollectData in fragmentMemoryTopicData.GetCollectDataList())
			{
				this.MemoryCollectMap.Add(fragmentMemoryCollectData.GetId(), fragmentMemoryCollectData);
			}
		}
		EventSystem.Instance.Emit(EEventName.FragmentRewardEntranceRedDot);
	}

	// Token: 0x0600AC30 RID: 44080 RVA: 0x0032B490 File Offset: 0x00329690
	public List<int> GetCollectedIds()
	{
		List<int> list = new List<int>();
		foreach (FragmentMemoryTopicData fragmentMemoryTopicData in this.TopicDataMap.Values)
		{
			foreach (FragmentMemoryCollectData fragmentMemoryCollectData in fragmentMemoryTopicData.GetCollectDataList())
			{
				if (fragmentMemoryCollectData.GetIfUnlock())
				{
					list.Add(fragmentMemoryCollectData.GetId());
				}
			}
		}
		return list;
	}

	// Token: 0x0600AC31 RID: 44081 RVA: 0x0032B538 File Offset: 0x00329738
	public IReadOnlyList<PhotoMemoryTopic> GetAllFragmentTopic()
	{
		return FragmentMemoryConfig.Instance.GetAllPhotoMemoryTopic();
	}

	// Token: 0x0600AC32 RID: 44082 RVA: 0x0032B544 File Offset: 0x00329744
	public bool GetTopicUnlockState(int id)
	{
		return this.GetTopicDataById(id) != null;
	}

	// Token: 0x0600AC33 RID: 44083 RVA: 0x0032B550 File Offset: 0x00329750
	public string GetUnlockConditionText(int id)
	{
		return LevelGeneralCommons.GetConditionGroupHintText(FragmentMemoryConfig.Instance.GetPhotoMemoryTopicById(id).Value.ConditionGroupId) ?? "";
	}

	// Token: 0x0600AC34 RID: 44084 RVA: 0x0032B588 File Offset: 0x00329788
	public void OnPhotoMemoryCollectUpdate(PhotoMemoryCollectNotify notify)
	{
		int id = notify.CollectInfo.Id;
		FragmentMemoryCollectData fragmentMemoryCollectData;
		if (!this.MemoryCollectMap.TryGetValue(id, out fragmentMemoryCollectData))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FragmentMemory;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "记忆历程数据刷新时找不到数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			fragmentMemoryCollectData = new FragmentMemoryCollectData();
		}
		fragmentMemoryCollectData.Phrase(notify.CollectInfo);
		EventSystem.Instance.Emit(EEventName.OnFragmentMemoryCollectUpdate);
	}

	// Token: 0x0600AC35 RID: 44085 RVA: 0x0032B602 File Offset: 0x00329802
	private FragmentMemoryTopicData CreateTopicData(PhotoMemoryTopicInfo data)
	{
		FragmentMemoryTopicData fragmentMemoryTopicData = new FragmentMemoryTopicData();
		fragmentMemoryTopicData.Phrase(data);
		return fragmentMemoryTopicData;
	}

	// Token: 0x0600AC36 RID: 44086 RVA: 0x0032B610 File Offset: 0x00329810
	[NullableContext(2)]
	public FragmentMemoryCollectData GetCollectDataById(int id)
	{
		FragmentMemoryCollectData result;
		if (this.MemoryCollectMap.TryGetValue(id, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600AC37 RID: 44087 RVA: 0x0032B630 File Offset: 0x00329830
	[NullableContext(2)]
	public FragmentMemoryTopicData GetTopicDataById(int id)
	{
		FragmentMemoryTopicData fragmentMemoryTopicData;
		if (!this.TopicDataMap.TryGetValue(id, out fragmentMemoryTopicData))
		{
			return null;
		}
		if (fragmentMemoryTopicData != null && !fragmentMemoryTopicData.GetUnlockState())
		{
			return null;
		}
		return fragmentMemoryTopicData;
	}

	// Token: 0x0600AC38 RID: 44088 RVA: 0x0032B660 File Offset: 0x00329860
	public bool GetRedDotState()
	{
		IReadOnlyList<PhotoMemoryTopic> allFragmentTopic = this.GetAllFragmentTopic();
		if (allFragmentTopic.Count == 0)
		{
			return false;
		}
		int id = allFragmentTopic[allFragmentTopic.Count - 1].Id;
		FragmentMemoryTopicData fragmentMemoryTopicData;
		return this.TopicDataMap.TryGetValue(id, out fragmentMemoryTopicData) && fragmentMemoryTopicData != null && fragmentMemoryTopicData.GetRedDotState();
	}

	// Token: 0x0600AC39 RID: 44089 RVA: 0x0032B6B2 File Offset: 0x003298B2
	public bool GetTopicFirstOpenRedDotState(int topicId)
	{
		ServerStorageUtil.OverrideLocalListToServerSet(ELocalStoragePlayerKey.FragmentMemoryOpened, EClientStorageSystemIdType.FragmentMemoryOpened, true);
		return !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FragmentMemoryOpened) as ServerStorageSet).Has(topicId);
	}

	// Token: 0x0600AC3A RID: 44090 RVA: 0x0032B6DC File Offset: 0x003298DC
	public bool GetCurrentActivityFragmentMemoryRedDotState()
	{
		List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(16);
		if (currentActivitiesByType != null && currentActivitiesByType.Count > 0)
		{
			using (List<ActivityBaseData>.Enumerator enumerator = currentActivitiesByType.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if ((enumerator.Current as FragmentMemoryActivityData).EntranceRedDot())
					{
						return true;
					}
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x0600AC3B RID: 44091 RVA: 0x0032B750 File Offset: 0x00329950
	public void SaveTopicOpened(int topicId)
	{
		FragmentMemoryTopicData fragmentMemoryTopicData;
		if (!this.TopicDataMap.TryGetValue(topicId, out fragmentMemoryTopicData))
		{
			return;
		}
		if (!fragmentMemoryTopicData.GetUnlockState())
		{
			return;
		}
		ServerStorageUtil.OverrideLocalListToServerSet(ELocalStoragePlayerKey.FragmentMemoryOpened, EClientStorageSystemIdType.FragmentMemoryOpened, true);
		ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FragmentMemoryOpened) as ServerStorageSet;
		if (serverStorageSet.Has(topicId))
		{
			return;
		}
		serverStorageSet.Add(topicId);
		EventSystem.Instance.Emit<int>(EEventName.FragmentRewardTopicRedDot, topicId);
		EventSystem.Instance.Emit(EEventName.FragmentRewardEntranceRedDot);
	}

	// Token: 0x170011DC RID: 4572
	// (get) Token: 0x0600AC3C RID: 44092 RVA: 0x0032B7C6 File Offset: 0x003299C6
	public static FragmentMemoryModel Instance
	{
		get
		{
			return FragmentMemoryModel._Instance;
		}
	}

	// Token: 0x0600AC3D RID: 44093 RVA: 0x0032B7CD File Offset: 0x003299CD
	public static FragmentMemoryModel GetOrCreateInstance()
	{
		if (FragmentMemoryModel._Instance == null)
		{
			FragmentMemoryModel.CreateInstance();
		}
		return FragmentMemoryModel._Instance;
	}

	// Token: 0x0600AC3E RID: 44094 RVA: 0x0032B7E1 File Offset: 0x003299E1
	public static bool CreateInstance()
	{
		if (FragmentMemoryModel._Instance != null)
		{
			return true;
		}
		FragmentMemoryModel._Instance = new FragmentMemoryModel();
		return true;
	}

	// Token: 0x0600AC3F RID: 44095 RVA: 0x0032B7F7 File Offset: 0x003299F7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AC40 RID: 44096 RVA: 0x0032B7F9 File Offset: 0x003299F9
	public static void ResetStaticDefaultValue()
	{
		FragmentMemoryModel._Instance = null;
	}

	// Token: 0x0600AC41 RID: 44097 RVA: 0x0032B801 File Offset: 0x00329A01
	static FragmentMemoryModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FragmentMemoryModel.CreateStaticDefaultValue), new Action(FragmentMemoryModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400635E RID: 25438
	public string ActivitySubViewTryPlayAnimation = "";

	// Token: 0x0400635F RID: 25439
	public string MemoryFragmentMainViewTryPlayAnimation = "";

	// Token: 0x04006360 RID: 25440
	private readonly Dictionary<int, FragmentMemoryCollectData> MemoryCollectMap = new Dictionary<int, FragmentMemoryCollectData>();

	// Token: 0x04006361 RID: 25441
	public int CurrentTrackMapMarkId;

	// Token: 0x04006362 RID: 25442
	public int CurrentTrackFragmentId;

	// Token: 0x04006363 RID: 25443
	private readonly Dictionary<int, FragmentMemoryTopicData> TopicDataMap = new Dictionary<int, FragmentMemoryTopicData>();

	// Token: 0x04006364 RID: 25444
	public int CurrentUnlockCollectId;

	// Token: 0x04006365 RID: 25445
	[Nullable(2)]
	private static FragmentMemoryModel _Instance;
}
