using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Module.MonsterGroup;

namespace CSharpScript.Game.NewWorld.Character.Monster.Controller
{
	// Token: 0x020070A0 RID: 28832
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class MonsterGroupEcologyController : ControllerBase
	{
		// Token: 0x06046406 RID: 287750 RVA: 0x011944E0 File Offset: 0x011926E0
		protected override bool OnClear()
		{
			this.PendingEcologyGroups.Clear();
			this.EntityIdToGroupId.Clear();
			return true;
		}

		// Token: 0x06046407 RID: 287751 RVA: 0x011944FC File Offset: 0x011926FC
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

		// Token: 0x06046408 RID: 287752 RVA: 0x01194614 File Offset: 0x01192814
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

		// Token: 0x06046409 RID: 287753 RVA: 0x011946CC File Offset: 0x011928CC
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

		// Token: 0x0604640A RID: 287754 RVA: 0x011947D4 File Offset: 0x011929D4
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

		// Token: 0x0604640B RID: 287755 RVA: 0x011948C8 File Offset: 0x01192AC8
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

		// Token: 0x0604640C RID: 287756 RVA: 0x01194940 File Offset: 0x01192B40
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

		// Token: 0x0604640D RID: 287757 RVA: 0x01194990 File Offset: 0x01192B90
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

		// Token: 0x17009C2B RID: 39979
		// (get) Token: 0x0604640E RID: 287758 RVA: 0x011949E3 File Offset: 0x01192BE3
		public static MonsterGroupEcologyController Instance
		{
			get
			{
				return MonsterGroupEcologyController._Instance;
			}
		}

		// Token: 0x0604640F RID: 287759 RVA: 0x011949EA File Offset: 0x01192BEA
		public static MonsterGroupEcologyController GetOrCreateInstance()
		{
			if (MonsterGroupEcologyController._Instance == null)
			{
				MonsterGroupEcologyController.CreateInstance();
			}
			return MonsterGroupEcologyController._Instance;
		}

		// Token: 0x06046410 RID: 287760 RVA: 0x011949FE File Offset: 0x01192BFE
		public static bool CreateInstance()
		{
			if (MonsterGroupEcologyController._Instance != null)
			{
				return true;
			}
			MonsterGroupEcologyController._Instance = new MonsterGroupEcologyController();
			return true;
		}

		// Token: 0x06046411 RID: 287761 RVA: 0x01194A14 File Offset: 0x01192C14
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06046412 RID: 287762 RVA: 0x01194A16 File Offset: 0x01192C16
		public static void ResetStaticDefaultValue()
		{
			MonsterGroupEcologyController._Instance = null;
		}

		// Token: 0x06046413 RID: 287763 RVA: 0x01194A1E File Offset: 0x01192C1E
		static MonsterGroupEcologyController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MonsterGroupEcologyController.CreateStaticDefaultValue), new Action(MonsterGroupEcologyController.ResetStaticDefaultValue));
		}

		// Token: 0x04024D00 RID: 150784
		private float DeltaTime;

		// Token: 0x04024D01 RID: 150785
		private readonly Dictionary<int, IPendingEcologyGroup> PendingEcologyGroups = new Dictionary<int, IPendingEcologyGroup>();

		// Token: 0x04024D02 RID: 150786
		private readonly Dictionary<int, int> EntityIdToGroupId = new Dictionary<int, int>();

		// Token: 0x04024D03 RID: 150787
		[Nullable(2)]
		private static MonsterGroupEcologyController _Instance;
	}
}
