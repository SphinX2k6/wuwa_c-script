using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

// Token: 0x02001712 RID: 5906
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MotionModel : ModelBase
{
	// Token: 0x0600E5B5 RID: 58805 RVA: 0x00435ED1 File Offset: 0x004340D1
	public void OnMotionUnlock(int roleId, int motionId)
	{
		this.ClearRoleMapMotion(roleId, motionId);
		this.TryAddUnLockMotion(roleId, motionId);
		EventSystem.Instance.Emit<int>(EEventName.UpdateRoleFavorData, roleId);
		EventSystem.Instance.Emit<int, int>(EEventName.UnLockRoleFavorItem, roleId, motionId);
	}

	// Token: 0x0600E5B6 RID: 58806 RVA: 0x00435F06 File Offset: 0x00434106
	public void OnNewMotionCanUnlock(int roleId, int motionId)
	{
		this.ClearRoleMapMotion(roleId, motionId);
		this.TryAddCanUnLockMotion(roleId, motionId);
	}

	// Token: 0x0600E5B7 RID: 58807 RVA: 0x00435F18 File Offset: 0x00434118
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

	// Token: 0x0600E5B8 RID: 58808 RVA: 0x00435FD8 File Offset: 0x004341D8
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

	// Token: 0x0600E5B9 RID: 58809 RVA: 0x00436140 File Offset: 0x00434340
	public void OnMotionFinishCondition(RoleMotionFinishConditionNotify message)
	{
		foreach (KeyValuePair<int, ConditionInfo> keyValuePair in message.RoleConditionInfoMap)
		{
			int key = keyValuePair.Key;
			this.UpdateCondition(key, keyValuePair.Value);
		}
	}

	// Token: 0x0600E5BA RID: 58810 RVA: 0x0043619C File Offset: 0x0043439C
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

	// Token: 0x0600E5BB RID: 58811 RVA: 0x004361FC File Offset: 0x004343FC
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

	// Token: 0x0600E5BC RID: 58812 RVA: 0x0043625C File Offset: 0x0043445C
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

	// Token: 0x0600E5BD RID: 58813 RVA: 0x00436394 File Offset: 0x00434594
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

	// Token: 0x0600E5BE RID: 58814 RVA: 0x004363EC File Offset: 0x004345EC
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

	// Token: 0x0600E5BF RID: 58815 RVA: 0x00436430 File Offset: 0x00434630
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

	// Token: 0x0600E5C0 RID: 58816 RVA: 0x00436474 File Offset: 0x00434674
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

	// Token: 0x0600E5C1 RID: 58817 RVA: 0x004364B8 File Offset: 0x004346B8
	public bool IfRoleMotionCanUnlock(int roleId)
	{
		HashSet<int> hashSet;
		return this.CurrentCanUnlockMotionMap.TryGetValue(roleId, out hashSet) && hashSet.Count > 0;
	}

	// Token: 0x170015E4 RID: 5604
	// (get) Token: 0x0600E5C2 RID: 58818 RVA: 0x004364E0 File Offset: 0x004346E0
	public static MotionModel Instance
	{
		get
		{
			return MotionModel._Instance;
		}
	}

	// Token: 0x0600E5C3 RID: 58819 RVA: 0x004364E7 File Offset: 0x004346E7
	public static MotionModel GetOrCreateInstance()
	{
		if (MotionModel._Instance == null)
		{
			MotionModel.CreateInstance();
		}
		return MotionModel._Instance;
	}

	// Token: 0x0600E5C4 RID: 58820 RVA: 0x004364FB File Offset: 0x004346FB
	public static bool CreateInstance()
	{
		if (MotionModel._Instance != null)
		{
			return true;
		}
		MotionModel._Instance = new MotionModel();
		return true;
	}

	// Token: 0x0600E5C5 RID: 58821 RVA: 0x00436511 File Offset: 0x00434711
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E5C6 RID: 58822 RVA: 0x00436513 File Offset: 0x00434713
	public static void ResetStaticDefaultValue()
	{
		MotionModel._Instance = null;
	}

	// Token: 0x0600E5C7 RID: 58823 RVA: 0x0043651B File Offset: 0x0043471B
	static MotionModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotionModel.CreateStaticDefaultValue), new Action(MotionModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008351 RID: 33617
	private readonly Dictionary<int, HashSet<int>> CurrentUnlockMotionsMap = new Dictionary<int, HashSet<int>>();

	// Token: 0x04008352 RID: 33618
	private readonly Dictionary<int, HashSet<int>> CurrentCanUnlockMotionMap = new Dictionary<int, HashSet<int>>();

	// Token: 0x04008353 RID: 33619
	private readonly Dictionary<int, HashSet<int>> CurrentLockMotionMap = new Dictionary<int, HashSet<int>>();

	// Token: 0x04008354 RID: 33620
	private readonly Dictionary<int, Dictionary<int, Dictionary<int, List<int>>>> RoleFavorConditionMap = new Dictionary<int, Dictionary<int, Dictionary<int, List<int>>>>();

	// Token: 0x04008355 RID: 33621
	[Nullable(2)]
	private static MotionModel _Instance;

	// Token: 0x020078E5 RID: 30949
	[NullableContext(0)]
	public enum EMotionState
	{
		// Token: 0x0402731C RID: 160540
		Lock,
		// Token: 0x0402731D RID: 160541
		CanUnlock,
		// Token: 0x0402731E RID: 160542
		Unlock
	}
}
