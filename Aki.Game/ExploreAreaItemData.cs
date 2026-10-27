using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001A99 RID: 6809
[NullableContext(1)]
[Nullable(0)]
public class ExploreAreaItemData
{
	// Token: 0x1700107B RID: 4219
	// (get) Token: 0x0600C960 RID: 51552 RVA: 0x002DFB3E File Offset: 0x002DDD3E
	public bool IsShowProgressBar
	{
		get
		{
			return this.IsShowProgress && this.PlayPointTotalCount > 0 && !this.IsCompleted();
		}
	}

	// Token: 0x1700107C RID: 4220
	// (get) Token: 0x0600C961 RID: 51553 RVA: 0x002DFB5C File Offset: 0x002DDD5C
	public bool IsFinishedPlayPoint
	{
		get
		{
			return this.PlayPointCompletedCount >= this.PlayPointTotalCount;
		}
	}

	// Token: 0x1700107D RID: 4221
	// (get) Token: 0x0600C962 RID: 51554 RVA: 0x002DFB6F File Offset: 0x002DDD6F
	public bool IsShowRecommendPlayPoint
	{
		get
		{
			return this.IsRecommend && !this.IsFinishedPlayPoint && this.IsUnlocked() && this.IsNearestPlayPointUnlock();
		}
	}

	// Token: 0x0600C963 RID: 51555 RVA: 0x002DFB94 File Offset: 0x002DDD94
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

	// Token: 0x0600C964 RID: 51556 RVA: 0x002DFD70 File Offset: 0x002DDF70
	public void Refresh(OneExploreItem info)
	{
		this.ExploreProgress = info.ExplorePercent;
		this.ExploreProgressId = info.ExploreProgressId;
		this.CurrentCount = info.CurCount;
		this.TotalCount = info.TotalCount;
		this.IsUnlock = info.UnLock;
		this.UpdateDefaultPlayPointData();
	}

	// Token: 0x0600C965 RID: 51557 RVA: 0x002DFDBF File Offset: 0x002DDFBF
	public int GetProgress()
	{
		return this.ExploreProgress;
	}

	// Token: 0x0600C966 RID: 51558 RVA: 0x002DFDC7 File Offset: 0x002DDFC7
	public int GetCurrentCount()
	{
		return this.CurrentCount;
	}

	// Token: 0x0600C967 RID: 51559 RVA: 0x002DFDCF File Offset: 0x002DDFCF
	public int GetTotalCount()
	{
		return this.TotalCount;
	}

	// Token: 0x0600C968 RID: 51560 RVA: 0x002DFDD7 File Offset: 0x002DDFD7
	public string GetNameId()
	{
		return this.TypeNameId;
	}

	// Token: 0x0600C969 RID: 51561 RVA: 0x002DFDE0 File Offset: 0x002DDFE0
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

	// Token: 0x0600C96A RID: 51562 RVA: 0x002DFE22 File Offset: 0x002DE022
	public bool IsPercent()
	{
		return this.CountMode == 0;
	}

	// Token: 0x0600C96B RID: 51563 RVA: 0x002DFE2D File Offset: 0x002DE02D
	public bool IsCompleted()
	{
		return this.ExploreProgress >= 100 || (this.CurrentCount > 0 && this.TotalCount > 0 && this.CurrentCount >= this.TotalCount);
	}

	// Token: 0x0600C96C RID: 51564 RVA: 0x002DFE60 File Offset: 0x002DE060
	public bool HasPhantomSkill()
	{
		return this.PhantomSkillId != 0;
	}

	// Token: 0x0600C96D RID: 51565 RVA: 0x002DFE6B File Offset: 0x002DE06B
	[NullableContext(2)]
	public string GetUnlockTextId()
	{
		return this.UnlockTextId;
	}

	// Token: 0x0600C96E RID: 51566 RVA: 0x002DFE73 File Offset: 0x002DE073
	[NullableContext(2)]
	public string GetLockTextId()
	{
		return this.LockTextId;
	}

	// Token: 0x0600C96F RID: 51567 RVA: 0x002DFE7B File Offset: 0x002DE07B
	public bool GetIsPhantomSkillUnlock()
	{
		return this.IsPhantomSkillUnlock;
	}

	// Token: 0x0600C970 RID: 51568 RVA: 0x002DFE84 File Offset: 0x002DE084
	public int? GetPhantomSkillHelpId()
	{
		ExploreTools? exploreConfigById = RouletteConfig.Instance.GetExploreConfigById(this.PhantomSkillId);
		if (exploreConfigById == null)
		{
			return null;
		}
		return new int?(exploreConfigById.GetValueOrDefault().HelpId);
	}

	// Token: 0x0600C971 RID: 51569 RVA: 0x002DFEC9 File Offset: 0x002DE0C9
	public bool IsUnlocked()
	{
		return this.IsUnlock;
	}

	// Token: 0x0600C972 RID: 51570 RVA: 0x002DFED4 File Offset: 0x002DE0D4
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

	// Token: 0x0600C973 RID: 51571 RVA: 0x002DFF20 File Offset: 0x002DE120
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

	// Token: 0x0600C974 RID: 51572 RVA: 0x002DFFBE File Offset: 0x002DE1BE
	public bool IsSubType(int subType)
	{
		return this.SubTypes.Contains(subType);
	}

	// Token: 0x0600C975 RID: 51573 RVA: 0x002DFFCC File Offset: 0x002DE1CC
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

	// Token: 0x0600C976 RID: 51574 RVA: 0x002E00B3 File Offset: 0x002DE2B3
	public void ClearPlayPointData()
	{
		this.PlayIdMap.Clear();
		this.PlayPointTotalCount = 0;
		this.PlayPointCompletedCount = 0;
		this.PlayPointToBeCompletedCount = 0;
		this.PlayPointLockedCount = 0;
		this.PlayProgressDataList.Clear();
	}

	// Token: 0x0600C977 RID: 51575 RVA: 0x002E00E8 File Offset: 0x002DE2E8
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

	// Token: 0x0600C978 RID: 51576 RVA: 0x002E019C File Offset: 0x002DE39C
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

	// Token: 0x0600C979 RID: 51577 RVA: 0x002E01F8 File Offset: 0x002DE3F8
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

	// Token: 0x0600C97A RID: 51578 RVA: 0x002E025F File Offset: 0x002DE45F
	public void TrackPoint()
	{
		if (this.PlayIdMap.Count > 0)
		{
			this.TrackPlayPoint();
			return;
		}
		this.TrackEntityPoint();
	}

	// Token: 0x0600C97B RID: 51579 RVA: 0x002E0280 File Offset: 0x002DE480
	private void TrackEntityPoint()
	{
		int exploratoryDegree = this.SubTypes[0];
		ExploreProgressController.Instance.ExploreEntityTraceRequest(exploratoryDegree, this.AreaId);
	}

	// Token: 0x0600C97C RID: 51580 RVA: 0x002E02A8 File Offset: 0x002DE4A8
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

	// Token: 0x0600C97D RID: 51581 RVA: 0x002E03CC File Offset: 0x002DE5CC
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

	// Token: 0x0600C97E RID: 51582 RVA: 0x002E042C File Offset: 0x002DE62C
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

	// Token: 0x0600C97F RID: 51583 RVA: 0x002E0470 File Offset: 0x002DE670
	public bool GetPlayIdIsUnlock(int playId)
	{
		IPlayPointInfo playPointInfo;
		return !this.PlayIdMap.TryGetValue(playId, out playPointInfo) || playPointInfo.IsUnlock;
	}

	// Token: 0x0600C980 RID: 51584 RVA: 0x002E0498 File Offset: 0x002DE698
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

	// Token: 0x0600C981 RID: 51585 RVA: 0x002E0530 File Offset: 0x002DE730
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

	// Token: 0x0600C982 RID: 51586 RVA: 0x002E056C File Offset: 0x002DE76C
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

	// Token: 0x0600C983 RID: 51587 RVA: 0x002E063C File Offset: 0x002DE83C
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

	// Token: 0x0600C984 RID: 51588 RVA: 0x002E06E0 File Offset: 0x002DE8E0
	private void CheckClearFindMarkIsHideRange(int markId, EMarkType markType)
	{
		NavigateMarkShowRange navigateMarkShowRangeInfo = WorldMapModel.Instance.NavigateMarkShowRangeInfo;
		if (navigateMarkShowRangeInfo != null && navigateMarkShowRangeInfo.MarkId == markId && navigateMarkShowRangeInfo != null && navigateMarkShowRangeInfo.MarkType == markType)
		{
			EventSystem.Instance.Emit(EEventName.HideNavigateMarkRange);
		}
	}

	// Token: 0x0600C985 RID: 51589 RVA: 0x002E0720 File Offset: 0x002DE920
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

	// Token: 0x0600C986 RID: 51590 RVA: 0x002E078C File Offset: 0x002DE98C
	private EPlayPointState GetTrackPlayState()
	{
		EPlayPointState result = EPlayPointState.Locked;
		if (this.PlayPointToBeCompletedCount > 0)
		{
			result = EPlayPointState.ToBeCompleted;
		}
		return result;
	}

	// Token: 0x0600C987 RID: 51591 RVA: 0x002E07A8 File Offset: 0x002DE9A8
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

	// Token: 0x0600C988 RID: 51592 RVA: 0x002E0818 File Offset: 0x002DEA18
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
				global::Vector entityPosition = WorldMapModel.Instance.GetEntityPosition(a.Item2.Value.EntityConfigId, a.Item2.Value.MapId);
				global::Vector entityPosition2 = WorldMapModel.Instance.GetEntityPosition(b.Item2.Value.EntityConfigId, b.Item2.Value.MapId);
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

	// Token: 0x0600C989 RID: 51593 RVA: 0x002E0910 File Offset: 0x002DEB10
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

	// Token: 0x0600C98A RID: 51594 RVA: 0x002E09E4 File Offset: 0x002DEBE4
	private MapMark? GetMapMarkByPlayInfo(IPlayPointInfo info)
	{
		return this.GetMapMarkByPlayId(info.PlayId);
	}

	// Token: 0x0600C98B RID: 51595 RVA: 0x002E09F4 File Offset: 0x002DEBF4
	public MapMark? GetMapMarkByPlayId(int playId)
	{
		ExploreAreaData exploreAreaData = ExploreProgressModel.Instance.GetExploreAreaData(this.AreaId);
		if (exploreAreaData == null)
		{
			return null;
		}
		return MapConfig.Instance.GetMapMarkByRelativeId(playId, exploreAreaData.GetSceneId());
	}

	// Token: 0x0600C98C RID: 51596 RVA: 0x002E0A30 File Offset: 0x002DEC30
	public EPlayPointState[] GetPlayPointStateList()
	{
		EPlayPointState[] array = new EPlayPointState[this.PlayProgressDataList.Count];
		for (int i = 0; i < this.PlayProgressDataList.Count; i++)
		{
			array[i] = this.PlayProgressDataList[i].PlayPointState;
		}
		return array;
	}

	// Token: 0x0600C98D RID: 51597 RVA: 0x002E0A79 File Offset: 0x002DEC79
	public void LogInfo()
	{
	}

	// Token: 0x0600C98E RID: 51598 RVA: 0x002E0A7B File Offset: 0x002DEC7B
	public void FinishNewRecommendPlay()
	{
		this.IsNewRecommendPlay = false;
	}

	// Token: 0x0600C98F RID: 51599 RVA: 0x002E0A84 File Offset: 0x002DEC84
	[NullableContext(2)]
	public void SetSequenceData(ExploreAreaItemData data = null)
	{
		this.SequenceData = data;
	}

	// Token: 0x0600C990 RID: 51600 RVA: 0x002E0A8D File Offset: 0x002DEC8D
	public void SetFlagSequenceData(bool flag)
	{
		this.FlagSequenceData = flag;
	}

	// Token: 0x0600C991 RID: 51601 RVA: 0x002E0A96 File Offset: 0x002DEC96
	public bool GetFlagSequenceDataAndClean()
	{
		bool flagSequenceData = this.FlagSequenceData;
		this.FlagSequenceData = false;
		return flagSequenceData;
	}

	// Token: 0x0600C992 RID: 51602 RVA: 0x002E0AA8 File Offset: 0x002DECA8
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

	// Token: 0x0600C993 RID: 51603 RVA: 0x002E0B88 File Offset: 0x002DED88
	public void SetEntityList(int[] entityList)
	{
		this.EntityList = entityList;
		this.CalcEntityDistance();
		this.CreateEntityMark();
	}

	// Token: 0x0600C994 RID: 51604 RVA: 0x002E0BA0 File Offset: 0x002DEDA0
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
			global::Vector entityPosition = WorldMapModel.Instance.GetEntityPosition(pbDataId, mapConfigId);
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

	// Token: 0x0600C995 RID: 51605 RVA: 0x002E0CA8 File Offset: 0x002DEEA8
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

	// Token: 0x04005CB2 RID: 23730
	public int AreaId;

	// Token: 0x04005CB3 RID: 23731
	public EExploreType ExploreType;

	// Token: 0x04005CB4 RID: 23732
	public int ExploreProgressId;

	// Token: 0x04005CB5 RID: 23733
	public int ConfigId;

	// Token: 0x04005CB6 RID: 23734
	private int ExploreProgress;

	// Token: 0x04005CB7 RID: 23735
	private int CurrentCount;

	// Token: 0x04005CB8 RID: 23736
	private int TotalCount;

	// Token: 0x04005CB9 RID: 23737
	[Nullable(2)]
	private string TypeNameId;

	// Token: 0x04005CBA RID: 23738
	private int PhantomSkillId;

	// Token: 0x04005CBB RID: 23739
	[Nullable(2)]
	private string UnlockTextId;

	// Token: 0x04005CBC RID: 23740
	[Nullable(2)]
	private string LockTextId;

	// Token: 0x04005CBD RID: 23741
	private bool IsPhantomSkillUnlock;

	// Token: 0x04005CBE RID: 23742
	private int CountMode;

	// Token: 0x04005CBF RID: 23743
	public string Icon;

	// Token: 0x04005CC0 RID: 23744
	public string DescBg;

	// Token: 0x04005CC1 RID: 23745
	public int SortIndex;

	// Token: 0x04005CC2 RID: 23746
	public string LockDescId;

	// Token: 0x04005CC3 RID: 23747
	public string DescId;

	// Token: 0x04005CC4 RID: 23748
	public int[] SubTypes;

	// Token: 0x04005CC5 RID: 23749
	public int UnlockConditionId;

	// Token: 0x04005CC6 RID: 23750
	public int AccessPathId;

	// Token: 0x04005CC7 RID: 23751
	public Dictionary<int, int> SpecialPlayPointIndexMap = new Dictionary<int, int>();

	// Token: 0x04005CC8 RID: 23752
	public bool IsRecommend;

	// Token: 0x04005CC9 RID: 23753
	private bool IsShowProgress;

	// Token: 0x04005CCA RID: 23754
	public bool IsShowTrackBtn;

	// Token: 0x04005CCB RID: 23755
	public bool IsNewRecommendPlay;

	// Token: 0x04005CCC RID: 23756
	[Nullable(2)]
	public ExploreAreaItemData SequenceData;

	// Token: 0x04005CCD RID: 23757
	public bool FlagSequenceData;

	// Token: 0x04005CCE RID: 23758
	public readonly List<IExplorePlayProgressItemData> PlayProgressDataList = new List<IExplorePlayProgressItemData>();

	// Token: 0x04005CCF RID: 23759
	public int PlayPointTotalCount;

	// Token: 0x04005CD0 RID: 23760
	public int PlayPointCompletedCount;

	// Token: 0x04005CD1 RID: 23761
	public int PlayPointToBeCompletedCount;

	// Token: 0x04005CD2 RID: 23762
	public int PlayPointLockedCount;

	// Token: 0x04005CD3 RID: 23763
	public EExploreTrackType UnlockTrackType;

	// Token: 0x04005CD4 RID: 23764
	public EExploreTrackType LockTrackType;

	// Token: 0x04005CD5 RID: 23765
	public readonly Dictionary<int, IPlayPointInfo> PlayIdMap = new Dictionary<int, IPlayPointInfo>();

	// Token: 0x04005CD6 RID: 23766
	[Nullable(2)]
	private IPlayPointInfo FindPlayIdInfo;

	// Token: 0x04005CD7 RID: 23767
	public string SpecialPlayerDesc;

	// Token: 0x04005CD8 RID: 23768
	private bool IsUnlock;

	// Token: 0x04005CD9 RID: 23769
	private int[] EntityList;
}
