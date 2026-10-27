using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000875 RID: 2165
	public class ConfigRogueWeeklyParamAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032D0 RID: 13008 RVA: 0x00178B4C File Offset: 0x00176D4C
		static ConfigRogueWeeklyParamAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyParamAll.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyParamAll.ResetStaticDefaultValue));
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x00178B6C File Offset: 0x00176D6C
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

		// Token: 0x060032D2 RID: 13010 RVA: 0x00178BEB File Offset: 0x00176DEB
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyParamAll.LogPair = null;
			ConfigRogueWeeklyParamAll.HandleId = 0;
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x00178BF9 File Offset: 0x00176DF9
		public static void Init()
		{
			ConfigRogueWeeklyParamAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyParamAll.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyParam`");
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x00178C14 File Offset: 0x00176E14
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

		// Token: 0x04003B19 RID: 15129
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003B1A RID: 15130
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003B1B RID: 15131
		private const string TABLE = "RogueWeeklyParam";

		// Token: 0x04003B1C RID: 15132
		private const string COMMAND = "select BinData from `RogueWeeklyParam`";

		// Token: 0x04003B1D RID: 15133
		private const string KEY_PREFIX = "RogueWeeklyParamAll";

		// Token: 0x04003B1E RID: 15134
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B1F RID: 15135
		private static int HandleId;
	}
}
