using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200015D RID: 349
	public class ConfigChipHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600082F RID: 2095 RVA: 0x00087BCB File Offset: 0x00085DCB
		static ConfigChipHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChipHandBookById.CreateStaticDefaultValue), new Action(ConfigChipHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00087BEC File Offset: 0x00085DEC
		public static void CreateStaticDefaultValue()
		{
			ConfigChipHandBookById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChipHandBookById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChipHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `ChipHandBook` where Id=?")
			});
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00087C6B File Offset: 0x00085E6B
		public static void ResetStaticDefaultValue()
		{
			ConfigChipHandBookById.LogPair = null;
			ConfigChipHandBookById.HandleId = 0;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00087C79 File Offset: 0x00085E79
		public static void Init()
		{
			ConfigChipHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigChipHandBookById.HandleId, "db_handbook.db", "select BinData from `ChipHandBook` where Id=?");
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00087C94 File Offset: 0x00085E94
		public static ChipHandBook? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChipHandBookById.HandleId, ConfigChipHandBookById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChipHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ChipHandBook?(ChipHandBook.GetRootAsChipHandBook(configBuffer));
				}
			}
			ConfigChipHandBookById.LogPair.Clear();
			ConfigChipHandBookById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigChipHandBookById.HandleId, 1, p0Id, ConfigChipHandBookById.LogPair) || ConfigCommon.Step(ConfigChipHandBookById.HandleId, true, ConfigChipHandBookById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChipHandBookById.HandleId, ConfigChipHandBookById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChipHandBookById.HandleId, 0, ConfigChipHandBookById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChipHandBookById.HandleId, ConfigChipHandBookById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChipHandBook rootAsChipHandBook = ChipHandBook.GetRootAsChipHandBook(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChipHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChipHandBookById.HandleId, ConfigChipHandBookById.LogPair);
			return new ChipHandBook?(rootAsChipHandBook);
		}

		// Token: 0x0400096F RID: 2415
		private const string DB = "db_handbook.db";

		// Token: 0x04000970 RID: 2416
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04000971 RID: 2417
		private const string TABLE = "ChipHandBook";

		// Token: 0x04000972 RID: 2418
		private const string COMMAND = "select BinData from `ChipHandBook` where Id=?";

		// Token: 0x04000973 RID: 2419
		private const string KEY_PREFIX = "ChipHandBookById";

		// Token: 0x04000974 RID: 2420
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000975 RID: 2421
		private static int HandleId;
	}
}
