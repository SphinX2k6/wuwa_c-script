using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x020004A3 RID: 1187
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingActivityData : ActivityBaseData
{
	// Token: 0x06003C4C RID: 15436 RVA: 0x001558AC File Offset: 0x00153AAC
	protected override void OnInit(ActivityData data)
	{
		GolemCrackActivityInfo golemCrackActivityInfo = data.GolemCrackActivityInfo;
		if (golemCrackActivityInfo == null)
		{
			return;
		}
		this.UpdateLevelInfo(golemCrackActivityInfo.GolemCrackLevelInfos);
	}

	// Token: 0x06003C4D RID: 15437 RVA: 0x001558D0 File Offset: 0x00153AD0
	protected override void PhraseEx(ActivityData data)
	{
		GolemCrackActivityInfo golemCrackActivityInfo = data.GolemCrackActivityInfo;
		if (golemCrackActivityInfo == null)
		{
			return;
		}
		this.UpdateLevelInfo(golemCrackActivityInfo.GolemCrackLevelInfos);
	}

	// Token: 0x06003C4E RID: 15438 RVA: 0x001558F4 File Offset: 0x00153AF4
	public override bool GetExDataRedPointShowState()
	{
		return this.CheckRedDot();
	}

	// Token: 0x06003C4F RID: 15439 RVA: 0x001558FC File Offset: 0x00153AFC
	protected override bool GetExDataFinishShowState()
	{
		ValueTuple<int, int> groupProgressState = this.GetGroupProgressState();
		int item = groupProgressState.Item1;
		int item2 = groupProgressState.Item2;
		return item == item2;
	}

	// Token: 0x06003C50 RID: 15440 RVA: 0x00155920 File Offset: 0x00153B20
	public int? GetCurrentId()
	{
		return this.CurrentConfigId;
	}

	// Token: 0x06003C51 RID: 15441 RVA: 0x00155928 File Offset: 0x00153B28
	public void SetCurrentId(int? currentId)
	{
		this.CurrentConfigId = currentId;
	}

	// Token: 0x06003C52 RID: 15442 RVA: 0x00155934 File Offset: 0x00153B34
	public void UpdateLevelInfo(IEnumerable<GolemCrackLevelInfo> levels)
	{
		foreach (GolemCrackLevelInfo golemCrackLevelInfo in levels)
		{
			if (!this.LevelInfo.ContainsKey(golemCrackLevelInfo.Id))
			{
				GolemCrack value = ConfigGolemCrackById.GetConfig(golemCrackLevelInfo.Id, true).Value;
				GolemHackingLevelInfo value2 = new GolemHackingLevelInfo
				{
					LevelId = golemCrackLevelInfo.Id,
					UnlockTime = this.GetUnlockTime(golemCrackLevelInfo.UnlockTime),
					UnlockId = value.UnlockId,
					State = golemCrackLevelInfo.State
				};
				this.LevelInfo[golemCrackLevelInfo.Id] = value2;
				int group = value.Group;
				if (!this.LevelGroup.ContainsKey(group))
				{
					GolemHackingLevelGroupInfo value3 = new GolemHackingLevelGroupInfo
					{
						Group = group,
						LevelGroup = new List<int>()
					};
					this.LevelGroup[group] = value3;
				}
				this.LevelGroup[group].LevelGroup.Add(golemCrackLevelInfo.Id);
				if (value.UnlockId != golemCrackLevelInfo.Id)
				{
					if (!this.LevelUnlock.ContainsKey(value.UnlockId))
					{
						this.LevelUnlock[value.UnlockId] = new List<int>();
					}
					this.LevelUnlock[value.UnlockId].Add(golemCrackLevelInfo.Id);
				}
			}
			else
			{
				GolemHackingLevelInfo golemHackingLevelInfo = this.LevelInfo[golemCrackLevelInfo.Id];
				golemHackingLevelInfo.UnlockTime = this.GetUnlockTime(golemCrackLevelInfo.UnlockTime);
				golemHackingLevelInfo.State = golemCrackLevelInfo.State;
			}
		}
	}

	// Token: 0x06003C53 RID: 15443 RVA: 0x00155AE8 File Offset: 0x00153CE8
	private long GetUnlockTime(long time)
	{
		return time;
	}

	// Token: 0x06003C54 RID: 15444 RVA: 0x00155AEC File Offset: 0x00153CEC
	public void OnLevelClear(int unlockLevelId)
	{
		List<int> list;
		bool flag = this.LevelUnlock.TryGetValue(unlockLevelId, out list);
		this.LevelInfo[unlockLevelId].State = GolemCrackState.GolemCrackFinished;
		if (!flag)
		{
			return;
		}
		foreach (int key in list)
		{
			GolemHackingLevelInfo golemHackingLevelInfo = this.LevelInfo[key];
			if (golemHackingLevelInfo.State == GolemCrackState.GolemCrackLocked && (double)golemHackingLevelInfo.UnlockTime <= TimeUtil.Instance.GetServerTime())
			{
				golemHackingLevelInfo.State = GolemCrackState.GolemCrackUnlocked;
			}
		}
	}

	// Token: 0x06003C55 RID: 15445 RVA: 0x00155B88 File Offset: 0x00153D88
	[NullableContext(0)]
	public ValueTuple<int, int> GetGroupProgressState()
	{
		bool flag = true;
		int num = 0;
		int num2 = 0;
		foreach (KeyValuePair<int, GolemHackingLevelGroupInfo> keyValuePair in this.LevelGroup)
		{
			int num3;
			GolemHackingLevelGroupInfo golemHackingLevelGroupInfo;
			keyValuePair.Deconstruct(out num3, out golemHackingLevelGroupInfo);
			int num4 = num3;
			GolemHackingLevelGroupInfo golemHackingLevelGroupInfo2 = golemHackingLevelGroupInfo;
			if (num4 != 7)
			{
				num2 += golemHackingLevelGroupInfo2.LevelGroup.Count;
				foreach (int key in golemHackingLevelGroupInfo2.LevelGroup)
				{
					GolemHackingLevelInfo golemHackingLevelInfo = this.LevelInfo[key];
					num += ((golemHackingLevelInfo.State == GolemCrackState.GolemCrackFinished) ? 1 : 0);
					if (golemHackingLevelInfo.State != GolemCrackState.GolemCrackFinished)
					{
						flag = false;
					}
				}
			}
		}
		GolemHackingLevelGroupInfo golemHackingLevelGroupInfo3;
		if (num2 > 0 && flag && this.LevelGroup.TryGetValue(7, out golemHackingLevelGroupInfo3))
		{
			num2 += golemHackingLevelGroupInfo3.LevelGroup.Count;
			foreach (int key2 in golemHackingLevelGroupInfo3.LevelGroup)
			{
				GolemHackingLevelInfo golemHackingLevelInfo2 = this.LevelInfo[key2];
				num += ((golemHackingLevelInfo2.State == GolemCrackState.GolemCrackFinished) ? 1 : 0);
			}
		}
		return new ValueTuple<int, int>(num, num2);
	}

	// Token: 0x06003C56 RID: 15446 RVA: 0x00155CF4 File Offset: 0x00153EF4
	[NullableContext(0)]
	public ValueTuple<EGolemHackingGroupState, int, int> GetGroupState(int id)
	{
		int num = 0;
		int num2 = 0;
		GolemHackingLevelGroupInfo golemHackingLevelGroupInfo = this.LevelGroup[id];
		foreach (int key in golemHackingLevelGroupInfo.LevelGroup)
		{
			GolemHackingLevelInfo golemHackingLevelInfo = this.LevelInfo[key];
			num += ((golemHackingLevelInfo.State == GolemCrackState.GolemCrackFinished) ? 1 : 0);
			num2 += ((golemHackingLevelInfo.State == GolemCrackState.GolemCrackLocked) ? 1 : 0);
		}
		if (num == golemHackingLevelGroupInfo.LevelGroup.Count)
		{
			return new ValueTuple<EGolemHackingGroupState, int, int>(EGolemHackingGroupState.Clear, num, num);
		}
		if (num2 == golemHackingLevelGroupInfo.LevelGroup.Count)
		{
			return new ValueTuple<EGolemHackingGroupState, int, int>(EGolemHackingGroupState.Locked, num2, num2);
		}
		return new ValueTuple<EGolemHackingGroupState, int, int>(EGolemHackingGroupState.Normal, num, golemHackingLevelGroupInfo.LevelGroup.Count);
	}

	// Token: 0x06003C57 RID: 15447 RVA: 0x00155DBC File Offset: 0x00153FBC
	public List<GolemHackingLevelGroupInfo> GetLevelGroupList()
	{
		List<GolemHackingLevelGroupInfo> list = new List<GolemHackingLevelGroupInfo>();
		bool flag = true;
		foreach (KeyValuePair<int, GolemHackingLevelGroupInfo> keyValuePair in this.LevelGroup)
		{
			int num;
			GolemHackingLevelGroupInfo golemHackingLevelGroupInfo;
			keyValuePair.Deconstruct(out num, out golemHackingLevelGroupInfo);
			int num2 = num;
			GolemHackingLevelGroupInfo golemHackingLevelGroupInfo2 = golemHackingLevelGroupInfo;
			if (num2 != 7)
			{
				list.Add(golemHackingLevelGroupInfo2);
				foreach (int key in golemHackingLevelGroupInfo2.LevelGroup)
				{
					if (this.LevelInfo[key].State != GolemCrackState.GolemCrackFinished)
					{
						flag = false;
					}
				}
			}
		}
		GolemHackingLevelGroupInfo item;
		if (flag && this.LevelGroup.TryGetValue(7, out item))
		{
			list.Add(item);
		}
		list.Sort((GolemHackingLevelGroupInfo a, GolemHackingLevelGroupInfo b) => a.Group - b.Group);
		return list;
	}

	// Token: 0x06003C58 RID: 15448 RVA: 0x00155EC0 File Offset: 0x001540C0
	public GolemHackingLevelGroupInfo GetGroupLevels(int groupId)
	{
		return this.LevelGroup[groupId];
	}

	// Token: 0x06003C59 RID: 15449 RVA: 0x00155ED0 File Offset: 0x001540D0
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<bool, string> GetGroupLockTxt(int groupId)
	{
		int key = this.LevelGroup[groupId].LevelGroup[0];
		GolemHackingLevelInfo golemHackingLevelInfo = this.LevelInfo[key];
		if (TimeUtil.Instance.GetServerTime() >= (double)golemHackingLevelInfo.UnlockTime)
		{
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("IntrusionProtocolActivity_Locked");
			return new ValueTuple<bool, string>(false, configTextByKey);
		}
		string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey("IntrusionProtocolActivity_NotOpened");
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText(golemHackingLevelInfo.UnlockTime, configTextByKey2);
		return new ValueTuple<bool, string>(true, remainTimeText);
	}

	// Token: 0x06003C5A RID: 15450 RVA: 0x00155F58 File Offset: 0x00154158
	public void GetGroupLockTips(int groupId)
	{
		int key = this.LevelGroup[groupId].LevelGroup[0];
		GolemHackingLevelInfo golemHackingLevelInfo = this.LevelInfo[key];
		if (TimeUtil.Instance.GetServerTime() >= (double)golemHackingLevelInfo.UnlockTime)
		{
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("IntrusionProtocolActivity_LockedTips");
			ScrollingTipsController.Instance.ShowTipsByText(configTextByKey);
			return;
		}
		string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey("IntrusionProtocolActivity_NotOpenedTips");
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText(golemHackingLevelInfo.UnlockTime, configTextByKey2);
		ScrollingTipsController.Instance.ShowTipsByText(remainTimeText);
	}

	// Token: 0x06003C5B RID: 15451 RVA: 0x00155FE8 File Offset: 0x001541E8
	public GolemHackingLevelInfo GetLevelInfo(int levelId)
	{
		return this.LevelInfo[levelId];
	}

	// Token: 0x06003C5C RID: 15452 RVA: 0x00155FF8 File Offset: 0x001541F8
	public bool CheckRedDot()
	{
		bool flag = this.IsBonusGroupUnlocked();
		foreach (KeyValuePair<int, GolemHackingLevelGroupInfo> keyValuePair in this.LevelGroup)
		{
			int num;
			GolemHackingLevelGroupInfo golemHackingLevelGroupInfo;
			keyValuePair.Deconstruct(out num, out golemHackingLevelGroupInfo);
			int num2 = num;
			if ((num2 != 7 || flag) && this.CheckGroupRedDot(num2))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003C5D RID: 15453 RVA: 0x00156074 File Offset: 0x00154274
	private bool IsBonusGroupUnlocked()
	{
		foreach (KeyValuePair<int, GolemHackingLevelGroupInfo> keyValuePair in this.LevelGroup)
		{
			int num;
			GolemHackingLevelGroupInfo golemHackingLevelGroupInfo;
			keyValuePair.Deconstruct(out num, out golemHackingLevelGroupInfo);
			int num2 = num;
			GolemHackingLevelGroupInfo golemHackingLevelGroupInfo2 = golemHackingLevelGroupInfo;
			if (num2 != 7)
			{
				foreach (int key in golemHackingLevelGroupInfo2.LevelGroup)
				{
					if (this.LevelInfo[key].State != GolemCrackState.GolemCrackFinished)
					{
						return false;
					}
				}
			}
		}
		return true;
	}

	// Token: 0x06003C5E RID: 15454 RVA: 0x00156130 File Offset: 0x00154330
	public bool CheckGroupRedDot(int groupId)
	{
		GolemHackingLevelGroupInfo golemHackingLevelGroupInfo;
		if (!this.LevelGroup.TryGetValue(groupId, out golemHackingLevelGroupInfo))
		{
			return false;
		}
		foreach (int levelId in golemHackingLevelGroupInfo.LevelGroup)
		{
			if (this.CheckLevelRedDot(levelId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003C5F RID: 15455 RVA: 0x001561A0 File Offset: 0x001543A0
	public bool CheckLevelRedDot(int levelId)
	{
		GolemHackingLevelInfo golemHackingLevelInfo;
		if (this.LevelInfo.TryGetValue(levelId, out golemHackingLevelInfo) && golemHackingLevelInfo.State == GolemCrackState.GolemCrackLocked)
		{
			return false;
		}
		GolemCrack? config = ConfigGolemCrackById.GetConfig(levelId, true);
		if (config == null)
		{
			return false;
		}
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.GolemCrack) as ServerStorageMap;
		for (int i = 0; i < config.Value.ConfigIdsLength; i++)
		{
			int key = config.Value.ConfigIds(i);
			if (serverStorageMap == null || serverStorageMap.Get(key) != null)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06003C60 RID: 15456 RVA: 0x00156234 File Offset: 0x00154434
	public void CheckIsUnlockWhenTimeUnlock(int groupId)
	{
		foreach (int num in this.LevelGroup[groupId].LevelGroup)
		{
			foreach (KeyValuePair<int, List<int>> keyValuePair in this.LevelUnlock)
			{
				int num2;
				List<int> list;
				keyValuePair.Deconstruct(out num2, out list);
				int key = num2;
				if (list.Contains(num) && this.LevelInfo[key].State == GolemCrackState.GolemCrackFinished)
				{
					this.LevelInfo[num].State = GolemCrackState.GolemCrackUnlocked;
				}
			}
		}
	}

	// Token: 0x0400308F RID: 12431
	protected Dictionary<int, GolemHackingLevelGroupInfo> LevelGroup = new Dictionary<int, GolemHackingLevelGroupInfo>();

	// Token: 0x04003090 RID: 12432
	protected Dictionary<int, List<int>> LevelUnlock = new Dictionary<int, List<int>>();

	// Token: 0x04003091 RID: 12433
	protected Dictionary<int, GolemHackingLevelInfo> LevelInfo = new Dictionary<int, GolemHackingLevelInfo>();

	// Token: 0x04003092 RID: 12434
	protected int? CurrentConfigId;
}
