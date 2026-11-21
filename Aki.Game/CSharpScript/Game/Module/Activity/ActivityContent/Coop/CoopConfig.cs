using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x0200581B RID: 22555
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class CoopConfig : ConfigBase
	{
		// Token: 0x06037A9F RID: 227999 RVA: 0x00F8FBA6 File Offset: 0x00F8DDA6
		public CoopRoleLevel? GetCoopConfigById(int id)
		{
			return ConfigCoopRoleLevelByID.GetConfig(id, true);
		}

		// Token: 0x06037AA0 RID: 228000 RVA: 0x00F8FBAF File Offset: 0x00F8DDAF
		[NullableContext(2)]
		public IReadOnlyList<CoopRoleLevel> GetCoopConfigAllLevel(int activityId, int roleId)
		{
			return ConfigCoopRoleLevelAllLevelData.GetConfigList(activityId, roleId, true);
		}

		// Token: 0x06037AA1 RID: 228001 RVA: 0x00F8FBB9 File Offset: 0x00F8DDB9
		public CoopRole? GetCoopRoleConfigByRoleId(int roleId)
		{
			return ConfigCoopRoleByRoleId.GetConfig(roleId, true);
		}

		// Token: 0x06037AA2 RID: 228002 RVA: 0x00F8FBC2 File Offset: 0x00F8DDC2
		public CoopSpReward? GetCoopSpRewardConfigById(int id)
		{
			return ConfigCoopSpRewardById.GetConfig(id, true);
		}

		// Token: 0x06037AA3 RID: 228003 RVA: 0x00F8FBCB File Offset: 0x00F8DDCB
		[NullableContext(2)]
		public IReadOnlyList<CoopSpReward> GetCoopSpRewardConfigByActivityId(int activityId)
		{
			return ConfigCoopSpRewardListByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x06037AA4 RID: 228004 RVA: 0x00F8FBD4 File Offset: 0x00F8DDD4
		public CoopTaskConfig? GetCoopTaskConfigById(int id)
		{
			return ConfigCoopTaskConfigByID.GetConfig(id, true);
		}

		// Token: 0x17006B15 RID: 27413
		// (get) Token: 0x06037AA5 RID: 228005 RVA: 0x00F8FBDD File Offset: 0x00F8DDDD
		public static CoopConfig Instance
		{
			get
			{
				return CoopConfig._Instance;
			}
		}

		// Token: 0x06037AA6 RID: 228006 RVA: 0x00F8FBE4 File Offset: 0x00F8DDE4
		public static CoopConfig GetOrCreateInstance()
		{
			if (CoopConfig._Instance == null)
			{
				CoopConfig.CreateInstance();
			}
			return CoopConfig._Instance;
		}

		// Token: 0x06037AA7 RID: 228007 RVA: 0x00F8FBF8 File Offset: 0x00F8DDF8
		public static bool CreateInstance()
		{
			if (CoopConfig._Instance != null)
			{
				return true;
			}
			CoopConfig._Instance = new CoopConfig();
			return true;
		}

		// Token: 0x06037AA8 RID: 228008 RVA: 0x00F8FC0E File Offset: 0x00F8DE0E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037AA9 RID: 228009 RVA: 0x00F8FC10 File Offset: 0x00F8DE10
		public static void ResetStaticDefaultValue()
		{
			CoopConfig._Instance = null;
		}

		// Token: 0x06037AAA RID: 228010 RVA: 0x00F8FC18 File Offset: 0x00F8DE18
		static CoopConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CoopConfig.CreateStaticDefaultValue), new Action(CoopConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401D598 RID: 120216
		[Nullable(2)]
		private static CoopConfig _Instance;
	}
}
