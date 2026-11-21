using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200039E RID: 926
	public class ConfigGeographyHandBookByTabType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015BA RID: 5562 RVA: 0x000D7FE4 File Offset: 0x000D61E4
		static ConfigGeographyHandBookByTabType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyHandBookByTabType.CreateStaticDefaultValue), new Action(ConfigGeographyHandBookByTabType.ResetStaticDefaultValue));
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x000D8004 File Offset: 0x000D6204
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

		// Token: 0x060015BC RID: 5564 RVA: 0x000D8083 File Offset: 0x000D6283
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyHandBookByTabType.LogPair = null;
			ConfigGeographyHandBookByTabType.HandleId = 0;
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x000D8091 File Offset: 0x000D6291
		public static void Init()
		{
			ConfigGeographyHandBookByTabType.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyHandBookByTabType.HandleId, "db_handbook.db", "select BinData from `GeographyHandBook` where GeographyTabType=?");
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x000D80AC File Offset: 0x000D62AC
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

		// Token: 0x04001936 RID: 6454
		private const string DB = "db_handbook.db";

		// Token: 0x04001937 RID: 6455
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001938 RID: 6456
		private const string TABLE = "GeographyHandBook";

		// Token: 0x04001939 RID: 6457
		private const string COMMAND = "select BinData from `GeographyHandBook` where GeographyTabType=?";

		// Token: 0x0400193A RID: 6458
		private const string KEY_PREFIX = "GeographyHandBookByTabType";

		// Token: 0x0400193B RID: 6459
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400193C RID: 6460
		private static int HandleId;
	}
}
