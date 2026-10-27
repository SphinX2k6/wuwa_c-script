using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.MonsterGroup
{
	// Token: 0x020053C4 RID: 21444
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MonsterGroupEcologyModel : ModelBase
	{
		// Token: 0x06036C9A RID: 224410 RVA: 0x00CF7E17 File Offset: 0x00CF6017
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06036C9B RID: 224411 RVA: 0x00CF7E1C File Offset: 0x00CF601C
		protected override bool OnClear()
		{
			foreach (KeyValuePair<int, MonsterGroupEcologyInfo> keyValuePair in this.EcologyGroups)
			{
				keyValuePair.Value.Clear();
			}
			this.EcologyGroups.Clear();
			return true;
		}

		// Token: 0x06036C9C RID: 224412 RVA: 0x00CF7E80 File Offset: 0x00CF6080
		[NullableContext(2)]
		public MonsterGroupEcologyInfo GetEcologyGroup(int groupEntityId)
		{
			MonsterGroupEcologyInfo result;
			this.EcologyGroups.TryGetValue(groupEntityId, out result);
			return result;
		}

		// Token: 0x06036C9D RID: 224413 RVA: 0x00CF7EA0 File Offset: 0x00CF60A0
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

		// Token: 0x06036C9E RID: 224414 RVA: 0x00CF7ED4 File Offset: 0x00CF60D4
		public bool RemoveMemberOnEntityDestroyed(int groupEntityId, int memberEntityId)
		{
			MonsterGroupEcologyInfo monsterGroupEcologyInfo;
			return this.EcologyGroups.TryGetValue(groupEntityId, out monsterGroupEcologyInfo) && monsterGroupEcologyInfo.RemoveMemberByEntityId(memberEntityId);
		}

		// Token: 0x06036C9F RID: 224415 RVA: 0x00CF7EFC File Offset: 0x00CF60FC
		public bool TryAddMemberToEcologyGroup(int groupEntityId, int pbDataId)
		{
			MonsterGroupEcologyInfo monsterGroupEcologyInfo;
			return this.EcologyGroups.TryGetValue(groupEntityId, out monsterGroupEcologyInfo) && monsterGroupEcologyInfo.TryAddMember(pbDataId);
		}

		// Token: 0x06036CA0 RID: 224416 RVA: 0x00CF7F24 File Offset: 0x00CF6124
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

		// Token: 0x170083B9 RID: 33721
		// (get) Token: 0x06036CA1 RID: 224417 RVA: 0x00CF7F52 File Offset: 0x00CF6152
		public static MonsterGroupEcologyModel Instance
		{
			get
			{
				return MonsterGroupEcologyModel._Instance;
			}
		}

		// Token: 0x06036CA2 RID: 224418 RVA: 0x00CF7F59 File Offset: 0x00CF6159
		public static MonsterGroupEcologyModel GetOrCreateInstance()
		{
			if (MonsterGroupEcologyModel._Instance == null)
			{
				MonsterGroupEcologyModel.CreateInstance();
			}
			return MonsterGroupEcologyModel._Instance;
		}

		// Token: 0x06036CA3 RID: 224419 RVA: 0x00CF7F6D File Offset: 0x00CF616D
		public static bool CreateInstance()
		{
			if (MonsterGroupEcologyModel._Instance != null)
			{
				return true;
			}
			MonsterGroupEcologyModel._Instance = new MonsterGroupEcologyModel();
			return true;
		}

		// Token: 0x06036CA4 RID: 224420 RVA: 0x00CF7F83 File Offset: 0x00CF6183
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036CA5 RID: 224421 RVA: 0x00CF7F85 File Offset: 0x00CF6185
		public static void ResetStaticDefaultValue()
		{
			MonsterGroupEcologyModel._Instance = null;
		}

		// Token: 0x06036CA6 RID: 224422 RVA: 0x00CF7F8D File Offset: 0x00CF618D
		static MonsterGroupEcologyModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MonsterGroupEcologyModel.CreateStaticDefaultValue), new Action(MonsterGroupEcologyModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401CEB1 RID: 118449
		public readonly Dictionary<int, MonsterGroupEcologyInfo> EcologyGroups = new Dictionary<int, MonsterGroupEcologyInfo>();

		// Token: 0x0401CEB2 RID: 118450
		[Nullable(2)]
		private static MonsterGroupEcologyModel _Instance;
	}
}
