using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x02006431 RID: 25649
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MotorDecalLinkConfig : ConfigBase
	{
		// Token: 0x060407D4 RID: 264148 RVA: 0x00F9BC02 File Offset: 0x00F99E02
		public IReadOnlyList<MotorDecalIp> GetIpConfigListByActivityId(int activityId)
		{
			return ConfigMotorDecalIpByActivityId.GetConfigList(activityId, true) ?? new List<MotorDecalIp>();
		}

		// Token: 0x060407D5 RID: 264149 RVA: 0x00F9BC14 File Offset: 0x00F99E14
		public IReadOnlyList<MotorDecalQuest> GetTaskConfigListByIpId(int ipId)
		{
			return ConfigMotorDecalQuestByIp.GetConfigList(ipId, true) ?? new List<MotorDecalQuest>();
		}

		// Token: 0x060407D6 RID: 264150 RVA: 0x00F9BC26 File Offset: 0x00F99E26
		public MotorDecalQuest? GetTaskConfig(int taskId)
		{
			return ConfigMotorDecalQuestByTaskId.GetConfig(taskId, true);
		}

		// Token: 0x060407D7 RID: 264151 RVA: 0x00F9BC2F File Offset: 0x00F99E2F
		public MotorDecalPreview? GetStickerPreviewConfig(int stickerId)
		{
			return ConfigMotorDecalPreviewByStickerId.GetConfig(stickerId, true);
		}

		// Token: 0x1700947C RID: 38012
		// (get) Token: 0x060407D8 RID: 264152 RVA: 0x00F9BC38 File Offset: 0x00F99E38
		public static MotorDecalLinkConfig Instance
		{
			get
			{
				return MotorDecalLinkConfig._Instance;
			}
		}

		// Token: 0x060407D9 RID: 264153 RVA: 0x00F9BC3F File Offset: 0x00F99E3F
		public static MotorDecalLinkConfig GetOrCreateInstance()
		{
			if (MotorDecalLinkConfig._Instance == null)
			{
				MotorDecalLinkConfig.CreateInstance();
			}
			return MotorDecalLinkConfig._Instance;
		}

		// Token: 0x060407DA RID: 264154 RVA: 0x00F9BC53 File Offset: 0x00F99E53
		public static bool CreateInstance()
		{
			if (MotorDecalLinkConfig._Instance != null)
			{
				return true;
			}
			MotorDecalLinkConfig._Instance = new MotorDecalLinkConfig();
			return true;
		}

		// Token: 0x060407DB RID: 264155 RVA: 0x00F9BC69 File Offset: 0x00F99E69
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060407DC RID: 264156 RVA: 0x00F9BC6B File Offset: 0x00F99E6B
		public static void ResetStaticDefaultValue()
		{
			MotorDecalLinkConfig._Instance = null;
		}

		// Token: 0x060407DD RID: 264157 RVA: 0x00F9BC73 File Offset: 0x00F99E73
		static MotorDecalLinkConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorDecalLinkConfig.CreateStaticDefaultValue), new Action(MotorDecalLinkConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04021869 RID: 137321
		[Nullable(2)]
		private static MotorDecalLinkConfig _Instance;
	}
}
