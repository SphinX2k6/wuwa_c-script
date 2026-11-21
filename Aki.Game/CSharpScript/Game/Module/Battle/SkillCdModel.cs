using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Module.InstanceDungeon;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C3D RID: 19517
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillCdModel : ModelBase
	{
		// Token: 0x06030B9C RID: 199580 RVA: 0x00D968F6 File Offset: 0x00D94AF6
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06030B9D RID: 199581 RVA: 0x00D968F9 File Offset: 0x00D94AF9
		protected override bool OnLeaveLevel()
		{
			this.InstanceDungeonSkillCdData.Clear();
			this.InstanceDungeonPassiveSkillCdData.Clear();
			return true;
		}

		// Token: 0x06030B9E RID: 199582 RVA: 0x00D96912 File Offset: 0x00D94B12
		protected override bool OnClear()
		{
			this.MainWorldSkillCdData.Clear();
			this.MainWorldPassiveSkillCdData.Clear();
			this.InstanceDungeonSkillCdData.Clear();
			this.InstanceDungeonPassiveSkillCdData.Clear();
			return true;
		}

		// Token: 0x06030B9F RID: 199583 RVA: 0x00D96941 File Offset: 0x00D94B41
		public WorldSkillCdData GetCurWorldSkillCdData()
		{
			if (!this.IsUseMainWorldData())
			{
				return this.InstanceDungeonSkillCdData;
			}
			return this.MainWorldSkillCdData;
		}

		// Token: 0x06030BA0 RID: 199584 RVA: 0x00D96958 File Offset: 0x00D94B58
		public WorldPassiveSkillCdData GetCurWorldPassiveSkillCdData()
		{
			if (!this.IsUseMainWorldData())
			{
				return this.InstanceDungeonPassiveSkillCdData;
			}
			return this.MainWorldPassiveSkillCdData;
		}

		// Token: 0x06030BA1 RID: 199585 RVA: 0x00D9696F File Offset: 0x00D94B6F
		public void HandlePlayerSkillInfoPbNotify(PlayerSkillInfoPbNotify notify)
		{
			this.MainWorldSkillCdData.HandlePlayerSkillInfoPbNotify(notify);
		}

		// Token: 0x06030BA2 RID: 199586 RVA: 0x00D9697D File Offset: 0x00D94B7D
		public void HandlePassiveSkillNotify(PassiveSkillNotify notify)
		{
			this.MainWorldPassiveSkillCdData.HandlePassiveSkillNotify(notify);
		}

		// Token: 0x06030BA3 RID: 199587 RVA: 0x00D9698C File Offset: 0x00D94B8C
		private bool IsUseMainWorldData()
		{
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			return instanceId == 0 || InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.ShareAttri != 0;
		}

		// Token: 0x06030BA4 RID: 199588 RVA: 0x00D969C8 File Offset: 0x00D94BC8
		[NullableContext(2)]
		public GroupSkillCdInfo GetGroupSkillCdInfoBySkillId(int entityId, int skillId)
		{
			WorldSkillCdData curWorldSkillCdData = this.GetCurWorldSkillCdData();
			SkillCdData allShareSkillCdData = curWorldSkillCdData.AllShareSkillCdData;
			int key;
			if (allShareSkillCdData.SkillId2GroupIdMap.TryGetValue(skillId, out key))
			{
				return allShareSkillCdData.GroupSkillCdInfoMap.GetValueOrDefault(key);
			}
			if (curWorldSkillCdData.EntitySkillCdMap.TryGetValue(entityId, out allShareSkillCdData) && allShareSkillCdData.SkillId2GroupIdMap.TryGetValue(skillId, out key))
			{
				return allShareSkillCdData.GroupSkillCdInfoMap.GetValueOrDefault(key);
			}
			return null;
		}

		// Token: 0x17006192 RID: 24978
		// (get) Token: 0x06030BA5 RID: 199589 RVA: 0x00D96A2E File Offset: 0x00D94C2E
		public static SkillCdModel Instance
		{
			get
			{
				return SkillCdModel._Instance;
			}
		}

		// Token: 0x06030BA6 RID: 199590 RVA: 0x00D96A35 File Offset: 0x00D94C35
		public static SkillCdModel GetOrCreateInstance()
		{
			if (SkillCdModel._Instance == null)
			{
				SkillCdModel.CreateInstance();
			}
			return SkillCdModel._Instance;
		}

		// Token: 0x06030BA7 RID: 199591 RVA: 0x00D96A49 File Offset: 0x00D94C49
		public static bool CreateInstance()
		{
			if (SkillCdModel._Instance != null)
			{
				return true;
			}
			SkillCdModel._Instance = new SkillCdModel();
			return true;
		}

		// Token: 0x06030BA8 RID: 199592 RVA: 0x00D96A5F File Offset: 0x00D94C5F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030BA9 RID: 199593 RVA: 0x00D96A61 File Offset: 0x00D94C61
		public static void ResetStaticDefaultValue()
		{
			SkillCdModel._Instance = null;
		}

		// Token: 0x06030BAA RID: 199594 RVA: 0x00D96A69 File Offset: 0x00D94C69
		static SkillCdModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkillCdModel.CreateStaticDefaultValue), new Action(SkillCdModel.ResetStaticDefaultValue));
		}

		// Token: 0x04019CA1 RID: 105633
		private readonly WorldSkillCdData MainWorldSkillCdData = new WorldSkillCdData();

		// Token: 0x04019CA2 RID: 105634
		private readonly WorldPassiveSkillCdData MainWorldPassiveSkillCdData = new WorldPassiveSkillCdData();

		// Token: 0x04019CA3 RID: 105635
		private readonly WorldSkillCdData InstanceDungeonSkillCdData = new WorldSkillCdData();

		// Token: 0x04019CA4 RID: 105636
		private readonly WorldPassiveSkillCdData InstanceDungeonPassiveSkillCdData = new WorldPassiveSkillCdData();

		// Token: 0x04019CA5 RID: 105637
		public bool SkillDebugMode;

		// Token: 0x04019CA6 RID: 105638
		[Nullable(2)]
		private static SkillCdModel _Instance;
	}
}
