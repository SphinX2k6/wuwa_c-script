using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200027F RID: 639
	public class ConfigEntitySkillPreloadByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EFF RID: 3839 RVA: 0x000AE3C0 File Offset: 0x000AC5C0
		static ConfigEntitySkillPreloadByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntitySkillPreloadByAll.CreateStaticDefaultValue), new Action(ConfigEntitySkillPreloadByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x000AE3E0 File Offset: 0x000AC5E0
		public static void CreateStaticDefaultValue()
		{
			ConfigEntitySkillPreloadByAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntitySkillPreloadByAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entity_skill_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/EntitySkillPreload.csv"),
				new ValueTuple<string, object>("表名", "EntitySkillPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `EntitySkillPreload`")
			});
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x000AE45F File Offset: 0x000AC65F
		public static void ResetStaticDefaultValue()
		{
			ConfigEntitySkillPreloadByAll.LogPair = null;
			ConfigEntitySkillPreloadByAll.HandleId = 0;
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x000AE46D File Offset: 0x000AC66D
		public static void Init()
		{
			ConfigEntitySkillPreloadByAll.HandleId = ConfigCommon.InitDataStatement(ConfigEntitySkillPreloadByAll.HandleId, "db_entity_skill_preload.db", "select BinData from `EntitySkillPreload`");
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x000AE488 File Offset: 0x000AC688
		[NullableContext(2)]
		public static IReadOnlyList<EntitySkillPreload> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntitySkillPreloadByAll.HandleId, ConfigEntitySkillPreloadByAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<EntitySkillPreload> readOnlyList = (IReadOnlyList<EntitySkillPreload>)ConfigCommon.GetConfig("EntitySkillPreloadByAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<EntitySkillPreload> list = new List<EntitySkillPreload>();
			while (ConfigCommon.Step(ConfigEntitySkillPreloadByAll.HandleId, false, ConfigEntitySkillPreloadByAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntitySkillPreloadByAll.HandleId, 0, ConfigEntitySkillPreloadByAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEntitySkillPreloadByAll.HandleId, ConfigEntitySkillPreloadByAll.LogPair);
					return null;
				}
				EntitySkillPreload rootAsEntitySkillPreload = EntitySkillPreload.GetRootAsEntitySkillPreload(new ByteBuffer(item2));
				list.Add(rootAsEntitySkillPreload);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("EntitySkillPreloadByAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigEntitySkillPreloadByAll.HandleId, ConfigEntitySkillPreloadByAll.LogPair);
			return list;
		}

		// Token: 0x0400115D RID: 4445
		private const string DB = "db_entity_skill_preload.db";

		// Token: 0x0400115E RID: 4446
		private const string FILE = "Preload/EntitySkillPreload.csv";

		// Token: 0x0400115F RID: 4447
		private const string TABLE = "EntitySkillPreload";

		// Token: 0x04001160 RID: 4448
		private const string COMMAND = "select BinData from `EntitySkillPreload`";

		// Token: 0x04001161 RID: 4449
		private const string KEY_PREFIX = "EntitySkillPreloadByAll";

		// Token: 0x04001162 RID: 4450
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001163 RID: 4451
		private static int HandleId;
	}
}
