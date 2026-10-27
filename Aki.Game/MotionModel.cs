using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

// Token: 0x0200222E RID: 8750
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MotionModel : ModelBase
{
	// Token: 0x0601111F RID: 69919 RVA: 0x0042932D File Offset: 0x0042752D
	public void OnMotionUnlock(int roleId, int motionId)
	{
		this.ClearRoleMapMotion(roleId, motionId);
		this.TryAddUnLockMotion(roleId, motionId);
		EventSystem.Instance.Emit<int>(EEventName.UpdateRoleFavorData, roleId);
		EventSystem.Instance.Emit<int, int>(EEventName.UnLockRoleFavorItem, roleId, motionId);
	}

	// Token: 0x06011120 RID: 69920 RVA: 0x00429362 File Offset: 0x00427562
	public void OnNewMotionCanUnlock(int roleId, int motionId)
	{
		this.ClearRoleMapMotion(roleId, motionId);
		this.TryAddCanUnLockMotion(roleId, motionId);
	}

	// Token: 0x06011121 RID: 69921 RVA: 0x00429374 File Offset: 0x00427574
	public void OnRoleMotionActive(RoleMotionActiveNotify message)
	{
		RoleMotion roleMotionInfo = message.RoleMotionInfo;
		if (roleMotionInfo == null || roleMotionInfo.MotionIds == null)
		{
			return;
		}
		foreach (FavorItem favorItem in roleMotionInfo.MotionIds)
		{
			this.ClearRoleMapMotion(roleMotionInfo.RoleId, favorItem.Id);
			if (favorItem.Status == FavorItemStatus.ItemLocked)
			{
				this.TryAddLockMotion(roleMotionInfo.RoleId, favorItem.Id);
			}
			else if (favorItem.Status == FavorItemStatus.ItemUnLocked)
			{
				this.TryAddUnLockMotion(roleMotionInfo.RoleId, favorItem.Id);
			}
			else if (favorItem.Status == FavorItemStatus.ItemCanUnLock)
			{
				this.TryAddCanUnLockMotion(roleMotionInfo.RoleId, favorItem.Id);
			}
		}
	}

	// Token: 0x06011122 RID: 69922 RVA: 0x00429434 File Offset: 0x00427634
	public void OnGetAllRoleMotionInfo(RoleMotionListNotify message)
	{
		this.CurrentUnlockMotionsMap.Clear();
		this.CurrentLockMotionMap.Clear();
		this.CurrentCanUnlockMotionMap.Clear();
		foreach (RoleMotion roleMotion in message.MotionList)
		{
			if (roleMotion.MotionIds != null)
			{
				foreach (FavorItem favorItem in roleMotion.MotionIds)
				{
					this.ClearRoleMapMotion(roleMotion.RoleId, favorItem.Id);
					if (favorItem.Status == FavorItemStatus.ItemLocked)
					{
						this.TryAddLockMotion(roleMotion.RoleId, favorItem.Id);
					}
					else if (favorItem.Status == FavorItemStatus.ItemUnLocked)
					{
						this.TryAddUnLockMotion(roleMotion.RoleId, favorItem.Id);
					}
					else if (favorItem.Status == FavorItemStatus.ItemCanUnLock)
					{
						this.TryAddCanUnLockMotion(roleMotion.RoleId, favorItem.Id);
					}
				}
			}
		}
		foreach (KeyValuePair<int, ConditionInfo> keyValuePair in message.RoleConditionInfoMap)
		{
			int key = keyValuePair.Key;
			this.UpdateCondition(key, keyValuePair.Value);
		}
	}

	// Token: 0x06011123 RID: 69923 RVA: 0x0042959C File Offset: 0x0042779C
	public void OnMotionFinishCondition(RoleMotionFinishConditionNotify message)
	{
		foreach (KeyValuePair<int, ConditionInfo> keyValuePair in message.RoleConditionInfoMap)
		{
			int key = keyValuePair.Key;
			this.UpdateCondition(key, keyValuePair.Value);
		}
	}

	// Token: 0x06011124 RID: 69924 RVA: 0x004295F8 File Offset: 0x004277F8
	public MotionModel.EMotionState GetRoleMotionState(int roleId, int motionId)
	{
		HashSet<int> hashSet;
		if (this.CurrentUnlockMotionsMap.TryGetValue(roleId, out hashSet) && hashSet.Contains(motionId))
		{
			return MotionModel.EMotionState.Unlock;
		}
		if (this.CurrentLockMotionMap.TryGetValue(roleId, out hashSet) && hashSet.Contains(motionId))
		{
			return MotionModel.EMotionState.Lock;
		}
		if (this.CurrentCanUnlockMotionMap.TryGetValue(roleId, out hashSet) && hashSet.Contains(motionId))
		{
			return MotionModel.EMotionState.CanUnlock;
		}
		return MotionModel.EMotionState.Lock;
	}

	// Token: 0x06011125 RID: 69925 RVA: 0x00429658 File Offset: 0x00427858
	public bool IsCondtionFinish(int roleId, int id, int conditionId)
	{
		Dictionary<int, Dictionary<int, List<int>>> dictionary;
		if (!this.RoleFavorConditionMap.TryGetValue(roleId, out dictionary))
		{
			return false;
		}
		Dictionary<int, List<int>> dictionary2;
		if (!dictionary.TryGetValue(0, out dictionary2))
		{
			return false;
		}
		List<int> list;
		if (!dictionary2.TryGetValue(id, out list))
		{
			return false;
		}
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			if (list[i] == conditionId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06011126 RID: 69926 RVA: 0x004296B8 File Offset: 0x004278B8
	public void UpdateCondition(int roleId, ConditionInfo conditionInfo)
	{
		Dictionary<int, Dictionary<int, List<int>>> dictionary;
		if (!this.RoleFavorConditionMap.TryGetValue(roleId, out dictionary))
		{
			dictionary = new Dictionary<int, Dictionary<int, List<int>>>();
		}
		foreach (KeyValuePair<int, ConditionItem> keyValuePair in conditionInfo.FinishConditionMap)
		{
			int key = keyValuePair.Key;
			MapField<int, ItemFinishList> itemFinishMap = keyValuePair.Value.ItemFinishMap;
			Dictionary<int, List<int>> dictionary2;
			if (!dictionary.TryGetValue(key, out dictionary2))
			{
				dictionary2 = new Dictionary<int, List<int>>();
			}
			foreach (KeyValuePair<int, ItemFinishList> keyValuePair2 in itemFinishMap)
			{
				int key2 = keyValuePair2.Key;
				RepeatedField<int> conditionIdList = keyValuePair2.Value.ConditionIdList;
				List<int> list;
				if (!dictionary2.TryGetValue(key2, out list))
				{
					list = new List<int>();
				}
				int count = conditionIdList.Count;
				for (int i = 0; i < count; i++)
				{
					int item = conditionIdList[i];
					list.Add(item);
				}
				dictionary2[key2] = list;
			}
			dictionary[key] = dictionary2;
		}
		this.RoleFavorConditionMap[roleId] = dictionary;
	}

	// Token: 0x06011127 RID: 69927 RVA: 0x004297F0 File Offset: 0x004279F0
	private void ClearRoleMapMotion(int roleId, int motionId)
	{
		HashSet<int> hashSet;
		if (this.CurrentUnlockMotionsMap.TryGetValue(roleId, out hashSet))
		{
			hashSet.Remove(motionId);
		}
		HashSet<int> hashSet2;
		if (this.CurrentLockMotionMap.TryGetValue(roleId, out hashSet2))
		{
			hashSet2.Remove(motionId);
		}
		HashSet<int> hashSet3;
		if (this.CurrentCanUnlockMotionMap.TryGetValue(roleId, out hashSet3))
		{
			hashSet3.Remove(motionId);
		}
	}

	// Token: 0x06011128 RID: 69928 RVA: 0x00429848 File Offset: 0x00427A48
	private void TryAddUnLockMotion(int roleId, int motionId)
	{
		HashSet<int> hashSet;
		if (this.CurrentUnlockMotionsMap.TryGetValue(roleId, out hashSet))
		{
			hashSet.Add(motionId);
			return;
		}
		HashSet<int> hashSet2 = new HashSet<int>();
		hashSet2.Add(motionId);
		this.CurrentUnlockMotionsMap[roleId] = hashSet2;
	}

	// Token: 0x06011129 RID: 69929 RVA: 0x0042988C File Offset: 0x00427A8C
	private void TryAddCanUnLockMotion(int roleId, int motionId)
	{
		HashSet<int> hashSet;
		if (this.CurrentCanUnlockMotionMap.TryGetValue(roleId, out hashSet))
		{
			hashSet.Add(motionId);
			return;
		}
		HashSet<int> hashSet2 = new HashSet<int>();
		hashSet2.Add(motionId);
		this.CurrentCanUnlockMotionMap[roleId] = hashSet2;
	}

	// Token: 0x0601112A RID: 69930 RVA: 0x004298D0 File Offset: 0x00427AD0
	private void TryAddLockMotion(int roleId, int motionId)
	{
		HashSet<int> hashSet;
		if (this.CurrentLockMotionMap.TryGetValue(roleId, out hashSet))
		{
			hashSet.Add(motionId);
			return;
		}
		HashSet<int> hashSet2 = new HashSet<int>();
		hashSet2.Add(motionId);
		this.CurrentLockMotionMap[roleId] = hashSet2;
	}

	// Token: 0x0601112B RID: 69931 RVA: 0x00429914 File Offset: 0x00427B14
	public bool IfRoleMotionCanUnlock(int roleId)
	{
		HashSet<int> hashSet;
		return this.CurrentCanUnlockMotionMap.TryGetValue(roleId, out hashSet) && hashSet.Count > 0;
	}

	// Token: 0x170015AD RID: 5549
	// (get) Token: 0x0601112C RID: 69932 RVA: 0x0042993C File Offset: 0x00427B3C
	public static MotionModel Instance
	{
		get
		{
			return MotionModel._Instance;
		}
	}

	// Token: 0x0601112D RID: 69933 RVA: 0x00429943 File Offset: 0x00427B43
	public static MotionModel GetOrCreateInstance()
	{
		if (MotionModel._Instance == null)
		{
			MotionModel.CreateInstance();
		}
		return MotionModel._Instance;
	}

	// Token: 0x0601112E RID: 69934 RVA: 0x00429957 File Offset: 0x00427B57
	public static bool CreateInstance()
	{
		if (MotionModel._Instance != null)
		{
			return true;
		}
		MotionModel._Instance = new MotionModel();
		return true;
	}

	// Token: 0x0601112F RID: 69935 RVA: 0x0042996D File Offset: 0x00427B6D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011130 RID: 69936 RVA: 0x0042996F File Offset: 0x00427B6F
	public static void ResetStaticDefaultValue()
	{
		MotionModel._Instance = null;
	}

	// Token: 0x06011131 RID: 69937 RVA: 0x00429977 File Offset: 0x00427B77
	static MotionModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotionModel.CreateStaticDefaultValue), new Action(MotionModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008213 RID: 33299
	private readonly Dictionary<int, HashSet<int>> CurrentUnlockMotionsMap = new Dictionary<int, HashSet<int>>();

	// Token: 0x04008214 RID: 33300
	private readonly Dictionary<int, HashSet<int>> CurrentCanUnlockMotionMap = new Dictionary<int, HashSet<int>>();

	// Token: 0x04008215 RID: 33301
	private readonly Dictionary<int, HashSet<int>> CurrentLockMotionMap = new Dictionary<int, HashSet<int>>();

	// Token: 0x04008216 RID: 33302
	private readonly Dictionary<int, Dictionary<int, Dictionary<int, List<int>>>> RoleFavorConditionMap = new Dictionary<int, Dictionary<int, Dictionary<int, List<int>>>>();

	// Token: 0x04008217 RID: 33303
	[Nullable(2)]
	private static MotionModel _Instance;

	// Token: 0x0200875C RID: 34652
	[NullableContext(0)]
	public enum EMotionState
	{
		// Token: 0x0402C004 RID: 180228
		Lock,
		// Token: 0x0402C005 RID: 180229
		CanUnlock,
		// Token: 0x0402C006 RID: 180230
		Unlock
	}
}
