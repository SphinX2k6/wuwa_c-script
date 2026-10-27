using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x02000FEE RID: 4078
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingActivityData : ActivityBaseData
{
	// Token: 0x060068B4 RID: 26804 RVA: 0x0014CFE8 File Offset: 0x0014B1E8
	protected override void OnInit(ActivityData data)
	{
		GolemCrackActivityInfo golemCrackActivityInfo = data.GolemCrackActivityInfo;
		if (golemCrackActivityInfo == null)
		{
			return;
		}
		this.UpdateLevelInfo(golemCrackActivityInfo.GolemCrackLevelInfos);
	}

	// Token: 0x060068B5 RID: 26805 RVA: 0x0014D00C File Offset: 0x0014B20C
	protected override void PhraseEx(ActivityData data)
	{
		GolemCrackActivityInfo golemCrackActivityInfo = data.GolemCrackActivityInfo;
		if (golemCrackActivityInfo == null)
		{
			return;
		}
		this.UpdateLevelInfo(golemCrackActivityInfo.GolemCrackLevelInfos);
	}

	// Token: 0x060068B6 RID: 26806 RVA: 0x0014D030 File Offset: 0x0014B230
	public override bool GetExDataRedPointShowState()
	{
		return this.CheckRedDot();
	}

	// Token: 0x060068B7 RID: 26807 RVA: 0x0014D038 File Offset: 0x0014B238
	protected override bool GetExDataFinishShowState()
	{
		ValueTuple<int, int> groupProgressState = this.GetGroupProgressState();
		int item = groupProgressState.Item1;
		int item2 = groupProgressState.Item2;
		return item == item2;
	}

	// Token: 0x060068B8 RID: 26808 RVA: 0x0014D05C File Offset: 0x0014B25C
	public int? GetCurrentId()
	{
		return this.CurrentConfigId;
	}

	// Token: 0x060068B9 RID: 26809 RVA: 0x0014D064 File Offset: 0x0014B264
	public void SetCurrentId(int? currentId)
	{
		this.CurrentConfigId = currentId;
	}

	// Token: 0x060068BA RID: 26810 RVA: 0x0014D070 File Offset: 0x0014B270
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

	// Token: 0x060068BB RID: 26811 RVA: 0x0014D224 File Offset: 0x0014B424
	private long GetUnlockTime(long time)
	{
		return time;
	}

	// Token: 0x060068BC RID: 26812 RVA: 0x0014D228 File Offset: 0x0014B428
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

	// Token: 0x060068BD RID: 26813 RVA: 0x0014D2C4 File Offset: 0x0014B4C4
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

	// Token: 0x060068BE RID: 26814 RVA: 0x0014D430 File Offset: 0x0014B630
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

	// Token: 0x060068BF RID: 26815 RVA: 0x0014D4F8 File Offset: 0x0014B6F8
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

	// Token: 0x060068C0 RID: 26816 RVA: 0x0014D5FC File Offset: 0x0014B7FC
	public GolemHackingLevelGroupInfo GetGroupLevels(int groupId)
	{
		return this.LevelGroup[groupId];
	}

	// Token: 0x060068C1 RID: 26817 RVA: 0x0014D60C File Offset: 0x0014B80C
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

	// Token: 0x060068C2 RID: 26818 RVA: 0x0014D694 File Offset: 0x0014B894
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

	// Token: 0x060068C3 RID: 26819 RVA: 0x0014D724 File Offset: 0x0014B924
	public GolemHackingLevelInfo GetLevelInfo(int levelId)
	{
		return this.LevelInfo[levelId];
	}

	// Token: 0x060068C4 RID: 26820 RVA: 0x0014D734 File Offset: 0x0014B934
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

	// Token: 0x060068C5 RID: 26821 RVA: 0x0014D7B0 File Offset: 0x0014B9B0
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

	// Token: 0x060068C6 RID: 26822 RVA: 0x0014D86C File Offset: 0x0014BA6C
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

	// Token: 0x060068C7 RID: 26823 RVA: 0x0014D8DC File Offset: 0x0014BADC
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

	// Token: 0x060068C8 RID: 26824 RVA: 0x0014D970 File Offset: 0x0014BB70
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

	// Token: 0x04002FF6 RID: 12278
	protected Dictionary<int, GolemHackingLevelGroupInfo> LevelGroup = new Dictionary<int, GolemHackingLevelGroupInfo>();

	// Token: 0x04002FF7 RID: 12279
	protected Dictionary<int, List<int>> LevelUnlock = new Dictionary<int, List<int>>();

	// Token: 0x04002FF8 RID: 12280
	protected Dictionary<int, GolemHackingLevelInfo> LevelInfo = new Dictionary<int, GolemHackingLevelInfo>();

	// Token: 0x04002FF9 RID: 12281
	protected int? CurrentConfigId;
}
