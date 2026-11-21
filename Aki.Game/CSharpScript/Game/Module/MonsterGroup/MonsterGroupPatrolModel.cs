using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.MonsterGroup
{
	// Token: 0x020043A9 RID: 17321
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MonsterGroupPatrolModel : ModelBase
	{
		// Token: 0x0602BBEE RID: 179182 RVA: 0x00C47067 File Offset: 0x00C45267
		protected override bool OnInit()
		{
			EventSystem.Instance.Add<int, int>(EEventName.OnGroupAiSyncTagAdded, new Action<int, int>(this.OnGroupSyncTagAdded));
			EventSystem.Instance.Add<int, int>(EEventName.OnGroupAiSyncTagRemoved, new Action<int, int>(this.OnGroupSyncTagRemoved));
			return true;
		}

		// Token: 0x0602BBEF RID: 179183 RVA: 0x00C470A4 File Offset: 0x00C452A4
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

		// Token: 0x0602BBF0 RID: 179184 RVA: 0x00C47154 File Offset: 0x00C45354
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

		// Token: 0x0602BBF1 RID: 179185 RVA: 0x00C471E8 File Offset: 0x00C453E8
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

		// Token: 0x0602BBF2 RID: 179186 RVA: 0x00C47218 File Offset: 0x00C45418
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

		// Token: 0x0602BBF3 RID: 179187 RVA: 0x00C47238 File Offset: 0x00C45438
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

		// Token: 0x0602BBF4 RID: 179188 RVA: 0x00C47270 File Offset: 0x00C45470
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

		// Token: 0x0602BBF5 RID: 179189 RVA: 0x00C472C4 File Offset: 0x00C454C4
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

		// Token: 0x0602BBF6 RID: 179190 RVA: 0x00C472E4 File Offset: 0x00C454E4
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

		// Token: 0x0602BBF7 RID: 179191 RVA: 0x00C47384 File Offset: 0x00C45584
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

		// Token: 0x0602BBF8 RID: 179192 RVA: 0x00C473B8 File Offset: 0x00C455B8
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

		// Token: 0x17005786 RID: 22406
		// (get) Token: 0x0602BBF9 RID: 179193 RVA: 0x00C47464 File Offset: 0x00C45664
		public static MonsterGroupPatrolModel Instance
		{
			get
			{
				return MonsterGroupPatrolModel._Instance;
			}
		}

		// Token: 0x0602BBFA RID: 179194 RVA: 0x00C4746B File Offset: 0x00C4566B
		public static MonsterGroupPatrolModel GetOrCreateInstance()
		{
			if (MonsterGroupPatrolModel._Instance == null)
			{
				MonsterGroupPatrolModel.CreateInstance();
			}
			return MonsterGroupPatrolModel._Instance;
		}

		// Token: 0x0602BBFB RID: 179195 RVA: 0x00C4747F File Offset: 0x00C4567F
		public static bool CreateInstance()
		{
			if (MonsterGroupPatrolModel._Instance != null)
			{
				return true;
			}
			MonsterGroupPatrolModel._Instance = new MonsterGroupPatrolModel();
			return true;
		}

		// Token: 0x0602BBFC RID: 179196 RVA: 0x00C47495 File Offset: 0x00C45695
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602BBFD RID: 179197 RVA: 0x00C47497 File Offset: 0x00C45697
		public static void ResetStaticDefaultValue()
		{
			MonsterGroupPatrolModel._Instance = null;
		}

		// Token: 0x0602BBFE RID: 179198 RVA: 0x00C4749F File Offset: 0x00C4569F
		static MonsterGroupPatrolModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MonsterGroupPatrolModel.CreateStaticDefaultValue), new Action(MonsterGroupPatrolModel.ResetStaticDefaultValue));
		}

		// Token: 0x04017951 RID: 96593
		public readonly Dictionary<int, MonsterPatrolInfo> MonsterEntityInfoMap = new Dictionary<int, MonsterPatrolInfo>();

		// Token: 0x04017952 RID: 96594
		public readonly Dictionary<int, MonsterGroupInfo> MonsterGroups = new Dictionary<int, MonsterGroupInfo>();

		// Token: 0x04017953 RID: 96595
		private readonly Dictionary<int, HashSet<int>> GroupSyncTagIds = new Dictionary<int, HashSet<int>>();

		// Token: 0x04017954 RID: 96596
		[Nullable(2)]
		private static MonsterGroupPatrolModel _Instance;
	}
}
