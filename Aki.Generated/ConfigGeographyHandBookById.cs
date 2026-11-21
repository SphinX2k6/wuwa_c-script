using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200039D RID: 925
	public class ConfigGeographyHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015B4 RID: 5556 RVA: 0x000D7D9B File Offset: 0x000D5F9B
		static ConfigGeographyHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyHandBookById.CreateStaticDefaultValue), new Action(ConfigGeographyHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000D7DBC File Offset: 0x000D5FBC
		public static void CreateStaticDefaultValue()
		{
			ConfigGeographyHandBookById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGeographyHandBookById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "GeographyHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `GeographyHandBook` where Id=?")
			});
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x000D7E3B File Offset: 0x000D603B
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyHandBookById.LogPair = null;
			ConfigGeographyHandBookById.HandleId = 0;
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x000D7E49 File Offset: 0x000D6049
		public static void Init()
		{
			ConfigGeographyHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyHandBookById.HandleId, "db_handbook.db", "select BinData from `GeographyHandBook` where Id=?");
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x000D7E64 File Offset: 0x000D6064
		public static GeographyHandBook? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGeographyHandBookById.HandleId, ConfigGeographyHandBookById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GeographyHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GeographyHandBook?(GeographyHandBook.GetRootAsGeographyHandBook(configBuffer));
				}
			}
			ConfigGeographyHandBookById.LogPair.Clear();
			ConfigGeographyHandBookById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGeographyHandBookById.HandleId, 1, p0Id, ConfigGeographyHandBookById.LogPair) || ConfigCommon.Step(ConfigGeographyHandBookById.HandleId, true, ConfigGeographyHandBookById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGeographyHandBookById.HandleId, ConfigGeographyHandBookById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGeographyHandBookById.HandleId, 0, ConfigGeographyHandBookById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGeographyHandBookById.HandleId, ConfigGeographyHandBookById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GeographyHandBook rootAsGeographyHandBook = GeographyHandBook.GetRootAsGeographyHandBook(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GeographyHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGeographyHandBookById.HandleId, ConfigGeographyHandBookById.LogPair);
			return new GeographyHandBook?(rootAsGeographyHandBook);
		}

		// Token: 0x0400192F RID: 6447
		private const string DB = "db_handbook.db";

		// Token: 0x04001930 RID: 6448
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001931 RID: 6449
		private const string TABLE = "GeographyHandBook";

		// Token: 0x04001932 RID: 6450
		private const string COMMAND = "select BinData from `GeographyHandBook` where Id=?";

		// Token: 0x04001933 RID: 6451
		private const string KEY_PREFIX = "GeographyHandBookById";

		// Token: 0x04001934 RID: 6452
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001935 RID: 6453
		private static int HandleId;
	}
}
