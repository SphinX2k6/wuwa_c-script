using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage
{
	// Token: 0x02006444 RID: 25668
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityMotorLinkageConfig : ConfigBase
	{
		// Token: 0x06040845 RID: 264261 RVA: 0x00F9E0A0 File Offset: 0x00F9C2A0
		public MotorLinkageIp GetIpConfig(int id)
		{
			return ConfigMotorLinkageIpById.GetConfig(id, true).Value;
		}

		// Token: 0x06040846 RID: 264262 RVA: 0x00F9E0BC File Offset: 0x00F9C2BC
		public IReadOnlyList<MotorLinkageIp> GetIpConfigAll()
		{
			return ConfigMotorLinkageIpAll.GetConfigList(true);
		}

		// Token: 0x06040847 RID: 264263 RVA: 0x00F9E0C4 File Offset: 0x00F9C2C4
		public MotorLinkageQuest GetQuestConfig(int id)
		{
			return ConfigMotorLinkageQuestByQuestId.GetConfig(id, true).Value;
		}

		// Token: 0x06040848 RID: 264264 RVA: 0x00F9E0E0 File Offset: 0x00F9C2E0
		public IReadOnlyList<MotorLinkageQuest> GetQuestConfigListByIpId(int ipId)
		{
			return ConfigMotorLinkageQuestByIp.GetConfigList(ipId, true);
		}

		// Token: 0x06040849 RID: 264265 RVA: 0x00F9E0E9 File Offset: 0x00F9C2E9
		public IReadOnlyList<MotorLinkageQuest> GetQuestConfigAll()
		{
			return ConfigMotorLinkageQuestAll.GetConfigList(true);
		}

		// Token: 0x1700947F RID: 38015
		// (get) Token: 0x0604084A RID: 264266 RVA: 0x00F9E0F1 File Offset: 0x00F9C2F1
		[Nullable(1)]
		public static ActivityMotorLinkageConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return ActivityMotorLinkageConfig._Instance;
			}
		}

		// Token: 0x0604084B RID: 264267 RVA: 0x00F9E0F8 File Offset: 0x00F9C2F8
		[NullableContext(1)]
		public static ActivityMotorLinkageConfig GetOrCreateInstance()
		{
			if (ActivityMotorLinkageConfig._Instance == null)
			{
				ActivityMotorLinkageConfig.CreateInstance();
			}
			return ActivityMotorLinkageConfig._Instance;
		}

		// Token: 0x0604084C RID: 264268 RVA: 0x00F9E10C File Offset: 0x00F9C30C
		public static bool CreateInstance()
		{
			if (ActivityMotorLinkageConfig._Instance != null)
			{
				return true;
			}
			ActivityMotorLinkageConfig._Instance = new ActivityMotorLinkageConfig();
			return true;
		}

		// Token: 0x0604084D RID: 264269 RVA: 0x00F9E122 File Offset: 0x00F9C322
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604084E RID: 264270 RVA: 0x00F9E124 File Offset: 0x00F9C324
		public static void ResetStaticDefaultValue()
		{
			ActivityMotorLinkageConfig._Instance = null;
		}

		// Token: 0x0604084F RID: 264271 RVA: 0x00F9E12C File Offset: 0x00F9C32C
		static ActivityMotorLinkageConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMotorLinkageConfig.CreateStaticDefaultValue), new Action(ActivityMotorLinkageConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040218D3 RID: 137427
		private static ActivityMotorLinkageConfig _Instance;
	}
}
