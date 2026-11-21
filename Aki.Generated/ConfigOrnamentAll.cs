using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000648 RID: 1608
	public class ConfigOrnamentAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025C0 RID: 9664 RVA: 0x0013297B File Offset: 0x00130B7B
		static ConfigOrnamentAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOrnamentAll.CreateStaticDefaultValue), new Action(ConfigOrnamentAll.ResetStaticDefaultValue));
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x0013299C File Offset: 0x00130B9C
		public static void CreateStaticDefaultValue()
		{
			ConfigOrnamentAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOrnamentAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ornament.db"),
				new ValueTuple<string, object>("文件", "s.饰品.xlsx"),
				new ValueTuple<string, object>("表名", "Ornament"),
				new ValueTuple<string, object>("语句", "select BinData from `Ornament`")
			});
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x00132A1B File Offset: 0x00130C1B
		public static void ResetStaticDefaultValue()
		{
			ConfigOrnamentAll.LogPair = null;
			ConfigOrnamentAll.HandleId = 0;
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x00132A29 File Offset: 0x00130C29
		public static void Init()
		{
			ConfigOrnamentAll.HandleId = ConfigCommon.InitDataStatement(ConfigOrnamentAll.HandleId, "db_ornament.db", "select BinData from `Ornament`");
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x00132A44 File Offset: 0x00130C44
		[NullableContext(2)]
		public static IReadOnlyList<Ornament> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOrnamentAll.HandleId, ConfigOrnamentAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Ornament> readOnlyList = (IReadOnlyList<Ornament>)ConfigCommon.GetConfig("OrnamentAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<Ornament> list = new List<Ornament>();
			while (ConfigCommon.Step(ConfigOrnamentAll.HandleId, false, ConfigOrnamentAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOrnamentAll.HandleId, 0, ConfigOrnamentAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigOrnamentAll.HandleId, ConfigOrnamentAll.LogPair);
					return null;
				}
				Ornament rootAsOrnament = Ornament.GetRootAsOrnament(new ByteBuffer(item2));
				list.Add(rootAsOrnament);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("OrnamentAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigOrnamentAll.HandleId, ConfigOrnamentAll.LogPair);
			return list;
		}

		// Token: 0x04002BDE RID: 11230
		private const string DB = "db_ornament.db";

		// Token: 0x04002BDF RID: 11231
		private const string FILE = "s.饰品.xlsx";

		// Token: 0x04002BE0 RID: 11232
		private const string TABLE = "Ornament";

		// Token: 0x04002BE1 RID: 11233
		private const string COMMAND = "select BinData from `Ornament`";

		// Token: 0x04002BE2 RID: 11234
		private const string KEY_PREFIX = "OrnamentAll";

		// Token: 0x04002BE3 RID: 11235
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BE4 RID: 11236
		private static int HandleId;
	}
}
