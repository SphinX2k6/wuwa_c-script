using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.RecallQuest
{
	// Token: 0x02003EDB RID: 16091
	[NullableContext(1)]
	[Nullable(0)]
	public class RecallQuestConfig : ConfigBase
	{
		// Token: 0x06028CE6 RID: 167142 RVA: 0x00B72F79 File Offset: 0x00B71179
		public RecallConfig? GetRecallQuestConfig(int id)
		{
			return ConfigRecallConfigByRecallId.GetConfig(id, true);
		}

		// Token: 0x06028CE7 RID: 167143 RVA: 0x00B72F82 File Offset: 0x00B71182
		public RecallFunction? GetRecallFunctionConfig(int id)
		{
			return ConfigRecallFunctionById.GetConfig(id, true);
		}

		// Token: 0x06028CE8 RID: 167144 RVA: 0x00B72F8C File Offset: 0x00B7118C
		public List<int> GetRecallEntityIds(int recallId, int instanceId)
		{
			foreach (RecallEntity recallEntity in ConfigRecallEntityAll.GetConfigList(false))
			{
				if (recallEntity.InstanceId == instanceId)
				{
					return new List<int>(recallEntity.GetEntityIdsArray());
				}
			}
			return new List<int>();
		}

		// Token: 0x170052EE RID: 21230
		// (get) Token: 0x06028CE9 RID: 167145 RVA: 0x00B72FF4 File Offset: 0x00B711F4
		public static RecallQuestConfig Instance
		{
			get
			{
				return RecallQuestConfig._Instance;
			}
		}

		// Token: 0x06028CEA RID: 167146 RVA: 0x00B72FFB File Offset: 0x00B711FB
		public static RecallQuestConfig GetOrCreateInstance()
		{
			if (RecallQuestConfig._Instance == null)
			{
				RecallQuestConfig.CreateInstance();
			}
			return RecallQuestConfig._Instance;
		}

		// Token: 0x06028CEB RID: 167147 RVA: 0x00B7300F File Offset: 0x00B7120F
		public static bool CreateInstance()
		{
			if (RecallQuestConfig._Instance != null)
			{
				return true;
			}
			RecallQuestConfig._Instance = new RecallQuestConfig();
			return true;
		}

		// Token: 0x06028CEC RID: 167148 RVA: 0x00B73025 File Offset: 0x00B71225
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06028CED RID: 167149 RVA: 0x00B73027 File Offset: 0x00B71227
		public static void ResetStaticDefaultValue()
		{
			RecallQuestConfig._Instance = null;
		}

		// Token: 0x06028CEE RID: 167150 RVA: 0x00B7302F File Offset: 0x00B7122F
		static RecallQuestConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RecallQuestConfig.CreateStaticDefaultValue), new Action(RecallQuestConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04016335 RID: 90933
		[Nullable(2)]
		private static RecallQuestConfig _Instance;
	}
}
