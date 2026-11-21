using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.WorldMap;

// Token: 0x02000F58 RID: 3928
[NullableContext(1)]
[Nullable(0)]
public class ExploreAreaItemData
{
	// Token: 0x170010A0 RID: 4256
	// (get) Token: 0x06009D71 RID: 40305 RVA: 0x002EAC8A File Offset: 0x002E8E8A
	public bool IsShowProgressBar
	{
		get
		{
			return this.IsShowProgress && this.PlayPointTotalCount > 0 && !this.IsCompleted();
		}
	}

	// Token: 0x170010A1 RID: 4257
	// (get) Token: 0x06009D72 RID: 40306 RVA: 0x002EACA8 File Offset: 0x002E8EA8
	public bool IsFinishedPlayPoint
	{
		get
		{
			return this.PlayPointCompletedCount >= this.PlayPointTotalCount;
		}
	}

	// Token: 0x170010A2 RID: 4258
	// (get) Token: 0x06009D73 RID: 40307 RVA: 0x002EACBB File Offset: 0x002E8EBB
	public bool IsShowRecommendPlayPoint
	{
		get
		{
			return this.IsRecommend && !this.IsFinishedPlayPoint && this.IsUnlocked() && this.IsNearestPlayPointUnlock();
		}
	}

	// Token: 0x06009D74 RID: 40308 RVA: 0x002EACE0 File Offset: 0x002E8EE0
	public void Initialize(ExploreProgress config)
	{
		this.AreaId = config.Area;
		this.ExploreType = (EExploreType)config.ExploreType;
		this.PhantomSkillId = config.PhantomSkillId;
		this.UnlockTextId = config.UnlockTextId;
		this.LockTextId = config.LockTextId;
		this.UnlockConditionId = config.UnlockCondition;
		this.SpecialPlayPointIndexMap = config.SpecialPlayerMap();
		this.IsRecommend = config.IsRecommend;
		this.IsShowProgress = config.IsShowProgress;
		this.SubTypes = new int[config.SubTypeScore().Count];
		int num = 0;
		foreach (int num2 in config.SubTypeScore().Keys)
		{
			this.SubTypes[num] = num2;
			num++;
		}
		this.SpecialPlayerDesc = config.SpecialPlayerDesc;
		this.ConfigId = config.Id;
		this.IsShowTrackBtn = config.IsShowTrack;
		this.UnlockTrackType = (EExploreTrackType)config.UnlockTrackType;
		this.LockTrackType = (EExploreTrackType)config.LockTrackType;
		this.AccessPathId = config.AccessPathId;
		this.IsPhantomSkillUnlock = false;
		if (this.PhantomSkillId != 0)
		{
			this.IsPhantomSkillUnlock = RouletteModel.Instance.UnlockExploreSkillDataMap.ContainsKey(this.PhantomSkillId);
		}
		ExploreType value = ExploreProgressConfig.Instance.GetExploreTypeByType((int)this.ExploreType).Value;
		this.TypeNameId = value.Name;
		this.CountMode = value.CountMode;
		this.Icon = value.Icon;
		this.DescBg = value.DescBg;
		this.SortIndex = value.SortIndex;
		this.LockDescId = value.LockDescId;
		this.DescId = value.DescId;
	}

	// Token: 0x06009D75 RID: 40309 RVA: 0x002EAEBC File Offset: 0x002E90BC
	public void Refresh(OneExploreItem info)
	{
		this.ExploreProgress = info.ExplorePercent;
		this.ExploreProgressId = info.ExploreProgressId;
		this.CurrentCount = info.CurCount;
		this.TotalCount = info.TotalCount;
		this.IsUnlock = info.UnLock;
		this.UpdateDefaultPlayPointData();
	}

	// Token: 0x06009D76 RID: 40310 RVA: 0x002EAF0B File Offset: 0x002E910B
	public int GetProgress()
	{
		return this.ExploreProgress;
	}

	// Token: 0x06009D77 RID: 40311 RVA: 0x002EAF13 File Offset: 0x002E9113
	public int GetCurrentCount()
	{
		return this.CurrentCount;
	}

	// Token: 0x06009D78 RID: 40312 RVA: 0x002EAF1B File Offset: 0x002E911B
	public int GetTotalCount()
	{
		return this.TotalCount;
	}

	// Token: 0x06009D79 RID: 40313 RVA: 0x002EAF23 File Offset: 0x002E9123
	public string GetNameId()
	{
		return this.TypeNameId;
	}

	// Token: 0x06009D7A RID: 40314 RVA: 0x002EAF2C File Offset: 0x002E912C
	public string GetPlayDetailTitle()
	{
		string text = "PrefabTextItem_1918495092_Text";
		string nameId = this.GetNameId();
		string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(text, text);
		string multiTextByKey2 = TextConfig.Instance.GetMultiTextByKey(nameId, nameId);
		return StringUtils.Format(multiTextByKey, new string[]
		{
			multiTextByKey2
		});
	}

	// Token: 0x06009D7B RID: 40315 RVA: 0x002EAF6E File Offset: 0x002E916E
	public bool IsPercent()
	{
		return this.CountMode == 0;
	}

	// Token: 0x06009D7C RID: 40316 RVA: 0x002EAF79 File Offset: 0x002E9179
	public bool IsCompleted()
	{
		return this.ExploreProgress >= 100 || (this.CurrentCount > 0 && this.TotalCount > 0 && this.CurrentCount >= this.TotalCount);
	}

	// Token: 0x06009D7D RID: 40317 RVA: 0x002EAFAC File Offset: 0x002E91AC
	public bool HasPhantomSkill()
	{
		return this.PhantomSkillId != 0;
	}

	// Token: 0x06009D7E RID: 40318 RVA: 0x002EAFB7 File Offset: 0x002E91B7
	[NullableContext(2)]
	public string GetUnlockTextId()
	{
		return this.UnlockTextId;
	}

	// Token: 0x06009D7F RID: 40319 RVA: 0x002EAFBF File Offset: 0x002E91BF
	[NullableContext(2)]
	public string GetLockTextId()
	{
		return this.LockTextId;
	}

	// Token: 0x06009D80 RID: 40320 RVA: 0x002EAFC7 File Offset: 0x002E91C7
	public bool GetIsPhantomSkillUnlock()
	{
		return this.IsPhantomSkillUnlock;
	}

	// Token: 0x06009D81 RID: 40321 RVA: 0x002EAFD0 File Offset: 0x002E91D0
	public int? GetPhantomSkillHelpId()
	{
		ExploreTools? exploreConfigById = RouletteConfig.Instance.GetExploreConfigById(this.PhantomSkillId);
		if (exploreConfigById == null)
		{
			return null;
		}
		return new int?(exploreConfigById.GetValueOrDefault().HelpId);
	}

	// Token: 0x06009D82 RID: 40322 RVA: 0x002EB015 File Offset: 0x002E9215
	public bool IsUnlocked()
	{
		return this.IsUnlock;
	}

	// Token: 0x06009D83 RID: 40323 RVA: 0x002EB020 File Offset: 0x002E9220
	public string GetLockDetailId()
	{
		if (this.UnlockConditionId == 0)
		{
			return "";
		}
		ConditionGroup? conditionGroupConfig = ConditionConfig.Instance.GetConditionGroupConfig(this.UnlockConditionId);
		if (conditionGroupConfig != null)
		{
			return conditionGroupConfig.Value.HintText;
		}
		return "";
	}

	// Token: 0x06009D84 RID: 40324 RVA: 0x002EB06C File Offset: 0x002E926C
	private void UpdateDefaultPlayPointData()
	{
		if (this.PlayProgressDataList.Count > 0)
		{
			return;
		}
		if (!this.IsShowProgress)
		{
			return;
		}
		this.PlayPointCompletedCount = this.CurrentCount;
		this.PlayPointToBeCompletedCount = 0;
		this.PlayPointLockedCount = this.TotalCount - this.CurrentCount;
		this.PlayPointTotalCount = this.TotalCount;
		for (int i = 0; i < this.TotalCount; i++)
		{
			this.PlayProgressDataList.Add(new ExplorePlayProgressItemData
			{
				ExploreType = this.ExploreType,
				PlayPointType = EPlayPointType.Normal,
				PlayPointState = ((i < this.CurrentCount) ? EPlayPointState.Completed : EPlayPointState.Locked)
			});
		}
	}

	// Token: 0x06009D85 RID: 40325 RVA: 0x002EB10A File Offset: 0x002E930A
	public bool IsSubType(int subType)
	{
		return Array.IndexOf<int>(this.SubTypes, subType) >= 0;
	}

	// Token: 0x06009D86 RID: 40326 RVA: 0x002EB120 File Offset: 0x002E9320
	public void AddPlayPointData(IPlayPointInfo info)
	{
		this.PlayIdMap.Add(info.PlayId, info);
		this.PlayPointTotalCount++;
		if (info.PlayState == EPlayPointState.Completed)
		{
			this.PlayPointCompletedCount++;
		}
		else if (info.PlayState == EPlayPointState.ToBeCompleted)
		{
			this.PlayPointToBeCompletedCount++;
		}
		else
		{
			this.PlayPointLockedCount++;
		}
		this.PlayProgressDataList.Add(new ExplorePlayProgressItemData
		{
			ExploreType = this.ExploreType,
			PlayPointType = EPlayPointType.Normal,
			PlayPointState = info.PlayState,
			PlayPointId = new int?(info.PlayId),
			EntityId = new int?(info.EntityId),
			IsClear = info.IsClear,
			ClearInfo = info.ClearInfo,
			IsUnlock = new bool?(info.IsUnlock)
		});
	}

	// Token: 0x06009D87 RID: 40327 RVA: 0x002EB207 File Offset: 0x002E9407
	public void ClearPlayPointData()
	{
		this.PlayIdMap.Clear();
		this.PlayPointTotalCount = 0;
		this.PlayPointCompletedCount = 0;
		this.PlayPointToBeCompletedCount = 0;
		this.PlayPointLockedCount = 0;
		this.PlayProgressDataList.Clear();
	}

	// Token: 0x06009D88 RID: 40328 RVA: 0x002EB23C File Offset: 0x002E943C
	public void PlayPointDataAddFinish()
	{
		if (this.PlayProgressDataList.Count == 0)
		{
			return;
		}
		this.PlayProgressDataList.Sort((IExplorePlayProgressItemData a, IExplorePlayProgressItemData b) => b.PlayPointState - a.PlayPointState);
		foreach (KeyValuePair<int, int> keyValuePair in this.SpecialPlayPointIndexMap)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			if (key < this.PlayProgressDataList.Count)
			{
				this.PlayProgressDataList[key].PlayPointType = (EPlayPointType)value;
			}
		}
	}

	// Token: 0x06009D89 RID: 40329 RVA: 0x002EB2F0 File Offset: 0x002E94F0
	public bool HasSpecialPlayPoint()
	{
		using (List<IExplorePlayProgressItemData>.Enumerator enumerator = this.PlayProgressDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.PlayPointType == EPlayPointType.Hidden)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06009D8A RID: 40330 RVA: 0x002EB34C File Offset: 0x002E954C
	public bool IsNearestPlayPointUnlock()
	{
		MapMark? nearTrackMapMark = this.GetNearTrackMapMark();
		bool result = true;
		if (nearTrackMapMark == null || nearTrackMapMark.Value.GameplayLockJumpId == 0 || nearTrackMapMark.Value.GameplayLockText == "")
		{
			return result;
		}
		if (!this.GetPlayIdIsUnlock(nearTrackMapMark.Value.RelativeId))
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06009D8B RID: 40331 RVA: 0x002EB3B3 File Offset: 0x002E95B3
	public void TrackPoint()
	{
		if (this.PlayIdMap.Count > 0)
		{
			this.TrackPlayPoint();
			return;
		}
		this.TrackEntityPoint();
	}

	// Token: 0x06009D8C RID: 40332 RVA: 0x002EB3D4 File Offset: 0x002E95D4
	private void TrackEntityPoint()
	{
		int exploratoryDegree = this.SubTypes[0];
		ExploreProgressController.Instance.ExploreEntityTraceRequest(exploratoryDegree, this.AreaId);
	}

	// Token: 0x06009D8D RID: 40333 RVA: 0x002EB3FC File Offset: 0x002E95FC
	public bool TrackPlayPoint()
	{
		if (this.TrackExploreType())
		{
			return true;
		}
		if (this.IsFinishedPlayPoint)
		{
			return false;
		}
		EPlayPointState trackPlayState = this.GetTrackPlayState();
		List<IPlayPointInfo> playPointIdsByState = this.GetPlayPointIdsByState(trackPlayState);
		if (playPointIdsByState.Count == 0)
		{
			return false;
		}
		MapMark? markByPointState = this.GetMarkByPointState(trackPlayState, playPointIdsByState);
		if (markByPointState == null)
		{
			return false;
		}
		if (trackPlayState == EPlayPointState.ToBeCompleted)
		{
			if (!MapModel.Instance.IsMarkFogUnlock(markByPointState.Value.MarkId))
			{
				GenericPromptController.Instance.ShowPromptByCode("MapAreaIsLock", Array.Empty<object>());
				return false;
			}
			if (!MapModel.Instance.IsConfigMarkIdUnlock(markByPointState.Value.MarkId))
			{
				MapModel.Instance.CreateTempMapMark(markByPointState.Value.MarkId);
			}
			EventSystem.Instance.Emit<NavigateMark>(EEventName.WorldMapNavigate, new NavigateMark
			{
				MarkId = markByPointState.Value.MarkId,
				MarkType = (EMarkType)markByPointState.Value.ObjectType,
				Focal = new bool?(true),
				NeedTempShow = new bool?(true)
			});
		}
		else if (trackPlayState == EPlayPointState.Locked)
		{
			this.TrackLockedPlayPointMark(markByPointState.Value);
		}
		return true;
	}

	// Token: 0x06009D8E RID: 40334 RVA: 0x002EB520 File Offset: 0x002E9720
	public MapMark? GetNearTrackMapMark()
	{
		if (this.PlayIdMap.Count <= 0)
		{
			return null;
		}
		if (this.IsFinishedPlayPoint)
		{
			return null;
		}
		EPlayPointState trackPlayState = this.GetTrackPlayState();
		List<IPlayPointInfo> playPointIdsByState = this.GetPlayPointIdsByState(trackPlayState);
		if (playPointIdsByState.Count == 0)
		{
			return null;
		}
		return this.GetMarkByPointState(trackPlayState, playPointIdsByState);
	}

	// Token: 0x06009D8F RID: 40335 RVA: 0x002EB580 File Offset: 0x002E9780
	public MapMark? GetMarkByPointState(EPlayPointState state, List<IPlayPointInfo> playIds)
	{
		EExploreTrackType eexploreTrackType = (state == EPlayPointState.Locked) ? this.LockTrackType : this.UnlockTrackType;
		if (eexploreTrackType == EExploreTrackType.Nearest)
		{
			return this.GetNearMapMarkByPlayIds(playIds);
		}
		if (eexploreTrackType != EExploreTrackType.MinId)
		{
			return null;
		}
		return this.GetMinMarkIdPlayPoint(playIds);
	}

	// Token: 0x06009D90 RID: 40336 RVA: 0x002EB5C4 File Offset: 0x002E97C4
	public bool GetPlayIdIsUnlock(int playId)
	{
		IPlayPointInfo playPointInfo;
		return !this.PlayIdMap.TryGetValue(playId, out playPointInfo) || playPointInfo.IsUnlock;
	}

	// Token: 0x06009D91 RID: 40337 RVA: 0x002EB5EC File Offset: 0x002E97EC
	private void TrackLockedPlayPointMark(MapMark nearMark)
	{
		IPlayPointInfo findPlayIdInfo = this.FindPlayIdInfo;
		if (findPlayIdInfo != null && findPlayIdInfo.IsClear.GetValueOrDefault())
		{
			this.FindClearPlayPointMark();
			return;
		}
		NavigateMarkShowRange navigateMarkShowRange = new NavigateMarkShowRange
		{
			MarkId = nearMark.MarkId,
			MarkType = (EMarkType)nearMark.ObjectType,
			Tips = "NoPlayPoint_Text",
			GamePlayId = new int?(nearMark.RelativeId),
			ExploreTypeName = this.GetNameId()
		};
		WorldMapModel.Instance.NavigateMarkShowRangeInfo = navigateMarkShowRange;
		EventSystem.Instance.Emit<NavigateMarkShowRange>(EEventName.NavigateMarkAndShowRange, navigateMarkShowRange);
	}

	// Token: 0x06009D92 RID: 40338 RVA: 0x002EB684 File Offset: 0x002E9884
	private void FindClearPlayPointMark()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ExploreClearPlayPointMark);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			IPlayPointInfo findPlayIdInfo = this.FindPlayIdInfo;
			string text = (findPlayIdInfo != null) ? findPlayIdInfo.ClearInfo : null;
			if (text == null)
			{
				return;
			}
			string[] array = text.Split('_', StringSplitOptions.None);
			string a = array[0].ToLower();
			string clearId = array[1];
			if (a == "q")
			{
				this.FindQuestMark(clearId);
				return;
			}
			if (a == "l")
			{
				this.FindPlayPointMark(clearId);
			}
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06009D93 RID: 40339 RVA: 0x002EB6C0 File Offset: 0x002E98C0
	private void FindQuestMark(string clearId)
	{
		int questId = int.Parse(clearId);
		global::Quest quest = QuestNewModel.Instance.GetQuest(questId);
		int? num;
		if (quest == null)
		{
			num = null;
		}
		else
		{
			BehaviorNodeBase currentActiveChildQuestNode = quest.GetCurrentActiveChildQuestNode();
			num = ((currentActiveChildQuestNode != null) ? new int?(currentActiveChildQuestNode.NodeId) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		int valueOrDefault2 = ((quest != null) ? quest.GetDefaultMark(valueOrDefault) : null).GetValueOrDefault();
		if (valueOrDefault2 == 0 || (quest != null && quest.IsSuspend()))
		{
			return;
		}
		EventSystem.Instance.Emit<NavigateMark>(EEventName.WorldMapNavigate, new NavigateMark
		{
			MarkId = valueOrDefault2,
			MarkType = EMarkType.Quest,
			Focal = new bool?(true),
			NeedTempShow = new bool?(true)
		});
		this.CheckClearFindMarkIsHideRange(valueOrDefault2, EMarkType.Quest);
	}

	// Token: 0x06009D94 RID: 40340 RVA: 0x002EB790 File Offset: 0x002E9990
	private void FindPlayPointMark(string clearId)
	{
		int playId = int.Parse(clearId);
		MapMark? mapMarkByPlayId = this.GetMapMarkByPlayId(playId);
		if (mapMarkByPlayId == null)
		{
			return;
		}
		EventSystem.Instance.Emit<NavigateMark>(EEventName.WorldMapNavigate, new NavigateMark
		{
			MarkId = mapMarkByPlayId.Value.MarkId,
			MarkType = (EMarkType)mapMarkByPlayId.Value.ObjectType,
			Focal = new bool?(true),
			NeedTempShow = new bool?(true)
		});
		this.CheckClearFindMarkIsHideRange(mapMarkByPlayId.Value.MarkId, (EMarkType)mapMarkByPlayId.Value.ObjectType);
	}

	// Token: 0x06009D95 RID: 40341 RVA: 0x002EB834 File Offset: 0x002E9A34
	private void CheckClearFindMarkIsHideRange(int markId, EMarkType markType)
	{
		NavigateMarkShowRange navigateMarkShowRangeInfo = WorldMapModel.Instance.NavigateMarkShowRangeInfo;
		if (navigateMarkShowRangeInfo != null && navigateMarkShowRangeInfo.MarkId == markId && navigateMarkShowRangeInfo != null && navigateMarkShowRangeInfo.MarkType == markType)
		{
			EventSystem.Instance.Emit(EEventName.HideNavigateMarkRange);
		}
	}

	// Token: 0x06009D96 RID: 40342 RVA: 0x002EB874 File Offset: 0x002E9A74
	private bool TrackExploreType()
	{
		if (this.PlayIdMap.Count > 0)
		{
			return false;
		}
		ScrollingTipsController instance = ScrollingTipsController.Instance;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 2);
		defaultInterpolatedStringHandler.AppendLiteral("Track ExploreType: ");
		defaultInterpolatedStringHandler.AppendFormatted<EExploreType>(this.ExploreType);
		defaultInterpolatedStringHandler.AppendLiteral(", AreaId: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.AreaId);
		instance.ShowTipsByText(defaultInterpolatedStringHandler.ToStringAndClear());
		return true;
	}

	// Token: 0x06009D97 RID: 40343 RVA: 0x002EB8E0 File Offset: 0x002E9AE0
	private EPlayPointState GetTrackPlayState()
	{
		EPlayPointState result = EPlayPointState.Locked;
		if (this.PlayPointToBeCompletedCount > 0)
		{
			result = EPlayPointState.ToBeCompleted;
		}
		return result;
	}

	// Token: 0x06009D98 RID: 40344 RVA: 0x002EB8FC File Offset: 0x002E9AFC
	private List<IPlayPointInfo> GetPlayPointIdsByState(EPlayPointState findState)
	{
		List<IPlayPointInfo> list = new List<IPlayPointInfo>();
		foreach (IPlayPointInfo playPointInfo in this.PlayIdMap.Values)
		{
			if (playPointInfo.PlayState == findState)
			{
				list.Add(playPointInfo);
			}
		}
		int count = list.Count;
		return list;
	}

	// Token: 0x06009D99 RID: 40345 RVA: 0x002EB96C File Offset: 0x002E9B6C
	private MapMark? GetNearMapMarkByPlayIds(List<IPlayPointInfo> infoList)
	{
		if (infoList.Count == 0)
		{
			return null;
		}
		int scale = 1000;
		global::Vector myPos = WorldMapModel.Instance.GetPlayerPosition();
		myPos.DivisionEqual((double)scale);
		List<ValueTuple<IPlayPointInfo, MapMark?>> list = new List<ValueTuple<IPlayPointInfo, MapMark?>>();
		foreach (IPlayPointInfo playPointInfo in infoList)
		{
			MapMark? mapMarkByPlayInfo = this.GetMapMarkByPlayInfo(playPointInfo);
			if (mapMarkByPlayInfo != null)
			{
				list.Add(new ValueTuple<IPlayPointInfo, MapMark?>(playPointInfo, mapMarkByPlayInfo));
			}
		}
		if (list.Count == 0)
		{
			return null;
		}
		list.Sort(delegate([TupleElementNames(new string[]
		{
			"Info",
			"Mark"
		})] [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<IPlayPointInfo, MapMark?> a, [TupleElementNames(new string[]
		{
			"Info",
			"Mark"
		})] [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<IPlayPointInfo, MapMark?> b)
		{
			if (a.Item1.IsUnlock == b.Item1.IsUnlock)
			{
				global::Vector entityPosition = WorldMapModel.Instance.GetEntityPosition(a.Item2.Value.EntityConfigId, a.Item2.Value.MapId, false);
				global::Vector entityPosition2 = WorldMapModel.Instance.GetEntityPosition(b.Item2.Value.EntityConfigId, b.Item2.Value.MapId, false);
				entityPosition.DivisionEqual((double)(scale * 100));
				entityPosition2.DivisionEqual((double)(scale * 100));
				double num = global::Vector.DistSquared(myPos, entityPosition);
				double value = global::Vector.DistSquared(myPos, entityPosition2);
				return num.CompareTo(value);
			}
			if (!a.Item1.IsUnlock)
			{
				return 1;
			}
			return -1;
		});
		ValueTuple<IPlayPointInfo, MapMark?> valueTuple = list[0];
		this.FindPlayIdInfo = valueTuple.Item1;
		return valueTuple.Item2;
	}

	// Token: 0x06009D9A RID: 40346 RVA: 0x002EBA64 File Offset: 0x002E9C64
	private MapMark? GetMinMarkIdPlayPoint(List<IPlayPointInfo> infoList)
	{
		if (infoList.Count == 0)
		{
			return null;
		}
		List<ValueTuple<IPlayPointInfo, MapMark?>> list = new List<ValueTuple<IPlayPointInfo, MapMark?>>();
		foreach (IPlayPointInfo playPointInfo in infoList)
		{
			MapMark? mapMarkByPlayInfo = this.GetMapMarkByPlayInfo(playPointInfo);
			if (mapMarkByPlayInfo != null)
			{
				list.Add(new ValueTuple<IPlayPointInfo, MapMark?>(playPointInfo, mapMarkByPlayInfo));
			}
		}
		if (list.Count == 0)
		{
			return null;
		}
		list.Sort(delegate([TupleElementNames(new string[]
		{
			"Info",
			"Mark"
		})] [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<IPlayPointInfo, MapMark?> a, [TupleElementNames(new string[]
		{
			"Info",
			"Mark"
		})] [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<IPlayPointInfo, MapMark?> b)
		{
			if (a.Item1.IsUnlock == b.Item1.IsUnlock)
			{
				return a.Item2.Value.MarkId - b.Item2.Value.MarkId;
			}
			if (!a.Item1.IsUnlock)
			{
				return 1;
			}
			return -1;
		});
		ValueTuple<IPlayPointInfo, MapMark?> valueTuple = list[0];
		this.FindPlayIdInfo = valueTuple.Item1;
		return valueTuple.Item2;
	}

	// Token: 0x06009D9B RID: 40347 RVA: 0x002EBB38 File Offset: 0x002E9D38
	private MapMark? GetMapMarkByPlayInfo(IPlayPointInfo info)
	{
		return this.GetMapMarkByPlayId(info.PlayId);
	}

	// Token: 0x06009D9C RID: 40348 RVA: 0x002EBB48 File Offset: 0x002E9D48
	public MapMark? GetMapMarkByPlayId(int playId)
	{
		ExploreAreaData exploreAreaData = ExploreProgressModel.Instance.GetExploreAreaData(this.AreaId);
		if (exploreAreaData == null)
		{
			return null;
		}
		return MapConfig.Instance.GetMapMarkByRelativeId(playId, exploreAreaData.GetSceneId());
	}

	// Token: 0x06009D9D RID: 40349 RVA: 0x002EBB84 File Offset: 0x002E9D84
	public EPlayPointState[] GetPlayPointStateList()
	{
		EPlayPointState[] array = new EPlayPointState[this.PlayProgressDataList.Count];
		for (int i = 0; i < this.PlayProgressDataList.Count; i++)
		{
			array[i] = this.PlayProgressDataList[i].PlayPointState;
		}
		return array;
	}

	// Token: 0x06009D9E RID: 40350 RVA: 0x002EBBCD File Offset: 0x002E9DCD
	public void LogInfo()
	{
	}

	// Token: 0x06009D9F RID: 40351 RVA: 0x002EBBCF File Offset: 0x002E9DCF
	public void FinishNewRecommendPlay()
	{
		this.IsNewRecommendPlay = false;
	}

	// Token: 0x06009DA0 RID: 40352 RVA: 0x002EBBD8 File Offset: 0x002E9DD8
	[NullableContext(2)]
	public void SetSequenceData(ExploreAreaItemData data = null)
	{
		this.SequenceData = data;
	}

	// Token: 0x06009DA1 RID: 40353 RVA: 0x002EBBE1 File Offset: 0x002E9DE1
	public void SetFlagSequenceData(bool flag)
	{
		this.FlagSequenceData = flag;
	}

	// Token: 0x06009DA2 RID: 40354 RVA: 0x002EBBEA File Offset: 0x002E9DEA
	public bool GetFlagSequenceDataAndClean()
	{
		bool flagSequenceData = this.FlagSequenceData;
		this.FlagSequenceData = false;
		return flagSequenceData;
	}

	// Token: 0x06009DA3 RID: 40355 RVA: 0x002EBBFC File Offset: 0x002E9DFC
	public List<IExplorePlayProgressItemData> GetPlayProgressDataIgnoreHiddenList()
	{
		List<IExplorePlayProgressItemData> list = new List<IExplorePlayProgressItemData>();
		foreach (IExplorePlayProgressItemData explorePlayProgressItemData in this.PlayProgressDataList)
		{
			ExplorePlayProgressItemData item = new ExplorePlayProgressItemData
			{
				ExploreType = explorePlayProgressItemData.ExploreType,
				PlayPointType = explorePlayProgressItemData.PlayPointType,
				PlayPointState = explorePlayProgressItemData.PlayPointState,
				PlayPointId = explorePlayProgressItemData.PlayPointId,
				LastPlayPointState = explorePlayProgressItemData.LastPlayPointState,
				EntityId = explorePlayProgressItemData.EntityId,
				IgnoreHiddenType = new bool?(true),
				IsClear = explorePlayProgressItemData.IsClear,
				ClearInfo = explorePlayProgressItemData.ClearInfo,
				IsUnlock = explorePlayProgressItemData.IsUnlock
			};
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06009DA4 RID: 40356 RVA: 0x002EBCDC File Offset: 0x002E9EDC
	public void SetEntityList(int[] entityList)
	{
		this.EntityList = entityList;
		this.CalcEntityDistance();
		this.CreateEntityMark();
	}

	// Token: 0x06009DA5 RID: 40357 RVA: 0x002EBCF4 File Offset: 0x002E9EF4
	public void CalcEntityDistance()
	{
		if (this.EntityList == null || this.EntityList.Length < 2)
		{
			return;
		}
		int num = 1000;
		Aki.Config.Area? areaInfo = AreaConfig.Instance.GetAreaInfo(this.AreaId);
		if (areaInfo == null)
		{
			return;
		}
		int mapConfigId = areaInfo.Value.MapConfigId;
		global::Vector playerPosition = WorldMapModel.Instance.GetPlayerPosition();
		double num2 = 2147483647.0;
		int num3 = 0;
		playerPosition.DivisionEqual((double)num);
		for (int i = 0; i < this.EntityList.Length; i++)
		{
			int pbDataId = this.EntityList[i];
			global::Vector entityPosition = WorldMapModel.Instance.GetEntityPosition(pbDataId, mapConfigId, false);
			entityPosition.DivisionEqual((double)num);
			double num4 = global::Vector.DistSquared(playerPosition, entityPosition);
			if (num4 < num2)
			{
				num2 = num4;
				num3 = i;
			}
		}
		if (num3 > 0)
		{
			int item = this.EntityList[num3];
			List<int> list = new List<int>(this.EntityList);
			list.RemoveAt(num3);
			list.Insert(0, item);
			this.EntityList = list.ToArray();
		}
	}

	// Token: 0x06009DA6 RID: 40358 RVA: 0x002EBDFC File Offset: 0x002E9FFC
	public void CreateEntityMark()
	{
		if (this.EntityList.Length == 0)
		{
			Log.Instance.Error(ELogModule.ExploreProgress, ELogAuthor.CB, "实体Id列表为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		EMarkType markType;
		if (!ExploreProgressDefine.exploreType2MarkType.TryGetValue((int)this.ExploreType, out markType))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ExploreProgress;
			ELogAuthor author = ELogAuthor.CB;
			string message = "找不到探索项对应的标记类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ExploreType", this.ExploreType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		int configId;
		if (!ExploreProgressDefine.exploreType2Config.TryGetValue((int)this.ExploreType, out configId))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.ExploreProgress;
			ELogAuthor author2 = ELogAuthor.CB;
			string message2 = "找不到探索项对应的标记id配置";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ExploreType", this.ExploreType);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		Aki.Config.Area? areaInfo = AreaConfig.Instance.GetAreaInfo(this.AreaId);
		if (areaInfo == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.ExploreProgress;
			ELogAuthor author3 = ELogAuthor.CB;
			string message3 = "找不到探索项对应的区域id配置";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("ExploreType", this.ExploreType);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return;
		}
		int entityId = this.EntityList[0];
		int num = MapModel.Instance.CreateDyMarkByEntity(entityId, markType, configId, areaInfo.Value.MapConfigId);
		MapModel.Instance.AddPendingTempMapMarkList(num);
		EventSystem.Instance.Emit<NavigateMark>(EEventName.WorldMapNavigate, new NavigateMark
		{
			MarkId = num,
			MarkType = markType,
			Focal = new bool?(true)
		});
	}

	// Token: 0x04005D81 RID: 23937
	public int AreaId;

	// Token: 0x04005D82 RID: 23938
	public EExploreType ExploreType;

	// Token: 0x04005D83 RID: 23939
	public int ExploreProgressId;

	// Token: 0x04005D84 RID: 23940
	public int ConfigId;

	// Token: 0x04005D85 RID: 23941
	private int ExploreProgress;

	// Token: 0x04005D86 RID: 23942
	private int CurrentCount;

	// Token: 0x04005D87 RID: 23943
	private int TotalCount;

	// Token: 0x04005D88 RID: 23944
	[Nullable(2)]
	private string TypeNameId;

	// Token: 0x04005D89 RID: 23945
	private int PhantomSkillId;

	// Token: 0x04005D8A RID: 23946
	[Nullable(2)]
	private string UnlockTextId;

	// Token: 0x04005D8B RID: 23947
	[Nullable(2)]
	private string LockTextId;

	// Token: 0x04005D8C RID: 23948
	private bool IsPhantomSkillUnlock;

	// Token: 0x04005D8D RID: 23949
	private int CountMode;

	// Token: 0x04005D8E RID: 23950
	public string Icon;

	// Token: 0x04005D8F RID: 23951
	public string DescBg;

	// Token: 0x04005D90 RID: 23952
	public int SortIndex;

	// Token: 0x04005D91 RID: 23953
	public string LockDescId;

	// Token: 0x04005D92 RID: 23954
	public string DescId;

	// Token: 0x04005D93 RID: 23955
	public int[] SubTypes;

	// Token: 0x04005D94 RID: 23956
	public int UnlockConditionId;

	// Token: 0x04005D95 RID: 23957
	public int AccessPathId;

	// Token: 0x04005D96 RID: 23958
	public Dictionary<int, int> SpecialPlayPointIndexMap = new Dictionary<int, int>();

	// Token: 0x04005D97 RID: 23959
	public bool IsRecommend;

	// Token: 0x04005D98 RID: 23960
	private bool IsShowProgress;

	// Token: 0x04005D99 RID: 23961
	public bool IsShowTrackBtn;

	// Token: 0x04005D9A RID: 23962
	public bool IsNewRecommendPlay;

	// Token: 0x04005D9B RID: 23963
	[Nullable(2)]
	public ExploreAreaItemData SequenceData;

	// Token: 0x04005D9C RID: 23964
	public bool FlagSequenceData;

	// Token: 0x04005D9D RID: 23965
	public readonly List<IExplorePlayProgressItemData> PlayProgressDataList = new List<IExplorePlayProgressItemData>();

	// Token: 0x04005D9E RID: 23966
	public int PlayPointTotalCount;

	// Token: 0x04005D9F RID: 23967
	public int PlayPointCompletedCount;

	// Token: 0x04005DA0 RID: 23968
	public int PlayPointToBeCompletedCount;

	// Token: 0x04005DA1 RID: 23969
	public int PlayPointLockedCount;

	// Token: 0x04005DA2 RID: 23970
	public EExploreTrackType UnlockTrackType;

	// Token: 0x04005DA3 RID: 23971
	public EExploreTrackType LockTrackType;

	// Token: 0x04005DA4 RID: 23972
	public readonly Dictionary<int, IPlayPointInfo> PlayIdMap = new Dictionary<int, IPlayPointInfo>();

	// Token: 0x04005DA5 RID: 23973
	[Nullable(2)]
	private IPlayPointInfo FindPlayIdInfo;

	// Token: 0x04005DA6 RID: 23974
	public string SpecialPlayerDesc;

	// Token: 0x04005DA7 RID: 23975
	private bool IsUnlock;

	// Token: 0x04005DA8 RID: 23976
	private int[] EntityList;
}
