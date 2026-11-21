using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.MonsterGroup
{
	// Token: 0x020043A7 RID: 17319
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MonsterGroupEcologyModel : ModelBase
	{
		// Token: 0x0602BBE0 RID: 179168 RVA: 0x00C46EBF File Offset: 0x00C450BF
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0602BBE1 RID: 179169 RVA: 0x00C46EC4 File Offset: 0x00C450C4
		protected override bool OnClear()
		{
			foreach (KeyValuePair<int, MonsterGroupEcologyInfo> keyValuePair in this.EcologyGroups)
			{
				keyValuePair.Value.Clear();
			}
			this.EcologyGroups.Clear();
			return true;
		}

		// Token: 0x0602BBE2 RID: 179170 RVA: 0x00C46F28 File Offset: 0x00C45128
		[NullableContext(2)]
		public MonsterGroupEcologyInfo GetEcologyGroup(int groupEntityId)
		{
			MonsterGroupEcologyInfo result;
			this.EcologyGroups.TryGetValue(groupEntityId, out result);
			return result;
		}

		// Token: 0x0602BBE3 RID: 179171 RVA: 0x00C46F48 File Offset: 0x00C45148
		public void RemoveEcologyGroup(int groupEntityId)
		{
			MonsterGroupEcologyInfo monsterGroupEcologyInfo;
			if (!this.EcologyGroups.TryGetValue(groupEntityId, out monsterGroupEcologyInfo))
			{
				return;
			}
			monsterGroupEcologyInfo.Clear();
			this.EcologyGroups.Remove(groupEntityId);
		}

		// Token: 0x0602BBE4 RID: 179172 RVA: 0x00C46F7C File Offset: 0x00C4517C
		public bool RemoveMemberOnEntityDestroyed(int groupEntityId, int memberEntityId)
		{
			MonsterGroupEcologyInfo monsterGroupEcologyInfo;
			return this.EcologyGroups.TryGetValue(groupEntityId, out monsterGroupEcologyInfo) && monsterGroupEcologyInfo.RemoveMemberByEntityId(memberEntityId);
		}

		// Token: 0x0602BBE5 RID: 179173 RVA: 0x00C46FA4 File Offset: 0x00C451A4
		public bool TryAddMemberToEcologyGroup(int groupEntityId, int pbDataId)
		{
			MonsterGroupEcologyInfo monsterGroupEcologyInfo;
			return this.EcologyGroups.TryGetValue(groupEntityId, out monsterGroupEcologyInfo) && monsterGroupEcologyInfo.TryAddMember(pbDataId);
		}

		// Token: 0x0602BBE6 RID: 179174 RVA: 0x00C46FCC File Offset: 0x00C451CC
		public bool GenerateAddEcologyGroup(int entityId, GroupAiComponent groupComp, IReadOnlyList<int> registeredPbDataIds)
		{
			MonsterGroupEcologyInfo monsterGroupEcologyInfo = new MonsterGroupEcologyInfo(entityId);
			if (!monsterGroupEcologyInfo.Init(groupComp, registeredPbDataIds))
			{
				return false;
			}
			this.EcologyGroups[entityId] = monsterGroupEcologyInfo;
			return true;
		}

		// Token: 0x17005785 RID: 22405
		// (get) Token: 0x0602BBE7 RID: 179175 RVA: 0x00C46FFA File Offset: 0x00C451FA
		public static MonsterGroupEcologyModel Instance
		{
			get
			{
				return MonsterGroupEcologyModel._Instance;
			}
		}

		// Token: 0x0602BBE8 RID: 179176 RVA: 0x00C47001 File Offset: 0x00C45201
		public static MonsterGroupEcologyModel GetOrCreateInstance()
		{
			if (MonsterGroupEcologyModel._Instance == null)
			{
				MonsterGroupEcologyModel.CreateInstance();
			}
			return MonsterGroupEcologyModel._Instance;
		}

		// Token: 0x0602BBE9 RID: 179177 RVA: 0x00C47015 File Offset: 0x00C45215
		public static bool CreateInstance()
		{
			if (MonsterGroupEcologyModel._Instance != null)
			{
				return true;
			}
			MonsterGroupEcologyModel._Instance = new MonsterGroupEcologyModel();
			return true;
		}

		// Token: 0x0602BBEA RID: 179178 RVA: 0x00C4702B File Offset: 0x00C4522B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602BBEB RID: 179179 RVA: 0x00C4702D File Offset: 0x00C4522D
		public static void ResetStaticDefaultValue()
		{
			MonsterGroupEcologyModel._Instance = null;
		}

		// Token: 0x0602BBEC RID: 179180 RVA: 0x00C47035 File Offset: 0x00C45235
		static MonsterGroupEcologyModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MonsterGroupEcologyModel.CreateStaticDefaultValue), new Action(MonsterGroupEcologyModel.ResetStaticDefaultValue));
		}

		// Token: 0x04017949 RID: 96585
		public readonly Dictionary<int, MonsterGroupEcologyInfo> EcologyGroups = new Dictionary<int, MonsterGroupEcologyInfo>();

		// Token: 0x0401794A RID: 96586
		[Nullable(2)]
		private static MonsterGroupEcologyModel _Instance;
	}
}
