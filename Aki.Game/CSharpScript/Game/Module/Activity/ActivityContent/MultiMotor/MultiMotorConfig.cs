using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x0200530C RID: 21260
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MultiMotorConfig : ConfigBase
	{
		// Token: 0x06034E39 RID: 216633 RVA: 0x00EC9F62 File Offset: 0x00EC8162
		[NullableContext(2)]
		public IReadOnlyList<OnlineMotorLevel> GetAllMotorMultiParkourLevel()
		{
			return ConfigOnlineMotorLevelAll.GetConfigList(true);
		}

		// Token: 0x06034E3A RID: 216634 RVA: 0x00EC9F6A File Offset: 0x00EC816A
		public OnlineMotorLevel? GetMotorMultiParkourLevelById(int levelId)
		{
			return ConfigOnlineMotorLevelById.GetConfig(levelId, true);
		}

		// Token: 0x06034E3B RID: 216635 RVA: 0x00EC9F73 File Offset: 0x00EC8173
		public OnlineMotorLevel? GetMotorMultiParkourLevelByInstId(int instId)
		{
			return ConfigOnlineMotorLevelByInstId.GetConfig(instId, true);
		}

		// Token: 0x06034E3C RID: 216636 RVA: 0x00EC9F7C File Offset: 0x00EC817C
		public OnlineMotorLevelTask? GetMotorLevelTaskByTaskId(int taskId)
		{
			return ConfigOnlineMotorLevelTaskById.GetConfig(taskId, true);
		}

		// Token: 0x06034E3D RID: 216637 RVA: 0x00EC9F85 File Offset: 0x00EC8185
		public OnlineMotorGlobalTask? GetMotorGlobalTaskByTaskId(int taskId)
		{
			return ConfigOnlineMotorGlobalTaskById.GetConfig(taskId, true);
		}

		// Token: 0x06034E3E RID: 216638 RVA: 0x00EC9F8E File Offset: 0x00EC818E
		public OnlineMotorBroadcast? GetMotorBroadcastById(int id)
		{
			return ConfigOnlineMotorBroadcastById.GetConfig(id, true);
		}

		// Token: 0x06034E3F RID: 216639 RVA: 0x00EC9F97 File Offset: 0x00EC8197
		[NullableContext(2)]
		public IReadOnlyList<OnlineMotorBroadcast> GetMotorBroadcastByGroup(int group)
		{
			return ConfigOnlineMotorBroadcastByBroadcastGroup.GetConfigList(group, true);
		}

		// Token: 0x06034E40 RID: 216640 RVA: 0x00EC9FA0 File Offset: 0x00EC81A0
		public MotorOnlineBuff? GetMotorBuffById(int id)
		{
			return ConfigMotorOnlineBuffById.GetConfig(id, true);
		}

		// Token: 0x06034E41 RID: 216641 RVA: 0x00EC9FA9 File Offset: 0x00EC81A9
		public MotorOnlineRoleSkin? GetMotorOnlineRoleSkinBySkinId(int skinId)
		{
			return ConfigMotorOnlineRoleSkinByRoleSkinId.GetConfig(skinId, true);
		}

		// Token: 0x06034E42 RID: 216642 RVA: 0x00EC9FB4 File Offset: 0x00EC81B4
		public int GetHostExitProtectTime()
		{
			return ConfigCommonParamById.GetIntConfig("MultiMotorHostExitProtectTime").GetValueOrDefault(300);
		}

		// Token: 0x170066B5 RID: 26293
		// (get) Token: 0x06034E43 RID: 216643 RVA: 0x00EC9FD8 File Offset: 0x00EC81D8
		public static MultiMotorConfig Instance
		{
			get
			{
				return MultiMotorConfig._Instance;
			}
		}

		// Token: 0x06034E44 RID: 216644 RVA: 0x00EC9FDF File Offset: 0x00EC81DF
		public static MultiMotorConfig GetOrCreateInstance()
		{
			if (MultiMotorConfig._Instance == null)
			{
				MultiMotorConfig.CreateInstance();
			}
			return MultiMotorConfig._Instance;
		}

		// Token: 0x06034E45 RID: 216645 RVA: 0x00EC9FF3 File Offset: 0x00EC81F3
		public static bool CreateInstance()
		{
			if (MultiMotorConfig._Instance != null)
			{
				return true;
			}
			MultiMotorConfig._Instance = new MultiMotorConfig();
			return true;
		}

		// Token: 0x06034E46 RID: 216646 RVA: 0x00ECA009 File Offset: 0x00EC8209
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034E47 RID: 216647 RVA: 0x00ECA00B File Offset: 0x00EC820B
		public static void ResetStaticDefaultValue()
		{
			MultiMotorConfig._Instance = null;
		}

		// Token: 0x06034E48 RID: 216648 RVA: 0x00ECA013 File Offset: 0x00EC8213
		static MultiMotorConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MultiMotorConfig.CreateStaticDefaultValue), new Action(MultiMotorConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401BF80 RID: 114560
		private const int DefaultExitHandleTime = 300;

		// Token: 0x0401BF81 RID: 114561
		[Nullable(2)]
		private static MultiMotorConfig _Instance;
	}
}
