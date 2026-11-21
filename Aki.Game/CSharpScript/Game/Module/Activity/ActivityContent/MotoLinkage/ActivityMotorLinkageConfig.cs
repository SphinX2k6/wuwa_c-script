using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage
{
	// Token: 0x020053C2 RID: 21442
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityMotorLinkageConfig : ConfigBase
	{
		// Token: 0x06035506 RID: 218374 RVA: 0x00EE501C File Offset: 0x00EE321C
		public MotorLinkageIp GetIpConfig(int id)
		{
			return ConfigMotorLinkageIpById.GetConfig(id, true).Value;
		}

		// Token: 0x06035507 RID: 218375 RVA: 0x00EE5038 File Offset: 0x00EE3238
		public IReadOnlyList<MotorLinkageIp> GetIpConfigAll()
		{
			return ConfigMotorLinkageIpAll.GetConfigList(true);
		}

		// Token: 0x06035508 RID: 218376 RVA: 0x00EE5040 File Offset: 0x00EE3240
		public MotorLinkageQuest GetQuestConfig(int id)
		{
			return ConfigMotorLinkageQuestByQuestId.GetConfig(id, true).Value;
		}

		// Token: 0x06035509 RID: 218377 RVA: 0x00EE505C File Offset: 0x00EE325C
		public IReadOnlyList<MotorLinkageQuest> GetQuestConfigListByIpId(int ipId)
		{
			return ConfigMotorLinkageQuestByIp.GetConfigList(ipId, true);
		}

		// Token: 0x0603550A RID: 218378 RVA: 0x00EE5065 File Offset: 0x00EE3265
		public IReadOnlyList<MotorLinkageQuest> GetQuestConfigAll()
		{
			return ConfigMotorLinkageQuestAll.GetConfigList(true);
		}

		// Token: 0x170067E1 RID: 26593
		// (get) Token: 0x0603550B RID: 218379 RVA: 0x00EE506D File Offset: 0x00EE326D
		[Nullable(1)]
		public static ActivityMotorLinkageConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return ActivityMotorLinkageConfig._Instance;
			}
		}

		// Token: 0x0603550C RID: 218380 RVA: 0x00EE5074 File Offset: 0x00EE3274
		[NullableContext(1)]
		public static ActivityMotorLinkageConfig GetOrCreateInstance()
		{
			if (ActivityMotorLinkageConfig._Instance == null)
			{
				ActivityMotorLinkageConfig.CreateInstance();
			}
			return ActivityMotorLinkageConfig._Instance;
		}

		// Token: 0x0603550D RID: 218381 RVA: 0x00EE5088 File Offset: 0x00EE3288
		public static bool CreateInstance()
		{
			if (ActivityMotorLinkageConfig._Instance != null)
			{
				return true;
			}
			ActivityMotorLinkageConfig._Instance = new ActivityMotorLinkageConfig();
			return true;
		}

		// Token: 0x0603550E RID: 218382 RVA: 0x00EE509E File Offset: 0x00EE329E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603550F RID: 218383 RVA: 0x00EE50A0 File Offset: 0x00EE32A0
		public static void ResetStaticDefaultValue()
		{
			ActivityMotorLinkageConfig._Instance = null;
		}

		// Token: 0x06035510 RID: 218384 RVA: 0x00EE50A8 File Offset: 0x00EE32A8
		static ActivityMotorLinkageConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMotorLinkageConfig.CreateStaticDefaultValue), new Action(ActivityMotorLinkageConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401C202 RID: 115202
		private static ActivityMotorLinkageConfig _Instance;
	}
}
