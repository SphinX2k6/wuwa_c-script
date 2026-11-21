using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020055D1 RID: 21969
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class DropCatchConfig : ConfigBase
	{
		// Token: 0x06036758 RID: 223064 RVA: 0x00F347EB File Offset: 0x00F329EB
		public IReadOnlyList<DropCatchGameplay> GetDropCatchGameplayByActivityId(int activityId)
		{
			return ConfigDropCatchGameplayByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x06036759 RID: 223065 RVA: 0x00F347F4 File Offset: 0x00F329F4
		public IReadOnlyList<DropCatchRole> GetAllDropCatchRole()
		{
			return ConfigDropCatchRoleAll.GetConfigList(true);
		}

		// Token: 0x0603675A RID: 223066 RVA: 0x00F347FC File Offset: 0x00F329FC
		public DropCatchGameplay? GetDropCatchGameplayById(int id)
		{
			return ConfigDropCatchGameplayById.GetConfig(id, true);
		}

		// Token: 0x0603675B RID: 223067 RVA: 0x00F34805 File Offset: 0x00F32A05
		public DropCatchRole? GetDropCatchRoleById(int id)
		{
			return ConfigDropCatchRoleById.GetConfig(id, true);
		}

		// Token: 0x0603675C RID: 223068 RVA: 0x00F3480E File Offset: 0x00F32A0E
		public DropCatchDropItem? GetDropCatchDropItemById(int id)
		{
			return ConfigDropCatchDropItemById.GetConfig(id, true);
		}

		// Token: 0x0603675D RID: 223069 RVA: 0x00F34817 File Offset: 0x00F32A17
		public IReadOnlyList<DropCatchDropItem> GetAllDropItemConfig()
		{
			return ConfigDropCatchDropItemAll.GetConfigList(true);
		}

		// Token: 0x0603675E RID: 223070 RVA: 0x00F3481F File Offset: 0x00F32A1F
		public DropCatchDropPool? GetDropCatchDropPoolById(int id)
		{
			return ConfigDropCatchDropPoolById.GetConfig(id, true);
		}

		// Token: 0x0603675F RID: 223071 RVA: 0x00F34828 File Offset: 0x00F32A28
		public DropCatchReward? GetDropCatchRewardById(int id)
		{
			return ConfigDropCatchRewardById.GetConfig(id, true);
		}

		// Token: 0x06036760 RID: 223072 RVA: 0x00F34834 File Offset: 0x00F32A34
		public DropCatchGameplay? GetTargetRoleLevelInfo(int activityId, int roleId)
		{
			IReadOnlyList<DropCatchGameplay> dropCatchGameplayByActivityId = this.GetDropCatchGameplayByActivityId(activityId);
			if (dropCatchGameplayByActivityId != null)
			{
				foreach (DropCatchGameplay value in dropCatchGameplayByActivityId)
				{
					if (value.RoleId == roleId && value.ActivityId > 0)
					{
						return new DropCatchGameplay?(value);
					}
				}
			}
			return null;
		}

		// Token: 0x06036761 RID: 223073 RVA: 0x00F348AC File Offset: 0x00F32AAC
		public IReadOnlyList<DropCatchRoleBook> GetDropCatchRoleBookAll()
		{
			return ConfigDropCatchRoleBookAll.GetConfigList(true);
		}

		// Token: 0x06036762 RID: 223074 RVA: 0x00F348B4 File Offset: 0x00F32AB4
		public DropCatchRoleBook? GetDropCatchRoleBookById(int id)
		{
			return ConfigDropCatchRoleBookById.GetConfig(id, true);
		}

		// Token: 0x17006980 RID: 27008
		// (get) Token: 0x06036763 RID: 223075 RVA: 0x00F348BD File Offset: 0x00F32ABD
		[Nullable(1)]
		public static DropCatchConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return DropCatchConfig._Instance;
			}
		}

		// Token: 0x06036764 RID: 223076 RVA: 0x00F348C4 File Offset: 0x00F32AC4
		[NullableContext(1)]
		public static DropCatchConfig GetOrCreateInstance()
		{
			if (DropCatchConfig._Instance == null)
			{
				DropCatchConfig.CreateInstance();
			}
			return DropCatchConfig._Instance;
		}

		// Token: 0x06036765 RID: 223077 RVA: 0x00F348D8 File Offset: 0x00F32AD8
		public static bool CreateInstance()
		{
			if (DropCatchConfig._Instance != null)
			{
				return true;
			}
			DropCatchConfig._Instance = new DropCatchConfig();
			return true;
		}

		// Token: 0x06036766 RID: 223078 RVA: 0x00F348EE File Offset: 0x00F32AEE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036767 RID: 223079 RVA: 0x00F348F0 File Offset: 0x00F32AF0
		public static void ResetStaticDefaultValue()
		{
			DropCatchConfig._Instance = null;
		}

		// Token: 0x06036768 RID: 223080 RVA: 0x00F348F8 File Offset: 0x00F32AF8
		static DropCatchConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DropCatchConfig.CreateStaticDefaultValue), new Action(DropCatchConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401CBCC RID: 117708
		private static DropCatchConfig _Instance;
	}
}
