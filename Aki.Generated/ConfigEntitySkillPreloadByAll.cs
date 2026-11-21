using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000293 RID: 659
	public class ConfigEntitySkillPreloadByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F77 RID: 3959 RVA: 0x000B4684 File Offset: 0x000B2884
		static ConfigEntitySkillPreloadByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntitySkillPreloadByAll.CreateStaticDefaultValue), new Action(ConfigEntitySkillPreloadByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x000B46A4 File Offset: 0x000B28A4
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

		// Token: 0x06000F79 RID: 3961 RVA: 0x000B4723 File Offset: 0x000B2923
		public static void ResetStaticDefaultValue()
		{
			ConfigEntitySkillPreloadByAll.LogPair = null;
			ConfigEntitySkillPreloadByAll.HandleId = 0;
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x000B4731 File Offset: 0x000B2931
		public static void Init()
		{
			ConfigEntitySkillPreloadByAll.HandleId = ConfigCommon.InitDataStatement(ConfigEntitySkillPreloadByAll.HandleId, "db_entity_skill_preload.db", "select BinData from `EntitySkillPreload`");
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x000B474C File Offset: 0x000B294C
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

		// Token: 0x040011E9 RID: 4585
		private const string DB = "db_entity_skill_preload.db";

		// Token: 0x040011EA RID: 4586
		private const string FILE = "Preload/EntitySkillPreload.csv";

		// Token: 0x040011EB RID: 4587
		private const string TABLE = "EntitySkillPreload";

		// Token: 0x040011EC RID: 4588
		private const string COMMAND = "select BinData from `EntitySkillPreload`";

		// Token: 0x040011ED RID: 4589
		private const string KEY_PREFIX = "EntitySkillPreloadByAll";

		// Token: 0x040011EE RID: 4590
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011EF RID: 4591
		private static int HandleId;
	}
}
