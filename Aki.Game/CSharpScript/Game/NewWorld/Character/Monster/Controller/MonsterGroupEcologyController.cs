using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Module.MonsterGroup;

namespace CSharpScript.Game.NewWorld.Character.Monster.Controller
{
	// Token: 0x02006305 RID: 25349
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class MonsterGroupEcologyController : ControllerBase
	{
		// Token: 0x0603D4F4 RID: 251124 RVA: 0x011B754C File Offset: 0x011B574C
		protected override bool OnClear()
		{
			this.PendingEcologyGroups.Clear();
			this.EntityIdToGroupId.Clear();
			return true;
		}

		// Token: 0x0603D4F5 RID: 251125 RVA: 0x011B7568 File Offset: 0x011B5768
		protected override void OnTick(float delta)
		{
			this.DeltaTime += delta;
			if (this.DeltaTime < 1000f)
			{
				return;
			}
			this.DeltaTime = 0f;
			this.TryGenerateAllPendingGroups();
			MonsterGroupEcologyModel instance = MonsterGroupEcologyModel.Instance;
			Dictionary<int, MonsterGroupEcologyInfo> dictionary = (instance != null) ? instance.EcologyGroups : null;
			if (dictionary == null || dictionary.Count == 0)
			{
				return;
			}
			List<int> list = null;
			foreach (KeyValuePair<int, MonsterGroupEcologyInfo> keyValuePair in dictionary)
			{
				int key = keyValuePair.Key;
				MonsterGroupEcologyInfo value = keyValuePair.Value;
				value.CheckMembersValid();
				value.Tick();
				if (value.ShouldRemove())
				{
					if (list == null)
					{
						list = new List<int>();
					}
					list.Add(key);
				}
			}
			if (list != null)
			{
				foreach (int groupEntityId in list)
				{
					MonsterGroupEcologyModel instance2 = MonsterGroupEcologyModel.Instance;
					if (instance2 != null)
					{
						instance2.RemoveEcologyGroup(groupEntityId);
					}
				}
			}
		}

		// Token: 0x0603D4F6 RID: 251126 RVA: 0x011B7680 File Offset: 0x011B5880
		private void TryGenerateAllPendingGroups()
		{
			if (this.PendingEcologyGroups.Count == 0)
			{
				return;
			}
			List<int> list = new List<int>(this.PendingEcologyGroups.Count);
			foreach (KeyValuePair<int, IPendingEcologyGroup> keyValuePair in this.PendingEcologyGroups)
			{
				list.Add(keyValuePair.Key);
			}
			foreach (int groupEntityId in list)
			{
				this.TryGeneratePendingGroup(groupEntityId);
			}
		}

		// Token: 0x0603D4F7 RID: 251127 RVA: 0x011B7738 File Offset: 0x011B5938
		private void TryGeneratePendingGroup(int groupEntityId)
		{
			MonsterGroupEcologyModel instance = MonsterGroupEcologyModel.Instance;
			if (instance == null)
			{
				return;
			}
			IPendingEcologyGroup pendingEcologyGroup;
			if (!this.PendingEcologyGroups.TryGetValue(groupEntityId, out pendingEcologyGroup))
			{
				return;
			}
			MonsterGroupEcologyInfo ecologyGroup = instance.GetEcologyGroup(groupEntityId);
			if (ecologyGroup != null)
			{
				List<int> list = new List<int>();
				foreach (int num in pendingEcologyGroup.RegisteredPbDataIds)
				{
					if (!ecologyGroup.HasMemberByPbDataId(num) && !instance.TryAddMemberToEcologyGroup(groupEntityId, num))
					{
						list.Add(num);
					}
				}
				if (list.Count == 0)
				{
					this.PendingEcologyGroups.Remove(groupEntityId);
					return;
				}
				pendingEcologyGroup.RegisteredPbDataIds = new HashSet<int>(list);
				return;
			}
			else
			{
				int count = pendingEcologyGroup.GroupComp.Entities.Count;
				if (pendingEcologyGroup.RegisteredPbDataIds.Count < count)
				{
					return;
				}
				if (!instance.GenerateAddEcologyGroup(groupEntityId, pendingEcologyGroup.GroupComp, new List<int>(pendingEcologyGroup.RegisteredPbDataIds)))
				{
					return;
				}
				this.PendingEcologyGroups.Remove(groupEntityId);
				return;
			}
		}

		// Token: 0x0603D4F8 RID: 251128 RVA: 0x011B7840 File Offset: 0x011B5A40
		public unsafe void RegisterMonsterPbDataId(int groupEntityId, Entity entity, int pbDataId, GroupAiComponent groupComp)
		{
			if (MonsterGroupEcologyModel.Instance == null)
			{
				return;
			}
			if (!groupComp.Entities.Contains(pbDataId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.AI;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[GroupAi.Ecology] 注册的PbDataId不在群组配置中";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("GroupEntityId", groupEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", pbDataId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.EntityIdToGroupId[entity.Id] = groupEntityId;
			IPendingEcologyGroup pendingEcologyGroup;
			if (!this.PendingEcologyGroups.TryGetValue(groupEntityId, out pendingEcologyGroup))
			{
				pendingEcologyGroup = new PendingEcologyGroup
				{
					GroupComp = groupComp,
					RegisteredPbDataIds = new HashSet<int>()
				};
				this.PendingEcologyGroups[groupEntityId] = pendingEcologyGroup;
			}
			if (pendingEcologyGroup.RegisteredPbDataIds.Contains(pbDataId))
			{
				return;
			}
			pendingEcologyGroup.RegisteredPbDataIds.Add(pbDataId);
			this.DeltaTime = 0f;
		}

		// Token: 0x0603D4F9 RID: 251129 RVA: 0x011B7934 File Offset: 0x011B5B34
		public void RemoveEntityFromMonsterGroup(int entityId, int pbDataId)
		{
			int num;
			if (!this.EntityIdToGroupId.TryGetValue(entityId, out num))
			{
				return;
			}
			this.EntityIdToGroupId.Remove(entityId);
			MonsterGroupEcologyModel instance = MonsterGroupEcologyModel.Instance;
			if (instance != null)
			{
				instance.RemoveMemberOnEntityDestroyed(num, entityId);
			}
			IPendingEcologyGroup pendingEcologyGroup;
			if (this.PendingEcologyGroups.TryGetValue(num, out pendingEcologyGroup))
			{
				pendingEcologyGroup.RegisteredPbDataIds.Remove(pbDataId);
				if (pendingEcologyGroup.RegisteredPbDataIds.Count == 0)
				{
					this.PendingEcologyGroups.Remove(num);
				}
			}
		}

		// Token: 0x0603D4FA RID: 251130 RVA: 0x011B79AC File Offset: 0x011B5BAC
		public bool CheckEntityInMonsterGroup(int entityId)
		{
			int key;
			if (!this.EntityIdToGroupId.TryGetValue(entityId, out key))
			{
				return false;
			}
			MonsterGroupEcologyModel instance = MonsterGroupEcologyModel.Instance;
			Dictionary<int, MonsterGroupEcologyInfo> dictionary = (instance != null) ? instance.EcologyGroups : null;
			MonsterGroupEcologyInfo monsterGroupEcologyInfo;
			return dictionary != null && dictionary.TryGetValue(key, out monsterGroupEcologyInfo) && monsterGroupEcologyInfo.GroupInfo.ContainsKey(entityId);
		}

		// Token: 0x0603D4FB RID: 251131 RVA: 0x011B79FC File Offset: 0x011B5BFC
		[NullableContext(2)]
		public MonsterEcologyInfo GetMonsterInfoByEntityId(int entityId)
		{
			int key;
			if (!this.EntityIdToGroupId.TryGetValue(entityId, out key))
			{
				return null;
			}
			MonsterGroupEcologyModel instance = MonsterGroupEcologyModel.Instance;
			Dictionary<int, MonsterGroupEcologyInfo> dictionary = (instance != null) ? instance.EcologyGroups : null;
			if (dictionary == null)
			{
				return null;
			}
			MonsterGroupEcologyInfo monsterGroupEcologyInfo;
			if (!dictionary.TryGetValue(key, out monsterGroupEcologyInfo))
			{
				return null;
			}
			MonsterEcologyInfo result;
			monsterGroupEcologyInfo.GroupInfo.TryGetValue(entityId, out result);
			return result;
		}

		// Token: 0x17007410 RID: 29712
		// (get) Token: 0x0603D4FC RID: 251132 RVA: 0x011B7A4F File Offset: 0x011B5C4F
		public static MonsterGroupEcologyController Instance
		{
			get
			{
				return MonsterGroupEcologyController._Instance;
			}
		}

		// Token: 0x0603D4FD RID: 251133 RVA: 0x011B7A56 File Offset: 0x011B5C56
		public static MonsterGroupEcologyController GetOrCreateInstance()
		{
			if (MonsterGroupEcologyController._Instance == null)
			{
				MonsterGroupEcologyController.CreateInstance();
			}
			return MonsterGroupEcologyController._Instance;
		}

		// Token: 0x0603D4FE RID: 251134 RVA: 0x011B7A6A File Offset: 0x011B5C6A
		public static bool CreateInstance()
		{
			if (MonsterGroupEcologyController._Instance != null)
			{
				return true;
			}
			MonsterGroupEcologyController._Instance = new MonsterGroupEcologyController();
			return true;
		}

		// Token: 0x0603D4FF RID: 251135 RVA: 0x011B7A80 File Offset: 0x011B5C80
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D500 RID: 251136 RVA: 0x011B7A82 File Offset: 0x011B5C82
		public static void ResetStaticDefaultValue()
		{
			MonsterGroupEcologyController._Instance = null;
		}

		// Token: 0x0603D501 RID: 251137 RVA: 0x011B7A8A File Offset: 0x011B5C8A
		static MonsterGroupEcologyController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MonsterGroupEcologyController.CreateStaticDefaultValue), new Action(MonsterGroupEcologyController.ResetStaticDefaultValue));
		}

		// Token: 0x04020852 RID: 133202
		private float DeltaTime;

		// Token: 0x04020853 RID: 133203
		private readonly Dictionary<int, IPendingEcologyGroup> PendingEcologyGroups = new Dictionary<int, IPendingEcologyGroup>();

		// Token: 0x04020854 RID: 133204
		private readonly Dictionary<int, int> EntityIdToGroupId = new Dictionary<int, int>();

		// Token: 0x04020855 RID: 133205
		[Nullable(2)]
		private static MonsterGroupEcologyController _Instance;
	}
}
