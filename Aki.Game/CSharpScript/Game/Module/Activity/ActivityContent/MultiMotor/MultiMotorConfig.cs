using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x0200638E RID: 25486
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MultiMotorConfig : ConfigBase
	{
		// Token: 0x06040178 RID: 262520 RVA: 0x00F82FEE File Offset: 0x00F811EE
		[NullableContext(2)]
		public IReadOnlyList<OnlineMotorLevel> GetAllMotorMultiParkourLevel()
		{
			return ConfigOnlineMotorLevelAll.GetConfigList(true);
		}

		// Token: 0x06040179 RID: 262521 RVA: 0x00F82FF6 File Offset: 0x00F811F6
		public OnlineMotorLevel? GetMotorMultiParkourLevelById(int levelId)
		{
			return ConfigOnlineMotorLevelById.GetConfig(levelId, true);
		}

		// Token: 0x0604017A RID: 262522 RVA: 0x00F82FFF File Offset: 0x00F811FF
		public OnlineMotorLevel? GetMotorMultiParkourLevelByInstId(int instId)
		{
			return ConfigOnlineMotorLevelByInstId.GetConfig(instId, true);
		}

		// Token: 0x0604017B RID: 262523 RVA: 0x00F83008 File Offset: 0x00F81208
		public OnlineMotorLevelTask? GetMotorLevelTaskByTaskId(int taskId)
		{
			return ConfigOnlineMotorLevelTaskById.GetConfig(taskId, true);
		}

		// Token: 0x0604017C RID: 262524 RVA: 0x00F83011 File Offset: 0x00F81211
		public OnlineMotorGlobalTask? GetMotorGlobalTaskByTaskId(int taskId)
		{
			return ConfigOnlineMotorGlobalTaskById.GetConfig(taskId, true);
		}

		// Token: 0x0604017D RID: 262525 RVA: 0x00F8301A File Offset: 0x00F8121A
		public OnlineMotorBroadcast? GetMotorBroadcastById(int id)
		{
			return ConfigOnlineMotorBroadcastById.GetConfig(id, true);
		}

		// Token: 0x0604017E RID: 262526 RVA: 0x00F83023 File Offset: 0x00F81223
		[NullableContext(2)]
		public IReadOnlyList<OnlineMotorBroadcast> GetMotorBroadcastByGroup(int group)
		{
			return ConfigOnlineMotorBroadcastByBroadcastGroup.GetConfigList(group, true);
		}

		// Token: 0x0604017F RID: 262527 RVA: 0x00F8302C File Offset: 0x00F8122C
		public MotorOnlineBuff? GetMotorBuffById(int id)
		{
			return ConfigMotorOnlineBuffById.GetConfig(id, true);
		}

		// Token: 0x06040180 RID: 262528 RVA: 0x00F83035 File Offset: 0x00F81235
		public MotorOnlineRoleSkin? GetMotorOnlineRoleSkinBySkinId(int skinId)
		{
			return ConfigMotorOnlineRoleSkinByRoleSkinId.GetConfig(skinId, true);
		}

		// Token: 0x06040181 RID: 262529 RVA: 0x00F83040 File Offset: 0x00F81240
		public int GetHostExitProtectTime()
		{
			return ConfigCommonParamById.GetIntConfig("MultiMotorHostExitProtectTime").GetValueOrDefault(300);
		}

		// Token: 0x17009353 RID: 37715
		// (get) Token: 0x06040182 RID: 262530 RVA: 0x00F83064 File Offset: 0x00F81264
		public static MultiMotorConfig Instance
		{
			get
			{
				return MultiMotorConfig._Instance;
			}
		}

		// Token: 0x06040183 RID: 262531 RVA: 0x00F8306B File Offset: 0x00F8126B
		public static MultiMotorConfig GetOrCreateInstance()
		{
			if (MultiMotorConfig._Instance == null)
			{
				MultiMotorConfig.CreateInstance();
			}
			return MultiMotorConfig._Instance;
		}

		// Token: 0x06040184 RID: 262532 RVA: 0x00F8307F File Offset: 0x00F8127F
		public static bool CreateInstance()
		{
			if (MultiMotorConfig._Instance != null)
			{
				return true;
			}
			MultiMotorConfig._Instance = new MultiMotorConfig();
			return true;
		}

		// Token: 0x06040185 RID: 262533 RVA: 0x00F83095 File Offset: 0x00F81295
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06040186 RID: 262534 RVA: 0x00F83097 File Offset: 0x00F81297
		public static void ResetStaticDefaultValue()
		{
			MultiMotorConfig._Instance = null;
		}

		// Token: 0x06040187 RID: 262535 RVA: 0x00F8309F File Offset: 0x00F8129F
		static MultiMotorConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MultiMotorConfig.CreateStaticDefaultValue), new Action(MultiMotorConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04021651 RID: 136785
		private const int DefaultExitHandleTime = 300;

		// Token: 0x04021652 RID: 136786
		[Nullable(2)]
		private static MultiMotorConfig _Instance;
	}
}
