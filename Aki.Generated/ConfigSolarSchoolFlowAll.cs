using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009DD RID: 2525
	public class ConfigSolarSchoolFlowAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B42 RID: 15170 RVA: 0x001ABC0C File Offset: 0x001A9E0C
		static ConfigSolarSchoolFlowAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolFlowAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolFlowAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x001ABC2C File Offset: 0x001A9E2C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolFlowAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolFlowAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_剧情.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolFlow"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolFlow`")
			});
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x001ABCAB File Offset: 0x001A9EAB
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolFlowAll.LogPair = null;
			ConfigSolarSchoolFlowAll.HandleId = 0;
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x001ABCB9 File Offset: 0x001A9EB9
		public static void Init()
		{
			ConfigSolarSchoolFlowAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolFlowAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolFlow`");
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x001ABCD4 File Offset: 0x001A9ED4
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolFlow> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolFlowAll.HandleId, ConfigSolarSchoolFlowAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolFlow> readOnlyList = (IReadOnlyList<SolarSchoolFlow>)ConfigCommon.GetConfig("SolarSchoolFlowAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolFlow> list = new List<SolarSchoolFlow>();
			while (ConfigCommon.Step(ConfigSolarSchoolFlowAll.HandleId, false, ConfigSolarSchoolFlowAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolFlowAll.HandleId, 0, ConfigSolarSchoolFlowAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolFlowAll.HandleId, ConfigSolarSchoolFlowAll.LogPair);
					return null;
				}
				SolarSchoolFlow rootAsSolarSchoolFlow = SolarSchoolFlow.GetRootAsSolarSchoolFlow(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolFlow);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolFlowAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolFlowAll.HandleId, ConfigSolarSchoolFlowAll.LogPair);
			return list;
		}

		// Token: 0x040044F1 RID: 17649
		private const string DB = "db_solarschool.db";

		// Token: 0x040044F2 RID: 17650
		private const string FILE = "d.第二索拉_剧情.xlsx";

		// Token: 0x040044F3 RID: 17651
		private const string TABLE = "SolarSchoolFlow";

		// Token: 0x040044F4 RID: 17652
		private const string COMMAND = "select BinData from `SolarSchoolFlow`";

		// Token: 0x040044F5 RID: 17653
		private const string KEY_PREFIX = "SolarSchoolFlowAll";

		// Token: 0x040044F6 RID: 17654
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044F7 RID: 17655
		private static int HandleId;
	}
}
