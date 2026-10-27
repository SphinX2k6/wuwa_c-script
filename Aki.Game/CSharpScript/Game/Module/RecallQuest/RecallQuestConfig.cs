using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.RecallQuest
{
	// Token: 0x02004F12 RID: 20242
	[NullableContext(1)]
	[Nullable(0)]
	public class RecallQuestConfig : ConfigBase
	{
		// Token: 0x06033E7B RID: 212603 RVA: 0x00C29989 File Offset: 0x00C27B89
		public RecallConfig? GetRecallQuestConfig(int id)
		{
			return ConfigRecallConfigByRecallId.GetConfig(id, true);
		}

		// Token: 0x06033E7C RID: 212604 RVA: 0x00C29992 File Offset: 0x00C27B92
		public RecallFunction? GetRecallFunctionConfig(int id)
		{
			return ConfigRecallFunctionById.GetConfig(id, true);
		}

		// Token: 0x06033E7D RID: 212605 RVA: 0x00C2999C File Offset: 0x00C27B9C
		public List<int> GetRecallEntityIds(int recallId, int instanceId)
		{
			foreach (RecallEntity recallEntity in ConfigRecallEntityAll.GetConfigList(false))
			{
				if (recallEntity.InstanceId == instanceId)
				{
					return recallEntity.GetEntityIdsArray().ToList<int>();
				}
			}
			return new List<int>();
		}

		// Token: 0x17007F3E RID: 32574
		// (get) Token: 0x06033E7E RID: 212606 RVA: 0x00C29A04 File Offset: 0x00C27C04
		public static RecallQuestConfig Instance
		{
			get
			{
				return RecallQuestConfig._Instance;
			}
		}

		// Token: 0x06033E7F RID: 212607 RVA: 0x00C29A0B File Offset: 0x00C27C0B
		public static RecallQuestConfig GetOrCreateInstance()
		{
			if (RecallQuestConfig._Instance == null)
			{
				RecallQuestConfig.CreateInstance();
			}
			return RecallQuestConfig._Instance;
		}

		// Token: 0x06033E80 RID: 212608 RVA: 0x00C29A1F File Offset: 0x00C27C1F
		public static bool CreateInstance()
		{
			if (RecallQuestConfig._Instance != null)
			{
				return true;
			}
			RecallQuestConfig._Instance = new RecallQuestConfig();
			return true;
		}

		// Token: 0x06033E81 RID: 212609 RVA: 0x00C29A35 File Offset: 0x00C27C35
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033E82 RID: 212610 RVA: 0x00C29A37 File Offset: 0x00C27C37
		public static void ResetStaticDefaultValue()
		{
			RecallQuestConfig._Instance = null;
		}

		// Token: 0x06033E83 RID: 212611 RVA: 0x00C29A3F File Offset: 0x00C27C3F
		static RecallQuestConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RecallQuestConfig.CreateStaticDefaultValue), new Action(RecallQuestConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401B962 RID: 112994
		[Nullable(2)]
		private static RecallQuestConfig _Instance;
	}
}
