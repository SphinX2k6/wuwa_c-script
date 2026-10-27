using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02006681 RID: 26241
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class DropCatchConfig : ConfigBase
	{
		// Token: 0x06041C0C RID: 269324 RVA: 0x00FF33E3 File Offset: 0x00FF15E3
		public IReadOnlyList<DropCatchGameplay> GetDropCatchGameplayByActivityId(int activityId)
		{
			return ConfigDropCatchGameplayByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x06041C0D RID: 269325 RVA: 0x00FF33EC File Offset: 0x00FF15EC
		public IReadOnlyList<DropCatchRole> GetAllDropCatchRole()
		{
			return ConfigDropCatchRoleAll.GetConfigList(true);
		}

		// Token: 0x06041C0E RID: 269326 RVA: 0x00FF33F4 File Offset: 0x00FF15F4
		public DropCatchGameplay? GetDropCatchGameplayById(int id)
		{
			return ConfigDropCatchGameplayById.GetConfig(id, true);
		}

		// Token: 0x06041C0F RID: 269327 RVA: 0x00FF33FD File Offset: 0x00FF15FD
		public DropCatchRole? GetDropCatchRoleById(int id)
		{
			return ConfigDropCatchRoleById.GetConfig(id, true);
		}

		// Token: 0x06041C10 RID: 269328 RVA: 0x00FF3406 File Offset: 0x00FF1606
		public DropCatchDropItem? GetDropCatchDropItemById(int id)
		{
			return ConfigDropCatchDropItemById.GetConfig(id, true);
		}

		// Token: 0x06041C11 RID: 269329 RVA: 0x00FF340F File Offset: 0x00FF160F
		public IReadOnlyList<DropCatchDropItem> GetAllDropItemConfig()
		{
			return ConfigDropCatchDropItemAll.GetConfigList(true);
		}

		// Token: 0x06041C12 RID: 269330 RVA: 0x00FF3417 File Offset: 0x00FF1617
		public DropCatchDropPool? GetDropCatchDropPoolById(int id)
		{
			return ConfigDropCatchDropPoolById.GetConfig(id, true);
		}

		// Token: 0x06041C13 RID: 269331 RVA: 0x00FF3420 File Offset: 0x00FF1620
		public DropCatchReward? GetDropCatchRewardById(int id)
		{
			return ConfigDropCatchRewardById.GetConfig(id, true);
		}

		// Token: 0x06041C14 RID: 269332 RVA: 0x00FF342C File Offset: 0x00FF162C
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

		// Token: 0x06041C15 RID: 269333 RVA: 0x00FF34A4 File Offset: 0x00FF16A4
		public IReadOnlyList<DropCatchRoleBook> GetDropCatchRoleBookAll()
		{
			return ConfigDropCatchRoleBookAll.GetConfigList(true);
		}

		// Token: 0x06041C16 RID: 269334 RVA: 0x00FF34AC File Offset: 0x00FF16AC
		public DropCatchRoleBook? GetDropCatchRoleBookById(int id)
		{
			return ConfigDropCatchRoleBookById.GetConfig(id, true);
		}

		// Token: 0x17009641 RID: 38465
		// (get) Token: 0x06041C17 RID: 269335 RVA: 0x00FF34B5 File Offset: 0x00FF16B5
		[Nullable(1)]
		public static DropCatchConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return DropCatchConfig._Instance;
			}
		}

		// Token: 0x06041C18 RID: 269336 RVA: 0x00FF34BC File Offset: 0x00FF16BC
		[NullableContext(1)]
		public static DropCatchConfig GetOrCreateInstance()
		{
			if (DropCatchConfig._Instance == null)
			{
				DropCatchConfig.CreateInstance();
			}
			return DropCatchConfig._Instance;
		}

		// Token: 0x06041C19 RID: 269337 RVA: 0x00FF34D0 File Offset: 0x00FF16D0
		public static bool CreateInstance()
		{
			if (DropCatchConfig._Instance != null)
			{
				return true;
			}
			DropCatchConfig._Instance = new DropCatchConfig();
			return true;
		}

		// Token: 0x06041C1A RID: 269338 RVA: 0x00FF34E6 File Offset: 0x00FF16E6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06041C1B RID: 269339 RVA: 0x00FF34E8 File Offset: 0x00FF16E8
		public static void ResetStaticDefaultValue()
		{
			DropCatchConfig._Instance = null;
		}

		// Token: 0x06041C1C RID: 269340 RVA: 0x00FF34F0 File Offset: 0x00FF16F0
		static DropCatchConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DropCatchConfig.CreateStaticDefaultValue), new Action(DropCatchConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04022373 RID: 140147
		private static DropCatchConfig _Instance;
	}
}
