using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200000F RID: 15
	public class ConfigAbyssCastDescAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600005A RID: 90 RVA: 0x0005C060 File Offset: 0x0005A260
		static ConfigAbyssCastDescAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssCastDescAll.CreateStaticDefaultValue), new Action(ConfigAbyssCastDescAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0005C080 File Offset: 0x0005A280
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssCastDescAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssCastDescAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssCastDesc"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssCastDesc`")
			});
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0005C0FF File Offset: 0x0005A2FF
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssCastDescAll.LogPair = null;
			ConfigAbyssCastDescAll.HandleId = 0;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0005C10D File Offset: 0x0005A30D
		public static void Init()
		{
			ConfigAbyssCastDescAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssCastDescAll.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssCastDesc`");
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0005C128 File Offset: 0x0005A328
		[NullableContext(2)]
		public static IReadOnlyList<AbyssCastDesc> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssCastDescAll.HandleId, ConfigAbyssCastDescAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssCastDesc> readOnlyList = (IReadOnlyList<AbyssCastDesc>)ConfigCommon.GetConfig("AbyssCastDescAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssCastDesc> list = new List<AbyssCastDesc>();
			while (ConfigCommon.Step(ConfigAbyssCastDescAll.HandleId, false, ConfigAbyssCastDescAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssCastDescAll.HandleId, 0, ConfigAbyssCastDescAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssCastDescAll.HandleId, ConfigAbyssCastDescAll.LogPair);
					return null;
				}
				AbyssCastDesc rootAsAbyssCastDesc = AbyssCastDesc.GetRootAsAbyssCastDesc(new ByteBuffer(item2));
				list.Add(rootAsAbyssCastDesc);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssCastDescAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssCastDescAll.HandleId, ConfigAbyssCastDescAll.LogPair);
			return list;
		}

		// Token: 0x0400004D RID: 77
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x0400004E RID: 78
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x0400004F RID: 79
		private const string TABLE = "AbyssCastDesc";

		// Token: 0x04000050 RID: 80
		private const string COMMAND = "select BinData from `AbyssCastDesc`";

		// Token: 0x04000051 RID: 81
		private const string KEY_PREFIX = "AbyssCastDescAll";

		// Token: 0x04000052 RID: 82
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000053 RID: 83
		private static int HandleId;
	}
}
