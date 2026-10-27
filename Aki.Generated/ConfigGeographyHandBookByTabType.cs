using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000388 RID: 904
	public class ConfigGeographyHandBookByTabType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001536 RID: 5430 RVA: 0x000D1890 File Offset: 0x000CFA90
		static ConfigGeographyHandBookByTabType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyHandBookByTabType.CreateStaticDefaultValue), new Action(ConfigGeographyHandBookByTabType.ResetStaticDefaultValue));
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x000D18B0 File Offset: 0x000CFAB0
		public static void CreateStaticDefaultValue()
		{
			ConfigGeographyHandBookByTabType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGeographyHandBookByTabType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "GeographyHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `GeographyHandBook` where GeographyTabType=?")
			});
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x000D192F File Offset: 0x000CFB2F
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyHandBookByTabType.LogPair = null;
			ConfigGeographyHandBookByTabType.HandleId = 0;
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x000D193D File Offset: 0x000CFB3D
		public static void Init()
		{
			ConfigGeographyHandBookByTabType.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyHandBookByTabType.HandleId, "db_handbook.db", "select BinData from `GeographyHandBook` where GeographyTabType=?");
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x000D1958 File Offset: 0x000CFB58
		[NullableContext(2)]
		public static IReadOnlyList<GeographyHandBook> GetConfigList(int p0GeographyTabType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGeographyHandBookByTabType.HandleId, ConfigGeographyHandBookByTabType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GeographyHandBookByTabType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GeographyTabType);
				IReadOnlyList<GeographyHandBook> readOnlyList = (IReadOnlyList<GeographyHandBook>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigGeographyHandBookByTabType.LogPair.Clear();
			ConfigGeographyHandBookByTabType.LogPair.Add(new ValueTuple<string, object>("GeographyTabType", p0GeographyTabType));
			if (!ConfigCommon.BindInt(ConfigGeographyHandBookByTabType.HandleId, 1, p0GeographyTabType, ConfigGeographyHandBookByTabType.LogPair))
			{
				ConfigCommon.Reset(ConfigGeographyHandBookByTabType.HandleId, ConfigGeographyHandBookByTabType.LogPair);
				return null;
			}
			List<GeographyHandBook> list = new List<GeographyHandBook>();
			while (ConfigCommon.Step(ConfigGeographyHandBookByTabType.HandleId, false, ConfigGeographyHandBookByTabType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGeographyHandBookByTabType.HandleId, 0, ConfigGeographyHandBookByTabType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGeographyHandBookByTabType.HandleId, ConfigGeographyHandBookByTabType.LogPair);
					return null;
				}
				GeographyHandBook rootAsGeographyHandBook = GeographyHandBook.GetRootAsGeographyHandBook(new ByteBuffer(item2));
				list.Add(rootAsGeographyHandBook);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GeographyHandBookByTabType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GeographyTabType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigGeographyHandBookByTabType.HandleId, ConfigGeographyHandBookByTabType.LogPair);
			return list;
		}

		// Token: 0x0400189C RID: 6300
		private const string DB = "db_handbook.db";

		// Token: 0x0400189D RID: 6301
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x0400189E RID: 6302
		private const string TABLE = "GeographyHandBook";

		// Token: 0x0400189F RID: 6303
		private const string COMMAND = "select BinData from `GeographyHandBook` where GeographyTabType=?";

		// Token: 0x040018A0 RID: 6304
		private const string KEY_PREFIX = "GeographyHandBookByTabType";

		// Token: 0x040018A1 RID: 6305
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018A2 RID: 6306
		private static int HandleId;
	}
}
