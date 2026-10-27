using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.MonsterGroup
{
	// Token: 0x020053C6 RID: 21446
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MonsterGroupPatrolModel : ModelBase
	{
		// Token: 0x06036CA8 RID: 224424 RVA: 0x00CF7FBF File Offset: 0x00CF61BF
		protected override bool OnInit()
		{
			EventSystem.Instance.Add<int, int>(EEventName.OnGroupAiSyncTagAdded, new Action<int, int>(this.OnGroupSyncTagAdded));
			EventSystem.Instance.Add<int, int>(EEventName.OnGroupAiSyncTagRemoved, new Action<int, int>(this.OnGroupSyncTagRemoved));
			return true;
		}

		// Token: 0x06036CA9 RID: 224425 RVA: 0x00CF7FFC File Offset: 0x00CF61FC
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove<int, int>(EEventName.OnGroupAiSyncTagAdded, new Action<int, int>(this.OnGroupSyncTagAdded));
			EventSystem.Instance.Remove<int, int>(EEventName.OnGroupAiSyncTagRemoved, new Action<int, int>(this.OnGroupSyncTagRemoved));
			this.GroupSyncTagIds.Clear();
			foreach (MonsterGroupInfo monsterGroupInfo in this.MonsterGroups.Values)
			{
				monsterGroupInfo.Clear();
			}
			this.MonsterEntityInfoMap.Clear();
			this.MonsterGroups.Clear();
			return true;
		}

		// Token: 0x06036CAA RID: 224426 RVA: 0x00CF80AC File Offset: 0x00CF62AC
		public void RemoveMonsterGroup(int id)
		{
			if (!this.MonsterGroups.ContainsKey(id))
			{
				return;
			}
			MonsterGroupInfo monsterGroupInfo = this.MonsterGroups[id];
			foreach (KeyValuePair<int, MonsterPatrolInfo> keyValuePair in monsterGroupInfo.GroupInfo)
			{
				this.MonsterEntityInfoMap.Remove(keyValuePair.Value.EntityId);
			}
			monsterGroupInfo.Clear();
			this.MonsterGroups.Remove(id);
		}

		// Token: 0x06036CAB RID: 224427 RVA: 0x00CF8140 File Offset: 0x00CF6340
		[NullableContext(2)]
		public MonsterGroupInfo GetMonsterGroup(int id)
		{
			if (this.MonsterGroups.Count <= 0)
			{
				return null;
			}
			MonsterGroupInfo result;
			if (!this.MonsterGroups.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06036CAC RID: 224428 RVA: 0x00CF8170 File Offset: 0x00CF6370
		[NullableContext(2)]
		public IReadOnlySet<int> GetGroupSyncTagIds(int ownerPbDataId)
		{
			HashSet<int> result;
			if (!this.GroupSyncTagIds.TryGetValue(ownerPbDataId, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06036CAD RID: 224429 RVA: 0x00CF8190 File Offset: 0x00CF6390
		private void OnGroupSyncTagAdded(int ownerPbDataId, int tagId)
		{
			HashSet<int> hashSet;
			if (!this.GroupSyncTagIds.TryGetValue(ownerPbDataId, out hashSet))
			{
				hashSet = new HashSet<int>();
				this.GroupSyncTagIds.Add(ownerPbDataId, hashSet);
			}
			hashSet.Add(tagId);
		}

		// Token: 0x06036CAE RID: 224430 RVA: 0x00CF81C8 File Offset: 0x00CF63C8
		private void OnGroupSyncTagRemoved(int ownerPbDataId, int tagId)
		{
			HashSet<int> hashSet;
			if (!this.GroupSyncTagIds.TryGetValue(ownerPbDataId, out hashSet))
			{
				return;
			}
			hashSet.RemoveWhere((int cachedTagId) => GameplayTagUtils.IsChildTag(cachedTagId, tagId));
			if (hashSet.Count == 0)
			{
				this.GroupSyncTagIds.Remove(ownerPbDataId);
			}
		}

		// Token: 0x06036CAF RID: 224431 RVA: 0x00CF821C File Offset: 0x00CF641C
		[NullableContext(2)]
		public MonsterPatrolInfo GetMonsterInfoByEntityId(int id)
		{
			MonsterPatrolInfo result;
			if (!this.MonsterEntityInfoMap.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06036CB0 RID: 224432 RVA: 0x00CF823C File Offset: 0x00CF643C
		public bool TryAddMonsterToGroup(int groupEntityId, int pbDataId)
		{
			MonsterGroupInfo monsterGroupInfo;
			if (!this.MonsterGroups.TryGetValue(groupEntityId, out monsterGroupInfo))
			{
				return false;
			}
			if (!monsterGroupInfo.TryAddMonster(pbDataId))
			{
				return false;
			}
			foreach (KeyValuePair<int, MonsterPatrolInfo> keyValuePair in monsterGroupInfo.GroupInfo)
			{
				MonsterPatrolInfo value = keyValuePair.Value;
				if (value.PbDataId == pbDataId)
				{
					this.MonsterEntityInfoMap[value.EntityId] = value;
					EventSystem.Instance.Emit<int>(EEventName.OnGeneratedMonsterPatrolGroup, groupEntityId);
					break;
				}
			}
			return true;
		}

		// Token: 0x06036CB1 RID: 224433 RVA: 0x00CF82DC File Offset: 0x00CF64DC
		public bool RemoveMemberOnEntityDestroyed(int groupEntityId, int memberEntityId)
		{
			MonsterGroupInfo monsterGroupInfo;
			if (!this.MonsterGroups.TryGetValue(groupEntityId, out monsterGroupInfo))
			{
				this.MonsterEntityInfoMap.Remove(memberEntityId);
				return false;
			}
			return monsterGroupInfo.RemoveMemberByEntityId(memberEntityId);
		}

		// Token: 0x06036CB2 RID: 224434 RVA: 0x00CF8310 File Offset: 0x00CF6510
		public bool CreateGroup(int entityId, GroupAiComponent groupComp, IReadOnlyList<int> registeredPbDataIds)
		{
			MonsterGroupInfo monsterGroupInfo = new MonsterGroupInfo(entityId);
			monsterGroupInfo.OnMemberRemoved = delegate(int memberEntityId)
			{
				this.MonsterEntityInfoMap.Remove(memberEntityId);
			};
			if (!monsterGroupInfo.Init(groupComp, registeredPbDataIds))
			{
				return false;
			}
			foreach (KeyValuePair<int, MonsterPatrolInfo> keyValuePair in monsterGroupInfo.GroupInfo)
			{
				MonsterPatrolInfo value = keyValuePair.Value;
				this.MonsterEntityInfoMap[value.EntityId] = value;
			}
			this.MonsterGroups[entityId] = monsterGroupInfo;
			EventSystem.Instance.Emit<int>(EEventName.OnGeneratedMonsterPatrolGroup, entityId);
			return true;
		}

		// Token: 0x170083BA RID: 33722
		// (get) Token: 0x06036CB3 RID: 224435 RVA: 0x00CF83BC File Offset: 0x00CF65BC
		public static MonsterGroupPatrolModel Instance
		{
			get
			{
				return MonsterGroupPatrolModel._Instance;
			}
		}

		// Token: 0x06036CB4 RID: 224436 RVA: 0x00CF83C3 File Offset: 0x00CF65C3
		public static MonsterGroupPatrolModel GetOrCreateInstance()
		{
			if (MonsterGroupPatrolModel._Instance == null)
			{
				MonsterGroupPatrolModel.CreateInstance();
			}
			return MonsterGroupPatrolModel._Instance;
		}

		// Token: 0x06036CB5 RID: 224437 RVA: 0x00CF83D7 File Offset: 0x00CF65D7
		public static bool CreateInstance()
		{
			if (MonsterGroupPatrolModel._Instance != null)
			{
				return true;
			}
			MonsterGroupPatrolModel._Instance = new MonsterGroupPatrolModel();
			return true;
		}

		// Token: 0x06036CB6 RID: 224438 RVA: 0x00CF83ED File Offset: 0x00CF65ED
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036CB7 RID: 224439 RVA: 0x00CF83EF File Offset: 0x00CF65EF
		public static void ResetStaticDefaultValue()
		{
			MonsterGroupPatrolModel._Instance = null;
		}

		// Token: 0x06036CB8 RID: 224440 RVA: 0x00CF83F7 File Offset: 0x00CF65F7
		static MonsterGroupPatrolModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MonsterGroupPatrolModel.CreateStaticDefaultValue), new Action(MonsterGroupPatrolModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401CEB9 RID: 118457
		public readonly Dictionary<int, MonsterPatrolInfo> MonsterEntityInfoMap = new Dictionary<int, MonsterPatrolInfo>();

		// Token: 0x0401CEBA RID: 118458
		public readonly Dictionary<int, MonsterGroupInfo> MonsterGroups = new Dictionary<int, MonsterGroupInfo>();

		// Token: 0x0401CEBB RID: 118459
		private readonly Dictionary<int, HashSet<int>> GroupSyncTagIds = new Dictionary<int, HashSet<int>>();

		// Token: 0x0401CEBC RID: 118460
		[Nullable(2)]
		private static MonsterGroupPatrolModel _Instance;
	}
}
