using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000386 RID: 902
	public class ConfigGeographyHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600152A RID: 5418 RVA: 0x000D14B4 File Offset: 0x000CF6B4
		static ConfigGeographyHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyHandBookAll.CreateStaticDefaultValue), new Action(ConfigGeographyHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x000D14D4 File Offset: 0x000CF6D4
		public static void CreateStaticDefaultValue()
		{
			ConfigGeographyHandBookAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGeographyHandBookAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "GeographyHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `GeographyHandBook`")
			});
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x000D1553 File Offset: 0x000CF753
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyHandBookAll.LogPair = null;
			ConfigGeographyHandBookAll.HandleId = 0;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x000D1561 File Offset: 0x000CF761
		public static void Init()
		{
			ConfigGeographyHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyHandBookAll.HandleId, "db_handbook.db", "select BinData from `GeographyHandBook`");
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x000D157C File Offset: 0x000CF77C
		[NullableContext(2)]
		public static IReadOnlyList<GeographyHandBook> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGeographyHandBookAll.HandleId, ConfigGeographyHandBookAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GeographyHandBook> readOnlyList = (IReadOnlyList<GeographyHandBook>)ConfigCommon.GetConfig("GeographyHandBookAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GeographyHandBook> list = new List<GeographyHandBook>();
			while (ConfigCommon.Step(ConfigGeographyHandBookAll.HandleId, false, ConfigGeographyHandBookAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGeographyHandBookAll.HandleId, 0, ConfigGeographyHandBookAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGeographyHandBookAll.HandleId, ConfigGeographyHandBookAll.LogPair);
					return null;
				}
				GeographyHandBook rootAsGeographyHandBook = GeographyHandBook.GetRootAsGeographyHandBook(new ByteBuffer(item2));
				list.Add(rootAsGeographyHandBook);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GeographyHandBookAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGeographyHandBookAll.HandleId, ConfigGeographyHandBookAll.LogPair);
			return list;
		}

		// Token: 0x0400188E RID: 6286
		private const string DB = "db_handbook.db";

		// Token: 0x0400188F RID: 6287
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001890 RID: 6288
		private const string TABLE = "GeographyHandBook";

		// Token: 0x04001891 RID: 6289
		private const string COMMAND = "select BinData from `GeographyHandBook`";

		// Token: 0x04001892 RID: 6290
		private const string KEY_PREFIX = "GeographyHandBookAll";

		// Token: 0x04001893 RID: 6291
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001894 RID: 6292
		private static int HandleId;
	}
}
