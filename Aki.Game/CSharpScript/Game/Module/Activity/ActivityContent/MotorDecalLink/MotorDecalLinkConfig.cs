using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x020053AF RID: 21423
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MotorDecalLinkConfig : ConfigBase
	{
		// Token: 0x06035495 RID: 218261 RVA: 0x00EE2B7E File Offset: 0x00EE0D7E
		public IReadOnlyList<MotorDecalIp> GetIpConfigListByActivityId(int activityId)
		{
			return ConfigMotorDecalIpByActivityId.GetConfigList(activityId, true) ?? new List<MotorDecalIp>();
		}

		// Token: 0x06035496 RID: 218262 RVA: 0x00EE2B90 File Offset: 0x00EE0D90
		public IReadOnlyList<MotorDecalQuest> GetTaskConfigListByIpId(int ipId)
		{
			return ConfigMotorDecalQuestByIp.GetConfigList(ipId, true) ?? new List<MotorDecalQuest>();
		}

		// Token: 0x06035497 RID: 218263 RVA: 0x00EE2BA2 File Offset: 0x00EE0DA2
		public MotorDecalQuest? GetTaskConfig(int taskId)
		{
			return ConfigMotorDecalQuestByTaskId.GetConfig(taskId, true);
		}

		// Token: 0x06035498 RID: 218264 RVA: 0x00EE2BAB File Offset: 0x00EE0DAB
		public MotorDecalPreview? GetStickerPreviewConfig(int stickerId)
		{
			return ConfigMotorDecalPreviewByStickerId.GetConfig(stickerId, true);
		}

		// Token: 0x170067DE RID: 26590
		// (get) Token: 0x06035499 RID: 218265 RVA: 0x00EE2BB4 File Offset: 0x00EE0DB4
		public static MotorDecalLinkConfig Instance
		{
			get
			{
				return MotorDecalLinkConfig._Instance;
			}
		}

		// Token: 0x0603549A RID: 218266 RVA: 0x00EE2BBB File Offset: 0x00EE0DBB
		public static MotorDecalLinkConfig GetOrCreateInstance()
		{
			if (MotorDecalLinkConfig._Instance == null)
			{
				MotorDecalLinkConfig.CreateInstance();
			}
			return MotorDecalLinkConfig._Instance;
		}

		// Token: 0x0603549B RID: 218267 RVA: 0x00EE2BCF File Offset: 0x00EE0DCF
		public static bool CreateInstance()
		{
			if (MotorDecalLinkConfig._Instance != null)
			{
				return true;
			}
			MotorDecalLinkConfig._Instance = new MotorDecalLinkConfig();
			return true;
		}

		// Token: 0x0603549C RID: 218268 RVA: 0x00EE2BE5 File Offset: 0x00EE0DE5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603549D RID: 218269 RVA: 0x00EE2BE7 File Offset: 0x00EE0DE7
		public static void ResetStaticDefaultValue()
		{
			MotorDecalLinkConfig._Instance = null;
		}

		// Token: 0x0603549E RID: 218270 RVA: 0x00EE2BEF File Offset: 0x00EE0DEF
		static MotorDecalLinkConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorDecalLinkConfig.CreateStaticDefaultValue), new Action(MotorDecalLinkConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401C198 RID: 115096
		[Nullable(2)]
		private static MotorDecalLinkConfig _Instance;
	}
}
