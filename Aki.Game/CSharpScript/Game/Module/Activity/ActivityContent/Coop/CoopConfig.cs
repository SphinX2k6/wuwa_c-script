using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068CB RID: 26827
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class CoopConfig : ConfigBase
	{
		// Token: 0x06042F47 RID: 274247 RVA: 0x0104E57E File Offset: 0x0104C77E
		public CoopRoleLevel? GetCoopConfigById(int id)
		{
			return ConfigCoopRoleLevelByID.GetConfig(id, true);
		}

		// Token: 0x06042F48 RID: 274248 RVA: 0x0104E587 File Offset: 0x0104C787
		[NullableContext(2)]
		public IReadOnlyList<CoopRoleLevel> GetCoopConfigAllLevel(int activityId, int roleId)
		{
			return ConfigCoopRoleLevelAllLevelData.GetConfigList(activityId, roleId, true);
		}

		// Token: 0x06042F49 RID: 274249 RVA: 0x0104E591 File Offset: 0x0104C791
		public CoopRole? GetCoopRoleConfigByRoleId(int roleId)
		{
			return ConfigCoopRoleByRoleId.GetConfig(roleId, true);
		}

		// Token: 0x06042F4A RID: 274250 RVA: 0x0104E59A File Offset: 0x0104C79A
		public CoopSpReward? GetCoopSpRewardConfigById(int id)
		{
			return ConfigCoopSpRewardById.GetConfig(id, true);
		}

		// Token: 0x06042F4B RID: 274251 RVA: 0x0104E5A3 File Offset: 0x0104C7A3
		[NullableContext(2)]
		public IReadOnlyList<CoopSpReward> GetCoopSpRewardConfigByActivityId(int activityId)
		{
			return ConfigCoopSpRewardListByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x06042F4C RID: 274252 RVA: 0x0104E5AC File Offset: 0x0104C7AC
		public CoopTaskConfig? GetCoopTaskConfigById(int id)
		{
			return ConfigCoopTaskConfigByID.GetConfig(id, true);
		}

		// Token: 0x170097D5 RID: 38869
		// (get) Token: 0x06042F4D RID: 274253 RVA: 0x0104E5B5 File Offset: 0x0104C7B5
		public static CoopConfig Instance
		{
			get
			{
				return CoopConfig._Instance;
			}
		}

		// Token: 0x06042F4E RID: 274254 RVA: 0x0104E5BC File Offset: 0x0104C7BC
		public static CoopConfig GetOrCreateInstance()
		{
			if (CoopConfig._Instance == null)
			{
				CoopConfig.CreateInstance();
			}
			return CoopConfig._Instance;
		}

		// Token: 0x06042F4F RID: 274255 RVA: 0x0104E5D0 File Offset: 0x0104C7D0
		public static bool CreateInstance()
		{
			if (CoopConfig._Instance != null)
			{
				return true;
			}
			CoopConfig._Instance = new CoopConfig();
			return true;
		}

		// Token: 0x06042F50 RID: 274256 RVA: 0x0104E5E6 File Offset: 0x0104C7E6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06042F51 RID: 274257 RVA: 0x0104E5E8 File Offset: 0x0104C7E8
		public static void ResetStaticDefaultValue()
		{
			CoopConfig._Instance = null;
		}

		// Token: 0x06042F52 RID: 274258 RVA: 0x0104E5F0 File Offset: 0x0104C7F0
		static CoopConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CoopConfig.CreateStaticDefaultValue), new Action(CoopConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04022D3C RID: 142652
		[Nullable(2)]
		private static CoopConfig _Instance;
	}
}
