using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x02001C1E RID: 7198
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class FragmentMemoryModel : ModelBase
{
	// Token: 0x0600D815 RID: 55317 RVA: 0x0031FE77 File Offset: 0x0031E077
	public void OnPhotoMemoryResponse(PhotoMemoryResponse response)
	{
		this.RebuildTopicData(response.Topics);
	}

	// Token: 0x0600D816 RID: 55318 RVA: 0x0031FE85 File Offset: 0x0031E085
	public void OnPhotoMemoryUpdate(PhotoMemoryUpdateNotify notify)
	{
		this.UpdateTopicData(notify.Topics);
		EventSystem.Instance.Emit(EEventName.OnFragmentMemoryDataUpdate);
	}

	// Token: 0x0600D817 RID: 55319 RVA: 0x0031FEA3 File Offset: 0x0031E0A3
	public void TryRemoveCurrentTrackEntity()
	{
		if (this.CurrentTrackMapMarkId != 0)
		{
			MapModel.Instance.RemoveMapMark(new EMarkType?(EMarkType.Entity), new int?(this.CurrentTrackMapMarkId));
			this.CurrentTrackMapMarkId = 0;
		}
	}

	// Token: 0x0600D818 RID: 55320 RVA: 0x0031FED0 File Offset: 0x0031E0D0
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

	// Token: 0x0600D819 RID: 55321 RVA: 0x0031FFE4 File Offset: 0x0031E1E4
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

	// Token: 0x0600D81A RID: 55322 RVA: 0x003200B8 File Offset: 0x0031E2B8
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

	// Token: 0x0600D81B RID: 55323 RVA: 0x00320160 File Offset: 0x0031E360
	public IReadOnlyList<PhotoMemoryTopic> GetAllFragmentTopic()
	{
		return FragmentMemoryConfig.Instance.GetAllPhotoMemoryTopic();
	}

	// Token: 0x0600D81C RID: 55324 RVA: 0x0032016C File Offset: 0x0031E36C
	public bool GetTopicUnlockState(int id)
	{
		return this.GetTopicDataById(id) != null;
	}

	// Token: 0x0600D81D RID: 55325 RVA: 0x00320178 File Offset: 0x0031E378
	public string GetUnlockConditionText(int id)
	{
		return LevelGeneralCommons.GetConditionGroupHintText(FragmentMemoryConfig.Instance.GetPhotoMemoryTopicById(id).Value.ConditionGroupId) ?? "";
	}

	// Token: 0x0600D81E RID: 55326 RVA: 0x003201B0 File Offset: 0x0031E3B0
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

	// Token: 0x0600D81F RID: 55327 RVA: 0x0032022A File Offset: 0x0031E42A
	private FragmentMemoryTopicData CreateTopicData(PhotoMemoryTopicInfo data)
	{
		FragmentMemoryTopicData fragmentMemoryTopicData = new FragmentMemoryTopicData();
		fragmentMemoryTopicData.Phrase(data);
		return fragmentMemoryTopicData;
	}

	// Token: 0x0600D820 RID: 55328 RVA: 0x00320238 File Offset: 0x0031E438
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

	// Token: 0x0600D821 RID: 55329 RVA: 0x00320258 File Offset: 0x0031E458
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

	// Token: 0x0600D822 RID: 55330 RVA: 0x00320288 File Offset: 0x0031E488
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

	// Token: 0x0600D823 RID: 55331 RVA: 0x003202DC File Offset: 0x0031E4DC
	public bool GetTopicFirstOpenRedDotState(int topicId)
	{
		List<int> player = LocalStorage.GetPlayer<List<int>>(ELocalStoragePlayerKey.FragmentMemoryOpened, null);
		return player == null || !player.Contains(topicId);
	}

	// Token: 0x0600D824 RID: 55332 RVA: 0x00320304 File Offset: 0x0031E504
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

	// Token: 0x0600D825 RID: 55333 RVA: 0x00320378 File Offset: 0x0031E578
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
		List<int> list = LocalStorage.GetPlayer<List<int>>(ELocalStoragePlayerKey.FragmentMemoryOpened, null);
		if (list == null)
		{
			list = new List<int>();
		}
		if (list.Contains(topicId))
		{
			return;
		}
		list.Add(topicId);
		LocalStorage.SetPlayer<List<int>>(ELocalStoragePlayerKey.FragmentMemoryOpened, list);
		EventSystem.Instance.Emit<int>(EEventName.FragmentRewardTopicRedDot, topicId);
		EventSystem.Instance.Emit(EEventName.FragmentRewardEntranceRedDot);
	}

	// Token: 0x170011B6 RID: 4534
	// (get) Token: 0x0600D826 RID: 55334 RVA: 0x003203EC File Offset: 0x0031E5EC
	public static FragmentMemoryModel Instance
	{
		get
		{
			return FragmentMemoryModel._Instance;
		}
	}

	// Token: 0x0600D827 RID: 55335 RVA: 0x003203F3 File Offset: 0x0031E5F3
	public static FragmentMemoryModel GetOrCreateInstance()
	{
		if (FragmentMemoryModel._Instance == null)
		{
			FragmentMemoryModel.CreateInstance();
		}
		return FragmentMemoryModel._Instance;
	}

	// Token: 0x0600D828 RID: 55336 RVA: 0x00320407 File Offset: 0x0031E607
	public static bool CreateInstance()
	{
		if (FragmentMemoryModel._Instance != null)
		{
			return true;
		}
		FragmentMemoryModel._Instance = new FragmentMemoryModel();
		return true;
	}

	// Token: 0x0600D829 RID: 55337 RVA: 0x0032041D File Offset: 0x0031E61D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D82A RID: 55338 RVA: 0x0032041F File Offset: 0x0031E61F
	public static void ResetStaticDefaultValue()
	{
		FragmentMemoryModel._Instance = null;
	}

	// Token: 0x0600D82B RID: 55339 RVA: 0x00320427 File Offset: 0x0031E627
	static FragmentMemoryModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FragmentMemoryModel.CreateStaticDefaultValue), new Action(FragmentMemoryModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400628C RID: 25228
	public string ActivitySubViewTryPlayAnimation = "";

	// Token: 0x0400628D RID: 25229
	public string MemoryFragmentMainViewTryPlayAnimation = "";

	// Token: 0x0400628E RID: 25230
	private readonly Dictionary<int, FragmentMemoryCollectData> MemoryCollectMap = new Dictionary<int, FragmentMemoryCollectData>();

	// Token: 0x0400628F RID: 25231
	public int CurrentTrackMapMarkId;

	// Token: 0x04006290 RID: 25232
	public int CurrentTrackFragmentId;

	// Token: 0x04006291 RID: 25233
	private readonly Dictionary<int, FragmentMemoryTopicData> TopicDataMap = new Dictionary<int, FragmentMemoryTopicData>();

	// Token: 0x04006292 RID: 25234
	public int CurrentUnlockCollectId;

	// Token: 0x04006293 RID: 25235
	[Nullable(2)]
	private static FragmentMemoryModel _Instance;
}
