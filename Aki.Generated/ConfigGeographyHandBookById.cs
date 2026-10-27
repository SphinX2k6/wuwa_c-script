using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000387 RID: 903
	public class ConfigGeographyHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001530 RID: 5424 RVA: 0x000D1647 File Offset: 0x000CF847
		static ConfigGeographyHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyHandBookById.CreateStaticDefaultValue), new Action(ConfigGeographyHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x000D1668 File Offset: 0x000CF868
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

		// Token: 0x06001532 RID: 5426 RVA: 0x000D16E7 File Offset: 0x000CF8E7
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyHandBookById.LogPair = null;
			ConfigGeographyHandBookById.HandleId = 0;
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x000D16F5 File Offset: 0x000CF8F5
		public static void Init()
		{
			ConfigGeographyHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyHandBookById.HandleId, "db_handbook.db", "select BinData from `GeographyHandBook` where Id=?");
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x000D1710 File Offset: 0x000CF910
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

		// Token: 0x04001895 RID: 6293
		private const string DB = "db_handbook.db";

		// Token: 0x04001896 RID: 6294
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001897 RID: 6295
		private const string TABLE = "GeographyHandBook";

		// Token: 0x04001898 RID: 6296
		private const string COMMAND = "select BinData from `GeographyHandBook` where Id=?";

		// Token: 0x04001899 RID: 6297
		private const string KEY_PREFIX = "GeographyHandBookById";

		// Token: 0x0400189A RID: 6298
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400189B RID: 6299
		private static int HandleId;
	}
}
