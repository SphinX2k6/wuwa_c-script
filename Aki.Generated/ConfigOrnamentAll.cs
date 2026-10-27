using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000630 RID: 1584
	public class ConfigOrnamentAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002530 RID: 9520 RVA: 0x0012BEFF File Offset: 0x0012A0FF
		static ConfigOrnamentAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOrnamentAll.CreateStaticDefaultValue), new Action(ConfigOrnamentAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x0012BF20 File Offset: 0x0012A120
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

		// Token: 0x06002532 RID: 9522 RVA: 0x0012BF9F File Offset: 0x0012A19F
		public static void ResetStaticDefaultValue()
		{
			ConfigOrnamentAll.LogPair = null;
			ConfigOrnamentAll.HandleId = 0;
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x0012BFAD File Offset: 0x0012A1AD
		public static void Init()
		{
			ConfigOrnamentAll.HandleId = ConfigCommon.InitDataStatement(ConfigOrnamentAll.HandleId, "db_ornament.db", "select BinData from `Ornament`");
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x0012BFC8 File Offset: 0x0012A1C8
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

		// Token: 0x04002B36 RID: 11062
		private const string DB = "db_ornament.db";

		// Token: 0x04002B37 RID: 11063
		private const string FILE = "s.饰品.xlsx";

		// Token: 0x04002B38 RID: 11064
		private const string TABLE = "Ornament";

		// Token: 0x04002B39 RID: 11065
		private const string COMMAND = "select BinData from `Ornament`";

		// Token: 0x04002B3A RID: 11066
		private const string KEY_PREFIX = "OrnamentAll";

		// Token: 0x04002B3B RID: 11067
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B3C RID: 11068
		private static int HandleId;
	}
}
