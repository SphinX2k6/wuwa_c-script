using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000891 RID: 2193
	public class ConfigRogueWeeklyParamAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003378 RID: 13176 RVA: 0x0017FE34 File Offset: 0x0017E034
		static ConfigRogueWeeklyParamAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyParamAll.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyParamAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x0017FE54 File Offset: 0x0017E054
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyParamAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyParamAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyParam"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyParam`")
			});
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x0017FED3 File Offset: 0x0017E0D3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyParamAll.LogPair = null;
			ConfigRogueWeeklyParamAll.HandleId = 0;
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x0017FEE1 File Offset: 0x0017E0E1
		public static void Init()
		{
			ConfigRogueWeeklyParamAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyParamAll.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyParam`");
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x0017FEFC File Offset: 0x0017E0FC
		[NullableContext(2)]
		public static IReadOnlyList<RogueWeeklyParam> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyParamAll.HandleId, ConfigRogueWeeklyParamAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueWeeklyParam> readOnlyList = (IReadOnlyList<RogueWeeklyParam>)ConfigCommon.GetConfig("RogueWeeklyParamAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueWeeklyParam> list = new List<RogueWeeklyParam>();
			while (ConfigCommon.Step(ConfigRogueWeeklyParamAll.HandleId, false, ConfigRogueWeeklyParamAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyParamAll.HandleId, 0, ConfigRogueWeeklyParamAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueWeeklyParamAll.HandleId, ConfigRogueWeeklyParamAll.LogPair);
					return null;
				}
				RogueWeeklyParam rootAsRogueWeeklyParam = RogueWeeklyParam.GetRootAsRogueWeeklyParam(new ByteBuffer(item2));
				list.Add(rootAsRogueWeeklyParam);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueWeeklyParamAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyParamAll.HandleId, ConfigRogueWeeklyParamAll.LogPair);
			return list;
		}

		// Token: 0x04003BDD RID: 15325
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003BDE RID: 15326
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003BDF RID: 15327
		private const string TABLE = "RogueWeeklyParam";

		// Token: 0x04003BE0 RID: 15328
		private const string COMMAND = "select BinData from `RogueWeeklyParam`";

		// Token: 0x04003BE1 RID: 15329
		private const string KEY_PREFIX = "RogueWeeklyParamAll";

		// Token: 0x04003BE2 RID: 15330
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BE3 RID: 15331
		private static int HandleId;
	}
}
