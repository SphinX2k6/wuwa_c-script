using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A03 RID: 2563
	public class ConfigSolarSchoolQuestNodeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C26 RID: 15398 RVA: 0x001B0CC4 File Offset: 0x001AEEC4
		static ConfigSolarSchoolQuestNodeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolQuestNodeAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolQuestNodeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x001B0CE4 File Offset: 0x001AEEE4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolQuestNodeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolQuestNodeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_任务.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolQuestNode"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolQuestNode`")
			});
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x001B0D63 File Offset: 0x001AEF63
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolQuestNodeAll.LogPair = null;
			ConfigSolarSchoolQuestNodeAll.HandleId = 0;
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x001B0D71 File Offset: 0x001AEF71
		public static void Init()
		{
			ConfigSolarSchoolQuestNodeAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolQuestNodeAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolQuestNode`");
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x001B0D8C File Offset: 0x001AEF8C
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolQuestNode> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolQuestNodeAll.HandleId, ConfigSolarSchoolQuestNodeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolQuestNode> readOnlyList = (IReadOnlyList<SolarSchoolQuestNode>)ConfigCommon.GetConfig("SolarSchoolQuestNodeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolQuestNode> list = new List<SolarSchoolQuestNode>();
			while (ConfigCommon.Step(ConfigSolarSchoolQuestNodeAll.HandleId, false, ConfigSolarSchoolQuestNodeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolQuestNodeAll.HandleId, 0, ConfigSolarSchoolQuestNodeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolQuestNodeAll.HandleId, ConfigSolarSchoolQuestNodeAll.LogPair);
					return null;
				}
				SolarSchoolQuestNode rootAsSolarSchoolQuestNode = SolarSchoolQuestNode.GetRootAsSolarSchoolQuestNode(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolQuestNode);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolQuestNodeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolQuestNodeAll.HandleId, ConfigSolarSchoolQuestNodeAll.LogPair);
			return list;
		}

		// Token: 0x040045FB RID: 17915
		private const string DB = "db_solarschool.db";

		// Token: 0x040045FC RID: 17916
		private const string FILE = "d.第二索拉_任务.xlsx";

		// Token: 0x040045FD RID: 17917
		private const string TABLE = "SolarSchoolQuestNode";

		// Token: 0x040045FE RID: 17918
		private const string COMMAND = "select BinData from `SolarSchoolQuestNode`";

		// Token: 0x040045FF RID: 17919
		private const string KEY_PREFIX = "SolarSchoolQuestNodeAll";

		// Token: 0x04004600 RID: 17920
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004601 RID: 17921
		private static int HandleId;
	}
}
