using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x02002190 RID: 8592
[NullableContext(1)]
[Nullable(0)]
public class TrackModel : ModelBase
{
	// Token: 0x17001FEA RID: 8170
	// (get) Token: 0x06015153 RID: 86355 RVA: 0x006246B1 File Offset: 0x006228B1
	// (set) Token: 0x06015154 RID: 86356 RVA: 0x006246B9 File Offset: 0x006228B9
	public int DefaultTrackHideDis { get; private set; }

	// Token: 0x06015155 RID: 86357 RVA: 0x006246C2 File Offset: 0x006228C2
	protected override bool OnInit()
	{
		this.TrackInfos = new Dictionary<int, Dictionary<int, ITrackData>>();
		this.ShowGroup = new Dictionary<int, Dictionary<int, ITrackData>>();
		this.GroupMinDistance = new Dictionary<int, double>();
		this.DefaultTrackHideDis = int.Parse(QuestNewConfig.Instance.GetGlobalConfig("TrackMarkHideDis"));
		return true;
	}

	// Token: 0x06015156 RID: 86358 RVA: 0x00624700 File Offset: 0x00622900
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

	// Token: 0x06015157 RID: 86359 RVA: 0x0062475C File Offset: 0x0062295C
	protected override bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x06015158 RID: 86360 RVA: 0x00624760 File Offset: 0x00622960
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

	// Token: 0x06015159 RID: 86361 RVA: 0x006247DC File Offset: 0x006229DC
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

	// Token: 0x0601515A RID: 86362 RVA: 0x0062480F File Offset: 0x00622A0F
	public void ClearTrackData()
	{
		this.TrackInfos.Clear();
		this.ShowGroup.Clear();
		EventSystem.Instance.Emit(EEventName.ClearTrackMark);
	}

	// Token: 0x0601515B RID: 86363 RVA: 0x00624838 File Offset: 0x00622A38
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

	// Token: 0x0601515C RID: 86364 RVA: 0x006248B0 File Offset: 0x00622AB0
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

	// Token: 0x0601515D RID: 86365 RVA: 0x00624908 File Offset: 0x00622B08
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

	// Token: 0x0601515E RID: 86366 RVA: 0x006249F8 File Offset: 0x00622BF8
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

	// Token: 0x0601515F RID: 86367 RVA: 0x00624A1C File Offset: 0x00622C1C
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

	// Token: 0x06015160 RID: 86368 RVA: 0x00624A50 File Offset: 0x00622C50
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

	// Token: 0x06015161 RID: 86369 RVA: 0x00624A64 File Offset: 0x00622C64
	public bool IsTracking(ETrackSource type, int id)
	{
		if (type == ETrackSource.None || id == 0)
		{
			return false;
		}
		Dictionary<int, ITrackData> tracksByType = this.GetTracksByType(type);
		return tracksByType != null && tracksByType.ContainsKey(id);
	}

	// Token: 0x06015162 RID: 86370 RVA: 0x00624A90 File Offset: 0x00622C90
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

	// Token: 0x06015163 RID: 86371 RVA: 0x00624AD8 File Offset: 0x00622CD8
	public bool CanShowInGroup(int groupId, double trackDistance)
	{
		double num;
		return this.GroupMinDistance == null || groupId == 0 || !this.GroupMinDistance.TryGetValue(groupId, out num) || trackDistance <= num;
	}

	// Token: 0x06015164 RID: 86372 RVA: 0x00624B0B File Offset: 0x00622D0B
	public void ClearGroupMinDistance()
	{
		Dictionary<int, double> groupMinDistance = this.GroupMinDistance;
		if (groupMinDistance == null)
		{
			return;
		}
		groupMinDistance.Clear();
	}

	// Token: 0x06015165 RID: 86373 RVA: 0x00624B1D File Offset: 0x00622D1D
	public bool IsForceCloseTracked()
	{
		return this.ForceCloseTracked;
	}

	// Token: 0x06015166 RID: 86374 RVA: 0x00624B25 File Offset: 0x00622D25
	public void SetForceCloseTracked(bool close)
	{
		this.ForceCloseTracked = close;
	}

	// Token: 0x17001FEB RID: 8171
	// (get) Token: 0x06015167 RID: 86375 RVA: 0x00624B2E File Offset: 0x00622D2E
	public static TrackModel Instance
	{
		get
		{
			return TrackModel._Instance;
		}
	}

	// Token: 0x06015168 RID: 86376 RVA: 0x00624B35 File Offset: 0x00622D35
	public static TrackModel GetOrCreateInstance()
	{
		if (TrackModel._Instance == null)
		{
			TrackModel.CreateInstance();
		}
		return TrackModel._Instance;
	}

	// Token: 0x06015169 RID: 86377 RVA: 0x00624B49 File Offset: 0x00622D49
	public static bool CreateInstance()
	{
		if (TrackModel._Instance != null)
		{
			return true;
		}
		TrackModel._Instance = new TrackModel();
		return true;
	}

	// Token: 0x0601516A RID: 86378 RVA: 0x00624B5F File Offset: 0x00622D5F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601516B RID: 86379 RVA: 0x00624B61 File Offset: 0x00622D61
	public static void ResetStaticDefaultValue()
	{
		TrackModel._Instance = null;
	}

	// Token: 0x0601516C RID: 86380 RVA: 0x00624B69 File Offset: 0x00622D69
	static TrackModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TrackModel.CreateStaticDefaultValue), new Action(TrackModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B34E RID: 45902
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<int, Dictionary<int, ITrackData>> TrackInfos;

	// Token: 0x0400B34F RID: 45903
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<int, Dictionary<int, ITrackData>> ShowGroup;

	// Token: 0x0400B350 RID: 45904
	[Nullable(2)]
	private Dictionary<int, double> GroupMinDistance;

	// Token: 0x0400B352 RID: 45906
	private bool ForceCloseTracked;

	// Token: 0x0400B353 RID: 45907
	[Nullable(2)]
	private static TrackModel _Instance;
}
