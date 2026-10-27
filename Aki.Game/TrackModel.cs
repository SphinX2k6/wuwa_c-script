using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x02002C15 RID: 11285
[NullableContext(1)]
[Nullable(0)]
public class TrackModel : ModelBase
{
	// Token: 0x17001F92 RID: 8082
	// (get) Token: 0x06017721 RID: 96033 RVA: 0x005F7B8D File Offset: 0x005F5D8D
	// (set) Token: 0x06017722 RID: 96034 RVA: 0x005F7B95 File Offset: 0x005F5D95
	public int DefaultTrackHideDis { get; private set; }

	// Token: 0x06017723 RID: 96035 RVA: 0x005F7B9E File Offset: 0x005F5D9E
	protected override bool OnInit()
	{
		this.TrackInfos = new Dictionary<int, Dictionary<int, ITrackData>>();
		this.ShowGroup = new Dictionary<int, Dictionary<int, ITrackData>>();
		this.GroupMinDistance = new Dictionary<int, double>();
		this.DefaultTrackHideDis = int.Parse(QuestNewConfig.Instance.GetGlobalConfig("TrackMarkHideDis"));
		return true;
	}

	// Token: 0x06017724 RID: 96036 RVA: 0x005F7BDC File Offset: 0x005F5DDC
	protected override bool OnClear()
	{
		if (this.TrackInfos != null)
		{
			this.TrackInfos.Clear();
			this.TrackInfos = null;
		}
		if (this.ShowGroup != null)
		{
			this.ShowGroup.Clear();
			this.ShowGroup = null;
		}
		if (this.GroupMinDistance != null)
		{
			this.GroupMinDistance.Clear();
			this.GroupMinDistance = null;
		}
		return true;
	}

	// Token: 0x06017725 RID: 96037 RVA: 0x005F7C38 File Offset: 0x005F5E38
	protected override bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x06017726 RID: 96038 RVA: 0x005F7C3C File Offset: 0x005F5E3C
	public void AddTrackData(ITrackData data)
	{
		Dictionary<int, ITrackData> dictionary = this.GetTracksByType(data.TrackSource);
		if (dictionary == null)
		{
			dictionary = new Dictionary<int, ITrackData>();
			this.TrackInfos[(int)data.TrackSource] = dictionary;
		}
		float? trackHideDis = data.TrackHideDis;
		float num = 0f;
		if (trackHideDis.GetValueOrDefault() == num & trackHideDis != null)
		{
			data.TrackHideDis = new float?((float)this.DefaultTrackHideDis);
		}
		dictionary[data.Id] = data;
		this.AddTrackToGroup(data);
	}

	// Token: 0x06017727 RID: 96039 RVA: 0x005F7CB8 File Offset: 0x005F5EB8
	public void RemoveTrackData(ETrackSource type, int id)
	{
		Dictionary<int, ITrackData> tracksByType = this.GetTracksByType(type);
		if (tracksByType == null)
		{
			return;
		}
		ITrackData data;
		if (tracksByType.TryGetValue(id, out data))
		{
			tracksByType.Remove(id);
			this.RemoveTrackFromGroup(data);
		}
	}

	// Token: 0x06017728 RID: 96040 RVA: 0x005F7CEB File Offset: 0x005F5EEB
	public void ClearTrackData()
	{
		this.TrackInfos.Clear();
		this.ShowGroup.Clear();
		EventSystem.Instance.Emit(EEventName.ClearTrackMark);
	}

	// Token: 0x06017729 RID: 96041 RVA: 0x005F7D14 File Offset: 0x005F5F14
	private void AddTrackToGroup(ITrackData data)
	{
		int? showGroupId = data.ShowGroupId;
		int num = 0;
		if (showGroupId.GetValueOrDefault() == num & showGroupId != null)
		{
			return;
		}
		Dictionary<int, ITrackData> dictionary;
		if (!this.ShowGroup.TryGetValue(data.ShowGroupId.GetValueOrDefault(), out dictionary))
		{
			dictionary = new Dictionary<int, ITrackData>();
			this.ShowGroup[data.ShowGroupId.GetValueOrDefault()] = dictionary;
		}
		dictionary[data.Id] = data;
	}

	// Token: 0x0601772A RID: 96042 RVA: 0x005F7D8C File Offset: 0x005F5F8C
	private void RemoveTrackFromGroup(ITrackData data)
	{
		int? showGroupId = data.ShowGroupId;
		int num = 0;
		if (showGroupId.GetValueOrDefault() == num & showGroupId != null)
		{
			return;
		}
		Dictionary<int, ITrackData> dictionary;
		if (this.ShowGroup.TryGetValue(data.ShowGroupId.GetValueOrDefault(), out dictionary))
		{
			dictionary.Remove(data.Id);
		}
	}

	// Token: 0x0601772B RID: 96043 RVA: 0x005F7DE4 File Offset: 0x005F5FE4
	[return: Nullable(2)]
	public ITrackData IsTargetTracking(TTrackTarget target)
	{
		ETrackSource? etrackSource = null;
		ITrackData result = null;
		foreach (KeyValuePair<int, Dictionary<int, ITrackData>> keyValuePair in this.TrackInfos)
		{
			foreach (KeyValuePair<int, ITrackData> keyValuePair2 in keyValuePair.Value)
			{
				ITrackData value = keyValuePair2.Value;
				if (object.Equals(value.TrackTarget, target))
				{
					if (etrackSource == null)
					{
						etrackSource = new ETrackSource?((ETrackSource)keyValuePair.Key);
						result = value;
					}
					else if (keyValuePair.Key > (int)etrackSource.Value)
					{
						result = value;
						etrackSource = new ETrackSource?((ETrackSource)keyValuePair.Key);
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0601772C RID: 96044 RVA: 0x005F7ED4 File Offset: 0x005F60D4
	[NullableContext(2)]
	public ITrackData GetTrackData(ETrackSource type, int id)
	{
		Dictionary<int, ITrackData> tracksByType = this.GetTracksByType(type);
		if (tracksByType == null)
		{
			return null;
		}
		return tracksByType.GetValueOrDefault(id);
	}

	// Token: 0x0601772D RID: 96045 RVA: 0x005F7EF8 File Offset: 0x005F60F8
	public void UpdateTrackData(ETrackSource type, int id, TTrackTarget newTrackTarget)
	{
		ITrackData trackData = this.GetTrackData(type, id);
		if (trackData == null)
		{
			return;
		}
		trackData.TrackTarget = newTrackTarget;
		EventSystem.Instance.Emit<ETrackSource, int, TTrackTarget>(EEventName.UpdateTrackTarget, type, id, newTrackTarget);
	}

	// Token: 0x0601772E RID: 96046 RVA: 0x005F7F2C File Offset: 0x005F612C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, ITrackData> GetTracksByType(ETrackSource type)
	{
		Dictionary<int, Dictionary<int, ITrackData>> trackInfos = this.TrackInfos;
		if (trackInfos == null)
		{
			return null;
		}
		return trackInfos.GetValueOrDefault((int)type);
	}

	// Token: 0x0601772F RID: 96047 RVA: 0x005F7F40 File Offset: 0x005F6140
	public bool IsTracking(ETrackSource type, int id)
	{
		if (type == ETrackSource.None || id == 0)
		{
			return false;
		}
		Dictionary<int, ITrackData> tracksByType = this.GetTracksByType(type);
		return tracksByType != null && tracksByType.ContainsKey(id);
	}

	// Token: 0x06017730 RID: 96048 RVA: 0x005F7F6C File Offset: 0x005F616C
	public void UpdateGroupMinDistance(int groupId, double trackDistance)
	{
		if (this.GroupMinDistance == null || groupId == 0)
		{
			return;
		}
		double num;
		if (this.GroupMinDistance.TryGetValue(groupId, out num))
		{
			if (trackDistance <= num)
			{
				this.GroupMinDistance[groupId] = trackDistance;
				return;
			}
		}
		else
		{
			this.GroupMinDistance[groupId] = trackDistance;
		}
	}

	// Token: 0x06017731 RID: 96049 RVA: 0x005F7FB4 File Offset: 0x005F61B4
	public bool CanShowInGroup(int groupId, double trackDistance)
	{
		double num;
		return this.GroupMinDistance == null || groupId == 0 || !this.GroupMinDistance.TryGetValue(groupId, out num) || trackDistance <= num;
	}

	// Token: 0x06017732 RID: 96050 RVA: 0x005F7FE7 File Offset: 0x005F61E7
	public void ClearGroupMinDistance()
	{
		Dictionary<int, double> groupMinDistance = this.GroupMinDistance;
		if (groupMinDistance == null)
		{
			return;
		}
		groupMinDistance.Clear();
	}

	// Token: 0x06017733 RID: 96051 RVA: 0x005F7FF9 File Offset: 0x005F61F9
	public bool IsForceCloseTracked()
	{
		return this.ForceCloseTracked;
	}

	// Token: 0x06017734 RID: 96052 RVA: 0x005F8001 File Offset: 0x005F6201
	public void SetForceCloseTracked(bool close)
	{
		this.ForceCloseTracked = close;
	}

	// Token: 0x17001F93 RID: 8083
	// (get) Token: 0x06017735 RID: 96053 RVA: 0x005F800A File Offset: 0x005F620A
	public static TrackModel Instance
	{
		get
		{
			return TrackModel._Instance;
		}
	}

	// Token: 0x06017736 RID: 96054 RVA: 0x005F8011 File Offset: 0x005F6211
	public static TrackModel GetOrCreateInstance()
	{
		if (TrackModel._Instance == null)
		{
			TrackModel.CreateInstance();
		}
		return TrackModel._Instance;
	}

	// Token: 0x06017737 RID: 96055 RVA: 0x005F8025 File Offset: 0x005F6225
	public static bool CreateInstance()
	{
		if (TrackModel._Instance != null)
		{
			return true;
		}
		TrackModel._Instance = new TrackModel();
		return true;
	}

	// Token: 0x06017738 RID: 96056 RVA: 0x005F803B File Offset: 0x005F623B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017739 RID: 96057 RVA: 0x005F803D File Offset: 0x005F623D
	public static void ResetStaticDefaultValue()
	{
		TrackModel._Instance = null;
	}

	// Token: 0x0601773A RID: 96058 RVA: 0x005F8045 File Offset: 0x005F6245
	static TrackModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TrackModel.CreateStaticDefaultValue), new Action(TrackModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400AF49 RID: 44873
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<int, Dictionary<int, ITrackData>> TrackInfos;

	// Token: 0x0400AF4A RID: 44874
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<int, Dictionary<int, ITrackData>> ShowGroup;

	// Token: 0x0400AF4B RID: 44875
	[Nullable(2)]
	private Dictionary<int, double> GroupMinDistance;

	// Token: 0x0400AF4D RID: 44877
	private bool ForceCloseTracked;

	// Token: 0x0400AF4E RID: 44878
	[Nullable(2)]
	private static TrackModel _Instance;
}
