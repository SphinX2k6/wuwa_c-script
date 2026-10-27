using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Module.InstanceDungeon;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C5D RID: 23645
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillCdModel : ModelBase
	{
		// Token: 0x0603BC51 RID: 244817 RVA: 0x00E46516 File Offset: 0x00E44716
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603BC52 RID: 244818 RVA: 0x00E46519 File Offset: 0x00E44719
		protected override bool OnLeaveLevel()
		{
			this.InstanceDungeonSkillCdData.Clear();
			this.InstanceDungeonPassiveSkillCdData.Clear();
			return true;
		}

		// Token: 0x0603BC53 RID: 244819 RVA: 0x00E46532 File Offset: 0x00E44732
		protected override bool OnClear()
		{
			this.MainWorldSkillCdData.Clear();
			this.MainWorldPassiveSkillCdData.Clear();
			this.InstanceDungeonSkillCdData.Clear();
			this.InstanceDungeonPassiveSkillCdData.Clear();
			return true;
		}

		// Token: 0x0603BC54 RID: 244820 RVA: 0x00E46561 File Offset: 0x00E44761
		public WorldSkillCdData GetCurWorldSkillCdData()
		{
			if (!this.IsUseMainWorldData())
			{
				return this.InstanceDungeonSkillCdData;
			}
			return this.MainWorldSkillCdData;
		}

		// Token: 0x0603BC55 RID: 244821 RVA: 0x00E46578 File Offset: 0x00E44778
		public WorldPassiveSkillCdData GetCurWorldPassiveSkillCdData()
		{
			if (!this.IsUseMainWorldData())
			{
				return this.InstanceDungeonPassiveSkillCdData;
			}
			return this.MainWorldPassiveSkillCdData;
		}

		// Token: 0x0603BC56 RID: 244822 RVA: 0x00E4658F File Offset: 0x00E4478F
		public void HandlePlayerSkillInfoPbNotify(PlayerSkillInfoPbNotify notify)
		{
			this.MainWorldSkillCdData.HandlePlayerSkillInfoPbNotify(notify);
		}

		// Token: 0x0603BC57 RID: 244823 RVA: 0x00E4659D File Offset: 0x00E4479D
		public void HandlePassiveSkillNotify(PassiveSkillNotify notify)
		{
			this.MainWorldPassiveSkillCdData.HandlePassiveSkillNotify(notify);
		}

		// Token: 0x0603BC58 RID: 244824 RVA: 0x00E465AC File Offset: 0x00E447AC
		private bool IsUseMainWorldData()
		{
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			return instanceId == 0 || InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.ShareAttri != 0;
		}

		// Token: 0x0603BC59 RID: 244825 RVA: 0x00E465E8 File Offset: 0x00E447E8
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

		// Token: 0x17008DC0 RID: 36288
		// (get) Token: 0x0603BC5A RID: 244826 RVA: 0x00E4664E File Offset: 0x00E4484E
		public static SkillCdModel Instance
		{
			get
			{
				return SkillCdModel._Instance;
			}
		}

		// Token: 0x0603BC5B RID: 244827 RVA: 0x00E46655 File Offset: 0x00E44855
		public static SkillCdModel GetOrCreateInstance()
		{
			if (SkillCdModel._Instance == null)
			{
				SkillCdModel.CreateInstance();
			}
			return SkillCdModel._Instance;
		}

		// Token: 0x0603BC5C RID: 244828 RVA: 0x00E46669 File Offset: 0x00E44869
		public static bool CreateInstance()
		{
			if (SkillCdModel._Instance != null)
			{
				return true;
			}
			SkillCdModel._Instance = new SkillCdModel();
			return true;
		}

		// Token: 0x0603BC5D RID: 244829 RVA: 0x00E4667F File Offset: 0x00E4487F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BC5E RID: 244830 RVA: 0x00E46681 File Offset: 0x00E44881
		public static void ResetStaticDefaultValue()
		{
			SkillCdModel._Instance = null;
		}

		// Token: 0x0603BC5F RID: 244831 RVA: 0x00E46689 File Offset: 0x00E44889
		static SkillCdModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkillCdModel.CreateStaticDefaultValue), new Action(SkillCdModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401F1F0 RID: 127472
		private readonly WorldSkillCdData MainWorldSkillCdData = new WorldSkillCdData();

		// Token: 0x0401F1F1 RID: 127473
		private readonly WorldPassiveSkillCdData MainWorldPassiveSkillCdData = new WorldPassiveSkillCdData();

		// Token: 0x0401F1F2 RID: 127474
		private readonly WorldSkillCdData InstanceDungeonSkillCdData = new WorldSkillCdData();

		// Token: 0x0401F1F3 RID: 127475
		private readonly WorldPassiveSkillCdData InstanceDungeonPassiveSkillCdData = new WorldPassiveSkillCdData();

		// Token: 0x0401F1F4 RID: 127476
		public bool SkillDebugMode;

		// Token: 0x0401F1F5 RID: 127477
		[Nullable(2)]
		private static SkillCdModel _Instance;
	}
}
